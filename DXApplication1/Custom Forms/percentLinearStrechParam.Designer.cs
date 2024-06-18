namespace 城市空间生态格局智能评估系统.Custom_Forms
{
    partial class percentLinearStrechParam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(percentLinearStrechParam));
            this.percentLinearStrechCancel = new System.Windows.Forms.Button();
            this.percentLinearStrechConfirm = new System.Windows.Forms.Button();
            this.numericUpDownPercentLinearStrech = new System.Windows.Forms.NumericUpDown();
            this.labelPercentLinearStrech = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentLinearStrech)).BeginInit();
            this.SuspendLayout();
            // 
            // percentLinearStrechCancel
            // 
            this.percentLinearStrechCancel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.percentLinearStrechCancel.Location = new System.Drawing.Point(163, 68);
            this.percentLinearStrechCancel.Margin = new System.Windows.Forms.Padding(2);
            this.percentLinearStrechCancel.Name = "percentLinearStrechCancel";
            this.percentLinearStrechCancel.Size = new System.Drawing.Size(93, 28);
            this.percentLinearStrechCancel.TabIndex = 15;
            this.percentLinearStrechCancel.Text = "取消";
            this.percentLinearStrechCancel.UseVisualStyleBackColor = true;
            this.percentLinearStrechCancel.Click += new System.EventHandler(this.percentLinearStretchBtnCancel);
            // 
            // percentLinearStrechConfirm
            // 
            this.percentLinearStrechConfirm.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.percentLinearStrechConfirm.Location = new System.Drawing.Point(28, 68);
            this.percentLinearStrechConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.percentLinearStrechConfirm.Name = "percentLinearStrechConfirm";
            this.percentLinearStrechConfirm.Size = new System.Drawing.Size(93, 28);
            this.percentLinearStrechConfirm.TabIndex = 14;
            this.percentLinearStrechConfirm.Text = "确认";
            this.percentLinearStrechConfirm.UseVisualStyleBackColor = true;
            this.percentLinearStrechConfirm.Click += new System.EventHandler(this.percentLinearStretchBtnConfirm);
            // 
            // numericUpDownPercentLinearStrech
            // 
            this.numericUpDownPercentLinearStrech.Location = new System.Drawing.Point(104, 23);
            this.numericUpDownPercentLinearStrech.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownPercentLinearStrech.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownPercentLinearStrech.Name = "numericUpDownPercentLinearStrech";
            this.numericUpDownPercentLinearStrech.Size = new System.Drawing.Size(166, 22);
            this.numericUpDownPercentLinearStrech.TabIndex = 13;
            this.numericUpDownPercentLinearStrech.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // labelPercentLinearStrech
            // 
            this.labelPercentLinearStrech.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPercentLinearStrech.Location = new System.Drawing.Point(21, 25);
            this.labelPercentLinearStrech.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPercentLinearStrech.Name = "labelPercentLinearStrech";
            this.labelPercentLinearStrech.Size = new System.Drawing.Size(79, 21);
            this.labelPercentLinearStrech.TabIndex = 12;
            this.labelPercentLinearStrech.Text = "百分比：";
            // 
            // percentLinearStrechParam
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 119);
            this.Controls.Add(this.percentLinearStrechCancel);
            this.Controls.Add(this.percentLinearStrechConfirm);
            this.Controls.Add(this.numericUpDownPercentLinearStrech);
            this.Controls.Add(this.labelPercentLinearStrech);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "percentLinearStrechParam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "输入线性拉伸百分比";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentLinearStrech)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button percentLinearStrechCancel;
        private System.Windows.Forms.Button percentLinearStrechConfirm;
        private System.Windows.Forms.NumericUpDown numericUpDownPercentLinearStrech;
        private System.Windows.Forms.Label labelPercentLinearStrech;
    }
}