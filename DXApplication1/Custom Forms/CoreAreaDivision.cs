using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PIE.Carto;
using PIE.CommonAlgo;
using PIE.SystemAlgo;
using PIE.DataSource;
using PIE.Geometry;
using System.IO;

namespace 绿廊智绘.Custom_Forms
{
    public partial class CoreAreaDivision : DevExpress.XtraEditors.XtraForm
    {
        public CoreAreaDivision()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "输入核心区文件";
            openfile.Filter = "矢量文件|*.shp";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                comboBox1.Text = openfile.FileName;//输入Shp矢量文件
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "保存矢量数据";
            save.Filter = "矢量数据|*.shp";
            if (save.ShowDialog() == DialogResult.OK)
            {
                comboBox2.Text = save.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //打开需要使用的矢量数据集
            IFeatureDataset featureDataset1 = DatasetFactory.OpenFeatureDataset(comboBox1.Text);
            //设置查询条件
            IQueryFilter queryFilter = new QueryFilter();
            string filter = ("Area>=1500000");
            queryFilter.SetAttributeQuery(filter);

            ILayer layer1 = null;
            layer1 = PIE.Carto.LayerFactory.CreateDefaultFeatureLayer(featureDataset1) as PIE.Carto.ILayer;
            IFeatureLayer featureLayer1 = layer1 as IFeatureLayer;
            //得到查询结果
            IFeatureCursor featureCursor = featureLayer1.FeatureClass.Search(queryFilter);
            IFeature feature = null;
            feature = featureCursor.NextFeature();
            //创建新的矢量数据集
            IFields fields = feature.GetFields();
            string path = comboBox2.Text;
            int index = path.LastIndexOf(".");
            //创建空间参考信息
            //ISpatialReference spatialReference = SpatialReferenceFactory.CreateSpatialReference((int)PIE.Geometry.GeoCSType.GeoCSType_WGS1984);
            ISpatialReference spatialReference = featureDataset1.SpatialReference;
            IFeatureDataset newFeatureDataset = DatasetFactory.CreateFeatureDataset(path.Insert(index,"一级"), fields, GeometryType.GeometryPolygon, spatialReference, "SHP");
            while (feature != null)
            {
                //feature = featureDataset1.GetNextFeature();
                //feature = featureCursor.NextFeature();
                newFeatureDataset.AddFeature(feature);
                //featureDataset1.DeleteFeature(feature.FID);                
                //newFeatureDataset.UpdateFeature(feature);
                feature = featureCursor.NextFeature();

            }
            // 保存数据集
            newFeatureDataset.Save();
            //featureDataset1.Save();

            //创建二级核心区存储文件
            IQueryFilter queryFilter2 = new QueryFilter();
            
            string filter2 = ("Area<1500000");
            //string filter4 = "Area<=1500000&&Area>=600000";
            //string filter3 = ("Area>=600000");
            queryFilter2.SetAttributeQuery(filter2);            
            //queryFilter3.SetAttributeQuery(filter3);
            ILayer layer2 = null;
            layer2 = PIE.Carto.LayerFactory.CreateDefaultFeatureLayer(featureDataset1) as PIE.Carto.ILayer;
            IFeatureLayer featureLayer2 = layer2 as IFeatureLayer;
            //得到查询结果
            IFeatureCursor featureCursor2 = featureLayer2.FeatureClass.Search(queryFilter2);
            ///featureCursor2 = featureLayer2.FeatureClass.Search(queryFilter3);
            IFeature feature2 = null;
            feature2 = featureCursor2.NextFeature();           
            IFeatureDataset newFeatureDataset2 = DatasetFactory.CreateFeatureDataset(path, fields, GeometryType.GeometryPolygon, spatialReference, "SHP");
            while (feature2 != null)
            {
                
                newFeatureDataset2.AddFeature(feature2);                
                feature2 = featureCursor2.NextFeature();

            }           
            newFeatureDataset2.Save();


            IFeatureDataset featureDataset2 = DatasetFactory.OpenFeatureDataset(path.Insert(index, "二级"));
            IQueryFilter queryFilter3 = new QueryFilter();
            string filter3 = ("Area>=1000000");
            queryFilter3.SetAttributeQuery(filter3);
            
            ILayer layer3 = null;
            layer3 = PIE.Carto.LayerFactory.CreateDefaultFeatureLayer(newFeatureDataset2) as PIE.Carto.ILayer;
            IFeatureLayer featureLayer3 = layer3 as IFeatureLayer;
            
            IFeatureCursor featureCursor3 = featureLayer3.FeatureClass.Search(queryFilter3);                        
            IFeature feature3 = featureCursor3.NextFeature();
            IFeatureDataset newFeatureDataset3 = DatasetFactory.CreateFeatureDataset(path.Insert(index, "二级"), fields, GeometryType.GeometryPolygon, spatialReference, "SHP");
            while (feature3 != null)
            {
                newFeatureDataset3.AddFeature(feature3);
                feature3 = featureCursor3.NextFeature();
            }
            newFeatureDataset3.Save();
            
            /*
            FileAttributes attr = File.GetAttributes(path);
            // 3、根据具体类型进行删除
            if (attr == FileAttributes.Directory)
            {

                // 3.1、删除文件夹
                Directory.Delete(path, true);
            }
            else
            {
                // 3.2、删除文件
                File.Delete(path);
            }
             * */

            /*
            //IFeature feature3 = newFeatureDataset.GetNextFeature();
            //IFeature feature4 = newFeatureDataset2.GetNextFeature();
            for (int i = 0; i < newFeatureDataset2.GetFeatureCount(); i++)
            {
                for (int j = 0; j < newFeatureDataset.GetFeatureCount(); j++)
                {
                    IFeature feature3 = newFeatureDataset.GetFeature(j);
                    IFeature feature4 = newFeatureDataset2.GetFeature(i);
                    if (feature3.GetValue("Area") == feature4.GetValue("Area"))
                    {
                        newFeatureDataset2.DeleteFeature(feature4.FID);
                        newFeatureDataset2.UpdateFeature(feature4);
                    }
                }
            }
            
            newFeatureDataset2.Save();
             * */

            MessageBox.Show("执行成功");
            comboBox1.Text = "";
            comboBox2.Text = "";
            //this.Close();
        }

        private void 核心区划分_Load(object sender, EventArgs e)
        {

        }
    }
}
