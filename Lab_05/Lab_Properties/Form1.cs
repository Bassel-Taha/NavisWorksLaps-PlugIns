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

        private void button1_Click(object sender, EventArgs e)
        {
            var path = "C:\\Users\\basse\\Desktop\\prop.txt";
            var output = DumpProperties.OutPut;
            File.WriteAllText(path, output);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
