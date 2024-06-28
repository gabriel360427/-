
namespace 绿廊智绘.Custom_Forms
{
    partial class 道路要素变化统计
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.结果框 = new System.Windows.Forms.RichTextBox();
            this.取消 = new System.Windows.Forms.Button();
            this.确定 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.第二期POI加载按钮 = new System.Windows.Forms.Button();
            this.第二景分类文件框 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.第一期POI加载按钮 = new System.Windows.Forms.Button();
            this.第一景分类文件框 = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.结果框);
            this.groupBox3.Location = new System.Drawing.Point(428, 20);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(409, 356);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "统计结果";
            // 
            // 结果框
            // 
            this.结果框.Location = new System.Drawing.Point(8, 30);
            this.结果框.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.结果框.Name = "结果框";
            this.结果框.Size = new System.Drawing.Size(392, 318);
            this.结果框.TabIndex = 0;
            this.结果框.Text = "";
            // 
            // 取消
            // 
            this.取消.Location = new System.Drawing.Point(243, 340);
            this.取消.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.取消.Name = "取消";
            this.取消.Size = new System.Drawing.Size(100, 29);
            this.取消.TabIndex = 15;
            this.取消.Text = "取消";
            this.取消.UseVisualStyleBackColor = true;
            this.取消.Click += new System.EventHandler(this.取消_Click);
            // 
            // 确定
            // 
            this.确定.Location = new System.Drawing.Point(72, 340);
            this.确定.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.确定.Name = "确定";
            this.确定.Size = new System.Drawing.Size(100, 29);
            this.确定.TabIndex = 14;
            this.确定.Text = "确定";
            this.确定.UseVisualStyleBackColor = true;
            this.确定.Click += new System.EventHandler(this.确定_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.第二期POI加载按钮);
            this.groupBox2.Controls.Add(this.第二景分类文件框);
            this.groupBox2.Location = new System.Drawing.Point(24, 178);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(381, 151);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输入第二期道路要素";
            // 
            // 第二期POI加载按钮
            // 
            this.第二期POI加载按钮.Location = new System.Drawing.Point(137, 115);
            this.第二期POI加载按钮.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.第二期POI加载按钮.Name = "第二期POI加载按钮";
            this.第二期POI加载按钮.Size = new System.Drawing.Size(100, 29);
            this.第二期POI加载按钮.TabIndex = 3;
            this.第二期POI加载按钮.Text = "加载";
            this.第二期POI加载按钮.UseVisualStyleBackColor = true;
            this.第二期POI加载按钮.Click += new System.EventHandler(this.第二期POI加载按钮_Click);
            // 
            // 第二景分类文件框
            // 
            this.第二景分类文件框.FormattingEnabled = true;
            this.第二景分类文件框.Location = new System.Drawing.Point(9, 56);
            this.第二景分类文件框.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.第二景分类文件框.Name = "第二景分类文件框";
            this.第二景分类文件框.Size = new System.Drawing.Size(363, 23);
            this.第二景分类文件框.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.第一期POI加载按钮);
            this.groupBox1.Controls.Add(this.第一景分类文件框);
            this.groupBox1.Location = new System.Drawing.Point(24, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(381, 150);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入第一期道路要素";
            // 
            // 第一期POI加载按钮
            // 
            this.第一期POI加载按钮.Location = new System.Drawing.Point(136, 111);
            this.第一期POI加载按钮.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.第一期POI加载按钮.Name = "第一期POI加载按钮";
            this.第一期POI加载按钮.Size = new System.Drawing.Size(100, 29);
            this.第一期POI加载按钮.TabIndex = 2;
            this.第一期POI加载按钮.Text = "加载";
            this.第一期POI加载按钮.UseVisualStyleBackColor = true;
            this.第一期POI加载按钮.Click += new System.EventHandler(this.第一期POI加载按钮_Click);
            // 
            // 第一景分类文件框
            // 
            this.第一景分类文件框.FormattingEnabled = true;
            this.第一景分类文件框.Location = new System.Drawing.Point(9, 52);
            this.第一景分类文件框.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.第一景分类文件框.Name = "第一景分类文件框";
            this.第一景分类文件框.Size = new System.Drawing.Size(363, 23);
            this.第一景分类文件框.TabIndex = 0;
            // 
            // 道路要素变化统计
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 395);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.取消);
            this.Controls.Add(this.确定);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "道路要素变化统计";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "道路要素变化统计";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox 结果框;
        private System.Windows.Forms.Button 取消;
        private System.Windows.Forms.Button 确定;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button 第二期POI加载按钮;
        private System.Windows.Forms.ComboBox 第二景分类文件框;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button 第一期POI加载按钮;
        private System.Windows.Forms.ComboBox 第一景分类文件框;
    }
}