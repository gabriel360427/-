namespace 城市空间生态格局智能评估系统.Custom_Commands
{
    partial class storageFormatConversionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(storageFormatConversionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filetextBox = new System.Windows.Forms.TextBox();
            this.outputtextBox = new System.Windows.Forms.TextBox();
            this.outputcomboBox = new System.Windows.Forms.ComboBox();
            this.inputfile_button = new System.Windows.Forms.Button();
            this.outputfile_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入文件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "存储格式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "输出文件";
            // 
            // filetextBox
            // 
            this.filetextBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.filetextBox.Location = new System.Drawing.Point(191, 35);
            this.filetextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.filetextBox.Name = "filetextBox";
            this.filetextBox.Size = new System.Drawing.Size(218, 30);
            this.filetextBox.TabIndex = 3;
            // 
            // outputtextBox
            // 
            this.outputtextBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.outputtextBox.Location = new System.Drawing.Point(191, 152);
            this.outputtextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.outputtextBox.Name = "outputtextBox";
            this.outputtextBox.Size = new System.Drawing.Size(218, 30);
            this.outputtextBox.TabIndex = 4;
            // 
            // outputcomboBox
            // 
            this.outputcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputcomboBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.outputcomboBox.FormattingEnabled = true;
            this.outputcomboBox.Items.AddRange(new object[] {
            "BSQ",
            "BIL",
            "BIP"});
            this.outputcomboBox.Location = new System.Drawing.Point(191, 93);
            this.outputcomboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.outputcomboBox.Name = "outputcomboBox";
            this.outputcomboBox.Size = new System.Drawing.Size(218, 30);
            this.outputcomboBox.TabIndex = 5;
            // 
            // inputfile_button
            // 
            this.inputfile_button.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputfile_button.Location = new System.Drawing.Point(435, 32);
            this.inputfile_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputfile_button.Name = "inputfile_button";
            this.inputfile_button.Size = new System.Drawing.Size(90, 36);
            this.inputfile_button.TabIndex = 6;
            this.inputfile_button.Text = "浏览";
            this.inputfile_button.UseVisualStyleBackColor = true;
            this.inputfile_button.Click += new System.EventHandler(this.inputfile_button_Click);
            // 
            // outputfile_button
            // 
            this.outputfile_button.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputfile_button.Location = new System.Drawing.Point(435, 148);
            this.outputfile_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.outputfile_button.Name = "outputfile_button";
            this.outputfile_button.Size = new System.Drawing.Size(90, 36);
            this.outputfile_button.TabIndex = 7;
            this.outputfile_button.Text = "浏览";
            this.outputfile_button.UseVisualStyleBackColor = true;
            this.outputfile_button.Click += new System.EventHandler(this.outputfile_button_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(138, 229);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "确定";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(360, 229);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 36);
            this.button4.TabIndex = 9;
            this.button4.Text = "取消";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // storageFormatConversionForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 329);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.outputfile_button);
            this.Controls.Add(this.inputfile_button);
            this.Controls.Add(this.outputcomboBox);
            this.Controls.Add(this.outputtextBox);
            this.Controls.Add(this.filetextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "storageFormatConversionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "影像存储格式转换";
            this.Load += new System.EventHandler(this.StorageFormatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filetextBox;
        private System.Windows.Forms.TextBox outputtextBox;
        private System.Windows.Forms.ComboBox outputcomboBox;
        private System.Windows.Forms.Button inputfile_button;
        private System.Windows.Forms.Button outputfile_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}