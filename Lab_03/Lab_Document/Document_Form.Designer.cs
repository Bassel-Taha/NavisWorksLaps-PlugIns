namespace Lab_Document
{
    partial class Document_Form
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
            this.listBox_Files = new System.Windows.Forms.ListBox();
            this.listBox_Append = new System.Windows.Forms.ListBox();
            this.listBox_Merge = new System.Windows.Forms.ListBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnAppendAdd = new System.Windows.Forms.Button();
            this.btnAppendRemove = new System.Windows.Forms.Button();
            this.btnMergeRemove = new System.Windows.Forms.Button();
            this.btnMergeAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPublish = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox_embedobjpro = new System.Windows.Forms.CheckBox();
            this.checkBox_embedDpro = new System.Windows.Forms.CheckBox();
            this.checkBox_embedtexture = new System.Windows.Forms.CheckBox();
            this.checkBox_displayonopen = new System.Windows.Forms.CheckBox();
            this.checkBox_displaypass = new System.Windows.Forms.CheckBox();
            this.checkBox_allowResave = new System.Windows.Forms.CheckBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_comments = new System.Windows.Forms.TextBox();
            this.textBox_keywords = new System.Windows.Forms.TextBox();
            this.textBox_copyright = new System.Windows.Forms.TextBox();
            this.textBox_publisherFor = new System.Windows.Forms.TextBox();
            this.textBox_publisher = new System.Windows.Forms.TextBox();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.textBox_subject = new System.Windows.Forms.TextBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAppendMerge = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Files
            // 
            this.listBox_Files.FormattingEnabled = true;
            this.listBox_Files.Location = new System.Drawing.Point(16, 42);
            this.listBox_Files.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBox_Files.Name = "listBox_Files";
            this.listBox_Files.Size = new System.Drawing.Size(140, 251);
            this.listBox_Files.TabIndex = 0;
            this.listBox_Files.SelectedIndexChanged += new System.EventHandler(this.listBox_Files_SelectedIndexChanged);
            // 
            // listBox_Append
            // 
            this.listBox_Append.FormattingEnabled = true;
            this.listBox_Append.Location = new System.Drawing.Point(218, 29);
            this.listBox_Append.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBox_Append.Name = "listBox_Append";
            this.listBox_Append.Size = new System.Drawing.Size(89, 121);
            this.listBox_Append.TabIndex = 1;
            // 
            // listBox_Merge
            // 
            this.listBox_Merge.FormattingEnabled = true;
            this.listBox_Merge.Location = new System.Drawing.Point(218, 172);
            this.listBox_Merge.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBox_Merge.Name = "listBox_Merge";
            this.listBox_Merge.Size = new System.Drawing.Size(89, 121);
            this.listBox_Merge.TabIndex = 2;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(16, 10);
            this.btnBrowser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(98, 26);
            this.btnBrowser.TabIndex = 3;
            this.btnBrowser.Text = "Browse";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnAppendAdd
            // 
            this.btnAppendAdd.Location = new System.Drawing.Point(164, 67);
            this.btnAppendAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAppendAdd.Name = "btnAppendAdd";
            this.btnAppendAdd.Size = new System.Drawing.Size(38, 22);
            this.btnAppendAdd.TabIndex = 4;
            this.btnAppendAdd.Text = ">>";
            this.btnAppendAdd.UseVisualStyleBackColor = true;
            this.btnAppendAdd.Click += new System.EventHandler(this.btnAppendAdd_Click);
            // 
            // btnAppendRemove
            // 
            this.btnAppendRemove.Location = new System.Drawing.Point(164, 113);
            this.btnAppendRemove.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAppendRemove.Name = "btnAppendRemove";
            this.btnAppendRemove.Size = new System.Drawing.Size(38, 22);
            this.btnAppendRemove.TabIndex = 5;
            this.btnAppendRemove.Text = "<<";
            this.btnAppendRemove.UseVisualStyleBackColor = true;
            this.btnAppendRemove.Click += new System.EventHandler(this.btnAppendRemove_Click);
            // 
            // btnMergeRemove
            // 
            this.btnMergeRemove.Location = new System.Drawing.Point(164, 255);
            this.btnMergeRemove.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMergeRemove.Name = "btnMergeRemove";
            this.btnMergeRemove.Size = new System.Drawing.Size(38, 22);
            this.btnMergeRemove.TabIndex = 7;
            this.btnMergeRemove.Text = "<<";
            this.btnMergeRemove.UseVisualStyleBackColor = true;
            this.btnMergeRemove.Click += new System.EventHandler(this.btnMergeRemove_Click);
            // 
            // btnMergeAdd
            // 
            this.btnMergeAdd.Location = new System.Drawing.Point(164, 209);
            this.btnMergeAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMergeAdd.Name = "btnMergeAdd";
            this.btnMergeAdd.Size = new System.Drawing.Size(38, 22);
            this.btnMergeAdd.TabIndex = 6;
            this.btnMergeAdd.Text = ">>";
            this.btnMergeAdd.UseVisualStyleBackColor = true;
            this.btnMergeAdd.Click += new System.EventHandler(this.btnMergeAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Append";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Merge";
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(113, 387);
            this.btnPublish.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(89, 42);
            this.btnPublish.TabIndex = 10;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(217, 387);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 42);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Keywords ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 237);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Comments";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 177);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Copyright ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.checkBox_embedobjpro);
            this.groupBox1.Controls.Add(this.checkBox_embedDpro);
            this.groupBox1.Controls.Add(this.checkBox_embedtexture);
            this.groupBox1.Controls.Add(this.checkBox_displayonopen);
            this.groupBox1.Controls.Add(this.checkBox_displaypass);
            this.groupBox1.Controls.Add(this.checkBox_allowResave);
            this.groupBox1.Controls.Add(this.textBox_password);
            this.groupBox1.Controls.Add(this.textBox_comments);
            this.groupBox1.Controls.Add(this.textBox_keywords);
            this.groupBox1.Controls.Add(this.textBox_copyright);
            this.groupBox1.Controls.Add(this.textBox_publisherFor);
            this.groupBox1.Controls.Add(this.textBox_publisher);
            this.groupBox1.Controls.Add(this.textBox_author);
            this.groupBox1.Controls.Add(this.textBox_subject);
            this.groupBox1.Controls.Add(this.textBox_title);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(331, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(228, 478);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Publish Options";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 302);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(119, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // checkBox_embedobjpro
            // 
            this.checkBox_embedobjpro.AutoSize = true;
            this.checkBox_embedobjpro.Location = new System.Drawing.Point(7, 460);
            this.checkBox_embedobjpro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_embedobjpro.Name = "checkBox_embedobjpro";
            this.checkBox_embedobjpro.Size = new System.Drawing.Size(172, 17);
            this.checkBox_embedobjpro.TabIndex = 20;
            this.checkBox_embedobjpro.Text = "Prevent Object Property Export";
            this.checkBox_embedobjpro.UseVisualStyleBackColor = true;
            // 
            // checkBox_embedDpro
            // 
            this.checkBox_embedDpro.AutoSize = true;
            this.checkBox_embedDpro.Location = new System.Drawing.Point(7, 439);
            this.checkBox_embedDpro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_embedDpro.Name = "checkBox_embedDpro";
            this.checkBox_embedDpro.Size = new System.Drawing.Size(158, 17);
            this.checkBox_embedDpro.TabIndex = 20;
            this.checkBox_embedDpro.Text = "Embed Database Properties";
            this.checkBox_embedDpro.UseVisualStyleBackColor = true;
            // 
            // checkBox_embedtexture
            // 
            this.checkBox_embedtexture.AutoSize = true;
            this.checkBox_embedtexture.Location = new System.Drawing.Point(7, 417);
            this.checkBox_embedtexture.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_embedtexture.Name = "checkBox_embedtexture";
            this.checkBox_embedtexture.Size = new System.Drawing.Size(103, 17);
            this.checkBox_embedtexture.TabIndex = 20;
            this.checkBox_embedtexture.Text = "Embed Textures";
            this.checkBox_embedtexture.UseVisualStyleBackColor = true;
            this.checkBox_embedtexture.CheckedChanged += new System.EventHandler(this.checkBox_embedtexture_CheckedChanged);
            // 
            // checkBox_displayonopen
            // 
            this.checkBox_displayonopen.AutoSize = true;
            this.checkBox_displayonopen.Location = new System.Drawing.Point(7, 391);
            this.checkBox_displayonopen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_displayonopen.Name = "checkBox_displayonopen";
            this.checkBox_displayonopen.Size = new System.Drawing.Size(104, 17);
            this.checkBox_displayonopen.TabIndex = 20;
            this.checkBox_displayonopen.Text = "Display on Open";
            this.checkBox_displayonopen.UseVisualStyleBackColor = true;
            // 
            // checkBox_displaypass
            // 
            this.checkBox_displaypass.AutoSize = true;
            this.checkBox_displaypass.Location = new System.Drawing.Point(7, 348);
            this.checkBox_displaypass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_displaypass.Name = "checkBox_displaypass";
            this.checkBox_displaypass.Size = new System.Drawing.Size(124, 17);
            this.checkBox_displaypass.TabIndex = 20;
            this.checkBox_displaypass.Text = "Display As Password";
            this.checkBox_displaypass.UseVisualStyleBackColor = true;
            // 
            // checkBox_allowResave
            // 
            this.checkBox_allowResave.AutoSize = true;
            this.checkBox_allowResave.Location = new System.Drawing.Point(7, 369);
            this.checkBox_allowResave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_allowResave.Name = "checkBox_allowResave";
            this.checkBox_allowResave.Size = new System.Drawing.Size(96, 17);
            this.checkBox_allowResave.TabIndex = 20;
            this.checkBox_allowResave.Text = "Allow Re-Save";
            this.checkBox_allowResave.UseVisualStyleBackColor = true;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(106, 266);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(109, 20);
            this.textBox_password.TabIndex = 18;
            // 
            // textBox_comments
            // 
            this.textBox_comments.Location = new System.Drawing.Point(106, 231);
            this.textBox_comments.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_comments.Name = "textBox_comments";
            this.textBox_comments.Size = new System.Drawing.Size(109, 20);
            this.textBox_comments.TabIndex = 17;
            // 
            // textBox_keywords
            // 
            this.textBox_keywords.Location = new System.Drawing.Point(106, 196);
            this.textBox_keywords.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_keywords.Name = "textBox_keywords";
            this.textBox_keywords.Size = new System.Drawing.Size(109, 20);
            this.textBox_keywords.TabIndex = 17;
            // 
            // textBox_copyright
            // 
            this.textBox_copyright.Location = new System.Drawing.Point(106, 169);
            this.textBox_copyright.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_copyright.Name = "textBox_copyright";
            this.textBox_copyright.Size = new System.Drawing.Size(109, 20);
            this.textBox_copyright.TabIndex = 17;
            // 
            // textBox_publisherFor
            // 
            this.textBox_publisherFor.Location = new System.Drawing.Point(106, 143);
            this.textBox_publisherFor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_publisherFor.Name = "textBox_publisherFor";
            this.textBox_publisherFor.Size = new System.Drawing.Size(109, 20);
            this.textBox_publisherFor.TabIndex = 17;
            // 
            // textBox_publisher
            // 
            this.textBox_publisher.Location = new System.Drawing.Point(106, 112);
            this.textBox_publisher.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_publisher.Name = "textBox_publisher";
            this.textBox_publisher.Size = new System.Drawing.Size(109, 20);
            this.textBox_publisher.TabIndex = 17;
            // 
            // textBox_author
            // 
            this.textBox_author.Location = new System.Drawing.Point(106, 85);
            this.textBox_author.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(109, 20);
            this.textBox_author.TabIndex = 17;
            // 
            // textBox_subject
            // 
            this.textBox_subject.Location = new System.Drawing.Point(106, 58);
            this.textBox_subject.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_subject.Name = "textBox_subject";
            this.textBox_subject.Size = new System.Drawing.Size(109, 20);
            this.textBox_subject.TabIndex = 17;
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(106, 29);
            this.textBox_title.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(109, 20);
            this.textBox_title.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Title ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 61);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Subject ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 151);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "PublishedFor ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 120);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Publisher ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 439);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "ExpiryDate ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 269);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Password";
            // 
            // btnAppendMerge
            // 
            this.btnAppendMerge.Location = new System.Drawing.Point(16, 387);
            this.btnAppendMerge.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAppendMerge.Name = "btnAppendMerge";
            this.btnAppendMerge.Size = new System.Drawing.Size(89, 42);
            this.btnAppendMerge.TabIndex = 10;
            this.btnAppendMerge.Text = "Append_Merge";
            this.btnAppendMerge.UseVisualStyleBackColor = true;
            this.btnAppendMerge.Click += new System.EventHandler(this.btnAppend_Merge_Click);
            // 
            // Document_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAppendMerge);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMergeRemove);
            this.Controls.Add(this.btnMergeAdd);
            this.Controls.Add(this.btnAppendRemove);
            this.Controls.Add(this.btnAppendAdd);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.listBox_Merge);
            this.Controls.Add(this.listBox_Append);
            this.Controls.Add(this.listBox_Files);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Document_Form";
            this.Text = "Document Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Files;
        private System.Windows.Forms.ListBox listBox_Append;
        private System.Windows.Forms.ListBox listBox_Merge;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnAppendAdd;
        private System.Windows.Forms.Button btnAppendRemove;
        private System.Windows.Forms.Button btnMergeRemove;
        private System.Windows.Forms.Button btnMergeAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_comments;
        private System.Windows.Forms.TextBox textBox_keywords;
        private System.Windows.Forms.TextBox textBox_copyright;
        private System.Windows.Forms.TextBox textBox_publisherFor;
        private System.Windows.Forms.TextBox textBox_publisher;
        private System.Windows.Forms.TextBox textBox_author;
        private System.Windows.Forms.TextBox textBox_subject;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.CheckBox checkBox_embedobjpro;
        private System.Windows.Forms.CheckBox checkBox_embedDpro;
        private System.Windows.Forms.CheckBox checkBox_embedtexture;
        private System.Windows.Forms.CheckBox checkBox_displayonopen;
        private System.Windows.Forms.CheckBox checkBox_allowResave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox_displaypass;
        private System.Windows.Forms.Button btnAppendMerge;
    }
}