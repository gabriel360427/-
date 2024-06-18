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

namespace 城市空间生态格局智能评估系统.Custom_Commands
{
    public class LoadRasterDataCommand : BaseCommand
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public LoadRasterDataCommand()
        {
            base.Caption = "加载栅格数据";
            base.ToolTip = "加载栅格数据";
        }

        /// <summary>
        /// 重写单击按钮事件
        /// </summary>
        public override void OnClick()
        {
            try
            {
                // 打开文件对话框
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "请选择要打开的数据：";
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "栅格数据(*.tiff)|*.tif;*.tiff";
                openFileDialog.InitialDirectory = @"C:\Users\Administrator\Desktop\黄河故道生态富民廊道\演示数据";
                if (openFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
                // 打开栅格数据集
                string filePath = openFileDialog.FileName;
                IRasterDataset rDataset = PIE.DataSource.DatasetFactory.OpenRasterDataset(filePath, OpenMode.ReadOnly);
                if (rDataset == null) return;
                // 创建栅格图层
                IRasterLayer rasterlayer = PIE.Carto.LayerFactory.CreateDefaultRasterLayer(rDataset);
                if (rasterlayer == null) return;
                // 添加图层到地图并刷新
                m_HookHelper.FocusMap.AddLayer(rasterlayer as ILayer);
                m_HookHelper.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
