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
    public partial class coordinationEvaluation : Form
    {
        public coordinationEvaluation()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "输入富民格局提取矢量图";
            openfile.Filter = "矢量文件|*.shp";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                comboBox2.Text = openfile.FileName;//输入Shp矢量文件
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "输入景观破碎度分布矢量图";
            openfile.Filter = "矢量文件|*.shp";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                comboBox1.Text = openfile.FileName;//输入Shp矢量文件
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // 获取TextBox中的文本
            string userInput = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // 获取TextBox中的文本
            string userInput = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 设置TextBox的文本为特定值
            textBox1.Text = "0.3735";
            textBox2.Text = "0.5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "保存输出矢量文件";
            saveFileDialog.Filter = "矢量文件|*.shp";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                comboBox3.Text = saveFileDialog.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            // Python 脚本路径
            string pythonScript = @"E:\pythonProject\生态富民协调度.py";

            // Python 解释器路径 (例如 Anaconda 环境下的解释器路径)
            string pythonExePath = @"E:\pythonProject\venv\Scripts\python.exe";

            // Python 脚本的参数
            string vector_path_1 = comboBox2.Text;
            string vector_path_2 = comboBox1.Text;
            string outputPath = comboBox3.Text;
            float light_Threshold_value,land_Threshold_value;

            // 将文本框中的值转换为浮点数
            if (!float.TryParse(textBox1.Text, out light_Threshold_value))
            {
                MessageBox.Show("无法解析均值输入为浮点数");
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                return;
            }

            if (!float.TryParse(textBox2.Text, out land_Threshold_value))
            {
                MessageBox.Show("无法解析标准差输入为浮点数");
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                return;
            }

            // Arguments for the Python script (replace with your arguments)
            string arguments = $"\"{pythonScript}\" \"{vector_path_1}\" \"{vector_path_2}\" \"{outputPath}\" {light_Threshold_value} {land_Threshold_value}"; ;

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
