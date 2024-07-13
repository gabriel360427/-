namespace 绿廊智绘.Custom_Forms
{
    partial class classpostMMAForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(classpostMMAForm));
            this.inputImageBtn = new System.Windows.Forms.Button();
            this.inputImageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.classificationListBox = new System.Windows.Forms.ListBox();
            this.clearAllBtn = new System.Windows.Forms.Button();
            this.selectAllBtn = new System.Windows.Forms.Button();
            this.classificationNumLabel = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.outputImageBtn = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.secondaryRadioButton = new System.Windows.Forms.RadioButton();
            this.mainRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.proportionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kernelYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.kernelXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proportionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernelYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernelXNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // inputImageBtn
            // 
            this.inputImageBtn.Font = new System.Drawing.Font("等线", 12F);
            this.inputImageBtn.Location = new System.Drawing.Point(684, 15);
            this.inputImageBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputImageBtn.Name = "inputImageBtn";
            this.inputImageBtn.Size = new System.Drawing.Size(104, 29);
            this.inputImageBtn.TabIndex = 20;
            this.inputImageBtn.Text = "浏览";
            this.inputImageBtn.UseVisualStyleBackColor = true;
            this.inputImageBtn.Click += new System.EventHandler(this.inputImageBtn_Click);
            // 
            // inputImageTextBox
            // 
            this.inputImageTextBox.Location = new System.Drawing.Point(131, 20);
            this.inputImageTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputImageTextBox.Name = "inputImageTextBox";
            this.inputImageTextBox.Size = new System.Drawing.Size(549, 22);
            this.inputImageTextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("等线", 12F);
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "输入文件：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "选中类别数量：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.classificationListBox);
            this.groupBox1.Controls.Add(this.clearAllBtn);
            this.groupBox1.Controls.Add(this.selectAllBtn);
            this.groupBox1.Controls.Add(this.classificationNumLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("等线", 12F);
            this.groupBox1.Location = new System.Drawing.Point(24, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(426, 405);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分类信息";
            // 
            // classificationListBox
            // 
            this.classificationListBox.FormattingEnabled = true;
            this.classificationListBox.ItemHeight = 17;
            this.classificationListBox.Location = new System.Drawing.Point(9, 27);
            this.classificationListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.classificationListBox.Name = "classificationListBox";
            this.classificationListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.classificationListBox.Size = new System.Drawing.Size(398, 293);
            this.classificationListBox.TabIndex = 6;
            this.classificationListBox.SelectedIndexChanged += new System.EventHandler(this.classificationListBox_SelectedIndexChanged);
            // 
            // clearAllBtn
            // 
            this.clearAllBtn.Location = new System.Drawing.Point(327, 358);
            this.clearAllBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearAllBtn.Name = "clearAllBtn";
            this.clearAllBtn.Size = new System.Drawing.Size(80, 27);
            this.clearAllBtn.TabIndex = 4;
            this.clearAllBtn.Text = "清空";
            this.clearAllBtn.UseVisualStyleBackColor = true;
            this.clearAllBtn.Click += new System.EventHandler(this.clearAllBtn_Click);
            // 
            // selectAllBtn
            // 
            this.selectAllBtn.Location = new System.Drawing.Point(226, 358);
            this.selectAllBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectAllBtn.Name = "selectAllBtn";
            this.selectAllBtn.Size = new System.Drawing.Size(80, 27);
            this.selectAllBtn.TabIndex = 3;
            this.selectAllBtn.Text = "全选";
            this.selectAllBtn.UseVisualStyleBackColor = true;
            this.selectAllBtn.Click += new System.EventHandler(this.selectAllBtn_Click);
            // 
            // classificationNumLabel
            // 
            this.classificationNumLabel.AutoSize = true;
            this.classificationNumLabel.Location = new System.Drawing.Point(149, 362);
            this.classificationNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.classificationNumLabel.Name = "classificationNumLabel";
            this.classificationNumLabel.Size = new System.Drawing.Size(0, 17);
            this.classificationNumLabel.TabIndex = 2;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("等线", 12F);
            this.cancelBtn.Location = new System.Drawing.Point(463, 495);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(127, 38);
            this.cancelBtn.TabIndex = 26;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("等线", 12F);
            this.confirmBtn.Location = new System.Drawing.Point(199, 495);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(127, 38);
            this.confirmBtn.TabIndex = 25;
            this.confirmBtn.Text = "确定";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // outputImageBtn
            // 
            this.outputImageBtn.Font = new System.Drawing.Font("等线", 12F);
            this.outputImageBtn.Location = new System.Drawing.Point(684, 458);
            this.outputImageBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputImageBtn.Name = "outputImageBtn";
            this.outputImageBtn.Size = new System.Drawing.Size(104, 29);
            this.outputImageBtn.TabIndex = 24;
            this.outputImageBtn.Text = "浏览";
            this.outputImageBtn.UseVisualStyleBackColor = true;
            this.outputImageBtn.Click += new System.EventHandler(this.outputImageBtn_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(131, 464);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(549, 22);
            this.outputTextBox.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("等线", 12F);
            this.label6.Location = new System.Drawing.Point(24, 464);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "输出文件：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.secondaryRadioButton);
            this.groupBox2.Controls.Add(this.mainRadioButton);
            this.groupBox2.Font = new System.Drawing.Font("等线", 12F);
            this.groupBox2.Location = new System.Drawing.Point(463, 48);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(325, 111);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "分类方法";
            // 
            // secondaryRadioButton
            // 
            this.secondaryRadioButton.AutoSize = true;
            this.secondaryRadioButton.Location = new System.Drawing.Point(176, 48);
            this.secondaryRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.secondaryRadioButton.Name = "secondaryRadioButton";
            this.secondaryRadioButton.Size = new System.Drawing.Size(58, 21);
            this.secondaryRadioButton.TabIndex = 1;
            this.secondaryRadioButton.Text = "次要";
            this.secondaryRadioButton.UseVisualStyleBackColor = true;
            this.secondaryRadioButton.CheckedChanged += new System.EventHandler(this.secondaryRadioButton_CheckedChanged);
            // 
            // mainRadioButton
            // 
            this.mainRadioButton.AutoSize = true;
            this.mainRadioButton.Checked = true;
            this.mainRadioButton.Location = new System.Drawing.Point(63, 48);
            this.mainRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainRadioButton.Name = "mainRadioButton";
            this.mainRadioButton.Size = new System.Drawing.Size(58, 21);
            this.mainRadioButton.TabIndex = 0;
            this.mainRadioButton.TabStop = true;
            this.mainRadioButton.Text = "主要";
            this.mainRadioButton.UseVisualStyleBackColor = true;
            this.mainRadioButton.CheckedChanged += new System.EventHandler(this.mainRadioButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.proportionNumericUpDown);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.kernelYNumericUpDown);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.kernelXNumericUpDown);
            this.groupBox3.Font = new System.Drawing.Font("等线", 12F);
            this.groupBox3.Location = new System.Drawing.Point(463, 176);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(325, 273);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "参数设置";
            // 
            // proportionNumericUpDown
            // 
            this.proportionNumericUpDown.Location = new System.Drawing.Point(163, 171);
            this.proportionNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.proportionNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.proportionNumericUpDown.Name = "proportionNumericUpDown";
            this.proportionNumericUpDown.Size = new System.Drawing.Size(77, 24);
            this.proportionNumericUpDown.TabIndex = 34;
            this.proportionNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "中心像元比重：";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(161, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "×";
            // 
            // kernelYNumericUpDown
            // 
            this.kernelYNumericUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.kernelYNumericUpDown.Location = new System.Drawing.Point(195, 77);
            this.kernelYNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kernelYNumericUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.kernelYNumericUpDown.Name = "kernelYNumericUpDown";
            this.kernelYNumericUpDown.Size = new System.Drawing.Size(117, 24);
            this.kernelYNumericUpDown.TabIndex = 31;
            this.kernelYNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.kernelYNumericUpDown.ValueChanged += new System.EventHandler(this.kernelYNumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "卷积核大小：";
            // 
            // kernelXNumericUpDown
            // 
            this.kernelXNumericUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.kernelXNumericUpDown.Location = new System.Drawing.Point(40, 77);
            this.kernelXNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kernelXNumericUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.kernelXNumericUpDown.Name = "kernelXNumericUpDown";
            this.kernelXNumericUpDown.Size = new System.Drawing.Size(117, 24);
            this.kernelXNumericUpDown.TabIndex = 30;
            this.kernelXNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.kernelXNumericUpDown.ValueChanged += new System.EventHandler(this.kernelXNumericUpDown_ValueChanged);
            // 
            // classpostMMAForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 548);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.inputImageBtn);
            this.Controls.Add(this.inputImageTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.outputImageBtn);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "classpostMMAForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主/次要分析";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proportionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernelYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernelXNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputImageBtn;
        private System.Windows.Forms.TextBox inputImageTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearAllBtn;
        private System.Windows.Forms.Button selectAllBtn;
        private System.Windows.Forms.Label classificationNumLabel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button outputImageBtn;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton secondaryRadioButton;
        private System.Windows.Forms.RadioButton mainRadioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown kernelYNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown kernelXNumericUpDown;
        private System.Windows.Forms.NumericUpDown proportionNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox classificationListBox;
    }
}