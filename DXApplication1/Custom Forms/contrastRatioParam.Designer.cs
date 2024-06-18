namespace 城市空间生态格局智能评估系统.Custom_Forms
{
    partial class contrastRatioParam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contrastRatioParam));
            this.contrastRatioCancel = new System.Windows.Forms.Button();
            this.contrastRatioConfirm = new System.Windows.Forms.Button();
            this.numericUpDownContrastRatio = new System.Windows.Forms.NumericUpDown();
            this.labelContrastRatio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContrastRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // contrastRatioCancel
            // 
            this.contrastRatioCancel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contrastRatioCancel.Location = new System.Drawing.Point(162, 90);
            this.contrastRatioCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.contrastRatioCancel.Name = "contrastRatioCancel";
            this.contrastRatioCancel.Size = new System.Drawing.Size(106, 36);
            this.contrastRatioCancel.TabIndex = 7;
            this.contrastRatioCancel.Text = "取消";
            this.contrastRatioCancel.UseVisualStyleBackColor = true;
            this.contrastRatioCancel.Click += new System.EventHandler(this.contrastRatioBtnCancel);
            // 
            // contrastRatioConfirm
            // 
            this.contrastRatioConfirm.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contrastRatioConfirm.Location = new System.Drawing.Point(22, 90);
            this.contrastRatioConfirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.contrastRatioConfirm.Name = "contrastRatioConfirm";
            this.contrastRatioConfirm.Size = new System.Drawing.Size(106, 36);
            this.contrastRatioConfirm.TabIndex = 6;
            this.contrastRatioConfirm.Text = "确定";
            this.contrastRatioConfirm.UseVisualStyleBackColor = true;
            this.contrastRatioConfirm.Click += new System.EventHandler(this.contrastRatioBtnConfirm);
            // 
            // numericUpDownContrastRatio
            // 
            this.numericUpDownContrastRatio.Location = new System.Drawing.Point(80, 33);
            this.numericUpDownContrastRatio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDownContrastRatio.Name = "numericUpDownContrastRatio";
            this.numericUpDownContrastRatio.Size = new System.Drawing.Size(190, 26);
            this.numericUpDownContrastRatio.TabIndex = 5;
            this.numericUpDownContrastRatio.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // labelContrastRatio
            // 
            this.labelContrastRatio.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelContrastRatio.Location = new System.Drawing.Point(6, 33);
            this.labelContrastRatio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContrastRatio.Name = "labelContrastRatio";
            this.labelContrastRatio.Size = new System.Drawing.Size(82, 27);
            this.labelContrastRatio.TabIndex = 4;
            this.labelContrastRatio.Text = "对比度：";
            // 
            // contrastRatioParam
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(286, 153);
            this.Controls.Add(this.contrastRatioCancel);
            this.Controls.Add(this.contrastRatioConfirm);
            this.Controls.Add(this.numericUpDownContrastRatio);
            this.Controls.Add(this.labelContrastRatio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "contrastRatioParam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "输入对比度";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContrastRatio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button contrastRatioCancel;
        private System.Windows.Forms.Button contrastRatioConfirm;
        private System.Windows.Forms.NumericUpDown numericUpDownContrastRatio;
        private System.Windows.Forms.Label labelContrastRatio;
    }
}