
namespace 绿廊智绘.Custom_Forms
{
    partial class 参考建议
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "边缘密度(ED)",
            "反映土地利用效率，可能与较高的经济富裕程度相关"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "斑块密度(PD)",
            "反映景观整体的异质性与破碎度,与经济富裕相关"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "斑块数量(NP)",
            "反映景观空间格局，描述景观的异质性，其值的大小与景观的破碎度有正相关性"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "聚集指数(AI)",
            "考察了每一种景观类型斑块间的连通性"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "斑块类型面积(CA)",
            "制约以此类型拼块作为聚居地的物种的丰度、数量、食物链及其次生种的繁殖"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "最大斑块指数(LPI)",
            "确定景观中的优势斑块类型，间接反映人类活动干扰的方向和大小 "}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "香农均匀度(SHEI)",
            "反映出景观受到一种或少数几种优势拼块类型所支配"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "香农多样性(SHDI)",
            "反映景观异质性，强调稀有拼块类型对信息的贡献"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "蔓延度指数(CONTAG)",
            "一定程度可反映人类的干扰程度，反映经济水平发展"}, -1);
            this.listView1 = new System.Windows.Forms.ListView();
            this.景观格局指数 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.生态富民意义 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.景观格局指数,
            this.生态富民意义});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1071, 357);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // 景观格局指数
            // 
            this.景观格局指数.Text = "景观格局指数";
            this.景观格局指数.Width = 217;
            // 
            // 生态富民意义
            // 
            this.生态富民意义.Text = "生态富民意义";
            this.生态富民意义.Width = 715;
            // 
            // 参考建议
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 357);
            this.Controls.Add(this.listView1);
            this.Name = "参考建议";
            this.Text = "指数选取参考建议";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 景观格局指数;
        private System.Windows.Forms.ColumnHeader 生态富民意义;
    }
}