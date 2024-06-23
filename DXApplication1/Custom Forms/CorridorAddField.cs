using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PIE.Carto;
using PIE.CommonAlgo;
using PIE.SystemAlgo;
using PIE.DataSource;
using PIE.Display;
using PIE.AxControls;
using System.Data.OleDb;

namespace 绿廊智绘.Custom_Forms
{
    public partial class CorridorAddField : DevExpress.XtraEditors.XtraForm
    {
        public CorridorAddField()
        {
            InitializeComponent();
        }

        //主窗口
        FormMain fm = new FormMain();
        //全局变量，表示当前输入文件框所选择的序号
        int index1 = -1;
        string path;
        string excelpath;
        string x;
        string result;
        
        int[] intarry = new int[300];
        int[] intarry1 = new int[300];
        object[] obj = new object[300];
        object[] obj1 = new object[300];
        int[] fenji = new int[300];
        int sum = 0;
        private void 廊道分级_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "打开矢量数据";
            open.Filter = "矢量数据|*.shp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = open.FileName;
                path = textBox2.Text;
            }
            //ILayer layer = LayerFactory.CreateDefaultLayer(textBox1.Text);
            //IFeatureClass featureClass = (layer as IFeatureLayer).FeatureClass;
            //if (featureClass == null) { MessageBox.Show("请打开矢量数据"); return; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string file_name = excelpath;//文件路径，此处为了省事，直接把文件放到了bin->Debug->netcoreapp3.1文件夹下（demo是一个.Net Core的控制台项目）
            string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file_name + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1'";//连接数据源所用的字符串
            OleDbConnection con = new OleDbConnection(conString);//创建连接
            con.Open();//打开连接
            string tableName = result;

            string sql = "select * from [{tableName}$]";//查询语句

            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);//执行查询语句
            DataSet ds = new DataSet();//可以理解未内存中的一个数据库，里边会有多张表
            adp.Fill(ds);//将查询结果填充到DataSet中
            con.Close();//关闭连接
            con.Dispose();//释放资源
            DataTableCollection datatable_collection = ds.Tables;//得到一个数据表的集合
            DataTable dt = datatable_collection[0];//第一张表就是我们的数据




            for (int i = 0; i < dt.Rows.Count; i++)
            {
                obj[i] = dt.Rows[i][3];
                obj1[i] = dt.Rows[i][0];
            }

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                intarry[i] = Convert.ToInt32(obj[i])/10000;
                intarry1[i] = Convert.ToInt32(obj1[i]);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sum = sum + intarry[i];
            }
            int fenjicount = 0;
            int aver = sum / ((dt.Rows.Count));
            int count = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (intarry[i] <= aver)
                {
                    fenji[fenjicount] = intarry1[i];
                    fenjicount++;
                    count++;
                }
            }

            #region 添加矢量字段
            int gridindex;
            try
            {
                //打开当前path的缓冲区文件
                IFeatureDataset featureDataset = DatasetFactory.OpenFeatureDataset(path);
                //判断原字段是否有grade
                IField field1;
                //没有grade就直接创建

                field1 = new Field("grade", FieldType.OFTInteger, 20, 0);
                 field1.Name = "grade";
                 field1.AliasName = "分级";
                string id = "GRID_CODE";
                
                //2矢量数据集的删除和修改
                featureDataset.AddField(field1, true);
                //获取字段序号
                gridindex = featureDataset.GetFields().GetFieldIndex(id);
                //遍历矢量属性表的每条记录并添加其缓冲区大小值

                int k = 1;
                for (uint i = 0; i < featureDataset.GetFeatureCount(); i++)
                {
                    IFeature feature = featureDataset.GetFeature(i);
                    for (int j = 0; j < count; j++)
                    {
                        
                        if ((fenji[j]+1) == Convert.ToInt32(feature.GetValue(gridindex))) 
                        {
                            feature.SetValue(feature.GetFieldIndex(field1.Name), Convert.ToInt32(k));
                        }
                    }
                    if (Convert.ToInt32(feature.GetValue(field1.Name)) != 1)
                    {
                        feature.SetValue(feature.GetFieldIndex(field1.Name), Convert.ToInt32(2));
                    }
                    //更新保存记录
                    featureDataset.UpdateFeature(feature);
                }
                IFeatureLayer featureLayer1 = new FeatureLayer();
                IFeatureClass fClass = new FeatureClass(featureDataset);
                featureLayer1.FeatureClass = fClass;
                featureDataset.Save();
            }
            catch { MessageBox.Show("添加矢量字段失败"); this.Cursor = Cursors.Default; return; }
            #endregion

            MessageBox.Show("执行成功");
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "打开excel表格";
            open.Filter = "数据表格|*.xls;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = open.FileName;
                excelpath = textBox1.Text;
                x = open.SafeFileName;
                result = x.Split('.')[0];
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
