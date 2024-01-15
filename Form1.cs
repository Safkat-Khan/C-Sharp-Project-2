
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace C__project
{
    public partial class Form1 : Form
    {
        public string? u_id;
        public bool checKnull = false;
        public string? u_email;
        public string? u_name;
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-JE75VAQ\SQLEXPRESS;Initial Catalog=c#_project(ticket);Integrated Security=True");
        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void checkNull()
        {
            if (string.IsNullOrEmpty(shafin1.Text.Trim()))
            {
                checKnull = true;
            }
            if (string.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                checKnull = true;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            u_email = shafin1.Text;
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select* from user_info where u_email=@u_email", cn);
                cmd.Parameters.AddWithValue("u_email", u_email);
                SqlDataReader read;
                read = cmd.ExecuteReader();
                if (read.Read())
                {
                    u_name = read["u_name"].ToString();
                    u_id = read["u_id"].ToString();
                }
                else
                {
                    //MessageBox.Show("No data found");
                }

                cn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("error");
                MessageBox.Show("Error" + ex);
            }
            try
            {
                if (checKnull == true)
                {
                    MessageBox.Show("Fill all the field");
                }
                else
                {
                    string quary = "select* from user_info where u_email='" + shafin1.Text + "'and u_pass='" + textBox2.Text + "' ";
                    SqlDataAdapter adapter = new SqlDataAdapter(quary, cn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        user_dashboard u1 = new user_dashboard(u_id);
                        u1.setUser(u1);
                        u1.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {

            }



        }

        private void label5_Click(object sender, EventArgs e)
        {
            signup s = new signup();
            s.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //string x = "*";

            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            home h1 = new home();
            h1.Show();
            this.Hide();
        }
    }
}