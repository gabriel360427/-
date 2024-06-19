namespace 城市空间生态格局智能评估系统.Custom_Forms
{
    partial class featureToRasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(featureToRasterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filetextBox = new System.Windows.Forms.TextBox();
            this.basefiletextBox = new System.Windows.Forms.TextBox();
            this.outputtextBox = new System.Windows.Forms.TextBox();
            this.inputfile_button = new System.Windows.Forms.Button();
            this.inputbasefile_button = new System.Windows.Forms.Button();
            this.outputfile_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入文件 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "基准文件";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "输出文件";
            // 
            // filetextBox
            // 
            this.filetextBox.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filetextBox.Location = new System.Drawing.Point(113, 48);
            this.filetextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.filetextBox.Name = "filetextBox";
            this.filetextBox.Size = new System.Drawing.Size(258, 29);
            this.filetextBox.TabIndex = 3;
            // 
            // basefiletextBox
            // 
            this.basefiletextBox.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basefiletextBox.Location = new System.Drawing.Point(113, 100);
            this.basefiletextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.basefiletextBox.Name = "basefiletextBox";
            this.basefiletextBox.Size = new System.Drawing.Size(258, 29);
            this.basefiletextBox.TabIndex = 4;
            // 
            // outputtextBox
            // 
            this.outputtextBox.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputtextBox.Location = new System.Drawing.Point(113, 162);
            this.outputtextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.outputtextBox.Name = "outputtextBox";
            this.outputtextBox.Size = new System.Drawing.Size(258, 29);
            this.outputtextBox.TabIndex = 5;
            // 
            // inputfile_button
            // 
            this.inputfile_button.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputfile_button.Location = new System.Drawing.Point(385, 44);
            this.inputfile_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputfile_button.Name = "inputfile_button";
            this.inputfile_button.Size = new System.Drawing.Size(90, 36);
            this.inputfile_button.TabIndex = 6;
            this.inputfile_button.Text = "浏览";
            this.inputfile_button.UseVisualStyleBackColor = true;
            this.inputfile_button.Click += new System.EventHandler(this.inputfile_button_Click);
            // 
            // inputbasefile_button
            // 
            this.inputbasefile_button.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputbasefile_button.Location = new System.Drawing.Point(385, 98);
            this.inputbasefile_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputbasefile_button.Name = "inputbasefile_button";
            this.inputbasefile_button.Size = new System.Drawing.Size(90, 36);
            this.inputbasefile_button.TabIndex = 7;
            this.inputbasefile_button.Text = "浏览";
            this.inputbasefile_button.UseVisualStyleBackColor = true;
            this.inputbasefile_button.Click += new System.EventHandler(this.inputbasefile_button_Click_1);
            // 
            // outputfile_button
            // 
            this.outputfile_button.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputfile_button.Location = new System.Drawing.Point(385, 154);
            this.outputfile_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.outputfile_button.Name = "outputfile_button";
            this.outputfile_button.Size = new System.Drawing.Size(90, 36);
            this.outputfile_button.TabIndex = 8;
            this.outputfile_button.Text = "浏览";
            this.outputfile_button.UseVisualStyleBackColor = true;
            this.outputfile_button.Click += new System.EventHandler(this.outputfile_button_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(113, 237);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 36);
            this.button4.TabIndex = 9;
            this.button4.Text = "确定";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(307, 237);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 36);
            this.button5.TabIndex = 10;
            this.button5.Text = "取消";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FeatureToRasterForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 318);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.outputfile_button);
            this.Controls.Add(this.inputbasefile_button);
            this.Controls.Add(this.inputfile_button);
            this.Controls.Add(this.outputtextBox);
            this.Controls.Add(this.basefiletextBox);
            this.Controls.Add(this.filetextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FeatureToRasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "矢量转栅格";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filetextBox;
        private System.Windows.Forms.TextBox basefiletextBox;
        private System.Windows.Forms.TextBox outputtextBox;
        private System.Windows.Forms.Button inputfile_button;
        private System.Windows.Forms.Button inputbasefile_button;
        private System.Windows.Forms.Button outputfile_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}