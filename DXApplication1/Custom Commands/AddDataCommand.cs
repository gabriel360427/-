using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIE.AxControls;
using PIE.Controls;
using PIE.Carto;

namespace 绿廊智绘.Custom_Commands 
{
    public class AddDataCommand : BaseCommand
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public AddDataCommand()
        {
            base.Caption = "加载数据";
            base.ToolTip = "加载数据";
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
                openFileDialog.Filter = "All Files|*.*|Shape Files|*.shp|Raster Files|*.tif;*.tiff;*.dat;*.bmp;*.img;*.jpg|HDF Files|*.hdf;*.h5|NC Files|*.nc";
                openFileDialog.InitialDirectory = @"C:\Users\Administrator\Desktop\绿廊智绘\演示数据";
                if (openFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
                // 打开文件刷新
                string filePath = openFileDialog.FileName;
                m_HookHelper.FocusMap.AddLayer(PIE.Carto.LayerFactory.CreateDefaultLayer(filePath));
                m_HookHelper.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
