using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCombo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cob.Items.Add(text.Text);

        }

        private void addstring_Click(object sender, EventArgs e)
        {
         
        }

        private void cob_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
