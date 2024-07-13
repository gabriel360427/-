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
    public class clippingThroughGridRangeCommand : BaseCommand
    {
        public clippingThroughGridRangeCommand()
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

            PIE.CommonAlgo.DataPreImgClip_Exchange_Info info = new PIE.CommonAlgo.DataPreImgClip_Exchange_Info();
            info.InputFilePath = openFilePath;
            if (rDataset == null) return;
            int count = rDataset.GetBandCount();
            List<int> list = new List<int> { };
            for (int i = 0; i < count; i++)
            {
                list.Add(i);
            }
            info.listBands = list;
            info.XFactor = 1;
            info.YFactor = 1;
            info.bInvalidValue = false;
            info.OutputFilePath = outFilePath;  //裁剪保存结果
            info.Type = 0;  // (等于0表示通过栅格范围裁剪)
            info.XStart = 0;
            info.XEnd = 500;
            info.YStart = 0;
            info.YEnd = 500;
            info.FileType = "GTiff";  //Tiff数据的FileTypeCode为“GTiff”,IMG数据的FileTypeCode为"HFA",其他格式的为"ENVI"。;

            PIE.SystemAlgo.ISystemAlgo algo = PIE.SystemAlgo.AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.ImageClipAlgo");
            if (algo == null) return;

            //2、算法执行
            PIE.SystemAlgo.ISystemAlgoEvents algoEvents = algo as PIE.SystemAlgo.ISystemAlgoEvents;
            algo.Name = "影像裁剪";
            algo.Params = info;
            //PIE.SystemAlgo.AlgoFactory.Instance().AsynExecuteAlgo(algo);
            //bool OK = PIE.SystemAlgo.AlgoFactory.Instance().ExecuteAlgo(algo);
            bool OK = algo.Execute();
            MessageBox.Show("裁剪成功！");
            ILayer layer = LayerFactory.CreateDefaultLayer(info.OutputFilePath);
            if (layer == null) return;
             m_HookHelper.ActiveView.FocusMap.AddLayer(layer);
             m_HookHelper.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
        }
    }
}
