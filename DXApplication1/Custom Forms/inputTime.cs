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
    public partial class inputTime : Form
    {
        public inputTime()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string InputText
        {
            get { return 输入时间框.Text; }
        }
    }
}
