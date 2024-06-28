
namespace 绿廊智绘.Custom_Forms
{
    partial class POI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POI));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.结果框 = new System.Windows.Forms.RichTextBox();
            this.取消 = new System.Windows.Forms.Button();
            this.确定 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.第二期POI加载按钮 = new System.Windows.Forms.Button();
            this.第二景分类文件框 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.第一期POI加载按钮 = new System.Windows.Forms.Button();
            this.第一景分类文件框 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mapControl1 = new PIE.AxControls.MapControl();
            this.mapControl2 = new PIE.AxControls.MapControl();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.POImapControl2 = new PIE.AxControls.MapControl();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton19 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton20 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton21 = new System.Windows.Forms.ToolStripButton();
            this.POImapControl1 = new PIE.AxControls.MapControl();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.结果框);
            this.groupBox3.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(12, 640);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1187, 126);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "统计结果";
            // 
            // 结果框
            // 
            this.结果框.Location = new System.Drawing.Point(6, 25);
            this.结果框.Name = "结果框";
            this.结果框.Size = new System.Drawing.Size(1175, 94);
            this.结果框.TabIndex = 0;
            this.结果框.Text = "";
            this.结果框.TextChanged += new System.EventHandler(this.结果框_TextChanged);
            // 
            // 取消
            // 
            this.取消.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.取消.Location = new System.Drawing.Point(1111, 52);
            this.取消.Name = "取消";
            this.取消.Size = new System.Drawing.Size(88, 49);
            this.取消.TabIndex = 10;
            this.取消.Text = "取消";
            this.取消.UseVisualStyleBackColor = true;
            this.取消.Click += new System.EventHandler(this.取消_Click);
            // 
            // 确定
            // 
            this.确定.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.确定.Location = new System.Drawing.Point(1014, 52);
            this.确定.Name = "确定";
            this.确定.Size = new System.Drawing.Size(91, 49);
            this.确定.TabIndex = 9;
            this.确定.Text = "确定";
            this.确定.UseVisualStyleBackColor = true;
            this.确定.Click += new System.EventHandler(this.确定_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.第二期POI加载按钮);
            this.groupBox2.Controls.Add(this.第二景分类文件框);
            this.groupBox2.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(523, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 89);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输入第二期POI数据";
            // 
            // 第二期POI加载按钮
            // 
            this.第二期POI加载按钮.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.第二期POI加载按钮.Location = new System.Drawing.Point(376, 36);
            this.第二期POI加载按钮.Name = "第二期POI加载按钮";
            this.第二期POI加载按钮.Size = new System.Drawing.Size(103, 34);
            this.第二期POI加载按钮.TabIndex = 3;
            this.第二期POI加载按钮.Text = "加载";
            this.第二期POI加载按钮.UseVisualStyleBackColor = true;
            this.第二期POI加载按钮.Click += new System.EventHandler(this.第二期POI加载按钮_Click);
            // 
            // 第二景分类文件框
            // 
            this.第二景分类文件框.FormattingEnabled = true;
            this.第二景分类文件框.Location = new System.Drawing.Point(6, 42);
            this.第二景分类文件框.Name = "第二景分类文件框";
            this.第二景分类文件框.Size = new System.Drawing.Size(364, 24);
            this.第二景分类文件框.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.第一期POI加载按钮);
            this.groupBox1.Controls.Add(this.第一景分类文件框);
            this.groupBox1.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 89);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入第一期POI数据";
            // 
            // 第一期POI加载按钮
            // 
            this.第一期POI加载按钮.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.第一期POI加载按钮.Location = new System.Drawing.Point(401, 38);
            this.第一期POI加载按钮.Name = "第一期POI加载按钮";
            this.第一期POI加载按钮.Size = new System.Drawing.Size(98, 31);
            this.第一期POI加载按钮.TabIndex = 2;
            this.第一期POI加载按钮.Text = "加载";
            this.第一期POI加载按钮.UseVisualStyleBackColor = true;
            this.第一期POI加载按钮.Click += new System.EventHandler(this.第一期POI加载按钮_Click);
            // 
            // 第一景分类文件框
            // 
            this.第一景分类文件框.FormattingEnabled = true;
            this.第一景分类文件框.Location = new System.Drawing.Point(7, 42);
            this.第一景分类文件框.Name = "第一景分类文件框";
            this.第一景分类文件框.Size = new System.Drawing.Size(388, 24);
            this.第一景分类文件框.TabIndex = 0;
            this.第一景分类文件框.SelectedIndexChanged += new System.EventHandler(this.第一景分类文件框_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.splitContainer1);
            this.groupBox4.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(12, 107);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1187, 530);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "变化展示";
            // 
            // mapControl1
            // 
            this.mapControl1.BackColor = System.Drawing.Color.White;
            this.mapControl1.CustomerProperty = null;
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(577, 502);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.Text = "第一期";
            // 
            // mapControl2
            // 
            this.mapControl2.BackColor = System.Drawing.Color.White;
            this.mapControl2.CustomerProperty = null;
            this.mapControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl2.Location = new System.Drawing.Point(0, 0);
            this.mapControl2.Name = "mapControl2";
            this.mapControl2.Size = new System.Drawing.Size(600, 502);
            this.mapControl2.TabIndex = 0;
            this.mapControl2.Text = "第二期";
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(1167, 12);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 13;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip2);
            this.splitContainer2.Panel1.Controls.Add(this.POImapControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.toolStrip3);
            this.splitContainer2.Panel2.Controls.Add(this.POImapControl2);
            this.splitContainer2.Size = new System.Drawing.Size(1181, 474);
            this.splitContainer2.SplitterDistance = 589;
            this.splitContainer2.TabIndex = 0;
            // 
            // POImapControl2
            // 
            this.POImapControl2.BackColor = System.Drawing.Color.White;
            this.POImapControl2.CustomerProperty = null;
            this.POImapControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.POImapControl2.Location = new System.Drawing.Point(0, 0);
            this.POImapControl2.Name = "POImapControl2";
            this.POImapControl2.Size = new System.Drawing.Size(588, 474);
            this.POImapControl2.TabIndex = 0;
            this.POImapControl2.Text = "第二期POI地图控件";
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton16,
            this.toolStripButton17,
            this.toolStripButton18,
            this.toolStripButton19,
            this.toolStripButton20,
            this.toolStripButton21});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(588, 25);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.Image = global::绿廊智绘.Properties.Resources.MainCategory_DeleteAllSelect;
            this.toolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton16.Text = "清空图层";
            this.toolStripButton16.Click += new System.EventHandler(this.toolStripButton16_Click);
            // 
            // toolStripButton17
            // 
            this.toolStripButton17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton17.Image")));
            this.toolStripButton17.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton17.Name = "toolStripButton17";
            this.toolStripButton17.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton17.Text = "移动图层";
            this.toolStripButton17.Click += new System.EventHandler(this.toolStripButton17_Click);
            // 
            // toolStripButton18
            // 
            this.toolStripButton18.Image = global::绿廊智绘.Properties.Resources.MapBrowser_Pan;
            this.toolStripButton18.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton18.Name = "toolStripButton18";
            this.toolStripButton18.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton18.Text = "漫游";
            this.toolStripButton18.Click += new System.EventHandler(this.toolStripButton18_Click);
            // 
            // toolStripButton19
            // 
            this.toolStripButton19.Image = global::绿廊智绘.Properties.Resources.MapBrowser_CenterZoomIn;
            this.toolStripButton19.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton19.Name = "toolStripButton19";
            this.toolStripButton19.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton19.Text = "中心放大";
            this.toolStripButton19.Click += new System.EventHandler(this.toolStripButton19_Click);
            // 
            // toolStripButton20
            // 
            this.toolStripButton20.Image = global::绿廊智绘.Properties.Resources.MapBrowser_CenterZoomOut;
            this.toolStripButton20.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton20.Name = "toolStripButton20";
            this.toolStripButton20.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton20.Text = "中心缩小";
            this.toolStripButton20.Click += new System.EventHandler(this.toolStripButton20_Click);
            // 
            // toolStripButton21
            // 
            this.toolStripButton21.Image = global::绿廊智绘.Properties.Resources.MapBrowser_FullExtent;
            this.toolStripButton21.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton21.Name = "toolStripButton21";
            this.toolStripButton21.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton21.Text = "全图显示";
            this.toolStripButton21.Click += new System.EventHandler(this.toolStripButton21_Click);
            // 
            // POImapControl1
            // 
            this.POImapControl1.BackColor = System.Drawing.Color.White;
            this.POImapControl1.CustomerProperty = null;
            this.POImapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.POImapControl1.Location = new System.Drawing.Point(0, 0);
            this.POImapControl1.Name = "POImapControl1";
            this.POImapControl1.Size = new System.Drawing.Size(589, 474);
            this.POImapControl1.TabIndex = 0;
            this.POImapControl1.Text = "第一期POI地图控件";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripButton14});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(589, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.Image = global::绿廊智绘.Properties.Resources.MainCategory_DeleteAllSelect;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton9.Text = "清空图层";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton10.Text = "移动图层";
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.Image = global::绿廊智绘.Properties.Resources.MapBrowser_Pan;
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton11.Text = "漫游";
            this.toolStripButton11.Click += new System.EventHandler(this.toolStripButton11_Click);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.Image = global::绿廊智绘.Properties.Resources.MapBrowser_CenterZoomIn;
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton12.Text = "中心放大";
            this.toolStripButton12.Click += new System.EventHandler(this.toolStripButton12_Click);
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.Image = global::绿廊智绘.Properties.Resources.MapBrowser_CenterZoomOut;
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton13.Text = "中心缩小";
            this.toolStripButton13.Click += new System.EventHandler(this.toolStripButton13_Click);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.Image = global::绿廊智绘.Properties.Resources.MapBrowser_FullExtent;
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton14.Text = "全图显示";
            this.toolStripButton14.Click += new System.EventHandler(this.toolStripButton14_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 22);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1181, 505);
            this.splitContainer1.SplitterDistance = 27;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::绿廊智绘.Properties.Resources.BlockAdjust_NewProj;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(100, 22);
            this.toolStripButton5.Text = "同步添加底图";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1181, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = global::绿廊智绘.Properties.Resources.CartoGraphy_ChangePageLayout;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton8.Text = "重置";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // POI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 775);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.取消);
            this.Controls.Add(this.确定);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "POI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POI变化统计";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox 结果框;
        private System.Windows.Forms.Button 取消;
        private System.Windows.Forms.Button 确定;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button 第二期POI加载按钮;
        private System.Windows.Forms.ComboBox 第二景分类文件框;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button 第一期POI加载按钮;
        private System.Windows.Forms.ComboBox 第一景分类文件框;
        private System.Windows.Forms.GroupBox groupBox4;
        private PIE.AxControls.MapControl mapControl1;
        private PIE.AxControls.MapControl mapControl2;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private PIE.AxControls.MapControl POImapControl1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripButton toolStripButton17;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private System.Windows.Forms.ToolStripButton toolStripButton19;
        private System.Windows.Forms.ToolStripButton toolStripButton20;
        private System.Windows.Forms.ToolStripButton toolStripButton21;
        private PIE.AxControls.MapControl POImapControl2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
    }
}