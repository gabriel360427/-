using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using PIE.DataSource;
using PIE.Carto;
using PIE.AxControls;
using PIE.CommonAlgo;
using PIE.SystemAlgo;

namespace 城市空间生态格局智能评估系统.Custom_Forms
{
    public partial class distanceClassifyForm : DevExpress.XtraEditors.XtraForm
    {
        public distanceClassifyForm(MapControl map)
        {
            InitializeComponent();
            m_Map = map;
            IList<ILayer> layerList = new List<ILayer>();
            layerList = map.ActiveView.FocusMap.GetAllLayer();
            foreach (ILayer currentlayer in layerList)
            {
                if (currentlayer.LayerType.Equals(LayerType.LayerTypeRasterLayer))
                {
                    this.inputImagelistBox.Items.Add(currentlayer.DataSourcePath);
                }
                if (currentlayer.LayerType.Equals(LayerType.LayerTypeGraphicsLayer))
                {
                    this.selectedROIListBox.Items.Add(currentlayer.Name);
                }
            }
        }

        public ROIStatistics_Exchange_Info m_roiDataInfo;

        private MapControl m_Map;

        public string selectedImage;

        public string resultImage;

        private PIE.CommonAlgo.SupervisedClassification_Exchange_Info m_DataInfo = new PIE.CommonAlgo.SupervisedClassification_Exchange_Info();

        public int CStartFrm;

        public int CEndFrm;

        public int RStartFrm;

        public int REndFrm;

        public int SelectBandNums
        {
            get
            {
                return int.Parse(bandNumLabel.Text);
            }
        }

        public int ClassType;

        public List<int> listBandIndex = new List<int>();

        public IGraphicsLayer ROILayer;

        private void inputImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "栅格数据(*.tiff)|*.tif;*.tiff;*.img;*.dat";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            string filePath = openFileDialog.FileName;
            selectedImage = filePath;
            inputImagelistBox.Items.Add(openFileDialog.FileName);
            IRasterDataset rDataset = PIE.DataSource.DatasetFactory.OpenRasterDataset(filePath, OpenMode.ReadOnly);
            int bandcount = rDataset.GetBandCount();
        }

        private void inputImagelistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            imageInfolabel.Text = "";
            /// <summary>
            /// BUG修改
            /// </summary>
            if (inputImagelistBox.SelectedItem == null) return;
            /// <summary>
            /// BUG修改
            /// </summary>
            selectedImage = inputImagelistBox.SelectedItem.ToString();
            if (selectedImage == null) return;
            IRasterDataset rDataset = PIE.DataSource.DatasetFactory.OpenRasterDataset(selectedImage, OpenMode.ReadOnly);
            imageInfolabel.Text = "文件路径：" + rDataset.FullName + "\n" +
                "数据类型：" + rDataset.DataSourceType + "\n" +
                "波段数：" + rDataset.GetBandCount() + "\n" +
                "宽：" + rDataset.GetRasterXSize() + "\n" +
                "高：" + rDataset.GetRasterYSize();
            lineStartTextBox.Text = "0";
            columnStartTextBox.Text = "0";
            lineEndTextBox.Text = (rDataset.GetRasterYSize() - 1).ToString();
            columnEndTextBox.Text = (rDataset.GetRasterXSize() - 1).ToString();
            int bandcount = rDataset.GetBandCount();
            /// <summary>
            /// BUG修改
            /// </summary>
            imageBandListBox.Items.Clear();
            /// <summary>
            /// BUG修改
            /// </summary>
            for (int i = 1; i <= bandcount; i++)
            {
                this.imageBandListBox.Items.Add("波段" + i);
                this.imageBandListBox.SelectedItems.Add("波段" + i);
            }
        }

        private void imageBandListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBandIndex.Clear();
            bandNumLabel.Text = imageBandListBox.SelectedItems.Count.ToString();
            //m_DataInfo.SelBandNums = imageBandListBox.SelectedItems.Count;
            for (int i = 0; i < SelectBandNums; i++)
            {
                listBandIndex.Add(i + 1);
            }
        }

        private void clearBandsBtn_Click(object sender, EventArgs e)
        {
            imageBandListBox.ClearSelected();
            bandNumLabel.Text = imageBandListBox.SelectedItems.Count.ToString();
        }

        private void lineStartTextBox_TextChanged(object sender, EventArgs e)
        {
            RStartFrm = int.Parse(lineStartTextBox.Text.ToString());
            m_DataInfo.RStart = RStartFrm;
        }

        private void lineEndTextBox_TextChanged(object sender, EventArgs e)
        {
            REndFrm = int.Parse(lineEndTextBox.Text.ToString());
            m_DataInfo.REnd = REndFrm;
        }

        private void columnStartTextBox_TextChanged(object sender, EventArgs e)
        {
            CStartFrm = int.Parse(columnStartTextBox.Text.ToString());
            m_DataInfo.CStart = CStartFrm;
        }

        private void columnEndTextBox_TextChanged(object sender, EventArgs e)
        {
            CEndFrm = int.Parse(columnEndTextBox.Text.ToString());
            m_DataInfo.CEnd = CEndFrm;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectedClassifierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(selectedClassifierComboBox.SelectedItem == "最小距离分类")
            {
                ClassType = 11;
            }
            else if(selectedClassifierComboBox.SelectedItem == "马氏距离分类")
            {
                ClassType = 12;
            }
        }

        private void selectResultImageBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "栅格数据(*.img)|*.img";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            string filePath = saveFileDialog.FileName;
            resultImage = filePath;
            this.resultImageTextBox.Text = filePath;
        }

        private void selectedROIListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IList<ILayer> listLayer = m_Map.ActiveView.FocusMap.GetAllLayer();
            foreach (ILayer item in listLayer)
            {
                if (item.LayerType.Equals(LayerType.LayerTypeGraphicsLayer))//"roi_layer"//得到利用分类工具生成的roi文件
                {
                    ROILayer = item as IGraphicsLayer;
                }
            }
        }
    }
}
