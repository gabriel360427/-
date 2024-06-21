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

namespace 绿廊智绘.Custom_Forms
{
    public partial class contrastRatioParam : DevExpress.XtraEditors.XtraForm
    {
        public contrastRatioParam(IRasterLayer rasterLayer)
        {
            InitializeComponent();
            if (rasterLayer != null)
            {
                IRasterStretch rasterStretch = rasterLayer.Render as IRasterStretch;
                this.numericUpDownContrastRatio.Value = (int)(rasterStretch as IRasterDisplayProps).ContrastValue;
            }
        }

        public int ContrastRatio
        {
            get
            {
                return (int)this.numericUpDownContrastRatio.Value;
            }
        }

        private void contrastRatioBtnConfirm(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void contrastRatioBtnCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
