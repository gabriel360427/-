namespace 绿廊智绘.Custom_Forms
{
    partial class vectorToRasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vectorToRasterForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.无效值 = new System.Windows.Forms.TextBox();
            this.是否设置无效值 = new System.Windows.Forms.CheckBox();
            this.选择字段 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputFile1 = new System.Windows.Forms.Button();
            this.矢量文件输入框 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Y = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.InputFile2 = new System.Windows.Forms.Button();
            this.基准影像输入框 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.OutputFile = new System.Windows.Forms.Button();
            this.栅格输出框 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.无效值);
            this.groupBox1.Controls.Add(this.是否设置无效值);
            this.groupBox1.Controls.Add(this.选择字段);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.InputFile1);
            this.groupBox1.Controls.Add(this.矢量文件输入框);
            this.groupBox1.Font = new System.Drawing.Font("等线", 12F);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(613, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请输入矢量文件";
            // 
            // 无效值
            // 
            this.无效值.Location = new System.Drawing.Point(466, 58);
            this.无效值.Margin = new System.Windows.Forms.Padding(2);
            this.无效值.Name = "无效值";
            this.无效值.Size = new System.Drawing.Size(100, 24);
            this.无效值.TabIndex = 5;
            // 
            // 是否设置无效值
            // 
            this.是否设置无效值.AutoSize = true;
            this.是否设置无效值.Location = new System.Drawing.Point(332, 59);
            this.是否设置无效值.Margin = new System.Windows.Forms.Padding(2);
            this.是否设置无效值.Name = "是否设置无效值";
            this.是否设置无效值.Size = new System.Drawing.Size(111, 21);
            this.是否设置无效值.TabIndex = 4;
            this.是否设置无效值.Text = "设置无效值:";
            this.是否设置无效值.UseVisualStyleBackColor = true;
            this.是否设置无效值.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // 选择字段
            // 
            this.选择字段.FormattingEnabled = true;
            this.选择字段.Location = new System.Drawing.Point(130, 58);
            this.选择字段.Margin = new System.Windows.Forms.Padding(2);
            this.选择字段.Name = "选择字段";
            this.选择字段.Size = new System.Drawing.Size(140, 25);
            this.选择字段.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "请选择字段:";
            // 
            // InputFile1
            // 
            this.InputFile1.Font = new System.Drawing.Font("等线", 12F);
            this.InputFile1.Location = new System.Drawing.Point(509, 18);
            this.InputFile1.Margin = new System.Windows.Forms.Padding(2);
            this.InputFile1.Name = "InputFile1";
            this.InputFile1.Size = new System.Drawing.Size(88, 30);
            this.InputFile1.TabIndex = 1;
            this.InputFile1.Text = "加载";
            this.InputFile1.UseVisualStyleBackColor = true;
            this.InputFile1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 矢量文件输入框
            // 
            this.矢量文件输入框.FormattingEnabled = true;
            this.矢量文件输入框.Location = new System.Drawing.Point(5, 23);
            this.矢量文件输入框.Margin = new System.Windows.Forms.Padding(2);
            this.矢量文件输入框.Name = "矢量文件输入框";
            this.矢量文件输入框.Size = new System.Drawing.Size(490, 25);
            this.矢量文件输入框.TabIndex = 0;
            this.矢量文件输入框.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Font = new System.Drawing.Font("等线", 12F);
            this.groupBox2.Location = new System.Drawing.Point(9, 107);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(613, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参数类型";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 22);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(602, 95);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Y);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.X);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(594, 65);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "指定大小";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(354, 24);
            this.Y.Margin = new System.Windows.Forms.Padding(2);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(130, 24);
            this.Y.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y（列数）";
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(98, 24);
            this.X.Margin = new System.Windows.Forms.Padding(2);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(129, 24);
            this.X.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "X（行数）";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.InputFile2);
            this.tabPage2.Controls.Add(this.基准影像输入框);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(594, 66);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "基准影像";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // InputFile2
            // 
            this.InputFile2.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputFile2.Location = new System.Drawing.Point(498, 19);
            this.InputFile2.Margin = new System.Windows.Forms.Padding(2);
            this.InputFile2.Name = "InputFile2";
            this.InputFile2.Size = new System.Drawing.Size(88, 30);
            this.InputFile2.TabIndex = 3;
            this.InputFile2.Text = "加载";
            this.InputFile2.UseVisualStyleBackColor = true;
            this.InputFile2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 基准影像输入框
            // 
            this.基准影像输入框.Location = new System.Drawing.Point(108, 24);
            this.基准影像输入框.Margin = new System.Windows.Forms.Padding(2);
            this.基准影像输入框.Name = "基准影像输入框";
            this.基准影像输入框.Size = new System.Drawing.Size(376, 24);
            this.基准影像输入框.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "基准影像:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Cancel);
            this.groupBox3.Controls.Add(this.OK);
            this.groupBox3.Controls.Add(this.OutputFile);
            this.groupBox3.Controls.Add(this.栅格输出框);
            this.groupBox3.Font = new System.Drawing.Font("等线", 12F);
            this.groupBox3.Location = new System.Drawing.Point(10, 240);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(612, 145);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "请设置栅格输出路径";
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("等线", 12F);
            this.Cancel.Location = new System.Drawing.Point(406, 72);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 30);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button5_Click);
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("等线", 12F);
            this.OK.Location = new System.Drawing.Point(11, 72);
            this.OK.Margin = new System.Windows.Forms.Padding(2);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(88, 30);
            this.OK.TabIndex = 3;
            this.OK.Text = "确认";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button4_Click);
            // 
            // OutputFile
            // 
            this.OutputFile.Font = new System.Drawing.Font("等线", 12F);
            this.OutputFile.Location = new System.Drawing.Point(508, 19);
            this.OutputFile.Margin = new System.Windows.Forms.Padding(2);
            this.OutputFile.Name = "OutputFile";
            this.OutputFile.Size = new System.Drawing.Size(88, 30);
            this.OutputFile.TabIndex = 2;
            this.OutputFile.Text = "加载";
            this.OutputFile.UseVisualStyleBackColor = true;
            this.OutputFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // 栅格输出框
            // 
            this.栅格输出框.Location = new System.Drawing.Point(11, 23);
            this.栅格输出框.Margin = new System.Windows.Forms.Padding(2);
            this.栅格输出框.Name = "栅格输出框";
            this.栅格输出框.Size = new System.Drawing.Size(483, 24);
            this.栅格输出框.TabIndex = 0;
            // 
            // vectorToRasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 394);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "vectorToRasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "矢量转栅格";
            this.Load += new System.EventHandler(this.矢量转栅格_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox 无效值;
        private System.Windows.Forms.CheckBox 是否设置无效值;
        private System.Windows.Forms.ComboBox 选择字段;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InputFile1;
        private System.Windows.Forms.ComboBox 矢量文件输入框;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button InputFile2;
        private System.Windows.Forms.TextBox 基准影像输入框;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button OutputFile;
        private System.Windows.Forms.TextBox 栅格输出框;
    }
}