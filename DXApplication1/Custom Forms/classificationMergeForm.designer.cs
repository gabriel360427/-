namespace 城市空间生态格局智能评估系统.Custom_Forms
{
    partial class classificationMergeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(classificationMergeForm));
            this.inputImageBtn = new System.Windows.Forms.Button();
            this.inputImageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputClassListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.outputClassListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.removeRelationBtn = new System.Windows.Forms.Button();
            this.addRelationBtn = new System.Windows.Forms.Button();
            this.mergeInfoListBox = new System.Windows.Forms.ListBox();
            this.resultImageBtn = new System.Windows.Forms.Button();
            this.resultImageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputImageBtn
            // 
            this.inputImageBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputImageBtn.Location = new System.Drawing.Point(666, 20);
            this.inputImageBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputImageBtn.Name = "inputImageBtn";
            this.inputImageBtn.Size = new System.Drawing.Size(119, 38);
            this.inputImageBtn.TabIndex = 23;
            this.inputImageBtn.Text = "浏览";
            this.inputImageBtn.UseVisualStyleBackColor = true;
            this.inputImageBtn.Click += new System.EventHandler(this.inputImageBtn_Click);
            // 
            // inputImageTextBox
            // 
            this.inputImageTextBox.Location = new System.Drawing.Point(147, 25);
            this.inputImageTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputImageTextBox.Name = "inputImageTextBox";
            this.inputImageTextBox.Size = new System.Drawing.Size(515, 26);
            this.inputImageTextBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "输入文件：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputClassListBox);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(11, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(392, 290);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入类别";
            // 
            // inputClassListBox
            // 
            this.inputClassListBox.FormattingEnabled = true;
            this.inputClassListBox.ItemHeight = 20;
            this.inputClassListBox.Location = new System.Drawing.Point(7, 34);
            this.inputClassListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputClassListBox.Name = "inputClassListBox";
            this.inputClassListBox.Size = new System.Drawing.Size(381, 204);
            this.inputClassListBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outputClassListBox);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(411, 76);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(392, 290);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出类别";
            // 
            // outputClassListBox
            // 
            this.outputClassListBox.FormattingEnabled = true;
            this.outputClassListBox.ItemHeight = 20;
            this.outputClassListBox.Location = new System.Drawing.Point(7, 34);
            this.outputClassListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputClassListBox.Name = "outputClassListBox";
            this.outputClassListBox.Size = new System.Drawing.Size(381, 204);
            this.outputClassListBox.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.removeRelationBtn);
            this.groupBox3.Controls.Add(this.addRelationBtn);
            this.groupBox3.Controls.Add(this.mergeInfoListBox);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(11, 373);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(793, 265);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "类别对应关系";
            // 
            // removeRelationBtn
            // 
            this.removeRelationBtn.Location = new System.Drawing.Point(659, 97);
            this.removeRelationBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeRelationBtn.Name = "removeRelationBtn";
            this.removeRelationBtn.Size = new System.Drawing.Size(127, 43);
            this.removeRelationBtn.TabIndex = 2;
            this.removeRelationBtn.Text = "取消对应";
            this.removeRelationBtn.UseVisualStyleBackColor = true;
            this.removeRelationBtn.Click += new System.EventHandler(this.removeRelationBtn_Click);
            // 
            // addRelationBtn
            // 
            this.addRelationBtn.Location = new System.Drawing.Point(659, 34);
            this.addRelationBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addRelationBtn.Name = "addRelationBtn";
            this.addRelationBtn.Size = new System.Drawing.Size(127, 43);
            this.addRelationBtn.TabIndex = 1;
            this.addRelationBtn.Text = "添加对应";
            this.addRelationBtn.UseVisualStyleBackColor = true;
            this.addRelationBtn.Click += new System.EventHandler(this.addRelationBtn_Click);
            // 
            // mergeInfoListBox
            // 
            this.mergeInfoListBox.FormattingEnabled = true;
            this.mergeInfoListBox.ItemHeight = 20;
            this.mergeInfoListBox.Location = new System.Drawing.Point(7, 34);
            this.mergeInfoListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mergeInfoListBox.Name = "mergeInfoListBox";
            this.mergeInfoListBox.Size = new System.Drawing.Size(650, 184);
            this.mergeInfoListBox.TabIndex = 0;
            // 
            // resultImageBtn
            // 
            this.resultImageBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resultImageBtn.Location = new System.Drawing.Point(666, 664);
            this.resultImageBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resultImageBtn.Name = "resultImageBtn";
            this.resultImageBtn.Size = new System.Drawing.Size(119, 38);
            this.resultImageBtn.TabIndex = 29;
            this.resultImageBtn.Text = "浏览";
            this.resultImageBtn.UseVisualStyleBackColor = true;
            this.resultImageBtn.Click += new System.EventHandler(this.resultImageBtn_Click);
            // 
            // resultImageTextBox
            // 
            this.resultImageTextBox.Location = new System.Drawing.Point(147, 670);
            this.resultImageTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resultImageTextBox.Name = "resultImageTextBox";
            this.resultImageTextBox.Size = new System.Drawing.Size(515, 26);
            this.resultImageTextBox.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(25, 670);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "输出文件：";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancelBtn.Location = new System.Drawing.Point(487, 713);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(145, 49);
            this.cancelBtn.TabIndex = 31;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmBtn.Location = new System.Drawing.Point(186, 713);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(145, 49);
            this.confirmBtn.TabIndex = 30;
            this.confirmBtn.Text = "确定";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // classificationMergeForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 785);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.resultImageBtn);
            this.Controls.Add(this.resultImageTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inputImageBtn);
            this.Controls.Add(this.inputImageTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "classificationMergeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "类别合并";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputImageBtn;
        private System.Windows.Forms.TextBox inputImageTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox inputClassListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox outputClassListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button removeRelationBtn;
        private System.Windows.Forms.Button addRelationBtn;
        private System.Windows.Forms.ListBox mergeInfoListBox;
        private System.Windows.Forms.Button resultImageBtn;
        private System.Windows.Forms.TextBox resultImageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button confirmBtn;
    }
}