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
    public partial class CostPathCalculation : DevExpress.XtraEditors.XtraForm
    {
        public CostPathCalculation()
        {
            InitializeComponent();
        }
        #region 定义变量
        IFeatureClass inDeastinationData = null;//输入目标数据
        string inDeastinationDatalink = "";
        IRasterLayer inCostDistanceRaster = null;//输入成本栅格
        string inCostDistanceRasterlink = "";
        IRasterLayer inCostBacklinkRaster = null;//输入成本栅格
        string inCostBacklinkRasterlink = "";
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
        private void 成本路径_Load(object sender, EventArgs e)
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
                inDeastinationData = LoadFeaClassFromShp(fullPath);
                textBox1.Text = fullPath;
                inDeastinationDatalink = openFileDialog.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
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
                inCostDistanceRaster = rasterLayer;
                textBox4.Text = openFileDialog.FileName;
                inCostDistanceRasterlink = openFileDialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
                inCostBacklinkRaster = rasterLayer;
                textBox2.Text = openFileDialog.FileName;
                inCostBacklinkRasterlink = openFileDialog.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog DialogSaveShpPath = new SaveFileDialog();
            DialogSaveShpPath.Title = "保存要素类";
            DialogSaveShpPath.Filter = "tiff文件(*.tif) | *.tif";
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
            Geoprocessor pGeoprocessor = new Geoprocessor();
            try
            {

                CostPath pCostPath = new CostPath();
                pCostPath.in_destination_data = inDeastinationDatalink;
                pCostPath.in_cost_distance_raster = inCostDistanceRasterlink;
                pCostPath.in_cost_backlink_raster = inCostBacklinkRasterlink;
                pCostPath.out_raster = outPath;
                IGeoProcessorResult pResult = pGeoprocessor.Execute(pCostPath, null) as IGeoProcessorResult;
            }
            //在调试的时候，针对工具箱工具用以下代码可以找到参数、环境设置等等问题
            catch (Exception ex)
            {
                object sev = null;
                MessageBox.Show(pGeoprocessor.GetMessages(ref sev));
            }
            MessageBox.Show("成功");
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
