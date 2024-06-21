using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PIE.CommonAlgo;
using PIE.SystemAlgo;
using PIE.DataSource;
using PIE.Carto;

namespace 绿廊智绘.Custom_Forms
{
    public partial class quickMosaicForm : DevExpress.XtraEditors.XtraForm
    {
        public quickMosaicForm()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//输入栅格数据
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "输入栅格文件";
            op.Filter = "栅格文件|*.tif;*.tiff;*.bmp;*.img;*.jpg;*.dat|其他文件|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(op.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)//移除栅格数据
        {
            if (listBox1.SelectedItem == null) { return; }
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)//设置栅格输出路径
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "输出栅格文件";
            savefile.Filter = "栅格文件|*.tif;*.tiff;*.bmp;*.img;*.jpg;*.dat|其他文件|*.*";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                栅格输出框.Text = savefile.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)//执行影像快速拼接
        {
            try
            {
                //影像快速拼接
                buildMosaicFileVec info = new buildMosaicFileVec();
                List<buildMosaicFileInfo> bmfVec = new List<buildMosaicFileInfo>();
                buildMosaicFileInfo item = new buildMosaicFileInfo();
                //设置影像文件
                IList<string> listFile = new List<string>();
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listFile.Add(listBox1.Items[i].ToString());
                }
                int bandCount = 0;
                int count = 0;
                foreach (string file in listFile)
                {
                    //判断拼接的图像的波段数是否一致
                    IRasterDataset tempDataset = DatasetFactory.OpenRasterDataset(file, OpenMode.ReadOnly);
                    if (tempDataset == null)
                    {
                        MessageBox.Show("打开数据集失败！" + file, "提示");
                        return;
                    }
                    if (count == 0)
                    {
                        bandCount = tempDataset.GetBandCount();
                    }
                    else
                    {
                        if (bandCount != tempDataset.GetBandCount())
                        {
                            MessageBox.Show("加入文件波段数不一致！", "提示");
                            (tempDataset as IDisposable).Dispose();
                            tempDataset = null;
                            return;
                        }
                    }
                    count++;
                    IRasterLayer rLayer = LayerFactory.CreateDefaultRasterLayer(tempDataset);
                    item.pSrcLyrs.Add(rLayer);
                }

                item.iOutBandType = 输出类型.SelectedIndex;//输出通道类型
                item.bFastMosaic = true;
                item.sOutFilePath = 栅格输出框.Text;
                bmfVec.Add(item);
                info.bmfVec = bmfVec;
                //创建算法
                ISystemAlgo algo = AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.ImageMosaicParamAlgo");
                if (algo == null) return;
                algo.Params = info;
                bool result = AlgoFactory.Instance().ExecuteAlgo(algo);
                if (result)
                {
                    MessageBox.Show("算法执行成功");
                }
                else {
                    MessageBox.Show("算法执行失败"); 
                }
            }
            catch { MessageBox.Show("请重新设置参数"); }
        }

        //主窗口
       FormMain pie1;
        private void 快速拼接_Load(object sender, EventArgs e)
       {

       }

        private void button5_Click(object sender, EventArgs e)//关闭窗口
        {
            this.Close();
        }
    }
}