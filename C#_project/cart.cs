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
using System.Data.SqlClient;

namespace C__project
{
    public partial class cart : Form
    {
        public string? username;
        public string? f_station;
        public string? t_station;
        public string? t_name;
        public string? date;
        public string? ttlet;
        public string? ttlprice;
        user_dashboard? s;
        public void setUser(user_dashboard s)
        {
            this.s = s;
        }
        public cart()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-JE75VAQ\SQLEXPRESS;Initial Catalog=c#_project(ticket);Integrated Security=True");

        public cart(string? username)
        {
            InitializeComponent();
            this.username = username;

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select* from ticket_info2 ", cn);

                SqlDataAdapter std = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                std.Fill(dt);
                int siz=(dt.Rows.Count)-1;
                t_name = dt.Rows[siz]["trainName"].ToString();
                f_station = dt.Rows[siz]["f_station"].ToString();
                t_station = dt.Rows[siz]["t_station"].ToString();
                date = dt.Rows[siz]["datE"].ToString();
                ttlet = dt.Rows[siz]["total_seat"].ToString();
                ttlprice = dt.Rows[siz]["total_price"].ToString();

                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }

        private void cart_Load(object sender, EventArgs e)
        {
            userN.Text = username;
            trainN.Text = t_name;
            fStation.Text = f_station;
            tStation.Text = t_station;
            totalS.Text = ttlet;
            totalP.Text = ttlprice;
            tDate.Text = date;

        }

        private void button30_Click(object sender, EventArgs e)
        {
            s.Show();
            this.Hide();
        }
    }
}
