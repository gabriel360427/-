namespace 城市空间生态格局智能评估系统.Custom_Forms
{
    partial class RadiationCalibrationCommand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadiationCalibrationCommand));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.文件输入框 = new System.Windows.Forms.ComboBox();
            this.元数据文件 = new System.Windows.Forms.ComboBox();
            this.InputFile = new System.Windows.Forms.Button();
            this.InputXML = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ApparentReflectance = new System.Windows.Forms.RadioButton();
            this.ApparentRadiance = new System.Windows.Forms.RadioButton();
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
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入文件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "元数据文件";
            // 
            // 文件输入框
            // 
            this.文件输入框.FormattingEnabled = true;
            this.文件输入框.Location = new System.Drawing.Point(133, 33);
            this.文件输入框.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.文件输入框.Name = "文件输入框";
            this.文件输入框.Size = new System.Drawing.Size(345, 26);
            this.文件输入框.TabIndex = 2;
            this.文件输入框.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // 元数据文件
            // 
            this.元数据文件.FormattingEnabled = true;
            this.元数据文件.Location = new System.Drawing.Point(133, 107);
            this.元数据文件.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.元数据文件.Name = "元数据文件";
            this.元数据文件.Size = new System.Drawing.Size(345, 26);
            this.元数据文件.TabIndex = 3;
            this.元数据文件.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // InputFile
            // 
            this.InputFile.Location = new System.Drawing.Point(506, 31);
            this.InputFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.InputFile.Name = "InputFile";
            this.InputFile.Size = new System.Drawing.Size(66, 23);
            this.InputFile.TabIndex = 5;
            this.InputFile.Text = "加载";
            this.InputFile.UseVisualStyleBackColor = true;
            this.InputFile.Click += new System.EventHandler(this.InputDialog_Click);
            // 
            // InputXML
            // 
            this.InputXML.Location = new System.Drawing.Point(506, 109);
            this.InputXML.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.InputXML.Name = "InputXML";
            this.InputXML.Size = new System.Drawing.Size(66, 23);
            this.InputXML.TabIndex = 6;
            this.InputXML.Text = "加载";
            this.InputXML.UseVisualStyleBackColor = true;
            this.InputXML.Click += new System.EventHandler(this.MetaDialog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ApparentReflectance);
            this.groupBox1.Controls.Add(this.ApparentRadiance);
            this.groupBox1.Location = new System.Drawing.Point(23, 168);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(550, 153);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "定标类型";
            // 
            // ApparentReflectance
            // 
            this.ApparentReflectance.AutoSize = true;
            this.ApparentReflectance.Location = new System.Drawing.Point(328, 78);
            this.ApparentReflectance.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ApparentReflectance.Name = "ApparentReflectance";
            this.ApparentReflectance.Size = new System.Drawing.Size(104, 22);
            this.ApparentReflectance.TabIndex = 1;
            this.ApparentReflectance.TabStop = true;
            this.ApparentReflectance.Text = "表观反射率";
            this.ApparentReflectance.UseVisualStyleBackColor = true;
            // 
            // ApparentRadiance
            // 
            this.ApparentRadiance.AutoSize = true;
            this.ApparentRadiance.Location = new System.Drawing.Point(110, 78);
            this.ApparentRadiance.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ApparentRadiance.Name = "ApparentRadiance";
            this.ApparentRadiance.Size = new System.Drawing.Size(104, 22);
            this.ApparentRadiance.TabIndex = 0;
            this.ApparentRadiance.TabStop = true;
            this.ApparentRadiance.Text = "表观辐射率";
            this.ApparentRadiance.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 346);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "输出文件";
            // 
            // 文件输出框
            // 
            this.文件输出框.FormattingEnabled = true;
            this.文件输出框.Location = new System.Drawing.Point(133, 346);
            this.文件输出框.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.文件输出框.Name = "文件输出框";
            this.文件输出框.Size = new System.Drawing.Size(345, 26);
            this.文件输出框.TabIndex = 9;
            // 
            // OutputFile
            // 
            this.OutputFile.Location = new System.Drawing.Point(506, 346);
            this.OutputFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OutputFile.Name = "OutputFile";
            this.OutputFile.Size = new System.Drawing.Size(66, 23);
            this.OutputFile.TabIndex = 10;
            this.OutputFile.Text = "加载";
            this.OutputFile.UseVisualStyleBackColor = true;
            this.OutputFile.Click += new System.EventHandler(this.OutputDialog_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(133, 401);
            this.OK.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(91, 31);
            this.OK.TabIndex = 11;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(351, 401);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(91, 31);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // 辐射定标
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 444);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.OutputFile);
            this.Controls.Add(this.文件输出框);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InputXML);
            this.Controls.Add(this.InputFile);
            this.Controls.Add(this.元数据文件);
            this.Controls.Add(this.文件输入框);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "辐射定标";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "辐射定标";
            this.Load += new System.EventHandler(this.辐射定标_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox 文件输入框;
        private System.Windows.Forms.ComboBox 元数据文件;
        private System.Windows.Forms.Button InputFile;
        private System.Windows.Forms.Button InputXML;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ApparentReflectance;
        private System.Windows.Forms.RadioButton ApparentRadiance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox 文件输出框;
        private System.Windows.Forms.Button OutputFile;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
    }
}