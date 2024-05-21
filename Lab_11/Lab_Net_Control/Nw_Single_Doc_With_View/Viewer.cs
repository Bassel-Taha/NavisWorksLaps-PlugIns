//------------------------------------------------------------------
// NavisWorks Sample code
//------------------------------------------------------------------

// (C) Copyright 2009 by Autodesk Inc.

// Permission to use, copy, modify, and distribute this software in
// object code form for any purpose and without fee is hereby granted,
// provided that the above copyright notice appears in all copies and
// that both that copyright notice and the limited warranty and
// restricted rights notice below appear in all supporting
// documentation.

// AUTODESK PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS.
// AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
// MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE.  AUTODESK
// DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
// UNINTERRUPTED OR ERROR FREE.
//------------------------------------------------------------------
//
// This sample demonstrates a basic Viewer for Navisworks files using
// the Controls part of the API
//
//------------------------------------------------------------------

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

namespace Viewer
{
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           LoadDocument();
        }

        private void LoadDocument()
        {
           #region DocumentControlDocumentTryOpenFile
           //Dialog for selecting the Location of the file toolStripMenuItem1 open
           OpenFileDialog dlg = new OpenFileDialog();

           //Ask user for file location
           if (dlg.ShowDialog() == DialogResult.OK)
           {
              //If the user has selected a valid location, then tell DocumentControl to open the file
              //As DocumentCtrl is linked to ViewControl
              documentControl.Document.TryOpenFile(dlg.FileName);
           }
           #endregion
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset 
            documentControl.Document.Models.ResetAllHidden();
            documentControl.Document.Models.ResetAllPermanentMaterials();
            documentControl.Document.Models.ResetAllPermanentTransforms();             

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Document oDoc = documentControl.Document;
            if (oDoc.CurrentSelection.SelectedItems.Count > 0)
            {
                //bounding box of current selected item
                BoundingBox3D oCurBox = oDoc.CurrentSelection.SelectedItems.BoundingBox();
                //find the model item whose boundingbox intersect with current box
                IEnumerable<ModelItem> oIntersectBoxItems =
                    oDoc.Models.RootItemDescendants.Where(x =>
                            x.HasGeometry && x.Geometry.BoundingBox.Intersects(oCurBox));

                //make transparency of these  items 
                if (oIntersectBoxItems.Count<ModelItem>() > 0)
                {
                    foreach (ModelItem oMI in oIntersectBoxItems)
                        oDoc.CurrentSelection.Add(oMI);
                    ModelItemCollection oCopyMC = new ModelItemCollection();
                    oDoc.CurrentSelection.SelectedItems.CopyTo(oCopyMC);
                    //unselected items
                    oCopyMC.Invert(oDoc);
                    oDoc.Models.OverridePermanentTransparency(oCopyMC, 0.9);
                }
                
            }
            else
            {
                MessageBox.Show("Please select model item!");
            }  
        }

        private void btnOrbit_Click(object sender, EventArgs e)
        {
            //swtich nagivation mode to orbit
            documentControl.Document.Tool.Value = Autodesk.Navisworks.Api.Tool.NavigateOrbit;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //swtich nagivation mode to select
            documentControl.Document.Tool.Value = Autodesk.Navisworks.Api.Tool.Select;

        }
    }



}
