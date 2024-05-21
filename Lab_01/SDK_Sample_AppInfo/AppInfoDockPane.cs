﻿//------------------------------------------------------------------
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
// This sample illustrates the various properties available in the API
//
//------------------------------------------------------------------
#region AppInfoDockPane
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AppInfo.Control;
using Autodesk.Navisworks.Api.Plugins;

namespace AppInfoDockPane
{
#region Plugin_Details
   [Plugin("AppInfo.AppInfoDockPane",                   //Plugin name
                    "ADSK",                              //4 character Developer ID or GUID
                    ToolTip = "Application Information", //The tooltip for the item in the ribbon
                    DisplayName = "AppInfo")]            //Display name for the Plugin in the Ribbon
#endregion
#region Docking_Pane_Details
   [DockPanePlugin(755, 575,     //the preferred sizes
      FixedSize = false,           //(Optional) Can the DockPane can grow and shrink
      AutoScroll = true,           //(Optional) Controls the showing and hiding of the scrollbars
      MinimumWidth = 585,          //(Optional) The minimum Width of the Dock Pane
      MinimumHeight = 280          //(Optional) The minimum Height of the Dock Pane
      )]
#endregion
   public class AppInfoDockPane : DockPanePlugin
   {
      public override Control CreateControlPane()
      {
         AppInfoControl control = new AppInfoControl();
         control.Dock = DockStyle.Fill;

         control.CreateControl();

         return control;
      }

      public override void DestroyControlPane(Control pane)
      {
         AppInfoControl control = pane as AppInfoControl;
         if (control != null)
         {
            control.CleanUp();
            control.Dispose();
         }
      }
   }
}
#endregion
