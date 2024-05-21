using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Autodesk.Navisworks.Api;
using Autodesk.Navisworks.Api.Controls;

using ComApiBridge = Autodesk.Navisworks.Api.ComApi.ComApiBridge;
using ComApi = Autodesk.Navisworks.Api.Interop.ComApi;


namespace Nw_Single_Doc_With_COM
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //single document mode
            Autodesk.Navisworks.Api.Controls.ApplicationControl.ApplicationType =
            ApplicationType.SingleDocument;
            //initialize  Navisworks API 
            ApplicationControl.Initialize();
            //create DocumentControl
            DocumentControl documentCtrl = new DocumentControl();

            //must call!
            //documentCtrl.SetAsMainDocument();


            OpenFileDialog openFileDDlg = new OpenFileDialog();
            if (openFileDDlg.ShowDialog() == DialogResult.OK)
            {
                if (documentCtrl.Document.TryOpenFile(openFileDDlg.FileName))
                {
                    //find   specific model items
                    Search oS = new Search();
                    oS.SearchConditions.Add(
                          SearchCondition.HasPropertyByName(PropertyCategoryNames.AutoCadEntityHandle,
                          DataPropertyNames.AutoCadEntityHandleValue).
                          EqualValue(new VariantData("16C17")));
                    oS.Selection.SelectAll();
                    ModelItemCollection findItems = oS.FindAll(Autodesk.Navisworks.Api.Application.ActiveDocument, true);

                    // add custom property to the items
                    ComApi.InwOpState9 oState = ComApiBridge.State;
                    if (findItems.Count > 0)
                    {
                        //if add custom properties to geometry model item only

                        ComApi.InwOpSelection comSelectionOut =
                        ComApiBridge.ToInwOpSelection(findItems);

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


                    //save to nwd file in 2014 format.
                    documentCtrl.Document.SaveFile("c:\\temp\\testcopy1.nwd", DocumentFileVersion.Navisworks2014);
                }
            }
            //destroy  DocumentControl
            documentCtrl.Dispose();
            //terminate Navisworks API 
            ApplicationControl.Terminate();
        }
    }
}
