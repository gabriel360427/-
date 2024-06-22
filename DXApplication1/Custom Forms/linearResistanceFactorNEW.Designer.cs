
namespace 绿廊智绘.Custom_Forms
{
    partial class LinearResistenceFactorNEW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinearResistenceFactorNEW));
            this.矢量数据输入框 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.矢量加载按钮 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.矢量裁剪 = new System.Windows.Forms.GroupBox();
            this.矢量裁剪加载按钮 = new System.Windows.Forms.Button();
            this.裁剪矢量输入框 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.矢量转栅格设置 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.指定大小 = new System.Windows.Forms.TabPage();
            this.Y输入框 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.X输入框 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.基准影像载入按钮 = new System.Windows.Forms.Button();
            this.基准影像输入框 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.取消 = new System.Windows.Forms.Button();
            this.确认 = new System.Windows.Forms.Button();
            this.文件输出类型框 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.文件输出加载 = new System.Windows.Forms.Button();
            this.文件输出框 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.矢量裁剪.SuspendLayout();
            this.矢量转栅格设置.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.指定大小.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // 矢量数据输入框
            // 
            this.矢量数据输入框.FormattingEnabled = true;
            this.矢量数据输入框.Location = new System.Drawing.Point(21, 24);
            this.矢量数据输入框.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.矢量数据输入框.Name = "矢量数据输入框";
            this.矢量数据输入框.Size = new System.Drawing.Size(209, 23);
            this.矢量数据输入框.TabIndex = 0;
            this.矢量数据输入框.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.矢量加载按钮);
            this.groupBox1.Controls.Add(this.矢量数据输入框);
            this.groupBox1.Location = new System.Drawing.Point(31, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(353, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入矢量数据";
            // 
            // 矢量加载按钮
            // 
            this.矢量加载按钮.Location = new System.Drawing.Point(240, 24);
            this.矢量加载按钮.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.矢量加载按钮.Name = "矢量加载按钮";
            this.矢量加载按钮.Size = new System.Drawing.Size(93, 25);
            this.矢量加载按钮.TabIndex = 1;
            this.矢量加载按钮.Text = "加载";
            this.矢量加载按钮.UseVisualStyleBackColor = true;
            this.矢量加载按钮.Click += new System.EventHandler(this.矢量加载按钮_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(31, 89);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(353, 411);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "缓冲区分析";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(5, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(328, 380);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "缓冲区范围（m）";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 105;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "分类级别";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 105;
            // 
            // 矢量裁剪
            // 
            this.矢量裁剪.Controls.Add(this.矢量裁剪加载按钮);
            this.矢量裁剪.Controls.Add(this.裁剪矢量输入框);
            this.矢量裁剪.Controls.Add(this.label1);
            this.矢量裁剪.Location = new System.Drawing.Point(407, 15);
            this.矢量裁剪.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.矢量裁剪.Name = "矢量裁剪";
            this.矢量裁剪.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.矢量裁剪.Size = new System.Drawing.Size(357, 96);
            this.矢量裁剪.TabIndex = 4;
            this.矢量裁剪.TabStop = false;
            this.矢量裁剪.Text = "矢量裁剪";
            // 
            // 矢量裁剪加载按钮
            // 
            this.矢量裁剪加载按钮.Location = new System.Drawing.Point(249, 21);
            this.矢量裁剪加载按钮.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.矢量裁剪加载按钮.Name = "矢量裁剪加载按钮";
            this.矢量裁剪加载按钮.Size = new System.Drawing.Size(97, 28);
            this.矢量裁剪加载按钮.TabIndex = 2;
            this.矢量裁剪加载按钮.Text = "加载";
            this.矢量裁剪加载按钮.UseVisualStyleBackColor = true;
            this.矢量裁剪加载按钮.Click += new System.EventHandler(this.button1_Click);
            // 
            // 裁剪矢量输入框
            // 
            this.裁剪矢量输入框.FormattingEnabled = true;
            this.裁剪矢量输入框.Location = new System.Drawing.Point(12, 59);
            this.裁剪矢量输入框.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.裁剪矢量输入框.Name = "裁剪矢量输入框";
            this.裁剪矢量输入框.Size = new System.Drawing.Size(336, 23);
            this.裁剪矢量输入框.TabIndex = 1;
            this.裁剪矢量输入框.SelectedIndexChanged += new System.EventHandler(this.裁剪矢量输入框_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入裁剪范围的shape文件";
            // 
            // 矢量转栅格设置
            // 
            this.矢量转栅格设置.Controls.Add(this.tabControl1);
            this.矢量转栅格设置.Location = new System.Drawing.Point(408, 120);
            this.矢量转栅格设置.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.矢量转栅格设置.Name = "矢量转栅格设置";
            this.矢量转栅格设置.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.矢量转栅格设置.Size = new System.Drawing.Size(355, 151);
            this.矢量转栅格设置.TabIndex = 5;
            this.矢量转栅格设置.TabStop = false;
            this.矢量转栅格设置.Text = "矢量转栅格设置";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.指定大小);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(335, 106);
            this.tabControl1.TabIndex = 0;
            // 
            // 指定大小
            // 
            this.指定大小.Controls.Add(this.Y输入框);
            this.指定大小.Controls.Add(this.label3);
            this.指定大小.Controls.Add(this.label2);
            this.指定大小.Controls.Add(this.X输入框);
            this.指定大小.Location = new System.Drawing.Point(4, 25);
            this.指定大小.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.指定大小.Name = "指定大小";
            this.指定大小.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.指定大小.Size = new System.Drawing.Size(327, 77);
            this.指定大小.TabIndex = 0;
            this.指定大小.Text = "指定像元大小";
            this.指定大小.UseVisualStyleBackColor = true;
            // 
            // Y输入框
            // 
            this.Y输入框.Location = new System.Drawing.Point(187, 22);
            this.Y输入框.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Y输入框.Name = "Y输入框";
            this.Y输入框.Size = new System.Drawing.Size(111, 25);
            this.Y输入框.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // X输入框
            // 
            this.X输入框.Location = new System.Drawing.Point(44, 22);
            this.X输入框.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.X输入框.Name = "X输入框";
            this.X输入框.Size = new System.Drawing.Size(111, 25);
            this.X输入框.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.基准影像载入按钮);
            this.tabPage2.Controls.Add(this.基准影像输入框);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(327, 77);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "基准影像";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // 基准影像载入按钮
            // 
            this.基准影像载入按钮.Location = new System.Drawing.Point(212, 41);
            this.基准影像载入按钮.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.基准影像载入按钮.Name = "基准影像载入按钮";
            this.基准影像载入按钮.Size = new System.Drawing.Size(97, 28);
            this.基准影像载入按钮.TabIndex = 3;
            this.基准影像载入按钮.Text = "加载";
            this.基准影像载入按钮.UseVisualStyleBackColor = true;
            this.基准影像载入按钮.Click += new System.EventHandler(this.基准影像载入按钮_Click);
            // 
            // 基准影像输入框
            // 
            this.基准影像输入框.FormattingEnabled = true;
            this.基准影像输入框.Location = new System.Drawing.Point(16, 11);
            this.基准影像输入框.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.基准影像输入框.Name = "基准影像输入框";
            this.基准影像输入框.Size = new System.Drawing.Size(292, 23);
            this.基准影像输入框.TabIndex = 0;
            this.基准影像输入框.SelectedIndexChanged += new System.EventHandler(this.基准影像输入框_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.axLicenseControl1);
            this.groupBox3.Controls.Add(this.取消);
            this.groupBox3.Controls.Add(this.确认);
            this.groupBox3.Controls.Add(this.文件输出类型框);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.文件输出加载);
            this.groupBox3.Controls.Add(this.文件输出框);
            this.groupBox3.Location = new System.Drawing.Point(409, 280);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(353, 219);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "请设置文件输出路径";
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(233, 144);
            this.axLicenseControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 8;
            // 
            // 取消
            // 
            this.取消.Location = new System.Drawing.Point(196, 151);
            this.取消.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.取消.Name = "取消";
            this.取消.Size = new System.Drawing.Size(117, 28);
            this.取消.TabIndex = 7;
            this.取消.Text = "取消";
            this.取消.UseVisualStyleBackColor = true;
            this.取消.Click += new System.EventHandler(this.取消_Click);
            // 
            // 确认
            // 
            this.确认.Location = new System.Drawing.Point(39, 151);
            this.确认.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.确认.Name = "确认";
            this.确认.Size = new System.Drawing.Size(117, 28);
            this.确认.TabIndex = 6;
            this.确认.Text = "确认";
            this.确认.UseVisualStyleBackColor = true;
            this.确认.Click += new System.EventHandler(this.确认_Click);
            // 
            // 文件输出类型框
            // 
            this.文件输出类型框.FormattingEnabled = true;
            this.文件输出类型框.Location = new System.Drawing.Point(7, 88);
            this.文件输出类型框.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.文件输出类型框.Name = "文件输出类型框";
            this.文件输出类型框.Size = new System.Drawing.Size(336, 23);
            this.文件输出类型框.TabIndex = 5;
            this.文件输出类型框.SelectedIndexChanged += new System.EventHandler(this.文件输出类型框_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "设置文件输出类型";
            // 
            // 文件输出加载
            // 
            this.文件输出加载.Location = new System.Drawing.Point(229, 25);
            this.文件输出加载.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.文件输出加载.Name = "文件输出加载";
            this.文件输出加载.Size = new System.Drawing.Size(117, 28);
            this.文件输出加载.TabIndex = 3;
            this.文件输出加载.Text = "加载";
            this.文件输出加载.UseVisualStyleBackColor = true;
            this.文件输出加载.Click += new System.EventHandler(this.文件输出加载_Click);
            // 
            // 文件输出框
            // 
            this.文件输出框.FormattingEnabled = true;
            this.文件输出框.Location = new System.Drawing.Point(7, 25);
            this.文件输出框.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.文件输出框.Name = "文件输出框";
            this.文件输出框.Size = new System.Drawing.Size(213, 23);
            this.文件输出框.TabIndex = 2;
            this.文件输出框.SelectedIndexChanged += new System.EventHandler(this.文件输出框_SelectedIndexChanged);
            // 
            // LinearResistenceFactorNEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 522);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.矢量转栅格设置);
            this.Controls.Add(this.矢量裁剪);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LinearResistenceFactorNEW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "阻力面构建";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.矢量裁剪.ResumeLayout(false);
            this.矢量裁剪.PerformLayout();
            this.矢量转栅格设置.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.指定大小.ResumeLayout(false);
            this.指定大小.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox 矢量数据输入框;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button 矢量加载按钮;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox 矢量裁剪;
        private System.Windows.Forms.Button 矢量裁剪加载按钮;
        private System.Windows.Forms.ComboBox 裁剪矢量输入框;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox 矢量转栅格设置;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 指定大小;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox X输入框;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Y输入框;
        private System.Windows.Forms.Button 基准影像载入按钮;
        private System.Windows.Forms.ComboBox 基准影像输入框;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox 文件输出框;
        private System.Windows.Forms.Button 文件输出加载;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox 文件输出类型框;
        private System.Windows.Forms.Button 取消;
        private System.Windows.Forms.Button 确认;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
    }
}