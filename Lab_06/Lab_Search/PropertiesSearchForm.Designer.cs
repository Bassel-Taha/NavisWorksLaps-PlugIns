namespace Lab_Search
{
    partial class PropertiesSearchForm
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
            this.listviewModel = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listviewModel
            // 
            this.listviewModel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colID,
            this.colPrice});
            this.listviewModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listviewModel.Location = new System.Drawing.Point(0, 0);
            this.listviewModel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listviewModel.Name = "listviewModel";
            this.listviewModel.Size = new System.Drawing.Size(722, 402);
            this.listviewModel.TabIndex = 43;
            this.listviewModel.UseCompatibleStateImageBehavior = false;
            this.listviewModel.View = System.Windows.Forms.View.Details;
            this.listviewModel.SelectedIndexChanged += new System.EventHandler(this.listviewModel_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "Model Item";
            this.colName.Width = 161;
            // 
            // colID
            // 
            this.colID.Text = "Element ID";
            this.colID.Width = 177;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listviewModel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 402);
            this.panel1.TabIndex = 44;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(12, 429);
            this.txtMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(143, 27);
            this.txtMin.TabIndex = 45;
            this.txtMin.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "<  Price  <";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(440, 434);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 27);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(277, 430);
            this.txtMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(145, 27);
            this.txtMax.TabIndex = 45;
            this.txtMax.Text = "100";
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(587, 434);
            this.btnAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(123, 27);
            this.btnAll.TabIndex = 47;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // PropertiesSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 484);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PropertiesSearchForm";
            this.Text = "PropertiesSearchForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PropertiesSearchForm_FormClosed);
            this.Load += new System.EventHandler(this.PropertiesSearchForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listviewModel;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ColumnHeader colPrice;
    }
}