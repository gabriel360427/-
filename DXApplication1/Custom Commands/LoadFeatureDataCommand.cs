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
    public class LoadFeatureDataCommand : BaseCommand
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public LoadFeatureDataCommand()
        {
            base.Caption = "加载矢量数据";
            base.ToolTip = "加载矢量数据";
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
                openFileDialog.Filter = "矢量数据(*.shp)|*.shp";
                openFileDialog.InitialDirectory = @"C:\Users\Administrator\Desktop\黄河故道生态富民廊道\演示数据";
                if (openFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
                // 打开矢量数据集
                string filePath = openFileDialog.FileName;
                IFeatureDataset fDataset = DatasetFactory.OpenFeatureDataset(filePath);
                if (fDataset == null) return;
                // 创建矢量图层
                IFeatureLayer fLayer = PIE.Carto.LayerFactory.CreateDefaultFeatureLayer(fDataset);
                if (fLayer == null) return;
                // 添加图层到地图并刷新
                m_HookHelper.FocusMap.AddLayer(fLayer as ILayer);
                m_HookHelper.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
