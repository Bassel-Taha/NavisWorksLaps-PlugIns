using Autodesk.Navisworks.Api.Interop.ComApi;
using Autodesk.Navisworks.Api;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComApi=Autodesk.Navisworks.Api.Interop.ComApi;

namespace Lab_Properties
{
    internal class AssistantFuncs
    {
        public static bool SetParameterValue(ModelItem item, string NewCategory, string NewAttribute, dynamic NewValue)
        {
            try
            {

                ComApi.InwOpState10 oState = Autodesk.Navisworks.Api.ComApi.ComApiBridge.State;

                //convert the .NET collection to COM object
                ComApi.InwOaPath oPath = Autodesk.Navisworks.Api.ComApi.ComApiBridge.ToInwOaPath(item);
                ComApi.InwGUIPropertyNode2 propn =
                      (ComApi.InwGUIPropertyNode2)oState.GetGUIPropertyNode(oPath, true);

                var prop = item.PropertyCategories.FindCategoryByDisplayName(NewCategory);

                if (prop != null)
                {
                    int index = 1;
                    bool isFound = false;
                    foreach (InwGUIAttribute2 categoryObj in propn.GUIAttributes())
                    {
                        if (categoryObj.ClassUserName == NewCategory)
                        {
                            //System.Diagnostics.Debug.WriteLine("Category internal name: " + categoryObj.ClassName + " UserName: " + categoryObj.ClassUserName + " User Defined" + categoryObj.UserDefined.ToString());

                            if (categoryObj.UserDefined)
                            {
                                ComApi.InwOaPropertyVec categoryPropertyList = (ComApi.InwOaPropertyVec)oState.ObjectFactory(ComApi.nwEObjectType.eObjectType_nwOaPropertyVec);
                                foreach (InwOaProperty existingProp in categoryObj.Properties())
                                {
                                    InwOaProperty nwNewProp = oState.ObjectFactory(ComApi.nwEObjectType.eObjectType_nwOaProperty);
                                    nwNewProp.name = existingProp.name;
                                    nwNewProp.value = existingProp.value;
                                    //if (nwNewProp.name.EndsWith(newAttributeName))
                                    if (nwNewProp.name == NewAttribute)
                                    {
                                        nwNewProp.value = NewValue;
                                        isFound = true;
                                    }
                                    categoryPropertyList.Properties().Add(nwNewProp);
                                }
                                if (!isFound)
                                {
                                    InwOaProperty nwNewProp = oState.ObjectFactory(ComApi.nwEObjectType.eObjectType_nwOaProperty);
                                    nwNewProp.name = NewAttribute;
                                    nwNewProp.value = NewValue;
                                    categoryPropertyList.Properties().Add(nwNewProp);
                                }
                                //index = 0 means add new property while index > 0 means update existing property
                                // index is the count of categories userdefined properties
                                propn.SetUserDefined(index, categoryObj.ClassUserName, categoryObj.ClassName, categoryPropertyList);
                                return true;
                                index++;
                            }


                        }
                    }
                }
                ComApi.InwOaPropertyVec propertyList = (ComApi.InwOaPropertyVec)oState.ObjectFactory(ComApi.nwEObjectType.eObjectType_nwOaPropertyVec);

                // create new property
                ComApi.InwOaProperty addProperty = (ComApi.InwOaProperty)oState.ObjectFactory(ComApi.nwEObjectType.eObjectType_nwOaProperty, null, null);

                // set the name, username and value of the new property
                addProperty.name = NewAttribute;
                addProperty.UserName = NewAttribute;
                addProperty.value = NewValue;
                propertyList.Properties().Add(addProperty);

                propn.SetUserDefined(0, NewCategory, NewCategory, propertyList);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public static string FindPropertyByDisplayName(ModelItem modelItem, string catDisplayName, string propDisplayName)
        {
            StringBuilder output = new StringBuilder();
            //find specific category:
            PropertyCategory oPC_Item = modelItem.PropertyCategories.FindCategoryByDisplayName(catDisplayName);
            if (oPC_Item != null)
            {
                output.Append($"Found a category by display name = \"{catDisplayName}\" Properties Count: " + oPC_Item.Properties.Count + "\n");
                DataProperty oDP_Layer = modelItem.PropertyCategories.FindPropertyByDisplayName(catDisplayName, propDisplayName);
                if (oPC_Item != null)
                {
                    output.Append($"Found a data property by display name = \"{propDisplayName}\" Value: " + oDP_Layer.Value.ToDisplayString() + "\n");
                }
                else
                {
                    output.Append($"Cannot find a data property by display name = \"{propDisplayName}\" in the propCatigury by displayname = {catDisplayName}\n");
                }
            }
            else
            {
                output.Append($"Cannot find a category by display name = \"{catDisplayName}\"\n");
            }
            return output.ToString();
        }


        public static string FindPropertyByDisplayName(ModelItem modelItem, string propDisplayName)
        {
            StringBuilder output = new StringBuilder();
            //find specific category:
            foreach (var category in modelItem.PropertyCategories)
            {
                DataProperty oDP_Layer = modelItem.PropertyCategories.FindPropertyByDisplayName(category.DisplayName,propDisplayName);
                if (oDP_Layer != null)
                {
                    output.Append($"Found a data property by display name = \"{propDisplayName}\" Value: " + oDP_Layer.Value.ToDisplayString() + "\n");
                    return output.ToString();
                }
            }

            return output.Append(
                $"Cannot find a data property by display name = \"{propDisplayName}\" in any property Category\n").ToString();
            
        }


        public static void ExportIntoTextFile(string output)
        {
            var path = "C:\\Users\\basse\\Desktop\\prop.txt";
            File.WriteAllText(path, output);
            MessageBox.Show("the Properties is exported succesfully on the disktop");
        }


    }
}
