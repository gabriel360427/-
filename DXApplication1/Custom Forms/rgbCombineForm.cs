using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIE.AxControls;
using PIE.Controls;
using PIE.Carto;
using PIE.DataSource;
using PIE.Plugin;
using PIE.SystemAlgo;
using PIE.SystemUI;
using PIE.CommonAlgo;

namespace 绿廊智绘.Custom_Forms
{
    public partial class rgbCombineForm : Form
    {
        public rgbCombineForm()
        {
            InitializeComponent();
        }
        public int RedBand
        {
            get
            {
                return int.Parse(this.RedBandNum.Value.ToString());
            }
        }
        public int GreenBand
        {
            get
            {
                return int.Parse(this.GreenBandNum.Value.ToString());
            }
        }
        public int BlueBand
        {
            get
            {
                return int.Parse(this.BlueBandNum.Value.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.RedBandNum.Value = 3;
            this.GreenBandNum.Value = 2;
            this.BlueBandNum.Value = 1;
            this.Close();
        }

    }
}
