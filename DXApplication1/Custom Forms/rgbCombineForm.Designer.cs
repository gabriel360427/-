namespace 绿廊智绘.Custom_Forms
{
    partial class rgbCombineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rgbCombineForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GreenBandNum = new System.Windows.Forms.NumericUpDown();
            this.RedBandNum = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BlueBandNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBandNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBandNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBandNum)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BlueBandNum);
            this.groupBox1.Controls.Add(this.GreenBandNum);
            this.groupBox1.Controls.Add(this.RedBandNum);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("等线", 12F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请输入波段组合";
            // 
            // GreenBandNum
            // 
            this.GreenBandNum.Location = new System.Drawing.Point(80, 81);
            this.GreenBandNum.Margin = new System.Windows.Forms.Padding(2);
            this.GreenBandNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GreenBandNum.Name = "GreenBandNum";
            this.GreenBandNum.Size = new System.Drawing.Size(168, 24);
            this.GreenBandNum.TabIndex = 9;
            this.GreenBandNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // RedBandNum
            // 
            this.RedBandNum.Location = new System.Drawing.Point(79, 35);
            this.RedBandNum.Margin = new System.Windows.Forms.Padding(2);
            this.RedBandNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RedBandNum.Name = "RedBandNum";
            this.RedBandNum.Size = new System.Drawing.Size(168, 24);
            this.RedBandNum.TabIndex = 8;
            this.RedBandNum.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("等线", 16F);
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blue：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("等线", 16F);
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("等线", 16F);
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red：";
            // 
            // BlueBandNum
            // 
            this.BlueBandNum.Location = new System.Drawing.Point(79, 129);
            this.BlueBandNum.Margin = new System.Windows.Forms.Padding(2);
            this.BlueBandNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BlueBandNum.Name = "BlueBandNum";
            this.BlueBandNum.Size = new System.Drawing.Size(168, 24);
            this.BlueBandNum.TabIndex = 10;
            this.BlueBandNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rgbCombineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 231);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rgbCombineForm";
            this.Text = "rgbCombineForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBandNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBandNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBandNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown GreenBandNum;
        private System.Windows.Forms.NumericUpDown RedBandNum;
        private System.Windows.Forms.NumericUpDown BlueBandNum;

    }
}