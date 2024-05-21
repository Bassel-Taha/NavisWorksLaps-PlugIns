namespace Lab_Selection
{
    partial class SelectionDockPaneControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddExplicitSet = new System.Windows.Forms.Button();
            this.btnAddsearch = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.checkBoxAutoRefresh = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(17, 15);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(147, 170);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(168, 14);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(174, 42);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "List selection sets";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddExplicitSet
            // 
            this.btnAddExplicitSet.Location = new System.Drawing.Point(168, 58);
            this.btnAddExplicitSet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddExplicitSet.Name = "btnAddExplicitSet";
            this.btnAddExplicitSet.Size = new System.Drawing.Size(174, 42);
            this.btnAddExplicitSet.TabIndex = 4;
            this.btnAddExplicitSet.Text = "Add set from current selection";
            this.btnAddExplicitSet.UseVisualStyleBackColor = true;
            this.btnAddExplicitSet.Click += new System.EventHandler(this.buttonAddSet_Click);
            // 
            // btnAddsearch
            // 
            this.btnAddsearch.Location = new System.Drawing.Point(168, 107);
            this.btnAddsearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddsearch.Name = "btnAddsearch";
            this.btnAddsearch.Size = new System.Drawing.Size(174, 42);
            this.btnAddsearch.TabIndex = 3;
            this.btnAddsearch.Text = "Add set from current search";
            this.btnAddsearch.UseVisualStyleBackColor = true;
            this.btnAddsearch.Click += new System.EventHandler(this.btnAddsearch_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(168, 159);
            this.btnAddGroup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(174, 38);
            this.btnAddGroup.TabIndex = 5;
            this.btnAddGroup.Text = "Group first 2 items";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // checkBoxAutoRefresh
            // 
            this.checkBoxAutoRefresh.AutoSize = true;
            this.checkBoxAutoRefresh.Location = new System.Drawing.Point(17, 199);
            this.checkBoxAutoRefresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBoxAutoRefresh.Name = "checkBoxAutoRefresh";
            this.checkBoxAutoRefresh.Size = new System.Drawing.Size(88, 17);
            this.checkBoxAutoRefresh.TabIndex = 6;
            this.checkBoxAutoRefresh.Text = "auto refresh?";
            this.checkBoxAutoRefresh.UseVisualStyleBackColor = true;
            this.checkBoxAutoRefresh.CheckedChanged += new System.EventHandler(this.checkBoxAutoRefresh_CheckedChanged);
            // 
            // SelectionDockPaneControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxAutoRefresh);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.btnAddExplicitSet);
            this.Controls.Add(this.btnAddsearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SelectionDockPaneControl";
            this.Size = new System.Drawing.Size(349, 242);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddExplicitSet;
        private System.Windows.Forms.Button btnAddsearch;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.CheckBox checkBoxAutoRefresh;
    }
}
