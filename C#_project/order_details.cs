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
    public partial class order_details : Form
    {
        public string trainN;
        public string set1;
        public string set2;
        public string ttlst;
        public string datE;
        string t_id;
        int price;
        user_dashboard? u1;
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-JE75VAQ\SQLEXPRESS;Initial Catalog=c#_project(ticket);Integrated Security=True");
        public order_details()
        {
            InitializeComponent();
        }
        public void setUser(user_dashboard s)
        {
            u1 = s;
        }
        public order_details(string name, string st1, string st2, string ttlst,string datE)
        {
            InitializeComponent();
            this.trainN = name;
            this.ttlst = ttlst;
            set1 = st1;
            set2 = st2;
            price = int.Parse(ttlst) * 1000;
            this.datE = datE;


        }

        private void button29_Click(object sender, EventArgs e)
        {
            payment p1 = new payment();
            p1.setTicket(trainN,set1,set2,datE,ttlst,price.ToString());
            p1.setUser(u1);
            p1.Show();
            this.Hide();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            t_seat t1 = new t_seat();
            t1.Show();
            this.Hide();
        }

        private void order_details_Load(object sender, EventArgs e)
        {
            name.Text = trainN;
            st1.Text = set1;
            label2.Text = set2;
            label4.Text = ttlst;
            label6.Text = price.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
