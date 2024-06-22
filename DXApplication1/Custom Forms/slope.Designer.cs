
namespace 绿廊智绘.Custom_Forms
{
    partial class slope
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DEM输入框 = new System.Windows.Forms.ComboBox();
            this.DEM加载按钮 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.输出路径加载框 = new System.Windows.Forms.Button();
            this.输出路径框 = new System.Windows.Forms.ComboBox();
            this.确定 = new System.Windows.Forms.Button();
            this.取消 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DEM加载按钮);
            this.groupBox1.Controls.Add(this.DEM输入框);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入DEM数据";
            // 
            // DEM输入框
            // 
            this.DEM输入框.FormattingEnabled = true;
            this.DEM输入框.Location = new System.Drawing.Point(6, 30);
            this.DEM输入框.Name = "DEM输入框";
            this.DEM输入框.Size = new System.Drawing.Size(296, 20);
            this.DEM输入框.TabIndex = 1;
            this.DEM输入框.SelectedIndexChanged += new System.EventHandler(this.DEM输入框_SelectedIndexChanged);
            // 
            // DEM加载按钮
            // 
            this.DEM加载按钮.Location = new System.Drawing.Point(308, 30);
            this.DEM加载按钮.Name = "DEM加载按钮";
            this.DEM加载按钮.Size = new System.Drawing.Size(75, 23);
            this.DEM加载按钮.TabIndex = 1;
            this.DEM加载按钮.Text = "加载";
            this.DEM加载按钮.UseVisualStyleBackColor = true;
            this.DEM加载按钮.Click += new System.EventHandler(this.DEM加载按钮_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.输出路径加载框);
            this.groupBox2.Controls.Add(this.输出路径框);
            this.groupBox2.Location = new System.Drawing.Point(27, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选择输出路径";
            // 
            // 输出路径加载框
            // 
            this.输出路径加载框.Location = new System.Drawing.Point(308, 30);
            this.输出路径加载框.Name = "输出路径加载框";
            this.输出路径加载框.Size = new System.Drawing.Size(75, 23);
            this.输出路径加载框.TabIndex = 1;
            this.输出路径加载框.Text = "浏览";
            this.输出路径加载框.UseVisualStyleBackColor = true;
            this.输出路径加载框.Click += new System.EventHandler(this.输出路径加载框_Click);
            // 
            // 输出路径框
            // 
            this.输出路径框.FormattingEnabled = true;
            this.输出路径框.Location = new System.Drawing.Point(6, 30);
            this.输出路径框.Name = "输出路径框";
            this.输出路径框.Size = new System.Drawing.Size(296, 20);
            this.输出路径框.TabIndex = 1;
            // 
            // 确定
            // 
            this.确定.Location = new System.Drawing.Point(101, 185);
            this.确定.Name = "确定";
            this.确定.Size = new System.Drawing.Size(75, 23);
            this.确定.TabIndex = 2;
            this.确定.Text = "确定";
            this.确定.UseVisualStyleBackColor = true;
            this.确定.Click += new System.EventHandler(this.确定_Click);
            // 
            // 取消
            // 
            this.取消.Location = new System.Drawing.Point(254, 185);
            this.取消.Name = "取消";
            this.取消.Size = new System.Drawing.Size(75, 23);
            this.取消.TabIndex = 3;
            this.取消.Text = "取消";
            this.取消.UseVisualStyleBackColor = true;
            this.取消.Click += new System.EventHandler(this.取消_Click);
            // 
            // slope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 220);
            this.Controls.Add(this.取消);
            this.Controls.Add(this.确定);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "slope";
            this.Text = "坡度处理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox DEM输入框;
        private System.Windows.Forms.Button DEM加载按钮;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button 输出路径加载框;
        private System.Windows.Forms.ComboBox 输出路径框;
        private System.Windows.Forms.Button 确定;
        private System.Windows.Forms.Button 取消;
    }
}