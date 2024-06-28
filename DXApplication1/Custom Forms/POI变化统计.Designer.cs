
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.mapControl3 = new PIE.AxControls.MapControl();
            this.mapControl4 = new PIE.AxControls.MapControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
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
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.mapControl3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.mapControl4);
            this.splitContainer2.Size = new System.Drawing.Size(1181, 474);
            this.splitContainer2.SplitterDistance = 589;
            this.splitContainer2.TabIndex = 0;
            // 
            // mapControl3
            // 
            this.mapControl3.BackColor = System.Drawing.Color.White;
            this.mapControl3.CustomerProperty = null;
            this.mapControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl3.Location = new System.Drawing.Point(0, 0);
            this.mapControl3.Name = "mapControl3";
            this.mapControl3.Size = new System.Drawing.Size(589, 474);
            this.mapControl3.TabIndex = 0;
            this.mapControl3.Text = "mapControl3";
            // 
            // mapControl4
            // 
            this.mapControl4.BackColor = System.Drawing.Color.White;
            this.mapControl4.CustomerProperty = null;
            this.mapControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl4.Location = new System.Drawing.Point(0, 0);
            this.mapControl4.Name = "mapControl4";
            this.mapControl4.Size = new System.Drawing.Size(588, 474);
            this.mapControl4.TabIndex = 0;
            this.mapControl4.Text = "mapControl4";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1181, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::绿廊智绘.Properties.Resources.MapBrowser_Pan;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "漫游";
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
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::绿廊智绘.Properties.Resources.MapBrowser_CenterZoomIn;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton2.Text = "中心放大";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::绿廊智绘.Properties.Resources.MapBrowser_CenterZoomOut;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton3.Text = "中心缩小";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::绿廊智绘.Properties.Resources.MapBrowser_FullExtent;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton4.Text = "全图显示";
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private PIE.AxControls.MapControl mapControl3;
        private PIE.AxControls.MapControl mapControl4;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}