using PIE.Carto;
using PIE.DataSource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIE.Controls;
using PIE.AxControls;
using System.IO;
using PIE.CommonAlgo;
using System.Runtime.InteropServices;
using PIE.Geometry;
using PIE.SystemUI;
using PIE.Display;
using PIE.Utility;

namespace 绿廊智绘.Custom_Forms
{
    public partial class comprehensiveResistance : DevExpress.XtraEditors.XtraForm
    {
        public comprehensiveResistance()
        {
            InitializeComponent();
        }
        //主窗口
        FormMain pie1;
        //全局变量，表示当前输入文件框所选择的序号
        int index = -1;
        int algoEvents_OnProgressChanged(double complete, string msg, PIE.SystemAlgo.ISystemAlgo algo)
        {
            return Convert.ToInt32(complete);
        }
        void algoEvents_OnExecuteCompleted(PIE.SystemAlgo.ISystemAlgo algo)
        {
            MessageBox.Show("综合阻力计算已完成");
            ILayer layer = PIE.Carto.LayerFactory.CreateDefaultLayer(textBox2.Text);
            if (layer == null) { return; }
           // pie1.mapControlMain.ActiveView.FocusMap.AddLayer(layer);
            //pie1.mapControlMain.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "栅格数据|*.tif;*.tiff";
            open.Title = "选择栅格文件";
            open.Multiselect = false;
            if (open.ShowDialog() != DialogResult.OK) return;
            string filePath = open.FileName;

            IRasterDataset dataSet = DatasetFactory.OpenRasterDataset(filePath, OpenMode.ReadOnly);
            if (dataSet == null)
            {
                MessageBox.Show("文件打开失败！");
                return;
            }
            if (!dataSet.Open(filePath, OpenMode.ReadOnly))
            {
                MessageBox.Show("文件打开失败！");
                return;
            }
            this.textBox1.Text = filePath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "栅格影像|*.tiff;*.tif";
            if (saveFile.ShowDialog() != DialogResult.OK) return;

            this.textBox2.Text = saveFile.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region 1、参数设置
            PIE.CommonAlgo.BandOper_Exchange_Info info = new PIE.CommonAlgo.BandOper_Exchange_Info();
            info.StrExp = "b1*0.07+b2*0.05+b3*0.22+b4*0.13+b5*0.24+b6*0.15+b7*0.04+b8*0.1";
            info.SelectFileBands = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            info.SelectFileNames = new List<string> { textBox1.Text, textBox1.Text, textBox1.Text, textBox1.Text, textBox1.Text, textBox1.Text, textBox1.Text, textBox1.Text };
            info.OutputFilePath = textBox2.Text;
            info.FileTypeCode = "GTiff";
            //info.PixelDataType = 6;
            PIE.SystemAlgo.ISystemAlgo algo = PIE.SystemAlgo.AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.BandOperAlgo");
            if (algo == null) return;
            #endregion

            //2、算法执行
            PIE.SystemAlgo.ISystemAlgoEvents algoEvents = algo as PIE.SystemAlgo.ISystemAlgoEvents;
            algo.Name = "波段运算";
            algo.Params = info;
            algoEvents.OnExecuteCompleted += algoEvents_OnExecuteCompleted;
            algoEvents.OnProgressChanged += algoEvents_OnProgressChanged;

            //3、结果显示
            bool result = PIE.SystemAlgo.AlgoFactory.Instance().ExecuteAlgo(algo);
            if (result)
            {
                //MessageBox.Show("波段算法执行成功");

            }
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 植被覆盖度_Load(object sender, EventArgs e)
        {

        }

    }
}
