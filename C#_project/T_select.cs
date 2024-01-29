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
    public partial class T_select : Form
    {
        bool is_login = false;
        string? name;
        string f_station;
        string t_station;
        DateTime date_t;
        string cls;
        seat_select s;
        user_dashboard? u1;

        public T_select()
        {
            InitializeComponent();
        }
        public void setUser(user_dashboard s)
        {
            u1 = s;
        }
        public T_select(string name, bool is_login)
        {
            InitializeComponent();
            this.is_login = is_login;
            this.name = name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            f_station = comboBox1.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date_t = dateTimePicker1.Value;
        }

        private void T_select_Load(object sender, EventArgs e)
        {


            u_name.Text = name;
            u_name.Visible = true;
            panel2.Visible = true;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            seat_select s1 = new seat_select(f_station, t_station, date_t, cls);
            s1.setUser(u1);
            s1.setOBJ(s1);
            s1.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            t_station = comboBox2.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls = comboBox3.Text;
        }
    }
}
