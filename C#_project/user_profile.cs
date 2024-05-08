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
using System.Xml.Linq;

namespace C__project
{
    public partial class user_profile : Form
    {
        public string? user_id;
        public string? user_name;
        public string? user_email;
        public string? user_password;
        public string? user_phone;
        public string? user_gender;
        public string? user_dob;
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-JE75VAQ\SQLEXPRESS;Initial Catalog=c#_project(ticket);Integrated Security=True");
        public user_profile(string? user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select* from user_info where u_id=@user_id", cn);
                cmd.Parameters.AddWithValue("user_id", int.Parse(user_id));
                SqlDataAdapter std = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                std.Fill(dt);
                user_name = dt.Rows[0]["u_name"].ToString();
                user_phone = dt.Rows[0]["u_phone"].ToString();
                user_email = dt.Rows[0]["u_email"].ToString();
                user_dob = dt.Rows[0]["u_dob"].ToString();
                user_gender = dt.Rows[0]["u_gender"].ToString();
                user_password = dt.Rows[0]["u_pass"].ToString();


                cn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("error");
                MessageBox.Show("Error" + ex);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_profile_Load(object sender, EventArgs e)
        {
            name.Text = user_name;
            phone.Text = user_phone;
            email.Text = user_email;
            dob.Text = user_dob;
            gender.Text = user_gender;
            password.Text = user_password;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            T_select t1 = new T_select(user_name, true);
            // T_select t1 = new T_select();
            t1.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
