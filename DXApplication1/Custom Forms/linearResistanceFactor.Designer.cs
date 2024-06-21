namespace 绿廊智绘.Custom_Commands
{
    partial class linearResistanceFactor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(linearResistanceFactor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InputFile1 = new System.Windows.Forms.Button();
            this.矢量数据输入框 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.末端类型 = new System.Windows.Forms.ComboBox();
            this.融合类型 = new System.Windows.Forms.ComboBox();
            this.侧类型 = new System.Windows.Forms.ComboBox();
            this.是否添加矢量字段 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Y = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.InputFile2 = new System.Windows.Forms.Button();
            this.基准影像输入框 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.InputFile3 = new System.Windows.Forms.Button();
            this.裁剪矢量文件输入框 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Y2 = new System.Windows.Forms.TextBox();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.X2 = new System.Windows.Forms.TextBox();
            this.X1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.OutputFile = new System.Windows.Forms.Button();
            this.输出文件数据类型 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.文件输出框 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InputFile1);
            this.groupBox1.Controls.Add(this.矢量数据输入框);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请输入矢量数据";
            // 
            // InputFile1
            // 
            this.InputFile1.Location = new System.Drawing.Point(509, 19);
            this.InputFile1.Name = "InputFile1";
            this.InputFile1.Size = new System.Drawing.Size(117, 57);
            this.InputFile1.TabIndex = 1;
            this.InputFile1.Text = "加载";
            this.InputFile1.UseVisualStyleBackColor = true;
            this.InputFile1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 矢量数据输入框
            // 
            this.矢量数据输入框.FormattingEnabled = true;
            this.矢量数据输入框.Location = new System.Drawing.Point(7, 29);
            this.矢量数据输入框.Name = "矢量数据输入框";
            this.矢量数据输入框.Size = new System.Drawing.Size(480, 30);
            this.矢量数据输入框.TabIndex = 0;
            this.矢量数据输入框.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(7, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(343, 477);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "缓冲区范围（m）";
            this.Column1.Name = "Column1";
            this.Column1.Width = 105;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "分类级别";
            this.Column2.Name = "Column2";
            this.Column2.Width = 105;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 517);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "缓冲区分析";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.末端类型);
            this.groupBox3.Controls.Add(this.融合类型);
            this.groupBox3.Controls.Add(this.侧类型);
            this.groupBox3.Controls.Add(this.是否添加矢量字段);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(375, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 185);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "缓冲区参数设置";
            // 
            // 末端类型
            // 
            this.末端类型.FormattingEnabled = true;
            this.末端类型.Items.AddRange(new object[] {
            "圆滑型",
            "扁平型"});
            this.末端类型.Location = new System.Drawing.Point(100, 105);
            this.末端类型.Name = "末端类型";
            this.末端类型.Size = new System.Drawing.Size(185, 30);
            this.末端类型.TabIndex = 6;
            // 
            // 融合类型
            // 
            this.融合类型.FormattingEnabled = true;
            this.融合类型.Items.AddRange(new object[] {
            "无融合",
            "全融合"});
            this.融合类型.Location = new System.Drawing.Point(100, 61);
            this.融合类型.Name = "融合类型";
            this.融合类型.Size = new System.Drawing.Size(185, 30);
            this.融合类型.TabIndex = 5;
            // 
            // 侧类型
            // 
            this.侧类型.FormattingEnabled = true;
            this.侧类型.Items.AddRange(new object[] {
            "两侧",
            "左侧",
            "右侧"});
            this.侧类型.Location = new System.Drawing.Point(100, 24);
            this.侧类型.Name = "侧类型";
            this.侧类型.Size = new System.Drawing.Size(185, 30);
            this.侧类型.TabIndex = 4;
            // 
            // 是否添加矢量字段
            // 
            this.是否添加矢量字段.AutoSize = true;
            this.是否添加矢量字段.Location = new System.Drawing.Point(11, 153);
            this.是否添加矢量字段.Name = "是否添加矢量字段";
            this.是否添加矢量字段.Size = new System.Drawing.Size(180, 26);
            this.是否添加矢量字段.TabIndex = 3;
            this.是否添加矢量字段.Text = "是否添加矢量字段";
            this.是否添加矢量字段.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "末端类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "融合类型";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "侧类型";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tabControl1);
            this.groupBox4.Location = new System.Drawing.Point(375, 297);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(291, 136);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "矢量转栅格";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(274, 100);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Y);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.X);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(266, 65);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "指定大小";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(166, 18);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(94, 29);
            this.Y.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Y";
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(32, 18);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(102, 29);
            this.X.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "X";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.InputFile2);
            this.tabPage2.Controls.Add(this.基准影像输入框);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(266, 65);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "基准影像";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // InputFile2
            // 
            this.InputFile2.Location = new System.Drawing.Point(185, 13);
            this.InputFile2.Name = "InputFile2";
            this.InputFile2.Size = new System.Drawing.Size(75, 41);
            this.InputFile2.TabIndex = 1;
            this.InputFile2.Text = "加载";
            this.InputFile2.UseVisualStyleBackColor = true;
            this.InputFile2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 基准影像输入框
            // 
            this.基准影像输入框.Location = new System.Drawing.Point(9, 19);
            this.基准影像输入框.Name = "基准影像输入框";
            this.基准影像输入框.Size = new System.Drawing.Size(167, 29);
            this.基准影像输入框.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tabControl2);
            this.groupBox5.Location = new System.Drawing.Point(375, 440);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(291, 181);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "影像裁剪";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(7, 29);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(278, 140);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.InputFile3);
            this.tabPage3.Controls.Add(this.裁剪矢量文件输入框);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(270, 105);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "矢量裁剪";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // InputFile3
            // 
            this.InputFile3.Location = new System.Drawing.Point(171, 25);
            this.InputFile3.Name = "InputFile3";
            this.InputFile3.Size = new System.Drawing.Size(93, 51);
            this.InputFile3.TabIndex = 1;
            this.InputFile3.Text = "加载";
            this.InputFile3.UseVisualStyleBackColor = true;
            this.InputFile3.Click += new System.EventHandler(this.button3_Click);
            // 
            // 裁剪矢量文件输入框
            // 
            this.裁剪矢量文件输入框.Location = new System.Drawing.Point(7, 36);
            this.裁剪矢量文件输入框.Name = "裁剪矢量文件输入框";
            this.裁剪矢量文件输入框.Size = new System.Drawing.Size(157, 29);
            this.裁剪矢量文件输入框.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Y2);
            this.tabPage4.Controls.Add(this.Y1);
            this.tabPage4.Controls.Add(this.X2);
            this.tabPage4.Controls.Add(this.X1);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(270, 105);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "范围裁剪";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Y2
            // 
            this.Y2.Location = new System.Drawing.Point(170, 68);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(78, 29);
            this.Y2.TabIndex = 7;
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(44, 68);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(78, 29);
            this.Y1.TabIndex = 6;
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(170, 33);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(78, 29);
            this.X2.TabIndex = 5;
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(44, 33);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(78, 29);
            this.X1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "终止坐标";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "起始坐标";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "X";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Cancel);
            this.groupBox6.Controls.Add(this.OK);
            this.groupBox6.Controls.Add(this.OutputFile);
            this.groupBox6.Controls.Add(this.输出文件数据类型);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.文件输出框);
            this.groupBox6.Location = new System.Drawing.Point(13, 616);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(653, 166);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "请设置输出文件路径";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(377, 120);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(117, 40);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button6_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(130, 120);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(117, 40);
            this.OK.TabIndex = 6;
            this.OK.Text = "确认";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button5_Click);
            // 
            // OutputFile
            // 
            this.OutputFile.Location = new System.Drawing.Point(508, 14);
            this.OutputFile.Name = "OutputFile";
            this.OutputFile.Size = new System.Drawing.Size(117, 57);
            this.OutputFile.TabIndex = 5;
            this.OutputFile.Text = "加载";
            this.OutputFile.UseVisualStyleBackColor = true;
            this.OutputFile.Click += new System.EventHandler(this.button4_Click);
            // 
            // 输出文件数据类型
            // 
            this.输出文件数据类型.FormattingEnabled = true;
            this.输出文件数据类型.Items.AddRange(new object[] {
            "字节型(8位)",
            "无符号整型(16位)",
            "整型(16位)",
            "无符号长整型(32位)",
            "长整型(32位)",
            "浮点型(32位)",
            "双精度浮点型(64位)"});
            this.输出文件数据类型.Location = new System.Drawing.Point(130, 75);
            this.输出文件数据类型.Name = "输出文件数据类型";
            this.输出文件数据类型.Size = new System.Drawing.Size(495, 30);
            this.输出文件数据类型.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 22);
            this.label10.TabIndex = 3;
            this.label10.Text = "输出数据类型";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // 文件输出框
            // 
            this.文件输出框.FormattingEnabled = true;
            this.文件输出框.Location = new System.Drawing.Point(6, 28);
            this.文件输出框.Name = "文件输出框";
            this.文件输出框.Size = new System.Drawing.Size(480, 30);
            this.文件输出框.TabIndex = 1;
            this.文件输出框.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // 阻力因子B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 794);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "阻力因子B";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "阻力因子";
            this.Load += new System.EventHandler(this.铁路因子_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button InputFile1;
        private System.Windows.Forms.ComboBox 矢量数据输入框;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox 末端类型;
        private System.Windows.Forms.ComboBox 融合类型;
        private System.Windows.Forms.ComboBox 侧类型;
        private System.Windows.Forms.CheckBox 是否添加矢量字段;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button InputFile2;
        private System.Windows.Forms.TextBox 基准影像输入框;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button InputFile3;
        private System.Windows.Forms.TextBox 裁剪矢量文件输入框;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox Y2;
        private System.Windows.Forms.TextBox Y1;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox 输出文件数据类型;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox 文件输出框;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button OutputFile;
    }
}