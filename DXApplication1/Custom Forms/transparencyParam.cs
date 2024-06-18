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
    public partial class transparencyParam : DevExpress.XtraEditors.XtraForm
    {
        public transparencyParam(ILayer currentlayer)
        {
            InitializeComponent();
            if (currentlayer != null)
            {
                if(currentlayer.LayerType.Equals(LayerType.LayerTypeRasterLayer))
                {
                    IRasterLayer rasterLayer = currentlayer as IRasterLayer;
                    if (rasterLayer != null)
                    {
                        IRasterStretch rasterStretch = rasterLayer.Render as IRasterStretch;
                        this.numericUpDownTransparency.Value = (int)(rasterStretch as IRasterDisplayProps).TransparencyValue;
                    }
                }
                else if(currentlayer.LayerType.Equals(LayerType.LayerTypeFeatureLayer))
                {
                    IFeatureLayer featureLayer = currentlayer as IFeatureLayer;
                    if (featureLayer != null)
                    {
                        this.numericUpDownTransparency.Value = featureLayer.Render.Transparency;
                    }
                }
            }
            //if (currentlayer.LayerType.Equals(LayerType.LayerTypeFeatureLayer))
            //{
            //    IFeatureLayer featureLayer = mapControlMain.ActiveView.CurrentLayer as IFeatureLayer;
            //    if (featureLayer != null)
            //    {
            //        featureLayer.Render.Transparency = transparency;
            //        featureLayer.RaiseRenderChanged();
            //        mapControlMain.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
            //    }
            //}
            //else if (currentlayer.LayerType.Equals(LayerType.LayerTypeRasterLayer))
            //{
            //    IRasterLayer rasterLayer = mapControlMain.ActiveView.CurrentLayer as IRasterLayer;
            //    if (rasterLayer != null)
            //    {
            //        IRasterStretch rStretch = rasterLayer.Render as IRasterStretch;
            //        (rStretch as IRasterDisplayProps).TransparencyValue = transparency;
            //        rasterLayer.RaiseRenderChanged();
            //        mapControlMain.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
            //    }
            //}
        }

        public int Transparency
        {
            get
            {
                return (int)this.numericUpDownTransparency.Value;
            }
        }

        private void transparencyBtnConfirm(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void transparencyBtnCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
