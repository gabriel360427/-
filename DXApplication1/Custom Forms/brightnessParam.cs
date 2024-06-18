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
    public partial class brightnessParam : DevExpress.XtraEditors.XtraForm
    {
        public brightnessParam(IRasterLayer rasterLayer)
        {
            InitializeComponent();
            if (rasterLayer != null)
            {
                IRasterStretch rasterStretch = rasterLayer.Render as IRasterStretch;
                this.numericUpDownBrightness.Value = (int)(rasterStretch as IRasterDisplayProps).BrightnessValue;
            }
        }

        public int Brightness
        {
            get
            {
                return (int)this.numericUpDownBrightness.Value;
            }
        }

        private void brightnessBtnConfirm(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void brightnessBtnCancel(object sender, MouseEventArgs e)
        {
            this.Close();
        }

    }
}
