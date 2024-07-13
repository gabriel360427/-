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
    public class ihsInverseTransformCommand : BaseCommand
    {
        public ihsInverseTransformCommand()
        {
            base.Caption = "IHS逆变换";
            base.ToolTip = "IHS逆变换";
        }
        public override void OnClick()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "请选择要打开的数据：";
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "栅格数据(*.tiff;*.img)|*.tif;*.tiff;*.img";
            openFileDialog.InitialDirectory = @"C:\Users\Administrator\Desktop\绿廊智绘\演示数据";
            if (openFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            // 打开栅格数据集
            string filePath = openFileDialog.FileName;
            IRasterDataset rDataset = PIE.DataSource.DatasetFactory.OpenRasterDataset(filePath, OpenMode.ReadOnly);
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

            // 1、参数设置
            PIE.CommonAlgo.RGBTrans_Exchange_Info info = new PIE.CommonAlgo.RGBTrans_Exchange_Info();
            info.m_strInputFile = filePath;
            info.m_strOutputFile = outFilePath;
            info.m_strFileTypeCode="GTiff"; 
            info.m_vecBandIndex = new List<int> { 1,2,3 };
            info.m_vecBandOutIndex = new List<int> { 0,1,2 };
            //PIE.SystemAlgo.ISystemAlgo algo = PIE.SystemAlgo.AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.TransformRGB2IHSAlgo"); //正变换
            PIE.SystemAlgo.ISystemAlgo algo = PIE.SystemAlgo.AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.TransformIHS2RGBAlgo"); //逆变换
            if (algo == null) return;
 
            //2、算法执行
            PIE.SystemAlgo.ISystemAlgoEvents algoEvents = algo as PIE.SystemAlgo.ISystemAlgoEvents;
            algo.Name = " 彩色空间正变换";             
            algo.Params = info;
            bool result = PIE.SystemAlgo.AlgoFactory.Instance().ExecuteAlgo(algo);
 
            //3、结果显示
            ILayer layer = PIE.Carto.LayerFactory.CreateDefaultLayer(outFilePath);
             m_HookHelper.ActiveView.FocusMap.AddLayer(layer);
             m_HookHelper.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
            }
    }
}
