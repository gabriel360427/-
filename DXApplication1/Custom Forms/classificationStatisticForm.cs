using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 绿廊智绘.Custom_Forms
{
    public partial class classificationStatisticForm : DevExpress.XtraEditors.XtraForm
    {
        public classificationStatisticForm()
        {
            InitializeComponent();
        }

        private string filePath;

        private void inputImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "栅格数据(*.img)|*.tif;*.tiff;*.img;*.dat";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            filePath = openFileDialog.FileName;
            inputImageTextBox.Text = filePath;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            #region 1、参数设置
            PIE.CommonAlgo.StclassStat info = new PIE.CommonAlgo.StclassStat();
            info.inputname = filePath;
            PIE.SystemAlgo.ISystemAlgo algo = PIE.SystemAlgo.AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.ImgClassPostStaAlgo");
            if (algo == null) return;
            #endregion
            //2、算法执行
            PIE.SystemAlgo.ISystemAlgoEvents algoEvents = algo as PIE.SystemAlgo.ISystemAlgoEvents;
            algo.Name = " 分类统计";
            algo.Params = info;
            bool result = PIE.SystemAlgo.AlgoFactory.Instance().ExecuteAlgo(algo);
            info = algo.Params as PIE.CommonAlgo.StclassStat;
            classificationStatisticTextBox.Text = info.statinfo;
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName, true);
                streamWriter.WriteLine(this.classificationStatisticTextBox.Text);
                streamWriter.Close();
                MessageBox.Show("导出成功！");
            }
        }
    }
}
