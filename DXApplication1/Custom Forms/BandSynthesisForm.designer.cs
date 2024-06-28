namespace 绿廊智绘.Custom_Forms
{
    partial class BandSynthesisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BandSynthesisForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Remove = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.MoveUp = new System.Windows.Forms.Button();
            this.InputFile = new System.Windows.Forms.Button();
            this.输入文件 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.输出文件框 = new System.Windows.Forms.ComboBox();
            this.OutputFile = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Remove);
            this.groupBox1.Controls.Add(this.MoveDown);
            this.groupBox1.Controls.Add(this.MoveUp);
            this.groupBox1.Controls.Add(this.InputFile);
            this.groupBox1.Controls.Add(this.输入文件);
            this.groupBox1.Font = new System.Drawing.Font("华文中宋", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(726, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件选择";
            // 
            // Remove
            // 
            this.Remove.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Remove.Location = new System.Drawing.Point(601, 295);
            this.Remove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(99, 51);
            this.Remove.TabIndex = 4;
            this.Remove.Text = "移除";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.button4_Click);
            // 
            // MoveDown
            // 
            this.MoveDown.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MoveDown.Location = new System.Drawing.Point(601, 211);
            this.MoveDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(99, 51);
            this.MoveDown.TabIndex = 3;
            this.MoveDown.Text = "下移";
            this.MoveDown.UseVisualStyleBackColor = true;
            this.MoveDown.Click += new System.EventHandler(this.button3_Click);
            // 
            // MoveUp
            // 
            this.MoveUp.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MoveUp.Location = new System.Drawing.Point(601, 122);
            this.MoveUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(99, 51);
            this.MoveUp.TabIndex = 2;
            this.MoveUp.Text = "上移";
            this.MoveUp.UseVisualStyleBackColor = true;
            this.MoveUp.Click += new System.EventHandler(this.button2_Click);
            // 
            // InputFile
            // 
            this.InputFile.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InputFile.Location = new System.Drawing.Point(601, 33);
            this.InputFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputFile.Name = "InputFile";
            this.InputFile.Size = new System.Drawing.Size(99, 51);
            this.InputFile.TabIndex = 1;
            this.InputFile.Text = "加载";
            this.InputFile.UseVisualStyleBackColor = true;
            this.InputFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // 输入文件
            // 
            this.输入文件.FormattingEnabled = true;
            this.输入文件.ItemHeight = 16;
            this.输入文件.Location = new System.Drawing.Point(33, 33);
            this.输入文件.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.输入文件.Name = "输入文件";
            this.输入文件.Size = new System.Drawing.Size(528, 292);
            this.输入文件.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "输出文件";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // 输出文件框
            // 
            this.输出文件框.FormattingEnabled = true;
            this.输出文件框.Location = new System.Drawing.Point(133, 414);
            this.输出文件框.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.输出文件框.Name = "输出文件框";
            this.输出文件框.Size = new System.Drawing.Size(443, 22);
            this.输出文件框.TabIndex = 2;
            this.输出文件框.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // OutputFile
            // 
            this.OutputFile.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OutputFile.Location = new System.Drawing.Point(616, 406);
            this.OutputFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutputFile.Name = "OutputFile";
            this.OutputFile.Size = new System.Drawing.Size(98, 34);
            this.OutputFile.TabIndex = 5;
            this.OutputFile.Text = "加载";
            this.OutputFile.UseVisualStyleBackColor = true;
            this.OutputFile.Click += new System.EventHandler(this.button5_Click);
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OK.Location = new System.Drawing.Point(133, 477);
            this.OK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(99, 51);
            this.OK.TabIndex = 6;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button6_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel.Location = new System.Drawing.Point(478, 477);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(99, 51);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button7_Click);
            // 
            // BandSynthesisForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(753, 543);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.OutputFile);
            this.Controls.Add(this.输出文件框);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "BandSynthesisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "波段合成";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button MoveDown;
        private System.Windows.Forms.Button MoveUp;
        private System.Windows.Forms.Button InputFile;
        private System.Windows.Forms.ListBox 输入文件;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox 输出文件框;
        private System.Windows.Forms.Button OutputFile;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
    }
}