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
    public partial class featureToRasterForm : DevExpress.XtraEditors.XtraForm
    {
        public string str1;
        public string str2;
        public string str3;
        public featureToRasterForm()
        {
            InitializeComponent();
        }

        private void inputfile_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Feature Data|*.shp";
            openFileDialog.Title = "选择输入文件";
            openFileDialog.InitialDirectory = @"C:\Users\84405\Desktop\尾矿系统开发资料\演示数据\演示数据\矢量转栅格";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            string filePath = openFileDialog.FileName;
            this.filetextBox.Text = filePath;
            str1 = filePath;
        }

        private void inputbasefile_button_Click(object sender, EventArgs e)
        {

        }

        private void outputfile_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Raster Data|*.tiff;*.tif";
            saveFileDialog.Title = "设置输出路径";
            saveFileDialog.FileName = "result";
            //saveFileDialog.InitialDirectory = @"C:\Users\84405\Desktop\TailingsMonitoringSystem_0610\TailingsMonitoringSystem_0610\TailingsMonitoringSystem\测试数据\Output";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            string outputfilepath = saveFileDialog.FileName;
            this.outputtextBox.Text = outputfilepath;
            str3 = outputfilepath;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputbasefile_button_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Raster Data|*.tiff;tif";
            openFileDialog.Title = "选择输入基准影像";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            string filePath = openFileDialog.FileName;
            this.basefiletextBox.Text = filePath;
            str2 = filePath;
        }
    }
}
