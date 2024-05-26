        internal static bool SetParameterValue(ModelItem item, string NewCategory, string NewAttribute, dynamic NewValue)
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

