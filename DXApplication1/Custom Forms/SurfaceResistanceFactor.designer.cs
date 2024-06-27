namespace 绿廊智绘.Custom_Forms
{
    partial class SurfaceResistanceFactor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SurfaceResistanceFactor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InputFile = new System.Windows.Forms.Button();
            this.栅格数据输入框 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.输出数据类型 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.OutputFile = new System.Windows.Forms.Button();
            this.文件输出框 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InputFile);
            this.groupBox1.Controls.Add(this.栅格数据输入框);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请输入栅格数据";
            // 
            // InputFile
            // 
            this.InputFile.Location = new System.Drawing.Point(511, 15);
            this.InputFile.Name = "InputFile";
            this.InputFile.Size = new System.Drawing.Size(119, 57);
            this.InputFile.TabIndex = 1;
            this.InputFile.Text = "加载";
            this.InputFile.UseVisualStyleBackColor = true;
            this.InputFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // 栅格数据输入框
            // 
            this.栅格数据输入框.FormattingEnabled = true;
            this.栅格数据输入框.Location = new System.Drawing.Point(7, 29);
            this.栅格数据输入框.Name = "栅格数据输入框";
            this.栅格数据输入框.Size = new System.Drawing.Size(489, 22);
            this.栅格数据输入框.TabIndex = 0;
            this.栅格数据输入框.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 436);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "阻力值计算";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(7, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(347, 398);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "范围（m）";
            this.Column1.Name = "Column1";
            this.Column1.Width = 105;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "分类级别";
            this.Column2.Name = "Column2";
            this.Column2.Width = 105;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.输出数据类型);
            this.groupBox3.Location = new System.Drawing.Point(379, 428);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "请选择输出数据类型";
            // 
            // 输出数据类型
            // 
            this.输出数据类型.FormattingEnabled = true;
            this.输出数据类型.Items.AddRange(new object[] {
            "字节型(8位)",
            "无符号整型(16位)",
            "整型(16位)",
            "无符号长整型(32位)",
            "长整型(32位)",
            "浮点型(32位)",
            "双精度浮点型(64位)"});
            this.输出数据类型.Location = new System.Drawing.Point(7, 37);
            this.输出数据类型.Name = "输出数据类型";
            this.输出数据类型.Size = new System.Drawing.Size(257, 22);
            this.输出数据类型.TabIndex = 0;
            this.输出数据类型.SelectedIndexChanged += new System.EventHandler(this.输出数据类型_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Cancel);
            this.groupBox4.Controls.Add(this.OK);
            this.groupBox4.Controls.Add(this.OutputFile);
            this.groupBox4.Controls.Add(this.文件输出框);
            this.groupBox4.Location = new System.Drawing.Point(19, 534);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(653, 125);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "请设置输出文件路径";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(365, 62);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(119, 57);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button4_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(133, 62);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(119, 57);
            this.OK.TabIndex = 3;
            this.OK.Text = "确认";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button3_Click);
            // 
            // OutputFile
            // 
            this.OutputFile.Location = new System.Drawing.Point(511, 14);
            this.OutputFile.Name = "OutputFile";
            this.OutputFile.Size = new System.Drawing.Size(119, 57);
            this.OutputFile.TabIndex = 2;
            this.OutputFile.Text = "加载";
            this.OutputFile.UseVisualStyleBackColor = true;
            this.OutputFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // 文件输出框
            // 
            this.文件输出框.FormattingEnabled = true;
            this.文件输出框.Location = new System.Drawing.Point(7, 28);
            this.文件输出框.Name = "文件输出框";
            this.文件输出框.Size = new System.Drawing.Size(489, 22);
            this.文件输出框.TabIndex = 1;
            this.文件输出框.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(386, 110);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(280, 312);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "    ★☆★示例说明\n（此窗口暂无说明）";
            // 
            // SurfaceResistanceFactor
            // 
            this.AccessibleName = "";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(678, 669);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SurfaceResistanceFactor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "阻力因子";
            this.Load += new System.EventHandler(this.高程因子_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button InputFile;
        private System.Windows.Forms.ComboBox 栅格数据输入框;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox 输出数据类型;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button OutputFile;
        private System.Windows.Forms.ComboBox 文件输出框;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}