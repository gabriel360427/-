using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
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
    public partial class studyAreaOverlayTreatment : Form
    {
        public studyAreaOverlayTreatment()
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "打开矢量数据";
            open.Filter = "矢量数据|*.shp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                comboBox1.Text = open.FileName;
                comboBox3.Text = comboBox1.Text.Substring(0, comboBox1.Text.LastIndexOf(".")) + "areaoutput.shp";
            }
        }

        private void studyAreaOverlayTreatment_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "打开矢量数据";
            open.Filter = "矢量数据|*.shp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                comboBox2.Text = open.FileName;
            }
        }

        int index1 = -1;
        string path;
        string outputpath;
        int index;
        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            #region 1.合并线要素
            path = comboBox1.Text;
            index = path.LastIndexOf(".");
            outputpath = path.Insert(index, "_merge");
            ShapeFileMerger merger = new ShapeFileMerger();
            merger.MergeFeaturesByGrade(path, outputpath);
            path = outputpath;
            index = path.LastIndexOf(".");
            #endregion
            #region 2.缓冲区建立
            string inputPath = path;
            outputpath = path.Insert(index, "_buffer");
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            string inputShapefilePath = path;
            string outputShapefilePath = outputpath;

            path = outputpath;
            index = index = path.LastIndexOf(".");

            IFeatureWorkspace featureWorkspace = OpenShapefileWorkspace(System.IO.Path.GetDirectoryName(inputShapefilePath));
            IFeatureClass inputFeatureClass = featureWorkspace.OpenFeatureClass(System.IO.Path.GetFileNameWithoutExtension(inputShapefilePath));

            // 获取输入shapefile的空间参考
            ISpatialReference spatialReference = GetSpatialReference(inputFeatureClass);

            // 创建输出shapefile
            IFeatureClass outputFeatureClass = CreateOutputFeatureClass(featureWorkspace, outputShapefilePath, inputFeatureClass.Fields, spatialReference);

            IFeatureCursor featureCursor = inputFeatureClass.Search(null, false);
            IFeature inputFeature;

            List<IGeometry> bufferedGeometries = new List<IGeometry>();

            while ((inputFeature = featureCursor.NextFeature()) != null)
            {
                try
                {
                    int grade = Convert.ToInt32(inputFeature.get_Value(inputFeature.Fields.FindField("grade")));
                    double bufferDistance = 0;

                    if (grade == 1)
                    {
                        bufferDistance = 5000 / 111319.9;
                    }
                    else if (grade == 2)
                    {
                        bufferDistance = 2000 / 111319.9;
                    }

                    if (bufferDistance > 0 && IsValidGeometry(inputFeature.Shape))
                    {
                        IGeometry bufferedGeometry = CreateBuffer(inputFeature.Shape, bufferDistance, spatialReference);
                        bufferedGeometries.Add(bufferedGeometry);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error processing feature ID {inputFeature.OID}: {ex.Message}");
                }
            }

            // 合并所有缓冲区要素成一个面要素
            IGeometry finalGeometry = MergeGeometries(bufferedGeometries, spatialReference);

            // 保存合并后的面要素
            SaveMergedGeometry(finalGeometry, outputFeatureClass);

            // 释放资源
            System.Runtime.InteropServices.Marshal.ReleaseComObject(featureCursor);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(inputFeatureClass);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(outputFeatureClass);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(featureWorkspace);
            #endregion
            #region 3.求交
            string inputShapefile1 = path;
            string inputShapefile2 = comboBox2.Text;
            string outputShapefile = comboBox3.Text;
            try
            {
                ShapefileIntersection intersection = new ShapefileIntersection();
                intersection.PerformIntersection(inputShapefile1, inputShapefile2, outputShapefile);
            }

            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            #endregion
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            MessageBox.Show($"处理成功，结果文件已存储在{comboBox3.Text}处");

        }

        // 创建输出要素类的方法
        static IFeatureClass CreateOutputFeatureClass(IFeatureWorkspace workspace, string outputPath)
        {
            // 创建要素类的架构
            IFields fields = new FieldsClass();
            IFieldsEdit fieldsEdit = (IFieldsEdit)fields;

            // 添加必需的几何字段
            IGeometryDef geometryDef = new GeometryDefClass();
            IGeometryDefEdit geometryDefEdit = (IGeometryDefEdit)geometryDef;
            geometryDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPolygon;
            geometryDefEdit.SpatialReference_2 = ((IGeoDataset)workspace.OpenFeatureClass(System.IO.Path.GetFileName(outputPath))).SpatialReference;

            IField shapeField = new FieldClass();
            IFieldEdit shapeFieldEdit = (IFieldEdit)shapeField;
            shapeFieldEdit.Name_2 = "Shape";
            shapeFieldEdit.Type_2 = esriFieldType.esriFieldTypeGeometry;
            shapeFieldEdit.GeometryDef_2 = geometryDef;
            fieldsEdit.AddField(shapeField);

            // 创建要素类
            UID classID = new UIDClass();
            classID.Value = "esriGeoDatabase.Feature";
            IObjectClassDescription objectClassDescription = new FeatureClassDescriptionClass();
            IFeatureClass featureClass = workspace.CreateFeatureClass(System.IO.Path.GetFileName(outputPath), fields, null, classID, esriFeatureType.esriFTSimple, "Shape", "");

            return featureClass;
        }

        static IFeatureWorkspace OpenShapefileWorkspace(string folderPath)
        {
            IWorkspaceFactory workspaceFactory = new ShapefileWorkspaceFactoryClass();
            return (IFeatureWorkspace)workspaceFactory.OpenFromFile(folderPath, 0);
        }

        static ISpatialReference GetSpatialReference(IFeatureClass featureClass)
        {
            IGeoDataset geoDataset = (IGeoDataset)featureClass;
            return geoDataset.SpatialReference;
        }

        static IGeometry CreateBuffer(IGeometry geometry, double distance, ISpatialReference spatialReference)
        {
            ITopologicalOperator topologicalOperator = (ITopologicalOperator)geometry;
            IGeometry bufferedGeometry = topologicalOperator.Buffer(distance);

            // 设置空间参考
            bufferedGeometry.SpatialReference = spatialReference;
            return bufferedGeometry;
        }

        static IFeatureClass CreateOutputFeatureClass(IFeatureWorkspace featureWorkspace, string shapefilePath, IFields inputFields, ISpatialReference spatialReference)
        {
            // 创建字段集合
            IFields fields = new FieldsClass();
            IFieldsEdit fieldsEdit = (IFieldsEdit)fields;

            // 添加几何字段
            IField geometryField = new FieldClass();
            IFieldEdit geometryFieldEdit = (IFieldEdit)geometryField;
            geometryFieldEdit.Name_2 = "Shape";
            geometryFieldEdit.Type_2 = esriFieldType.esriFieldTypeGeometry;

            IGeometryDef geometryDef = new GeometryDefClass();
            IGeometryDefEdit geometryDefEdit = (IGeometryDefEdit)geometryDef;
            geometryDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPolygon;
            geometryDefEdit.SpatialReference_2 = spatialReference;
            geometryFieldEdit.GeometryDef_2 = geometryDef;

            fieldsEdit.AddField(geometryField);

            // 复制输入字段
            for (int i = 0; i < inputFields.FieldCount; i++)
            {
                IField inputField = inputFields.get_Field(i);
                if (inputField.Type != esriFieldType.esriFieldTypeGeometry)
                {
                    fieldsEdit.AddField(inputField);
                }
            }

            // 创建FeatureClass
            string shapeFileName = System.IO.Path.GetFileNameWithoutExtension(shapefilePath);
            IFeatureClass outputFeatureClass = featureWorkspace.CreateFeatureClass(shapeFileName, fields, null, null, esriFeatureType.esriFTSimple, "Shape", "");

            return outputFeatureClass;
        }

        static IGeometry MergeGeometries(List<IGeometry> geometries, ISpatialReference spatialReference)
        {
            // 如果没有要素，返回null
            if (geometries.Count == 0)
            {
                return null;
            }

            IGeometryBag geometryBag = new GeometryBagClass();
            geometryBag.SpatialReference = spatialReference;

            IGeometryCollection geometryCollection = (IGeometryCollection)geometryBag;
            foreach (IGeometry geometry in geometries)
            {
                geometryCollection.AddGeometry(geometry);
            }

            ITopologicalOperator unionOperator = new PolygonClass();
            unionOperator.ConstructUnion(geometryCollection as IEnumGeometry);

            return unionOperator as IGeometry;
        }

        static void SaveMergedGeometry(IGeometry geometry, IFeatureClass outputFeatureClass)
        {
            if (geometry == null)
            {
                return;
            }

            IFeatureBuffer featureBuffer = outputFeatureClass.CreateFeatureBuffer();
            featureBuffer.Shape = geometry;

            IFeatureCursor insertCursor = outputFeatureClass.Insert(true);
            insertCursor.InsertFeature(featureBuffer);
            insertCursor.Flush();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(insertCursor);
        }

        static bool IsValidGeometry(IGeometry geometry)
        {
            ITopologicalOperator2 topoOperator = geometry as ITopologicalOperator2;
            if (topoOperator != null)
            {
                return topoOperator.IsKnownSimple;
            }
            return false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "5000";
            textBox2.Text = "2000";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class ShapeFileMerger
    {
        public void MergeFeaturesByGrade(string inputShapePath, string outputShapePath)
        {
            // 打开输入shape文件
            IWorkspaceFactory workspaceFactory = new ShapefileWorkspaceFactory();
            IFeatureWorkspace featureWorkspace = (IFeatureWorkspace)workspaceFactory.OpenFromFile(System.IO.Path.GetDirectoryName(inputShapePath), 0);
            IFeatureClass inputFeatureClass = featureWorkspace.OpenFeatureClass(System.IO.Path.GetFileNameWithoutExtension(inputShapePath));

            // 创建输出shape文件
            IWorkspaceFactory outputWorkspaceFactory = new ShapefileWorkspaceFactory();
            IWorkspace outputWorkspace = outputWorkspaceFactory.OpenFromFile(System.IO.Path.GetDirectoryName(outputShapePath), 0);
            IFeatureWorkspace outputFeatureWorkspace = (IFeatureWorkspace)outputWorkspace;

            // 创建输出要素类
            IFields fields = inputFeatureClass.Fields;
            IFeatureClassDescription fcDescription = new FeatureClassDescriptionClass();
            IObjectClassDescription ocDescription = (IObjectClassDescription)fcDescription;
            IFieldsEdit fieldsEdit = new FieldsClass();

            // 获取输入要素类的空间参考
            ISpatialReference spatialReference = null;
            IGeometryDef geometryDef = inputFeatureClass.Fields.get_Field(inputFeatureClass.FindField(inputFeatureClass.ShapeFieldName)).GeometryDef;
            if (geometryDef != null)
            {
                spatialReference = geometryDef.SpatialReference;
            }

            // 复制输入要素类的字段
            for (int i = 0; i < fields.FieldCount; i++)
            {
                IField field = fields.get_Field(i);
                if (field.Type != esriFieldType.esriFieldTypeOID &&
                    field.Type != esriFieldType.esriFieldTypeGeometry)
                {
                    IFieldEdit fieldEdit = new FieldClass();
                    fieldEdit.Name_2 = field.Name;
                    fieldEdit.Type_2 = field.Type;
                    fieldEdit.Length_2 = field.Length;
                    fieldEdit.Precision_2 = field.Precision;
                    fieldEdit.Scale_2 = field.Scale;
                    fieldEdit.IsNullable_2 = field.IsNullable;
                    fieldsEdit.AddField(fieldEdit);
                }
            }

            // 添加形状字段
            IGeometryDef newGeometryDef = new GeometryDefClass();
            IGeometryDefEdit geometryDefEdit = (IGeometryDefEdit)newGeometryDef;
            geometryDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPolyline;
            geometryDefEdit.SpatialReference_2 = spatialReference;

            IField geometryField = new FieldClass();
            IFieldEdit geometryFieldEdit = (IFieldEdit)geometryField;
            geometryFieldEdit.Name_2 = "Shape";
            geometryFieldEdit.Type_2 = esriFieldType.esriFieldTypeGeometry;
            geometryFieldEdit.GeometryDef_2 = newGeometryDef;
            fieldsEdit.AddField(geometryField);

            IFeatureClass outputFeatureClass = outputFeatureWorkspace.CreateFeatureClass(
                System.IO.Path.GetFileNameWithoutExtension(outputShapePath),
                fieldsEdit,
                ocDescription.InstanceCLSID,
                ocDescription.ClassExtensionCLSID,
                esriFeatureType.esriFTSimple,
                "Shape",
                "");

            // 处理grade为1和2的要素
            ProcessGradeFeatures(inputFeatureClass, outputFeatureClass, 1);
            ProcessGradeFeatures(inputFeatureClass, outputFeatureClass, 2);
        }

        private void ProcessGradeFeatures(IFeatureClass inputFeatureClass, IFeatureClass outputFeatureClass, int gradeValue)
        {
            IQueryFilter queryFilter = new QueryFilterClass();
            queryFilter.WhereClause = "grade = " + gradeValue;

            IFeatureCursor inputCursor = null;
            try
            {
                inputCursor = inputFeatureClass.Search(queryFilter, false);
                IFeature inputFeature = null;
                IGeometryCollection geometryCollection = new PolylineClass();
                IGeometry mergedGeometry = null;

                while ((inputFeature = inputCursor.NextFeature()) != null)
                {
                    IGeometry geometry = inputFeature.Shape;
                    if (geometry != null && geometry.GeometryType == esriGeometryType.esriGeometryPolyline)
                    {
                        if (mergedGeometry == null)
                        {
                            mergedGeometry = geometry;
                        }
                        else
                        {
                            ITopologicalOperator topologicalOperator = mergedGeometry as ITopologicalOperator;
                            mergedGeometry = topologicalOperator.Union(geometry);
                        }
                    }
                }

                if (mergedGeometry != null)
                {
                    // 创建新要素并设置属性
                    IFeature outputFeature = outputFeatureClass.CreateFeature();
                    outputFeature.Shape = mergedGeometry;
                    int gradeFieldIndex = outputFeature.Fields.FindField("grade");
                    if (gradeFieldIndex != -1)
                    {
                        outputFeature.set_Value(gradeFieldIndex, gradeValue);
                    }
                    outputFeature.Store();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("出现错误: " + ex.Message);
            }
            finally
            {
                if (inputCursor != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(inputCursor);
                }
            }
        }
    }
    public class ShapefileIntersection
    {
        public void PerformIntersection(string inputShapefile1, string inputShapefile2, string outputShapefile)
        {
            try
            {
                // 检查输出路径
                string outputDir = System.IO.Path.GetDirectoryName(outputShapefile);
                if (!Directory.Exists(outputDir))
                {
                    Console.WriteLine($"Output directory does not exist: {outputDir}");
                    Directory.CreateDirectory(outputDir);
                    Console.WriteLine($"Created output directory: {outputDir}");
                }

                // 打开输入Shapefiles
                IFeatureClass featureClass1 = OpenShapefile(inputShapefile1);
                IFeatureClass featureClass2 = OpenShapefile(inputShapefile2);

                // 创建输出Shapefile
                IFeatureClass outputFeatureClass = CreateOutputShapefile(outputShapefile, featureClass1.Fields);

                if (outputFeatureClass == null)
                {
                    Console.WriteLine("Failed to create output feature class. Trying alternative method.");
                    outputFeatureClass = CreateOutputShapefileAlternative(outputShapefile, featureClass1);
                }

                if (outputFeatureClass == null)
                {
                    Console.WriteLine("Failed to create output feature class using both methods.");
                    return;
                }

                // 执行交集操作
                PerformIntersectionOperation(featureClass1, featureClass2, outputFeatureClass);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
            }
        }

        private void PerformIntersectionOperation(IFeatureClass featureClass1, IFeatureClass featureClass2, IFeatureClass outputFeatureClass)
        {
            IFeatureCursor cursor1 = featureClass1.Search(null, false);
            IFeature feature1;

            while ((feature1 = cursor1.NextFeature()) != null)
            {
                IGeometry geometry1 = feature1.Shape;
                ITopologicalOperator topologicalOperator = geometry1 as ITopologicalOperator;

                if (topologicalOperator == null)
                {
                    continue;
                }

                IFeatureCursor cursor2 = featureClass2.Search(null, false);
                IFeature feature2;

                while ((feature2 = cursor2.NextFeature()) != null)
                {
                    IGeometry geometry2 = feature2.Shape;
                    IGeometry intersection = topologicalOperator.Intersect(geometry2, esriGeometryDimension.esriGeometry2Dimension);

                    if (intersection != null && !intersection.IsEmpty)
                    {
                        CreateNewFeature(outputFeatureClass, intersection, feature1);
                    }
                }
                Marshal.ReleaseComObject(cursor2);
            }
            Marshal.ReleaseComObject(cursor1);
        }

        private void CreateNewFeature(IFeatureClass featureClass, IGeometry geometry, IFeature sourceFeature)
        {
            IFeature newFeature = featureClass.CreateFeature();
            newFeature.Shape = geometry;

            for (int i = 0; i < sourceFeature.Fields.FieldCount; i++)
            {
                IField field = sourceFeature.Fields.Field[i];
                if (!field.Editable || field.Type == esriFieldType.esriFieldTypeGeometry || field.Type == esriFieldType.esriFieldTypeOID)
                {
                    continue;
                }

                try
                {
                    newFeature.Value[newFeature.Fields.FindField(field.Name)] = sourceFeature.Value[i];
                }
                catch (COMException)
                {
                    Console.WriteLine($"Failed to copy field: {field.Name}");
                }
            }

            newFeature.Store();
        }

        private IFeatureClass OpenShapefile(string shapefilePath)
        {
            IWorkspaceFactory workspaceFactory = new ShapefileWorkspaceFactory();
            IFeatureWorkspace featureWorkspace = (IFeatureWorkspace)workspaceFactory.OpenFromFile(System.IO.Path.GetDirectoryName(shapefilePath), 0);
            return featureWorkspace.OpenFeatureClass(System.IO.Path.GetFileNameWithoutExtension(shapefilePath));
        }

        private IFeatureClass CreateOutputShapefile(string outputPath, IFields sourceFields)
        {
            try
            {
                IWorkspaceFactory workspaceFactory = new ShapefileWorkspaceFactory();
                IWorkspace workspace = workspaceFactory.OpenFromFile(System.IO.Path.GetDirectoryName(outputPath), 0);
                IFeatureWorkspace featureWorkspace = (IFeatureWorkspace)workspace;

                IFields newFields = CreateNewFields(sourceFields);

                string className = System.IO.Path.GetFileNameWithoutExtension(outputPath);
                Console.WriteLine($"Creating new feature class: {className}");

                // 打印字段信息
                for (int i = 0; i < newFields.FieldCount; i++)
                {
                    IField field = newFields.Field[i];
                    Console.WriteLine($"Field {i}: Name = {field.Name}, Type = {field.Type}, Editable = {field.Editable}");
                }

                IFeatureClass newFeatureClass = featureWorkspace.CreateFeatureClass(
                    className,
                    newFields,
                    null,
                    null,
                    esriFeatureType.esriFTSimple,
                    "Shape",
                    "");

                if (newFeatureClass == null)
                {
                    Console.WriteLine("CreateFeatureClass returned null.");
                }
                else
                {
                    Console.WriteLine($"Successfully created feature class: {newFeatureClass.AliasName}");
                }

                return newFeatureClass;
            }
            catch (COMException comEx)
            {
                Console.WriteLine($"COM Exception in CreateOutputShapefile: {comEx.Message}");
                Console.WriteLine($"HRESULT: {comEx.ErrorCode}");
                Console.WriteLine($"Stack Trace: {comEx.StackTrace}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in CreateOutputShapefile: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                return null;
            }
        }

        private IFields CreateNewFields(IFields sourceFields)
        {
            IFields newFields = new FieldsClass();
            IFieldsEdit newFieldsEdit = (IFieldsEdit)newFields;

            for (int i = 0; i < sourceFields.FieldCount; i++)
            {
                IField field = sourceFields.Field[i];
                if (field.Editable && field.Type != esriFieldType.esriFieldTypeOID)
                {
                    IField newField = new FieldClass();
                    IFieldEdit newFieldEdit = (IFieldEdit)newField;
                    newFieldEdit.Name_2 = field.Name;
                    newFieldEdit.Type_2 = field.Type;
                    newFieldEdit.Length_2 = field.Length;
                    newFieldsEdit.AddField(newField);
                }
            }

            // 确保添加了形状字段
            if (newFields.FindField("Shape") == -1)
            {
                IGeometryDef geometryDef = new GeometryDefClass();
                IGeometryDefEdit geometryDefEdit = (IGeometryDefEdit)geometryDef;
                geometryDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPolygon;
                geometryDefEdit.SpatialReference_2 = sourceFields.Field[sourceFields.FindField("Shape")].GeometryDef.SpatialReference;

                IField shapeField = new FieldClass();
                IFieldEdit shapeFieldEdit = (IFieldEdit)shapeField;
                shapeFieldEdit.Name_2 = "Shape";
                shapeFieldEdit.Type_2 = esriFieldType.esriFieldTypeGeometry;
                shapeFieldEdit.GeometryDef_2 = geometryDef;
                newFieldsEdit.AddField(shapeField);
            }

            return newFields;
        }
        private IFeatureClass CreateOutputShapefileAlternative(string outputPath, IFeatureClass sourceFeatureClass)
        {
            try
            {
                // 使用 IFeatureClassDescription 来创建默认字段
                IFeatureClassDescription fcDescription = new FeatureClassDescriptionClass();
                IObjectClassDescription ocDescription = (IObjectClassDescription)fcDescription;
                IFields fields = ocDescription.RequiredFields;
                IFieldsEdit fieldsEdit = (IFieldsEdit)fields;

                // 添加源要素类的字段
                for (int i = 0; i < sourceFeatureClass.Fields.FieldCount; i++)
                {
                    IField sourceField = sourceFeatureClass.Fields.Field[i];
                    if (sourceField.Type != esriFieldType.esriFieldTypeOID && sourceField.Type != esriFieldType.esriFieldTypeGeometry)
                    {
                        IField newField = new FieldClass();
                        IFieldEdit fieldEdit = (IFieldEdit)newField;
                        fieldEdit.Name_2 = sourceField.Name;
                        fieldEdit.Type_2 = sourceField.Type;
                        fieldEdit.Length_2 = sourceField.Length;
                        fieldsEdit.AddField(newField);
                    }
                }

                // 设置几何字段的空间参考
                int shapeFieldIndex = fields.FindField("Shape");
                IField shapeField = fields.Field[shapeFieldIndex];
                IGeometryDef geometryDef = shapeField.GeometryDef;
                IGeometryDefEdit geometryDefEdit = (IGeometryDefEdit)geometryDef;
                geometryDefEdit.SpatialReference_2 = sourceFeatureClass.Fields.Field[sourceFeatureClass.FindField("Shape")].GeometryDef.SpatialReference;

                // 创建要素类
                IWorkspaceFactory workspaceFactory = new ShapefileWorkspaceFactory();
                IWorkspace workspace = workspaceFactory.OpenFromFile(System.IO.Path.GetDirectoryName(outputPath), 0);
                IFeatureWorkspace featureWorkspace = (IFeatureWorkspace)workspace;

                return featureWorkspace.CreateFeatureClass(
                    System.IO.Path.GetFileNameWithoutExtension(outputPath),
                    fields,
                    null,
                    null,
                    esriFeatureType.esriFTSimple,
                    "Shape",
                    "");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in CreateOutputShapefileAlternative: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                return null;
            }
        }
    }
}


