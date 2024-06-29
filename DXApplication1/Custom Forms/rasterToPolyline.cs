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
using ESRI.ArcGIS.DataManagementTools;
using ESRI.ArcGIS.ConversionTools;

namespace 绿廊智绘.Custom_Forms
{
    public partial class rasterToPolyline : DevExpress.XtraEditors.XtraForm
    {
        public rasterToPolyline()
        {
            InitializeComponent();
        }
        string inpath = "";
        string outpath = "";
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "栅格数据(*.tif)|*.tif";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inpath = openFileDialog.FileName;
                textBox1.Text = openFileDialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog DialogSaveShpPath = new SaveFileDialog();
            DialogSaveShpPath.Title = "保存位置";
            DialogSaveShpPath.Filter = "矢量文件(*.shp) | *.shp";
            DialogSaveShpPath.OverwritePrompt = false;
            if (DialogSaveShpPath.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(DialogSaveShpPath.FileName))
                {
                    MessageBox.Show("文件已存在！");
                    return;
                }
                outpath = DialogSaveShpPath.FileName;
                textBox2.Text = outpath;
            }
        }

        private void 栅格转折线_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Geoprocessor pGeoprocessor = new Geoprocessor();
            try
            {
                RasterToPolyline rtp = new RasterToPolyline();
                rtp.in_raster = inpath;
                rtp.out_polyline_features = outpath;
                rtp.simplify = "SIMPLIFY";
                rtp.background_value = "ZERO";
                IGeoProcessorResult pResult = pGeoprocessor.Execute(rtp, null) as IGeoProcessorResult;
            }
            //在调试的时候，针对工具箱工具用以下代码可以找到参数、环境设置等等问题
            catch (Exception ex)
            {
                object sev = null;
                MessageBox.Show(pGeoprocessor.GetMessages(ref sev));
            }
            MessageBox.Show("栅格转折线执行成功！");
            this.Close();

        }
    }
}
