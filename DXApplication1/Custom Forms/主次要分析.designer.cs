
namespace 绿廊智绘.Custom_Forms
{
    partial class 主次要分析
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
            this.分类文件加载按钮 = new System.Windows.Forms.Button();
            this.分类文件加载框 = new System.Windows.Forms.ComboBox();
            this.选择输出位置 = new System.Windows.Forms.GroupBox();
            this.输出位置加载按钮 = new System.Windows.Forms.Button();
            this.输出位置加载框 = new System.Windows.Forms.ComboBox();
            this.确认 = new System.Windows.Forms.Button();
            this.取消 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.选择输出位置.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.分类文件加载按钮);
            this.groupBox1.Controls.Add(this.分类文件加载框);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请输入分类文件";
            // 
            // 分类文件加载按钮
            // 
            this.分类文件加载按钮.Location = new System.Drawing.Point(102, 47);
            this.分类文件加载按钮.Name = "分类文件加载按钮";
            this.分类文件加载按钮.Size = new System.Drawing.Size(75, 23);
            this.分类文件加载按钮.TabIndex = 1;
            this.分类文件加载按钮.Text = "加载";
            this.分类文件加载按钮.UseVisualStyleBackColor = true;
            // 
            // 分类文件加载框
            // 
            this.分类文件加载框.FormattingEnabled = true;
            this.分类文件加载框.Location = new System.Drawing.Point(7, 21);
            this.分类文件加载框.Name = "分类文件加载框";
            this.分类文件加载框.Size = new System.Drawing.Size(267, 20);
            this.分类文件加载框.TabIndex = 0;
            // 
            // 选择输出位置
            // 
            this.选择输出位置.Controls.Add(this.输出位置加载按钮);
            this.选择输出位置.Controls.Add(this.输出位置加载框);
            this.选择输出位置.Location = new System.Drawing.Point(13, 99);
            this.选择输出位置.Name = "选择输出位置";
            this.选择输出位置.Size = new System.Drawing.Size(280, 75);
            this.选择输出位置.TabIndex = 1;
            this.选择输出位置.TabStop = false;
            this.选择输出位置.Text = "选择输出位置";
            // 
            // 输出位置加载按钮
            // 
            this.输出位置加载按钮.Location = new System.Drawing.Point(102, 46);
            this.输出位置加载按钮.Name = "输出位置加载按钮";
            this.输出位置加载按钮.Size = new System.Drawing.Size(75, 23);
            this.输出位置加载按钮.TabIndex = 2;
            this.输出位置加载按钮.Text = "加载";
            this.输出位置加载按钮.UseVisualStyleBackColor = true;
            // 
            // 输出位置加载框
            // 
            this.输出位置加载框.FormattingEnabled = true;
            this.输出位置加载框.Location = new System.Drawing.Point(6, 20);
            this.输出位置加载框.Name = "输出位置加载框";
            this.输出位置加载框.Size = new System.Drawing.Size(267, 20);
            this.输出位置加载框.TabIndex = 2;
            // 
            // 确认
            // 
            this.确认.Location = new System.Drawing.Point(62, 188);
            this.确认.Name = "确认";
            this.确认.Size = new System.Drawing.Size(75, 23);
            this.确认.TabIndex = 2;
            this.确认.Text = "确认";
            this.确认.UseVisualStyleBackColor = true;
            // 
            // 取消
            // 
            this.取消.Location = new System.Drawing.Point(165, 188);
            this.取消.Name = "取消";
            this.取消.Size = new System.Drawing.Size(75, 23);
            this.取消.TabIndex = 3;
            this.取消.Text = "取消";
            this.取消.UseVisualStyleBackColor = true;
            this.取消.Click += new System.EventHandler(this.取消_Click);
            // 
            // 主次要分析
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 223);
            this.Controls.Add(this.取消);
            this.Controls.Add(this.确认);
            this.Controls.Add(this.选择输出位置);
            this.Controls.Add(this.groupBox1);
            this.Name = "主次要分析";
            this.Text = "主次要分析";
            this.groupBox1.ResumeLayout(false);
            this.选择输出位置.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button 分类文件加载按钮;
        private System.Windows.Forms.ComboBox 分类文件加载框;
        private System.Windows.Forms.GroupBox 选择输出位置;
        private System.Windows.Forms.Button 输出位置加载按钮;
        private System.Windows.Forms.ComboBox 输出位置加载框;
        private System.Windows.Forms.Button 确认;
        private System.Windows.Forms.Button 取消;
    }
}