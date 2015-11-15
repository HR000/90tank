using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My90Tank
{
    public partial class Judge : Form
    {
        public Judge()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.Owner = this;

        }

        private void btnPlay1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form1.numOfPlayer = 1;
            Scene.numOfPlayer = 1;
            f1.Show();
            //this.Close();
        }

        private void btnPlayer2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Scene.numOfPlayer = 2;
            Form1.numOfPlayer = 2;
            f1.Show();
            //this.Close();
        }

     
    }
}
