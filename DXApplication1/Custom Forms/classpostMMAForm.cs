using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 城市空间生态格局智能评估系统.Custom_Forms
{
    public partial class classpostMMAForm : DevExpress.XtraEditors.XtraForm
    {
        public classpostMMAForm()
        {
            InitializeComponent();
        }

        public string inputImage;

        public string resultImage;

        public List<int> classIndex = new List<int>();

        public List<int> restClassIndex = new List<int>();

        public int kernelX
        {
            get
            {
                return int.Parse(this.kernelXNumericUpDown.Value.ToString());
            }
        }

        public int kernelY
        {
            get
            {
                return int.Parse(this.kernelYNumericUpDown.Value.ToString());
            }
        }

        public int majMin = 0;

        public int pixelProportion
        {
            get
            {
                return int.Parse(this.proportionNumericUpDown.Value.ToString());
            }
        }

        public void confirmAnalysis()
        {
            if ((mainRadioButton.Checked == true) && (secondaryRadioButton.Checked == false))
            {
                majMin = 0;
                proportionNumericUpDown.Enabled = true;
            }
            else if ((mainRadioButton.Checked == false) && (secondaryRadioButton.Checked == true))
            {
                majMin = 1;
                proportionNumericUpDown.Enabled = false;
            }
        }

        public void getClassIndex()
        {
            classIndex.Clear();
            for (int i = 0; i < classificationListBox.Items.Count; i++)
            {
                if (classificationListBox.SelectedIndices.Contains(i))
                {
                    classIndex.Add(i);
                }
                else
                {
                    restClassIndex.Add(i);
                }
            }
        }

        private void inputImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "栅格数据(*.img)|*.tif;*.tiff;*.img;*.dat";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            classificationListBox.Items.Clear();
            classIndex.Clear();
            inputImage = openFileDialog.FileName;
            inputImageTextBox.Text = inputImage;
            string selectHDR = openFileDialog.FileName.Substring(0, openFileDialog.FileName.LastIndexOf(".")) + ".hdr";
            StreamReader sr = new StreamReader(selectHDR);
            string f = sr.ReadToEnd();
            /// <summary>
            /// BUG修改
            /// </summary>
            string[] lines = f.Replace("\r\n", "\n").Replace("}","").Split('\n');
            /// <summary>
            /// BUG修改
            /// </summary>
            List<string> nameList = new List<string>();
            for (int i = 1; i < lines.Length; i++)
            {
                switch (lines[i].Replace(" ", "").Split('=')[0])
                {
                    case "classnames":
                        string[] allName = lines[i + 1].Replace(" ", "").Split(',');
                        nameList = allName.ToList();
                        break;
                }
            }
            foreach (string Cname in nameList)
            {
                classificationListBox.Items.Add(Cname);
                classificationListBox.SelectedItems.Add(Cname);
                classificationNumLabel.Text = classificationListBox.SelectedItems.Count.ToString();
            }
        }

        private void outputImageBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "栅格数据(*.img)|*.img";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            string filePath = saveFileDialog.FileName;
            resultImage = filePath;
            this.outputTextBox.Text = filePath;
        }

        private void selectAllBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < classificationListBox.Items.Count; i++)
            {
                classificationListBox.SelectedIndex = i;
            }
        }

        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            classificationListBox.ClearSelected();
        }

        private void classificationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            classificationNumLabel.Text = classificationListBox.SelectedItems.Count.ToString();
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

        private void mainRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            confirmAnalysis();
        }

        private void secondaryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            confirmAnalysis();
        }

        /// <summary>
        /// BUG修改
        /// </summary>

        private void kernelXNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            kernelYNumericUpDown.Value = kernelXNumericUpDown.Value;
        }

        private void kernelYNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            kernelXNumericUpDown.Value = kernelYNumericUpDown.Value;
        }

        /// <summary>
        /// BUG修改
        /// </summary>
    }
}
