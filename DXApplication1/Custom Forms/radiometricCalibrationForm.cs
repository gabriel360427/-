using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PIE.AxControls;
using PIE.Carto;
using PIE.CommonAlgo;
using 城市空间生态格局智能评估系统;


namespace 城市空间生态格局智能评估系统.Custom_Forms
{
    public partial class radiometricCalibrationForm : DevExpress.XtraEditors.XtraForm
    {
        public radiometricCalibrationForm()
        {
            InitializeComponent();
        }

        void algoEvents_OnExecuteCompleted(PIE.SystemAlgo.ISystemAlgo algo)
        {
            ILayer layer = PIE.Carto.LayerFactory.CreateDefaultLayer(文件输出框.Text);//输出文件
            if (layer == null) { return; }
            //pie1.mapControlMain.ActiveView.FocusMap.AddLayer(layer);
            //pie1.mapControlMain.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
            this.Close();
        }

        public int algoEvents_OnProgressChanged(double complete, string msg, PIE.SystemAlgo.ISystemAlgo algo)
        {
            return Convert.ToInt32(complete);
        }

        //主窗口
        城市空间生态格局智能评估系统.FormMain pie1;
        //全局变量，表示当前输入文件框所选择的序号
        int index = -1;
        private void Form1_Load(object sender, EventArgs e)
        {
            pie1 = (城市空间生态格局智能评估系统.FormMain)this.Owner;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //当选择文件名后更改为改文件路径
            if (index == 文件输入框.SelectedIndex) { return; }
            index = 文件输入框.SelectedIndex;
            文件输入框.Items[index] = pie1.mapControlMain.FocusMap.GetLayer(index).DataSourcePath;
        }

        private void InputDialog_Click(object sender, EventArgs e)//输入进行辐射定标的影像数据
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Title = "打开影像";
            openfiledialog.Filter = "栅格数据|*.tif;*.tiff;*.img;|其他文件|*.*";
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                文件输入框.Text = openfiledialog.FileName;//comboBox1文本框中显示文件名
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MetaDialog_Click(object sender, EventArgs e)//打开元数据文件
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Title = "打开元数据文件";
            openfiledialog.Filter = "原数据文件|*.xml|其他文件|*.*";
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                元数据文件.Text = openfiledialog.FileName;
            }
        }

        private void OutputDialog_Click(object sender, EventArgs e)//保存输出文件
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "保存文件";
            savefile.Filter = "栅格数据|*.tif;*.tiff;*.img;|其他文件|*.*";
            if (savefile.ShowDialog() == DialogResult.OK) 
            {
                文件输出框.Text = savefile.FileName; 
            }
        }

        private void button1_Click(object sender, EventArgs e)//进行辐射定标
        {
            try
            {
                PIE.CommonAlgo.DataPreCali_Exchange_Info info = new PIE.CommonAlgo.DataPreCali_Exchange_Info();
                info.InputFilePath = 文件输入框.Text;
                info.XMLFilePath = 元数据文件.Text;
                info.OutputFilePath = 文件输出框.Text;
                string s = 文件输出框.Text.Substring(文件输出框.Text.LastIndexOf(".")).ToLower();
                if (s == ".tif" | s == ".tiff") { info.FileTypeCode = "GTIFF"; }
                else if (s == ".img") { info.FileTypeCode = "HFA"; }
                else { info.FileTypeCode = "ENVI"; }
                if (ApparentRadiance.Checked) { info.Type = 100; }
                else if (ApparentReflectance.Checked) { info.Type = 200; }
                else { MessageBox.Show("请选择定标类型"); return; }

                PIE.SystemAlgo.ISystemAlgo algo = PIE.SystemAlgo.AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.CalibrationAlgo");
                if (algo == null) return;

                //算法执行
                PIE.SystemAlgo.ISystemAlgoEvents algoEvents = algo as PIE.SystemAlgo.ISystemAlgoEvents;
                algo.Name = "辐射定标";
                algo.Params = info;
                algoEvents.OnProgressChanged += algoEvents_OnProgressChanged;
                algoEvents.OnExecuteCompleted += algoEvents_OnExecuteCompleted;
                PIE.SystemAlgo.AlgoFactory.Instance().AsynExecuteAlgo(algo);

                this.Close();//关闭辐射定标窗口

            }
            catch { MessageBox.Show("文件输入错误！"); }
        }

        private void button2_Click(object sender, EventArgs e)//关闭窗口
        {
            this.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 辐射定标_Load(object sender, EventArgs e)
        {

        }
    }
}
