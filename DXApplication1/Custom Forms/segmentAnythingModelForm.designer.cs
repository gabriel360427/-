namespace 绿廊智绘.Custom_Forms
{
    partial class segmentAnythingModelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(segmentAnythingModelForm));
            this.selectoutputfile = new System.Windows.Forms.Button();
            this.selectImage = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.btnRunScript = new System.Windows.Forms.Button();
            this.outputfileBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputfileBox = new System.Windows.Forms.TextBox();
            this.txtImagePath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectoutputfile
            // 
            this.selectoutputfile.Font = new System.Drawing.Font("等线", 12F);
            this.selectoutputfile.Location = new System.Drawing.Point(444, 93);
            this.selectoutputfile.Margin = new System.Windows.Forms.Padding(2);
            this.selectoutputfile.Name = "selectoutputfile";
            this.selectoutputfile.Size = new System.Drawing.Size(82, 29);
            this.selectoutputfile.TabIndex = 22;
            this.selectoutputfile.Text = "浏览";
            this.selectoutputfile.UseVisualStyleBackColor = true;
            this.selectoutputfile.Click += new System.EventHandler(this.selectoutputfile_Click);
            // 
            // selectImage
            // 
            this.selectImage.Font = new System.Drawing.Font("等线", 12F);
            this.selectImage.Location = new System.Drawing.Point(444, 36);
            this.selectImage.Margin = new System.Windows.Forms.Padding(2);
            this.selectImage.Name = "selectImage";
            this.selectImage.Size = new System.Drawing.Size(82, 29);
            this.selectImage.TabIndex = 21;
            this.selectImage.Text = "浏览";
            this.selectImage.UseVisualStyleBackColor = true;
            this.selectImage.Click += new System.EventHandler(this.selectImage_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("等线", 12F);
            this.cancelBtn.Location = new System.Drawing.Point(356, 163);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(84, 45);
            this.cancelBtn.TabIndex = 20;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // btnRunScript
            // 
            this.btnRunScript.Font = new System.Drawing.Font("等线", 12F);
            this.btnRunScript.Location = new System.Drawing.Point(161, 163);
            this.btnRunScript.Margin = new System.Windows.Forms.Padding(2);
            this.btnRunScript.Name = "btnRunScript";
            this.btnRunScript.Size = new System.Drawing.Size(87, 45);
            this.btnRunScript.TabIndex = 19;
            this.btnRunScript.Text = "确定";
            this.btnRunScript.UseVisualStyleBackColor = true;
            this.btnRunScript.Click += new System.EventHandler(this.btnRunScript_Click);
            // 
            // outputfileBox
            // 
            this.outputfileBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.outputfileBox.Location = new System.Drawing.Point(161, 92);
            this.outputfileBox.Margin = new System.Windows.Forms.Padding(2);
            this.outputfileBox.Name = "outputfileBox";
            this.outputfileBox.Size = new System.Drawing.Size(278, 25);
            this.outputfileBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("等线", 12F);
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "输出文件夹：";
            // 
            // inputfileBox
            // 
            this.inputfileBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.inputfileBox.Location = new System.Drawing.Point(161, 36);
            this.inputfileBox.Margin = new System.Windows.Forms.Padding(2);
            this.inputfileBox.Name = "inputfileBox";
            this.inputfileBox.Size = new System.Drawing.Size(278, 25);
            this.inputfileBox.TabIndex = 16;
            // 
            // txtImagePath
            // 
            this.txtImagePath.AutoSize = true;
            this.txtImagePath.Font = new System.Drawing.Font("等线", 12F);
            this.txtImagePath.Location = new System.Drawing.Point(13, 41);
            this.txtImagePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(136, 17);
            this.txtImagePath.TabIndex = 15;
            this.txtImagePath.Text = "输入待分割图像：";
            // 
            // segmentAnythingModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 259);
            this.Controls.Add(this.selectoutputfile);
            this.Controls.Add(this.selectImage);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.btnRunScript);
            this.Controls.Add(this.outputfileBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputfileBox);
            this.Controls.Add(this.txtImagePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "segmentAnythingModelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAM面向对象分割";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectoutputfile;
        private System.Windows.Forms.Button selectImage;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button btnRunScript;
        private System.Windows.Forms.TextBox outputfileBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputfileBox;
        private System.Windows.Forms.Label txtImagePath;
    }
}