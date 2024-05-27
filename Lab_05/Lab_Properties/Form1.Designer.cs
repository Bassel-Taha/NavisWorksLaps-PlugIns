namespace Lab_Properties
{
    partial class Form1
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
            this.PropsText = new System.Windows.Forms.RichTextBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.CatDisplayNameTextBox = new System.Windows.Forms.TextBox();
            this.PropDisplayNameTextBox = new System.Windows.Forms.TextBox();
            this.CatDisplayName = new System.Windows.Forms.Label();
            this.PropDisplayName = new System.Windows.Forms.Label();
            this.PropertiesOfSelectedElement = new System.Windows.Forms.Label();
            this.Find = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.SelectElemetnsButton = new System.Windows.Forms.Button();
            this.PropValueTextBox = new System.Windows.Forms.TextBox();
            this.ValueLable = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PropsText
            // 
            this.PropsText.Location = new System.Drawing.Point(23, 33);
            this.PropsText.Name = "PropsText";
            this.PropsText.Size = new System.Drawing.Size(310, 148);
            this.PropsText.TabIndex = 4;
            this.PropsText.Text = "";
            this.PropsText.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(47, 373);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(76, 39);
            this.ExportButton.TabIndex = 3;
            this.ExportButton.Text = "Export to TXT file";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.Export_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(259, 373);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(74, 39);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // CatDisplayNameTextBox
            // 
            this.CatDisplayNameTextBox.Location = new System.Drawing.Point(34, 222);
            this.CatDisplayNameTextBox.Name = "CatDisplayNameTextBox";
            this.CatDisplayNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.CatDisplayNameTextBox.TabIndex = 5;
            this.CatDisplayNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PropDisplayNameTextBox
            // 
            this.PropDisplayNameTextBox.Location = new System.Drawing.Point(243, 222);
            this.PropDisplayNameTextBox.Name = "PropDisplayNameTextBox";
            this.PropDisplayNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.PropDisplayNameTextBox.TabIndex = 5;
            // 
            // CatDisplayName
            // 
            this.CatDisplayName.AutoSize = true;
            this.CatDisplayName.Location = new System.Drawing.Point(31, 197);
            this.CatDisplayName.Name = "CatDisplayName";
            this.CatDisplayName.Size = new System.Drawing.Size(114, 13);
            this.CatDisplayName.TabIndex = 6;
            this.CatDisplayName.Text = "Category DisplayName";
            this.CatDisplayName.Click += new System.EventHandler(this.label1_Click);
            // 
            // PropDisplayName
            // 
            this.PropDisplayName.AutoSize = true;
            this.PropDisplayName.Location = new System.Drawing.Point(240, 197);
            this.PropDisplayName.Name = "PropDisplayName";
            this.PropDisplayName.Size = new System.Drawing.Size(108, 13);
            this.PropDisplayName.TabIndex = 6;
            this.PropDisplayName.Text = "PropertyDisplayName";
            this.PropDisplayName.Click += new System.EventHandler(this.label1_Click);
            // 
            // PropertiesOfSelectedElement
            // 
            this.PropertiesOfSelectedElement.AutoSize = true;
            this.PropertiesOfSelectedElement.Location = new System.Drawing.Point(31, 9);
            this.PropertiesOfSelectedElement.Name = "PropertiesOfSelectedElement";
            this.PropertiesOfSelectedElement.Size = new System.Drawing.Size(189, 13);
            this.PropertiesOfSelectedElement.TabIndex = 6;
            this.PropertiesOfSelectedElement.Text = "All Properties OF the Selected Element";
            this.PropertiesOfSelectedElement.Click += new System.EventHandler(this.label1_Click);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(146, 249);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(74, 39);
            this.Find.TabIndex = 3;
            this.Find.Text = "Find Property";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // GreenButton
            // 
            this.GreenButton.Location = new System.Drawing.Point(283, 304);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(74, 39);
            this.GreenButton.TabIndex = 3;
            this.GreenButton.Text = "Green Elements";
            this.GreenButton.UseVisualStyleBackColor = true;
            this.GreenButton.Click += new System.EventHandler(this.Find_Click);
            // 
            // SelectElemetnsButton
            // 
            this.SelectElemetnsButton.Location = new System.Drawing.Point(203, 304);
            this.SelectElemetnsButton.Name = "SelectElemetnsButton";
            this.SelectElemetnsButton.Size = new System.Drawing.Size(74, 39);
            this.SelectElemetnsButton.TabIndex = 3;
            this.SelectElemetnsButton.Text = "Select Elements by ID";
            this.SelectElemetnsButton.UseVisualStyleBackColor = true;
            this.SelectElemetnsButton.Click += new System.EventHandler(this.SelectItems_Click);
            // 
            // PropValueTextBox
            // 
            this.PropValueTextBox.Location = new System.Drawing.Point(88, 314);
            this.PropValueTextBox.Name = "PropValueTextBox";
            this.PropValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.PropValueTextBox.TabIndex = 5;
            this.PropValueTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // ValueLable
            // 
            this.ValueLable.AutoSize = true;
            this.ValueLable.Location = new System.Drawing.Point(31, 317);
            this.ValueLable.Name = "ValueLable";
            this.ValueLable.Size = new System.Drawing.Size(34, 13);
            this.ValueLable.TabIndex = 6;
            this.ValueLable.Text = "Value";
            this.ValueLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(339, 85);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(43, 39);
            this.RefreshButton.TabIndex = 3;
            this.RefreshButton.Text = "Get";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 436);
            this.Controls.Add(this.PropDisplayName);
            this.Controls.Add(this.PropertiesOfSelectedElement);
            this.Controls.Add(this.ValueLable);
            this.Controls.Add(this.CatDisplayName);
            this.Controls.Add(this.PropValueTextBox);
            this.Controls.Add(this.PropDisplayNameTextBox);
            this.Controls.Add(this.CatDisplayNameTextBox);
            this.Controls.Add(this.PropsText);
            this.Controls.Add(this.SelectElemetnsButton);
            this.Controls.Add(this.GreenButton);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.ExportButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox PropsText;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox CatDisplayNameTextBox;
        private System.Windows.Forms.TextBox PropDisplayNameTextBox;
        private System.Windows.Forms.Label CatDisplayName;
        private System.Windows.Forms.Label PropDisplayName;
        private System.Windows.Forms.Label PropertiesOfSelectedElement;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.Button SelectElemetnsButton;
        private System.Windows.Forms.TextBox PropValueTextBox;
        private System.Windows.Forms.Label ValueLable;
        private System.Windows.Forms.Button RefreshButton;
    }
}