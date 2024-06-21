using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 绿廊智绘.Custom_Forms
{
    public partial class classificationMergeForm : DevExpress.XtraEditors.XtraForm
    {
        public classificationMergeForm()
        {
            InitializeComponent();
        }

        public string inputImage;

        public string resultImage;

        public int classCount;

        public List<int> classMerge = new List<int>();

        public List<string> mergeInfoFirst = new List<string>();

        public int inputItem;

        public int outputItem;

        private void inputImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "栅格数据(*.img)|*.tif;*.tiff;*.img;*.dat";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            inputImage = openFileDialog.FileName;
            inputImageTextBox.Text = inputImage;
            string selectHDR = openFileDialog.FileName.Substring(0, openFileDialog.FileName.LastIndexOf(".")) + ".hdr";
            StreamReader sr = new StreamReader(selectHDR);
            string f = sr.ReadToEnd();
            string[] lines = f.Replace("\r\n", "\n").Replace("}","").Split('\n');
            List<string> nameList = new List<string>();
            for (int i = 1; i < lines.Length; i++)
            {
                switch (lines[i].Replace(" ", "").Split('=')[0])
                {
                    case "classnames":
                        string[] allName = lines[i + 1].Replace(" ", "").Split(',');
                        nameList = allName.ToList();
                        classCount = nameList.Count;
                        break;
                }
            }
            for (int i = 0; i < classCount; i++)
            {
                classMerge.Add(i);
            }
            foreach (string Cname in nameList)
            {
                inputClassListBox.Items.Add(Cname);
                outputClassListBox.Items.Add(Cname);
            }
        }

        private void addRelationBtn_Click(object sender, EventArgs e)
        {
            if ((inputClassListBox.SelectedItems.Count == 0) || (outputClassListBox.SelectedItems.Count == 0)) return;
            inputItem = this.inputClassListBox.SelectedIndex;
            outputItem = this.outputClassListBox.SelectedIndex;
            string info = inputClassListBox.Items[inputItem] + "<->" + outputClassListBox.Items[outputItem];
            mergeInfoFirst.Add(info.Replace("<->", "\n").Split('\n')[0]);
            bool result = true;
            for (int i = 0; i < mergeInfoFirst.Count; i++)
            {
                for (int j = i + 1; j < mergeInfoFirst.Count; j++)
                {
                    if (mergeInfoFirst[i] == mergeInfoFirst[j])
                    {
                        MessageBox.Show("类别重复，请重新选择！");
                        mergeInfoFirst.Remove(info.Replace("<->", "\n").Split('\n')[0]);
                        result = false;
                        break;
                    }
                }
            }
            if(result)
            {
                classMerge[inputItem] = outputItem;
                mergeInfoListBox.Items.Add(info);
            }
        }

        private void removeRelationBtn_Click(object sender, EventArgs e)
        {
            if(mergeInfoListBox.SelectedItems.Count == 0) return;
            string inputItemClass = mergeInfoListBox.SelectedItem.ToString().Replace("<->", "\n").Split('\n')[0];
            int inputItemIndex;
            mergeInfoListBox.Items.Remove(mergeInfoListBox.SelectedItem);
            mergeInfoFirst.Remove(inputItemClass);
            for (int i = 0; i < inputClassListBox.Items.Count; i++)
            {
                if(inputClassListBox.Items[i].ToString() == inputItemClass)
                {
                    inputItemIndex = i;
                    classMerge[inputItemIndex] = inputItemIndex;
                }
            }
        }

        private void resultImageBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "栅格数据(*.img)|*.img";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            string filePath = saveFileDialog.FileName;
            resultImage = filePath;
            this.resultImageTextBox.Text = filePath;
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
