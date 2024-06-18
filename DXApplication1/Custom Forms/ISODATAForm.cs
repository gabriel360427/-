using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PIE.Carto;
using PIE.DataSource;

namespace 城市空间生态格局智能评估系统.Custom_Forms
{
    public partial class ISODATAForm : DevExpress.XtraEditors.XtraForm
    {
        public ISODATAForm()
        {
            InitializeComponent();
        }

        public string selectedImage;

        public string resultImage;

        public int ProspClassNumFrm
        {
            get
            {
                return int.Parse(this.ProspClassNumControl.Value.ToString());
            }
        }

        public int InitClassNumFrm
        {
            get
            {
                return int.Parse(this.InitClassNumControl.Value.ToString());
            }
        }

        public int MinSamFrm
        {
            get
            {
                return int.Parse(this.MinSamControl.Value.ToString());
            }
        }

        public int MaxMergeFrm
        {
            get
            {
                return int.Parse(this.MaxMergeControl.Value.ToString());
            }
        }

        public int MaxLoopFrm
        {
            get
            {
                return int.Parse(this.MaxLoopControl.Value.ToString());
            }
        }

        public double DevFrm
        {
            get
            {
                return double.Parse(this.DevControl.Text);
            }
        }

        public double MinDisFrm
        {
            get
            {
                return double.Parse(this.MinDisControl.Text);
            }
        }

        public List<int> selectedBands = new List<int>();

        private void inputImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "栅格数据(*.tiff)|*.tif;*.tiff;*.img;*.dat";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            string filePath = openFileDialog.FileName;
            selectedImage = filePath;
            this.inputImageTextBox.Text = filePath;
            IRasterDataset rDataset = PIE.DataSource.DatasetFactory.OpenRasterDataset(filePath, OpenMode.ReadOnly);
            int bandcount = rDataset.GetBandCount();
            for (int i = 1; i <= bandcount; i++)
            {
                this.bandNumListBox.Items.Add("波段"+i);
                this.bandNumListBox.SelectedItems.Add("波段" + i);
            }
        }

        private void outputImageButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "栅格数据(*.img)|*.tif;*.tiff;*.img;*.dat";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            string filePath = saveFileDialog.FileName;
            resultImage = filePath;
            this.outputImageTextBox.Text = filePath;
        }

        private void formConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            selectedBands.Add(this.bandNumListBox.SelectedIndex);
            this.Close();
        }

        private void formCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bandNumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bandNumLabel.Text = bandNumListBox.SelectedItems.Count.ToString();
        }

        private void bandClear_Click(object sender, EventArgs e)
        {
            bandNumListBox.ClearSelected();
            bandNumLabel.Text = bandNumListBox.SelectedItems.Count.ToString();
        }
    }
}
