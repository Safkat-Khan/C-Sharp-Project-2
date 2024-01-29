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
    public partial class seat_select : Form
    {
        string f_station;
        string t_station;
        DateTime datee;
        string clss;
        string trainN;
        user_dashboard? u1;

        seat_select s;
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-JE75VAQ\SQLEXPRESS;Initial Catalog=c#_project(ticket);Integrated Security=True");
        public seat_select()
        {
            InitializeComponent();

        }
        public void setUser(user_dashboard s)
        {
            u1 = s;
        }
        public void setOBJ(seat_select s)
        {
            this.s = s;
        }
        public seat_select(string f_station, string t_station, DateTime date, string cls)
        {
            InitializeComponent();
            this.f_station = f_station;
            this.t_station = t_station;
            this.datee = date;
            this.clss = cls;
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select* from t_details ", cn);
                // cmd.Parameters.AddWithValue("t_id", int.Parse(t_id));
                SqlDataAdapter std = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                std.Fill(dt);
                trainN = dt.Rows[0]["t_name"].ToString();

                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }


        }

        private void button30_Click(object sender, EventArgs e)
        {
            t_seat s1 = new t_seat(trainN, f_station, t_station, datee, clss);
            s1.setUser(u1);
            s1.setOBj(s);
            s1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            T_select s = new T_select();
            s.Show();
            this.Hide();
        }

        private void seat_select_Load(object sender, EventArgs e)
        {
            station1.Text = f_station;
            station2.Text = t_station;
            Date.Text = datee.ToString();
            //cls.Text = clss;
            label2.Text = trainN.ToString();
        }

        private void seatcnt_Click(object sender, EventArgs e)
        {

        }
    }
}
