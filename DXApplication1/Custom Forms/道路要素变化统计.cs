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
    public partial class 道路要素变化统计 : Form
    {
        public 道路要素变化统计()
        {
            InitializeComponent();
        }

        private void 第一期POI加载按钮_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "打开矢量数据";
            open.Filter = "矢量数据|*.shp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                第一景分类文件框.Text = open.FileName;
            }
        }

        private void 第二期POI加载按钮_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "打开矢量数据";
            open.Filter = "矢量数据|*.shp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                第二景分类文件框.Text = open.FileName;
            }
        }

        private void 确定_Click(object sender, EventArgs e)
        {
            结果框.Clear();
            StringBuilder sb = new StringBuilder();

            // 替换实际数据
            int firstNonEconomicCount1 = 1000;
            int firstEconomicCount1 = 2000;
            int economicChange = +1000;
            double economicChangePercentage = 200;

            sb.AppendLine($"第一期道路要素长度：{firstNonEconomicCount1}");
            sb.AppendLine($"第二期道路要素长度：{firstEconomicCount1}");
            sb.AppendLine($"道路长度变化：{economicChange}，同比变化{economicChangePercentage}%；");

            // 将内容设置到 RichTextBox
            结果框.Text = sb.ToString();
        }

        private void 取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
