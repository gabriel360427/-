using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PIE.DataSource;
using PIE.CommonAlgo;

namespace 绿廊智绘.Custom_Forms
{
    public partial class BandSynthesisForm : DevExpress.XtraEditors.XtraForm
    {
        public BandSynthesisForm()
        {
            InitializeComponent();
        }
        //主窗口
        绿廊智绘.FormMain pie1;
        //全局变量，表示当前输入文件框所选择的序号
        int index = -1;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)//设置输出文件路径
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "输出栅格文件";
            savefile.Filter = "栅格文件|*.tif;*.tiff;*.img;|其他文件|*.*";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                输出文件框.Text = savefile.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)//加载栅格数据
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "输入栅格文件";
            op.Filter = "栅格文件|*.tif;*.tiff;*.bmp;*.img;*.jpg;*.jpeg;*.sid;*.lan|其他文件|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                输入文件.Items.Add(op.FileName);//输入文件
            }
        }

        private void button2_Click(object sender, EventArgs e)//波段上移
        {
            if (输入文件.SelectedItem == null | 输入文件.SelectedIndex == 0) { return; }
            输入文件.Items.Insert(输入文件.SelectedIndex + 1, 输入文件.Items[输入文件.SelectedIndex - 1]);
            输入文件.Items.Remove(输入文件.Items[输入文件.SelectedIndex - 1]);
        }

        private void button3_Click(object sender, EventArgs e)//波段下移
        {
            if (输入文件.SelectedItem == null | 输入文件.SelectedIndex == 输入文件.Items.Count - 1) { return; }
            输入文件.Items.Insert(输入文件.SelectedIndex + 2, 输入文件.SelectedItem);
            输入文件.Items.Remove(输入文件.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)//移除波段
        {
            if (输入文件.SelectedItem == null) { return; }
            输入文件.Items.Remove(输入文件.Items[输入文件.SelectedIndex]);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //当选择文件名后更改为改文件路径
            if (index == 输出文件框.SelectedIndex) { return; }
            index = 输出文件框.SelectedIndex;
            输出文件框.Items[index] = pie1.mapControlMain.FocusMap.GetLayer(index).DataSourcePath;
        }

        private void button6_Click(object sender, EventArgs e)//进行波段合成
        {
            try
            {
                PIE.CommonAlgo.BandCombination_Exchange_Info info = new PIE.CommonAlgo.BandCombination_Exchange_Info();
                List<IRasterDataset> rDatasets = new List<IRasterDataset>();
                List<List<int>> lists = new List<List<int>>();
                List<Interestregion> interestregions = new List<Interestregion>();
                for (int i = 0; i < 输入文件.Items.Count; i++)
                {
                    //将listbox的文件路径名转为栅格数据集
                    string path = 输入文件.Items[i].ToString();
                    IRasterDataset rDataset = DatasetFactory.OpenDataset(path, OpenMode.ReadOnly) as IRasterDataset;
                    rDatasets.Add(rDataset);

                    //将listbox的文件路径名的各个文件波段序列进行连接
                    List<int> list = new List<int>();
                    int bandcount = rDataset.GetBandCount();
                    for (int b = 0; b < bandcount; b++)
                    {
                        list.Add(b);
                    }
                    lists.Add(list);
                    //设置范围
                    Interestregion interestregion = new Interestregion();
                    interestregion.SetRegion(0, 0, rDataset.GetRasterYSize(), rDataset.GetRasterXSize());
                    interestregions.Add(interestregion);
                }

                info.regioninfo = interestregions;
                info.m_iOutRangeCrossType = 0;

                info.m_vecFileptr = rDatasets;
                info.bands = lists;
                info.tstrfile = 输出文件框.Text;
                string s = 输出文件框.Text.Substring(输出文件框.Text.LastIndexOf(".")).ToLower();
                if (s == ".tif" | s == ".tiff") { info.m_strFileTypeCode = "GTIFF"; }
                else if (s == ".img") { info.m_strFileTypeCode = "HFA"; }
                else { info.m_strFileTypeCode = "ENVI"; }

                PIE.SystemAlgo.ISystemAlgo algo = PIE.SystemAlgo.AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.BandCombinationAlgo");
                if (algo == null) return;

                PIE.SystemAlgo.ISystemAlgoEvents algoEvents = algo as PIE.SystemAlgo.ISystemAlgoEvents;
                algo.Name = "波段合成";
                algo.Params = info;
                bool result = PIE.SystemAlgo.AlgoFactory.Instance().ExecuteAlgo(algo);
                if (result)
                {
                    MessageBox.Show("算法执行成功！"); this.Close();
                } else { MessageBox.Show("算法执行失败！"); }
            }
            catch { MessageBox.Show("请输入文件数据！"); }
        }

        private void button7_Click(object sender, EventArgs e)//取消，关闭窗口
        {
            this.Close();
        }
    }
}
