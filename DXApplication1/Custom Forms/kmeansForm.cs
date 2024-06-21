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


namespace 绿廊智绘.Custom_Forms
{
    public partial class kmeansForm : DevExpress.XtraEditors.XtraForm
    {
        public kmeansForm()
        {
            InitializeComponent();
        }

        public string selectedImage;

        public string resultImage;

        public int ClassNumFrm
        {
            get
            {
                return int.Parse(this.classNumControl.Value.ToString());
            }
        }

        public int MaxLoopFrm
        {
            get
            {
                return int.Parse(this.maxLoopControl.Value.ToString());
            }
        }

        public double ThresholdFrm
        {
            get
            {
                return double.Parse(this.thresholdControl.Text);
            }
        }

        public List<int> selectedBands = new List<int>();

        private void inputImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "栅格数据(*.tiff)|*.tif;*.tiff;*.img;*.dat";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            string filePath = openFileDialog.FileName;
            inputImageTextBox.Text = filePath;
            selectedImage = filePath;
            this.inputImageTextBox.Text = filePath;
            IRasterDataset rDataset = PIE.DataSource.DatasetFactory.OpenRasterDataset(filePath, OpenMode.ReadOnly);
            int bandcount = rDataset.GetBandCount();
            for (int i = 1; i <= bandcount; i++)
            {
                this.bandNumListBox.Items.Add("波段" + i);
                this.bandNumListBox.SelectedItems.Add("波段" + i);
            }
        }

        private void bandNumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bandNumLabel.Text = bandNumListBox.SelectedItems.Count.ToString();
        }

        private void clearBandsBtn_Click(object sender, EventArgs e)
        {
            bandNumListBox.ClearSelected();
            bandNumLabel.Text = bandNumListBox.SelectedItems.Count.ToString();
        }

        private void outputImageBtn_Click(object sender, EventArgs e)
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

        private void thresholdControl_TextChanged(object sender, EventArgs e)
        {
            double flag = double.Parse(thresholdControl.Text);
            if (flag >= 0 && flag <= 1)
            {

            }
            else
            {
                MessageBox.Show("阈值范围设置不正确！");
                thresholdControl.Text = "1";
            }
        }
    }
}
