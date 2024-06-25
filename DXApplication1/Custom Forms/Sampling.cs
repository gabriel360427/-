using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geoprocessing;
using ESRI.ArcGIS.Geoprocessor;
using ESRI.ArcGIS.SpatialAnalystTools;
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
    public partial class Sampling : DevExpress.XtraEditors.XtraForm
    {
        public Sampling()
        {
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.EngineOrDesktop);
            InitializeComponent();
        }

        #region 定义变量
        IFeatureClass infeaturedata = null;//输入目标数据
        string infeaturepath = "";
        IRasterLayer inRaster = null;//输入成本栅格
        string inRasterpath = "";
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


        private void 采样_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "tiff数据(*.tif)|*.tif";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string Filename = System.IO.Path.GetFileName(openFileDialog.FileName);
                string Parhname = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
                IRasterLayer rasterLayer = new RasterLayerClass();
                rasterLayer.CreateFromFilePath(openFileDialog.FileName);
                inRaster = rasterLayer;
                textBox1.Text = openFileDialog.FileName;
                inRasterpath = openFileDialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fullPath;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "shp数据(*.shp)|*.shp";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fullPath = openFileDialog.FileName;
                infeaturedata = LoadFeaClassFromShp(fullPath);
                textBox2.Text = fullPath;
                infeaturepath = fullPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog DialogSaveShpPath = new SaveFileDialog();
            DialogSaveShpPath.Title = "保存要素类";
            DialogSaveShpPath.Filter = "DBF文件(*.dbf) | *.dbf";
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

        private void button4_Click(object sender, EventArgs e)
        {
            Geoprocessor pGeoprocessor = new Geoprocessor();
            try
            {

                Sample psample = new Sample();
                psample.in_rasters = inRasterpath;
                psample.in_location_data = infeaturepath;
                psample.out_table = outPath;
                psample.resampling_type = "NEAREST";
                IGeoProcessorResult pResult = pGeoprocessor.Execute(psample, null) as IGeoProcessorResult;
            }
            //在调试的时候，针对工具箱工具用以下代码可以找到参数、环境设置等等问题
            catch (Exception ex)
            {
                object sev = null;
                MessageBox.Show(pGeoprocessor.GetMessages(ref sev));
            }
            MessageBox.Show("成功执行，请将DBF表在Excel中转为xls格式");
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
