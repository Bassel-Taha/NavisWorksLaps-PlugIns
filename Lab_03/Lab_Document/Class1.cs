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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Autodesk.Navisworks.Api;
using Autodesk.Navisworks.Api.Plugins;
using Autodesk.Navisworks.Api.DocumentParts;


namespace Lab_Document
{
    using System.Collections;
    using System.Security.Cryptography.X509Certificates;

    #region "Manipulate Document"
    [PluginAttribute("NWAPI_ManipulateDocument",
                     //Plugin name
                     "ADSK",
                     //Developer ID or GUID
                     ToolTip = "Manipulate Document",
                     //The tooltip for the item in the ribbon
                     DisplayName = "Manipulate Document")]
    //Display name for the Plugin in the Ribbon
    public class ManipulateDocument : AddInPlugin
    {
        public override int Execute(params string[] parameters)
        {
            //pop out the dialog that demos how to manipulate document
            Document_Form oForm = new Document_Form();
            var groupControl = oForm.Controls["groupBox1"];
            var stringcollection = new List<string>() {"textBox_title", "textBox_subject", "textBox_author", "textBox_publisher", "textBox_publisherFor", "textBox_copyright", "textBox_comments", "textBox_keywords"};
            var control = new ArrayList();
            foreach (var item in stringcollection)
            {
               control.Add( groupControl.Controls[item]);
            }

            var testStrings = new List<string>() { "Title Test", "Test Author" , "Test Subject", "Test Keywords" , "Test Comments", "Test Publisher", DateTime.Now.ToString() , "Test Copyright" };

            for (int i = 0; i < 8; i++)
            {
                var itemAsControl = control[i] as Control;
                itemAsControl.Text = testStrings[i];
            }
            oForm.ShowDialog();
            return 0;
        }
    }
    #endregion

    #region "Load Document Info"
    [PluginAttribute("NWAPI_LoadDocumentInfo",
                     //Plugin name
                     "ADSK",
                     //Developer ID or GUID
                     ToolTip = "LoadDocument Info",
                      //The tooltip for the item in the ribbon
                      DisplayName = "LoadDocument Info")]
    //Display name for the Plugin in the Ribbon
    public class LoadDocumentInfo : AddInPlugin
    {
        public override int Execute(params string[] parameters)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();
            if (fileDlg.ShowDialog() == DialogResult.OK)
            {
                // load the sheet info of one document but the file wont be opened if "its not appended"   
                // we can get the information from the file without opening it by searching for thr data without appending the file 
                DocumentInfo oDocInfo = Autodesk.Navisworks.Api.Application.LoadDocumentInfo(fileDlg.FileName);

                string infoStr = oDocInfo.DisplayName;
                infoStr = infoStr + "Current Sheet Name: " + oDocInfo.CurrentSheet.DisplayName;
                MessageBox.Show(infoStr);

                // append sheet of other document to active document, assume some sheets are available in the other document

                // iterate the children of the DocumentInfo
                foreach (SavedItem item in oDocInfo.Children)
                {
                    SheetInfo sheetInfo = item as SheetInfo;
                    // Find the first valid SheetInfo instance
                    if (sheetInfo != null)
                    {
                        // Try and append the SheetInfo to open the file in navisWorks
                        if (Autodesk.Navisworks.Api.Application.ActiveDocument.TryAppendSheet(sheetInfo))
                        {
                            // Tell the user we've successfully appende the sheet
                            MessageBox.Show(string.Format("Appended the '{0}' Sheet", item.DisplayName));
                            // break out of the loop, we've found a valid sheet
                            break;
                        }
                    }
                }
            }

            return 0;

        }
    }
    #endregion 

    #region "Manipulate Grid"
    [PluginAttribute("NWAPI_ManipulateGrid",
                     //Plugin name
                     "ADSK",
                     // Developer ID or GUID
                     ToolTip = "IManipulate Grid",
                     //The tooltip for the item in the ribbon
                     DisplayName = "Manipulate Grid")]
    //Display name for the Plugin in the Ribbon
    public class ManipulateGrid : AddInPlugin
    {
        public override int Execute(params string[] parameters)
        {
            Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;
            DocumentGrids oGrids = oDoc.Grids;
            //set render mode of grid = Above and Below
            oGrids.RenderMode = GridsRenderMode.AboveAndBelow;
            //get active grid system
            GridSystem oGridSys = oGrids.ActiveSystem;

            StringBuilder infoStr = new StringBuilder(1000);
            infoStr.Append("Active System Name: " + oGridSys.DisplayName + "\n");

            //dump levels
            infoStr.Append("Level Info: \n");
            foreach (GridLevel oGridLevel in oGridSys.Levels)
                infoStr.Append(oGridLevel.DisplayName +
                    ": Elevation = " +
                    oGridLevel.Elevation + "\n");

            //dump grid lines
            infoStr.Append("Grid Line Info: \n");
            foreach (GridLine oGridLine in oGridSys.Lines)
                infoStr.Append(
                    "Grid Line Name: " +
                    oGridLine.DisplayName + "\n");

            MessageBox.Show(infoStr.ToString());

            //enable grid or not
            GridsOptions oGridsOp =
                Autodesk.Navisworks.Api.Application.Options.Grids;

            DialogResult isEnableGrid = MessageBox.Show("Enable Grid？", "Enable Grid", MessageBoxButtons.YesNo);
            if (isEnableGrid == DialogResult.Yes)
                oGridsOp.Enabled = true;
            else
                oGridsOp.Enabled = false;


            return 0;
        }
    }
    #endregion
}
