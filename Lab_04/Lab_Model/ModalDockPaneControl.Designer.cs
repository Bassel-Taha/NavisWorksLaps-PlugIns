namespace Lab_Model
{
    partial class ModalDockPaneControl
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
            this.checkBox_Numeric = new System.Windows.Forms.CheckBox();
            this.textBox_Prefix = new System.Windows.Forms.TextBox();
            this.btnHideOther = new System.Windows.Forms.Button();
            this.btnHideSelf = new System.Windows.Forms.Button();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.btnTransOther = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Postfix = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTransform = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.HotTracking = true;
            this.treeView1.Location = new System.Drawing.Point(13, 34);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(180, 417);
            this.treeView1.TabIndex = 4;
            this.treeView1.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.treeView1_NodeMouseHover);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(37, 111);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(151, 28);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Generate Selection Tree";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // checkBox_Numeric
            // 
            this.checkBox_Numeric.AutoSize = true;
            this.checkBox_Numeric.Location = new System.Drawing.Point(38, 81);
            this.checkBox_Numeric.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_Numeric.Name = "checkBox_Numeric";
            this.checkBox_Numeric.Size = new System.Drawing.Size(134, 17);
            this.checkBox_Numeric.TabIndex = 6;
            this.checkBox_Numeric.Text = "  Numeric of Hierarchy ";
            this.checkBox_Numeric.UseVisualStyleBackColor = true;
            // 
            // textBox_Prefix
            // 
            this.textBox_Prefix.Location = new System.Drawing.Point(92, 21);
            this.textBox_Prefix.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_Prefix.Name = "textBox_Prefix";
            this.textBox_Prefix.Size = new System.Drawing.Size(96, 20);
            this.textBox_Prefix.TabIndex = 7;
            // 
            // btnHideOther
            // 
            this.btnHideOther.Location = new System.Drawing.Point(12, 107);
            this.btnHideOther.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHideOther.Name = "btnHideOther";
            this.btnHideOther.Size = new System.Drawing.Size(157, 28);
            this.btnHideOther.TabIndex = 8;
            this.btnHideOther.Text = "Hide Others";
            this.btnHideOther.UseVisualStyleBackColor = true;
            this.btnHideOther.Click += new System.EventHandler(this.btnHideOther_Click);
            // 
            // btnHideSelf
            // 
            this.btnHideSelf.Location = new System.Drawing.Point(12, 70);
            this.btnHideSelf.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHideSelf.Name = "btnHideSelf";
            this.btnHideSelf.Size = new System.Drawing.Size(157, 28);
            this.btnHideSelf.TabIndex = 8;
            this.btnHideSelf.Text = "Hide Self";
            this.btnHideSelf.UseVisualStyleBackColor = true;
            this.btnHideSelf.Click += new System.EventHandler(this.btnHideSelf_Click);
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(12, 33);
            this.btnChangeColor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(157, 28);
            this.btnChangeColor.TabIndex = 8;
            this.btnChangeColor.Text = "Override Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(12, 216);
            this.btnResetAll.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(157, 28);
            this.btnResetAll.TabIndex = 8;
            this.btnResetAll.Text = "ResetAll";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // btnTransOther
            // 
            this.btnTransOther.Location = new System.Drawing.Point(12, 145);
            this.btnTransOther.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTransOther.Name = "btnTransOther";
            this.btnTransOther.Size = new System.Drawing.Size(157, 28);
            this.btnTransOther.TabIndex = 8;
            this.btnTransOther.Text = "Blur Others";
            this.btnTransOther.UseVisualStyleBackColor = true;
            this.btnTransOther.Click += new System.EventHandler(this.btnTransOther_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(170, 145);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(58, 45);
            this.trackBar1.TabIndex = 9;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Red;
            this.btnColor.Location = new System.Drawing.Point(180, 33);
            this.btnColor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(25, 23);
            this.btnColor.TabIndex = 11;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Selection Tree";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Prefix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Postfix";
            // 
            // textBox_Postfix
            // 
            this.textBox_Postfix.Location = new System.Drawing.Point(92, 48);
            this.textBox_Postfix.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_Postfix.Name = "textBox_Postfix";
            this.textBox_Postfix.Size = new System.Drawing.Size(96, 20);
            this.textBox_Postfix.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTransform);
            this.groupBox1.Controls.Add(this.btnHideOther);
            this.groupBox1.Controls.Add(this.btnHideSelf);
            this.groupBox1.Controls.Add(this.btnTransOther);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.btnColor);
            this.groupBox1.Controls.Add(this.btnResetAll);
            this.groupBox1.Controls.Add(this.btnChangeColor);
            this.groupBox1.Location = new System.Drawing.Point(212, 174);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(232, 276);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maipulate Attribute ";
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(13, 181);
            this.btnTransform.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(157, 28);
            this.btnTransform.TabIndex = 12;
            this.btnTransform.Text = "Transform";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Prefix);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.checkBox_Numeric);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_Postfix);
            this.groupBox2.Location = new System.Drawing.Point(212, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(205, 148);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generate Tree";
            // 
            // ModalDockPaneControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ModalDockPaneControl";
            this.Size = new System.Drawing.Size(452, 483);
            this.Load += new System.EventHandler(this.ADNDockPaneUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.CheckBox checkBox_Numeric;
        private System.Windows.Forms.TextBox textBox_Prefix;
        private System.Windows.Forms.Button btnHideOther;
        private System.Windows.Forms.Button btnHideSelf;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.Button btnTransOther;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Postfix;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTransform;
    }
}
