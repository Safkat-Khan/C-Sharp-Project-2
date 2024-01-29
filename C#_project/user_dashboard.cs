using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Data.SqlClient;


namespace C__project
{
    public partial class user_dashboard : Form
    {
        public string? user_id;
        public string? user_name;
        public string? user_email;
        user_dashboard? s;
        public void setUser(user_dashboard s)
        {
            this.s = s;
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-JE75VAQ\SQLEXPRESS;Initial Catalog=c#_project(ticket);Integrated Security=True");

        
        public user_dashboard(string? user_id)
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
                user_email = dt.Rows[0]["u_email"].ToString();

                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            user_profile f1 = new user_profile(user_id);
            f1.Show();
            this.Hide();
        }

        private void user_dashboard_Load(object sender, EventArgs e)
        {
            label1.Text = user_name;
            label2.Text = user_email;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            T_select t1 = new T_select(user_name, true);
            t1.setUser(s);
            // T_select t1 = new T_select();
            t1.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            cart c= new cart(user_name);
            c.setUser(s);
            c.Show();
            this.Hide();
        }
    }
}
