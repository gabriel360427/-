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
    public partial class rasterToFeatureAreaForm : DevExpress.XtraEditors.XtraForm
    {
        public rasterToFeatureAreaForm()
        {
            InitializeComponent();
        }
        public string allFile
        {
            get
            {
                string all = " " + this.inputRasterTextBox.Text.Substring(0, this.inputRasterTextBox.Text.LastIndexOf("\\"));
                all += " " + this.inputRasterTextBox.Text.Split('\\').Last();
                all += " " + this.outputFeatureAreaTextBox.Text;
                if (this.comboBox1.Text == "")
                {
                    all += " " + "Value";
                }
                else
                {
                    all += " " + this.comboBox1.Text;
                }
                if (simplifiedCheckBox.Checked == true)
                {
                    all += " " + "NO_SIMPLIFY";
                }
                else
                {
                    all += " " + "SIMPLIFY";
                }
                return all;
            }
        }
        public string file1
        {
            get
            {
                return this.outputFeatureAreaTextBox.Text;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "栅格数据(*.tiff)|*.tif;*.tiff";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            string filePath = openFileDialog.FileName;
            this.inputRasterTextBox.Text = filePath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Feature Data|*.shp";
            saveFileDialog.Title = "设置输出路径";
            saveFileDialog.FileName = "result";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            string outputfilepath = saveFileDialog.FileName;
            this.outputFeatureAreaTextBox.Text = outputfilepath;
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
    }
}
