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
using PIE.DataSource;

namespace 绿廊智绘.Custom_Forms
{
    public partial class CoreAreaExtraction : DevExpress.XtraEditors.XtraForm
    {
        public CoreAreaExtraction()
        {
            InitializeComponent();
        }
        FormMain fm = new FormMain();                          

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "输入栅格文件";
            op.Filter = "栅格文件|*.tif;*.tiff;*.bmp;*.img;*.jpg;*.ldf";
            if (op.ShowDialog() == DialogResult.OK)
            {
                comboBox1.Text = op.FileName;
            }
            else { this.Cursor = Cursors.Default; return; }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "保存矢量数据";
            save.Filter = "矢量数据|*.shp";
            if (save.ShowDialog() == DialogResult.OK)
            {
                comboBox2.Text = save.FileName;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            RasterVectorization_Exchange_Info info = new RasterVectorization_Exchange_Info();
            //info.indexList = new List<int> { 0, 1, 2, 3, 4,5,6,7 };//类别列表
            info.indexList = new List<int> { 0 };
            //info.indexNameList = new List<string> { "Core", "Islet", "Perforation", "Edge", "Loop","Bridge","Branch","Background" };//类别名称列表
            info.indexNameList = new List<string> { "Core" };
            info.isCountPolygonInfo = false;
            info.isSaveAsOneFile = true;//是否保存单个文件 fasle 保存多个文件
            info.pchrasterIndexImgPath = comboBox1.Text;//输入的栅格路径
            //info.pixList = new List<int> { 0, 1, 2, 3, 4,5,6,7 };//类别对应像素列表 和类别列表对应
            info.pixList = new List<int> { 0 };
            info.savingPathList = new List<string> { comboBox2.Text };//保存路径列表：若保存单个文件，一个输出路径即可，若输出多个文件，输出路径即为每一类生成文件路径
            //info.vpixTable = new List<int>(); ;//像素值索引表， 可以设置这个参数，默认是0

            PIE.SystemAlgo.ISystemAlgo algo = PIE.SystemAlgo.AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.RasterToVectorAlgo");
            if (algo == null) return;

            PIE.SystemAlgo.ISystemAlgoEvents algoEvents = algo as PIE.SystemAlgo.ISystemAlgoEvents;
            algo.Name = "核心区提取";
            algo.Params = info;
            bool result = PIE.SystemAlgo.AlgoFactory.Instance().ExecuteAlgo(algo);
            if (result)
            {
                MessageBox.Show("核心区提取成功");
                IList<ILayer> listLayer = LayerFactory.CreateDefaultLayers(info.savingPathList);
                if (listLayer == null) return;
                fm.mapControlMain.ActiveView.FocusMap.AddLayers(listLayer);
                fm.mapControlMain.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 核心区提取_Load(object sender, EventArgs e)
        {

        }
    }
}
