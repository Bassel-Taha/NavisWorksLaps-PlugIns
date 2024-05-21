#region Copyright
//
// Copyright (C) 2011-2015 by Autodesk, Inc.
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
using Autodesk.Navisworks.Api.DocumentParts;

using ComApi = Autodesk.Navisworks.Api.Interop.ComApi;
using ComApiBridge = Autodesk.Navisworks.Api.ComApi;


namespace Lab_Selection
{
    public partial class SelectionDockPaneControl : UserControl
    {
        public SelectionDockPaneControl()
        {
            InitializeComponent();
        }

        private void recurse(SavedItem oFolder, TreeNode parentNode)
        {
            foreach (SavedItem oSS in ((GroupItem)oFolder).Children)
            {
                string nodename = "";
                if (oSS.IsGroup)
                {
                    nodename += "Group: ";
                    nodename += oSS.DisplayName;
                    TreeNode oNode = parentNode.Nodes.Add(nodename);
                    oNode.Tag = oSS;
                    recurse(oSS, oNode);
                }
                else
                {
                    SelectionSet oSet = (SelectionSet)oSS;
                    if (oSet.HasExplicitModelItems)
                    {
                        nodename += "Explicit: ";
                    }
                    if (oSet.HasSearch)
                    {
                        nodename += "Search: ";
                    }

                    nodename += oSS.DisplayName;
                    TreeNode oNode = parentNode.Nodes.Add(nodename);
                    oNode.Tag = oSS;
                }
            }
        }

        void refresh_list()
        {
            treeView1.Nodes.Clear();
            Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;

            foreach (SavedItem oSS in oDoc.SelectionSets.Value)
            {
                string nodename = "";
                if (oSS.IsGroup)
                {
                    nodename += "Group: ";
                    nodename += oSS.DisplayName;
                    TreeNode oNode = treeView1.Nodes.Add(nodename);
                    oNode.Tag = oSS;
                    recurse(oSS, oNode);
                }
                else
                {
                    SelectionSet oSet = (SelectionSet)oSS;
                    if (oSet.HasExplicitModelItems)
                    {
                        nodename += "Explicit: ";
                    }
                    if (oSet.HasSearch)
                    {
                        nodename += "Search: ";
                    }

                    nodename += oSS.DisplayName;
                    TreeNode oNode = treeView1.Nodes.Add(nodename);
                    oNode.Tag = oSS;

                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //dump the tree of selection sets 
            refresh_list();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SavedItem oSelSet = (SavedItem)e.Node.Tag;
            Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;

            if (!oSelSet.IsGroup)
            {
                SelectionSet oSS = oSelSet as SelectionSet;
                oDoc.CurrentSelection.CopyFrom(oSS.GetSelectedItems());
                ComApiBridge.ComApiBridge.State.ZoomInCurViewOnCurSel();
            }
        }


        private void buttonAddSet_Click(object sender, EventArgs e)
        {
            FormAskName oaskname = new FormAskName("New Set");
            if (oaskname.ShowDialog() == DialogResult.OK)
            {
                Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;

                if (oDoc.CurrentSelection.SelectedItems.Count > 0)
                {
                    SelectionSet oMySet = new SelectionSet(oDoc.CurrentSelection.SelectedItems);
                    oMySet.DisplayName = oaskname.inputName;

                    DocumentSelectionSets oCurSets = oDoc.SelectionSets;
                    oCurSets.AddCopy(oMySet);
                }
                else
                {
                    MessageBox.Show("Please at least select one item");
                }
            }
        }

        //add current search as a selection set
        private void btnAddsearch_Click(object sender, EventArgs e)
        {
            FormAskName oaskname = new FormAskName("New Set");
            if (oaskname.ShowDialog() == DialogResult.OK)
            {
                Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;

                if (!oDoc.CurrentSearch.ToSearch().IsClear)
                {
                    SelectionSet oMySet = new SelectionSet(oDoc.CurrentSearch.ToSearch());
                    oMySet.DisplayName = oaskname.inputName;

                    DocumentSelectionSets oCurSets = oDoc.SelectionSets;
                    oCurSets.AddCopy(oMySet);
                }
            }
        }

        //create a folder with two selection sets 
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            //get active document
            Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;

            //ask user to input the name for new folder name
            FormAskName oaskname = new FormAskName("New Group");
            if (oaskname.ShowDialog() == DialogResult.OK)
            {
                //get document part: SavedViewpoints
                DocumentSelectionSets oSSets = oDoc.SelectionSets;
                int groupNdx = oSSets.Value.IndexOfDisplayName(oaskname.inputName);

                // make sure there are at least 2 items under root or after the group
                if (oSSets.RootItem.Children.Count - groupNdx > 2)
                {
                    FolderItem oAFolder = null;
                    if (-1 == groupNdx)
                    {
                        FolderItem oFolderCopy = new FolderItem();
                        oFolderCopy.DisplayName = oaskname.inputName;
                        oDoc.SelectionSets.InsertCopy(oSSets.RootItem, 0, oFolderCopy);
                        oAFolder = (FolderItem)oSSets.RootItem.Children[0];
                        groupNdx = 0;
                    }
                    else
                    {
                        oAFolder = (FolderItem)oSSets.RootItem.Children[groupNdx];
                    }
                    if (null != oAFolder)
                    {
                        try
                        {
                            oSSets.Move(oSSets.RootItem, groupNdx + 1, oAFolder, 0);
                            oSSets.Move(oSSets.RootItem, groupNdx + 1, oAFolder, 1);
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

        void SelectionSets_Changed(object sender, EventArgs e)
        {
            refresh_list();
        }

        private void checkBoxAutoRefresh_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoRefresh.Checked)
            {
                Autodesk.Navisworks.Api.Application.ActiveDocument.SelectionSets.Changed +=
                    new EventHandler<SavedItemChangedEventArgs>(SelectionSets_Changed);
            }
            else
            {
                Autodesk.Navisworks.Api.Application.ActiveDocument.SelectionSets.Changed -=
                     SelectionSets_Changed;
            }
        }



    }
}
