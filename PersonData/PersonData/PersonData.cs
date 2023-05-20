using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PersonData
{
    public partial class PersonData : Form
    {
        public PersonData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader srr = new StreamReader("Data.txt");
            string stAll = "";
            bool bl = false;
            do
            {
                stAll = srr.ReadLine();
                if (stAll != null)
                {
                    string[] strData = stAll.Split('-');
                    if (strData[0] == textId.Text)
                    {
                        textId.Text = strData[0];
                        textName.Text = strData[1];
                        textAdres.Text = strData[2];
                        bl = true;
                        break;
                    }

                }

            } while (stAll != null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frmShow = new Form();
            TextBox txtShow = new TextBox();
            frmShow.StartPosition = FormStartPosition.CenterScreen;
            frmShow.Font = this.Font;
            frmShow.Icon = this.Icon;
            frmShow.Size = this.Size;
            frmShow.Text = "All Data";
            txtShow.Multiline = true;
            txtShow.Dock = DockStyle.Fill;
            frmShow.Controls.Add(txtShow);
            try
            {
                StreamReader sr = new StreamReader("Data.txt");
                string strall = sr.ReadToEnd();
                sr.Close();
                txtShow.Text = strall;

            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            frmShow.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PersonData_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (textId.Text.Trim() == "" || textName.Text.Trim() == "" || textAdres.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter All Data and Try Agan");
                return;
            }
            StreamReader srCheck = new StreamReader("Data.txt",true);
            string strCheck = srCheck.ReadToEnd();
            srCheck.Close();
            if (strCheck.Contains(textId.Text + "-")) { MessageBox.Show("This ID is Exist, Plese change and Try agin"); textId.Focus(); textId.Focus(); textId.SelectAll(); }
            else
            {
                StreamWriter sw = new StreamWriter("Data.txt", true);
                string str = textId.Text + '-' + textName.Text + '-' + textAdres.Text;
                sw.WriteLine(str);
                sw.Close();

                foreach (Control x in this.Controls) { if (x is TextBox) x.Text = ""; }

                //textId.Text = "";
                //textName.Text = "";
                //textAdres.Text = "";

                MessageBox.Show("Person Is Added");
            }

        }

        private void textId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
