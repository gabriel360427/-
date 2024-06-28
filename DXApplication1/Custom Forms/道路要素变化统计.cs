using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIE.AxControls;
using PIE.Controls;
using PIE.Carto;
using PIE.DataSource;
using PIE.SystemUI;
using PIE.CommonAlgo;
using ESRI.ArcGIS.esriSystem;
using System.Runtime.InteropServices;

namespace 绿廊智绘.Custom_Forms
{
    public partial class 道路要素变化统计 : Form
    {
        public 道路要素变化统计()
        {
            if (!ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.EngineOrDesktop))
            {
                Console.WriteLine("ArcGIS runtime initialization failed.");
                return;
            }
            IAoInitialize aoInit = new AoInitializeClass();
            aoInit.Initialize(esriLicenseProductCode.esriLicenseProductCodeArcServer);
            InitializeComponent();
        }

        private void 第一期道路要素加载按钮_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "打开矢量数据";
            open.Filter = "矢量数据|*.shp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                第一景分类文件框.Text = open.FileName;
            }
        }

        private void 确定_Click(object sender, EventArgs e)
        {
            结果框.Clear();
            StringBuilder sb = new StringBuilder();

            // 替换实际数据
            int firstNonEconomicCount1 = 1000;
            int firstEconomicCount1 = 2000;
            int economicChange = +1000;
            double economicChangePercentage = 200;

            sb.AppendLine("第一期道路要素长度：{firstNonEconomicCount1}");
            sb.AppendLine("第二期道路要素长度：{firstEconomicCount1}");
            sb.AppendLine("道路长度变化：{economicChange}，同比变化{economicChangePercentage}%；");

            // 将内容设置到 RichTextBox
            结果框.Text = sb.ToString();

            //加载第一期数据到第一个地图控件
            string filePath1 = 第一景分类文件框.Text;
            IFeatureDataset fDataset1 = DatasetFactory.OpenFeatureDataset(filePath1);
            if (fDataset1 == null) return;
            // 创建矢量图层
            IFeatureLayer fLayer1 = PIE.Carto.LayerFactory.CreateDefaultFeatureLayer(fDataset1);
            if (fLayer1 == null) return;
            // 添加图层到地图并刷新
            道路mapControl1.FocusMap.AddLayer(fLayer1 as ILayer);
            道路mapControl1.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);

            //加载第二期数据到第二个地图控件
            string filePath2 = 第二景分类文件框.Text; ;
            IFeatureDataset fDataset2 = DatasetFactory.OpenFeatureDataset(filePath2);
            if (fDataset2 == null) return;
            // 创建矢量图层
            IFeatureLayer fLayer2 = PIE.Carto.LayerFactory.CreateDefaultFeatureLayer(fDataset2);
            if (fLayer2 == null) return;
            // 添加图层到地图并刷新
            道路mapControl2.FocusMap.AddLayer(fLayer2 as ILayer);
            道路mapControl2.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);

        }

        private void 取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // 打开文件对话框
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "请选择要打开的数据：";
                openFileDialog.Multiselect = false;
                openFileDialog.InitialDirectory = "";
                openFileDialog.Filter = "Shape Files|*.shp;*.000|Raster Files|*.tif;*.tiff;*.dat;*.bmp;*.img;*.jpg";
                if (openFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
                // 打开文件刷新
                string filePath = openFileDialog.FileName;
                道路mapControl1.FocusMap.AddLayer(PIE.Carto.LayerFactory.CreateDefaultLayer(filePath));
                道路mapControl1.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);

                道路mapControl2.FocusMap.AddLayer(PIE.Carto.LayerFactory.CreateDefaultLayer(filePath));
                道路mapControl2.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);

            }
            catch
            {
                MessageBox.Show("添加图层失败！");
            }
        }

        private void 第二期道路要素加载按钮_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "打开矢量数据";
            open.Filter = "矢量数据|*.shp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                第二景分类文件框.Text = open.FileName;
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (道路mapControl1.FocusMap.LayerCount < 1) return;
            //删除索引为0图层
            ILayer layer1 = 道路mapControl1.ActiveView.FocusMap.GetLayer(0);
            道路mapControl1.ActiveView.FocusMap.DeleteLayer(layer1);
            道路mapControl1.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            int layerCount = 道路mapControl1.FocusMap.LayerCount;
            if (layerCount > 0)
            {
                try
                {
                    //将最下层图层文件移动到最上层
                    道路mapControl1.MoveLayerTo(layerCount - 1, 0);
                    道路mapControl1.PartialRefresh(ViewDrawPhaseType.ViewAll);
                }
                catch
                {
                    MessageBox.Show("移动图层失败！" + e.ToString());
                }
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            ITool tool = new PIE.Controls.PanTool();
            (tool as ICommand).OnCreate(道路mapControl1);
            道路mapControl1.CurrentTool = tool;
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            ICommand cmd = new PIE.Controls.CenterZoomInCommand();
            cmd.OnCreate(道路mapControl1);
            cmd.OnClick();
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            ICommand cmd = new PIE.Controls.CenterZoomOutCommand();
            cmd.OnCreate(道路mapControl1);
            cmd.OnClick();
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            ICommand command = new PIE.Controls.FullExtentCommand();
            command.OnCreate(道路mapControl1);
            command.OnClick();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (道路mapControl2.FocusMap.LayerCount < 1) return;
            //删除索引为0图层
            ILayer layer2 = 道路mapControl2.ActiveView.FocusMap.GetLayer(0);
            道路mapControl2.ActiveView.FocusMap.DeleteLayer(layer2);
            道路mapControl2.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            int layerCount = 道路mapControl2.FocusMap.LayerCount;
            if (layerCount > 0)
            {
                try
                {
                    //将最下层图层文件移动到最上层
                    道路mapControl2.MoveLayerTo(layerCount - 1, 0);
                    道路mapControl2.PartialRefresh(ViewDrawPhaseType.ViewAll);
                }
                catch
                {
                    MessageBox.Show("移动图层失败！" + e.ToString());
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ITool tool = new PIE.Controls.PanTool();
            (tool as ICommand).OnCreate(道路mapControl2);
            道路mapControl2.CurrentTool = tool;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ICommand cmd = new PIE.Controls.CenterZoomInCommand();
            cmd.OnCreate(道路mapControl2);
            cmd.OnClick();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            ICommand cmd = new PIE.Controls.CenterZoomOutCommand();
            cmd.OnCreate(道路mapControl2);
            cmd.OnClick();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            ICommand command = new PIE.Controls.FullExtentCommand();
            command.OnCreate(道路mapControl2);
            command.OnClick();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            第一景分类文件框.Text = "";
            第二景分类文件框.Text = "";
            道路mapControl1.ClearLayers();
            道路mapControl1.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
            道路mapControl2.ClearLayers();
            道路mapControl2.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
            结果框.Clear();
        }
    }
}
