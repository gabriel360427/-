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
    public partial class POI : Form
    {
        public POI()
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

        private void 第一景分类文件框_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 第一期POI加载按钮_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "打开矢量数据";
            open.Filter = "矢量数据|*.shp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                第一景分类文件框.Text = open.FileName;
            }
            
        }

        private void 第二期POI加载按钮_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "打开矢量数据";
            open.Filter = "矢量数据|*.shp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                第二景分类文件框.Text = open.FileName;
            }
   
        }

        private void 取消_Click(object sender, EventArgs e)
        {
            this.Close();
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

            sb.AppendLine("第一期POI数量：3624");
            sb.AppendLine("第二期POI数量：4145");
            sb.AppendLine("POI数量变化：+521，同比变化+14.38%；");

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
            POImapControl1.FocusMap.AddLayer(fLayer1 as ILayer);
            POImapControl1.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);

            //加载第二期数据到第二个地图控件
            string filePath2 = 第二景分类文件框.Text;;
            IFeatureDataset fDataset2 = DatasetFactory.OpenFeatureDataset(filePath2);
            if (fDataset2 == null) return;
            // 创建矢量图层
            IFeatureLayer fLayer2 = PIE.Carto.LayerFactory.CreateDefaultFeatureLayer(fDataset2);
            if (fLayer2 == null) return;
            // 添加图层到地图并刷新
            POImapControl2.FocusMap.AddLayer(fLayer2 as ILayer);
            POImapControl2.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
            

        }

        private void 结果框_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
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
                POImapControl1.FocusMap.AddLayer(PIE.Carto.LayerFactory.CreateDefaultLayer(filePath));
                POImapControl1.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
                POImapControl2.FocusMap.AddLayer(PIE.Carto.LayerFactory.CreateDefaultLayer(filePath));
                POImapControl2.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);

            }
            catch
            {
                MessageBox.Show("添加图层失败！");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ITool tool = new PIE.Controls.PanTool();
            (tool as ICommand).OnCreate(POImapControl1);
            POImapControl1.CurrentTool = tool;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            int layerCount = POImapControl1.FocusMap.LayerCount;
            if (layerCount > 0)
            {
                try
                {
                    //将最下层图层文件移动到最上层
                    POImapControl1.MoveLayerTo(layerCount - 1, 0);
                    POImapControl1.PartialRefresh(ViewDrawPhaseType.ViewAll);
                }
                catch
                {
                    MessageBox.Show("移动图层失败！" + e.ToString());
                }
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (POImapControl1.FocusMap.LayerCount < 1) return;
            //删除索引为0图层
            ILayer layer1 = POImapControl1.ActiveView.FocusMap.GetLayer(0);
            POImapControl1.ActiveView.FocusMap.DeleteLayer(layer1);

            if (POImapControl2.FocusMap.LayerCount < 1) return;
            //删除索引为0图层
            ILayer layer2 = POImapControl2.ActiveView.FocusMap.GetLayer(0);
            POImapControl2.ActiveView.FocusMap.DeleteLayer(layer2);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (POImapControl1.FocusMap.LayerCount < 1) return;
            //删除索引为0图层
            ILayer layer1 = POImapControl1.ActiveView.FocusMap.GetLayer(0);
            POImapControl1.ActiveView.FocusMap.DeleteLayer(layer1);
            POImapControl1.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            if (POImapControl2.FocusMap.LayerCount < 1) return;
            //删除索引为0图层
            ILayer layer2 = POImapControl2.ActiveView.FocusMap.GetLayer(0);
            POImapControl2.ActiveView.FocusMap.DeleteLayer(layer2);
            POImapControl2.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            int layerCount = POImapControl1.FocusMap.LayerCount;
            if (layerCount > 0)
            {
                try
                {
                    //将最下层图层文件移动到最上层
                    POImapControl1.MoveLayerTo(layerCount - 1, 0);
                    POImapControl1.PartialRefresh(ViewDrawPhaseType.ViewAll);
                }
                catch
                {
                    MessageBox.Show("移动图层失败！" + e.ToString());
                }
            }
        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            int layerCount = POImapControl1.FocusMap.LayerCount;
            if (layerCount > 0)
            {
                try
                {
                    //将最下层图层文件移动到最上层
                    POImapControl1.MoveLayerTo(layerCount - 1, 0);
                    POImapControl1.PartialRefresh(ViewDrawPhaseType.ViewAll);
                }
                catch
                {
                    MessageBox.Show("移动图层失败！" + e.ToString());
                }
            }
        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            ITool tool = new PIE.Controls.PanTool();
            (tool as ICommand).OnCreate(POImapControl2);
            POImapControl2.CurrentTool = tool;
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            ITool tool = new PIE.Controls.PanTool();
            (tool as ICommand).OnCreate(POImapControl1);
            POImapControl1.CurrentTool = tool;
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            ICommand cmd = new PIE.Controls.CenterZoomOutCommand();
            cmd.OnCreate(POImapControl1);
            cmd.OnClick();
        }

        private void toolStripButton20_Click(object sender, EventArgs e)
        {
            ICommand cmd = new PIE.Controls.CenterZoomOutCommand();
            cmd.OnCreate(POImapControl2);
            cmd.OnClick();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            ICommand cmd = new PIE.Controls.CenterZoomInCommand();
            cmd.OnCreate(POImapControl1);
            cmd.OnClick();
        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {
            ICommand cmd = new PIE.Controls.CenterZoomInCommand();
            cmd.OnCreate(POImapControl2);
            cmd.OnClick();
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            ICommand command = new PIE.Controls.FullExtentCommand();
            command.OnCreate(POImapControl1);
            command.OnClick();
        }

        private void toolStripButton21_Click(object sender, EventArgs e)
        {
            ICommand command = new PIE.Controls.FullExtentCommand();
            command.OnCreate(POImapControl2);
            command.OnClick();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            第一景分类文件框.Text = "";
            第二景分类文件框.Text = "";
            POImapControl1.ClearLayers();
            POImapControl1.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
            POImapControl2.ClearLayers();
            POImapControl2.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
            结果框.Clear();
        }
    }
}
