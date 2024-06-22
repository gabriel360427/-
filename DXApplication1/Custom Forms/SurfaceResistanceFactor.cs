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
using PIE.DataSource;
using PIE.Carto;
using PIE.Geometry;
using 绿廊智绘;
using 绿廊智绘.Custom_Commands;

namespace 绿廊智绘.Custom_Forms
{
    public partial class SurfaceResistanceFactor : DevExpress.XtraEditors.XtraForm
    {
        public SurfaceResistanceFactor()
        {
            InitializeComponent();
        }
        //主窗口
        FormMain pie1;
        //全局变量，表示当前输入文件框所选择的序号
        int index = -1;
        private void button1_Click(object sender, EventArgs e)//输入栅格数据
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "输入栅格文件";
            op.Filter = "栅格文件|*.tif;*.tiff;*.bmp;*.img;*.jpg;*.ldf";
            if (op.ShowDialog() == DialogResult.OK)
            {
                栅格数据输入框.Text = op.FileName;
                文件输出框.Text = 栅格数据输入框.Text.Insert(栅格数据输入框.Text.LastIndexOf("."), "_1");
            }
            else { MessageBox.Show("打开文件失败"); return; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //当选择文件名后更改为改文件路径
            if (index == 栅格数据输入框.SelectedIndex) { return; }
            index = 栅格数据输入框.SelectedIndex;
            栅格数据输入框.Items[index] = pie1.mapControlMain.FocusMap.GetLayer(index).DataSourcePath;
            文件输出框.Text = 栅格数据输入框.Text.Insert(栅格数据输入框.Text.LastIndexOf("."), "_1");
        }

        private void 高程因子_Load(object sender, EventArgs e)
        {
            //主窗口
            pie1 = (FormMain)this.Owner;
            /*dataGridView1.Rows.Add(new object[] { "300-∞", "100" });
            dataGridView1.Rows.Add(new object[] { "200-300", "80" });
            dataGridView1.Rows.Add(new object[] { "100-200", "60" });
            dataGridView1.Rows.Add(new object[] { "50-100", "20" });
            dataGridView1.Rows.Add(new object[] { "-∞-50", "1" });
            dataGridView1.Rows.Add(new object[] { "NoData", "NoData" });*/
        }

        private void button3_Click(object sender, EventArgs e)//执行重分类
        {
            this.Cursor = Cursors.WaitCursor;//鼠标等待
            try
            {
                //打开数据
                IRasterDataset rasterdataset1 = DatasetFactory.OpenRasterDataset(栅格数据输入框.Text, OpenMode.ReadOnly);
                if (rasterdataset1 == null) { MessageBox.Show("数据打开失败"); this.Cursor = Cursors.Default; return; }

                //用于判断栅格的格式
                string rasterformat = 栅格数据输入框.Text.Substring(栅格数据输入框.Text.LastIndexOf(".")).ToLower();
                if (rasterformat == ".tif" || rasterformat == ".tiff") { rasterformat = "GTIFF"; }
                else if (rasterformat == ".img") { rasterformat = "HFA"; }
                else { rasterformat = "ENVI"; }

                //栅格像元数据类型
                PixelDataType pixelType;
                //判断输出数据类型
                switch (输出数据类型.SelectedIndex)
                {
                    case 0: pixelType = PixelDataType.Byte; break;
                    case 1: pixelType = PixelDataType.UInt16; break;
                    case 2: pixelType = PixelDataType.Int16; break;
                    case 3: pixelType = PixelDataType.UInt32; break;
                    case 4: pixelType = PixelDataType.Int32; break;
                    case 5: pixelType = PixelDataType.Float32; break;
                    case 6: pixelType = PixelDataType.Float64; break;
                    default: pixelType = rasterdataset1.GetRasterBand(0).GetRasterDataType(); break;
                }
                //创建栅格
                IRasterDataset newRDataset = DatasetFactory.CreateRasterDataset(文件输出框.Text, rasterdataset1.GetRasterXSize(), rasterdataset1.GetRasterYSize(),
                    rasterdataset1.GetBandCount(), pixelType, rasterformat, null);

                List<string> oldvalue = new List<string>();
                List<string> newvalue = new List<string>();
                int num = dataGridView1.RowCount - 1;
                for (int i = 0; i < num; i++)
                {
                    oldvalue.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    newvalue.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    //读取最大值
                    if (oldvalue[i].Contains("∞"))
                    {
                        //最大值
                        dynamic max = 0;
                        //获取栅格数据类型
                        PixelDataType pixelType1 = rasterdataset1.GetRasterBand(0).GetRasterDataType();

                        //获取栅格波段总数
                        int bandcount = rasterdataset1.GetBandCount();
                        //暂时只支持单波段影像
                        if (bandcount > 1) { MessageBox.Show("请输入单波段文件"); this.Cursor = Cursors.Default; return; }
                        //用于创建新栅格的参数
                        int[] bandmap = new int[bandcount];
                        for (int ii = 0; ii < bandcount; ii++) { bandmap[ii] = ii + 1; }
                        //获取栅格宽度
                        int xsize = rasterdataset1.GetRasterXSize();
                        //获取栅格高度
                        int ysize = rasterdataset1.GetRasterYSize();

                        //将栅格拆分成1000*1000大小，以避免运行内存不足
                        //初始化X、Y方向的数量为1000
                        int XSegmentationSize = 1000;
                        int YSegmentationSize = 1000;
                        //求解出横、竖方向上满足数量达1000的次数
                        int x = xsize / XSegmentationSize;
                        int y = ysize / YSegmentationSize;
                        #region 将整副影像拆分为(x+1)*(y+1)次进行计算
                        for (int yi = 0; yi <= y; yi++)
                        {
                            //在计算Y方向上不足1000数量的部分时要将Y方向的数量更改为余数部分
                            if (yi == y)
                            { YSegmentationSize = ysize % YSegmentationSize; }
                            else { YSegmentationSize = 1000; }

                            for (int xi = 0; xi <= x; xi++)
                            {
                                //在计算X方向上不足1000数量的部分时要将X方向的数量更改为余数部分
                                if (xi == x)
                                {
                                    XSegmentationSize = xsize % XSegmentationSize;
                                }
                                else
                                { XSegmentationSize = 1000; }//用于读取栅格数据
                                dynamic arr;
                                #region 根据数据类型与XSegmentationSize和YSegmentationSize初始化arr[]
                                switch (pixelType1)
                                {
                                    case PixelDataType.Byte: arr = new byte[XSegmentationSize * YSegmentationSize]; break;
                                    case PixelDataType.Float32: arr = new float[XSegmentationSize * YSegmentationSize]; break;
                                    case PixelDataType.Float64: arr = new double[XSegmentationSize * YSegmentationSize]; break;
                                    case PixelDataType.Int16: arr = new short[XSegmentationSize * YSegmentationSize]; break;
                                    case PixelDataType.Int32: arr = new Int32[XSegmentationSize * YSegmentationSize]; break;
                                    case PixelDataType.UInt16: arr = new ushort[XSegmentationSize * YSegmentationSize]; break;
                                    case PixelDataType.UInt32: arr = new UInt32[XSegmentationSize * YSegmentationSize]; break;
                                    default: arr = new dynamic[XSegmentationSize * YSegmentationSize]; max = new double(); break;
                                }
                                #endregion
                                //读取栅格数据
                                rasterdataset1.Read(xi * 1000, yi * 1000, XSegmentationSize, YSegmentationSize, arr, XSegmentationSize, YSegmentationSize, pixelType1, bandcount, bandmap);
                                for (int ii = 0; ii < arr.Length; ii++) { if (max < arr[ii]) { max = arr[ii]; } }
                            }
                        }
                        #endregion
                        //更改"∞"为最大值
                        oldvalue[i] = oldvalue[i].Replace("∞", max.ToString());
                    }
                }

                reClassification reclass1 = new reClassification();
                reclass1.reclassification(rasterdataset1, ref newRDataset, oldvalue, newvalue, pixelType);
                newRDataset.SpatialReference = rasterdataset1.SpatialReference;
                double[] geotrans = rasterdataset1.GetGeoTransform();
                newRDataset.SetGeoTransform(geotrans);
                string message = "分类已完成。\n\r文件已保存在" + 文件输出框.Text + "\n\r";
                MessageBox.Show(message); this.Cursor = Cursors.Default;//鼠标恢复
                this.Close();
            }
            catch { MessageBox.Show("计算失败"); }
        }

        private void button2_Click(object sender, EventArgs e)//设置输出文件路径
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "输出栅格文件";
            savefile.Filter = "栅格文件|*.tif;*.tiff;*.bmp;*.img;*.jpg;*.ldf";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                文件输出框.Text = savefile.FileName;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)//当选择文件名后更改为改文件路径
        {
            if (index == 文件输出框.SelectedIndex) { return; }
            index = 文件输出框.SelectedIndex;
            文件输出框.Items[index] = pie1.mapControlMain.FocusMap.GetLayer(index).DataSourcePath;
            文件输出框.Text = 文件输出框.Text.Insert(文件输出框.Text.LastIndexOf("."), "_1");
        }

        private void button4_Click(object sender, EventArgs e)//关闭窗口
        {
            this.Close();
        }

        private void 输出数据类型_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}