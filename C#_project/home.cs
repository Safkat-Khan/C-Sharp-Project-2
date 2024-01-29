using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__project
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            signup s1 = new signup();
            s1.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            adminLogin s1 = new adminLogin();
            s1.Show();
            this.Hide();
        }
    }
}
