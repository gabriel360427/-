using PIE.Carto;
using PIE.DataSource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 城市空间生态格局智能评估系统.Custom_Forms
{
    public partial class percentLinearStrechParam : DevExpress.XtraEditors.XtraForm
    {
        public percentLinearStrechParam(IRasterLayer rasterLayer)
        {
            InitializeComponent();
            if (rasterLayer != null)
            {
                //获取拉伸对象
                IRasterRender render = rasterLayer.Render;
                IRasterStretch stretch = render as IRasterStretch;
                //设置拉伸类型
                stretch.StretchType = PIE.Carto.RasterStretchType.RasterStretch_PercentMinimumMaximum;
                this.numericUpDownPercentLinearStrech.Value = (int)(stretch.LinearStretchPercent);
            }
        }

        public int percentLinearStrech
        {
            get
            {
                return (int)this.numericUpDownPercentLinearStrech.Value;
            }
        }

        private void percentLinearStretchBtnConfirm(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void percentLinearStretchBtnCancel(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
