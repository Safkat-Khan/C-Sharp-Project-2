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
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }

        private void adminLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.ToLower();
            if (textBox1.Text != null && textBox2.Text != null)
            {
                if (username == "admin")
                {
                    if (textBox2.Text == "12345")
                    {
                        admin_dashboard d1 = new admin_dashboard();
                        d1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password");
                    }
                }
                else
                {
                    MessageBox.Show("incorrect username");
                }
            }
            else
            {
                MessageBox.Show("Enter username or password");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            home h1= new home();    
            h1.Show();
            this.Hide();
        }
    }
}
