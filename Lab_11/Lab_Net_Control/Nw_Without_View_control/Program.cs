
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
using System.Windows.Forms;


using Autodesk.Navisworks.Api;
using Autodesk.Navisworks.Api.Controls;


namespace Nw_Without_View_control
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //single document mode
            Autodesk.Navisworks.Api.Controls.ApplicationControl.ApplicationType =
            ApplicationType.SingleDocument;
            //initialize application control 
            ApplicationControl.Initialize();
            //create a DocumentControl
            DocumentControl documentCtrl = new DocumentControl();
            //open a document 

            OpenFileDialog openFileDDlg = new OpenFileDialog();
            if (openFileDDlg.ShowDialog() == DialogResult.OK)
            {
                if (documentCtrl.Document.TryOpenFile(openFileDDlg.FileName))
                {
                    Search oS = new Search();
                    oS.SearchConditions.Add(
                          SearchCondition.HasPropertyByName(PropertyCategoryNames.AutoCadEntityHandle,
                          DataPropertyNames.AutoCadEntityHandleValue).
                          EqualValue(new VariantData("16C17")));
                    oS.Selection.SelectAll();
                    ModelItemCollection findItems = oS.FindAll(Autodesk.Navisworks.Api.Application.ActiveDocument, true);


                    if (findItems.Count  > 0)
                    {
                        documentCtrl.Document.Models.OverridePermanentColor(findItems, Autodesk.Navisworks.Api.Color.Red);
                        //save to a lower version
                        documentCtrl.Document.SaveFile("c:\\temp\\testcopy2014.nwd", DocumentFileVersion.Navisworks2014);
                    }
                }
            }   
            //destroy DocumentControl
            documentCtrl.Dispose();
            //terminate application control 
            ApplicationControl.Terminate();
        }
    }
}
