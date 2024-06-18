namespace 城市空间生态格局智能评估系统.Custom_Forms
{
    partial class distanceClassifyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(distanceClassifyForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.imageInfolabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inputImageBtn = new System.Windows.Forms.Button();
            this.inputImagelistBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selectROIGroupBox = new System.Windows.Forms.GroupBox();
            this.selectedROIListBox = new System.Windows.Forms.ListBox();
            this.selectClassifierGroupBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.selectedClassifierComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resultImageTextBox = new System.Windows.Forms.TextBox();
            this.selectResultImageBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lineStartTextBox = new System.Windows.Forms.TextBox();
            this.columnStartTextBox = new System.Windows.Forms.TextBox();
            this.selectRegionGroupBox = new System.Windows.Forms.GroupBox();
            this.columnEndTextBox = new System.Windows.Forms.TextBox();
            this.lineEndTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clearBandsBtn = new System.Windows.Forms.Button();
            this.bandNumLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageBandListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.selectROIGroupBox.SuspendLayout();
            this.selectClassifierGroupBox.SuspendLayout();
            this.selectRegionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(995, 460);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择文件";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.imageInfolabel);
            this.groupBox3.Location = new System.Drawing.Point(496, 31);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(495, 411);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "文件信息";
            // 
            // imageInfolabel
            // 
            this.imageInfolabel.Location = new System.Drawing.Point(17, 30);
            this.imageInfolabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.imageInfolabel.Name = "imageInfolabel";
            this.imageInfolabel.Size = new System.Drawing.Size(473, 364);
            this.imageInfolabel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputImageBtn);
            this.groupBox2.Controls.Add(this.inputImagelistBox);
            this.groupBox2.Location = new System.Drawing.Point(7, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(483, 411);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "待分类影像";
            // 
            // inputImageBtn
            // 
            this.inputImageBtn.Location = new System.Drawing.Point(15, 343);
            this.inputImageBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputImageBtn.Name = "inputImageBtn";
            this.inputImageBtn.Size = new System.Drawing.Size(448, 49);
            this.inputImageBtn.TabIndex = 1;
            this.inputImageBtn.Text = "导入文件";
            this.inputImageBtn.UseVisualStyleBackColor = true;
            this.inputImageBtn.Click += new System.EventHandler(this.inputImageBtn_Click);
            // 
            // inputImagelistBox
            // 
            this.inputImagelistBox.FormattingEnabled = true;
            this.inputImagelistBox.ItemHeight = 17;
            this.inputImagelistBox.Location = new System.Drawing.Point(15, 30);
            this.inputImagelistBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputImagelistBox.Name = "inputImagelistBox";
            this.inputImagelistBox.Size = new System.Drawing.Size(447, 259);
            this.inputImagelistBox.TabIndex = 0;
            this.inputImagelistBox.SelectedIndexChanged += new System.EventHandler(this.inputImagelistBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(10, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "进行分类的波段：";
            // 
            // selectROIGroupBox
            // 
            this.selectROIGroupBox.Controls.Add(this.selectedROIListBox);
            this.selectROIGroupBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectROIGroupBox.Location = new System.Drawing.Point(487, 647);
            this.selectROIGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.selectROIGroupBox.Name = "selectROIGroupBox";
            this.selectROIGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.selectROIGroupBox.Size = new System.Drawing.Size(521, 199);
            this.selectROIGroupBox.TabIndex = 3;
            this.selectROIGroupBox.TabStop = false;
            this.selectROIGroupBox.Text = "选择ROI";
            // 
            // selectedROIListBox
            // 
            this.selectedROIListBox.FormattingEnabled = true;
            this.selectedROIListBox.ItemHeight = 17;
            this.selectedROIListBox.Location = new System.Drawing.Point(22, 42);
            this.selectedROIListBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.selectedROIListBox.Name = "selectedROIListBox";
            this.selectedROIListBox.Size = new System.Drawing.Size(475, 106);
            this.selectedROIListBox.TabIndex = 7;
            this.selectedROIListBox.SelectedIndexChanged += new System.EventHandler(this.selectedROIListBox_SelectedIndexChanged);
            // 
            // selectClassifierGroupBox
            // 
            this.selectClassifierGroupBox.Controls.Add(this.label8);
            this.selectClassifierGroupBox.Controls.Add(this.selectedClassifierComboBox);
            this.selectClassifierGroupBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectClassifierGroupBox.Location = new System.Drawing.Point(487, 480);
            this.selectClassifierGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.selectClassifierGroupBox.Name = "selectClassifierGroupBox";
            this.selectClassifierGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.selectClassifierGroupBox.Size = new System.Drawing.Size(521, 161);
            this.selectClassifierGroupBox.TabIndex = 4;
            this.selectClassifierGroupBox.TabStop = false;
            this.selectClassifierGroupBox.Text = "分类器";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(17, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(449, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "请选择分类器，最小距离分类器或马氏距离分类器";
            // 
            // selectedClassifierComboBox
            // 
            this.selectedClassifierComboBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectedClassifierComboBox.FormattingEnabled = true;
            this.selectedClassifierComboBox.Items.AddRange(new object[] {
            "最小距离分类",
            "马氏距离分类"});
            this.selectedClassifierComboBox.Location = new System.Drawing.Point(19, 85);
            this.selectedClassifierComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.selectedClassifierComboBox.Name = "selectedClassifierComboBox";
            this.selectedClassifierComboBox.Size = new System.Drawing.Size(476, 28);
            this.selectedClassifierComboBox.TabIndex = 7;
            this.selectedClassifierComboBox.SelectedIndexChanged += new System.EventHandler(this.selectedClassifierComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(15, 881);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "输出文件：";
            // 
            // resultImageTextBox
            // 
            this.resultImageTextBox.Location = new System.Drawing.Point(136, 881);
            this.resultImageTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.resultImageTextBox.Name = "resultImageTextBox";
            this.resultImageTextBox.Size = new System.Drawing.Size(738, 26);
            this.resultImageTextBox.TabIndex = 6;
            // 
            // selectResultImageBtn
            // 
            this.selectResultImageBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectResultImageBtn.Location = new System.Drawing.Point(897, 881);
            this.selectResultImageBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.selectResultImageBtn.Name = "selectResultImageBtn";
            this.selectResultImageBtn.Size = new System.Drawing.Size(111, 31);
            this.selectResultImageBtn.TabIndex = 9;
            this.selectResultImageBtn.Text = "浏览";
            this.selectResultImageBtn.UseVisualStyleBackColor = true;
            this.selectResultImageBtn.Click += new System.EventHandler(this.selectResultImageBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmBtn.Location = new System.Drawing.Point(136, 930);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(243, 62);
            this.confirmBtn.TabIndex = 10;
            this.confirmBtn.Text = "确定";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancelBtn.Location = new System.Drawing.Point(592, 930);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(243, 62);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "起始索引行：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(10, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "起始索引列：";
            // 
            // lineStartTextBox
            // 
            this.lineStartTextBox.Location = new System.Drawing.Point(119, 39);
            this.lineStartTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lineStartTextBox.Name = "lineStartTextBox";
            this.lineStartTextBox.Size = new System.Drawing.Size(114, 27);
            this.lineStartTextBox.TabIndex = 2;
            this.lineStartTextBox.TextChanged += new System.EventHandler(this.lineStartTextBox_TextChanged);
            // 
            // columnStartTextBox
            // 
            this.columnStartTextBox.Location = new System.Drawing.Point(119, 82);
            this.columnStartTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.columnStartTextBox.Name = "columnStartTextBox";
            this.columnStartTextBox.Size = new System.Drawing.Size(114, 27);
            this.columnStartTextBox.TabIndex = 3;
            this.columnStartTextBox.TextChanged += new System.EventHandler(this.columnStartTextBox_TextChanged);
            // 
            // selectRegionGroupBox
            // 
            this.selectRegionGroupBox.Controls.Add(this.columnEndTextBox);
            this.selectRegionGroupBox.Controls.Add(this.lineEndTextBox);
            this.selectRegionGroupBox.Controls.Add(this.label6);
            this.selectRegionGroupBox.Controls.Add(this.label7);
            this.selectRegionGroupBox.Controls.Add(this.clearBandsBtn);
            this.selectRegionGroupBox.Controls.Add(this.bandNumLabel);
            this.selectRegionGroupBox.Controls.Add(this.label1);
            this.selectRegionGroupBox.Controls.Add(this.imageBandListBox);
            this.selectRegionGroupBox.Controls.Add(this.columnStartTextBox);
            this.selectRegionGroupBox.Controls.Add(this.lineStartTextBox);
            this.selectRegionGroupBox.Controls.Add(this.label4);
            this.selectRegionGroupBox.Controls.Add(this.label3);
            this.selectRegionGroupBox.Controls.Add(this.label2);
            this.selectRegionGroupBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectRegionGroupBox.Location = new System.Drawing.Point(11, 480);
            this.selectRegionGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.selectRegionGroupBox.Name = "selectRegionGroupBox";
            this.selectRegionGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.selectRegionGroupBox.Size = new System.Drawing.Size(470, 368);
            this.selectRegionGroupBox.TabIndex = 1;
            this.selectRegionGroupBox.TabStop = false;
            this.selectRegionGroupBox.Text = "选择待分类的区域及波段";
            // 
            // columnEndTextBox
            // 
            this.columnEndTextBox.Location = new System.Drawing.Point(342, 82);
            this.columnEndTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.columnEndTextBox.Name = "columnEndTextBox";
            this.columnEndTextBox.Size = new System.Drawing.Size(114, 27);
            this.columnEndTextBox.TabIndex = 13;
            this.columnEndTextBox.TextChanged += new System.EventHandler(this.columnEndTextBox_TextChanged);
            // 
            // lineEndTextBox
            // 
            this.lineEndTextBox.Location = new System.Drawing.Point(342, 39);
            this.lineEndTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lineEndTextBox.Name = "lineEndTextBox";
            this.lineEndTextBox.Size = new System.Drawing.Size(114, 27);
            this.lineEndTextBox.TabIndex = 12;
            this.lineEndTextBox.TextChanged += new System.EventHandler(this.lineEndTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(235, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "终止索引列：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(235, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "终止索引行：";
            // 
            // clearBandsBtn
            // 
            this.clearBandsBtn.Location = new System.Drawing.Point(331, 323);
            this.clearBandsBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clearBandsBtn.Name = "clearBandsBtn";
            this.clearBandsBtn.Size = new System.Drawing.Size(107, 35);
            this.clearBandsBtn.TabIndex = 9;
            this.clearBandsBtn.Text = "清空";
            this.clearBandsBtn.UseVisualStyleBackColor = true;
            this.clearBandsBtn.Click += new System.EventHandler(this.clearBandsBtn_Click);
            // 
            // bandNumLabel
            // 
            this.bandNumLabel.AutoSize = true;
            this.bandNumLabel.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bandNumLabel.Location = new System.Drawing.Point(182, 324);
            this.bandNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bandNumLabel.Name = "bandNumLabel";
            this.bandNumLabel.Size = new System.Drawing.Size(22, 24);
            this.bandNumLabel.TabIndex = 8;
            this.bandNumLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 327);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "选中波段数量：";
            // 
            // imageBandListBox
            // 
            this.imageBandListBox.FormattingEnabled = true;
            this.imageBandListBox.ItemHeight = 17;
            this.imageBandListBox.Location = new System.Drawing.Point(15, 165);
            this.imageBandListBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.imageBandListBox.Name = "imageBandListBox";
            this.imageBandListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.imageBandListBox.Size = new System.Drawing.Size(427, 106);
            this.imageBandListBox.TabIndex = 6;
            this.imageBandListBox.SelectedIndexChanged += new System.EventHandler(this.imageBandListBox_SelectedIndexChanged);
            // 
            // distanceClassifyForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 1008);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.selectClassifierGroupBox);
            this.Controls.Add(this.selectResultImageBtn);
            this.Controls.Add(this.resultImageTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.selectROIGroupBox);
            this.Controls.Add(this.selectRegionGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "distanceClassifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "距离分类";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.selectROIGroupBox.ResumeLayout(false);
            this.selectClassifierGroupBox.ResumeLayout(false);
            this.selectClassifierGroupBox.PerformLayout();
            this.selectRegionGroupBox.ResumeLayout(false);
            this.selectRegionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label imageInfolabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button inputImageBtn;
        private System.Windows.Forms.ListBox inputImagelistBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox selectROIGroupBox;
        private System.Windows.Forms.GroupBox selectClassifierGroupBox;
        private System.Windows.Forms.ComboBox selectedClassifierComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resultImageTextBox;
        private System.Windows.Forms.Button selectResultImageBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lineStartTextBox;
        private System.Windows.Forms.TextBox columnStartTextBox;
        private System.Windows.Forms.GroupBox selectRegionGroupBox;
        private System.Windows.Forms.ListBox imageBandListBox;
        private System.Windows.Forms.Button clearBandsBtn;
        private System.Windows.Forms.Label bandNumLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox selectedROIListBox;
        private System.Windows.Forms.TextBox columnEndTextBox;
        private System.Windows.Forms.TextBox lineEndTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}