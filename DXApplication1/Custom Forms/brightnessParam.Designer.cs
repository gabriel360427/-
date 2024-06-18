namespace 城市空间生态格局智能评估系统.Custom_Forms
{
    partial class brightnessParam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(brightnessParam));
            this.labelBrightness = new System.Windows.Forms.Label();
            this.numericUpDownBrightness = new System.Windows.Forms.NumericUpDown();
            this.brightnessConfirm = new System.Windows.Forms.Button();
            this.brightnessCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBrightness
            // 
            this.labelBrightness.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBrightness.Location = new System.Drawing.Point(18, 36);
            this.labelBrightness.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBrightness.Name = "labelBrightness";
            this.labelBrightness.Size = new System.Drawing.Size(66, 27);
            this.labelBrightness.TabIndex = 0;
            this.labelBrightness.Text = "亮度：";
            // 
            // numericUpDownBrightness
            // 
            this.numericUpDownBrightness.Location = new System.Drawing.Point(78, 36);
            this.numericUpDownBrightness.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDownBrightness.Name = "numericUpDownBrightness";
            this.numericUpDownBrightness.Size = new System.Drawing.Size(190, 26);
            this.numericUpDownBrightness.TabIndex = 1;
            this.numericUpDownBrightness.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // brightnessConfirm
            // 
            this.brightnessConfirm.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.brightnessConfirm.Location = new System.Drawing.Point(22, 90);
            this.brightnessConfirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.brightnessConfirm.Name = "brightnessConfirm";
            this.brightnessConfirm.Size = new System.Drawing.Size(106, 36);
            this.brightnessConfirm.TabIndex = 2;
            this.brightnessConfirm.Text = "确定";
            this.brightnessConfirm.UseVisualStyleBackColor = true;
            this.brightnessConfirm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.brightnessBtnConfirm);
            // 
            // brightnessCancel
            // 
            this.brightnessCancel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.brightnessCancel.Location = new System.Drawing.Point(158, 90);
            this.brightnessCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.brightnessCancel.Name = "brightnessCancel";
            this.brightnessCancel.Size = new System.Drawing.Size(106, 36);
            this.brightnessCancel.TabIndex = 3;
            this.brightnessCancel.Text = "取消";
            this.brightnessCancel.UseVisualStyleBackColor = true;
            this.brightnessCancel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.brightnessBtnCancel);
            // 
            // brightnessParam
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 153);
            this.Controls.Add(this.brightnessCancel);
            this.Controls.Add(this.brightnessConfirm);
            this.Controls.Add(this.numericUpDownBrightness);
            this.Controls.Add(this.labelBrightness);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "brightnessParam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "输入亮度值";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrightness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBrightness;
        private System.Windows.Forms.NumericUpDown numericUpDownBrightness;
        private System.Windows.Forms.Button brightnessConfirm;
        private System.Windows.Forms.Button brightnessCancel;
    }
}