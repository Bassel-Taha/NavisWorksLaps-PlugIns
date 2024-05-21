using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Autodesk.Navisworks.Api.Plugins;


namespace EventWatcherDemo
{
    [Plugin("EventWatcher", "ADSK",DisplayName = "Event Watcher")]
    public class EventWatcher : EventWatcherPlugin
    {
        public override void OnLoaded()
        {
            //The plugin will be loaded as soon as is possible in the GUI
            Autodesk.Navisworks.Api.Application.ActiveDocumentChanged += Application_ActiveDocumentChanged;
            }
        public override void OnUnloading()
        {
            //The plugin is unloaded at the end of the Navisworks session
           
            Autodesk.Navisworks.Api.Application.ActiveDocumentChanged -= Application_ActiveDocumentChanged;             
        } 
        /// simple event handler for Application.GuiCreated    
        void Application_ActiveDocumentChanged(object sender,
                                        System.EventArgs e)
        {
            MessageBox.Show("ActiveDocumentChanged");
           
            if(Autodesk.Navisworks.Api.Application.ActiveDocument != null)
                Autodesk.Navisworks.Api.Application.ActiveDocument.Models.
                    CollectionChanged += ActiveDocument_Models_CollectionChanged;
            
        }

        void ActiveDocument_Models_CollectionChanged(object sender,
                                                 System.EventArgs e)
        {
            MessageBox.Show("ActiveDocument_Models_CollectionChanged");
        } 

    }

}
