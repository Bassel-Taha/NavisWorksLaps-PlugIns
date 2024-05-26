using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Export_Click(object sender, EventArgs e)
        {
            var output = ElementsProperties.OutPut;
            AssistantFuncs.ExportIntoTextFile(output);
            
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Find_Click(object sender, EventArgs e)
        {
            var output = new StringBuilder();
            if (string.IsNullOrEmpty(this.CatDisplayNameTextBox.Text) && string.IsNullOrEmpty(this.PropDisplayNameTextBox.Text))
            {
                 MessageBox.Show("please at least fill the prop displayname");
                 return;
            }
            else if (string.IsNullOrEmpty(this.CatDisplayNameTextBox.Text))
            {
                output.Append( AssistantFuncs.FindPropertyByDisplayName(ElementsProperties.SelectedModelItem,
                    this.PropDisplayNameTextBox.Text));
            }
            else
            {
                output.Append(AssistantFuncs.FindPropertyByDisplayName(ElementsProperties.SelectedModelItem
                    , this.CatDisplayNameTextBox.Text, this.PropDisplayNameTextBox.Text));
            }

            this.PropsText.Text = output.ToString();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
