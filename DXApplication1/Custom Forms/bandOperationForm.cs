using PIE.Carto;
using PIE.AxControls;
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

namespace 城市空间生态格局智能评估系统.Custom_Forms
{
    public partial class bandOperationForm : DevExpress.XtraEditors.XtraForm
    {
        public bandOperationForm(MapControl map)
        {
            InitializeComponent();
            int layercount;
            IList<ILayer> layerList = new List<ILayer>();
            layerList = map.ActiveView.FocusMap.GetAllLayer();
            layercount = map.ActiveView.FocusMap.LayerCount;
            Array.Resize<string>(ref layerName, layercount);
            Array.Resize<int>(ref layerBands, layercount);
            Array.Resize<string>(ref layerSource, layercount);
            List<string> layerN = layerName.ToList();
            List<int> layerB = layerBands.ToList();
            List<string> layerS = layerSource.ToList();
            foreach (ILayer currentlayer in layerList)
            {
                if (currentlayer.LayerType.Equals(LayerType.LayerTypeRasterLayer))
                {
                    this.ImageOnecomboBox.Items.Add(currentlayer.Name);
                    this.ImageTwocomboBox.Items.Add(currentlayer.Name);
                    layerN.Add(currentlayer.Name);
                    IRasterDataset rasterDataset = (currentlayer as IRasterLayer).Dataset;
                    layerB.Add(rasterDataset.GetBandCount());
                    layerS.Add(currentlayer.DataSourcePath);
                }
            }
            layerName = layerN.ToArray();
            layerBands = layerB.ToArray();
            layerSource = layerS.ToArray();
        }

        public string[] layerName = null;

        public int[] layerBands = null;

        public string[] layerSource = null;

        public string ImagePathOne;

        public string ImagePathTwo;

        public void getImageOneFilePath(MapControl map)
        {
            IList<ILayer> layerList = new List<ILayer>();
            layerList = map.ActiveView.FocusMap.GetAllLayer();
            foreach (ILayer currentlayer in layerList)
            {
                if (ImageOnecomboBox.Text == currentlayer.Name)
                {
                    ImagePathOne = currentlayer.DataSourcePath;
                    IRasterDataset rasterDataset = (currentlayer as IRasterLayer).Dataset;
                    int BandCount = rasterDataset.GetBandCount();
                    for (int i = 1; i <= BandCount; i++)
                    {
                        this.BandOnecomboBox.Items.Add(i);
                    }
                }
            }
        }

        public void getImageTwoFilePath(MapControl map)
        {
            IList<ILayer> layerList = new List<ILayer>();
            layerList = map.ActiveView.FocusMap.GetAllLayer();
            foreach (ILayer currentlayer in layerList)
            {
                if (ImageTwocomboBox.Text == currentlayer.Name)
                {
                    ImagePathTwo = currentlayer.DataSourcePath;
                    IRasterDataset rasterDataset = (currentlayer as IRasterLayer).Dataset;
                    int BandCount = rasterDataset.GetBandCount();
                    for (int i = 1; i <= BandCount; i++)
                    {
                        this.BandTwocomboBox.Items.Add(i);
                    }
                }
            }
        }

        public string ImageOne
        {
            get
            {
                return this.ImagePathOne;
            }
        }

        public string ImageTwo
        {
            get
            {
                return this.ImagePathTwo;
            }
        }

        public string BandResult
        {
            get
            {
                return this.BandResultTextBox.Text;
            }
        }

        public string CalExpression
        {
            get
            {
                return this.BandCalExpression.Text;
            }
        }

        public int BandOne
        {
            get
            {
                return int.Parse(this.BandOnecomboBox.Text);
            }
        }

        public int BandTwo
        {
            get
            {
                return int.Parse(this.BandTwocomboBox.Text);
            }
        }

        private void SelectBandOne_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "栅格数据(*.tiff)|*.tif;*.tiff";
            //if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            //string filePath = openFileDialog.FileName;
            //this.ImageOnecomboBox.Text = filePath.Substring(filePath.LastIndexOf("\\") + 1);
            //IRasterDataset rDataset = PIE.DataSource.DatasetFactory.OpenRasterDataset(filePath, OpenMode.ReadOnly);
            //int bandcount = rDataset.GetBandCount();
            //for (int i = 1; i <= bandcount; i++)
            //{
            //    this.BandOnecomboBox.Items.Add(i);
            //}
        }

        private void SelectBandTwo_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "栅格数据(*.tiff)|*.tif;*.tiff";
            //if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            //string filePath = openFileDialog.FileName;
            //this.ImageTwocomboBox.Text = filePath.Substring(filePath.LastIndexOf("\\") + 1);
            //IRasterDataset rDataset = PIE.DataSource.DatasetFactory.OpenRasterDataset(filePath, OpenMode.ReadOnly);
            //int bandcount = rDataset.GetBandCount();
            //for (int i = 1; i <= bandcount; i++)
            //{
            //    this.BandTwocomboBox.Items.Add(i);
            //}
        }

        private void SelectBandDest_Click(object sender, EventArgs e)
        {
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "栅格数据(*.tiff)|*.tif;*.tiff";
            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    //this.CalResultTextBox.Text = saveFileDialog.FileName.ToString();
            //    //FileStream fs = File.Open(saveFileDialog.FileName.ToString(), FileMode.Create);
            //}
        }

        private void CalConfirmBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CalCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectImageOne_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "栅格数据(*.tiff)|*.tif;*.tiff";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            string filePath = openFileDialog.FileName;
            this.ImageOnecomboBox.Text = filePath;
            ImagePathOne = filePath;
            IRasterDataset rDataset = PIE.DataSource.DatasetFactory.OpenRasterDataset(filePath, OpenMode.ReadOnly);
            int bandcount = rDataset.GetBandCount();
            for (int i = 1; i <= bandcount; i++)
            {
                this.BandOnecomboBox.Items.Add(i);
            }
        }

        private void SelectImageTwo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "栅格数据(*.tiff)|*.tif;*.tiff";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            string filePath = openFileDialog.FileName;
            this.ImageTwocomboBox.Text = filePath;
            ImagePathTwo = filePath;
            IRasterDataset rDataset = PIE.DataSource.DatasetFactory.OpenRasterDataset(filePath, OpenMode.ReadOnly);
            int bandcount = rDataset.GetBandCount();
            for (int i = 1; i <= bandcount; i++)
            {
                this.BandTwocomboBox.Items.Add(i);
            }
        }

        private void ImageOnecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BandOnecomboBox.Items.Clear();
            for (int i = 0; i < layerName.Length; i++)
            {
                if(ImageOnecomboBox.Text == layerName[i])
                {
                    for (int j = 1; j <= layerBands[i]; j++)
                    {
                        this.BandOnecomboBox.Items.Add(j);
                    }
                    ImagePathOne = layerSource[i];
                }
            }
        }

        private void ImageTwocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BandTwocomboBox.Items.Clear();
            for (int i = 0; i < layerName.Length; i++)
            {
                if (ImageTwocomboBox.Text == layerName[i])
                {
                    for (int j = 1; j <= layerBands[i]; j++)
                    {
                        this.BandTwocomboBox.Items.Add(j);
                    }
                    ImagePathTwo = layerSource[i];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "栅格数据(*.tiff)|*.tif;*.tiff";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            string filePath = saveFileDialog.FileName;
            this.BandResultTextBox.Text = filePath;
        }

        private void BandCalculator_Load(object sender, EventArgs e)
        {

        }

        private void BandCalExpression_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
