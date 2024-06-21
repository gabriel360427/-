namespace 绿廊智绘.Custom_Forms
{
    partial class createFeatureForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createFeatureForm));
            this.label1 = new System.Windows.Forms.Label();
            this.outputFeatureTextBox = new System.Windows.Forms.TextBox();
            this.outputFeatureBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.featureTypeComboBox = new System.Windows.Forms.ComboBox();
            this.addFieldBtn = new System.Windows.Forms.Button();
            this.removeFieldBtn = new System.Windows.Forms.Button();
            this.featureDataGridView = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAliasName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.spatialReferenceSelectorBtn = new System.Windows.Forms.Button();
            this.spatialReferenceTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.featureDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "输出文件：";
            // 
            // outputFeatureTextBox
            // 
            this.outputFeatureTextBox.Location = new System.Drawing.Point(140, 26);
            this.outputFeatureTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputFeatureTextBox.Name = "outputFeatureTextBox";
            this.outputFeatureTextBox.Size = new System.Drawing.Size(597, 25);
            this.outputFeatureTextBox.TabIndex = 1;
            // 
            // outputFeatureBtn
            // 
            this.outputFeatureBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.outputFeatureBtn.Location = new System.Drawing.Point(767, 21);
            this.outputFeatureBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputFeatureBtn.Name = "outputFeatureBtn";
            this.outputFeatureBtn.Size = new System.Drawing.Size(95, 30);
            this.outputFeatureBtn.TabIndex = 2;
            this.outputFeatureBtn.Text = "浏览";
            this.outputFeatureBtn.UseVisualStyleBackColor = true;
            this.outputFeatureBtn.Click += new System.EventHandler(this.outputFeatureBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(19, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "要素类型：";
            // 
            // featureTypeComboBox
            // 
            this.featureTypeComboBox.FormattingEnabled = true;
            this.featureTypeComboBox.Items.AddRange(new object[] {
            "点",
            "线",
            "面"});
            this.featureTypeComboBox.Location = new System.Drawing.Point(140, 111);
            this.featureTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.featureTypeComboBox.Name = "featureTypeComboBox";
            this.featureTypeComboBox.Size = new System.Drawing.Size(337, 23);
            this.featureTypeComboBox.TabIndex = 4;
            // 
            // addFieldBtn
            // 
            this.addFieldBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addFieldBtn.Location = new System.Drawing.Point(599, 111);
            this.addFieldBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addFieldBtn.Name = "addFieldBtn";
            this.addFieldBtn.Size = new System.Drawing.Size(116, 30);
            this.addFieldBtn.TabIndex = 5;
            this.addFieldBtn.Text = "添加字段";
            this.addFieldBtn.UseVisualStyleBackColor = true;
            this.addFieldBtn.Click += new System.EventHandler(this.addFieldBtn_Click);
            // 
            // removeFieldBtn
            // 
            this.removeFieldBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.removeFieldBtn.Location = new System.Drawing.Point(747, 111);
            this.removeFieldBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeFieldBtn.Name = "removeFieldBtn";
            this.removeFieldBtn.Size = new System.Drawing.Size(116, 30);
            this.removeFieldBtn.TabIndex = 6;
            this.removeFieldBtn.Text = "删除字段";
            this.removeFieldBtn.UseVisualStyleBackColor = true;
            this.removeFieldBtn.Click += new System.EventHandler(this.removeFieldBtn_Click);
            // 
            // featureDataGridView
            // 
            this.featureDataGridView.AllowUserToAddRows = false;
            this.featureDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.featureDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.featureDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.featureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.featureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnAliasName,
            this.columnType,
            this.ColumnWidth,
            this.ColumnPrecision});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.featureDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.featureDataGridView.Location = new System.Drawing.Point(11, 151);
            this.featureDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.featureDataGridView.Name = "featureDataGridView";
            this.featureDataGridView.RowTemplate.Height = 30;
            this.featureDataGridView.Size = new System.Drawing.Size(852, 451);
            this.featureDataGridView.TabIndex = 7;
            this.featureDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.featureDataGridView_EditingControlShowing);
            // 
            // columnName
            // 
            this.columnName.HeaderText = "名称";
            this.columnName.Name = "columnName";
            // 
            // columnAliasName
            // 
            this.columnAliasName.HeaderText = "别名";
            this.columnAliasName.Name = "columnAliasName";
            // 
            // columnType
            // 
            this.columnType.HeaderText = "字段值类型";
            this.columnType.Name = "columnType";
            // 
            // ColumnWidth
            // 
            this.ColumnWidth.HeaderText = "宽度";
            this.ColumnWidth.Name = "ColumnWidth";
            // 
            // ColumnPrecision
            // 
            this.ColumnPrecision.HeaderText = "精度";
            this.ColumnPrecision.Name = "ColumnPrecision";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmBtn.Location = new System.Drawing.Point(140, 624);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(153, 39);
            this.confirmBtn.TabIndex = 8;
            this.confirmBtn.Text = "确定";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancelBtn.Location = new System.Drawing.Point(583, 624);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(153, 39);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(19, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "坐标系：";
            // 
            // spatialReferenceSelectorBtn
            // 
            this.spatialReferenceSelectorBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.spatialReferenceSelectorBtn.Location = new System.Drawing.Point(767, 69);
            this.spatialReferenceSelectorBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spatialReferenceSelectorBtn.Name = "spatialReferenceSelectorBtn";
            this.spatialReferenceSelectorBtn.Size = new System.Drawing.Size(95, 30);
            this.spatialReferenceSelectorBtn.TabIndex = 12;
            this.spatialReferenceSelectorBtn.Text = "选择";
            this.spatialReferenceSelectorBtn.UseVisualStyleBackColor = true;
            this.spatialReferenceSelectorBtn.Click += new System.EventHandler(this.spatialReferenceSelectorBtn_Click);
            // 
            // spatialReferenceTextBox
            // 
            this.spatialReferenceTextBox.Location = new System.Drawing.Point(140, 71);
            this.spatialReferenceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spatialReferenceTextBox.Name = "spatialReferenceTextBox";
            this.spatialReferenceTextBox.Size = new System.Drawing.Size(597, 25);
            this.spatialReferenceTextBox.TabIndex = 13;
            // 
            // createFeatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 674);
            this.Controls.Add(this.spatialReferenceTextBox);
            this.Controls.Add(this.spatialReferenceSelectorBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.featureDataGridView);
            this.Controls.Add(this.removeFieldBtn);
            this.Controls.Add(this.addFieldBtn);
            this.Controls.Add(this.featureTypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputFeatureBtn);
            this.Controls.Add(this.outputFeatureTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "createFeatureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "创建要素";
            ((System.ComponentModel.ISupportInitialize)(this.featureDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputFeatureTextBox;
        private System.Windows.Forms.Button outputFeatureBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox featureTypeComboBox;
        private System.Windows.Forms.Button addFieldBtn;
        private System.Windows.Forms.Button removeFieldBtn;
        private System.Windows.Forms.DataGridView featureDataGridView;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAliasName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecision;
        private System.Windows.Forms.Button spatialReferenceSelectorBtn;
        private System.Windows.Forms.TextBox spatialReferenceTextBox;
    }
}