

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

using Autodesk.Navisworks.Api.Controls;
using Autodesk.Navisworks.Api;

namespace Nw_Multi_Doc_without_COM
{
    public partial class Form1 : Form
    {

        private DocumentControl NW_DC1;
        private ViewControl NW_VC1;
        private DocumentControl NW_DC2;
        private ViewControl NW_VC2;

        public Form1()
        {
            InitializeComponent();

            //add document controls and view controls dynamically
            if (this.components == null)
                this.components = new System.ComponentModel.Container();

            NW_DC1 = new DocumentControl(this.components);
            NW_DC2 = new DocumentControl(this.components);

            NW_VC1 = new ViewControl();
            NW_VC1.DocumentControl = NW_DC1;

            NW_VC1.Location = new System.Drawing.Point(Left + 10, Top - 10);
            NW_VC1.Name = "myNWVC1";
            NW_VC1.Size = new System.Drawing.Size(300, 300);



            NW_VC2 = new ViewControl();
            NW_VC2.DocumentControl = NW_DC2;

            NW_VC2.Location = new System.Drawing.Point(Left + 400, Top - 10);
            NW_VC2.Name = "myNWVC2";
            NW_VC2.Size = new System.Drawing.Size(300, 300);


            this.Controls.Add(NW_VC1);
            this.Controls.Add(NW_VC2);

            
        }

        // open document 1
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDDlg = new OpenFileDialog();  
            if (openFileDDlg.ShowDialog() == DialogResult.OK)
            {
               if( NW_DC1.Document.TryOpenFile(openFileDDlg.FileName))
                   NW_DC1.Document.Tool.Value = Tool.Select;                           
            }                         
        }


        // open document 2
        private void button3_Click(object sender, EventArgs e)
        {
             OpenFileDialog openFileDDlg = new OpenFileDialog();  
            if (openFileDDlg.ShowDialog() == DialogResult.OK)
            {
               if( NW_DC2.Document.TryOpenFile(openFileDDlg.FileName))
                   NW_DC2.Document.Tool.Value = Tool.SelectBox;                           
            }            
        }

        //change selection color
        private void button2_Click(object sender, EventArgs e)
        {
            //active document is what the user has just interacted with.
            Document oAcDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;
            MessageBox.Show(oAcDoc.FileName);
            if (oAcDoc.CurrentSelection.SelectedItems.Count > 0)
            {
                oAcDoc.Models.OverridePermanentColor(oAcDoc.CurrentSelection.SelectedItems,
                    Autodesk.Navisworks.Api.Color.Red);
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
