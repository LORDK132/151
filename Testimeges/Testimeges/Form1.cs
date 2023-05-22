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

namespace Testimeges
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.download;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //////pictureBox8.Image = Image.FromFile("downloa.jpg");


            ////Bitmap bmp = new Bitmap("downloa.jpg");
            ////ictureBox8.Image = bmp;



            Bitmap bmp = new Bitmap();
            pictureBox8.Image = bmp;

        }
    }
}
