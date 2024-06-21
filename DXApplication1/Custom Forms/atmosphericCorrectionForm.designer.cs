namespace 绿廊智绘.Custom_Forms
{
    partial class atmosphericCorrectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(atmosphericCorrectionForm));
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.atmosConfirm = new System.Windows.Forms.Button();
            this.atmosCancel = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.airosolYesOrNo = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.airosolPattern = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.atmosPattern = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new System.Windows.Forms.Label();
            this.visibility = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectMetadata = new System.Windows.Forms.Button();
            this.selectImage = new System.Windows.Forms.Button();
            this.inputMetadata = new System.Windows.Forms.TextBox();
            this.inputImage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EpigeneticReflectance = new System.Windows.Forms.RadioButton();
            this.EpigeneticBrightness = new System.Windows.Forms.RadioButton();
            this.DN = new System.Windows.Forms.RadioButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.outputImage = new System.Windows.Forms.Button();
            this.outputFile = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // atmosConfirm
            // 
            this.atmosConfirm.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.atmosConfirm.Location = new System.Drawing.Point(190, 609);
            this.atmosConfirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.atmosConfirm.Name = "atmosConfirm";
            this.atmosConfirm.Size = new System.Drawing.Size(123, 37);
            this.atmosConfirm.TabIndex = 18;
            this.atmosConfirm.Text = "确定";
            this.atmosConfirm.UseVisualStyleBackColor = true;
            this.atmosConfirm.Click += new System.EventHandler(this.atmosConfirm_Click);
            // 
            // atmosCancel
            // 
            this.atmosCancel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.atmosCancel.Location = new System.Drawing.Point(461, 609);
            this.atmosCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.atmosCancel.Name = "atmosCancel";
            this.atmosCancel.Size = new System.Drawing.Size(123, 37);
            this.atmosCancel.TabIndex = 19;
            this.atmosCancel.Text = "取消";
            this.atmosCancel.UseVisualStyleBackColor = true;
            this.atmosCancel.Click += new System.EventHandler(this.atmosCancel_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(284, 105);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(135, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "逐像元反演气溶胶：";
            // 
            // airosolYesOrNo
            // 
            this.airosolYesOrNo.FormattingEnabled = true;
            this.airosolYesOrNo.Items.AddRange(new object[] {
            "是",
            "否"});
            this.airosolYesOrNo.Location = new System.Drawing.Point(423, 102);
            this.airosolYesOrNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.airosolYesOrNo.Name = "airosolYesOrNo";
            this.airosolYesOrNo.Size = new System.Drawing.Size(190, 26);
            this.airosolYesOrNo.TabIndex = 16;
            this.airosolYesOrNo.SelectedIndexChanged += new System.EventHandler(this.airosolYesOrNo_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(19, 67);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 22);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "气溶胶类型：";
            // 
            // airosolPattern
            // 
            this.airosolPattern.FormattingEnabled = true;
            this.airosolPattern.Items.AddRange(new object[] {
            "大陆型气溶胶",
            "海洋型气溶胶",
            "城市型气溶胶",
            "沙尘型气溶胶",
            "煤烟型气溶胶",
            "平流层型气溶胶"});
            this.airosolPattern.Location = new System.Drawing.Point(139, 60);
            this.airosolPattern.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.airosolPattern.Name = "airosolPattern";
            this.airosolPattern.Size = new System.Drawing.Size(466, 26);
            this.airosolPattern.TabIndex = 15;
            this.airosolPattern.SelectedIndexChanged += new System.EventHandler(this.airosolPattern_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(19, 31);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(90, 22);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "大气模式：";
            // 
            // atmosPattern
            // 
            this.atmosPattern.FormattingEnabled = true;
            this.atmosPattern.Items.AddRange(new object[] {
            "系统自动选择大气模式",
            "热带大气模式",
            "中纬度夏季大气模式",
            "中纬度冬季大气模式",
            "副极地夏季大气模式",
            "副极地冬季大气模式",
            "美国1962大气模式"});
            this.atmosPattern.Location = new System.Drawing.Point(139, 24);
            this.atmosPattern.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.atmosPattern.Name = "atmosPattern";
            this.atmosPattern.Size = new System.Drawing.Size(466, 26);
            this.atmosPattern.TabIndex = 14;
            this.atmosPattern.SelectedIndexChanged += new System.EventHandler(this.atmosPattern_SelectedIndexChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(234, 105);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(25, 22);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "KM";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label5.Location = new System.Drawing.Point(71, 431);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "初始能见度:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // visibility
            // 
            this.visibility.Location = new System.Drawing.Point(139, 105);
            this.visibility.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.visibility.Name = "visibility";
            this.visibility.Size = new System.Drawing.Size(73, 26);
            this.visibility.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectMetadata);
            this.groupBox1.Controls.Add(this.selectImage);
            this.groupBox1.Controls.Add(this.inputMetadata);
            this.groupBox1.Controls.Add(this.inputImage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(55, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(619, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入信息";
            // 
            // selectMetadata
            // 
            this.selectMetadata.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectMetadata.Location = new System.Drawing.Point(513, 228);
            this.selectMetadata.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.selectMetadata.Name = "selectMetadata";
            this.selectMetadata.Size = new System.Drawing.Size(93, 28);
            this.selectMetadata.TabIndex = 6;
            this.selectMetadata.Text = "浏览";
            this.selectMetadata.UseVisualStyleBackColor = true;
            this.selectMetadata.Click += new System.EventHandler(this.selectMetadata_Click);
            // 
            // selectImage
            // 
            this.selectImage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectImage.Location = new System.Drawing.Point(513, 186);
            this.selectImage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.selectImage.Name = "selectImage";
            this.selectImage.Size = new System.Drawing.Size(93, 28);
            this.selectImage.TabIndex = 5;
            this.selectImage.Text = "浏览";
            this.selectImage.UseVisualStyleBackColor = true;
            this.selectImage.Click += new System.EventHandler(this.selectImage_Click);
            // 
            // inputMetadata
            // 
            this.inputMetadata.Location = new System.Drawing.Point(139, 228);
            this.inputMetadata.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputMetadata.Name = "inputMetadata";
            this.inputMetadata.Size = new System.Drawing.Size(369, 26);
            this.inputMetadata.TabIndex = 4;
            // 
            // inputImage
            // 
            this.inputImage.Location = new System.Drawing.Point(139, 186);
            this.inputImage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputImage.Name = "inputImage";
            this.inputImage.Size = new System.Drawing.Size(369, 26);
            this.inputImage.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(18, 230);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "元数据文件：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入文件：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EpigeneticReflectance);
            this.groupBox2.Controls.Add(this.EpigeneticBrightness);
            this.groupBox2.Controls.Add(this.DN);
            this.groupBox2.Location = new System.Drawing.Point(16, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(576, 132);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据类型";
            // 
            // EpigeneticReflectance
            // 
            this.EpigeneticReflectance.AutoSize = true;
            this.EpigeneticReflectance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EpigeneticReflectance.Location = new System.Drawing.Point(447, 60);
            this.EpigeneticReflectance.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EpigeneticReflectance.Name = "EpigeneticReflectance";
            this.EpigeneticReflectance.Size = new System.Drawing.Size(119, 22);
            this.EpigeneticReflectance.TabIndex = 2;
            this.EpigeneticReflectance.TabStop = true;
            this.EpigeneticReflectance.Text = "表观反射率";
            this.EpigeneticReflectance.UseVisualStyleBackColor = true;
            this.EpigeneticReflectance.CheckedChanged += new System.EventHandler(this.EpigeneticReflectance_CheckedChanged);
            // 
            // EpigeneticBrightness
            // 
            this.EpigeneticBrightness.AutoSize = true;
            this.EpigeneticBrightness.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EpigeneticBrightness.Location = new System.Drawing.Point(218, 60);
            this.EpigeneticBrightness.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EpigeneticBrightness.Name = "EpigeneticBrightness";
            this.EpigeneticBrightness.Size = new System.Drawing.Size(119, 22);
            this.EpigeneticBrightness.TabIndex = 1;
            this.EpigeneticBrightness.TabStop = true;
            this.EpigeneticBrightness.Text = "表观辐亮度";
            this.EpigeneticBrightness.UseVisualStyleBackColor = true;
            this.EpigeneticBrightness.CheckedChanged += new System.EventHandler(this.EpigeneticBrightness_CheckedChanged);
            // 
            // DN
            // 
            this.DN.AutoSize = true;
            this.DN.Checked = true;
            this.DN.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DN.Location = new System.Drawing.Point(6, 60);
            this.DN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DN.Name = "DN";
            this.DN.Size = new System.Drawing.Size(65, 22);
            this.DN.TabIndex = 0;
            this.DN.TabStop = true;
            this.DN.Text = "DN值";
            this.DN.UseVisualStyleBackColor = true;
            this.DN.CheckedChanged += new System.EventHandler(this.DN_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(71, 532);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "输出文件：";
            // 
            // outputImage
            // 
            this.outputImage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.outputImage.Location = new System.Drawing.Point(568, 525);
            this.outputImage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.outputImage.Name = "outputImage";
            this.outputImage.Size = new System.Drawing.Size(93, 30);
            this.outputImage.TabIndex = 7;
            this.outputImage.Text = "浏览";
            this.outputImage.UseVisualStyleBackColor = true;
            this.outputImage.Click += new System.EventHandler(this.outputImage_Click);
            // 
            // outputFile
            // 
            this.outputFile.Location = new System.Drawing.Point(190, 525);
            this.outputFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.outputFile.Name = "outputFile";
            this.outputFile.Size = new System.Drawing.Size(369, 26);
            this.outputFile.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelControl2);
            this.groupBox3.Controls.Add(this.airosolYesOrNo);
            this.groupBox3.Controls.Add(this.visibility);
            this.groupBox3.Controls.Add(this.labelControl5);
            this.groupBox3.Controls.Add(this.labelControl3);
            this.groupBox3.Controls.Add(this.airosolPattern);
            this.groupBox3.Controls.Add(this.atmosPattern);
            this.groupBox3.Controls.Add(this.labelControl4);
            this.groupBox3.Location = new System.Drawing.Point(55, 325);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(619, 162);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "参数设置";
            // 
            // atmosphericCorrectionForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 705);
            this.Controls.Add(this.outputFile);
            this.Controls.Add(this.outputImage);
            this.Controls.Add(this.atmosCancel);
            this.Controls.Add(this.atmosConfirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "atmosphericCorrectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "大气校正";
            this.Load += new System.EventHandler(this.AtmosCorrectionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private System.Windows.Forms.Button atmosConfirm;
        private System.Windows.Forms.Button atmosCancel;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox airosolYesOrNo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox airosolPattern;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox atmosPattern;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox visibility;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selectMetadata;
        private System.Windows.Forms.Button selectImage;
        private System.Windows.Forms.TextBox inputMetadata;
        private System.Windows.Forms.TextBox inputImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton EpigeneticReflectance;
        private System.Windows.Forms.RadioButton EpigeneticBrightness;
        private System.Windows.Forms.RadioButton DN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button outputImage;
        private System.Windows.Forms.TextBox outputFile;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}