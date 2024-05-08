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
    public partial class admin_dashboard : Form
    {
        public admin_dashboard()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-JE75VAQ\SQLEXPRESS;Initial Catalog=c#_project(ticket);Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            adminLogin d1 = new adminLogin();
            d1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select* from user_info ", cn);

                SqlDataAdapter std = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                std.Fill(dt);
                dataGridView1.DataSource = dt;

                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }
    }
}
