using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIE.AxControls;
using PIE.Controls;
using PIE.Carto;
using PIE.DataSource;
using PIE.Plugin;
using PIE.SystemAlgo;
using PIE.SystemUI;
using PIE.CommonAlgo;

namespace 绿廊智绘.Custom_Commands
{
    public class clippingThroughGeometricRangeCommand : BaseCommand
    {
        public clippingThroughGeometricRangeCommand()
        {
            base.Caption = "通过栅格范围裁剪";
            base.ToolTip = "通过栅格范围裁剪";
        }
        public override void OnClick()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "请选择要打开的数据：";
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "栅格数据(*.tiff;*.img)|*.tif;*.tiff;*.img";
            openFileDialog.InitialDirectory = @"C:\Users\Administrator\Desktop\示例\演示数据";
            if (openFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            // 打开栅格数据集
            string openFilePath = openFileDialog.FileName;
            IRasterDataset rDataset = PIE.DataSource.DatasetFactory.OpenRasterDataset(openFilePath, OpenMode.ReadOnly);
            if (rDataset == null) return;
            // 创建栅格图层
            IRasterLayer rasterlayer = PIE.Carto.LayerFactory.CreateDefaultRasterLayer(rDataset);
            if (rasterlayer == null) return;
            //设置保存路径
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "请选择输出路径：";
            saveFileDialog.Filter = "栅格数据(*.tiff;*.img)|*.tif;*.tiff;*.img";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            string outFilePath = saveFileDialog.FileName;

            // 打开矢量文件对话框
            OpenFileDialog openSHPDialog = new OpenFileDialog();
            openSHPDialog.Title = "请选择用于裁剪的矢量数据：";
            openSHPDialog.Multiselect = false;
            openSHPDialog.Filter = "矢量数据(*.shp)|*.shp";
            openSHPDialog.InitialDirectory = @"C:\Users\Administrator\Desktop\示例\演示数据";
            if (openSHPDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            // 打开矢量数据集
            string shpFilePath = openSHPDialog.FileName;
            IFeatureDataset fDataset = DatasetFactory.OpenFeatureDataset(shpFilePath);
            if (fDataset == null) return;

            PIE.CommonAlgo.DataPreImgClip_Exchange_Info info = new PIE.CommonAlgo.DataPreImgClip_Exchange_Info();
            //参数设置
            PIE.DataSource.IFeature feature = fDataset.GetNextFeature();
            fDataset.ResetReading();
            PIE.Geometry.IGeometry geometryClip = null;
            while (feature != null)
            {
                geometryClip = feature.Geometry;
                feature = fDataset.GetNextFeature();
                break;
            }
            info.InputFilePath = openFilePath;  //待裁剪影像
            if (rDataset == null) return;
            int count = rDataset.GetBandCount();
            List<int> list = new List<int> { };
            for (int i = 0; i < count; i++)
            {
                list.Add(i);
            }
            info.listBands = list;
            info.bInvalidValue = false;
            info.OutputFilePath = outFilePath;  //裁剪保存结果
            info.Type = 2;  // (等于2表示使用几何范围裁剪)
            info.Geometry = geometryClip;
            info.FileType = "GTiff";  //Tiff数据的FileTypeCode为“GTiff”,IMG数据的FileTypeCode为"HFA",其他格式的为"ENVI"。;
            PIE.SystemAlgo.ISystemAlgo algo = PIE.SystemAlgo.AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.ImageClipAlgo");
            if (algo == null) return;
            //2、算法执行
            PIE.SystemAlgo.ISystemAlgoEvents algoEvents = algo as PIE.SystemAlgo.ISystemAlgoEvents;
            algo.Name = "影像裁剪";
            algo.Params = info; PIE.SystemAlgo.AlgoFactory.Instance().AsynExecuteAlgo(algo);
            //bool OK = PIE.SystemAlgo.AlgoFactory.Instance().ExecuteAlgo(algo);
            //bool OK = algo.Execute();
            MessageBox.Show("裁剪成功！");
            ILayer layer = LayerFactory.CreateDefaultLayer(info.OutputFilePath);
            if (layer == null) return;
            m_HookHelper.ActiveView.FocusMap.AddLayer(layer);
            m_HookHelper.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
        }
    }
}
