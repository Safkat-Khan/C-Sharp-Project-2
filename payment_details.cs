using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace C__project
{
    public partial class payment_details : Form
    {
        Random rnd = new Random();
        int number1;
        int number2;
        string pay_option;
        string? id;
        user_dashboard u1;
        public string t_name;
        public string f_station;
        public string t_station;
        public string datE;
        public string ttl_seat;
        public string ttl_price;
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-JE75VAQ\SQLEXPRESS;Initial Catalog=c#_project(ticket);Integrated Security=True");

        public void setTicket(string t_name, string f_station, string t_station, string datE, string ttl_seat, string ttl_price)
        {

            this.t_name = t_name;
            this.f_station = f_station;
            this.t_station = t_station;
            this.datE = datE;
            this.ttl_seat = ttl_seat;
            this.ttl_price = ttl_price;
        }
        public payment_details(string pay_option)
        {
            Form1 f1 = new Form1();
            id = f1.u_id;
            number1 = rnd.Next(20);
            for (int i = 0; i < 5; i++)
            {
                int temp = rnd.Next(20);
                if (number1 != temp)
                {
                    number2 = temp;
                }
            }
            InitializeComponent();
            this.pay_option = pay_option;
        }
        public void setUser(user_dashboard s)
        {
            u1 = s;
        }

        private void payment_details_Load(object sender, EventArgs e)
        {       
            label4.Text = pay_option.ToString();
            //  label4.Text = Font.Name.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        int sum;
        int temp;
        bool accno, pin, capt = false;
        private void button1_Click(object sender, EventArgs e)
        {







        }
        private void buyNowClick(object sender, EventArgs e)
        {
         

              try
                {
                    cn.Open();
                    string quary = "insert into ticket_info2 values('" + t_name + "','" + f_station + "','" + t_station + "','" + datE + "','" + ttl_seat + "','" + ttl_price + "')";
                    SqlCommand cmd = new SqlCommand(quary, cn);
                    int v = cmd.ExecuteNonQuery();
                    cn.Close();
                  MessageBox.Show("Purchasse Done");
                    u1.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }



        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            payment f2 = new payment();
            f2.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
