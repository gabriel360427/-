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
using PIE.AxControls;

namespace 绿廊智绘.Custom_Commands
{

    public partial class linearResistanceFactor: DevExpress.XtraEditors.XtraForm
    {
        public linearResistanceFactor()
        {
            InitializeComponent();
        }
        //主窗口
        FormMain pie1;
        public IMapControl m_MapControl;
        //全局变量，表示当前输入文件框所选择的序号
        int index1 = -1;
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//输入矢量数据
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "打开矢量数据";
            open.Filter = "矢量数据|*.shp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                矢量数据输入框.Text = open.FileName;
                文件输出框.Text = 矢量数据输入框.Text.Substring(0, 矢量数据输入框.Text.LastIndexOf(".")) + "阻力.tif";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//当选择文件名后更改为改文件路径
        {
            if (index1 == 矢量数据输入框.SelectedIndex) { return; }
            index1 = 矢量数据输入框.SelectedIndex;
            矢量数据输入框.Items[index1] = pie1.mapControlMain.FocusMap.GetLayer(index1).DataSourcePath;
            try
            {
                ILayer layer = LayerFactory.CreateDefaultLayer(矢量数据输入框.Text);
                IFeatureClass featureClass = (layer as IFeatureLayer).FeatureClass;
                if (featureClass == null) { MessageBox.Show("请打开矢量数据"); return; }
            }
            catch { MessageBox.Show("请打开矢量数据"); return; }
            文件输出框.Text = 矢量数据输入框.Text.Substring(0, 矢量数据输入框.Text.LastIndexOf(".")) + "阻力.tif";
        }

        private void button4_Click(object sender, EventArgs e)//设置输出文件路径
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "输出栅格文件";
            savefile.Filter = "栅格文件|*.tif;*.tiff;*.bmp;*.img;*.jpg;*.ldf";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                文件输出框.Text = savefile.FileName;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)//当选择文件名后更改为改文件路径
        {
            if (index1 == 文件输出框.SelectedIndex) { return; }
            index1 = 文件输出框.SelectedIndex;
            文件输出框.Items[index1] = pie1.mapControlMain.FocusMap.GetLayer(index1).DataSourcePath;
            try
            {
                ILayer layer = LayerFactory.CreateDefaultLayer(文件输出框.Text);
                IFeatureClass featureClass = (layer as IFeatureLayer).FeatureClass;
                if (featureClass == null) { MessageBox.Show("请打开矢量数据"); return; }
            }
            catch { MessageBox.Show("请打开矢量数据"); return; }
            文件输出框.Text = 文件输出框.Text.Substring(0, 文件输出框.Text.LastIndexOf(".")) + "阻力.tif";
        }

        private void button2_Click(object sender, EventArgs e)//输入基准影像文件
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "输入基准影像";
            open.Filter = "基准影像|*.tif;*.tiff;*.bmp;*.img;*.jpg;*.ldf";
            if (open.ShowDialog() == DialogResult.OK)
            {
                基准影像输入框.Text = open.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)//输入裁剪矢量文件
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "输入矢量文件";
            openfile.Filter = "矢量文件|*.shp";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                裁剪矢量文件输入框.Text = openfile.FileName;
            }
        }
        int index;//输入文件的最后一个"."的序号
        string BufferDistance;//输入的缓冲区
        int num;//输入范围的个数，决定了要做几次循环
        int nownum;//现在循环的次数
        string path;//当前文件路径
        string message = ""; //分析结束时提供给用户的信息
        List<string> oldvalue;//缓冲区值字符串列表
        List<string> newvalue;//分类程度值字符串列表
        string oldNoData; //暂存旧值列表的无效值字符串
        string newNoData;//暂存新值列表的无效值字符串
        private void button5_Click(object sender, EventArgs e)//进行缓冲区分析
        {
            this.Cursor = Cursors.WaitCursor;//鼠标等待
            //获取除无效值列有多少行记录
            num = dataGridView1.RowCount - 2;
            //缓冲区值字符串列表
            oldvalue = new List<string>();
            //分类程度值字符串列表
            newvalue = new List<string>();
            //读取数据表中的第一二列数据
            for (int i = 0; i < num; i++)
            {
                oldvalue.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                newvalue.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
            }
            //获取新旧无效值字符串
            oldNoData = dataGridView1.Rows[num].Cells[0].Value.ToString();
            newNoData = dataGridView1.Rows[num].Cells[1].Value.ToString();
            ILayer layer = LayerFactory.CreateDefaultLayer(矢量数据输入框.Text);
            IFeatureClass featureClass = (layer as IFeatureLayer).FeatureClass;
            if (featureClass == null) { MessageBox.Show("打开矢量数据错误"); this.Cursor = Cursors.Default; return; }
            //获得中心Y坐标
            double CentralLatitude = (featureClass.GetExtent().YMax + featureClass.GetExtent().YMin) / 2;
            //若为地理坐标则需用算法转化单位（m），若为投影坐标则无需转化
            double co = 2 * Math.PI * 6371.393 / 360 * Math.Cos(CentralLatitude / 180 * Math.PI);

            //如果存在正无穷，
            if (oldvalue.Contains("∞"))
            {
                int i = oldvalue.IndexOf("∞");
                if (featureClass.GetExtent().GetHeight() < featureClass.GetExtent().GetWidth())
                { oldvalue[i] = featureClass.GetExtent().GetWidth().ToString(); }
                else { oldvalue[i] = featureClass.GetExtent().GetHeight().ToString(); }

                //若为地理坐标则转为米
                if (-90 <= CentralLatitude & CentralLatitude <= 90)
                { oldvalue[i] = Convert.ToInt32((Convert.ToDouble(oldvalue[i]) * co * 1000)).ToString(); }
            }
            //对每一行记录进行循环
            for (nownum = 0; nownum < num; nownum++)
            {
                try
                {//调用缓冲区算法并执行
                    #region 缓冲区

                    PIE.CommonAlgo.stBufferAnalyse_Exchange_Info info = new stBufferAnalyse_Exchange_Info();

                    //获取缓冲区距离
                    BufferDistance = oldvalue[nownum];
                    if (-90 <= CentralLatitude & CentralLatitude <= 90)
                    { info.dbDistance = Convert.ToDouble(BufferDistance) / co / 1000; }//为地理坐标则需用算法转化单位（m）为对应的经纬度单位
                    else { info.dbDistance = Convert.ToDouble(BufferDistance); }//为投影坐标则无需转化

                    //获取输入文件最后一个'.'的序号
                    index = 矢量数据输入框.Text.LastIndexOf(".");
                    info.strInputFile = 矢量数据输入框.Text;
                    //在最后一个'.'前插入缓冲距离
                    info.strOutputFile = 矢量数据输入框.Text.Insert(index, BufferDistance);
                    //获取当前输出路径
                    path = info.strOutputFile;
                    //更新当前path的最后'.'的序号
                    index = path.LastIndexOf(".");
                    //根据序号选择末端类型
                    if (末端类型.SelectedIndex == 0) { info.endCapStyle = EndCapStyle.EndCapStyle_Round; }
                    else if (末端类型.SelectedIndex == 1) { info.endCapStyle = EndCapStyle.EndCapStyle_Flat; }
                    else
                    {
                        MessageBox.Show("请选择末端类型"); this.Cursor = Cursors.Default; return;
                    }
                    //根据序号选择侧类型
                    if (侧类型.SelectedIndex == 0) { info.sideType = SideType.SideType_Full; }
                    else if (侧类型.SelectedIndex == 1) { info.sideType = SideType.SideType_Left; }
                    else if (侧类型.SelectedIndex == 2) { info.sideType = SideType.SideType_Right; }
                    else { MessageBox.Show("请选择侧类型"); this.Cursor = Cursors.Default; return; }
                    //根据序号选择融合类型
                    if (融合类型.SelectedIndex == 1) { info.fuseType = FuseType.FuseType_All; }
                    else if (融合类型.SelectedIndex == 0) { info.fuseType = FuseType.FuseType_None; }
                    else { MessageBox.Show("请选择融合类型"); this.Cursor = Cursors.Default; return; }

                    PIE.SystemAlgo.ISystemAlgo algo = PIE.SystemAlgo.AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.BufferAnalysisAlgo");
                    if (algo == null) { this.Cursor = Cursors.Default; return; }
                    PIE.SystemAlgo.ISystemAlgoEvents algoEvents = algo as PIE.SystemAlgo.ISystemAlgoEvents;
                    algoEvents.OnExecuteCompleted += algoEvents_OnExecuteCompleted;
                    algo.Params = info;
                    PIE.SystemAlgo.AlgoFactory.Instance().ExecuteAlgo(algo);
                    #endregion
                }
                catch { MessageBox.Show("缓冲区分析错误"); this.Cursor = Cursors.Default; return; }
            }
        }
        void algoEvents_OnExecuteCompleted(ISystemAlgo algo)
        {
            //写入message信息
            message += "缓冲区" + oldvalue[nownum] + "已完成。\n\r文件已保存在" + path + "\n\r";
            #region 添加矢量字段
            int bufferValueIndex;//获取字段序号
            try
            {
                if (是否添加矢量字段.Checked == false) { this.Cursor = Cursors.Default; return; }//是否添加矢量字段
                //打开当前path的缓冲区文件
                IFeatureDataset featureDataset = DatasetFactory.OpenFeatureDataset(path);
                //判断原字段是否有buffer或buffer1等等
                IField field1;
                //若有buffer字段，则寻找"buffer+数字"字段
                if (featureDataset.GetFields().GetFieldIndex("buffer") >= 0)
                {
                    int i;
                    //寻找是否有buffer1，buffer2...字段，直到没有buffer+i字段
                    for (i = 1; featureDataset.GetFields().GetFieldIndex("buffer" + i.ToString()) >= 0; i++) { }
                    field1 = new Field("buffer" + i.ToString(), FieldType.OFTInteger, 20, 0);
                    field1.Name = "buffer" + i.ToString();
                    field1.AliasName = "缓冲值" + i.ToString();
                }
                //没有buffer就直接创建
                else
                {
                    field1 = new Field("buffer", FieldType.OFTInteger, 20, 0);
                    field1.Name = "buffer";
                    field1.AliasName = "缓冲值";
                }
                //2矢量数据集的删除和修改
                featureDataset.AddField(field1, true);
                //获取字段序号
                bufferValueIndex = featureDataset.GetFields().GetFieldIndex(field1.Name);
                //遍历矢量属性表的每条记录并添加其缓冲区大小值
                for (uint i = 0; i < featureDataset.GetFeatureCount(); i++)
                {
                    //获取记录
                    IFeature feature = featureDataset.GetFeature(i);
                    //添加其缓冲区大小值
                    feature.SetValue(feature.GetFieldIndex(field1.Name), Convert.ToInt32(oldvalue[nownum]));
                    //更新保存记录
                    featureDataset.UpdateFeature(feature);
                }
                IFeatureLayer featureLayer = new FeatureLayer();
                IFeatureClass fClass = new FeatureClass(featureDataset);
                featureLayer.FeatureClass = fClass;
                featureDataset.Save();
            }
            catch { MessageBox.Show("添加矢量字段失败"); this.Cursor = Cursors.Default; return; }
            #endregion
            #region 矢量转栅格
            try
            {
                VectorToRaster_Exchange_Info info = new VectorToRaster_Exchange_Info();
                //将当前path输入
                info.strInputFile = path;
                //将文件的去掉后缀加s代表栅格并加tif后缀
                info.strOutputFile = path.Substring(0, index) + "s.tif";//输出文件
                //更新当前path
                path = info.strOutputFile;
                //更新当前path的最后'.'的序号
                index = path.LastIndexOf(".");
                //根据缓冲值进行转换
                info.nFieldIndex = bufferValueIndex;
                string s = info.strOutputFile.Substring(info.strOutputFile.LastIndexOf(".")).ToLower();
                if (s == ".tif" || s == ".tiff") { info.strOutputFileType = "GTiff"; }
                else if (s == ".img") { info.strOutputFileType = "HFA"; }
                else { info.strOutputFileType = "ENVI"; }
                info.bHasNoData = false;//默认为不设置无效值
                //是否指定大小
                if (tabControl1.SelectedIndex == 0)
                {
                    info.bStandardFile = false;
                    info.x = Convert.ToInt32(X.Text);
                    info.y = Convert.ToInt32(Y.Text);
                }
                //是否基准影像
                else if (tabControl1.SelectedIndex == 1)
                {
                    info.bStandardFile = true;
                    info.strStandardFile = 基准影像输入框.Text;//输入影像文件
                }

                PIE.SystemAlgo.ISystemAlgo algo1 = PIE.SystemAlgo.AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.VectorToRasterAlgo");
                if (algo1 == null) { MessageBox.Show("矢量转栅格失败"); this.Cursor = Cursors.Default; return; }

                PIE.SystemAlgo.ISystemAlgoEvents algoEvents1 = algo1 as PIE.SystemAlgo.ISystemAlgoEvents;
                algoEvents1.OnExecuteCompleted += algoEvents1_OnExecuteCompleted;
                algo1.Name = "矢量转栅格";
                algo1.Params = info;
                bool result = PIE.SystemAlgo.AlgoFactory.Instance().ExecuteAlgo(algo1);

            }
            catch { MessageBox.Show("矢量" + oldvalue[nownum] + "转栅格失败"); this.Cursor = Cursors.Default; return; }
            #endregion
        }
        //矢量转栅格完成事件
        void algoEvents1_OnExecuteCompleted(ISystemAlgo algo)
        {
            IRasterDataset rasterdataset1 = DatasetFactory.OpenRasterDataset(path, OpenMode.Update);
            if (rasterdataset1 == null) { MessageBox.Show("数据打开失败"); this.Cursor = Cursors.Default; return; }
            IRasterDataset rasterdataset2 = DatasetFactory.OpenRasterDataset(基准影像输入框.Text, OpenMode.ReadOnly);
            if (rasterdataset2 == null) { MessageBox.Show("数据打开失败"); this.Cursor = Cursors.Default; return; }

            rasterdataset1.SpatialReference = rasterdataset2.SpatialReference;
            double[] geotrans = rasterdataset2.GetGeoTransform();
            rasterdataset1.SetGeoTransform(geotrans);
            (rasterdataset1 as IDisposable).Dispose();
            (rasterdataset2 as IDisposable).Dispose();

            //更新message
            message += "矢量" + oldvalue[nownum] + "转栅格已完成。\n\r文件已保存在" + path + "\n\r";
            //当最后一次循环的矢量转栅格完成时进行波段运算
            if (num - 1 == nownum)
            {
                #region 波段运算
                try
                {
                    #region 1、参数设置
                    PIE.CommonAlgo.BandOper_Exchange_Info info = new PIE.CommonAlgo.BandOper_Exchange_Info();
                    //若缓冲距离记录只有一条则只返回原影像
                    info.StrExp = "b1";
                    //若缓冲区距离距离记录有多条则取所有影像叠加的最小值
                    for (int i = 2; i <= num; i++)
                    {
                        //表达式为b1+b2+b3...+bn
                        info.StrExp += "+b" + i.ToString();
                    }
                    //波段列表
                    List<int> selectfileband = new List<int>();
                    //文件名列表
                    List<string> selectfilename = new List<string>();
                    for (int i = 0; i < num; i++)
                    {
                        selectfileband.Add(1);
                        //根据之前的命名规则将每一个矢量转栅格后的文件找出（先去掉输入文件的后缀，加上缓冲距离，再加s，再加.tif的后缀）
                        selectfilename.Add(矢量数据输入框.Text.Substring(0, 矢量数据输入框.Text.LastIndexOf(".")) + oldvalue[i] + "s.tif");
                    }
                    info.SelectFileBands = selectfileband;
                    info.SelectFileNames = selectfilename;
                    //命名为输出文件的后缀前加入_math代表波段运算后的文件
                    info.OutputFilePath = 文件输出框.Text.Insert(文件输出框.Text.LastIndexOf('.'), "_math");
                    //更新path
                    path = info.OutputFilePath;
                    //更新index
                    index = path.LastIndexOf(".");
                    //数据类型为长整型
                    info.PixelDataType = 4;
                    string s = info.OutputFilePath.Substring(info.OutputFilePath.LastIndexOf(".")).ToLower();
                    if (s == ".tif" || s == ".tiff") { info.FileTypeCode = "GTIFF"; }
                    else if (s == ".img") { info.FileTypeCode = "HFA"; }
                    else { info.FileTypeCode = "ENVI"; }

                    PIE.SystemAlgo.ISystemAlgo algo2 = PIE.SystemAlgo.AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.BandOperAlgo");
                    if (algo2 == null) { MessageBox.Show("波段运算错误"); this.Cursor = Cursors.Default; return; }
                    #endregion

                    //2、算法执行
                    PIE.SystemAlgo.ISystemAlgoEvents algoEvents2 = algo2 as PIE.SystemAlgo.ISystemAlgoEvents;
                    algoEvents2.OnExecuteCompleted += algoEvents2_OnExecuteCompleted;
                    algo2.Name = "波段运算";
                    algo2.Params = info;

                    //3、结果显示
                    bool result = PIE.SystemAlgo.AlgoFactory.Instance().ExecuteAlgo(algo2);
                    if (!result)
                    {
                        MessageBox.Show("波段算法执行失败");
                    }
                }
                catch { MessageBox.Show("波段算法错误"); }
                #endregion
            }
        }

        //波段运算完成事件
        void algoEvents2_OnExecuteCompleted(ISystemAlgo algo2)
        {
            //更新message
            message += "波段运算已完成。\n\r文件已保存在" + path + "\n\r";
            #region 矢量裁剪
            try
            {
                //Clip裁剪
                PIE.CommonAlgo.DataPreImgClip_Exchange_Info info = new PIE.CommonAlgo.DataPreImgClip_Exchange_Info();
                //参数设置 
                info.InputFilePath = path;  //待裁剪影像
                info.OutputFilePath = path.Insert(index, "_clip");  //裁剪保存结果
                path = info.OutputFilePath;//更新path
                index = path.LastIndexOf(".");//更新index
                PIE.DataSource.IRasterDataset rDataset = PIE.DataSource.DatasetFactory.OpenRasterDataset(info.InputFilePath, PIE.DataSource.OpenMode.ReadOnly);
                if (rDataset == null) { this.Cursor = Cursors.Default; return; }
                int count = rDataset.GetBandCount();
                List<int> list = new List<int> { };
                for (int i = 0; i < count; i++)
                {
                    list.Add(i);
                }
                info.listBands = list;
                //是否设置无效值
                info.bInvalidValue = false;
                string s = 文件输出框.Text.Substring(文件输出框.Text.LastIndexOf(".")).ToLower();
                if (s == ".tif" || s == ".tiff") { info.FileType = "GTIFF"; }
                else if (s == ".img") { info.FileType = "HFA"; }
                else { info.FileType = "ENVI"; }

                if (tabControl2.SelectedIndex == 0)
                {
                    info.Type = 1;  // (等于1表示使用shape文件裁剪) }
                    info.ShpFilePath = 裁剪矢量文件输入框.Text; //裁剪的几何要素
                }
                if (tabControl2.SelectedIndex == 1)
                {
                    info.Type = 0;  // (等于0表示通过栅格范围裁剪)
                    info.XFactor = 1;
                    info.YFactor = 1;
                    info.XStart = Convert.ToInt32(X1.Text);
                    info.XEnd = Convert.ToInt32(X2.Text);
                    info.YStart = Convert.ToInt32(Y1.Text);
                    info.YEnd = Convert.ToInt32(Y2.Text);
                }
                PIE.SystemAlgo.ISystemAlgo algo3 = PIE.SystemAlgo.AlgoFactory.Instance().CreateAlgo("PIE.CommonAlgo.dll", "PIE.CommonAlgo.ImageClipAlgo");
                if (algo3 == null) { this.Cursor = Cursors.Default; return; }

                PIE.SystemAlgo.ISystemAlgoEvents algoEvents3 = algo3 as PIE.SystemAlgo.ISystemAlgoEvents;
                algoEvents3.OnExecuteCompleted += algoEvents3_OnExecuteCompleted;
                algo3.Name = "矢量裁剪";
                algo3.Params = info;
                PIE.SystemAlgo.AlgoFactory.Instance().ExecuteAlgo(algo3);
            }
            catch
            {
                MessageBox.Show("矢量裁剪出现错误");
            }
            #endregion
        }

        //矢量裁剪完成事件
        void algoEvents3_OnExecuteCompleted(ISystemAlgo algo3)
        {
            //更新message
            message += "矢量裁剪已完成。\n\r文件已保存在" + path + "\n\r";

            //打开数据
            IRasterDataset rasterdataset1 = DatasetFactory.OpenRasterDataset(path, OpenMode.ReadOnly);
            if (rasterdataset1 == null) { MessageBox.Show("数据打开失败"); this.Cursor = Cursors.Default; return; }

            //获取输出路径
            path = 文件输出框.Text;
            //用于判断栅格的格式
            string rasterformat = path.Substring(path.LastIndexOf(".")).ToLower();
            if (rasterformat == ".tif" || rasterformat == ".tiff") { rasterformat = "GTIFF"; }
            else if (rasterformat == ".img") { rasterformat = "HFA"; }
            else { rasterformat = "ENVI"; }

            //栅格像元数据类型
            PixelDataType pixelType;
            //判断输出数据类型
            switch (输出文件数据类型.SelectedIndex)
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
            IRasterDataset newRDataset = DatasetFactory.CreateRasterDataset(path, rasterdataset1.GetRasterXSize(),
                rasterdataset1.GetRasterYSize(), rasterdataset1.GetBandCount(), pixelType, rasterformat, null);

            for (int i = num - 2; i >= 0; i--)
            {
                //由于波段运算的值相加，故旧值列表应更新
                oldvalue[i] = (Convert.ToInt32(oldvalue[i]) + Convert.ToInt32(oldvalue[i + 1])).ToString();
            }
            oldvalue.Add(oldNoData);
            newvalue.Add(newNoData);
            #region 重分类
            reClassification reclass1 = new reClassification();
            reclass1.reclassification(rasterdataset1, ref newRDataset, oldvalue, newvalue, pixelType);
            #endregion

            newRDataset.SpatialReference = rasterdataset1.SpatialReference;
            double[] geotrans = rasterdataset1.GetGeoTransform();
            newRDataset.SetGeoTransform(geotrans);
            //更新message
            message += "重分类已完成。\n\r文件已保存在" + path + "\n\r";
            //弹出message
            MessageBox.Show(message);
            this.Cursor = Cursors.Default;
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)//关闭窗口
        {
            this.Close();
        }

        private void 铁路因子_Load(object sender, EventArgs e)
        {
            侧类型.SelectedItem = 侧类型.Items[0];
            融合类型.SelectedItem = 融合类型.Items[1];
            末端类型.SelectedItem = 末端类型.Items[0];
            //主窗口
           /* pie1 = (FormMain)this.Owner;
            dataGridView1.Rows.Add(new object[] { "100", "9" });
            dataGridView1.Rows.Add(new object[] { "300", "7" });
            dataGridView1.Rows.Add(new object[] { "500", "5" });
            dataGridView1.Rows.Add(new object[] { "1000", "3" });
            dataGridView1.Rows.Add(new object[] { "∞", "1" });
            dataGridView1.Rows.Add(new object[] { "NoData", "NoData" });*/
        }

    }
}