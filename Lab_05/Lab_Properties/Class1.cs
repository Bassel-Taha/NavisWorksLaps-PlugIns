﻿
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

#region Namespaces

using Autodesk.Navisworks.Api;
using Autodesk.Navisworks.Api.Plugins;

#endregion




namespace Lab_Properties
{    
    #region "Properties"
        [PluginAttribute("DumpProperties",
                        //Plugin name
                        "ADSK",
                        //Developer ID or GUID
                        ToolTip = "Dump Properties",
                        //The tooltip for the item in the ribbon
                       DisplayName = "Dump Properties")]
                        //Display name for the Plugin in the Ribbon
    public class DumpProperties : AddInPlugin
    {
        public override int Execute(params string[] parameters)
        {                 
            Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;
                
            if(oDoc.CurrentSelection.SelectedItems.Count >0)
            {
                StringBuilder output = new StringBuilder(1000); 
                output.Append("Dump Property Category of Current Selected Item\n");   
                //dump the first item only
                ModelItem oItem = oDoc.CurrentSelection.SelectedItems[0];
                foreach (PropertyCategory oPC in oItem.PropertyCategories) 
                {
                    output.Append(" Display Name: " + oPC.DisplayName + "  Internal Name" + oPC.Name + "\n");
                    output.Append("    Properties\n");   
                    foreach (DataProperty oDP in oPC.Properties)
                    {
                        output.Append("     [Display Name]: " + oDP.DisplayName + "[Internal Name]:" + oDP.Name);
                        if(oDP.Value.IsDisplayString)
                        {
                            output.Append("[Value]: " + oDP.Value.ToString() +"\n");                                                    
                        }
                        if (oDP.Value.IsDateTime)
                        {
                            output.Append("[Value]: " + oDP.Value.ToDateTime().ToShortTimeString() + "\n");
                        }
                        else
                        {
                            output.Append("<Other types of values>" + "\n");
                        }
                    }
                }

                //find specific category:
                PropertyCategory oPC_Item = oItem.PropertyCategories.FindCategoryByDisplayName("Item");
                if (oPC_Item != null)
                {
                    output.Append("Found a category by display name = \"Item\" Properties Count: " + oPC_Item.Properties.Count + "\n");
                    DataProperty oDP_Layer = oItem.PropertyCategories.FindPropertyByDisplayName("Item", "Layer");
                    if (oPC_Item != null)
                    {
                        output.Append("Found a data property by display name = \"Item,Layer\" Value: " + oDP_Layer.Value.ToDisplayString() + "\n");
                    }
                    else
                    {
                        output.Append("Cannot find a data property by display name = \"Item,Layer\"\n");
                    }
                }
                else
                {
                    output.Append("Cannot find a category by display name = \"Item\"\n");
                }

                MessageBox.Show(output.ToString());
            } 
            return 0;
        } 
    }
   #endregion 

   
}