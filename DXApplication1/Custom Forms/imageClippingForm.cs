using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PIE.DataSource;
using PIE.Carto;
using 绿廊智绘;

namespace 绿廊智绘.Custom_Forms
{
    public partial class imageClippingForm : DevExpress.XtraEditors.XtraForm
    {
        public imageClippingForm()
        {
            InitializeComponent();
        }

        //主窗口
        绿廊智绘.FormMain pie1;
        //全局变量，表示当前输入文件框所选择的序号
        int index = -1;

        void algoEvents_OnExecuteCompleted(PIE.SystemAlgo.ISystemAlgo algo)
        {
            ILayer layer = PIE.Carto.LayerFactory.CreateDefaultLayer(文件输出框.Text);//输出文件
            if (layer == null) { return; }
            //pie1.mapControlMain.ActiveView.FocusMap.AddLayer(layer);//将结果加载到图层上
            //pie1.mapControlMain.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);//刷新视图
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //当选择文件名后更改为改文件路径
            if (index == 文件输入框.SelectedIndex) { return; }//输入文件
            index = 文件输入框.SelectedIndex;
            文件输入框.Items[index] = pie1.mapControlMain.FocusMap.GetLayer(index).DataSourcePath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "输入文件";
            openfile.Filter = "图像文件|*.tif;*.tiff;*.img;*.dat|其他文件|*.*";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                文件输入框.Text = openfile.FileName;//输入文件
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "输入矢量文件";
            openfile.Filter = "矢量文件|*.shp";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                矢量文件输入框.Text = openfile.FileName;//输入Shp矢量文件
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //当选择文件名后更改为改文件路径
            if (index == 矢量文件输入框.SelectedIndex) { return; }//输入矢量文件
            index = 矢量文件输入框.SelectedIndex;
            矢量文件输入框.Items[index] = pie1.mapControlMain.FocusMap.GetLayer(index).DataSourcePath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "输出文件";
            savefile.Filter = "图像文件|*.tif;*.tiff;*.img";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                文件输出框.Text = savefile.FileName;//输出文件
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //当选择文件名后更改为改文件路径
            if (index == 文件输出框.SelectedIndex) { return; }//输入矢量文件
            index = 文件输出框.SelectedIndex;
            文件输出框.Items[index] = pie1.mapControlMain.FocusMap.GetLayer(index).DataSourcePath;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //矢量裁剪
            try
            {
                //Clip裁剪
                PIE.CommonAlgo.DataPreImgClip_Exchange_Info info = new PIE.CommonAlgo.DataPreImgClip_Exchange_Info();
                //参数设置 
                info.InputFilePath = 文件输入框.Text;  //待裁剪影像
                info.OutputFilePath = 文件输出框.Text;  //裁剪保存结果
                PIE.DataSource.IRasterDataset rDataset = PIE.DataSource.DatasetFactory.OpenRasterDataset(info.InputFilePath, PIE.DataSource.OpenMode.ReadOnly);
                if (rDataset == null) return;
                int count = rDataset.GetBandCount();
                List<int> list = new List<int> { };
                for (int i = 0; i < count; i++)
                {
                    list.Add(i);
                }
                info.listBands = list;
                info.bInvalidValue = false;
                string s = 文件输出框.Text.Substring(文件输出框.Text.LastIndexOf(".")).ToLower();//输出文件
                if (s == ".tif" | s == ".tiff") { info.FileType = "GTIFF"; }
                else if (s == ".img") { info.FileType = "HFA"; }
                else { info.FileType = "ENVI"; }

                    info.Type = 1;  // (等于1表示使用shape文件裁剪) }
                    info.ShpFilePath = 矢量文件输入框.Text; //裁剪的几何要素
                
                PIE.SystemAlgo.ISystemAlgo algo = PIE.SystemAlgo.AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.ImageClipAlgo");
                if (algo == null) return;

                PIE.SystemAlgo.ISystemAlgoEvents algoEvents = algo as PIE.SystemAlgo.ISystemAlgoEvents;
                algoEvents.OnExecuteCompleted += algoEvents_OnExecuteCompleted;
                algo.Name = "矢量裁剪";
                algo.Params = info;
                PIE.SystemAlgo.AlgoFactory.Instance().AsynExecuteAlgo(algo);
                this.Close();//关闭影像裁剪窗口
            }
            catch
            {
                MessageBox.Show("请重新输入影像和Shp矢量文件！");
            }
        }
    }
}
