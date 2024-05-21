#region Copyright
//
// Copyright (C) 2010-2015 by Autodesk, Inc.
//
// Permission to use, copy, modify, and distribute this software in
// object code form for any purpose and without fee is hereby granted,
// provided that the above copyright notice appears in all copies and
// that both that copyright notice and the limited warranty and
// restricted rights notice below appear in all supporting
// documentation.
//
// AUTODESK PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS.
// AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
// MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE.  AUTODESK, INC.
// DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
// UNINTERRUPTED OR ERROR FREE.
//
// Use, duplication, or disclosure by the U.S. Government is subject to
// restrictions set forth in FAR 52.227-19 (Commercial Computer
// Software - Restricted Rights) and DFAR 252.227-7013(c)(1)(ii)
// (Rights in Technical Data and Computer Software), as applicable.
#endregion // Copyright

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Collections;

using Autodesk.Navisworks.Api;


namespace Lab_Document
{
    public partial class Document_Form : Form
    {
        public Document_Form()
        {
            InitializeComponent();
        }

        private string folder;

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            //  browser a folder to list all available files
            FolderBrowserDialog folderBDlg = new FolderBrowserDialog();
            if (folderBDlg.ShowDialog() == DialogResult.OK)
            {
                folder = folderBDlg.SelectedPath;

                listBox_Files.Items.Clear();
                listBox_Append.Items.Clear();
                listBox_Merge.Items.Clear();

                DirectoryInfo di = new DirectoryInfo(folderBDlg.SelectedPath);
                FileInfo[] fiA = di.GetFiles("*.*", SearchOption.TopDirectoryOnly);
                foreach (FileInfo file in fiA)
                {
                    listBox_Files.Items.Add(file.Name);
                }

            }

            //create a new Navisworks file
            Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;
            oDoc.Clear();

        }

        private void btnAppendAdd_Click(object sender, EventArgs e)
        {
            //prepare the files to be appended
            if (listBox_Files.SelectedItem != null &&
                !listBox_Append.Items.Contains(listBox_Files.SelectedItem))
            {
                listBox_Append.Items.Add(listBox_Files.SelectedItem);
                listBox_Files.Items.Remove(listBox_Files.SelectedItem);
            }
        }

        private void btnAppendRemove_Click(object sender, EventArgs e)
        {
            //prepare the files to be appended
            if (listBox_Append.SelectedItem != null &&
               !listBox_Files.Items.Contains(listBox_Append.SelectedItem))
            {
                listBox_Files.Items.Add(listBox_Append.SelectedItem);
                listBox_Append.Items.Remove(listBox_Append.SelectedItem);
            }
        }

        private void btnMergeAdd_Click(object sender, EventArgs e)
        {
            //prepare the files to be merged
            if (listBox_Files.SelectedItem != null &&
                !listBox_Merge.Items.Contains(listBox_Files.SelectedItem))
            {
                listBox_Merge.Items.Add(listBox_Files.SelectedItem);
                listBox_Files.Items.Remove(listBox_Files.SelectedItem);
            }
        }

        private void btnMergeRemove_Click(object sender, EventArgs e)
        {
            //prepare the files to be merged
            if (listBox_Merge.SelectedItem != null &&
                !listBox_Files.Items.Contains(listBox_Merge.SelectedItem.ToString()))
            {
                listBox_Files.Items.Add(listBox_Merge.SelectedItem);
                listBox_Merge.Items.Remove(listBox_Merge.SelectedItem);
            }
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            //publish file
            SaveFileDialog oDlg = new SaveFileDialog();
            oDlg.AddExtension = true;
            oDlg.Filter = "nwd(*.nwd)|*.nwd";

            if (oDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;

                PublishProperties properties = new PublishProperties();

                //Set the published file's properties            
                properties.Title = textBox_title.Text;
                properties.Subject = textBox_subject.Text;
                properties.Author = textBox_author.Text;
                properties.Publisher = textBox_publisher.Text;
                properties.PublishedFor = textBox_publisherFor.Text;
                properties.Copyright = textBox_copyright.Text;
                properties.Keywords = textBox_keywords.Text;
                properties.Comments = textBox_comments.Text;
                properties.SetPassword(textBox_password.Text);

                properties.ExpiryDate = dateTimePicker1.Value;

                properties.DisplayAtPassword = checkBox_displaypass.Checked;
                properties.AllowResave = checkBox_allowResave.Checked;
                properties.DisplayOnOpen = checkBox_displayonopen.Checked;
                properties.EmbedTextures = checkBox_embedtexture.Checked;
                properties.EmbedDatabaseProperties = checkBox_embedDpro.Checked;
                properties.PreventObjectPropertyExport = checkBox_embedobjpro.Checked;
                properties.PublishDate = DateTime.Now;


                //create the published NWD
                try
                {
                    oDoc.PublishFile(oDlg.FileName, properties);
                }
                catch (Autodesk.Navisworks.Api.DocumentFileException)
                {
                    //Failed to publish ile, perhaps try saving in 
                    //an alternate location using the exception safe method
                    if (!Autodesk.Navisworks.Api.Application.ActiveDocument.TryPublishFile(oDlg.FileName, properties))
                    {
                        MessageBox.Show("Failed to publish the file");
                    }
                }
                catch (System.InvalidOperationException)
                {
                    MessageBox.Show("Document is clear");
                }

            }
        }



        private void btnAppend_Merge_Click(object sender, EventArgs e)
        {
            Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;

            //Append files
            foreach (string eachAppendFile in listBox_Append.Items)
            {
                try
                {
                    // append each file one by one
                    oDoc.AppendFile(folder + "\\" + eachAppendFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to append " + folder + "\\" + eachAppendFile);
                }
            }

            //Merge files

            foreach (string file in listBox_Merge.Items)
            {
                try
                {
                    // merge each file one by one
                    oDoc.MergeFile(folder + "\\" + file);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to merge " + folder + "\\" + file);
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox_embedtexture_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox_Files_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
