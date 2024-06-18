using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PIE.Carto;
using 城市空间生态格局智能评估系统;

namespace 城市空间生态格局智能评估系统.Custom_Forms
{
    public partial class AtmosphericCorrectionCommand : DevExpress.XtraEditors.XtraForm
    {
        public AtmosphericCorrectionCommand()
        {
            InitializeComponent();
        }

        int algoEvents_OnProgressChanged(double complete, string msg, PIE.SystemAlgo.ISystemAlgo algo)
        {
            return Convert.ToInt32(complete);
        }

        void algoEvents_OnExecuteCompleted(PIE.SystemAlgo.ISystemAlgo algo)
        {
            ILayer layer = PIE.Carto.LayerFactory.CreateDefaultLayer(输出文件框.Text);//输出文件
            if (layer == null) { return; }
            //pie1.mapControlMain.ActiveView.FocusMap.AddLayer(layer);
            //pie1.mapControlMain.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
            this.Close();
        }

        //主窗口
        城市空间生态格局智能评估系统.FormMain pie1;
        //全局变量，表示当前输入文件框所选择的序号
        int index = -1;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
 
            //当选择文件名后更改为改文件路径
            if (index == 文件输入框.SelectedIndex) { return; }
            index = 文件输入框.SelectedIndex;
            文件输入框.Items[index] = pie1.mapControlMain.FocusMap.GetLayer(index).DataSourcePath;
        }

        private void button1_Click(object sender, EventArgs e)//输入栅格数据
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "打开文件";
            openfile.Filter = "栅格数据|*.tif;*.tiff;*.img;|其他文件|*.*";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                文件输入框.Text = openfile.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)//输入元数据
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "打开文件";
            openfile.Filter = "原数据文件|*.xml|其他文件|*.*";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                元数据文件.Text = openfile.FileName;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)//当选择文件名后更改为改文件路径
        {
            if (index == 元数据文件.SelectedIndex) { return; }
            index = 元数据文件.SelectedIndex;
            元数据文件.Items[index] = pie1.mapControlMain.FocusMap.GetLayer(index).DataSourcePath;
        }

        private void button3_Click(object sender, EventArgs e)//设置输出路径
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "栅格数据|*.tif;*.tiff;*.img;|其他文件|*.*";
            savefile.FileName = "";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                输出文件框.Text = savefile.FileName;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)//当选择文件名后更改为改文件路径
        {
            if (index == 输出文件框.SelectedIndex) { return; }
            index = 输出文件框.SelectedIndex;
            输出文件框.Items[index] = pie1.mapControlMain.FocusMap.GetLayer(index).DataSourcePath;
        }

        private void button4_Click(object sender, EventArgs e)//进行大气校正
        {
            try
            {
                PIE.CommonAlgo.DataProcess_AtmCor_Info info = new PIE.CommonAlgo.DataProcess_AtmCor_Info();
                info.InputFile = 文件输入框.Text;//输入文件
                info.InputXML = 元数据文件.Text;//元数据
                info.OutputSR = 输出文件框.Text;//输出文件
                info.AtmModel = 大气模式.SelectedIndex;//大气模式
                info.AerosolType = 气溶胶类型.SelectedIndex + 1;//气溶胶类型
                info.InitialVIS = Convert.ToSingle(初始能见度.Text);//初始能见度
                if (是否反演气溶胶.SelectedIndex == 0) { info.AeroRetrieval = 1; }//是否逐像元反演
                else { info.AeroRetrieval = 0; }
                string s = 输出文件框.Text.Substring(输出文件框.Text.LastIndexOf(".")).ToLower();
                if (s == ".tif" | s == ".tiff") { info.FileTypeCode = "GTIFF"; }
                else if (s == ".img") { info.FileTypeCode = "HFA"; }
                else { info.FileTypeCode = "ENVI"; }
                if (DNValue.Checked) { info.DataType = 1; }//数据类型选择：DN值
                else if (ApparentRadiance.Checked) { info.DataType = 2; }//表观辐亮度
                else if (ApparentReflectance.Checked) { info.DataType = 3; }//表观反射率
                else { MessageBox.Show("请选择数据类型"); return; }

                PIE.SystemAlgo.ISystemAlgo algo = PIE.SystemAlgo.AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.AtmosphericCorrectionAlgo");
                if (algo == null) return;

                //算法执行
                PIE.SystemAlgo.ISystemAlgoEvents algoEvents = algo as PIE.SystemAlgo.ISystemAlgoEvents;
                algoEvents.OnExecuteCompleted += algoEvents_OnExecuteCompleted;
                algoEvents.OnProgressChanged += algoEvents_OnProgressChanged;
                algo.Name = "大气校正";
                algo.Params = info;
                PIE.SystemAlgo.AlgoFactory.Instance().AsynExecuteAlgo(algo);

                this.Close();//关闭辐射定标窗口
            }
            catch { MessageBox.Show("请重新输入数据及完成全部参数设置！"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 大气校正_Load(object sender, EventArgs e)
        {

        }

        private void 大气模式_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
