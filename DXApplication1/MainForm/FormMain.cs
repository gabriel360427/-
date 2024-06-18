using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PIE.AxControls;
using PIE.Carto;
using PIE.Controls;
using PIE.CommonAlgo;
using PIE.DataSource;
using PIE.Display;
using PIE.Geometry;
using PIE.SystemAlgo;
using PIE.SystemUI;
using PIE.Utility;
using 城市空间生态格局智能评估系统.Custom_Commands;
using 城市空间生态格局智能评估系统.Custom_Tools;
using 城市空间生态格局智能评估系统.Custom_Forms;

namespace 城市空间生态格局智能评估系统
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            //地图和制图绑定，图层树和制图绑定
            mapControlMain.FocusMap = pageLayoutControlMain.FocusMap;
            tocControlMain.SetBuddyControl(pageLayoutControlMain as IPmdContents);
            pageLayoutControlMain.DeActivate();
            mapControlMain.Activate();

            //绑定MapControl右键菜单Command
            FullExtentToolStripMenuItem.Tag = new FullExtentCommand();
            RasterIdentifyToolStripMenuItem.Tag = new RasterIdentifyTool();
            tocControlMain.SetBuddyControl(mapControlMain as PIE.Carto.IPmdContents);

            //地图监听事件
            IActiveViewEvents activeViewEvents = mapControlMain.FocusMap as PIE.Carto.IActiveViewEvents;
            activeViewEvents.OnLayerDeleted += MapControl_OnLayerDeleted;//图层删除事件
            
        }

        #region 地图模式制图模式
        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedIndex == 0)//地图模式
            {
                ActiveMapControl();
            }
            else if (tabControlMain.SelectedIndex == 1)//制图模式
            {
                ActivePagelayoutControl();
            }
        }
        /// <summary>
        /// 激活地图模式
        /// </summary>
        private void ActiveMapControl()
        {
            pageLayoutControlMain.DeActivate();
            mapControlMain.Activate();
            mapControlMain.PartialRefresh(ViewDrawPhaseType.ViewAll);
        }

        /// <summary>
        /// 激活制图模式
        /// </summary>
        private void ActivePagelayoutControl()
        {
            mapControlMain.DeActivate();
            pageLayoutControlMain.Activate();
            pageLayoutControlMain.PartialRefresh(ViewDrawPhaseType.ViewAll);
        }
        #endregion

        #region mapControlMain右击事件
        private void mapControlMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip_MapControl.Show(mapControlMain, new System.Drawing.Point(e.X, e.Y));
            }
        }
        private void mapControlMenuItem_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) return;

            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item == null) return;

            ICommand command = item.Tag as ICommand;
            if (command == null) return;
            command.OnCreate(mapControlMain); //必须加
            command.OnClick();

            ITool tool = command as ITool;
            if (tool != null)
            {
                mapControlMain.CurrentTool = tool;
            }
        }
        #endregion

        #region tocControlMain右击事件
        //TOCControlMain右击事件
        private ILayer m_Layer = null;//鼠标点击的图层
        private void tocControlMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)//右键
            {
                IMap pMap = null;
                m_Layer = null;
                PIETOCNodeType nodeType = PIETOCNodeType.Null;
                object unk = null;
                object data = null;

                this.tocControlMain.HitTest(e.X, e.Y, ref nodeType, ref pMap, ref m_Layer, ref unk, ref data);
                this.contextMenuStrip_TocControl.Show(this.tocControlMain, new System.Drawing.Point(e.X, e.Y));//右键菜单显示
            }
        }
        //删除图层
        private void DeleteLayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICommand cmd = new DeleteLayerCommand();
            cmd.OnCreate(mapControlMain);
            cmd.OnClick();
        }
        //打开属性表
        private void FeatureLayerAttributeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICommand cmd = new FeatureLayerAttributeCommand();
            cmd.OnCreate(mapControlMain);
            cmd.OnClick();
        }
        //符号选择器
        private void SymbolSelectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SymbolSelectorDialog symbolSelectDialog = new SymbolSelectorDialog();
            //1获取要操作的图层，鼠标选中的图层
            IMap map = mapControlMain.FocusMap;
            IFeatureLayer featureLayer = m_Layer as IFeatureLayer;

            GeometryType geoType = featureLayer.FeatureClass.GetGeomType();
            ISymbol currentSymbol = null;

            switch (geoType)
            {
                case GeometryType.GeometryPoint:
                    currentSymbol = new SimpleMarkerSymbol();
                    break;
                case GeometryType.GeometryPolygon:
                    currentSymbol = new SimpleFillSymbol();
                    break;
                case GeometryType.GeometryPolyline:
                    currentSymbol = new SimpleLineSymbol();
                    break;
                case GeometryType.GeometryUnknown:
                    break;
                default:
                    break;
            }
            if (currentSymbol != null)
            {
                //3.对话框显示当前图层的类型符号
                symbolSelectDialog.Symbol = currentSymbol;
                if (symbolSelectDialog.ShowDialog() != 1) return;//判断ok还是取消

                //4.将选中的符号进行渲染
                ISymbol selectSymbol = symbolSelectDialog.Symbol;
                //IFeatureRender featureRender = featureLayer.Render;
                IFeatureUniqueValueRender render = new FeatureUniqueValueRender();
                render.DefaultSymbol = selectSymbol;
                featureLayer.Render = render as IFeatureRender;
                mapControlMain.PartialRefresh(ViewDrawPhaseType.ViewAll);
            }
        }
        //层属性
        private void LayerPropertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICommand cmd = new LayerPropertyCommand();
            cmd.OnCreate(mapControlMain);
            cmd.OnClick();
        }
        #endregion

        #region 工具栏 地图模式
        private void zoomIn3_Click(object sender, EventArgs e)
        {
            ITool tool = new PIE.Controls.MapZoomInTool();
            (tool as ICommand).OnCreate(mapControlMain);
            mapControlMain.CurrentTool = tool;
        }
        private void zoomOut3_Click(object sender, EventArgs e)
        {
            ITool tool = new PIE.Controls.MapZoomOutTool();
            (tool as ICommand).OnCreate(mapControlMain);
            mapControlMain.CurrentTool = tool;
        }
        private void zoomToOrigin3_Click_1(object sender, EventArgs e)
        {
            ICommand cmd = new PIE.Controls.ZoomToNativeCommand();
            cmd.OnCreate(mapControlMain);
            cmd.OnClick();
        }
        private void centerZoomIn1_Click(object sender, EventArgs e)
        {
            ICommand cmd = new PIE.Controls.CenterZoomInCommand();
            cmd.OnCreate(mapControlMain);
            cmd.OnClick();
        }
        private void centerZoomOut1_Click(object sender, EventArgs e)
        {
            ICommand cmd = new PIE.Controls.CenterZoomOutCommand();
            cmd.OnCreate(mapControlMain);
            cmd.OnClick();
        }
        private void fullExtent3_Click(object sender, EventArgs e)
        {
            ICommand command = new PIE.Controls.FullExtentCommand();
            command.OnCreate(mapControlMain);
            command.OnClick();
        }
        private void panTool3_Click(object sender, EventArgs e)
        {
            ITool tool = new PIE.Controls.PanTool();
            (tool as ICommand).OnCreate(mapControlMain);
            mapControlMain.CurrentTool = tool;
        }
        private void elementSelect2_Click(object sender, EventArgs e)
        {
            ITool tool = new PIE.Controls.ElementSelectTool();
            (tool as ICommand).OnCreate(mapControlMain);
            mapControlMain.CurrentTool = tool;
        }
        private void swipeLayer_Click(object sender, EventArgs e)
        {
            ITool tool = new PIE.Controls.SwipeLayerTool();
            (tool as ICommand).OnCreate(mapControlMain);
            mapControlMain.CurrentTool = tool;
        }
        #endregion

        #region 工具栏 制图模式
        private void zoomIn4_Click(object sender, EventArgs e)
        {
            ITool tool = new PIE.Controls.MapZoomInTool();
            (tool as ICommand).OnCreate(pageLayoutControlMain);
            pageLayoutControlMain.CurrentTool = tool;
        }
        private void zoomOut4_Click(object sender, EventArgs e)
        {
            ITool tool = new PIE.Controls.MapZoomOutTool();
            (tool as ICommand).OnCreate(pageLayoutControlMain);
            pageLayoutControlMain.CurrentTool = tool;
        }
        private void zoomToOrigin4_Click(object sender, EventArgs e)
        {
            ICommand cmd = new PIE.Controls.ZoomToNativeCommand();
            cmd.OnCreate(pageLayoutControlMain);
            cmd.OnClick();
        }
        private void centerZoomIn2_Click(object sender, EventArgs e)
        {
            ICommand cmd = new PIE.Controls.CenterZoomInCommand();
            cmd.OnCreate(pageLayoutControlMain);
            cmd.OnClick();
        }
        private void centerZoomOut2_Click_1(object sender, EventArgs e)
        {
            ICommand cmd = new PIE.Controls.CenterZoomOutCommand();
            cmd.OnCreate(pageLayoutControlMain);
            cmd.OnClick();
        }
        private void fullExtent4_Click(object sender, EventArgs e)
        {
            ICommand command = new PIE.Controls.FullExtentCommand();
            command.OnCreate(pageLayoutControlMain);
            command.OnClick();
        }
        private void panTool4_Click(object sender, EventArgs e)
        {
            ITool tool = new PIE.Controls.PanTool();
            (tool as ICommand).OnCreate(pageLayoutControlMain);
            pageLayoutControlMain.CurrentTool = tool;
        }
        private void elementSelect3_Click(object sender, EventArgs e)
        {
            ITool tool = new PIE.Controls.ElementSelectTool();
            (tool as ICommand).OnCreate(pageLayoutControlMain);
            pageLayoutControlMain.CurrentTool = tool;
        }

        #endregion

        #region 地图监听事件
        private void MapControl_OnLayerDeleted(ILayer layer)
        {
            string str = string.Format("删除{0}图层", layer.Name);
            MessageBox.Show(str, "提示");
        }
        #endregion

        #region 一、基础功能

        #region 1. 地图工程

        #region 1.1 新建工程
        /// <summary>
        /// 新建地图工程
        /// </summary>
        private void newProject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewProject();
        }
        private void NewProject()
        {
            IMapDocument mapDocument = new MapDocument();
            DialogResult resultType = MessageBox.Show("是否保存当前地图工程", "新建地图工程", MessageBoxButtons.YesNoCancel);
            if (resultType == DialogResult.Cancel)
            {
                return;
            }
            else if (resultType == DialogResult.Yes)
            {
                // 获得保存路径信息
                string pmdFilePath = mapDocument.GetDocumentFilename();
                if (string.IsNullOrEmpty(pmdFilePath))
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Title = "地图文档另存为：";
                    saveFileDialog.Filter = "PMD|*.pmd";
                    saveFileDialog.InitialDirectory = @"C:\Users\Administrator\Desktop\黄河故道生态富民廊道\演示工程";
                    if (saveFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
                    pmdFilePath = saveFileDialog.FileName;
                    if (string.IsNullOrEmpty(pmdFilePath)) return;
                }
                if (!pmdFilePath.EndsWith(".pmd"))
                {
                    pmdFilePath = pmdFilePath + ".pmd";
                }
                mapDocument.SaveAs(pmdFilePath, true, true);
            }

            IMapDocument newMapDocument = new MapDocument();
            newMapDocument.New("");  //新建地图工程文档

            // 为PageLayoutControl设置PageLayout
            IPageLayout newPageLayout = newMapDocument.GetPageLayout();
            pageLayoutControlMain.PageLayout = newPageLayout;

            // 为MapControl设置Map
            IMap newMap = (newPageLayout as IActiveView).FocusMap;
            mapControlMain.FocusMap = newMap;

            if (tabControlMain.SelectedIndex == 0)
            {
                // 刷新
                ActivateMapControl();
            }
            else if (tabControlMain.SelectedIndex == 1)
            {
                // 刷新
                ActivatePageLayoutControl();
            }
        }
        /// <summary>
        /// 激活地图模式
        /// </summary>
        private void ActivateMapControl()
        {
            pageLayoutControlMain.DeActivate();
            mapControlMain.Activate();
            //刷新地图
            mapControlMain.PartialRefresh(ViewDrawPhaseType.ViewAll);
        }
        /// <summary>
        /// 激活制图模式
        /// </summary>
        private void ActivatePageLayoutControl()
        {
            mapControlMain.DeActivate();
            pageLayoutControlMain.Activate();
            //刷新地图
            pageLayoutControlMain.PartialRefresh(ViewDrawPhaseType.ViewAll);
        }
        #endregion

        #region 1.2 打开工程
        /// <summary>
        /// 打开地图工程
        /// </summary>
        private void openProject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenProject();
        }
        private void OpenProject()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "请选择要打开的地图文档：";
            openFileDialog.Multiselect = false;
            openFileDialog.InitialDirectory = @"C:\Users\Administrator\Desktop\黄河故道生态富民廊道\演示工程";
            openFileDialog.Filter = "PMD(.pmd) |*.pmd";
            if (openFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            string pmdNewFilePath = openFileDialog.FileName;
            if (string.IsNullOrEmpty(pmdNewFilePath)) return;

            IMapDocument newMapDocument = new MapDocument();
            newMapDocument.Open(pmdNewFilePath);

            // 为PageLayoutControl设置PageLayout
            IPageLayout newPageLayout = newMapDocument.GetPageLayout();
            pageLayoutControlMain.PageLayout = newPageLayout;

            // 为MapControl设置Map
            IMap newMap = (newPageLayout as IActiveView).FocusMap;
            mapControlMain.FocusMap = newMap;

            if (tabControlMain.SelectedIndex == 0)
            {
                // 刷新
                pageLayoutControlMain.DeActivate();
                mapControlMain.Activate();
                mapControlMain.PartialRefresh(ViewDrawPhaseType.ViewAll);
            }
            else
            {
                // 刷新
                mapControlMain.DeActivate();
                pageLayoutControlMain.Activate();
                pageLayoutControlMain.PartialRefresh(ViewDrawPhaseType.ViewAll);
            }
        }
        #endregion
        
        #region 1.3 保存工程
        /// <summary>
        /// 保存地图工程
        /// </summary>
        private void saveProject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveProject();
        }
        private void SaveProject()
        {
            IMapDocument mapDocument = (pageLayoutControlMain as Control).Tag as IMapDocument;
            if (mapDocument == null)
            {
                mapDocument = new MapDocument();
                mapDocument.ReplaceContents(pageLayoutControlMain);
            }
            string pmdFilePath = mapDocument.GetDocumentFilename();
            if (string.IsNullOrEmpty(pmdFilePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "地图文档保存为：";
                saveFileDialog.Filter = "PMD(.pmd) |*.pmd";
                saveFileDialog.InitialDirectory = @"C:\Users\Administrator\Desktop\黄河故道生态富民廊道\演示工程";
                if (saveFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
                pmdFilePath = saveFileDialog.FileName;
                if (string.IsNullOrEmpty(pmdFilePath)) return;

                if (!pmdFilePath.EndsWith(".pmd"))
                {
                    pmdFilePath = pmdFilePath + ".pmd";
                }
            }
            mapDocument.SaveAs(pmdFilePath, false, false);
        }
        #endregion

        #region 1.4 另存工程
        /// <summary>
        /// 另存地图工程
        /// </summary>
        private void saveAs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveAsProject();
        }
        private void SaveAsProject()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "地图文档另存为：";
            saveFileDialog.Filter = "PMD(.pmd)|*.pmd";
            saveFileDialog.InitialDirectory = @"C:\Users\Administrator\Desktop\黄河故道生态富民廊道\演示工程";
            if (saveFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            string pmdFilePath = saveFileDialog.FileName;
            if (string.IsNullOrEmpty(pmdFilePath)) return;

            if (!pmdFilePath.EndsWith(".pmd"))
            {
                pmdFilePath = pmdFilePath + ".pmd";
            }
            IMapDocument newMapDocument = new MapDocument();
            newMapDocument.ReplaceContents(pageLayoutControlMain);
            newMapDocument.SaveAs(pmdFilePath, false, false);
        }
        #endregion

        #region 1.5 关闭工程
        /// <summary>
        /// 退出软件
        /// </summary>
        private void closeProject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("是否退出当前系统?", "退出", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

        #endregion

        #region 2. 数据管理

        #region 2.1 加载数据

        private void loadData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand cmd = new AddDataCommand();
            cmd.OnCreate(mapControlMain);
            cmd.OnClick();
        }
        #endregion

        #region 2.2 加载矢量数据
        private void loadFeatureData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand cmd = new LoadFeatureDataCommand();
            cmd.OnCreate(mapControlMain);
            cmd.OnClick();
        }
        #endregion

        #region 2.3 加载栅格数据
        private void loadRasterData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand cmd = new LoadRasterDataCommand();
            cmd.OnCreate(mapControlMain);
            cmd.OnClick();
        }
        #endregion

        #region 2.4 加载卫星数据
        private void loadSatelliteData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PIE.SystemUI.ICommand cmd = new PIE.Controls.LoadHJDataCommand();
            cmd.OnCreate(mapControlMain);
            cmd.OnClick();
        }
        #endregion

        #region 2.5 添加底图
        //2.5.1 天地图影像底图
        private void TDTTiledImg_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PIE.SystemUI.ICommand cmd = new PIE.Controls.TDTTiledImgCommand();
            cmd.OnCreate(mapControlMain);
            cmd.OnClick();
        }
        //2.5.2 天地图影像注记
        private void TDTTiledCia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PIE.SystemUI.ICommand cmd = new PIE.Controls.TDTTiledCiaCommand();
            cmd.OnCreate(mapControlMain);
            cmd.OnClick();
        }
        //2.5.3 高德卫星图
        private void GaoDeSatellite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PIE.SystemUI.ICommand cmd = new PIE.Controls.GaoDeSatelliteCommand();
            cmd.OnCreate(mapControlMain);
            cmd.OnClick();
        }
        //2.5.4 高德路线图
        private void GaoDeRoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PIE.SystemUI.ICommand cmd = new PIE.Controls.GaoDeRoadCommand();
            cmd.OnCreate(mapControlMain);
            cmd.OnClick();
        }
        //2.5.5 高德注记图
        private void GaoDeAnnotation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PIE.SystemUI.ICommand cmd = new PIE.Controls.GaoDeAnnotationCommand();
            cmd.OnCreate(mapControlMain);
            cmd.OnClick();
        }
        //2.5.6 ArcGISImage
        private void LoadArcGISServerLayer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PIE.SystemUI.ICommand cmd = new PIE.Controls.LoadArcGISServerLayerCommand();
            cmd.OnCreate(mapControlMain);
            cmd.OnClick();
        }
        #endregion

        #endregion

        #region 3. 信息查询

        #region 3.1 探针工具
        private void rasterIdentify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ITool rIdentifyTool = new RasterIdentifyTool();

            ICommand cmd = rIdentifyTool as ICommand;
            if (tabControlMain.SelectedIndex == 0)
            {
                cmd.OnCreate(mapControlMain);
                cmd.OnClick();
                mapControlMain.CurrentTool = rIdentifyTool;
            }
        }
        #endregion

        #region 3.2 属性查询
        private void attributeQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ITool attIdentifyTool = new AttributeIdentifyTool();
            ICommand cmd = attIdentifyTool as ICommand;
            if (tabControlMain.SelectedIndex == 0)
            {
                cmd.OnCreate(mapControlMain);
                cmd.OnClick();
                mapControlMain.CurrentTool = attIdentifyTool;
            }
        }
        #endregion

        #region 3.3 空间查询
        private void spatialQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ITool tool = new SpatialQueryTool();
            ICommand cmd = tool as ICommand;
            cmd.OnCreate(mapControlMain);
            mapControlMain.CurrentTool = tool;
        }
        #endregion

        #region 3.4 直方图统计
        private void histogramStatistics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //只能用于显示参数不能获取界面上的统计信息
            PIE.AxControls.HistogramStatDialog frmSupervisedClassificaiton = new PIE.AxControls.HistogramStatDialog();
            frmSupervisedClassificaiton.Initialize(mapControlMain.FocusMap);
            frmSupervisedClassificaiton.ShowDialog();

            (frmSupervisedClassificaiton as IDisposable).Dispose();
            frmSupervisedClassificaiton = null;
        }
        #endregion

        #endregion
        #endregion

        #region 二、显示控制
        //修改RGB波段
        private void rgbCombine_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mapControlMain.ActiveView.CurrentLayer == null) return;
            //判断选择的图层是否为栅格图层
            IRasterLayer rasterLayer = mapControlMain.ActiveView.CurrentLayer as IRasterLayer;
            if (rasterLayer == null) return;
            //初始化rgbRender
            IRasterRGBRender rRGBRender = new PIE.Carto.RasterRGBRender();

            //设置参数
            rRGBRender.UseRedBand = true;
            rRGBRender.UseGreenBand = true;
            rRGBRender.UseBlueBand = true;
            //根据栅格数据的波段数进行rgb波段索引设置，
            rRGBRender.SetBandIndices(3, 2, 1);

            //设置rasterrender
            IRasterRender render = rRGBRender as IRasterRender;
            rasterLayer.Render = render;
            //刷新视图  mapControlMain.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
        }
        #region Scroll部分
        //滚动条调节亮度
        private void brightEditItem_Scroll(object sender, EventArgs e)
        {
            int brightness = int.Parse(brightnessEditItem.EditValue.ToString());
            /* if (brightnessEditItem.EditValue != null)
            {
                brightnessEditItem.EditValue.MinValue = 1;
                brightnessEditItem.EditValue.MaxValue = 100;
            }*/
            if (mapControlMain.ActiveView.CurrentLayer == null) return;
            IRasterLayer rasterLayer = mapControlMain.ActiveView.CurrentLayer as IRasterLayer;
            if (rasterLayer != null)
            {
                IRasterStretch rStretch = rasterLayer.Render as IRasterStretch;
                (rStretch as IRasterDisplayProps).BrightnessValue = brightness;
                rasterLayer.RaiseRenderChanged();
                mapControlMain.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
                brightnessText.EditValue = brightness.ToString();
            }
        }
        //滚动条调节对比度
        private void contrastRatioEditItem_Scroll(object sender, EventArgs e)
        {
            int contrastRatio = int.Parse(contrastRatioEditItem.EditValue.ToString());
            if (mapControlMain.ActiveView.CurrentLayer == null) return;
            IRasterLayer rasterLayer = mapControlMain.ActiveView.CurrentLayer as IRasterLayer;
            if (rasterLayer != null)
            {
                IRasterStretch rStretch = rasterLayer.Render as IRasterStretch;
                (rStretch as IRasterDisplayProps).ContrastValue = contrastRatio;
                rasterLayer.RaiseRenderChanged();
                mapControlMain.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
                contrastRatioText.EditValue = contrastRatio.ToString();
            }
        }
        //滚动条调节透明度
        private void transparencyEditItem_Scroll(object sender, EventArgs e)
        {
            int transparency = int.Parse(transparencyEditItem.EditValue.ToString());
            ILayer currentlayer = mapControlMain.ActiveView.CurrentLayer;
            if (currentlayer == null) return;
            if (currentlayer.LayerType.Equals(LayerType.LayerTypeFeatureLayer))
            {
                IFeatureLayer featureLayer = mapControlMain.ActiveView.CurrentLayer as IFeatureLayer;
                if (featureLayer != null)
                {
                    featureLayer.Render.Transparency = transparency;
                    featureLayer.RaiseRenderChanged();
                    mapControlMain.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
                    transparencyText.EditValue = transparency.ToString();
                }
            }
            else if (currentlayer.LayerType.Equals(LayerType.LayerTypeRasterLayer))
            {
                IRasterLayer rasterLayer = mapControlMain.ActiveView.CurrentLayer as IRasterLayer;
                if (rasterLayer != null)
                {
                    IRasterStretch rStretch = rasterLayer.Render as IRasterStretch;
                    (rStretch as IRasterDisplayProps).TransparencyValue = transparency;
                    rasterLayer.RaiseRenderChanged();
                    mapControlMain.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
                    transparencyText.EditValue = transparency.ToString();
                }
            }
        }
        //滚动条调节线性拉伸百分比
        private void stretchEditItem_Scroll(object sender, EventArgs e)
        {
            double percentage = double.Parse(stretchEditItem.EditValue.ToString());
            if (mapControlMain.ActiveView.CurrentLayer == null) return;
            //获取待拉伸的图层
            IRasterLayer rasterLayer = mapControlMain.ActiveView.CurrentLayer as IRasterLayer;
            if (rasterLayer == null)
                return;
            //获取拉伸对象
            IRasterRender render = rasterLayer.Render;
            IRasterStretch stretch = render as IRasterStretch;
            //设置拉伸类型
            stretch.StretchType = PIE.Carto.RasterStretchType.RasterStretch_PercentMinimumMaximum;
            stretch.LinearStretchPercent = percentage;
            rasterLayer.RaiseRenderChanged();
            //刷新地图
            mapControlMain.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
            stretchText.EditValue = percentage.ToString();
        }
        #endregion

        #region 点击按钮弹窗手动输入
        //亮度
        private void brightness_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mapControlMain.ActiveView.CurrentLayer == null)
            {
                MessageBox.Show("请添加图层！");
                return;
            }
            IRasterLayer rasterLayer = mapControlMain.ActiveView.CurrentLayer as IRasterLayer;
            if (rasterLayer != null)
            {
                //通过界面去设置亮度
                brightnessParam frm = new brightnessParam(rasterLayer);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    //设置栅格拉伸属性
                    IRasterStretch rStretch = rasterLayer.Render as IRasterStretch;
                    (rStretch as IRasterDisplayProps).BrightnessValue = frm.Brightness;//亮度
                    rasterLayer.RaiseRenderChanged();
                    mapControlMain.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
                    brightnessEditItem.EditValue = frm.Brightness;
                    brightnessText.EditValue = frm.Brightness.ToString();
                }
            }
        }
        //对比度
        private void contrastRatio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mapControlMain.ActiveView.CurrentLayer == null)
            {
                MessageBox.Show("请添加图层！");
                return;
            }
            IRasterLayer rasterLayer = mapControlMain.ActiveView.CurrentLayer as IRasterLayer;
            if (rasterLayer != null)
            {
                //通过界面去设置亮度
                contrastRatioParam frm = new contrastRatioParam(rasterLayer);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    //设置栅格拉伸属性
                    IRasterStretch rStretch = rasterLayer.Render as IRasterStretch;
                    (rStretch as IRasterDisplayProps).ContrastValue = frm.ContrastRatio;//亮度
                    rasterLayer.RaiseRenderChanged();
                    mapControlMain.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
                    contrastRatioEditItem.EditValue = frm.ContrastRatio;
                    contrastRatioText.EditValue = frm.ContrastRatio.ToString();
                }
            }
        }
        //透明度
        private void transparency_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mapControlMain.ActiveView.CurrentLayer == null)
            {
                MessageBox.Show("请添加图层！");
                return;
            }
            ILayer currentlayer = mapControlMain.ActiveView.CurrentLayer;
            if (currentlayer != null)
            {
                transparencyParam frm = new transparencyParam(currentlayer);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    if (currentlayer.LayerType.Equals(LayerType.LayerTypeFeatureLayer))
                    {
                        IFeatureLayer featureLayer = currentlayer as IFeatureLayer;
                        if (featureLayer != null)
                        {
                            featureLayer.Render.Transparency = frm.Transparency;
                            featureLayer.RaiseRenderChanged();
                            mapControlMain.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
                            transparencyEditItem.EditValue = frm.Transparency;
                            transparencyText.EditValue = frm.Transparency.ToString();
                        }
                    }
                    else if (currentlayer.LayerType.Equals(LayerType.LayerTypeRasterLayer))
                    {
                        IRasterLayer rasterLayer = currentlayer as IRasterLayer;
                        if (rasterLayer != null)
                        {
                            IRasterStretch rStretch = rasterLayer.Render as IRasterStretch;
                            (rStretch as IRasterDisplayProps).TransparencyValue = frm.Transparency;
                            rasterLayer.RaiseRenderChanged();
                            mapControlMain.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
                            transparencyEditItem.EditValue = frm.Transparency;
                            transparencyText.EditValue = frm.Transparency.ToString();
                        }
                    }
                }
            }
        }
        //拉伸
        private void stretch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mapControlMain.ActiveView.CurrentLayer == null)
            {
                MessageBox.Show("请添加图层！");
                return;
            }
            IRasterLayer rasterLayer = mapControlMain.ActiveView.CurrentLayer as IRasterLayer;
            if (rasterLayer != null)
            {
                //通过界面去设置亮度
                percentLinearStrechParam frm = new percentLinearStrechParam(rasterLayer);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    //获取拉伸对象
                    IRasterRender render = rasterLayer.Render;
                    IRasterStretch stretch = render as IRasterStretch;
                    //设置拉伸类型
                    stretch.StretchType = PIE.Carto.RasterStretchType.RasterStretch_PercentMinimumMaximum;
                    stretch.LinearStretchPercent = frm.percentLinearStrech;
                    rasterLayer.RaiseRenderChanged();
                    //刷新地图
                    mapControlMain.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
                    stretchEditItem.EditValue = frm.percentLinearStrech;
                    stretchText.EditValue = frm.percentLinearStrech.ToString();
                }
            }
        }
        #endregion
        #endregion

        #region 三、影像处理
        #region 1. 辐射校正
        #region 1.1 辐射定标
        private void radiometricCalibration_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            radiometricCalibrationForm form = new radiometricCalibrationForm();
            form.ShowDialog();
        }
        #endregion

        #region 1.2 大气校正

        #endregion

        #endregion

        #region 2. 几何校正
        #region 2.1 影像匹配

        #endregion

        #region 2.2 正射校正

        #endregion
        #region 2.3 几何精校正

        #endregion

        #endregion

        #region 3. 影像镶嵌
        #region 3.1 快速拼接

        #endregion

        #region 3.2 无缝镶嵌

        #endregion

        #endregion

        #region 4. 影像裁剪

        #endregion

        #region 5. 波段处理
        #region 5.1 波段运算

        #endregion

        #region 5.2 波段合成
        private void bandSynthesis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BandSynthesisForm form = new BandSynthesisForm();
            form.ShowDialog();
        }
        #endregion

        #endregion

        #endregion

        #region 四、影像分类

        #region 1. ROI工具
        private void roiTool_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool flag = false;
            IList<ILayer> layerList = new List<ILayer>();
            layerList = mapControlMain.ActiveView.FocusMap.GetAllLayer();
            foreach (ILayer currentlayer in layerList)
            {
                if (currentlayer.LayerType.Equals(LayerType.LayerTypeRasterLayer))
                {
                    flag = true;
                }
            }
            if (flag)
            {
                PIE.SystemUI.ICommand cmd = new PIE.Plugin.ROIToolCommand();
                cmd.OnCreate(mapControlMain);
                cmd.OnClick();
            }
            else
            {
                MessageBox.Show("未加载栅格图层！");
            }
        }
        #endregion

        #region 2. 非监督分类

        #region 2.1 ISODATA分类
        private void isoData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //PIE.SystemUI.ICommand cmd = new ISODATA();
            //cmd.OnCreate(mapControlMain);
            //cmd.OnClick();
            ISODATAForm frm = new ISODATAForm();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                #region 1、参数设置
                PIE.CommonAlgo.ISODataClassification_Exchange_Info info = new PIE.CommonAlgo.ISODataClassification_Exchange_Info();

                info.InputFilePath = frm.selectedImage;
                info.OutputFilePath = frm.resultImage;
                info.ProspClassNum = frm.ProspClassNumFrm;
                info.InitClassNum = frm.InitClassNumFrm;
                info.MinSam = frm.MinSamFrm;
                info.MaxLoop = frm.MaxLoopFrm;
                info.MaxMerge = frm.MaxMergeFrm;
                info.Dev = frm.DevFrm;
                info.MinDis = frm.MinDisFrm;
                IRasterDataset rDataset = PIE.DataSource.DatasetFactory.OpenRasterDataset(frm.selectedImage, OpenMode.ReadOnly);
                if (rDataset == null) return;
                info.LowBands = frm.selectedBands;
                info.FileTypeCode = "Gtiff";

                PIE.SystemAlgo.ISystemAlgo algo = PIE.SystemAlgo.AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.ISODataClassificationAlgo");
                if (algo == null) return;
                #endregion

                //2、算法执行
                PIE.SystemAlgo.ISystemAlgoEvents algoEvents = algo as PIE.SystemAlgo.ISystemAlgoEvents;
                algo.Name = "ISODATA分类";
                algo.Params = info;
                bool result = PIE.SystemAlgo.AlgoFactory.Instance().ExecuteAlgo(algo);

                //3、结果显示
                ILayer layer = PIE.Carto.LayerFactory.CreateDefaultLayer(frm.resultImage);
                mapControlMain.ActiveView.FocusMap.AddLayer(layer);
                mapControlMain.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
            }
        }
        #endregion

        #region 2.2 K-Means分类
        private void kmeans_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            kmeansForm frm = new kmeansForm();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                #region 1、参数设置
                PIE.CommonAlgo.KmeansClassification_Exchange_Info info = new PIE.CommonAlgo.KmeansClassification_Exchange_Info();
                info.InputFilePath = frm.selectedImage;
                info.OutputFilePath = frm.resultImage;
                info.ClassNum = frm.ClassNumFrm;
                info.Maxloop = frm.MaxLoopFrm;
                info.Threshold = frm.ThresholdFrm;
                info.LowBands = frm.selectedBands;

                PIE.SystemAlgo.ISystemAlgo algo = PIE.SystemAlgo.AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.KmeansClassificationAlgo");
                if (algo == null) return;
                #endregion

                //2、算法执行
                PIE.SystemAlgo.ISystemAlgoEvents algoEvents = algo as PIE.SystemAlgo.ISystemAlgoEvents;
                algo.Name = " K-Means分类";
                algo.Params = info;
                bool result = PIE.SystemAlgo.AlgoFactory.Instance().ExecuteAlgo(algo);

                //3、结果显示
                ILayer layer = PIE.Carto.LayerFactory.CreateDefaultLayer(info.OutputFilePath);
                mapControlMain.ActiveView.FocusMap.AddLayer(layer);
                mapControlMain.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
            }
        }
        #endregion

        #endregion

        #region 3. 监督分类
        PIE.CommonAlgo.SupervisedClassification_Exchange_Info m_DataInfo = new SupervisedClassification_Exchange_Info();

        void systemEvents_OnExecuteCompleted(ISystemAlgo algo)
        {
            ISystemAlgoEvents systemEvents = algo as ISystemAlgoEvents;
            systemEvents.OnExecuteCompleted -= systemEvents_OnExecuteCompleted;
            ILayer layer = LayerFactory.CreateDefaultLayer(m_DataInfo.OutputFilePath);
            if (layer == null)
            {
                System.Windows.Forms.MessageBox.Show("分类后图层为空");
                return;
            }
            mapControlMain.ActiveView.FocusMap.AddLayer(layer);
            mapControlMain.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
        }

        #region 3.1 距离分类
        private void distanceClassification_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            distanceClassifyForm frm = new distanceClassifyForm(mapControlMain);
            frm.ShowDialog();
            if (frm.DialogResult != DialogResult.OK) return;
            m_DataInfo.InputFilePath = frm.selectedImage;
            m_DataInfo.OutputFilePath = frm.resultImage;
            m_DataInfo.CStart = frm.CStartFrm;
            m_DataInfo.CEnd = frm.CEndFrm;
            m_DataInfo.RStart = frm.RStartFrm;
            m_DataInfo.REnd = frm.REndFrm;
            m_DataInfo.SelBandNums = frm.SelectBandNums;//波段的个数
            m_DataInfo.ClassifierType = frm.ClassType;//分类类型 0 代表最大似然;11代表最小距离分类；12代表马氏距离分类
            m_DataInfo.SelBandIndexs = frm.listBandIndex;

            #region ROIStatistics ROI统计算法
            ROIStatistics_Exchange_Info roiDataInfo = new PIE.CommonAlgo.ROIStatistics_Exchange_Info();
            roiDataInfo.ClassifierType = m_DataInfo.ClassifierType;
            roiDataInfo.currentFileName = m_DataInfo.InputFilePath;
            roiDataInfo.selBandIndex = m_DataInfo.SelBandIndexs.ToArray();
            roiDataInfo.selBandNums = m_DataInfo.SelBandNums;
            roiDataInfo.pROILayer = frm.ROILayer;

            ISystemAlgo algo = AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.ROIStatisticsAlgo");
            algo.Params = roiDataInfo;
            bool result = AlgoFactory.Instance().ExecuteAlgo(algo);//同步执行roi统计算法
            #endregion

            #region DistanceClassify算法
            //执行完成后得到roi统计的参数会发生变化
            roiDataInfo = (ROIStatistics_Exchange_Info)algo.Params;
            int roiNum = roiDataInfo.vecROIName.Count;

            m_DataInfo.ROINums = roiNum; //ROI个数
            m_DataInfo.ListRoiNames = roiDataInfo.vecROIName;//roi名称列表
            m_DataInfo.ListRoiColors = roiDataInfo.vecROIColor;//roi颜色集合
            m_DataInfo.ROIMean = new List<double>();
            m_DataInfo.ROICof = new List<double>();
            for (int i = 0; i < roiNum; i++)//roi均值集合
            {
                for (int j = 0; j < frm.SelectBandNums; j++)
                {
                    m_DataInfo.ROIMean.Add(roiDataInfo.vecMean[i * frm.SelectBandNums + j]);
                }
                for (int k = 0; k < frm.SelectBandNums * frm.SelectBandNums; k++)
                {
                    m_DataInfo.ROICof.Add(roiDataInfo.vecCof[i * frm.SelectBandNums * frm.SelectBandNums + k]);
                }
            }
            ISystemAlgo distanceAlgo = AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.DistanceClassificationAlgo");//最大似然法就将DistanceClassificationAlgo替换为MLClassificationAlgo
            distanceAlgo.Params = m_DataInfo;
            ISystemAlgoEvents systemEvents = distanceAlgo as ISystemAlgoEvents;
            systemEvents.OnExecuteCompleted += systemEvents_OnExecuteCompleted;
            result = AlgoFactory.Instance().ExecuteAlgo(distanceAlgo);
            #endregion
        }
        #endregion

        #region 3.2 最大似然分类
        private void mlClassification_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            maximumLikelihoodForm frm = new maximumLikelihoodForm(mapControlMain);
            frm.ShowDialog();
            if (frm.DialogResult != DialogResult.OK) return;
            m_DataInfo.InputFilePath = frm.selectedImage;
            m_DataInfo.OutputFilePath = frm.resultImage;
            m_DataInfo.CStart = frm.CStartFrm;
            m_DataInfo.CEnd = frm.CEndFrm;
            m_DataInfo.RStart = frm.RStartFrm;
            m_DataInfo.REnd = frm.REndFrm;
            m_DataInfo.SelBandNums = frm.SelectBandNums;//波段的个数
            m_DataInfo.ClassifierType = frm.ClassType;//分类类型 0 代表最大似然;11代表最小距离分类；12代表马氏距离分类
            m_DataInfo.SelBandIndexs = frm.listBandIndex;

            #region ROIStatistics ROI统计算法
            ROIStatistics_Exchange_Info roiDataInfo = new PIE.CommonAlgo.ROIStatistics_Exchange_Info();
            roiDataInfo.ClassifierType = m_DataInfo.ClassifierType;
            roiDataInfo.currentFileName = m_DataInfo.InputFilePath;
            roiDataInfo.selBandIndex = m_DataInfo.SelBandIndexs.ToArray();
            roiDataInfo.selBandNums = m_DataInfo.SelBandNums;
            roiDataInfo.pROILayer = frm.ROILayer;

            ISystemAlgo algo = AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.ROIStatisticsAlgo");
            algo.Params = roiDataInfo;
            bool result = AlgoFactory.Instance().ExecuteAlgo(algo);//同步执行roi统计算法
            #endregion

            #region DistanceClassify算法
            //执行完成后得到roi统计的参数会发生变化
            roiDataInfo = (ROIStatistics_Exchange_Info)algo.Params;
            int roiNum = roiDataInfo.vecROIName.Count;

            m_DataInfo.ROINums = roiNum; //ROI个数
            m_DataInfo.ListRoiNames = roiDataInfo.vecROIName;//roi名称列表
            m_DataInfo.ListRoiColors = roiDataInfo.vecROIColor;//roi颜色集合
            m_DataInfo.ROIMean = new List<double>();
            m_DataInfo.ROICof = new List<double>();
            for (int i = 0; i < roiNum; i++)//roi均值集合
            {
                for (int j = 0; j < frm.SelectBandNums; j++)
                {
                    m_DataInfo.ROIMean.Add(roiDataInfo.vecMean[i * frm.SelectBandNums + j]);
                }
                for (int k = 0; k < frm.SelectBandNums * frm.SelectBandNums; k++)
                {
                    m_DataInfo.ROICof.Add(roiDataInfo.vecCof[i * frm.SelectBandNums * frm.SelectBandNums + k]);
                }
            }
            ISystemAlgo distanceAlgo = AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.DistanceClassificationAlgo");//最大似然法就将DistanceClassificationAlgo替换为MLClassificationAlgo
            distanceAlgo.Params = m_DataInfo;
            ISystemAlgoEvents systemEvents = distanceAlgo as ISystemAlgoEvents;
            systemEvents.OnExecuteCompleted += systemEvents_OnExecuteCompleted;
            result = AlgoFactory.Instance().ExecuteAlgo(distanceAlgo);
            #endregion
        }
        #endregion

        #endregion

        #region 4.分类后处理
        #region 4.1 分类统计
        private void classStatistics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            classificationStatisticForm frm = new classificationStatisticForm();
            frm.ShowDialog();
        }
        #endregion

        #endregion

        #endregion



































    }
}
