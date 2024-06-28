
namespace 绿廊智绘.Custom_Forms
{
    partial class 土地转移矩阵
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(土地转移矩阵));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.第一景影像加载按钮 = new System.Windows.Forms.Button();
            this.第一景影像加载框 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.第二景影像加载 = new System.Windows.Forms.Button();
            this.第二景影像加载框 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.输出位置加载按钮 = new System.Windows.Forms.Button();
            this.输出位置框 = new System.Windows.Forms.ComboBox();
            this.确定 = new System.Windows.Forms.Button();
            this.取消 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.第一景影像加载按钮);
            this.groupBox1.Controls.Add(this.第一景影像加载框);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(468, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请添加第一景遥感影像数据";
            // 
            // 第一景影像加载按钮
            // 
            this.第一景影像加载按钮.Location = new System.Drawing.Point(187, 52);
            this.第一景影像加载按钮.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.第一景影像加载按钮.Name = "第一景影像加载按钮";
            this.第一景影像加载按钮.Size = new System.Drawing.Size(100, 29);
            this.第一景影像加载按钮.TabIndex = 1;
            this.第一景影像加载按钮.Text = "加载";
            this.第一景影像加载按钮.UseVisualStyleBackColor = true;
            this.第一景影像加载按钮.Click += new System.EventHandler(this.第一景影像加载按钮_Click);
            // 
            // 第一景影像加载框
            // 
            this.第一景影像加载框.FormattingEnabled = true;
            this.第一景影像加载框.Location = new System.Drawing.Point(8, 25);
            this.第一景影像加载框.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.第一景影像加载框.Name = "第一景影像加载框";
            this.第一景影像加载框.Size = new System.Drawing.Size(451, 23);
            this.第一景影像加载框.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.第二景影像加载);
            this.groupBox2.Controls.Add(this.第二景影像加载框);
            this.groupBox2.Location = new System.Drawing.Point(16, 111);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(468, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "请添加第二景遥感影像数据";
            // 
            // 第二景影像加载
            // 
            this.第二景影像加载.Location = new System.Drawing.Point(187, 52);
            this.第二景影像加载.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.第二景影像加载.Name = "第二景影像加载";
            this.第二景影像加载.Size = new System.Drawing.Size(100, 29);
            this.第二景影像加载.TabIndex = 2;
            this.第二景影像加载.Text = "加载";
            this.第二景影像加载.UseVisualStyleBackColor = true;
            this.第二景影像加载.Click += new System.EventHandler(this.第二景影像加载_Click);
            // 
            // 第二景影像加载框
            // 
            this.第二景影像加载框.FormattingEnabled = true;
            this.第二景影像加载框.Location = new System.Drawing.Point(8, 25);
            this.第二景影像加载框.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.第二景影像加载框.Name = "第二景影像加载框";
            this.第二景影像加载框.Size = new System.Drawing.Size(451, 23);
            this.第二景影像加载框.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.输出位置加载按钮);
            this.groupBox3.Controls.Add(this.输出位置框);
            this.groupBox3.Location = new System.Drawing.Point(16, 202);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(468, 89);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "请设置输出位置";
            // 
            // 输出位置加载按钮
            // 
            this.输出位置加载按钮.Location = new System.Drawing.Point(187, 52);
            this.输出位置加载按钮.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.输出位置加载按钮.Name = "输出位置加载按钮";
            this.输出位置加载按钮.Size = new System.Drawing.Size(100, 29);
            this.输出位置加载按钮.TabIndex = 2;
            this.输出位置加载按钮.Text = "加载";
            this.输出位置加载按钮.UseVisualStyleBackColor = true;
            this.输出位置加载按钮.Click += new System.EventHandler(this.输出位置加载按钮_Click);
            // 
            // 输出位置框
            // 
            this.输出位置框.FormattingEnabled = true;
            this.输出位置框.Location = new System.Drawing.Point(8, 25);
            this.输出位置框.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.输出位置框.Name = "输出位置框";
            this.输出位置框.Size = new System.Drawing.Size(451, 23);
            this.输出位置框.TabIndex = 2;
            this.输出位置框.SelectedIndexChanged += new System.EventHandler(this.输出位置框_SelectedIndexChanged);
            // 
            // 确定
            // 
            this.确定.Location = new System.Drawing.Point(116, 301);
            this.确定.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.确定.Name = "确定";
            this.确定.Size = new System.Drawing.Size(100, 29);
            this.确定.TabIndex = 3;
            this.确定.Text = "确定";
            this.确定.UseVisualStyleBackColor = true;
            // 
            // 取消
            // 
            this.取消.Location = new System.Drawing.Point(283, 301);
            this.取消.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.取消.Name = "取消";
            this.取消.Size = new System.Drawing.Size(100, 29);
            this.取消.TabIndex = 4;
            this.取消.Text = "取消";
            this.取消.UseVisualStyleBackColor = true;
            this.取消.Click += new System.EventHandler(this.取消_Click);
            // 
            // 土地转移矩阵
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 345);
            this.Controls.Add(this.取消);
            this.Controls.Add(this.确定);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "土地转移矩阵";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "土地转移矩阵";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button 第一景影像加载按钮;
        private System.Windows.Forms.ComboBox 第一景影像加载框;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button 第二景影像加载;
        private System.Windows.Forms.ComboBox 第二景影像加载框;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button 输出位置加载按钮;
        private System.Windows.Forms.ComboBox 输出位置框;
        private System.Windows.Forms.Button 确定;
        private System.Windows.Forms.Button 取消;
    }
}