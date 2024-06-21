using PIE.AxControls;
using PIE.DataSource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 绿廊智绘.Custom_Forms
{
    public partial class createFeatureForm : Form
    {
        public createFeatureForm()
        {
            InitializeComponent();
        }

        public int propertyNum
        {
            get
            {
                return this.featureDataGridView.Rows.Count;
            }
        }

        public string fileName
        {
            get
            {
                return this.outputFeatureTextBox.Text;
            }
        }

        public string spatialReferenceWKT;

        public string GeoType;

        public List<string> fieldName;

        public List<string> fieldAliasName;

        public List<string> fType;

        //public List<FieldType> fieldType;

        public List<int> fieldWidth;

        public List<int> fieldPrecision;

        //public List<FieldType> ToFieldType(List<string> ftype, List<FieldType> FType)
        //{
        //    for (int i = 0; i < ftype.Count; i++)
        //    {
        //        if(ftype[i] == "int")
        //        {
        //            FType.Add(FieldType.OFTInteger);
        //        }
        //        else if (ftype[i] == "double")
        //        {
        //            FType.Add(FieldType.OFTReal);
        //        }
        //        if (ftype[i] == "string")
        //        {
        //            FType.Add(FieldType.OFTString);
        //        }
        //        if (ftype[i] == "DateTime")
        //        {
        //            FType.Add(FieldType.OFTDateTime);
        //        }
        //    }
        //    return FType;
        //}

        private void outputFeatureBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "请选择待创建的矢量要素数据";
            saveFileDialog.Filter = "ShapeFile|*.shp";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            outputFeatureTextBox.Text = saveFileDialog.FileName;
        }

        private void addFieldBtn_Click(object sender, EventArgs e)
        {
            if (outputFeatureTextBox.Text == null || featureTypeComboBox.Text == null) return;
            DataGridViewRow row = new DataGridViewRow();
            this.featureDataGridView.Rows.Add(row);
            DataGridViewComboBoxCell comboxcel = new DataGridViewComboBoxCell();
            string[] comValue = new string[] { "int", "double", "string", "DateTime" };
            for (int i = 0; i < comValue.Length; i++)
            {
                comboxcel.Items.Add(comValue[i]);
            }
            for (int i = 0; i < featureDataGridView.Columns.Count; i++)
            {
                string title = featureDataGridView.Columns[i].HeaderText.ToString();
                if(title == "字段值类型")
                {
                    row.Cells[i] = comboxcel;
                }
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            bool result = true;
            if (outputFeatureTextBox.Text == null)
            {
                MessageBox.Show("输出结果不可为空！");
                result = false;
            }
            if (spatialReferenceTextBox.Text == null)
            {
                MessageBox.Show("请选择坐标系！");
                result = false;
            }
            if (featureTypeComboBox.Text == null)
            {
                MessageBox.Show("请选择要素类型！");
                result = false;
            }
            if (featureDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("请添加字段！");
                result = false;
            }
            else
            {
                for (int i = 0; i < featureDataGridView.Rows.Count; i++)
                {
                    if (featureDataGridView.Rows[i].Cells[0].Value == null)
                    {
                        MessageBox.Show("字段名称不可为空！");
                        result = false;
                        break;
                    }
                }
            }
            if (result)
            {
                if (featureTypeComboBox.SelectedItem.ToString() == "点")
                {
                    GeoType = "点";
                }
                else if (featureTypeComboBox.SelectedItem.ToString() == "线")
                {
                    GeoType = "线";
                }
                else if (featureTypeComboBox.SelectedItem.ToString() == "面")
                {
                    GeoType = "面";
                }
                fieldName = new List<string>();
                fieldAliasName = new List<string>();
                fType = new List<string>();
                fieldWidth = new List<int>();
                fieldPrecision = new List<int>();
                for (int i = 0; i < propertyNum; i++)
                {
                    fieldName.Add(this.featureDataGridView.Rows[i].Cells[0].Value.ToString());
                    fieldAliasName.Add(this.featureDataGridView.Rows[i].Cells[1].Value.ToString());
                    if (this.featureDataGridView.Rows[i].Cells[2].Value.ToString() == "")
                    {
                        fType.Add("");
                    }
                    else
                    {
                        fType.Add(this.featureDataGridView.Rows[i].Cells[2].Value.ToString());
                    }
                    fieldWidth.Add(int.Parse(this.featureDataGridView.Rows[i].Cells[3].Value.ToString()));
                    fieldPrecision.Add(int.Parse(this.featureDataGridView.Rows[i].Cells[4].Value.ToString()));
                }
                //fieldType = ToFieldType(fType, fieldType);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeFieldBtn_Click(object sender, EventArgs e)
        {
            int selectNum = this.featureDataGridView.SelectedRows.Count;
            if (selectNum == 0)
            {
                return;
            }
            else
            {
                for (int i = 0; i < selectNum; i++)
                {
                    this.featureDataGridView.Rows.Remove(this.featureDataGridView.SelectedRows[0]);
                }
            }
        }

        private void featureDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridView featureDataGridView = sender as DataGridView;
            if (featureDataGridView.CurrentCell.GetType().Name == "DataGridViewComboBoxCell" && featureDataGridView.CurrentCell.RowIndex != -1)
            {
                //添加下拉事件
                (e.Control as ComboBox).SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            }
        }

        public void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combox = sender as ComboBox;

            //去掉事件，避免一直触发
            combox.Leave += new EventHandler(combox_Leave);

            if (combox.SelectedItem != null)
            {
                if(combox.SelectedItem.ToString() == "int")
                {
                    int rowIndex = this.featureDataGridView.CurrentRow.Index;
                    int columnIndex = this.featureDataGridView.CurrentCell.ColumnIndex;
                    featureDataGridView.Rows[rowIndex].Cells[columnIndex + 1].Value = "4";
                    featureDataGridView.Rows[rowIndex].Cells[columnIndex + 2].Value = "0";
                }
                else if (combox.SelectedItem.ToString() == "float")
                {
                    int rowIndex = this.featureDataGridView.CurrentRow.Index;
                    int columnIndex = this.featureDataGridView.CurrentCell.ColumnIndex;
                    featureDataGridView.Rows[rowIndex].Cells[columnIndex + 1].Value = "24";
                    featureDataGridView.Rows[rowIndex].Cells[columnIndex + 2].Value = "15";
                }
                else if (combox.SelectedItem.ToString() == "string")
                {
                    int rowIndex = this.featureDataGridView.CurrentRow.Index;
                    int columnIndex = this.featureDataGridView.CurrentCell.ColumnIndex;
                    featureDataGridView.Rows[rowIndex].Cells[columnIndex + 1].Value = "80";
                    featureDataGridView.Rows[rowIndex].Cells[columnIndex + 2].Value = "0";
                }
                else if (combox.SelectedItem.ToString() == "float")
                {
                    int rowIndex = this.featureDataGridView.CurrentRow.Index;
                    int columnIndex = this.featureDataGridView.CurrentCell.ColumnIndex;
                    featureDataGridView.Rows[rowIndex].Cells[columnIndex + 1].Value = "10";
                    featureDataGridView.Rows[rowIndex].Cells[columnIndex + 2].Value = "0";
                }
            }
        }

        public void combox_Leave(object sender, EventArgs e)
        {
            ComboBox combox = sender as ComboBox;
            //做完处理撤销动态事件
            combox.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
        }

        private void spatialReferenceSelectorBtn_Click(object sender, EventArgs e)
        {
            PIE.AxControls.SpatialReferenceSelectorDialog sRSelectorDialog = new SpatialReferenceSelectorDialog();
            if (sRSelectorDialog.ShowDialog() != 1) return;
            //获取对应编码
            spatialReferenceWKT = sRSelectorDialog.SpatialReference.ExportToWkt();
            this.spatialReferenceTextBox.Text = sRSelectorDialog.SpatialReference.Name;
        }
    }
}
