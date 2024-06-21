using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 绿廊智绘.Custom_Commands
{

    public partial class storageFormatConversionForm : DevExpress.XtraEditors.XtraForm
    {
        public string str1;
        public string str2;
        public string str3;
        public string boxstr
        {
            get
            {
                return this.outputcomboBox.Text;
            }
        }
        public storageFormatConversionForm()
        {
            InitializeComponent();
        }

        private void inputfile_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Raster Data|*.tif;*.tiff;*.img";
            openFileDialog.Title = "选择输入文件";
            openFileDialog.InitialDirectory = @"C:\Users\Administrator\Desktop\绿廊智绘\演示数据";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            string filePath = openFileDialog.FileName;
            this.filetextBox.Text = filePath;
            str1 = filePath;
        }

        private void outputfile_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();


            saveFileDialog.Filter = "Raster Data|*.img";
            saveFileDialog.Title = "设置输出路径";
            saveFileDialog.FileName = "result";
            //saveFileDialog.InitialDirectory = @"C:\Users\84405\Desktop\TailingsMonitoringSystem_0610\TailingsMonitoringSystem_0610\TailingsMonitoringSystem\测试数据\Output";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            string outputfilepath = saveFileDialog.FileName;
            this.outputtextBox.Text = outputfilepath;
            str3 = outputfilepath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
