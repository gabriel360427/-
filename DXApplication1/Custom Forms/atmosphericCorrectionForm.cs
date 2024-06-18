using DevExpress.LookAndFeel;
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
    public partial class atmosphericCorrectionForm : DevExpress.XtraEditors.XtraForm
    {
        public atmosphericCorrectionForm()
        {
            InitializeComponent();

           // DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Office2016Colorful);
        }

        public int dataType;

        public string selectedImage;

        public string selectedMetadata;

        public int selectedAtmosPattern;

        public int selectedAirosolPattern;

        public float inputVisibility
        {
            get
            {
                return float.Parse(this.visibility.Text);
            }
        }

        public int selectedAirosolYesOrNo;

        public string resultImage;

        public void confirmDataType()
        {
            if ((DN.Checked == true) && (EpigeneticBrightness.Checked == false) && (EpigeneticReflectance.Checked == false))
            {
                dataType = 1;
            }
            else if ((DN.Checked == false) && (EpigeneticBrightness.Checked == true) && (EpigeneticReflectance.Checked == false))
            {
                dataType = 2;
            }
            else if ((DN.Checked == false) && (EpigeneticBrightness.Checked == false) && (EpigeneticReflectance.Checked == true))
            {
                dataType = 3;
            }
        }

        private void selectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "栅格数据(*.tif)|*.tif;*.tiff";
            openFileDialog.InitialDirectory = @"C:\Users\Administrator\Desktop\城市空间生态格局智能评估系统\演示数据";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            string filePath = openFileDialog.FileName;
            selectedImage = filePath;
            this.inputImage.Text = filePath;
            selectedMetadata = openFileDialog.FileName.Substring(0, openFileDialog.FileName.LastIndexOf(".")) + ".xml";
            this.inputMetadata.Text = selectedMetadata;
            this.atmosPattern.Text = "系统自动选择大气模式";
            this.airosolPattern.Text = "大陆型气溶胶";
            this.visibility.Text = "40";
            this.airosolYesOrNo.Text = "是";
        }

        private void selectMetadata_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "打开文件";
            openFileDialog.Filter = "原数据文件|*.xml|其他文件|*.*";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            string filePath = openFileDialog.FileName;
            selectedMetadata = filePath;
            this.inputMetadata.Text = filePath;
        }

        private void DN_CheckedChanged(object sender, EventArgs e)
        {
            confirmDataType();
        }

        private void EpigeneticBrightness_CheckedChanged(object sender, EventArgs e)
        {
            confirmDataType();
        }

        private void EpigeneticReflectance_CheckedChanged(object sender, EventArgs e)
        {
            confirmDataType();
        }

        private void atmosPattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(atmosPattern.Text == "系统自动选择大气模式")
            {
                selectedAtmosPattern = 0;
            }
            if (atmosPattern.Text == "热带大气模式")
            {
                selectedAtmosPattern = 1;
            }
            if (atmosPattern.Text == "中纬度夏季大气模式")
            {
                selectedAtmosPattern = 2;
            }
            if (atmosPattern.Text == "中纬度冬季大气模式")
            {
                selectedAtmosPattern = 3;
            }
            if (atmosPattern.Text == "副极地夏季大气模式")
            {
                selectedAtmosPattern = 4;
            }
            if (atmosPattern.Text == "副极地冬季大气模式")
            {
                selectedAtmosPattern = 5;
            }
            if (atmosPattern.Text == "美国1962大气模式")
            {
                selectedAtmosPattern = 6;
            }
        }

        private void airosolPattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(airosolPattern.Text == "大陆型气溶胶")
            {
                selectedAirosolPattern = 1;
            }
            if (airosolPattern.Text == "海洋型气溶胶")
            {
                selectedAirosolPattern = 2;
            }
            if (airosolPattern.Text == "城市型气溶胶")
            {
                selectedAirosolPattern = 3;
            }
            if (airosolPattern.Text == "沙尘型气溶胶")
            {
                selectedAirosolPattern = 4;
            }
            if (airosolPattern.Text == "煤烟型气溶胶")
            {
                selectedAirosolPattern = 5;
            }
            if (airosolPattern.Text == "平流层型气溶胶")
            {
                selectedAirosolPattern = 6;
            }
        }

        private void airosolYesOrNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (airosolYesOrNo.Text == "是")
            {
                selectedAirosolYesOrNo = 1;
            }
            if (airosolYesOrNo.Text == "否")
            {
                selectedAirosolYesOrNo = 0;
            }
        }

        private void outputImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "栅格数据(*.tif)|*.tif;*.tiff";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            string filePath = saveFileDialog.FileName;
            resultImage = filePath;
            this.outputFile.Text = filePath;
        }

        private void atmosConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void atmosCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtmosCorrectionForm_Load(object sender, EventArgs e)
        {
            confirmDataType();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        
    }
}
