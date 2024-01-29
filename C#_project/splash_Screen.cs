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
    public partial class splash_Screen : Form
    {
        public splash_Screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Width += 5;
            if (panel3.Width >= 799)
            {

                timer1.Stop();
                // MessageBox.Show("DOne");
                home t1 = new home();
                t1.Show();
                this.Hide();
            }
        }

        private void splash_Screen_Load(object sender, EventArgs e)
        {

        }
    }
}
