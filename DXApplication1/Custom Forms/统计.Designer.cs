
namespace 绿廊智绘.Custom_Forms
{
    partial class 统计
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.耕地矢量文件加载按钮 = new System.Windows.Forms.Button();
            this.耕地矢量文件加载框 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.输出路径加载按钮 = new System.Windows.Forms.Button();
            this.输出路径框 = new System.Windows.Forms.ComboBox();
            this.确定 = new System.Windows.Forms.Button();
            this.取消 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.分类文件加载按钮);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入分类文件";
            // 
            // 分类文件加载按钮
            // 
            this.分类文件加载按钮.Location = new System.Drawing.Point(102, 47);
            this.分类文件加载按钮.Name = "分类文件加载按钮";
            this.分类文件加载按钮.Size = new System.Drawing.Size(75, 23);
            this.分类文件加载按钮.TabIndex = 2;
            this.分类文件加载按钮.Text = "加载";
            this.分类文件加载按钮.UseVisualStyleBackColor = true;
            this.分类文件加载按钮.Click += new System.EventHandler(this.分类文件加载按钮_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 20);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.耕地矢量文件加载按钮);
            this.groupBox2.Controls.Add(this.耕地矢量文件加载框);
            this.groupBox2.Location = new System.Drawing.Point(12, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输入耕地矢量文件";
            // 
            // 耕地矢量文件加载按钮
            // 
            this.耕地矢量文件加载按钮.Location = new System.Drawing.Point(103, 44);
            this.耕地矢量文件加载按钮.Name = "耕地矢量文件加载按钮";
            this.耕地矢量文件加载按钮.Size = new System.Drawing.Size(75, 23);
            this.耕地矢量文件加载按钮.TabIndex = 3;
            this.耕地矢量文件加载按钮.Text = "加载";
            this.耕地矢量文件加载按钮.UseVisualStyleBackColor = true;
            // 
            // 耕地矢量文件加载框
            // 
            this.耕地矢量文件加载框.FormattingEnabled = true;
            this.耕地矢量文件加载框.Location = new System.Drawing.Point(7, 20);
            this.耕地矢量文件加载框.Name = "耕地矢量文件加载框";
            this.耕地矢量文件加载框.Size = new System.Drawing.Size(273, 20);
            this.耕地矢量文件加载框.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.输出路径加载按钮);
            this.groupBox3.Controls.Add(this.输出路径框);
            this.groupBox3.Location = new System.Drawing.Point(12, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 80);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "设置输出路径";
            // 
            // 输出路径加载按钮
            // 
            this.输出路径加载按钮.Location = new System.Drawing.Point(103, 44);
            this.输出路径加载按钮.Name = "输出路径加载按钮";
            this.输出路径加载按钮.Size = new System.Drawing.Size(75, 23);
            this.输出路径加载按钮.TabIndex = 3;
            this.输出路径加载按钮.Text = "加载";
            this.输出路径加载按钮.UseVisualStyleBackColor = true;
            // 
            // 输出路径框
            // 
            this.输出路径框.FormattingEnabled = true;
            this.输出路径框.Location = new System.Drawing.Point(7, 20);
            this.输出路径框.Name = "输出路径框";
            this.输出路径框.Size = new System.Drawing.Size(273, 20);
            this.输出路径框.TabIndex = 1;
            // 
            // 确定
            // 
            this.确定.Location = new System.Drawing.Point(49, 271);
            this.确定.Name = "确定";
            this.确定.Size = new System.Drawing.Size(75, 23);
            this.确定.TabIndex = 4;
            this.确定.Text = "确定";
            this.确定.UseVisualStyleBackColor = true;
            // 
            // 取消
            // 
            this.取消.Location = new System.Drawing.Point(175, 271);
            this.取消.Name = "取消";
            this.取消.Size = new System.Drawing.Size(75, 23);
            this.取消.TabIndex = 5;
            this.取消.Text = "取消";
            this.取消.UseVisualStyleBackColor = true;
            this.取消.Click += new System.EventHandler(this.取消_Click);
            // 
            // 统计
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 304);
            this.Controls.Add(this.取消);
            this.Controls.Add(this.确定);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "统计";
            this.Text = "统计";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button 分类文件加载按钮;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox 耕地矢量文件加载框;
        private System.Windows.Forms.Button 耕地矢量文件加载按钮;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button 输出路径加载按钮;
        private System.Windows.Forms.ComboBox 输出路径框;
        private System.Windows.Forms.Button 确定;
        private System.Windows.Forms.Button 取消;
    }
}