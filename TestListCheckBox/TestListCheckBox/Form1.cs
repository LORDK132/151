using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestListCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butshow_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < chList.CheckedItems.Count; x += 1)
            {
                MessageBox.Show(chList.CheckedItems[x].ToString());
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addtolist_Click(object sender, EventArgs e)
        {
            if (text.Text == "") { MessageBox.Show("Enter Name"); }
            else { chList.Items.Add(text.Text); }    
            
           
            

        }
    }
}
