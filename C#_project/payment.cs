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
    public partial class payment : Form
    {
        
        string pay_option;
        user_dashboard? u1;
        public string t_name;
        public string f_station;
        public string t_station;
        public string datE;
        public string ttl_seat;
        public string ttl_price;
        public void setTicket(string t_name, string f_station, string t_station, string datE, string ttl_seat, string ttl_price)
        {
            this.t_name = t_name;
            this.f_station = f_station;
            this.t_station = t_station;
            this.datE = datE;
            this.ttl_seat = ttl_seat;
            this.ttl_price = ttl_price;
        }
        public payment()
        {
            InitializeComponent();
        }
       
        public void setUser(user_dashboard s)
        {
            u1 = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            payment_details f1 = new payment_details(pay_option);
            f1.setTicket(t_name, f_station, t_station,datE, ttl_seat, ttl_price);
            f1.setUser(u1);
            f1.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pay_option = "bKash";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pay_option = "Nagad";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pay_option = "Mastercard";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            order_details od = new order_details();
            od.Show();
            this.Hide();
        }

        private void payment_Load(object sender, EventArgs e)
        {

        }
    }
}
