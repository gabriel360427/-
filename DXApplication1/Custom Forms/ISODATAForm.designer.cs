namespace 绿廊智绘.Custom_Forms
{
    partial class ISODATAForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ISODATAForm));
            this.label1 = new System.Windows.Forms.Label();
            this.inputImageTextBox = new System.Windows.Forms.TextBox();
            this.inputImageButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MinDisControl = new System.Windows.Forms.TextBox();
            this.DevControl = new System.Windows.Forms.TextBox();
            this.MaxLoopControl = new System.Windows.Forms.NumericUpDown();
            this.MaxMergeControl = new System.Windows.Forms.NumericUpDown();
            this.MinSamControl = new System.Windows.Forms.NumericUpDown();
            this.InitClassNumControl = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProspClassNumControl = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.outputImageTextBox = new System.Windows.Forms.TextBox();
            this.outputImageButton = new System.Windows.Forms.Button();
            this.formConfirm = new System.Windows.Forms.Button();
            this.formCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bandClear = new System.Windows.Forms.Button();
            this.bandNumLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bandNumListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLoopControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxMergeControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinSamControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitClassNumControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProspClassNumControl)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入文件：";
            // 
            // inputImageTextBox
            // 
            this.inputImageTextBox.Location = new System.Drawing.Point(122, 24);
            this.inputImageTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputImageTextBox.Name = "inputImageTextBox";
            this.inputImageTextBox.Size = new System.Drawing.Size(410, 26);
            this.inputImageTextBox.TabIndex = 1;
            // 
            // inputImageButton
            // 
            this.inputImageButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputImageButton.Location = new System.Drawing.Point(538, 18);
            this.inputImageButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputImageButton.Name = "inputImageButton";
            this.inputImageButton.Size = new System.Drawing.Size(88, 39);
            this.inputImageButton.TabIndex = 2;
            this.inputImageButton.Text = "浏览";
            this.inputImageButton.UseVisualStyleBackColor = true;
            this.inputImageButton.Click += new System.EventHandler(this.inputImageButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MinDisControl);
            this.groupBox1.Controls.Add(this.DevControl);
            this.groupBox1.Controls.Add(this.MaxLoopControl);
            this.groupBox1.Controls.Add(this.MaxMergeControl);
            this.groupBox1.Controls.Add(this.MinSamControl);
            this.groupBox1.Controls.Add(this.InitClassNumControl);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ProspClassNumControl);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(304, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(336, 417);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数设置";
            // 
            // MinDisControl
            // 
            this.MinDisControl.Location = new System.Drawing.Point(162, 351);
            this.MinDisControl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinDisControl.Name = "MinDisControl";
            this.MinDisControl.Size = new System.Drawing.Size(156, 27);
            this.MinDisControl.TabIndex = 17;
            this.MinDisControl.Text = "6.4";
            // 
            // DevControl
            // 
            this.DevControl.Location = new System.Drawing.Point(144, 303);
            this.DevControl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DevControl.Name = "DevControl";
            this.DevControl.Size = new System.Drawing.Size(174, 27);
            this.DevControl.TabIndex = 16;
            this.DevControl.Text = "9.8";
            // 
            // MaxLoopControl
            // 
            this.MaxLoopControl.Location = new System.Drawing.Point(162, 249);
            this.MaxLoopControl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaxLoopControl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxLoopControl.Name = "MaxLoopControl";
            this.MaxLoopControl.Size = new System.Drawing.Size(154, 27);
            this.MaxLoopControl.TabIndex = 15;
            this.MaxLoopControl.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // MaxMergeControl
            // 
            this.MaxMergeControl.Location = new System.Drawing.Point(162, 198);
            this.MaxMergeControl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaxMergeControl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxMergeControl.Name = "MaxMergeControl";
            this.MaxMergeControl.Size = new System.Drawing.Size(154, 27);
            this.MaxMergeControl.TabIndex = 6;
            this.MaxMergeControl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MinSamControl
            // 
            this.MinSamControl.Location = new System.Drawing.Point(144, 147);
            this.MinSamControl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinSamControl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinSamControl.Name = "MinSamControl";
            this.MinSamControl.Size = new System.Drawing.Size(174, 27);
            this.MinSamControl.TabIndex = 14;
            this.MinSamControl.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // InitClassNumControl
            // 
            this.InitClassNumControl.Location = new System.Drawing.Point(126, 99);
            this.InitClassNumControl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.InitClassNumControl.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.InitClassNumControl.Name = "InitClassNumControl";
            this.InitClassNumControl.Size = new System.Drawing.Size(192, 27);
            this.InitClassNumControl.TabIndex = 13;
            this.InitClassNumControl.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(16, 357);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "最小中心距离：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(16, 306);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "最大标准差：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(16, 252);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "最大迭代次数：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(16, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "最大合并对数：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(16, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "最少像元数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(16, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "初始类数：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(16, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "预期类数：";
            // 
            // ProspClassNumControl
            // 
            this.ProspClassNumControl.Location = new System.Drawing.Point(126, 51);
            this.ProspClassNumControl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ProspClassNumControl.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ProspClassNumControl.Name = "ProspClassNumControl";
            this.ProspClassNumControl.Size = new System.Drawing.Size(192, 27);
            this.ProspClassNumControl.TabIndex = 0;
            this.ProspClassNumControl.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(26, 513);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "输出文件：";
            // 
            // outputImageTextBox
            // 
            this.outputImageTextBox.Location = new System.Drawing.Point(122, 513);
            this.outputImageTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.outputImageTextBox.Name = "outputImageTextBox";
            this.outputImageTextBox.Size = new System.Drawing.Size(410, 26);
            this.outputImageTextBox.TabIndex = 7;
            // 
            // outputImageButton
            // 
            this.outputImageButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.outputImageButton.Location = new System.Drawing.Point(536, 503);
            this.outputImageButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.outputImageButton.Name = "outputImageButton";
            this.outputImageButton.Size = new System.Drawing.Size(82, 42);
            this.outputImageButton.TabIndex = 8;
            this.outputImageButton.Text = "浏览";
            this.outputImageButton.UseVisualStyleBackColor = true;
            this.outputImageButton.Click += new System.EventHandler(this.outputImageButton_Click);
            // 
            // formConfirm
            // 
            this.formConfirm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.formConfirm.Location = new System.Drawing.Point(122, 552);
            this.formConfirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.formConfirm.Name = "formConfirm";
            this.formConfirm.Size = new System.Drawing.Size(126, 42);
            this.formConfirm.TabIndex = 9;
            this.formConfirm.Text = "确定";
            this.formConfirm.UseVisualStyleBackColor = true;
            this.formConfirm.Click += new System.EventHandler(this.formConfirm_Click);
            // 
            // formCancel
            // 
            this.formCancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.formCancel.Location = new System.Drawing.Point(408, 552);
            this.formCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.formCancel.Name = "formCancel";
            this.formCancel.Size = new System.Drawing.Size(126, 42);
            this.formCancel.TabIndex = 10;
            this.formCancel.Text = "取消";
            this.formCancel.UseVisualStyleBackColor = true;
            this.formCancel.Click += new System.EventHandler(this.formCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bandClear);
            this.groupBox2.Controls.Add(this.bandNumLabel);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.bandNumListBox);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(10, 75);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(288, 417);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "波段选择";
            // 
            // bandClear
            // 
            this.bandClear.Location = new System.Drawing.Point(200, 366);
            this.bandClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bandClear.Name = "bandClear";
            this.bandClear.Size = new System.Drawing.Size(78, 33);
            this.bandClear.TabIndex = 3;
            this.bandClear.Text = "清空";
            this.bandClear.UseVisualStyleBackColor = true;
            this.bandClear.Click += new System.EventHandler(this.bandClear_Click);
            // 
            // bandNumLabel
            // 
            this.bandNumLabel.AutoSize = true;
            this.bandNumLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bandNumLabel.Location = new System.Drawing.Point(150, 372);
            this.bandNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bandNumLabel.Name = "bandNumLabel";
            this.bandNumLabel.Size = new System.Drawing.Size(17, 18);
            this.bandNumLabel.TabIndex = 2;
            this.bandNumLabel.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(6, 372);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "选中波段数量：";
            // 
            // bandNumListBox
            // 
            this.bandNumListBox.FormattingEnabled = true;
            this.bandNumListBox.ItemHeight = 17;
            this.bandNumListBox.Location = new System.Drawing.Point(0, 51);
            this.bandNumListBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bandNumListBox.Name = "bandNumListBox";
            this.bandNumListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.bandNumListBox.Size = new System.Drawing.Size(276, 276);
            this.bandNumListBox.TabIndex = 0;
            this.bandNumListBox.SelectedIndexChanged += new System.EventHandler(this.bandNumListBox_SelectedIndexChanged);
            // 
            // ISODATAForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 606);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.formCancel);
            this.Controls.Add(this.formConfirm);
            this.Controls.Add(this.outputImageButton);
            this.Controls.Add(this.outputImageTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inputImageButton);
            this.Controls.Add(this.inputImageTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ISODATAForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISODATA分类";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLoopControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxMergeControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinSamControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitClassNumControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProspClassNumControl)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputImageTextBox;
        private System.Windows.Forms.Button inputImageButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MinDisControl;
        private System.Windows.Forms.TextBox DevControl;
        private System.Windows.Forms.NumericUpDown MaxLoopControl;
        private System.Windows.Forms.NumericUpDown MaxMergeControl;
        private System.Windows.Forms.NumericUpDown MinSamControl;
        private System.Windows.Forms.NumericUpDown InitClassNumControl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ProspClassNumControl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox outputImageTextBox;
        private System.Windows.Forms.Button outputImageButton;
        private System.Windows.Forms.Button formConfirm;
        private System.Windows.Forms.Button formCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bandClear;
        private System.Windows.Forms.Label bandNumLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox bandNumListBox;
    }
}