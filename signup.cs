using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace C__project
{
    public partial class signup : Form
    {
        bool checKnull = false;
        Random rnd= new Random();
        int u_id;
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-JE75VAQ\SQLEXPRESS;Initial Catalog=c#_project(ticket);Integrated Security=True");
        public signup()
        {
            u_id = rnd.Next(1000);
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void signup_Load(object sender, EventArgs e)
        {
            textBox3.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void checkNull()
        {
            if(string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                checKnull=true;
            }
            if(string.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                checKnull=true;
            }
            if (string.IsNullOrEmpty(textBox3.Text.Trim()))
            {
                checKnull = true;
            }
            if(string.IsNullOrEmpty(textBox5.Text.Trim()))
            {
                checKnull = true;
            }
            if(comboBox1.Text.Trim().Length == 0)
            {
                checKnull=true;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                checkNull();
                if (checKnull==true)
                {
                    MessageBox.Show("Fill all the field");
                }
                else
                {
                    cn.Open();
                    String quary = "insert into user_info values('" + u_id + "','" + textBox1.Text + "','" + textBox5.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Text + "','" + textBox2.Text + "')";
                    SqlCommand cmd = new SqlCommand(quary, cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    Form1 f1= new Form1();
                    f1.Show();
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
