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
    public partial class Relief : Form
    {
        public Relief()
        {
            InitializeComponent();
        }

        private void 确定_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DEM地形起伏度处理完成！");
            this.Close();
        }

        private void 取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DEM加载按钮_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "输入DEM数据";
            open.Filter = "基准影像|*.tif;*.tiff;*.bmp;*.img;*.jpg;*.ldf";
            if (open.ShowDialog() == DialogResult.OK)
            {
                DEM输入框.Text = open.FileName;
            }
        }

        private void 输出路径加载框_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "输出栅格文件";
            savefile.Filter = "栅格文件|*.tif;*.tiff;*.bmp;*.img;*.jpg;*.ldf";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                输出路径框.Text = savefile.FileName;
            }
        }

        private void Relief_Load(object sender, EventArgs e)
        {

        }
    }
}
