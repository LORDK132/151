using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBtn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi "+text1.Text);

        }

        private void ok_MouseHover(object sender, EventArgs e)
        {
            text1.Visible = true;
            text1.Focus();
        }

        private void ok_MouseLeave(object sender, EventArgs e)
        {
            text1.Visible = false;
            
        }

        private void ok_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
