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


#region Namespaces

using Autodesk.Navisworks.Api;
using Autodesk.Navisworks.Api.Plugins;
using Autodesk.Navisworks.Api.DocumentParts; 
using ComApi = Autodesk.Navisworks.Api.Interop.ComApi;
using ComApiBridge = Autodesk.Navisworks.Api.ComApi.ComApiBridge;

#endregion


namespace Lab_Events
{
    [PluginAttribute("ManipulateEvents",
                     //Plugin name
                    "ADSK",
                    // Developer ID or GUID
                    ToolTip = "Manipulate Events",
                    //The tooltip for the item in the ribbon
                    DisplayName = "Enable/Disable Events")]
                    //Display name for the Plugin in the Ribbon
    public class ManipulateEvents : AddInPlugin
    {
        //subscribe event or not
        static bool isEnabled = false;
        //indicates if event of saved view changed has finished
        static bool isSavedViewChangedDone = false;

        public override int Execute(params string[] parameters)
        {  
            if (isEnabled)
            {
                //un-subscribe the events
                Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;
                oDoc.SavedViewpoints.CurrentSavedViewpointChanged -= SavedViewpoints_CurrentSavedViewpointChanged;                                
                Autodesk.Navisworks.Api.Application.Idle-=Application_Idle;
            }
            else
            {
                //subscribe the events
                Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;
                oDoc.SavedViewpoints.CurrentSavedViewpointChanged += SavedViewpoints_CurrentSavedViewpointChanged;
                 Autodesk.Navisworks.Api.Application.Idle += Application_Idle;

            }
            isEnabled = !isEnabled;
            return 0;
        }

        //when Navisworks is not busy
        void Application_Idle(object sender,
                                    System.EventArgs e)
        {
            if (isSavedViewChangedDone)
            {
                //event of saved view changed has finished
                try
                {
                     Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;
                    //get saved viewpoints
                    SavedItem oSV = oDoc.SavedViewpoints.CurrentSavedViewpoint;
                    if (null != oSV)
                    {
                        string curViewName = oSV.DisplayName;
                        //get COM state
                        ComApi.InwOpState10 oState = ComApiBridge.State;
                        // get the plug-in of exporting image
                        ComApi.InwOaPropertyVec options =
                            oState.GetIOPluginOptions("lcodpimage");

                        // set to the format to png
                        foreach (ComApi.InwOaProperty opt in options.Properties())
                        {
                            if (opt.name == "export.image.format")
                                opt.value = "lcodpexpng";
                        }
                        // execute the plugin "lcodpimage" to export it to an image
                        string tempFileName = "c:\\temp\\" + curViewName + ".PNG";
                        if (System.IO.File.Exists(tempFileName))
                            System.IO.File.Delete(tempFileName);
                        oState.DriveIOPlugin("lcodpimage", tempFileName, options);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                isSavedViewChangedDone = false;
            }
        }

       

        void SavedViewpoints_CurrentSavedViewpointChanged(object sender,
                                    System.EventArgs e)
        {
            //tell Idle event SavedViewpointChanged has done.
            isSavedViewChangedDone = true;
            
        }

       
         
    }
}
