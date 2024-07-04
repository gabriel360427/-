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
    public partial class segmentAnythingModelForm : Form
    {
        public segmentAnythingModelForm()
        {
            InitializeComponent();
        }

        private void btnRunScript_Click(object sender, EventArgs e)
        {
            // Python 脚本路径
            string pythonScriptPath = @"D:\learn_pytorch\sam分割.py";

            // Python 解释器路径 (例如 Anaconda 环境下的解释器路径)
            string pythonInterpreterPath = @"D:\anaconda3\envs\pytorch\python.exe";

            // 图像文件路径和输出文件夹路径（假设从界面获取）
            string imageFilePath = inputfileBox.Text;  // 从文本框获取图像文件路径
            string outputFolder = outputfileBox.Text;    // 从文本框获取输出文件夹路径

            // 构造启动 Python 脚本的进程
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = pythonInterpreterPath;
            startInfo.Arguments = "{pythonScriptPath} {imageFilePath} {outputFolder}";
            startInfo.UseShellExecute = false;  // 必须为 false 以指定 RedirectStandardOutput
            startInfo.RedirectStandardOutput = true;  // 重定向输出，以便在需要时读取 Python 脚本的输出

            try
            {
                using (Process process = Process.Start(startInfo))
                {
                    // 可选：读取 Python 脚本的输出
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        Console.WriteLine(result);  // 输出 Python 脚本的输出
                    }

                    process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                // 处理异常（例如路径错误、权限问题等）
                Console.WriteLine("Error: {ex.Message}");
            }
        }

        private void selectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "请输入待分割影像";
            openfile.Filter = "栅格数据(*.img)|*.tif;*.tiff;*.img;*.dat";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                inputfileBox.Text = openfile.FileName;//输入Shp矢量文件
            }
        }

        private void selectoutputfile_Click(object sender, EventArgs e)
        {
            // 创建一个 FolderBrowserDialog 对象
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            // 设置对话框的描述信息
            folderDialog.Description = "请选择输出文件夹";

            // 如果用户点击了“确定”按钮
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取用户选择的文件夹路径
                string selectedFolder = folderDialog.SelectedPath;

                // 将路径显示在 outputfileBox 文本框中
                outputfileBox.Text = selectedFolder;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
