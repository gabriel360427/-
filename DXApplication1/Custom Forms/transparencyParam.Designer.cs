namespace 绿廊智绘.Custom_Forms
{
    partial class transparencyParam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transparencyParam));
            this.transparencyCancel = new System.Windows.Forms.Button();
            this.transparencyConfirm = new System.Windows.Forms.Button();
            this.numericUpDownTransparency = new System.Windows.Forms.NumericUpDown();
            this.labelTransparency = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransparency)).BeginInit();
            this.SuspendLayout();
            // 
            // transparencyCancel
            // 
            this.transparencyCancel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.transparencyCancel.Location = new System.Drawing.Point(197, 104);
            this.transparencyCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.transparencyCancel.Name = "transparencyCancel";
            this.transparencyCancel.Size = new System.Drawing.Size(106, 36);
            this.transparencyCancel.TabIndex = 11;
            this.transparencyCancel.Text = "取消";
            this.transparencyCancel.UseVisualStyleBackColor = true;
            this.transparencyCancel.Click += new System.EventHandler(this.transparencyBtnCancel);
            // 
            // transparencyConfirm
            // 
            this.transparencyConfirm.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.transparencyConfirm.Location = new System.Drawing.Point(55, 104);
            this.transparencyConfirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.transparencyConfirm.Name = "transparencyConfirm";
            this.transparencyConfirm.Size = new System.Drawing.Size(106, 36);
            this.transparencyConfirm.TabIndex = 10;
            this.transparencyConfirm.Text = "确定";
            this.transparencyConfirm.UseVisualStyleBackColor = true;
            this.transparencyConfirm.Click += new System.EventHandler(this.transparencyBtnConfirm);
            // 
            // numericUpDownTransparency
            // 
            this.numericUpDownTransparency.Location = new System.Drawing.Point(127, 46);
            this.numericUpDownTransparency.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDownTransparency.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownTransparency.Name = "numericUpDownTransparency";
            this.numericUpDownTransparency.Size = new System.Drawing.Size(190, 26);
            this.numericUpDownTransparency.TabIndex = 9;
            this.numericUpDownTransparency.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // labelTransparency
            // 
            this.labelTransparency.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTransparency.Location = new System.Drawing.Point(40, 49);
            this.labelTransparency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTransparency.Name = "labelTransparency";
            this.labelTransparency.Size = new System.Drawing.Size(82, 27);
            this.labelTransparency.TabIndex = 8;
            this.labelTransparency.Text = "透明度：";
            // 
            // transparencyParam
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 197);
            this.Controls.Add(this.transparencyCancel);
            this.Controls.Add(this.transparencyConfirm);
            this.Controls.Add(this.numericUpDownTransparency);
            this.Controls.Add(this.labelTransparency);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "transparencyParam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "输入透明度";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransparency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button transparencyCancel;
        private System.Windows.Forms.Button transparencyConfirm;
        private System.Windows.Forms.NumericUpDown numericUpDownTransparency;
        private System.Windows.Forms.Label labelTransparency;
    }
}