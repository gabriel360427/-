using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace 绿廊智绘.Custom_Forms
{
    public partial class ObjectOrientedclassification : DevExpress.XtraEditors.XtraForm
    {
        public ObjectOrientedclassification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Title = "输入原始分类影像";
            openfiledialog.Filter = "栅格数据|*.tif;*.tiff;*.img;|其他文件|*.*";
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                comboBox1.Text = openfiledialog.FileName;//comboBox1文本框中显示文件名
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "输入对象分割矢量";
            openfile.Filter = "矢量文件|*.shp";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                comboBox2.Text = openfile.FileName;//输入Shp矢量文件
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "输出栅格文件";
            savefile.Filter = "栅格文件|*.tif;*.tiff;*.bmp;*.img;*.jpg;*.dat|其他文件|*.*";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                comboBox3.Text = savefile.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            // Python 脚本路径
            string pythonScript = @"D:\learn_pytorch\面向对象分类.py";

            // Python 解释器路径 (例如 Anaconda 环境下的解释器路径)
            string pythonExePath = @"D:\anaconda3\envs\pytorch\python.exe";

            // Python 脚本的参数
            string rasterPath = comboBox1.Text;
            string vectorPath = comboBox2.Text;
            string outputPath = comboBox3.Text;

            // Arguments for the Python script (replace with your arguments)
            string arguments = $"\"{pythonScript}\" \"{rasterPath}\" \"{vectorPath}\" \"{outputPath}\"";

            // Start Python process
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = pythonExePath;
            startInfo.Arguments = arguments;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;

            using (Process process = Process.Start(startInfo))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);  // Output from Python script, if needed
                }
            }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            MessageBox.Show($"处理成功，结果文件已存储在{comboBox3.Text}处");
            this.Close();
        }


    }
}
