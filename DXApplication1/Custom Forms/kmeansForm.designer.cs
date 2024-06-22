namespace 绿廊智绘.Custom_Forms
{
    partial class kmeansForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kmeansForm));
            this.label1 = new System.Windows.Forms.Label();
            this.inputImageTextBox = new System.Windows.Forms.TextBox();
            this.inputImageBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearBandsBtn = new System.Windows.Forms.Button();
            this.bandNumLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bandNumListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.thresholdControl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maxLoopControl = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.classNumControl = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.outputImageTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.outputImageBtn = new System.Windows.Forms.Button();
            this.formConfirm = new System.Windows.Forms.Button();
            this.formCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxLoopControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classNumControl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入文件：";
            // 
            // inputImageTextBox
            // 
            this.inputImageTextBox.Location = new System.Drawing.Point(91, 23);
            this.inputImageTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputImageTextBox.Name = "inputImageTextBox";
            this.inputImageTextBox.Size = new System.Drawing.Size(317, 22);
            this.inputImageTextBox.TabIndex = 1;
            // 
            // inputImageBtn
            // 
            this.inputImageBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputImageBtn.Location = new System.Drawing.Point(411, 14);
            this.inputImageBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputImageBtn.Name = "inputImageBtn";
            this.inputImageBtn.Size = new System.Drawing.Size(79, 37);
            this.inputImageBtn.TabIndex = 2;
            this.inputImageBtn.Text = "浏览";
            this.inputImageBtn.UseVisualStyleBackColor = true;
            this.inputImageBtn.Click += new System.EventHandler(this.inputImageBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearBandsBtn);
            this.groupBox1.Controls.Add(this.bandNumLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bandNumListBox);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(9, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(252, 282);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "波段选择";
            // 
            // clearBandsBtn
            // 
            this.clearBandsBtn.Location = new System.Drawing.Point(152, 245);
            this.clearBandsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearBandsBtn.Name = "clearBandsBtn";
            this.clearBandsBtn.Size = new System.Drawing.Size(96, 26);
            this.clearBandsBtn.TabIndex = 3;
            this.clearBandsBtn.Text = "清空";
            this.clearBandsBtn.UseVisualStyleBackColor = true;
            this.clearBandsBtn.Click += new System.EventHandler(this.clearBandsBtn_Click);
            // 
            // bandNumLabel
            // 
            this.bandNumLabel.AutoSize = true;
            this.bandNumLabel.Location = new System.Drawing.Point(121, 252);
            this.bandNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bandNumLabel.Name = "bandNumLabel";
            this.bandNumLabel.Size = new System.Drawing.Size(14, 14);
            this.bandNumLabel.TabIndex = 2;
            this.bandNumLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "选中波段数量：";
            // 
            // bandNumListBox
            // 
            this.bandNumListBox.FormattingEnabled = true;
            this.bandNumListBox.ItemHeight = 14;
            this.bandNumListBox.Location = new System.Drawing.Point(5, 23);
            this.bandNumListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bandNumListBox.Name = "bandNumListBox";
            this.bandNumListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.bandNumListBox.Size = new System.Drawing.Size(242, 200);
            this.bandNumListBox.TabIndex = 0;
            this.bandNumListBox.SelectedIndexChanged += new System.EventHandler(this.bandNumListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.thresholdControl);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.maxLoopControl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.classNumControl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(273, 56);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(219, 282);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参数设置";
            // 
            // thresholdControl
            // 
            this.thresholdControl.Location = new System.Drawing.Point(107, 173);
            this.thresholdControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.thresholdControl.Name = "thresholdControl";
            this.thresholdControl.Size = new System.Drawing.Size(110, 23);
            this.thresholdControl.TabIndex = 5;
            this.thresholdControl.Text = "1";
            this.thresholdControl.TextChanged += new System.EventHandler(this.thresholdControl_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "终止阈值(0-1)：";
            // 
            // maxLoopControl
            // 
            this.maxLoopControl.Location = new System.Drawing.Point(107, 128);
            this.maxLoopControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maxLoopControl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxLoopControl.Name = "maxLoopControl";
            this.maxLoopControl.Size = new System.Drawing.Size(107, 23);
            this.maxLoopControl.TabIndex = 3;
            this.maxLoopControl.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "最大迭代次数：";
            // 
            // classNumControl
            // 
            this.classNumControl.Location = new System.Drawing.Point(107, 84);
            this.classNumControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.classNumControl.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.classNumControl.Name = "classNumControl";
            this.classNumControl.Size = new System.Drawing.Size(107, 23);
            this.classNumControl.TabIndex = 1;
            this.classNumControl.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "预期类数：";
            // 
            // outputImageTextBox
            // 
            this.outputImageTextBox.Location = new System.Drawing.Point(100, 352);
            this.outputImageTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputImageTextBox.Name = "outputImageTextBox";
            this.outputImageTextBox.Size = new System.Drawing.Size(307, 22);
            this.outputImageTextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(9, 352);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "输出文件：";
            // 
            // outputImageBtn
            // 
            this.outputImageBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.outputImageBtn.Location = new System.Drawing.Point(411, 343);
            this.outputImageBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputImageBtn.Name = "outputImageBtn";
            this.outputImageBtn.Size = new System.Drawing.Size(79, 37);
            this.outputImageBtn.TabIndex = 8;
            this.outputImageBtn.Text = "浏览";
            this.outputImageBtn.UseVisualStyleBackColor = true;
            this.outputImageBtn.Click += new System.EventHandler(this.outputImageBtn_Click);
            // 
            // formConfirm
            // 
            this.formConfirm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.formConfirm.Location = new System.Drawing.Point(91, 387);
            this.formConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.formConfirm.Name = "formConfirm";
            this.formConfirm.Size = new System.Drawing.Size(112, 35);
            this.formConfirm.TabIndex = 9;
            this.formConfirm.Text = "确定";
            this.formConfirm.UseVisualStyleBackColor = true;
            this.formConfirm.Click += new System.EventHandler(this.formConfirm_Click);
            // 
            // formCancel
            // 
            this.formCancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.formCancel.Location = new System.Drawing.Point(271, 387);
            this.formCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.formCancel.Name = "formCancel";
            this.formCancel.Size = new System.Drawing.Size(112, 35);
            this.formCancel.TabIndex = 10;
            this.formCancel.Text = "取消";
            this.formCancel.UseVisualStyleBackColor = true;
            this.formCancel.Click += new System.EventHandler(this.formCancel_Click);
            // 
            // kmeansForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 432);
            this.Controls.Add(this.formCancel);
            this.Controls.Add(this.formConfirm);
            this.Controls.Add(this.outputImageBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.outputImageTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inputImageBtn);
            this.Controls.Add(this.inputImageTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "kmeansForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "K-Means分类";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxLoopControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classNumControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputImageTextBox;
        private System.Windows.Forms.Button inputImageBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox bandNumListBox;
        private System.Windows.Forms.Label bandNumLabel;
        private System.Windows.Forms.Button clearBandsBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown classNumControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox thresholdControl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown maxLoopControl;
        private System.Windows.Forms.TextBox outputImageTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button outputImageBtn;
        private System.Windows.Forms.Button formConfirm;
        private System.Windows.Forms.Button formCancel;
    }
}