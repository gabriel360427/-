﻿namespace 城市空间生态格局智能评估系统.Custom_Forms
{
    partial class quickMosaicForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quickMosaicForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.输出类型 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OutputFile = new System.Windows.Forms.Button();
            this.栅格输出框 = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Remove);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入栅格";
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(536, 128);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(112, 42);
            this.Remove.TabIndex = 2;
            this.Remove.Text = "移除";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(536, 60);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(112, 42);
            this.Add.TabIndex = 1;
            this.Add.Text = "添加";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(7, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(523, 136);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.输出类型);
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出类型";
            // 
            // 输出类型
            // 
            this.输出类型.FormattingEnabled = true;
            this.输出类型.Items.AddRange(new object[] {
            "原始数据格式",
            "3通道8位输出"});
            this.输出类型.Location = new System.Drawing.Point(7, 29);
            this.输出类型.Name = "输出类型";
            this.输出类型.Size = new System.Drawing.Size(523, 30);
            this.输出类型.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OutputFile);
            this.groupBox3.Controls.Add(this.栅格输出框);
            this.groupBox3.Location = new System.Drawing.Point(12, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(654, 90);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "栅格输出路径";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // OutputFile
            // 
            this.OutputFile.Location = new System.Drawing.Point(536, 22);
            this.OutputFile.Name = "OutputFile";
            this.OutputFile.Size = new System.Drawing.Size(112, 42);
            this.OutputFile.TabIndex = 3;
            this.OutputFile.Text = "加载";
            this.OutputFile.UseVisualStyleBackColor = true;
            this.OutputFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // 栅格输出框
            // 
            this.栅格输出框.Location = new System.Drawing.Point(7, 29);
            this.栅格输出框.Name = "栅格输出框";
            this.栅格输出框.Size = new System.Drawing.Size(523, 29);
            this.栅格输出框.TabIndex = 0;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(107, 395);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(112, 42);
            this.OK.TabIndex = 3;
            this.OK.Text = "确认";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button4_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(430, 395);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(112, 42);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button5_Click);
            // 
            // 快速拼接
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 444);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "快速拼接";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "快速拼接";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox 输出类型;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button OutputFile;
        private System.Windows.Forms.TextBox 栅格输出框;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
    }
}