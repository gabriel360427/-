using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIE.Carto;
using PIE.CommonAlgo;
using PIE.SystemAlgo;
using PIE.DataSource;
using PIE.AxControls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.GeoAnalyst;
using ESRI.ArcGIS.SpatialAnalyst;
using ESRI.ArcGIS.SpatialAnalystTools;
using ESRI.ArcGIS.Geoprocessing;
using ESRI.ArcGIS.Geoprocessor;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.esriSystem;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.ADF.Connection.Local;
using ESRI.ArcGIS.ConversionTools;
using ESRI.ArcGIS.DataSourcesRaster;

namespace 绿廊智绘.Custom_Forms
{
    public partial class LinearResistenceFactorNEW : Form
    {
        public LinearResistenceFactorNEW()
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
        FormMain pie1;
        public IMapControl m_MapControl;
        //全局变量，表示当前输入文件框所选择的序号
        int index1 = -1;
        string path;
        int index;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (index1 == 矢量数据输入框.SelectedIndex) { return; }
            index1 = 矢量数据输入框.SelectedIndex;
            矢量数据输入框.Items[index1] = pie1.mapControlMain.FocusMap.GetLayer(index1).DataSourcePath;
            try
            {
                PIE.Carto.ILayer layer = PIE.Carto.LayerFactory.CreateDefaultLayer(矢量数据输入框.Text);
                PIE.DataSource.IFeatureClass featureClass = (layer as PIE.Carto.IFeatureLayer).FeatureClass;
                if (featureClass == null) { MessageBox.Show("请打开矢量数据"); return; }
            }
            catch { MessageBox.Show("请打开矢量数据"); return; }
            文件输出框.Text = 矢量数据输入框.Text.Substring(0, 矢量数据输入框.Text.LastIndexOf(".")) + "阻力.tif";
        }

        private void 矢量加载按钮_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "打开矢量数据";
            open.Filter = "矢量数据|*.shp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                矢量数据输入框.Text = open.FileName;
                文件输出框.Text = 矢量数据输入框.Text.Substring(0, 矢量数据输入框.Text.LastIndexOf(".")) + "阻力.tif";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "输入矢量文件";
            openfile.Filter = "矢量文件|*.shp";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                裁剪矢量输入框.Text = openfile.FileName;
            }
        }

        private void 文件输出类型框_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 文件输出框_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (index1 == 文件输出框.SelectedIndex) { return; }
            index1 = 文件输出框.SelectedIndex;
            文件输出框.Items[index1] = pie1.mapControlMain.FocusMap.GetLayer(index1).DataSourcePath;
            try
            {
                PIE.Carto.ILayer layer = PIE.Carto.LayerFactory.CreateDefaultLayer(文件输出框.Text);
                PIE.DataSource.IFeatureClass featureClass = (layer as PIE.Carto.IFeatureLayer).FeatureClass;
                if (featureClass == null) { MessageBox.Show("请打开矢量数据"); return; }
            }
            catch { MessageBox.Show("请打开矢量数据"); return; }
            文件输出框.Text = 文件输出框.Text.Substring(0, 文件输出框.Text.LastIndexOf(".")) + "阻力.tif";
        }

        private void 文件输出加载_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "输入矢量文件";
            openfile.Filter = "矢量文件|*.shp";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                裁剪矢量输入框.Text = openfile.FileName;
            }
        }

        private void 基准影像输入框_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 基准影像载入按钮_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "输入基准影像";
            open.Filter = "基准影像|*.tif;*.tiff;*.bmp;*.img;*.jpg;*.ldf";
            if (open.ShowDialog() == DialogResult.OK)
            {
                基准影像输入框.Text = open.FileName;
            }
        }

        private void 取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void 确认_Click(object sender, EventArgs e)
        {
            #region 开始集成功能

            #region 1 多环缓冲区建立
            try
            {
                // Initialize the license
                IAoInitialize aoInitialize = new AoInitializeClass();
                aoInitialize.Initialize(esriLicenseProductCode.esriLicenseProductCodeEngine);

                // Path to your shapefile
                string shapefilePath = 矢量数据输入框.Text;
                path = shapefilePath;
                index = path.LastIndexOf(".");
                string outputpath = path.Insert(index,"_merge");
                
                #region 合并矢量数据
                string inputShapefilePath = path;
                string outputShapefilePath = outputpath;
                path = outputpath;
                index = path.LastIndexOf(".");

                // 打开输入shp文件
                IWorkspaceFactory workspaceFactory = new ShapefileWorkspaceFactoryClass();
                IFeatureWorkspace featureWorkspace = (IFeatureWorkspace)workspaceFactory.OpenFromFile(System.IO.Path.GetDirectoryName(inputShapefilePath), 0);
                ESRI.ArcGIS.Geodatabase.IFeatureClass inputFeatureClass = featureWorkspace.OpenFeatureClass(System.IO.Path.GetFileName(inputShapefilePath));

                // 创建输出shp文件
                ESRI.ArcGIS.Geodatabase.IFields fields = inputFeatureClass.Fields;
                string shapefileName = System.IO.Path.GetFileName(outputShapefilePath);
                ESRI.ArcGIS.Geodatabase.IFeatureClass outputFeatureClass = CreateShapefile(workspaceFactory, System.IO.Path.GetDirectoryName(outputShapefilePath), shapefileName, fields);

                // 合并线要素
                IGeometry mergedGeometry = MergeLines(inputFeatureClass);

                // 创建新的线要素并添加到输出shp文件中
                ESRI.ArcGIS.Geodatabase.IFeature newFeature = outputFeatureClass.CreateFeature();
                newFeature.Shape = mergedGeometry;
                newFeature.Store();

                Console.WriteLine("线要素合并完成，并导出到新的shp文件。");
                #endregion
                // Open the shapefile
                IWorkspaceFactory workspaceFactory2 = new ShapefileWorkspaceFactoryClass();
                IFeatureWorkspace featureWorkspace2 = (IFeatureWorkspace)workspaceFactory2.OpenFromFile(System.IO.Path.GetDirectoryName(path), 0);
                ESRI.ArcGIS.Geodatabase.IFeatureClass featureClass = featureWorkspace2.OpenFeatureClass(System.IO.Path.GetFileNameWithoutExtension(path));

                // Create buffer distances
                double[] bufferDistances = new double[] { 0.1, 0.2, 0.3 };

                // Create a buffer for each distance
                ITopologicalOperator2 topologicalOperator;
                IGeometry bufferGeometry;
                IGeometryCollection bufferGeometryCollection = new GeometryBagClass();

                List<Tuple<IGeometry, double>> bufferGeometriesWithDistances = new List<Tuple<IGeometry, double>>();

                ESRI.ArcGIS.Geodatabase.IFeatureCursor featureCursor = featureClass.Search(null, false);
                ESRI.ArcGIS.Geodatabase.IFeature feature;
                while ((feature = featureCursor.NextFeature()) != null)
                {
                    IGeometry geometry = feature.Shape;

                    foreach (double distance in bufferDistances)
                    {
                        topologicalOperator = (ITopologicalOperator2)geometry;
                        bufferGeometry = CreateRoundedBuffer(geometry, distance);
                        bufferGeometryCollection.AddGeometry(bufferGeometry);
                        bufferGeometriesWithDistances.Add(new Tuple<IGeometry, double>(bufferGeometry, distance));
                    }
                }

                
                // Optionally, save the buffer result to a new shapefile
                string bufferShapefilePath = path.Insert(index, "_multibuffer");
                path = bufferShapefilePath;
                ESRI.ArcGIS.Geodatabase.IFeatureClass bufferFeatureClass = CreateShapefile(bufferShapefilePath, bufferGeometriesWithDistances);

                MessageBox.Show("Execution completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion

            #region 2 重分类
            string newFieldName = "Cost";

            // Open the input shapefile
            IWorkspaceFactory workspaceFactory3 = new ShapefileWorkspaceFactory();
            IFeatureWorkspace inputFeatureWorkspace2 = (IFeatureWorkspace)workspaceFactory3.OpenFromFile(System.IO.Path.GetDirectoryName(path), 0);
            ESRI.ArcGIS.Geodatabase.IFeatureClass inputFeatureClass2 = inputFeatureWorkspace2.OpenFeatureClass(System.IO.Path.GetFileName(path));

            // Add a new field for the reclassified values
            ESRI.ArcGIS.Geodatabase.IFields fields2 = inputFeatureClass2.Fields;
            int fieldIndex = fields2.FindField(newFieldName);

            if (fieldIndex == -1) // Check if the field already exists
            {
                ESRI.ArcGIS.Geodatabase.IField newField = new FieldClass();
                IFieldEdit fieldEdit = (IFieldEdit)newField;
                fieldEdit.Name_2 = newFieldName;
                fieldEdit.Type_2 = esriFieldType.esriFieldTypeDouble;
                inputFeatureClass2.AddField(newField);
                fieldIndex = inputFeatureClass2.Fields.FindField(newFieldName);
            }

            // Start an edit session
            IWorkspaceEdit workspaceEdit = (IWorkspaceEdit)inputFeatureWorkspace2;
            workspaceEdit.StartEditing(false);
            workspaceEdit.StartEditOperation();

            try
            {
                // Iterate through each feature and reclassify the 'Distence' field
                ESRI.ArcGIS.Geodatabase.IFeatureCursor featureCursor = inputFeatureClass2.Update(null, false);
                ESRI.ArcGIS.Geodatabase.IFeature feature;
                int distanceFieldIndex = inputFeatureClass2.FindField("Distance");
                while ((feature = featureCursor.NextFeature()) != null)
                {
                    // Read the 'Distence' value
                    object distanceValueObj = feature.get_Value(distanceFieldIndex);
                    if (distanceValueObj != DBNull.Value)
                    {
                        double distance = Convert.ToDouble(distanceValueObj);
                        double reclassifiedValue = ReclassifyDistance(distance);

                        // Update the 'Reclassified' field
                        feature.set_Value(fieldIndex, reclassifiedValue);
                        featureCursor.UpdateFeature(feature);
                        Console.WriteLine($"Feature OID: {feature.OID}, Distence: {distance}, Reclassified: {reclassifiedValue}");
                    }
                }

                // Stop the edit operation
                workspaceEdit.StopEditOperation();
                workspaceEdit.StopEditing(true);
                Console.WriteLine("Reclassification completed successfully.");
            }
            catch (Exception ex)
            {
                // Abort the edit operation in case of an error
                workspaceEdit.AbortEditOperation();
                Console.WriteLine("Error: " + ex.Message);
            }
            #endregion

            #region 3 矢量转栅格
            index = path.LastIndexOf(".");
            string shapefilePath4 = path;
            string rasterPath = path.Insert(index,"_raster");
            double cellSize = 0.01; // 像元大小，单位为米
            string selectedField = "Elevation"; // 所选字段，例如高程

            // 创建基准影像
            //IRasterWorkspace2 rasterWs = CreateRasterWorkspace(@"C:\path\to\base\raster_folder");
            //IRaster baseRaster = OpenBaseRaster(rasterWs, @"C:\path\to\base\raster.tif");
            //IRasterProps baseProps = baseRaster as IRasterProps;

            // 执行转换
            ESRI.ArcGIS.Carto.IFeatureLayer featureLayer = OpenShapefile(shapefilePath4);
            ESRI.ArcGIS.Carto.ILayer rasterLayer = xjShpToRaster(featureLayer, rasterPath, cellSize, selectedField);

            Console.WriteLine("Raster conversion completed. Press any key to exit.");
            #endregion
        }
        
        private IGeometry CreateRoundedBuffer(IGeometry geometry, double distance)
        {
            IBufferConstruction bufferConstruction = new BufferConstructionClass();
            IBufferConstructionProperties bufferConstructionProperties = (IBufferConstructionProperties)bufferConstruction;
            bufferConstructionProperties.EndOption = esriBufferConstructionEndEnum.esriBufferRound;

            return bufferConstruction.Buffer(geometry, distance);
        }

        static ESRI.ArcGIS.Geodatabase.IFeatureClass CreateShapefile(string shapefilePath, List<Tuple<IGeometry, double>> geometriesWithDistances)
        {
            try
            {
                IWorkspaceFactory workspaceFactory = new ShapefileWorkspaceFactoryClass();
                IFeatureWorkspace featureWorkspace = (IFeatureWorkspace)workspaceFactory.OpenFromFile(System.IO.Path.GetDirectoryName(shapefilePath), 0);

                ESRI.ArcGIS.Geodatabase.IFields fields = new FieldsClass();
                IFieldsEdit fieldsEdit = (IFieldsEdit)fields;

                // Add Shape field
                ESRI.ArcGIS.Geodatabase.IField field = new FieldClass();
                IFieldEdit fieldEdit = (IFieldEdit)field;
                fieldEdit.Name_2 = "Shape";
                fieldEdit.Type_2 = esriFieldType.esriFieldTypeGeometry;

                IGeometryDef geometryDef = new GeometryDefClass();
                IGeometryDefEdit geometryDefEdit = (IGeometryDefEdit)geometryDef;
                geometryDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPolygon;

                fieldEdit.GeometryDef_2 = geometryDef;
                fieldsEdit.AddField(field);

                // Add Distance field
                ESRI.ArcGIS.Geodatabase.IField distanceField = new FieldClass();
                IFieldEdit distanceFieldEdit = (IFieldEdit)distanceField;
                distanceFieldEdit.Name_2 = "Distance";
                distanceFieldEdit.Type_2 = esriFieldType.esriFieldTypeDouble;
                fieldsEdit.AddField(distanceField);

                ESRI.ArcGIS.Geodatabase.IFeatureClass featureClass = featureWorkspace.CreateFeatureClass(System.IO.Path.GetFileNameWithoutExtension(shapefilePath), fields, null, null, esriFeatureType.esriFTSimple, "Shape", "");

                ESRI.ArcGIS.Geodatabase.IFeatureBuffer featureBuffer;
                ESRI.ArcGIS.Geodatabase.IFeatureCursor featureCursor = featureClass.Insert(true);

                foreach (var geomWithDistance in geometriesWithDistances)
                {
                    featureBuffer = featureClass.CreateFeatureBuffer();
                    featureBuffer.Shape = geomWithDistance.Item1;
                    featureBuffer.set_Value(featureClass.FindField("Distance"), geomWithDistance.Item2);
                    featureCursor.InsertFeature(featureBuffer);
                }

                featureCursor.Flush();
                return featureClass;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while creating shapefile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
    }
        static double ReclassifyDistance(double distance)
        {
            if (distance == 0.1)
                return 1000;
            else if (distance == 0.2)
                return 500;
            else if (distance == 0.3)
                return 200;
            else
                return 2; // Default value for unhandled distances
        }
        private void 裁剪矢量输入框_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        static ESRI.ArcGIS.Geodatabase.IFeatureClass CreateShapefile(IWorkspaceFactory workspaceFactory, string folderPath, string shapefileName, ESRI.ArcGIS.Geodatabase.IFields fields)
        {
            IWorkspace workspace = workspaceFactory.OpenFromFile(folderPath, 0);
            IFeatureWorkspace featureWorkspace = (IFeatureWorkspace)workspace;

            // 创建新的shp文件
            ESRI.ArcGIS.Geodatabase.IFeatureClass outputFeatureClass = featureWorkspace.CreateFeatureClass(shapefileName, fields, null, null, esriFeatureType.esriFTSimple, "Shape", "");

            return outputFeatureClass;
        }

        static IGeometry MergeLines(ESRI.ArcGIS.Geodatabase.IFeatureClass featureClass)
        {
            ITopologicalOperator unionedPolyline = null;

            ESRI.ArcGIS.Geodatabase.IFeatureCursor featureCursor = featureClass.Search(null, false);
            ESRI.ArcGIS.Geodatabase.IFeature feature;
            while ((feature = featureCursor.NextFeature()) != null)
            {
                IPolyline polyline = (IPolyline)feature.Shape;
                if (unionedPolyline == null)
                {
                    unionedPolyline = (ITopologicalOperator)polyline;
                }
                else
                {
                    unionedPolyline = (ITopologicalOperator)unionedPolyline.Union(polyline);
                }
            }

            return (IGeometry)unionedPolyline;
        }
        #endregion
        private ESRI.ArcGIS.Carto.ILayer xjShpToRaster(ESRI.ArcGIS.Carto.IFeatureLayer xjFeatureLayer, string RasterPath,
                                  double CellSize, string SecletctedField)
        {
            ESRI.ArcGIS.Geodatabase.IFeatureClass xjFeatureClass = xjFeatureLayer.FeatureClass;
            IFeatureClassDescriptor xjFeatureClassDescriptor = new FeatureClassDescriptorClass();//using ESRI.ArcGIS.GeoAnalyst;
            xjFeatureClassDescriptor.Create(xjFeatureClass, null, SecletctedField);
            IGeoDataset xjGeoDataset = xjFeatureClassDescriptor as IGeoDataset;

            IWorkspaceFactory xjwsf = new RasterWorkspaceFactoryClass();//using ESRI.ArcGIS.DataSourcesRaster;
            string xjRasterFolder = System.IO.Path.GetDirectoryName(RasterPath);
            IWorkspace xjws = xjwsf.OpenFromFile(xjRasterFolder, 0);
            IConversionOp xjConversionOp = new RasterConversionOpClass();
            IRasterAnalysisEnvironment xjRasteren = xjConversionOp as IRasterAnalysisEnvironment;

            object xjCellSize = CellSize as object;
            xjRasteren.SetCellSize(esriRasterEnvSettingEnum.esriRasterEnvValue, ref xjCellSize);

            string xjFileName = System.IO.Path.GetFileName(RasterPath);
            ESRI.ArcGIS.Geodatabase.IRasterDataset xjdaset2 = xjConversionOp.ToRasterDataset(xjGeoDataset, "TIFF", xjws, xjFileName);

            ESRI.ArcGIS.Carto.IRasterLayer xjRasterLayer = new RasterLayerClass();
            xjRasterLayer.CreateFromDataset(xjdaset2);
            ESRI.ArcGIS.Carto.ILayer xjLayer = xjRasterLayer;
            xjRasterLayer.Name = xjFileName;

            return xjLayer;
        }
        static IRasterWorkspace2 CreateRasterWorkspace(string folderPath)
        {
            IWorkspaceFactory workspaceFactory = new RasterWorkspaceFactoryClass();
            return workspaceFactory.OpenFromFile(folderPath, 0) as IRasterWorkspace2;
        }

        // 打开基准影像
        static IRaster OpenBaseRaster(IRasterWorkspace2 workspace, string rasterPath)
        {
            return workspace.OpenRasterDataset(rasterPath).CreateDefaultRaster();
        }

        // 打开Shapefile文件
        static ESRI.ArcGIS.Carto.IFeatureLayer OpenShapefile(string shapefilePath)
        {
            IWorkspaceFactory workspaceFactory = new ShapefileWorkspaceFactoryClass();
            IFeatureWorkspace featureWorkspace = workspaceFactory.OpenFromFile(System.IO.Path.GetDirectoryName(shapefilePath), 0) as IFeatureWorkspace;
            ESRI.ArcGIS.Geodatabase.IFeatureClass featureClass = featureWorkspace.OpenFeatureClass(System.IO.Path.GetFileName(shapefilePath));
            return new FeatureLayerClass() { FeatureClass = featureClass };
        }
    }
}



