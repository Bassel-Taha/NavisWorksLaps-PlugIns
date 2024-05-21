namespace Lab_Viewpoint
{
    partial class ViewpointForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonIn = new System.Windows.Forms.Button();
            this.buttonOut = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.textStep = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textRotStep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textRotZ = new System.Windows.Forms.TextBox();
            this.textRotY = new System.Windows.Forms.TextBox();
            this.textRotX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRotateCW = new System.Windows.Forms.Button();
            this.buttonRotateACW = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnAddView = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonIn);
            this.groupBox2.Controls.Add(this.buttonOut);
            this.groupBox2.Controls.Add(this.buttonUp);
            this.groupBox2.Controls.Add(this.buttonDown);
            this.groupBox2.Controls.Add(this.buttonRight);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonLeft);
            this.groupBox2.Controls.Add(this.textStep);
            this.groupBox2.Location = new System.Drawing.Point(173, 32);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(174, 179);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera Position";
            // 
            // buttonIn
            // 
            this.buttonIn.Location = new System.Drawing.Point(94, 110);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(32, 31);
            this.buttonIn.TabIndex = 11;
            this.buttonIn.Text = "-Z";
            this.buttonIn.UseVisualStyleBackColor = true;
            this.buttonIn.Click += new System.EventHandler(this.buttonIn_Click);
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(94, 65);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(32, 31);
            this.buttonOut.TabIndex = 10;
            this.buttonOut.Text = "+Z";
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(56, 64);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(32, 31);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.Text = "+Y";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(56, 110);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(32, 31);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.Text = "-Y";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(11, 64);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(32, 31);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.Text = "+X";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Step";
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(11, 110);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(32, 31);
            this.buttonLeft.TabIndex = 5;
            this.buttonLeft.Text = "-X";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // textStep
            // 
            this.textStep.Location = new System.Drawing.Point(56, 28);
            this.textStep.Name = "textStep";
            this.textStep.Size = new System.Drawing.Size(72, 20);
            this.textStep.TabIndex = 8;
            this.textStep.Text = "1.0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textRotStep);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textRotZ);
            this.groupBox1.Controls.Add(this.textRotY);
            this.groupBox1.Controls.Add(this.textRotX);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.buttonRotateCW);
            this.groupBox1.Controls.Add(this.buttonRotateACW);
            this.groupBox1.Location = new System.Drawing.Point(173, 251);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(174, 157);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rotation Camera";
            // 
            // textRotStep
            // 
            this.textRotStep.Location = new System.Drawing.Point(50, 71);
            this.textRotStep.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textRotStep.Name = "textRotStep";
            this.textRotStep.Size = new System.Drawing.Size(28, 20);
            this.textRotStep.TabIndex = 19;
            this.textRotStep.Text = "0.1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Step";
            // 
            // textRotZ
            // 
            this.textRotZ.Location = new System.Drawing.Point(132, 36);
            this.textRotZ.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textRotZ.Name = "textRotZ";
            this.textRotZ.Size = new System.Drawing.Size(36, 20);
            this.textRotZ.TabIndex = 17;
            this.textRotZ.Text = "0.0";
            // 
            // textRotY
            // 
            this.textRotY.Location = new System.Drawing.Point(91, 36);
            this.textRotY.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textRotY.Name = "textRotY";
            this.textRotY.Size = new System.Drawing.Size(36, 20);
            this.textRotY.TabIndex = 16;
            this.textRotY.Text = "0.0";
            // 
            // textRotX
            // 
            this.textRotX.Location = new System.Drawing.Point(48, 36);
            this.textRotX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textRotX.Name = "textRotX";
            this.textRotX.Size = new System.Drawing.Size(36, 20);
            this.textRotX.TabIndex = 15;
            this.textRotX.Text = "1.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Axis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Z";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "X";
            // 
            // buttonRotateCW
            // 
            this.buttonRotateCW.Location = new System.Drawing.Point(16, 103);
            this.buttonRotateCW.Name = "buttonRotateCW";
            this.buttonRotateCW.Size = new System.Drawing.Size(52, 50);
            this.buttonRotateCW.TabIndex = 6;
            this.buttonRotateCW.Text = "Rotate CW";
            this.buttonRotateCW.UseVisualStyleBackColor = true;
            this.buttonRotateCW.Click += new System.EventHandler(this.buttonRotateCW_Click);
            // 
            // buttonRotateACW
            // 
            this.buttonRotateACW.Location = new System.Drawing.Point(100, 105);
            this.buttonRotateACW.Name = "buttonRotateACW";
            this.buttonRotateACW.Size = new System.Drawing.Size(51, 50);
            this.buttonRotateACW.TabIndex = 7;
            this.buttonRotateACW.Text = "Rotate ACW";
            this.buttonRotateACW.UseVisualStyleBackColor = true;
            this.buttonRotateACW.Click += new System.EventHandler(this.buttonRotateACW_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(-4, 23);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(150, 157);
            this.treeView1.TabIndex = 26;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // btnAddView
            // 
            this.btnAddView.Location = new System.Drawing.Point(14, 197);
            this.btnAddView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddView.Name = "btnAddView";
            this.btnAddView.Size = new System.Drawing.Size(115, 37);
            this.btnAddView.TabIndex = 27;
            this.btnAddView.Text = "Add saved viewpoint";
            this.btnAddView.UseVisualStyleBackColor = true;
            this.btnAddView.Click += new System.EventHandler(this.btnAddView_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(14, 244);
            this.btnAddGroup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(115, 37);
            this.btnAddGroup.TabIndex = 27;
            this.btnAddGroup.Text = "Group first 2 items";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 354);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "auto refresh list ?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.btnAddGroup);
            this.groupBox3.Controls.Add(this.btnAddView);
            this.groupBox3.Controls.Add(this.treeView1);
            this.groupBox3.Location = new System.Drawing.Point(9, 32);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(160, 380);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "saved viewpoints";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(14, 296);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 37);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "List viewports";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ViewpointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 419);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ViewpointForm";
            this.Text = "view point";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.TextBox textStep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textRotStep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textRotZ;
        private System.Windows.Forms.TextBox textRotY;
        private System.Windows.Forms.TextBox textRotX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonRotateCW;
        private System.Windows.Forms.Button buttonRotateACW;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnAddView;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRefresh;

    }
}