using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections;

using Autodesk.Navisworks.Api;
using Autodesk.Navisworks.Api.DocumentParts;
using ComApi = Autodesk.Navisworks.Api.Interop.ComApi;
using ComApiBridge = Autodesk.Navisworks.Api.ComApi.ComApiBridge;




namespace Lab_Search
{
    public partial class PropertiesSearchForm : Form
    {
        public PropertiesSearchForm()
        {
            InitializeComponent();
        }

        static string _priceXMLFile;

        Dictionary<string, string> _priceMap = new Dictionary<string, string>();

        private void PropertiesSearchForm_Load(object sender, EventArgs e)
        {
            OpenFileDialog openFileDDlg = new OpenFileDialog();
            openFileDDlg.Filter = "xml files (*.xml)|*.xml";

            if (openFileDDlg.ShowDialog() == DialogResult.OK)
            {
                _priceXMLFile = openFileDDlg.FileName;
                buildPriceMap();
                refreshListView(_priceMap);
            }

        }

        private void PropertiesSearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        void refreshListView(dynamic _toList)
        {
            try
            {

                listviewModel.Items.Clear();
                foreach (string key in _toList.Keys)
                {
                    Search oS = new Search();
                    oS.SearchConditions.Add(GetIdSearchCondition(key)
                        );
                    oS.Selection.SelectAll();
                    ModelItemCollection findItems = oS.FindAll(Autodesk.Navisworks.Api.Application.ActiveDocument, true);
                    if (findItems.Count<ModelItem>() > 0)
                    {
                        ModelItem oNavisItem = findItems[0];
                        ListViewItem listviewItem = new ListViewItem();
                        if (string.IsNullOrEmpty(oNavisItem.DisplayName))
                            listviewItem.Text = oNavisItem.ClassDisplayName;
                        else
                            listviewItem.Text = oNavisItem.DisplayName;
                        listviewItem.SubItems.Add(key);
                        listviewItem.SubItems.Add(_toList[key]);
                        listviewModel.Items.Add(listviewItem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private SearchCondition GetIdSearchCondition(string key)
        {
            //Element ID -> Value
            return SearchCondition.HasPropertyByName("LcRevitId", "LcOaNat64AttributeValue").EqualValue(new VariantData(key));
        }

        void buildPriceMap()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(_priceXMLFile);
                XmlNode root = xmlDoc.SelectSingleNode("price");
                XmlNodeList nodeList = root.ChildNodes;

                foreach (XmlNode xn in nodeList)
                {
                    XmlElement xe = (XmlElement)xn;
                    string elementId = xe.GetAttribute("ID");
                    string elementPrice = xe.GetAttribute("Price");

                    if (!_priceMap.ContainsKey(elementId))
                        _priceMap.Add(elementId, elementPrice);

                }
                xmlDoc.Save(_priceXMLFile);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            double minV = Convert.ToDouble(txtMin.Text);
            double maxV = Convert.ToDouble(txtMax.Text);

            var itemsInRange = _priceMap.Where(x => Convert.ToDouble(x.Value) > minV
                                                && Convert.ToDouble(x.Value) < maxV);
            listviewModel.Items.Clear();

            foreach (var item in itemsInRange)
            {
                Search oS = new Search();
                oS.SearchConditions.Add(GetIdSearchCondition(item.Key));
                oS.Selection.SelectAll();
                ModelItemCollection findItems = oS.FindAll(Autodesk.Navisworks.Api.Application.ActiveDocument, true);
                if (findItems.Count<ModelItem>() > 0)
                {
                    ModelItem oNavisItem = findItems[0];
                    ListViewItem listviewItem = new ListViewItem();
                    if (string.IsNullOrEmpty(oNavisItem.DisplayName))
                        listviewItem.Text = oNavisItem.ClassDisplayName;
                    else
                        listviewItem.Text = oNavisItem.DisplayName;
                    listviewItem.SubItems.Add(item.Key);
                    listviewItem.SubItems.Add(item.Value);
                    listviewModel.Items.Add(listviewItem);
                }
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            refreshListView(_priceMap);
        }

        private void listviewModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;

            Search oS = new Search();
            foreach (ListViewItem item in listviewModel.SelectedItems)
            {
                oS.SearchConditions.Add(GetIdSearchCondition(item.SubItems[1].Text));
            }

            oS.Selection.SelectAll();
            ModelItemCollection findItems = oS.FindAll(oDoc, true);
            oDoc.CurrentSelection.CopyFrom(findItems);

            ComApiBridge.State.ZoomInCurViewOnCurSel();
        }
    }
}
