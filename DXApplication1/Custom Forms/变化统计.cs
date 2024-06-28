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
    public partial class 变化统计 : Form
    {
        public 变化统计()
        {
            InitializeComponent();

        }

        private void 分类文件加载按钮_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "输入栅格文件";
            op.Filter = "栅格文件|*.tif;*.tiff;*.bmp;*.img;*.jpg;*.ldf";
            if (op.ShowDialog() == DialogResult.OK)
            {
                第一景分类文件框.Text = op.FileName;
            }
            else { MessageBox.Show("打开文件失败"); return; }
        }

        private void 取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 耕地矢量文件加载按钮_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "输入栅格文件";
            op.Filter = "栅格文件|*.tif;*.tiff;*.bmp;*.img;*.jpg;*.ldf";
            if (op.ShowDialog() == DialogResult.OK)
            {
                第二景分类文件框.Text = op.FileName;
            }
            else { MessageBox.Show("打开文件失败"); return; }
        }

        private void 确定_Click(object sender, EventArgs e)
        {
            结果框.Clear();
            StringBuilder sb = new StringBuilder();

            // 替换实际数据
            int firstNonEconomicCount1 = 1000;
            double firstNonEconomicPercentage1 = 25.5;
            int firstEconomicCount1 = 2000;
            double firstEconomicPercentage1 = 50.5;
            int secondNonEconomicCount2 = 1500;
            double secondNonEconomicPercentage2 = 30.5;
            int secondEconomicCount2 = 2500;
            double secondEconomicPercentage2 = 60.5;
            int economicChange = 500;
            double economicChangePercentage = 10.0;

            sb.AppendLine("第一景图像非经济作物像元数：{firstNonEconomicCount1}，占比{firstNonEconomicPercentage1}%；");
            sb.AppendLine("第一景图像经济作物像元数：{firstEconomicCount1}，占比{firstEconomicPercentage1}%；");
            sb.AppendLine("第二景图像非经济作物像元数：{secondNonEconomicCount2}，占比{secondNonEconomicPercentage2}%；");
            sb.AppendLine("第二景图像经济作物像元数：{secondEconomicCount2}，占比{secondEconomicPercentage2}%；");
            sb.AppendLine("经济作物像元变化：{economicChange}，同比变化{economicChangePercentage}%；");

            // 将内容设置到 RichTextBox
            结果框.Text = sb.ToString();
        }
    }
}
