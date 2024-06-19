using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIE.Carto;
using PIE.Controls;
using PIE.AxControls;
using PIE.DataSource;
using PIE.Geometry;

namespace 城市空间生态格局智能评估系统.Custom_Tools
{
    public class SpatialQueryTool : BaseTool
    {
        private IMapControl m_MapControl;
        /// <summary>
        /// 构造函数
        /// </summary>
        public SpatialQueryTool()
        {
            base.Caption = "空间查询工具";
            base.Name = "空间查询";
            base.ToolTip = "拉框查询";
        }
        //重写鼠标down事件
        public override void OnMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (m_HookHelper.ActiveView == null)
            {
                return;
            }
            m_MapControl = m_HookHelper.Hook as IMapControl;
            //空间查询改为拉框空间查询
            IMap map = m_MapControl.FocusMap;
            ILayer layer = map.GetLayer(0);
            IFeatureLayer featureLayer = layer as IFeatureLayer;
            IQueryFilter queryFilter = new QueryFilter();
            IEnvelope envelope = new Envelope();
            // 定义范围
            IEnvelope trackExtent = m_MapControl.TrackRectangle();
            envelope = trackExtent;
            queryFilter.SetSpatialQuery(envelope as IGeometry);
            IFeatureCursor featureCursor = featureLayer.FeatureClass.Search(queryFilter);
            if (featureCursor != null)
            {
                IFeature feature = null;
                feature = featureCursor.NextFeature();
                //地图显示得到的结果
                map.ClearSelectionFeatures();
                while (feature != null)
                {
                    m_MapControl.FocusMap.SelectFeature(featureLayer as ILayer, feature);
                    feature = featureCursor.NextFeature();
                }
                m_MapControl.PartialRefresh(ViewDrawPhaseType.ViewAll);
            }
            else 
            {
                MessageBox.Show("所选图层不是矢量数据，请选择矢量数据！");
            }
            
        }
    }
}
