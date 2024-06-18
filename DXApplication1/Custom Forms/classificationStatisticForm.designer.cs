namespace 城市空间生态格局智能评估系统.Custom_Forms
{
    partial class classificationStatisticForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(classificationStatisticForm));
            this.label1 = new System.Windows.Forms.Label();
            this.inputImageTextBox = new System.Windows.Forms.TextBox();
            this.inputImageBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.classificationStatisticTextBox = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入文件：";
            // 
            // inputImageTextBox
            // 
            this.inputImageTextBox.Location = new System.Drawing.Point(131, 30);
            this.inputImageTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputImageTextBox.Name = "inputImageTextBox";
            this.inputImageTextBox.Size = new System.Drawing.Size(627, 26);
            this.inputImageTextBox.TabIndex = 1;
            // 
            // inputImageBtn
            // 
            this.inputImageBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputImageBtn.Location = new System.Drawing.Point(763, 22);
            this.inputImageBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputImageBtn.Name = "inputImageBtn";
            this.inputImageBtn.Size = new System.Drawing.Size(119, 37);
            this.inputImageBtn.TabIndex = 2;
            this.inputImageBtn.Text = "浏览";
            this.inputImageBtn.UseVisualStyleBackColor = true;
            this.inputImageBtn.Click += new System.EventHandler(this.inputImageBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.classificationStatisticTextBox);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(15, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(870, 459);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分类统计结果";
            // 
            // classificationStatisticTextBox
            // 
            this.classificationStatisticTextBox.Location = new System.Drawing.Point(7, 35);
            this.classificationStatisticTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.classificationStatisticTextBox.Multiline = true;
            this.classificationStatisticTextBox.Name = "classificationStatisticTextBox";
            this.classificationStatisticTextBox.Size = new System.Drawing.Size(859, 408);
            this.classificationStatisticTextBox.TabIndex = 0;
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartBtn.Location = new System.Drawing.Point(97, 550);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(210, 54);
            this.StartBtn.TabIndex = 4;
            this.StartBtn.Text = "开始统计";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exportBtn.Location = new System.Drawing.Point(579, 550);
            this.exportBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(210, 54);
            this.exportBtn.TabIndex = 5;
            this.exportBtn.Text = "导出文件";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // classificationStatisticForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 630);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inputImageBtn);
            this.Controls.Add(this.inputImageTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "classificationStatisticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "分类统计";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputImageTextBox;
        private System.Windows.Forms.Button inputImageBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox classificationStatisticTextBox;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button exportBtn;
    }
}