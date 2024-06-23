using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geoprocessing;
using ESRI.ArcGIS.Geoprocessor;
using ESRI.ArcGIS.AnalysisTools;
using PIE.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 绿廊智绘.Custom_Forms
{
    public partial class EcologicalNodeExtraction : DevExpress.XtraEditors.XtraForm
    {
        public EcologicalNodeExtraction()
        {
            InitializeComponent();
        }
        #region 定义变量
        IFeatureClass line1 = null;//输入廊道1
        string line11ink = "";
        IFeatureClass line2 = null;//输入廊道2
        string line2link = "";



        string outPath = "";//输出的路径
        #endregion

        #region 封装方法
        /// <summary>
        /// 加载shp的方法
        /// </summary>
        /// <param name="fullpath">shp文件的路径</param>
        /// <returns>返回shp要素类IFeatureClass</returns>
        private IFeatureClass LoadFeaClassFromShp(string fullpath)
        {
            IWorkspaceFactory pWorkspaceFactory = new ShapefileWorkspaceFactory();
            IFeatureWorkspace pFeatureWorkspace;
            int index = fullpath.LastIndexOf("\\");
            string path = fullpath.Substring(0, index);
            string name = fullpath.Substring(index + 1);
            pFeatureWorkspace = pWorkspaceFactory.OpenFromFile(path, 0) as IFeatureWorkspace;
            return pFeatureWorkspace.OpenFeatureClass(name);
        }
        #endregion
        private void 生态节点_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullPath;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "shp数据(*.shp)|*.shp";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fullPath = openFileDialog.FileName;
                line1 = LoadFeaClassFromShp(fullPath);
                textBox1.Text = fullPath;
                line11ink = openFileDialog.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string fullPath;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "shp数据(*.shp)|*.shp";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fullPath = openFileDialog.FileName;
                line2 = LoadFeaClassFromShp(fullPath);
                textBox4.Text = fullPath;
                line2link = openFileDialog.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog DialogSaveShpPath = new SaveFileDialog();
            DialogSaveShpPath.Title = "保存要素类";
            DialogSaveShpPath.Filter = "shp文件(*.shp) | *.shp";
            DialogSaveShpPath.OverwritePrompt = false;
            DialogSaveShpPath.OverwritePrompt = false;
            if (DialogSaveShpPath.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(DialogSaveShpPath.FileName))
                {
                    MessageBox.Show("文件已存在！");
                    return;
                }
                outPath = DialogSaveShpPath.FileName;
                textBox3.Text = outPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //判断文本框下拉框是否为空
            if (textBox1.Text.Trim() == "" || textBox3.Text.Trim() == null || textBox4.Text.Trim() == "")
            {
                MessageBox.Show("请输入正确的信息!");
                return;
            }

            IGpValueTableObject valTbl = new GpValueTableObjectClass();
            valTbl.SetColumns(2);
            object row = "";
            object rank = 1;

            row = line11ink;
            valTbl.SetRow(0, ref row);
            valTbl.SetValue(0, 1, ref rank);

            row = line2link;
            valTbl.SetRow(1, ref row);
            rank = 2;
            valTbl.SetValue(1, 1, ref rank);


            Geoprocessor pGeoprocessor = new Geoprocessor();
            Intersect pcostdistance = new Intersect();
            pcostdistance.in_features = valTbl;
            pcostdistance.out_feature_class = outPath;
            pcostdistance.output_type = "POINT";
            IGeoProcessorResult pResult = pGeoprocessor.Execute(pcostdistance, null) as IGeoProcessorResult;
            MessageBox.Show("成功");
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
