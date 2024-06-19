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
using PIE.Carto;
using PIE.CommonAlgo;
using PIE.SystemAlgo;

namespace 城市空间生态格局智能评估系统.Custom_Forms
{
    public partial class vectorToRasterForm : DevExpress.XtraEditors.XtraForm
    {
        public vectorToRasterForm()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (是否设置无效值.Checked) { 无效值.Enabled = true; }
            else { 无效值.Enabled = false; }
        }
        //主窗口
        FormMain pie1;
        //全局变量，表示当前输入文件框所选择的序号
        int index = -1;
        private void button1_Click(object sender, EventArgs e)//输入待转换的矢量数据
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "输入矢量文件";
            openfile.Filter = "矢量文件|*.shp";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                矢量文件输入框.Text = openfile.FileName;
            }
            try
            {
                ILayer layer1 = LayerFactory.CreateDefaultLayer(矢量文件输入框.Text);
                IFeatureLayer featurelayer1 = layer1 as IFeatureLayer;
                for (int i = 0; i < featurelayer1.FeatureClass.GetFeature(0).GetFieldCount(); i++)
                {
                    选择字段.Items.Add(featurelayer1.FeatureClass.GetFeature(0).GetFieldName(i));
                }
            }
            catch { MessageBox.Show("请选择矢量文件"); }
        }

        

        private void button2_Click(object sender, EventArgs e)//输入基准影像数据
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "输入基准影像";
            openfile.Filter = "基准影像|*.tif;*.tiff;*.bmp;*.img;*.jpg;*.ldf";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                基准影像输入框.Text = openfile.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)//设置输出文件路径
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "输出栅格文件";
            savefile.Filter = "栅格文件|*.tif;*.tiff;*.bmp;*.img;*.jpg;*.ldf";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                栅格输出框.Text = savefile.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)//执行矢量转栅格
        {
            try
            {
                VectorToRaster_Exchange_Info info = new VectorToRaster_Exchange_Info();
                info.strInputFile = 矢量文件输入框.Text;
                info.strOutputFile = 栅格输出框.Text;
                info.nFieldIndex = 矢量文件输入框.SelectedIndex;
                string s = 栅格输出框.Text.Substring(栅格输出框.Text.LastIndexOf(".")).ToLower();
                if (s == ".tif" | s == ".tiff") { info.strOutputFileType = "GTiff"; }
                else if (s == ".img") { info.strOutputFileType = "HFA"; }
                else { info.strOutputFileType = "ENVI"; }
                if (是否设置无效值.Checked)
                {
                    info.bHasNoData = true;
                    info.dbNoData = Convert.ToDouble(无效值.Text);
                }

                if (tabControl1.SelectedIndex == 0)
                {
                    info.bStandardFile = false;
                    info.x = Convert.ToInt32(X.Text);
                    info.y = Convert.ToInt32(Y.Text);
                }
                else if (tabControl1.SelectedIndex == 1)
                {
                    info.bStandardFile = true;
                    info.strStandardFile = 基准影像输入框.Text;
                }

                PIE.SystemAlgo.ISystemAlgo algo = PIE.SystemAlgo.AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.VectorToRasterAlgo");
                if (algo == null) return;

                PIE.SystemAlgo.ISystemAlgoEvents algoEvents = algo as PIE.SystemAlgo.ISystemAlgoEvents;
                algoEvents.OnExecuteCompleted += algoEvents_OnExecuteCompleted;
                algoEvents.OnProgressChanged += algoEvents_OnProgressChanged;
                algo.Name = "矢量化栅格";
                algo.Params = info;
                PIE.SystemAlgo.AlgoFactory.Instance().AsynExecuteAlgo(algo);
            }
            catch { MessageBox.Show("请设置完整参数"); }
        }
        int algoEvents_OnProgressChanged(double complete, string msg, ISystemAlgo algo)
        {
            return Convert.ToInt32(complete);
        }


        void algoEvents_OnExecuteCompleted(ISystemAlgo algo)
        {
            MessageBox.Show("矢量化栅格已完成");
            ILayer layer = PIE.Carto.LayerFactory.CreateDefaultLayer(栅格输出框.Text);
            if (layer == null) { return; }
            pie1.mapControlMain.ActiveView.FocusMap.AddLayer(layer);
            pie1.mapControlMain.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
            this.Close();
        }

        private void 矢量转栅格_Load(object sender, EventArgs e)
        {
            是否设置无效值.Checked = true;
            //主窗口
            pie1 = (FormMain)this.Owner;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //当选择文件名后更改为改文件路径
            if (index == 矢量文件输入框.SelectedIndex) { return; }
            index = 矢量文件输入框.SelectedIndex;
            矢量文件输入框.Items[index] = pie1.mapControlMain.FocusMap.GetLayer(index).DataSourcePath;
            try
            {
                ILayer layer1 = LayerFactory.CreateDefaultLayer(矢量文件输入框.Text);
                IFeatureLayer featurelayer1 = layer1 as IFeatureLayer;
                for (int i = 0; i < featurelayer1.FeatureClass.GetFeature(0).GetFieldCount(); i++)
                {
                    矢量文件输入框.Items.Add(featurelayer1.FeatureClass.GetFeature(0).GetFieldName(i));
                }
            }
            catch { MessageBox.Show("请选择矢量文件"); }
        }

        private void button5_Click(object sender, EventArgs e)//关闭窗口
        {
            this.Close();
        }
    }
}