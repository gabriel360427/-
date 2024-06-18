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


namespace 城市空间生态格局智能评估系统.Custom_Commands
{
    public partial class reClassification : DevExpress.XtraEditors.XtraForm
    {
        public reClassification()
        {
            InitializeComponent();
        }

        //用于写入旧值列表
        dynamic oldvalue;
        //主窗口
        FormMain pie1;
        //全局变量，表示当前输入文件框所选择的序号
        int index = -1;
        private void readData()
        {
            //打开栅格
            IRasterDataset rasterdataset1 = DatasetFactory.OpenRasterDataset(栅格数据输入框.Text, OpenMode.ReadOnly);
            if (rasterdataset1 == null) { return; }


            //用于检测是否有无效值
            IRasterBand rasterband = rasterdataset1.GetRasterBand(0);
            //是否存在原影像的无效值
            bool isExsitOldNoDataValue = rasterband.IsExsitNoDataValue();
            //获取栅格数据类型
            PixelDataType pixelType = rasterdataset1.GetRasterBand(0).GetRasterDataType();

            //获取栅格波段总数
            int bandcount = rasterdataset1.GetBandCount();
            //暂时只支持单波段影像
            if (bandcount > 1) { MessageBox.Show("请输入单波段文件"); return; }
            //用于创建新栅格的参数
            int[] bandmap = new int[bandcount];
            for (int i = 0; i < bandcount; i++) { bandmap[i] = i + 1; }
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
            //获取旧影像的无效值
            dynamic GetOldNoDataValue;
            #region  根据数据类型初始化oldvalue列表和获取GetOldNoDataValue值
            switch (pixelType)
            {
                case PixelDataType.Byte: oldvalue = new List<byte>(); GetOldNoDataValue = (byte)rasterband.GetNoDataValue(); break;
                case PixelDataType.Float32: oldvalue = new List<float>(); GetOldNoDataValue = (float)rasterband.GetNoDataValue(); break;
                case PixelDataType.Float64: oldvalue = new List<double>(); GetOldNoDataValue = (double)rasterband.GetNoDataValue(); break;
                case PixelDataType.Int16: oldvalue = new List<Int16>(); GetOldNoDataValue = (Int16)rasterband.GetNoDataValue(); break;
                case PixelDataType.Int32: oldvalue = new List<Int32>(); GetOldNoDataValue = (Int32)rasterband.GetNoDataValue(); break;
                case PixelDataType.UInt16: oldvalue = new List<UInt16>(); GetOldNoDataValue = (UInt16)rasterband.GetNoDataValue(); break;
                case PixelDataType.UInt32: oldvalue = new List<UInt32>(); GetOldNoDataValue = (UInt32)rasterband.GetNoDataValue(); break;
                //开关的默认的代码不严谨，有待改善
                default: oldvalue = new List<dynamic>(); GetOldNoDataValue = (dynamic)rasterband.GetNoDataValue(); break;
            }
            #endregion
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
                    switch (pixelType)
                    {
                        case PixelDataType.Byte: arr = new byte[XSegmentationSize * YSegmentationSize]; break;
                        case PixelDataType.Float32: arr = new float[XSegmentationSize * YSegmentationSize]; break;
                        case PixelDataType.Float64: arr = new double[XSegmentationSize * YSegmentationSize]; break;
                        case PixelDataType.Int16: arr = new short[XSegmentationSize * YSegmentationSize]; break;
                        case PixelDataType.Int32: arr = new Int32[XSegmentationSize * YSegmentationSize]; break;
                        case PixelDataType.UInt16: arr = new ushort[XSegmentationSize * YSegmentationSize]; break;
                        case PixelDataType.UInt32: arr = new UInt32[XSegmentationSize * YSegmentationSize]; break;
                        //开关的默认的代码不严谨，有待改善
                        default: arr = new dynamic[XSegmentationSize * YSegmentationSize]; break;
                    }
                    #endregion
                    //读取栅格数据
                    rasterdataset1.Read(xi * 1000, yi * 1000, XSegmentationSize, YSegmentationSize, arr, XSegmentationSize, YSegmentationSize, pixelType, bandcount, bandmap);
                    //初始化
                    if (xi == 0 && yi == 0) { oldvalue.Add(arr[0]); }

                    //查出所有不同的值
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (!oldvalue.Contains(arr[i])) { oldvalue.Add(arr[i]); }
                    }
                }
            }
            #endregion
            //将旧值列表去掉无效值
            oldvalue.Remove(GetOldNoDataValue);
            //排序
            oldvalue.Sort();

            //保证数据表中无值
            dataGridView1.Rows.Clear();
            #region 数据表中旧新值列的添加
            //若唯一值数小于等于9，则直接将唯一值写入旧值列表
            if (oldvalue.Count <= 9)
            {
                for (int i = 0; i < oldvalue.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    //旧值列表添加
                    dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[0].Value = oldvalue[i];
                    //新值列表添加
                    dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[1].Value = i + 1;
                }
            }
            else
            {
                //间隔
                int Multiple;
                //保证除“NoData”行，旧值列表的行数不超过9行
                for (Multiple = 2; oldvalue.Count / Multiple >= 9; Multiple += 2) { }
                int i;
                for (i = 0; i < oldvalue.Count - Multiple; i += Multiple)
                {
                    dataGridView1.Rows.Add();
                    //旧值列表添加
                    dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[0].Value = oldvalue[i].ToString() + "-" + oldvalue[i + Multiple].ToString();
                    //新值列表添加
                    dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[1].Value = (dataGridView1.RowCount - 1).ToString();
                }
                //最后一组旧新值添加
                dataGridView1.Rows.Add();
                //若最后两区间值相同则写入一个即可
                dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[0].Value = oldvalue[i].ToString() + "-" + oldvalue[oldvalue.Count - 1].ToString();
                dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[1].Value = (dataGridView1.RowCount - 1).ToString();

            }
            //添加无效值列
            dataGridView1.Rows.Add();
            dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[0].Value = "NoData";
            dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[1].Value = "NoData";
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)//输入栅格数据
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "输入栅格文件";
            op.Filter = "栅格文件|*.tif;*.tiff;*.bmp;*.img;*.jpg;*.ldf";
            if (op.ShowDialog() == DialogResult.OK)
            {
                栅格数据输入框.Text = op.FileName;
            }
            else { this.Cursor = Cursors.Default; return; }
            readData();
        }

        private void button6_Click(object sender, EventArgs e)//设置输出文件路径
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "输出栅格文件";
            savefile.Filter = "栅格文件|*.tif;*.tiff;*.bmp;*.img;*.jpg;*.ldf";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                文件输出框.Text = savefile.FileName;
            }
        }

        private void button7_Click(object sender, EventArgs e)//执行重分类
        {
            this.Cursor = Cursors.WaitCursor;//鼠标等待
            try
            {

                //打开数据
                IRasterDataset rasterdataset1 = DatasetFactory.OpenRasterDataset(栅格数据输入框.Text, OpenMode.ReadOnly);
                if (rasterdataset1 == null) { MessageBox.Show("数据打开失败"); return; }

                //获取栅格数据类型
                PixelDataType pixelType = rasterdataset1.GetRasterBand(0).GetRasterDataType();
                //获取栅格波段总数
                int bandcount = rasterdataset1.GetBandCount();
                //暂时只支持单波段影像
                if (bandcount > 1) { MessageBox.Show("请输入单波段文件"); return; }
                //获取栅格宽度
                int xsize = rasterdataset1.GetRasterXSize();
                //获取栅格高度
                int ysize = rasterdataset1.GetRasterYSize();

                //用于判断栅格的格式
                string rasterformat = 文件输出框.Text.Substring(文件输出框.Text.LastIndexOf(".")).ToLower();
                if (rasterformat == ".tif" || rasterformat == ".tiff") { rasterformat = "GTIFF"; }
                else if (rasterformat == ".img") { rasterformat = "HFA"; }
                else { rasterformat = "ENVI"; }
                //创建栅格
                IRasterDataset newRDataset = DatasetFactory.CreateRasterDataset(文件输出框.Text, xsize, ysize, bandcount, pixelType, rasterformat, null);

                //旧值字符串列表
                List<string> oldvalue = new List<string>();
                //新值字符串列表
                List<string> newvalue = new List<string>();
                //通过遍历将数据表中的数据分别加入旧、新值字符串列表中
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    oldvalue.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    newvalue.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
                //调用重分类算法参数为（原栅格数据集，新的栅格数据集，旧值字符串列表，新值字符串列表）
                reclassification(rasterdataset1, ref newRDataset, oldvalue, newvalue, pixelType);
                //设置输出栅格的坐标系与仿射变换参数
                newRDataset.SpatialReference = rasterdataset1.SpatialReference;
                double[] geotrans = rasterdataset1.GetGeoTransform();
                newRDataset.SetGeoTransform(geotrans);
                MessageBox.Show("重分类已完成");
                this.Close();
            }
            catch { MessageBox.Show("error"); }
            this.Cursor = Cursors.Default;//鼠标恢复正常状态
        }

        public void reclassification(IRasterDataset rasterdataset1, ref IRasterDataset newRDataset,
                    List<string> oldvalue, List<string> newvalue, PixelDataType pixelType)
        {
            #region
            //用于检测是否有无效值
            IRasterBand rasterband = rasterdataset1.GetRasterBand(0);
            PixelDataType pixelType1 = rasterband.GetRasterDataType();
            //获取栅格波段总数
            int bandcount = rasterdataset1.GetBandCount();
            //暂时只支持单波段影像
            if (bandcount > 1) { MessageBox.Show("请输入单波段文件"); return; }
            //用于创建新栅格的参数
            int[] bandmap = new int[bandcount];
            for (int i = 0; i < bandcount; i++) { bandmap[i] = i + 1; }
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
            #endregion
            //是否存在原影像的无效值
            bool isExsitOldNoDataValue = rasterband.IsExsitNoDataValue();
            //如果原影像存在无效值,则将无效值替换字符串"NoData"
            if (isExsitOldNoDataValue) { if (oldvalue.Contains("NoData")) { oldvalue[oldvalue.IndexOf("NoData")] = rasterband.GetNoDataValue().ToString(); } }
            //如果原影像不存在无效值，则将新旧值字符串列表删除掉NoData所在行
            else { if (oldvalue.Contains("NoData")) { newvalue.RemoveAt(oldvalue.IndexOf("NoData")); oldvalue.RemoveAt(oldvalue.IndexOf("NoData")); } }
            //如果新值存在NoData字符串
            if (newvalue.Contains("NoData"))
            {
                //设置新栅格的无效值并将新值的NoData字符串改为无效值
                try
                {
                    //设置新栅格的无效值
                    newRDataset.GetRasterBand(0).SetNoDataValue(Convert.ToDouble(oldvalue[newvalue.IndexOf("NoData")]));
                    //将新值的NoData字符串改为无效值
                    newvalue[newvalue.IndexOf("NoData")] = oldvalue[newvalue.IndexOf("NoData")];
                }
                catch { MessageBox.Show("设置无效值错误"); return; }
            }
            //用于有中断线'-'的行判断新旧值之间关系
            List<string> Condition = new List<string>();
            try
            {
                for (int r = 0; r < oldvalue.Count; r++)
                {

                    //为避免检测到负号，在去掉第一个字符后验证旧值列中是否含有‘-’字符
                    if (oldvalue[r].Substring(1).Contains("-"))
                    {
                        //为避免检测到负号，在去掉第一个字符后找出字符'-'的序号并加1可得出中断线'-'的序号
                        int index1 = oldvalue[r].Substring(1).IndexOf("-") + 1;
                        //获取中断线'-'前的数字
                        string condition1 = oldvalue[r].Substring(0, index1);
                        //获取中断线'-'后的数字
                        string condition2 = oldvalue[r].Substring(index1 + 1);
                        //更新旧值列表
                        Condition.Add(condition1);
                        Condition.Add(condition2);
                    }
                    //在去掉第一个字符后没有符号'-'则说明没有中断线
                    else
                    {
                        //更新旧值列表
                        Condition.Add(oldvalue[r]);
                    }
                }
            }
            catch { return; }

            #region  将Condition<string>、newvalue<string>转为对应数据类型的oldvaluearr、newvaluearr数组
            //用于Condition泛型转化的字符串
            string strArray1 = string.Join(",", Condition);
            //用于newvalue泛型转化的字符串
            string strArray2 = string.Join(",", newvalue);
            dynamic oldvaluearr; dynamic newvaluearr;
            switch (pixelType)
            {
                case PixelDataType.Byte: newvaluearr = Array.ConvertAll<string, byte>(strArray2.Split(','), s => byte.Parse(s)); break;
                case PixelDataType.Float32: newvaluearr = Array.ConvertAll<string, float>(strArray2.Split(','), s => float.Parse(s)); break;
                case PixelDataType.Float64: newvaluearr = Array.ConvertAll<string, double>(strArray2.Split(','), s => double.Parse(s)); break;
                case PixelDataType.Int16: newvaluearr = Array.ConvertAll<string, Int16>(strArray2.Split(','), s => Int16.Parse(s)); break;
                case PixelDataType.Int32: newvaluearr = Array.ConvertAll<string, Int32>(strArray2.Split(','), s => Int32.Parse(s)); break;
                case PixelDataType.UInt16: newvaluearr = Array.ConvertAll<string, UInt16>(strArray2.Split(','), s => UInt16.Parse(s)); break;
                case PixelDataType.UInt32: newvaluearr = Array.ConvertAll<string, UInt32>(strArray2.Split(','), s => UInt32.Parse(s)); break;
                default: newvaluearr = Array.ConvertAll<string, dynamic>(strArray2.Split(','), s => double.Parse(s)); break;
            }
            switch (pixelType1)
            {
                case PixelDataType.Byte: oldvaluearr = Array.ConvertAll<string, byte>(strArray1.Split(','), s => byte.Parse(s)); break;
                case PixelDataType.Float32: oldvaluearr = Array.ConvertAll<string, float>(strArray1.Split(','), s => float.Parse(s)); break;
                case PixelDataType.Float64: oldvaluearr = Array.ConvertAll<string, double>(strArray1.Split(','), s => double.Parse(s)); break;
                case PixelDataType.Int16: oldvaluearr = Array.ConvertAll<string, Int16>(strArray1.Split(','), s => Int16.Parse(s)); break;
                case PixelDataType.Int32: oldvaluearr = Array.ConvertAll<string, Int32>(strArray1.Split(','), s => Int32.Parse(s)); break;
                case PixelDataType.UInt16: oldvaluearr = Array.ConvertAll<string, UInt16>(strArray1.Split(','), s => UInt16.Parse(s)); break;
                case PixelDataType.UInt32: oldvaluearr = Array.ConvertAll<string, UInt32>(strArray1.Split(','), s => UInt32.Parse(s)); break;
                default: oldvaluearr = Array.ConvertAll<string, dynamic>(strArray1.Split(','), s => double.Parse(s)); break;
            }
            #endregion

            #region
            //将整副影像拆分为(x+1)*(y+1)次进行计算
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
                    { XSegmentationSize = 1000; }
                    dynamic arr;
                    dynamic newarr;
                    #region 定义arr和newarr
                    switch (pixelType)
                    {
                        case PixelDataType.Byte: newarr = new byte[XSegmentationSize * YSegmentationSize]; break;
                        case PixelDataType.Float32: newarr = new float[XSegmentationSize * YSegmentationSize]; break;
                        case PixelDataType.Float64: newarr = new double[XSegmentationSize * YSegmentationSize]; break;
                        case PixelDataType.Int16: newarr = new short[XSegmentationSize * YSegmentationSize]; break;
                        case PixelDataType.Int32: newarr = new Int32[XSegmentationSize * YSegmentationSize]; break;
                        case PixelDataType.UInt16: newarr = new ushort[XSegmentationSize * YSegmentationSize]; break;
                        case PixelDataType.UInt32: newarr = new UInt32[XSegmentationSize * YSegmentationSize]; break;
                        default: newarr = new dynamic[XSegmentationSize * YSegmentationSize]; break;
                    }
                    switch (pixelType1)
                    {
                        case PixelDataType.Byte: arr = new byte[XSegmentationSize * YSegmentationSize]; break;
                        case PixelDataType.Float32: arr = new float[XSegmentationSize * YSegmentationSize]; break;
                        case PixelDataType.Float64: arr = new double[XSegmentationSize * YSegmentationSize]; break;
                        case PixelDataType.Int16: arr = new short[XSegmentationSize * YSegmentationSize]; break;
                        case PixelDataType.Int32: arr = new Int32[XSegmentationSize * YSegmentationSize]; break;
                        case PixelDataType.UInt16: arr = new ushort[XSegmentationSize * YSegmentationSize]; break;
                        case PixelDataType.UInt32: arr = new UInt32[XSegmentationSize * YSegmentationSize]; break;
                        default: arr = new dynamic[XSegmentationSize * YSegmentationSize]; break;
                    }
                    #endregion
                    //读取栅格数据
                    rasterdataset1.Read(xi * 1000, yi * 1000, XSegmentationSize, YSegmentationSize, arr, XSegmentationSize, YSegmentationSize,
                        pixelType1, bandcount, bandmap);

                    //对读取的栅格数据arr数组进行循环
                    for (int i = 0; i < XSegmentationSize * YSegmentationSize; i++)
                    {
                        //当前旧值列表的数序号
                        int oldvalueindex = 0;

                        //对的旧值列表进行循环
                        for (int r = 0; r < oldvalue.Count; r++)
                        {
                            //再次判断是否有中断线，若有则判断arr[i]是否在oldvaluearr的当前序号和下一序号值之间
                            //为避免检测到负号，在去掉第一个字符后验证旧值列中是否含有‘-’字符
                            if (oldvalue[r].Substring(1).Contains("-"))
                            {
                                //判断是否处于中断线两值之间，若是，则写入新数组
                                if (oldvaluearr[oldvalueindex] <= arr[i] && arr[i] <= oldvaluearr[oldvalueindex + 1])
                                {
                                    //获取数值并写入新数组
                                    newarr[i] = newvaluearr[r];
                                }
                                oldvalueindex += 2;
                            }
                            //若没有中断线，则直接判断arr[i]是否等于oldvaluearr的当前序号的值
                            //在去掉第一个字符后没有符号'-'则说明没有中断线
                            else
                            {
                                if (arr[i] == oldvaluearr[oldvalueindex])
                                {
                                    //获取数值并写入新数组
                                    newarr[i] = newvaluearr[r];
                                }
                                oldvalueindex++;
                            }
                        }
                    }
                    //写入栅格
                    newRDataset.Write(xi * 1000, yi * 1000, XSegmentationSize, YSegmentationSize, newarr, XSegmentationSize, YSegmentationSize, pixelType, bandcount, bandmap);
            #endregion
                }
            }
        }

        private void 重分类_Load(object sender, EventArgs e)
        {
            //主窗口
            pie1 = (FormMain)this.Owner;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //当选择文件名后更改为改文件路径
            if (index == 栅格数据输入框.SelectedIndex) { return; }
            index = 栅格数据输入框.SelectedIndex;
            栅格数据输入框.Items[index] = pie1.mapControlMain.FocusMap.GetLayer(index).DataSourcePath;
            try { readData(); }
            catch { MessageBox.Show("请选择栅格数据"); }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            //更新输入文件的内容
            /*comboBox1.Items.Clear();
            for (int i = 0; i < pie1.mapControlMain.FocusMap.LayerCount; i++)
            { comboBox1.Items.Add(pie1.mapControlMain.FocusMap.GetLayer(i).Name); }*/
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//获取唯一值
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < oldvalue.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[0].Value = oldvalue[i];
                dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[1].Value = i + 1;
            }
            dataGridView1.Rows.Add();
            dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[0].Value = "NoData";
            dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[1].Value = "NoData";
        }

        private void button3_Click(object sender, EventArgs e)//添加条目
        {
            dataGridView1.Rows.Add();
        }

        private void button4_Click(object sender, EventArgs e)//移除条目
        {
            if (dataGridView1.Rows.Count > 1)
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[dataGridView1.CurrentRow.Index]);
            }
        }

        private void button5_Click(object sender, EventArgs e)//对新值取反
        {
            List<string> newvalue = new List<string>();
            if (dataGridView1.Rows.Count > 2)
            {
                //读取除"NoData"行之外的值
                for (int i = 0; i < dataGridView1.Rows.Count - 2; i++)
                { newvalue.Add(dataGridView1.Rows[i].Cells[1].Value.ToString()); }
                //倒序
                newvalue.Reverse();
                for (int i = 0; i < dataGridView1.Rows.Count - 2; i++)
                {
                    dataGridView1.Rows[i].Cells[1].Value = newvalue[i];
                }
            }
        }
    }
}