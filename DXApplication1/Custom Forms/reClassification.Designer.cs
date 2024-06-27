namespace 绿廊智绘.Custom_Commands
{
    partial class reClassification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reClassification));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InputFile = new System.Windows.Forms.Button();
            this.栅格数据输入框 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.对新值取反 = new System.Windows.Forms.Button();
            this.删除条目 = new System.Windows.Forms.Button();
            this.添加条目 = new System.Windows.Forms.Button();
            this.唯一值 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.OutputFile = new System.Windows.Forms.Button();
            this.文件输出框 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InputFile);
            this.groupBox1.Controls.Add(this.栅格数据输入框);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(547, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请输入栅格数据";
            // 
            // InputFile
            // 
            this.InputFile.Location = new System.Drawing.Point(419, 14);
            this.InputFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InputFile.Name = "InputFile";
            this.InputFile.Size = new System.Drawing.Size(93, 27);
            this.InputFile.TabIndex = 1;
            this.InputFile.Text = "加载";
            this.InputFile.UseVisualStyleBackColor = true;
            this.InputFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // 栅格数据输入框
            // 
            this.栅格数据输入框.FormattingEnabled = true;
            this.栅格数据输入框.Location = new System.Drawing.Point(5, 18);
            this.栅格数据输入框.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.栅格数据输入框.Name = "栅格数据输入框";
            this.栅格数据输入框.Size = new System.Drawing.Size(389, 22);
            this.栅格数据输入框.TabIndex = 0;
            this.栅格数据输入框.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.栅格数据输入框.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.对新值取反);
            this.groupBox2.Controls.Add(this.删除条目);
            this.groupBox2.Controls.Add(this.添加条目);
            this.groupBox2.Controls.Add(this.唯一值);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(8, 60);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(547, 166);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "重分类";
            // 
            // 对新值取反
            // 
            this.对新值取反.Location = new System.Drawing.Point(419, 124);
            this.对新值取反.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.对新值取反.Name = "对新值取反";
            this.对新值取反.Size = new System.Drawing.Size(93, 27);
            this.对新值取反.TabIndex = 5;
            this.对新值取反.Text = "对新值取反";
            this.对新值取反.UseVisualStyleBackColor = true;
            this.对新值取反.Click += new System.EventHandler(this.button5_Click);
            // 
            // 删除条目
            // 
            this.删除条目.Location = new System.Drawing.Point(419, 93);
            this.删除条目.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.删除条目.Name = "删除条目";
            this.删除条目.Size = new System.Drawing.Size(93, 27);
            this.删除条目.TabIndex = 4;
            this.删除条目.Text = "删除条目";
            this.删除条目.UseVisualStyleBackColor = true;
            this.删除条目.Click += new System.EventHandler(this.button4_Click);
            // 
            // 添加条目
            // 
            this.添加条目.Location = new System.Drawing.Point(419, 61);
            this.添加条目.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.添加条目.Name = "添加条目";
            this.添加条目.Size = new System.Drawing.Size(93, 27);
            this.添加条目.TabIndex = 3;
            this.添加条目.Text = "添加条目";
            this.添加条目.UseVisualStyleBackColor = true;
            this.添加条目.Click += new System.EventHandler(this.button3_Click);
            // 
            // 唯一值
            // 
            this.唯一值.Location = new System.Drawing.Point(419, 29);
            this.唯一值.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.唯一值.Name = "唯一值";
            this.唯一值.Size = new System.Drawing.Size(93, 27);
            this.唯一值.TabIndex = 2;
            this.唯一值.Text = "唯一值";
            this.唯一值.UseVisualStyleBackColor = true;
            this.唯一值.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(5, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 80;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(388, 144);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "旧值";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "新值";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Cancel);
            this.groupBox3.Controls.Add(this.OK);
            this.groupBox3.Controls.Add(this.OutputFile);
            this.groupBox3.Controls.Add(this.文件输出框);
            this.groupBox3.Location = new System.Drawing.Point(8, 230);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(547, 117);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "请设置栅格输出路径";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(315, 71);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(93, 27);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button8_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(101, 71);
            this.OK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(93, 27);
            this.OK.TabIndex = 3;
            this.OK.Text = "确认";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button7_Click);
            // 
            // OutputFile
            // 
            this.OutputFile.Location = new System.Drawing.Point(419, 25);
            this.OutputFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OutputFile.Name = "OutputFile";
            this.OutputFile.Size = new System.Drawing.Size(93, 27);
            this.OutputFile.TabIndex = 2;
            this.OutputFile.Text = "加载";
            this.OutputFile.UseVisualStyleBackColor = true;
            this.OutputFile.Click += new System.EventHandler(this.button6_Click);
            // 
            // 文件输出框
            // 
            this.文件输出框.FormattingEnabled = true;
            this.文件输出框.Location = new System.Drawing.Point(40, 29);
            this.文件输出框.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.文件输出框.Name = "文件输出框";
            this.文件输出框.Size = new System.Drawing.Size(332, 22);
            this.文件输出框.TabIndex = 1;
            this.文件输出框.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // reClassification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 355);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "reClassification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "重分类";
            this.Load += new System.EventHandler(this.重分类_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button InputFile;
        private System.Windows.Forms.ComboBox 栅格数据输入框;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button 对新值取反;
        private System.Windows.Forms.Button 删除条目;
        private System.Windows.Forms.Button 添加条目;
        private System.Windows.Forms.Button 唯一值;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button OutputFile;
        private System.Windows.Forms.ComboBox 文件输出框;
    }
}