
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
using System.IO;

 
using Autodesk.Navisworks.Api;
using Autodesk.Navisworks.Api.Plugins;

using ComApi = Autodesk.Navisworks.Api.Interop.ComApi;
using ComApiBridge = Autodesk.Navisworks.Api.ComApi.ComApiBridge;
 

namespace Lab_COM_Interop
{
    #region "Plug-in Add Custom Properties"
    [PluginAttribute("NWAPI_Add_CustomProperties", //Plugin name
                      "ADSK", //Developer ID or GUID
                      ToolTip = "Add Custom Properties to Model Item",
                       //The tooltip for the item in the ribbon
                      DisplayName = "Add Custom Properties")]
                      //Display name for the Plugin in the Ribbon

    public class NWAPI_Add_CustomProperties : AddInPlugin
    {
        public override int Execute(params string[] parameters)
        {
            ModelItemCollection oMC_NET = Autodesk.Navisworks.Api.Application.ActiveDocument.CurrentSelection.SelectedItems;
            ComApi.InwOpState9 oState = ComApiBridge.State;
            if(oMC_NET.Count>0)
            {
                //if add custom properties to geometry model item only

                ComApi.InwOpSelection comSelectionOut =
                ComApiBridge.ToInwOpSelection(oMC_NET);
 
                ComApi.InwSelectionPathsColl oPaths = comSelectionOut.Paths();
                ComApi.InwOaPath3 oPath = (ComApi.InwOaPath3)oPaths.Last();
                ComApi.InwGUIPropertyNode2 propn = 
		            (ComApi.InwGUIPropertyNode2)oState.GetGUIPropertyNode(oPath, true);
 
                 ComApi.InwOaPropertyVec newPvec =
		             (ComApi.InwOaPropertyVec)oState.ObjectFactory(
			            ComApi.nwEObjectType.eObjectType_nwOaPropertyVec, null, null);
                 ComApi.InwOaProperty newP = (ComApi.InwOaProperty)oState.ObjectFactory(
		                  ComApi.nwEObjectType.eObjectType_nwOaProperty, null, null);
                 newP.name = "demo_Property_Name";
                 newP.UserName = "demo_Property_UserName";
                 newP.value = "demo_Property_Value";
 
                 newPvec.Properties().Add(newP);
 
                 propn.SetUserDefined(0, "demo_PropertyTab_Name", 
				              "demo_PropertyTab_InteralName", newPvec);
 
            }

            return 0;
        }

    }

    #endregion


    #region "Plug-in Dump Geometry Primitives"
    [PluginAttribute("NWAPI_Dump_Primitives", //Plugin name
                      "ADSK", //Developer ID or GUID
                      ToolTip = "Dump Geometry Primitives of Model Item",
        //The tooltip for the item in the ribbon
                      DisplayName = "Dump Geometry Primitives")]
    //Display name for the Plugin in the Ribbon
    public class NWAPI_Dump_Primitives : AddInPlugin
    {
        public override int Execute(params string[] parameters)
        {
            // get the current selection
            ModelItemCollection oModelColl = Autodesk.Navisworks.Api.Application.ActiveDocument.CurrentSelection.SelectedItems;

            //convert to COM selection
            ComApi.InwOpState oState = ComApiBridge.State;
            ComApi.InwOpSelection oSel = ComApiBridge.ToInwOpSelection(oModelColl);

            // create the callback object
            CallbackGeomListener callbkListener = new CallbackGeomListener();
            foreach (ComApi.InwOaPath3 path in oSel.Paths())
            {
                foreach (ComApi.InwOaFragment3 frag in path.Fragments())
                {
                    // generate the primitives
                    frag.GenerateSimplePrimitives(ComApi.nwEVertexProperty.eNORMAL, callbkListener);
                }
            }
             
            return 0;
        }

    }

    #region InwSimplePrimitivesCB Class
    class CallbackGeomListener : ComApi.InwSimplePrimitivesCB
    {
        FileStream aFile;
        StreamWriter sw;

        public CallbackGeomListener()
        {
            aFile = new FileStream("c:\\temp\\NavisworksObjGeomtries.txt", FileMode.OpenOrCreate);
            sw = new StreamWriter(aFile);
        }
        
        public void Line(ComApi.InwSimpleVertex v1, ComApi.InwSimpleVertex v2)
        {
            // do your work
        }

        public void Point(ComApi.InwSimpleVertex v1)
        {
            // do your work
        }

        public void SnapPoint(ComApi.InwSimpleVertex v1)
        {
            // do your work
        }

        public void Triangle(ComApi.InwSimpleVertex v1,
                ComApi.InwSimpleVertex v2,
                ComApi.InwSimpleVertex v3)
        {
            // do your work

            Array array_v1 = (Array)(object)v1.coord;
            Array array_v2 = (Array)(object)v2.coord;
            Array array_v3 = (Array)(object)v3.coord;

            StringBuilder oStr = new StringBuilder();
            oStr.Append("[" + array_v1.GetValue(1).ToString() + "," +
                              array_v1.GetValue(2).ToString() + "," +
                              array_v1.GetValue(3).ToString() + "]");
            oStr.Append("[" + array_v2.GetValue(1).ToString() + "," +
                              array_v2.GetValue(2).ToString() + "," +
                              array_v2.GetValue(3).ToString() + "]");
            oStr.Append("[" + array_v3.GetValue(1).ToString() + "," +
                              array_v3.GetValue(2).ToString() + "," +
                              array_v3.GetValue(3).ToString() + "]\n");

            sw.WriteLine(oStr);

        }
        ~CallbackGeomListener()
        {
            sw.Close();
        }

    }
    #endregion


    #endregion


  

}
