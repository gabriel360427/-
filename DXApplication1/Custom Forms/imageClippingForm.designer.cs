namespace 绿廊智绘.Custom_Forms
{
    partial class imageClippingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(imageClippingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.文件输入框 = new System.Windows.Forms.ComboBox();
            this.InputFile1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InputFile2 = new System.Windows.Forms.Button();
            this.矢量文件输入框 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.文件输出框 = new System.Windows.Forms.ComboBox();
            this.OutputFile = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入文件";
            // 
            // 文件输入框
            // 
            this.文件输入框.FormattingEnabled = true;
            this.文件输入框.Location = new System.Drawing.Point(132, 22);
            this.文件输入框.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.文件输入框.Name = "文件输入框";
            this.文件输入框.Size = new System.Drawing.Size(470, 30);
            this.文件输入框.TabIndex = 1;
            this.文件输入框.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // InputFile1
            // 
            this.InputFile1.Location = new System.Drawing.Point(627, 17);
            this.InputFile1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputFile1.Name = "InputFile1";
            this.InputFile1.Size = new System.Drawing.Size(113, 39);
            this.InputFile1.TabIndex = 2;
            this.InputFile1.Text = "加载";
            this.InputFile1.UseVisualStyleBackColor = true;
            this.InputFile1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InputFile2);
            this.groupBox1.Controls.Add(this.矢量文件输入框);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 104);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(723, 260);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "矢量裁剪";
            // 
            // InputFile2
            // 
            this.InputFile2.Location = new System.Drawing.Point(203, 171);
            this.InputFile2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputFile2.Name = "InputFile2";
            this.InputFile2.Size = new System.Drawing.Size(253, 51);
            this.InputFile2.TabIndex = 2;
            this.InputFile2.Text = "加载";
            this.InputFile2.UseVisualStyleBackColor = true;
            this.InputFile2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 矢量文件输入框
            // 
            this.矢量文件输入框.FormattingEnabled = true;
            this.矢量文件输入框.Location = new System.Drawing.Point(78, 106);
            this.矢量文件输入框.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.矢量文件输入框.Name = "矢量文件输入框";
            this.矢量文件输入框.Size = new System.Drawing.Size(548, 30);
            this.矢量文件输入框.TabIndex = 1;
            this.矢量文件输入框.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "请输入矢量文件";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "输出文件";
            // 
            // 文件输出框
            // 
            this.文件输出框.FormattingEnabled = true;
            this.文件输出框.Location = new System.Drawing.Point(132, 403);
            this.文件输出框.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.文件输出框.Name = "文件输出框";
            this.文件输出框.Size = new System.Drawing.Size(470, 30);
            this.文件输出框.TabIndex = 5;
            this.文件输出框.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // OutputFile
            // 
            this.OutputFile.Location = new System.Drawing.Point(627, 398);
            this.OutputFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutputFile.Name = "OutputFile";
            this.OutputFile.Size = new System.Drawing.Size(113, 39);
            this.OutputFile.TabIndex = 6;
            this.OutputFile.Text = "加载";
            this.OutputFile.UseVisualStyleBackColor = true;
            this.OutputFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(170, 472);
            this.OK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(113, 39);
            this.OK.TabIndex = 7;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button4_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(429, 472);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(113, 39);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button5_Click);
            // 
            // 影像裁剪
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 543);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.OutputFile);
            this.Controls.Add(this.文件输出框);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InputFile1);
            this.Controls.Add(this.文件输入框);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "影像裁剪";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "影像裁剪";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox 文件输入框;
        private System.Windows.Forms.Button InputFile1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button InputFile2;
        private System.Windows.Forms.ComboBox 矢量文件输入框;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox 文件输出框;
        private System.Windows.Forms.Button OutputFile;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
    }
}