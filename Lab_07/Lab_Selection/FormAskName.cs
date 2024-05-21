using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_Selection
{
    public partial class FormAskName : Form
    {
        public string inputName = "";

        public FormAskName()
        {
            InitializeComponent();
        }

        public FormAskName(string title) : this()
        {
            this.Text = title;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                inputName = textBox1.Text;
            else
                MessageBox.Show("The name cannot be empty!");

        }
 
    }
}
