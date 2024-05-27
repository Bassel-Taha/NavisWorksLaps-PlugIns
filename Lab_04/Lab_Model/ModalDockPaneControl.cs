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
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
 
using Autodesk.Navisworks.Api;



namespace Lab_Model
{
    public partial class ModalDockPaneControl : UserControl
    {
        public ModalDockPaneControl()
        {
            InitializeComponent();
        }

        //recurs the model tree and add them to the tree control one by one
        //with the prefix and postfix string
        private void recurse(ModelItem oParentModItem, TreeNode oParentNode)
        {
            foreach (ModelItem oSubModItem in oParentModItem.Children)
            {
                string nodeName;
                if (checkBox_Numeric.Checked)
                {
                    nodeName = oParentNode.Index.ToString();
                }
                else
                {
                    if (string.IsNullOrEmpty(oSubModItem.DisplayName))
                    {
                        //add prefix string
                        nodeName = textBox_Prefix.Text
                                       + " " + oSubModItem.ClassDisplayName + " " +
                                       textBox_Postfix.Text;
                    }
                    else
                    {
                        nodeName = textBox_Prefix.Text +
                                      " " + oSubModItem.DisplayName + " " +
                                      textBox_Postfix.Text;
                    } 
                }

                TreeNode oSubNode = oParentNode.Nodes.Add(nodeName);

                if (checkBox_Numeric.Checked)
                {
                    oSubNode.Name += oSubNode.Index.ToString(); ;
                }

                //store the model item with this tree node
                oSubNode.Tag = oSubModItem;
                recurse(oSubModItem, oSubNode);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;

            //  to simplify the sample, we test a document with only one modal.
            if (oDoc.Models.Count ==1 )
            {
                treeView1.Nodes.Clear();

                //get root item
                ModelItem rootItem = Autodesk.Navisworks.Api.Application.ActiveDocument.Models[0].RootItem;
                string nodeName; 
                if (checkBox_Numeric.Checked)
                {
                    nodeName = " root ";                                
                }
                else
                {
                    if (string.IsNullOrEmpty(rootItem.DisplayName))
                    {
                        nodeName = textBox_Prefix.Text
                                       + " " + rootItem.ClassDisplayName + " " +
                                       textBox_Postfix.Text;
                    }
                    else
                    {
                        nodeName = textBox_Prefix.Text
                                        + " " + rootItem.DisplayName + " " +
                                        textBox_Postfix.Text;
                    }
                }

                //add roo item as a node to the tree control
                TreeNode oRootNode = treeView1.Nodes.Add(nodeName);
                //attach root item to this tree node
                oRootNode.Tag = rootItem;
                //recurs from root item
                recurse(rootItem, oRootNode); 
            }
        }

      
        //when mouse hovering the tree control
        private void treeView1_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            //which item is being hovered
            ModelItem item = e.Node.Tag as ModelItem;

            //display some information of this item in tootip
            string tipString = item.DisplayName; 

            if (item.IsInsert)
                tipString += " \n[Insert]";
            if (item.IsLayer)
                tipString += " \n[IsLayer]";
            if (item.IsHidden)
                tipString += " \n[IsHidden]";
            if (item.IsComposite)
                tipString += " \n[IsComposite]";
            if (item.HasGeometry)
                tipString += " \n[HasGeometry]"; 
           
            e.Node.ToolTipText = tipString; 
        }

        //when a tree node is selected, highlight the corresponding model items
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                ModelItem item = e.Node.Tag as ModelItem;
                ModelItemCollection oColl = new ModelItemCollection();
                oColl.Add(item);
                Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;
                oDoc.CurrentSelection.Clear();
                oDoc.CurrentSelection.CopyFrom(oColl);
                        
            }
        }

        private Autodesk.Navisworks.Api.Color oColor = 
                    Autodesk.Navisworks.Api.Color.FromByteRGB(255,0,0); 

        //set a color 
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog oDlg = new ColorDialog();
            if (oDlg.ShowDialog() == DialogResult.OK)
            {
                oColor = Autodesk.Navisworks.Api.Color.FromByteRGB(oDlg.Color.R,
                    oDlg.Color.G,
                    oDlg.Color.B);
                btnColor.BackColor = oDlg.Color;
            }
        }

        //override color of the selected items
        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;
            if (oDoc.CurrentSelection.SelectedItems.Count != 0)
            {
                oDoc.Models.OverridePermanentColor(oDoc.CurrentSelection.SelectedItems,
                                                    oColor);
            }
        }

        //hide the selected items
        private void btnHideSelf_Click(object sender, EventArgs e)
        {
            Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;
            if (oDoc.CurrentSelection.SelectedItems.Count != 0)
            {
                ModelItemCollection hidden = new ModelItemCollection();       
                hidden.AddRange(oDoc.CurrentSelection.SelectedItems);
                oDoc.Models.SetHidden(hidden, true); 
            }
        }

        //hide the un-selected items
        private void btnHideOther_Click(object sender, EventArgs e)
        {
            Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;
            if (oDoc.CurrentSelection.SelectedItems.Count != 0)
            {
                Hide_Trans_Others(oDoc.CurrentSelection.SelectedItems);
            }
        }

        //make the  un-selected items transparency
        private void btnTransOther_Click(object sender, EventArgs e)
        {
             Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;
             if (oDoc.CurrentSelection.SelectedItems.Count != 0)
             {
                 Hide_Trans_Others(oDoc.CurrentSelection.SelectedItems,false);
             }

        }
        


         void Hide_Trans_Others(ModelItemCollection oSelf,
                                     bool hide_or_trans = true)
        {
            //get un-selected items
            ModelItemCollection hidden = new ModelItemCollection();
            oSelf.CopyTo(hidden);
            hidden.Invert(Autodesk.Navisworks.Api.Application.ActiveDocument);
             

            //hide the remaining items
            if (hide_or_trans)
            {
                Autodesk.Navisworks.Api.Application.ActiveDocument.Models.
               SetHidden(hidden, true);
            }
            else
            {
                Autodesk.Navisworks.Api.Application.ActiveDocument.Models.
                    OverridePermanentTransparency(hidden, trackBar1.Value / 100.0);
            }

        }

        private void ADNDockPaneUserControl_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;
        }

        //reset all attributes of the geometries
        private void btnResetAll_Click(object sender, EventArgs e)
        {
            Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;
            oDoc.Models.ResetAllHidden();
            oDoc.Models.ResetAllPermanentMaterials();
            oDoc.Models.ResetAllPermanentTransforms();
        }

        //override transform of the selected items
        private void btnTransform_Click(object sender, EventArgs e)
        {
                Document doc = Autodesk.Navisworks.Api.Application.MainDocument;

                // current selection
                ModelItemCollection coll = doc.CurrentSelection.SelectedItems;
                if (coll.Count > 0)
                {

                    //build a vector for moving
                    Vector3D oNewVector3d = new Vector3D(1, 1, 0);

                    // optional way 1: orthogonal transforms + translation
                    //*********
                    //build an identity matrix which represents orthogonal transforms
                    Matrix3 oNewIndentityM = new Matrix3();

                    //create a transform from a matrix with a vector.
                    Transform3D oNewOverrideTrans = new Transform3D(oNewIndentityM, oNewVector3d);
                    //***********

                    // optional way 2: direct static function
                    //********
                    //Transform3D oNewOverrideTrans1 = Transform3D.CreateTranslation(oNewVector3d);
                    //*********

                    //override the transformation of the selection
                    doc.Models.OverridePermanentTransform(coll, oNewOverrideTrans, true);
            }  

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
