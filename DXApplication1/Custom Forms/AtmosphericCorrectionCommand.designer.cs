namespace 城市空间生态格局智能评估系统.Custom_Forms
{
    partial class AtmosphericCorrectionCommand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtmosphericCorrectionCommand));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.OutputFile = new System.Windows.Forms.Button();
            this.输出文件框 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.是否反演气溶胶 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.初始能见度 = new System.Windows.Forms.TextBox();
            this.气溶胶类型 = new System.Windows.Forms.ComboBox();
            this.大气模式 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ApparentReflectance = new System.Windows.Forms.RadioButton();
            this.ApparentRadiance = new System.Windows.Forms.RadioButton();
            this.DNValue = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.InputXML = new System.Windows.Forms.Button();
            this.InputFile = new System.Windows.Forms.Button();
            this.元数据文件 = new System.Windows.Forms.ComboBox();
            this.文件输入框 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.OK);
            this.panel1.Controls.Add(this.OutputFile);
            this.panel1.Controls.Add(this.输出文件框);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 445);
            this.panel1.TabIndex = 0;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(390, 404);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(66, 32);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button5_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(134, 404);
            this.OK.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(66, 32);
            this.OK.TabIndex = 6;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button4_Click);
            // 
            // OutputFile
            // 
            this.OutputFile.Location = new System.Drawing.Point(478, 367);
            this.OutputFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OutputFile.Name = "OutputFile";
            this.OutputFile.Size = new System.Drawing.Size(66, 23);
            this.OutputFile.TabIndex = 5;
            this.OutputFile.Text = "加载";
            this.OutputFile.UseVisualStyleBackColor = true;
            this.OutputFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // 输出文件框
            // 
            this.输出文件框.FormattingEnabled = true;
            this.输出文件框.Location = new System.Drawing.Point(134, 367);
            this.输出文件框.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.输出文件框.Name = "输出文件框";
            this.输出文件框.Size = new System.Drawing.Size(323, 26);
            this.输出文件框.TabIndex = 4;
            this.输出文件框.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 367);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "输出文件";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.是否反演气溶胶);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.初始能见度);
            this.groupBox2.Controls.Add(this.气溶胶类型);
            this.groupBox2.Controls.Add(this.大气模式);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(38, 213);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(528, 147);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参数设置";
            // 
            // 是否反演气溶胶
            // 
            this.是否反演气溶胶.FormattingEnabled = true;
            this.是否反演气溶胶.Items.AddRange(new object[] {
            "是",
            "否"});
            this.是否反演气溶胶.Location = new System.Drawing.Point(440, 111);
            this.是否反演气溶胶.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.是否反演气溶胶.Name = "是否反演气溶胶";
            this.是否反演气溶胶.Size = new System.Drawing.Size(67, 26);
            this.是否反演气溶胶.TabIndex = 8;
            this.是否反演气溶胶.Text = "否";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "逐像元反演气溶胶";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "KM";
            // 
            // 初始能见度
            // 
            this.初始能见度.Location = new System.Drawing.Point(97, 111);
            this.初始能见度.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.初始能见度.Name = "初始能见度";
            this.初始能见度.Size = new System.Drawing.Size(90, 26);
            this.初始能见度.TabIndex = 5;
            this.初始能见度.Text = "40.0";
            // 
            // 气溶胶类型
            // 
            this.气溶胶类型.FormattingEnabled = true;
            this.气溶胶类型.Items.AddRange(new object[] {
            "大陆型气溶胶",
            "海洋型气溶胶",
            "城市型气溶胶",
            "沙尘型气溶胶",
            "煤烟型气溶胶",
            "平流层型气溶胶"});
            this.气溶胶类型.Location = new System.Drawing.Point(97, 72);
            this.气溶胶类型.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.气溶胶类型.Name = "气溶胶类型";
            this.气溶胶类型.Size = new System.Drawing.Size(323, 26);
            this.气溶胶类型.TabIndex = 4;
            this.气溶胶类型.Text = "大陆型气溶胶";
            // 
            // 大气模式
            // 
            this.大气模式.FormattingEnabled = true;
            this.大气模式.Items.AddRange(new object[] {
            "系统自动选择大气模式",
            "热带大气模式",
            "中纬度夏季大气模式",
            "中纬度冬季大气模式",
            "副极地夏季大气模式",
            "副极地冬季大气模式",
            "美国1962大气模式"});
            this.大气模式.Location = new System.Drawing.Point(97, 28);
            this.大气模式.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.大气模式.Name = "大气模式";
            this.大气模式.Size = new System.Drawing.Size(323, 26);
            this.大气模式.TabIndex = 3;
            this.大气模式.Text = "系统自动选择大气模式";
            this.大气模式.SelectedIndexChanged += new System.EventHandler(this.大气模式_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "初始能见度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "气溶胶类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "大气模式";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ApparentReflectance);
            this.groupBox1.Controls.Add(this.ApparentRadiance);
            this.groupBox1.Controls.Add(this.DNValue);
            this.groupBox1.Location = new System.Drawing.Point(38, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(528, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据类型";
            // 
            // ApparentReflectance
            // 
            this.ApparentReflectance.AutoSize = true;
            this.ApparentReflectance.Location = new System.Drawing.Point(398, 27);
            this.ApparentReflectance.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ApparentReflectance.Name = "ApparentReflectance";
            this.ApparentReflectance.Size = new System.Drawing.Size(104, 22);
            this.ApparentReflectance.TabIndex = 2;
            this.ApparentReflectance.TabStop = true;
            this.ApparentReflectance.Text = "表观反射率";
            this.ApparentReflectance.UseVisualStyleBackColor = true;
            // 
            // ApparentRadiance
            // 
            this.ApparentRadiance.AutoSize = true;
            this.ApparentRadiance.Location = new System.Drawing.Point(193, 27);
            this.ApparentRadiance.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ApparentRadiance.Name = "ApparentRadiance";
            this.ApparentRadiance.Size = new System.Drawing.Size(104, 22);
            this.ApparentRadiance.TabIndex = 1;
            this.ApparentRadiance.TabStop = true;
            this.ApparentRadiance.Text = "表观辐亮度";
            this.ApparentRadiance.UseVisualStyleBackColor = true;
            // 
            // DNValue
            // 
            this.DNValue.AutoSize = true;
            this.DNValue.Location = new System.Drawing.Point(6, 27);
            this.DNValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DNValue.Name = "DNValue";
            this.DNValue.Size = new System.Drawing.Size(64, 22);
            this.DNValue.TabIndex = 0;
            this.DNValue.TabStop = true;
            this.DNValue.Text = "DN值";
            this.DNValue.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.InputXML);
            this.groupBox3.Controls.Add(this.InputFile);
            this.groupBox3.Controls.Add(this.元数据文件);
            this.groupBox3.Controls.Add(this.文件输入框);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(11, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(581, 183);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "输入信息";
            // 
            // InputXML
            // 
            this.InputXML.Location = new System.Drawing.Point(466, 148);
            this.InputXML.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.InputXML.Name = "InputXML";
            this.InputXML.Size = new System.Drawing.Size(66, 23);
            this.InputXML.TabIndex = 5;
            this.InputXML.Text = "加载";
            this.InputXML.UseVisualStyleBackColor = true;
            this.InputXML.Click += new System.EventHandler(this.button2_Click);
            // 
            // InputFile
            // 
            this.InputFile.Location = new System.Drawing.Point(466, 111);
            this.InputFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.InputFile.Name = "InputFile";
            this.InputFile.Size = new System.Drawing.Size(66, 23);
            this.InputFile.TabIndex = 4;
            this.InputFile.Text = "加载";
            this.InputFile.UseVisualStyleBackColor = true;
            this.InputFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // 元数据文件
            // 
            this.元数据文件.FormattingEnabled = true;
            this.元数据文件.Location = new System.Drawing.Point(122, 148);
            this.元数据文件.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.元数据文件.Name = "元数据文件";
            this.元数据文件.Size = new System.Drawing.Size(323, 26);
            this.元数据文件.TabIndex = 3;
            this.元数据文件.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // 文件输入框
            // 
            this.文件输入框.FormattingEnabled = true;
            this.文件输入框.Location = new System.Drawing.Point(122, 108);
            this.文件输入框.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.文件输入框.Name = "文件输入框";
            this.文件输入框.Size = new System.Drawing.Size(323, 26);
            this.文件输入框.TabIndex = 2;
            this.文件输入框.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "元数据文件";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入文件";
            // 
            // 大气校正
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 445);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "大气校正";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "大气校正";
            this.Load += new System.EventHandler(this.大气校正_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button OutputFile;
        private System.Windows.Forms.ComboBox 输出文件框;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox 是否反演气溶胶;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox 初始能见度;
        private System.Windows.Forms.ComboBox 气溶胶类型;
        private System.Windows.Forms.ComboBox 大气模式;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ApparentReflectance;
        private System.Windows.Forms.RadioButton ApparentRadiance;
        private System.Windows.Forms.RadioButton DNValue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button InputXML;
        private System.Windows.Forms.Button InputFile;
        private System.Windows.Forms.ComboBox 元数据文件;
        private System.Windows.Forms.ComboBox 文件输入框;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}