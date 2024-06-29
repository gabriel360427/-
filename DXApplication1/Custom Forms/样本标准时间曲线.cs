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
    public partial class 样本标准时序曲线 : Form
    {
        public 样本标准时序曲线()
        {
            InitializeComponent();
        }

        private void 取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "输入栅格文件";
            op.Filter = "栅格文件|*.tif;*.tiff;*.bmp;*.img;*.jpg;*.jpeg;*.sid;*.lan|其他文件|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(op.FileName);//输入文件
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) { return; }
            listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null | listBox1.SelectedIndex == listBox1.Items.Count - 1) { return; }
            listBox1.Items.Insert(listBox1.SelectedIndex + 2, listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null | listBox1.SelectedIndex == 0) { return; }
            listBox1.Items.Insert(listBox1.SelectedIndex + 1, listBox1.Items[listBox1.SelectedIndex - 1]);
            listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex - 1]);
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

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(时间输入框.Text);
            时间输入框.Clear();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null) { return; }
            listBox2.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null | listBox2.SelectedIndex == 0) { return; }
            listBox2.Items.Insert(listBox2.SelectedIndex + 1, listBox2.Items[listBox2.SelectedIndex - 1]);
            listBox2.Items.Remove(listBox2.Items[listBox2.SelectedIndex - 1]);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null | listBox2.SelectedIndex == listBox2.Items.Count - 1) { return; }
            listBox2.Items.Insert(listBox2.SelectedIndex + 2, listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void 确定_Click(object sender, EventArgs e)
        {
            MessageBox.Show("标准时序曲线已生成！");
        }
    }
}
