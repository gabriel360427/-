using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 绿廊智绘.Custom_Forms
{
    public partial class 土地转移矩阵 : Form
    {
        public 土地转移矩阵()
        {
            InitializeComponent();
        }

        private void 取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 第一景影像加载按钮_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "输入栅格文件";
            op.Filter = "栅格文件|*.tif;*.tiff;*.bmp;*.img;*.jpg;*.ldf";
            if (op.ShowDialog() == DialogResult.OK)
            {
                第一景影像加载框.Text = op.FileName;
            }
            else { MessageBox.Show("打开文件失败"); return; }
        }

        private void 第二景影像加载_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "输入栅格文件";
            op.Filter = "栅格文件|*.tif;*.tiff;*.bmp;*.img;*.jpg;*.ldf";
            if (op.ShowDialog() == DialogResult.OK)
            {
                第二景影像加载框.Text = op.FileName;
            }
            else { MessageBox.Show("打开文件失败"); return; }
        }

        private void 输出位置加载按钮_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "输出表格文件";
            savefile.Filter = "表格文件|*.dbf;";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                输出位置框.Text = savefile.FileName;
            }
        }

        private void 输出位置框_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
