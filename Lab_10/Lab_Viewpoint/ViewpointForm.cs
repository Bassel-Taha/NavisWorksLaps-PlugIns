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

using Autodesk.Navisworks.Api;

using Autodesk.Navisworks.Api.DocumentParts;

namespace Lab_Viewpoint
{
    public partial class ViewpointForm : Form
    {
        public ViewpointForm()
        {
            InitializeComponent();
        }

        private void MoveCamera(double x, double y, double z)
        {
            // To move the camera, we can just directly manipulate the
            // Position property. Rotation will remain unchanged, so view direction
            // is not changed.

            Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;
            Viewpoint oCurrentViewCopy = oDoc.CurrentViewpoint.CreateCopy();


            Point3D oNewPos = new Point3D(oCurrentViewCopy.Position.X + x,
                oCurrentViewCopy.Position.Y + y,
                oCurrentViewCopy.Position.Z + z);

            oCurrentViewCopy.Position = oNewPos;
            oDoc.CurrentViewpoint.CopyFrom(oCurrentViewCopy);
        }

        private void RotateCamera(double angle)
        {
            Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;
            //  Make a copy of current viewpoint	
            Viewpoint oCurrVCopy = oDoc.CurrentViewpoint.CreateCopy();

            //  set the axis we will rotate around （Ｚ：０,０,１）
            UnitVector3D odeltaA = new UnitVector3D(double.Parse(textRotX.Text),
                                                    double.Parse(textRotY.Text),
                                                    double.Parse(textRotZ.Text));
            // Create delta of Quaternion: 
            Rotation3D delta = new Rotation3D(odeltaA, angle);
            // multifly the current Quaternion with the delta , get the new Quaternion 
            oCurrVCopy.Rotation = Multiply(oCurrVCopy.Rotation, delta);
            // Update current viewpoint
            oDoc.CurrentViewpoint.CopyFrom(oCurrVCopy);

        }

        public static Rotation3D Multiply(Rotation3D r1, Rotation3D r2)
        {
            Rotation3D res = new Rotation3D(r2.D * r1.A + r2.A * r1.D + r2.B * r1.C - r2.C * r1.B,
                                            r2.D * r1.B + r2.B * r1.D + r2.C * r1.A - r2.A * r1.C,
                                            r2.D * r1.C + r2.C * r1.D + r2.A * r1.B - r2.B * r1.A,
                                            r2.D * r1.D - r2.A * r1.A - r2.B * r1.B - r2.C * r1.C);

            return res;
        }


        private void buttonRight_Click(object sender, EventArgs e)
        {
            MoveCamera(Double.Parse(textStep.Text), 0, 0);
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            MoveCamera(0, Double.Parse(textStep.Text), 0);
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            MoveCamera(0, 0, Double.Parse(textStep.Text));
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            MoveCamera(-Double.Parse(textStep.Text), 0, 0);
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            MoveCamera(0, -Double.Parse(textStep.Text), 0);
        }

        private void buttonIn_Click(object sender, EventArgs e)
        {
            MoveCamera(0, 0, -Double.Parse(textStep.Text));
        }

        private void buttonRotateCW_Click(object sender, EventArgs e)
        {
            RotateCamera(double.Parse(textRotStep.Text));
        }

        private void buttonRotateACW_Click(object sender, EventArgs e)
        {
            RotateCamera(-double.Parse(textRotStep.Text));
        }


        private void recurse(SavedItem oFolder, TreeNode oParentNode)
        {
            foreach (SavedItem oSItem in ((GroupItem)oFolder).Children)
            {
                TreeNode oNode = oParentNode.Nodes.Add(oSItem.DisplayName);
                oNode.Tag = oSItem;

                if (oSItem.IsGroup)
                    recurse(oSItem, oNode);
            }
        }


        void refresh()
        {
            treeView1.Nodes.Clear();
            Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;
            // iterate the collection of saved viewpoints
            foreach (SavedItem oSVP in oDoc.SavedViewpoints.Value)
            {
                TreeNode oNode = treeView1.Nodes.Add(oSVP.DisplayName);
                oNode.Tag = oSVP;
                if (oSVP.IsGroup)  // if it is a folder/animation group  
                {
                    recurse(oSVP, oNode);
                }
            }

        }
        private void btnAddView_Click(object sender, EventArgs e)
        {
            Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;

            FormAskName oaskname = new FormAskName("New View");
            if (oaskname.ShowDialog() == DialogResult.OK)
            {
                SavedViewpoint oNewViewPt1 = new SavedViewpoint(oDoc.CurrentViewpoint.ToViewpoint());
                oNewViewPt1.DisplayName = oaskname.inputName;
                oDoc.SavedViewpoints.AddCopy(oNewViewPt1);
            }

        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            //get active document
            Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;

            //ask user to input the name for new folder name
            FormAskName oaskname = new FormAskName("New Group");
            if (oaskname.ShowDialog() == DialogResult.OK)
            {
                //get document part: SavedViewpoints
                DocumentSavedViewpoints oSavePts = oDoc.SavedViewpoints;
                int groupNdx = oSavePts.Value.IndexOfDisplayName(oaskname.inputName);
                // make sure there are at least 2 items under root or after the group
                if (oSavePts.RootItem.Children.Count - groupNdx > 2)
                {
                    FolderItem oAFolder = null;
                    if (-1 == groupNdx)
                    {
                        FolderItem oFolderCopy = new FolderItem();
                        oFolderCopy.DisplayName = oaskname.inputName;
                        oDoc.SavedViewpoints.InsertCopy(oSavePts.RootItem, 0, oFolderCopy);
                        oAFolder = (FolderItem)oSavePts.RootItem.Children[0];
                        groupNdx = 0;
                    }
                    else
                    {
                        oAFolder = (FolderItem)oSavePts.RootItem.Children[groupNdx];
                    }
                    if (null != oAFolder)
                    {
                        try
                        {
                            oSavePts.Move(oSavePts.RootItem, groupNdx + 1, oAFolder, 0);
                            oSavePts.Move(oSavePts.RootItem, groupNdx + 1, oAFolder, 1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("There are less than 2 items under root or after the existing group");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        void SavedViewpoints_Changed(object sender, EventArgs e)
        {
            refresh();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;
            if (checkBox1.Checked)
            {
                oDoc.SavedViewpoints.Changed += new EventHandler<SavedItemChangedEventArgs>(SavedViewpoints_Changed);
            }
            else
            {
                oDoc.SavedViewpoints.Changed -= SavedViewpoints_Changed;
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                SavedItem oSelSet = (SavedItem)e.Node.Tag;
                Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;

                if (!oSelSet.IsGroup)
                {
                    SavedViewpoint oSV = oSelSet as SavedViewpoint;
                    oDoc.SavedViewpoints.CurrentSavedViewpoint = oSV;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
