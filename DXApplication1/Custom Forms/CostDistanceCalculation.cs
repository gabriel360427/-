using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
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
    public partial class CostDistanceCalculation : DevExpress.XtraEditors.XtraForm
    {
        public CostDistanceCalculation()
        {
            InitializeComponent();
        }


        #region 定义变量
        IFeatureClass inFeatureClass = null;//源
        string infeaturelink = "";
        IRasterLayer in_cost_raster = null;//成本栅格
        string inrasterlink = "";
        string outPath = "";//输出的路径
        string outPath1 = "";
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

        //加载源
        private void 成本距离_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fullPath;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "shp数据(*.shp)|*.shp";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fullPath = openFileDialog.FileName;
                inFeatureClass = LoadFeaClassFromShp(fullPath);
                textBox1.Text = fullPath;
                infeaturelink = openFileDialog.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
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
                in_cost_raster = rasterLayer;
                textBox2.Text = openFileDialog.FileName;
                inrasterlink = openFileDialog.FileName;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog DialogSaveShpPath = new SaveFileDialog();
            DialogSaveShpPath.Title = "保存要素类";
            DialogSaveShpPath.Filter = "tiff文件(*.tif) | *.tif";
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

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog DialogSaveShpPath = new SaveFileDialog();
            DialogSaveShpPath.Title = "保存要素类";
            DialogSaveShpPath.Filter = "tiff文件(*.tif) | *.tif";
            DialogSaveShpPath.OverwritePrompt = false;
            DialogSaveShpPath.OverwritePrompt = false;
            if (DialogSaveShpPath.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(DialogSaveShpPath.FileName))
                {
                    MessageBox.Show("文件已存在！");
                    return;
                }
                outPath1 = DialogSaveShpPath.FileName;
                textBox4.Text = outPath1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //判断文本框下拉框是否为空
            if (textBox1.Text.Trim() == "" || textBox3.Text.Trim() == null || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("请输入正确的信息!");
                return;
            }
            // CostDistance1(inFeatureClass, in_cost_raster, outPath);       
            Geoprocessor pGeoprocessor = new Geoprocessor();
            CostDistance pcostdistance = new CostDistance();
            pcostdistance.in_source_data = infeaturelink;
            pcostdistance.in_cost_raster = inrasterlink;
            pcostdistance.out_distance_raster = outPath;
            pcostdistance.out_backlink_raster = outPath1;
            IGeoProcessorResult pResult = pGeoprocessor.Execute(pcostdistance, null) as IGeoProcessorResult;
            MessageBox.Show("成功");
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
