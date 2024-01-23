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

namespace C__project
{
    public partial class t_seat : Form
    {
        int[] st_color = { 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0 };
        Button[] bt = new Button[28];
        Button[] booked_bt = new Button[28];
        public int[] btnarry = new int[29];
        int seatCnt = 0;
        int[] cnt = new int[100];
        Button? temp;
        int ct;
        string f_station;
        string t_station;
        DateTime datee;
        string clss;
        seat_select s;
        string t_id;
        int ttlseat = 0;
        string tname;
        string datE;
        user_dashboard? u1;
        public t_seat()
        {
            InitializeComponent();
        }
        public void setUser(user_dashboard s)
        {
            u1 = s;
        }
        public void setOBj(seat_select seat)
        {
            this.s = seat;
        }
        public t_seat(string tname, string f_station, string t_station, DateTime date, string cls)
        {
            InitializeComponent();
            this.tname = tname;
            this.f_station = f_station;
            this.t_station = t_station;
            this.datee = date;
            this.clss = cls;
            


        }
        public int buttonColor(int cnt, Button button, int setNo)
        {


            btnarry[setNo]++;
            for (int i = 0; i < 28; i++)
            {
                for (int j = 0; j < booked_bt.Length; j++)
                {
                    if (bt[i] != booked_bt[j])
                    {

                        if (bt[i] == button)
                        {
                            if (cnt == 1)
                            {
                                bt[i].BackColor = Color.Red;


                            }
                            else if (cnt == 2)
                            {
                                bt[i].BackColor = Color.Green;


                            }
                        }



                    }
                }
            }



            if (button.BackColor == Color.Red)
            {
                seatCnt++;
            }
            else if (button.BackColor == Color.Green)
            {
                seatCnt--;
            }

            return seatCnt;
        }
        void stColor()
        {
            for (int i = 0; i < 28; i++)
            {
                if (st_color[i] == 0)
                {
                    bt[i].BackColor = Color.Red;
                }
                else if (st_color[i] == 1)
                {
                    bt[i].BackColor = Color.Green;
                }
            }
        }


        private void button30_Click(object sender, EventArgs e)
        {
            // seat_select seat =new seat_select(f_station, t_station, datee, clss);
            s.Show();
            this.Hide();
        }
        void set()
        {

        }
        private void t_seat_Load(object sender, EventArgs e)
        {
            label10.Text = tname;
            bt[0] = A1;
            bt[1] = A2;
            bt[2] = A3;
            bt[3] = A4;
            bt[4] = B1;
            bt[5] = B2;
            bt[6] = B3;
            bt[7] = B4;
            bt[8] = C1;
            bt[9] = C2;
            bt[10] = C3;
            bt[11] = C4;
            bt[12] = D1;
            bt[13] = D2;
            bt[14] = D3;
            bt[15] = D4;
            bt[16] = E1;
            bt[17] = E2;
            bt[18] = E3;
            bt[19] = E4;
            bt[20] = F1;
            bt[21] = F2;
            bt[22] = F3;
            bt[23] = F4;
            bt[24] = G1;
            bt[25] = G2;
            bt[26] = G3;
            bt[27] = G4;
            stColor();
            int k = 0;
            for (int i = 0; i < bt.Length; i++)
            {
                if (bt[i].BackColor == Color.Red)
                {
                    booked_bt[k] = bt[i];
                    k++;
                }
            }



        }

        private void A1_Click(object sender, EventArgs e)
        {
            // slctSet = button2.Text;

            cnt[0]++;
            int temp = 0;
            if (cnt[0] % 2 != 0)
            {
                temp = buttonColor(1, A1, 1);
            }
            else if (cnt[0] % 2 == 0)
            {
                temp = buttonColor(2, A1, 1);
            }
            ttlseat = temp;
        }

        private void A2_Click(object sender, EventArgs e)
        {
            // slctSet = button2.Text;

            cnt[1]++;
            int temp = 0;
            if (cnt[1] % 2 != 0)
            {
                temp = buttonColor(1, A2, 2);
            }
            else if (cnt[1] % 2 == 0)
            {
                temp = buttonColor(2, A2, 2);
            }
            ttlseat = temp;
        }

        private void A3_Click(object sender, EventArgs e)
        {
            //slctSet = button2.Text;

            cnt[2]++;
            int temp = 0;
            if (cnt[2] % 2 != 0)
            {
                temp = buttonColor(1, A3, 3);
            }
            else if (cnt[2] % 2 == 0)
            {
                temp = buttonColor(2, A3, 3);
            }
            ttlseat = temp;
        }

        private void A4_Click(object sender, EventArgs e)
        {
            // slctSet = button2.Text;

            cnt[3]++;
            int temp = 0;
            if (cnt[3] % 2 != 0)
            {
                temp = buttonColor(1, A4, 4);
            }
            else if (cnt[3] % 2 == 0)
            {
                temp = buttonColor(2, A4, 4);
            }
            ttlseat = temp;
        }

        private void B1_Click(object sender, EventArgs e)
        {
            cnt[4]++;
            int temp = 0;
            if (cnt[4] % 2 != 0)
            {
                temp = buttonColor(1, B1, 5);
            }
            else if (cnt[4] % 2 == 0)
            {
                temp = buttonColor(2, B1, 5);
            }
            ttlseat = temp;
        }

        private void B2_Click(object sender, EventArgs e)
        {
            cnt[5]++;
            int temp = 0;
            if (cnt[5] % 2 != 0)
            {
                temp = buttonColor(1, B2, 6);
            }
            else if (cnt[5] % 2 == 0)
            {
                temp = buttonColor(2, B2, 6);
            }
            ttlseat = temp;
        }

        private void B3_Click(object sender, EventArgs e)
        {
            cnt[6]++;
            int temp = 0;
            if (cnt[6] % 2 != 0)
            {
                temp = buttonColor(1, B3, 7);
            }
            else if (cnt[6] % 2 == 0)
            {
                temp = buttonColor(2, B3, 7);
            }
            ttlseat = temp;
        }

        private void B4_Click(object sender, EventArgs e)
        {
            cnt[7]++;
            int temp = 0;
            if (cnt[7] % 2 != 0)
            {
                temp = buttonColor(1, B4, 8);
            }
            else if (cnt[7] % 2 == 0)
            {
                temp = buttonColor(2, B4, 8);
            }
            ttlseat = temp;
        }

        private void C1_Click(object sender, EventArgs e)
        {
            cnt[8]++;
            int temp = 0;
            if (cnt[8] % 2 != 0)
            {
                temp = buttonColor(1, C1, 9);
            }
            else if (cnt[8] % 2 == 0)
            {
                temp = buttonColor(2, C1, 9);
            }
            ttlseat = temp;
        }

        private void C2_Click(object sender, EventArgs e)
        {
            cnt[9]++;
            int temp = 0;
            if (cnt[9] % 2 != 0)
            {
                temp = buttonColor(1, C2, 10);
            }
            else if (cnt[9] % 2 == 0)
            {
                temp = buttonColor(2, C2, 10);
            }
            ttlseat = temp;
        }

        private void C3_Click(object sender, EventArgs e)
        {
            cnt[10]++;
            int temp = 0;
            if (cnt[10] % 2 != 0)
            {
                temp = buttonColor(1, C3, 11);
            }
            else if (cnt[10] % 2 == 0)
            {
                temp = buttonColor(2, C3, 11);
            }
            ttlseat = temp;
        }

        private void C4_Click(object sender, EventArgs e)
        {
            cnt[11]++;
            int temp = 0;
            if (cnt[11] % 2 != 0)
            {
                temp = buttonColor(1, C4, 12);
            }
            else if (cnt[11] % 2 == 0)
            {
                temp = buttonColor(2, C4, 12);
            }
            ttlseat = temp;
        }

        private void D1_Click(object sender, EventArgs e)
        {
            cnt[12]++;
            int temp = 0;
            if (cnt[12] % 2 != 0)
            {
                temp = buttonColor(1, D1, 13);
            }
            else if (cnt[12] % 2 == 0)
            {
                temp = buttonColor(2, D1, 13);
            }
            ttlseat = temp;
        }

        private void D2_Click(object sender, EventArgs e)
        {
            cnt[13]++;
            int temp = 0;
            if (cnt[13] % 2 != 0)
            {
                temp = buttonColor(1, D2, 14);
            }
            else if (cnt[13] % 2 == 0)
            {
                temp = buttonColor(2, D2, 14);
            }
            ttlseat = temp;
        }

        private void D3_Click(object sender, EventArgs e)
        {
            cnt[14]++;
            int temp = 0;
            if (cnt[14] % 2 != 0)
            {
                temp = buttonColor(1, D3, 15);
            }
            else if (cnt[14] % 2 == 0)
            {
                temp = buttonColor(2, D3, 15);
            }
            ttlseat = temp;
        }

        private void D4_Click(object sender, EventArgs e)
        {
            cnt[15]++;
            int temp = 0;
            if (cnt[15] % 2 != 0)
            {
                temp = buttonColor(1, D4, 16);
            }
            else if (cnt[5] % 2 == 0)
            {
                temp = buttonColor(2, D4, 16);
            }
            ttlseat = temp;
        }

        private void E1_Click(object sender, EventArgs e)
        {
            cnt[16]++;
            int temp = 0;
            if (cnt[16] % 2 != 0)
            {
                temp = buttonColor(1, E1, 17);
            }
            else if (cnt[16] % 2 == 0)
            {
                temp = buttonColor(2, E1, 17);
            }
            ttlseat = temp;
        }

        private void E2_Click(object sender, EventArgs e)
        {
            cnt[17]++;
            int temp = 0;
            if (cnt[17] % 2 != 0)
            {
                temp = buttonColor(1, E2, 18);
            }
            else if (cnt[17] % 2 == 0)
            {
                temp = buttonColor(2, E2, 18);
            }
            ttlseat = temp;
        }

        private void E3_Click(object sender, EventArgs e)
        {
            cnt[18]++;
            int temp = 0;
            if (cnt[18] % 2 != 0)
            {
                temp = buttonColor(1, E3, 19);
            }
            else if (cnt[18] % 2 == 0)
            {
                temp = buttonColor(2, E3, 19);
            }
            ttlseat = temp;
        }

        private void E4_Click(object sender, EventArgs e)
        {
            cnt[19]++;
            int temp = 0;
            if (cnt[19] % 2 != 0)
            {
                temp = buttonColor(1, E4, 20);
            }
            else if (cnt[19] % 2 == 0)
            {
                temp = buttonColor(2, E4, 20);
            }
            ttlseat = temp;
        }

        private void F1_Click(object sender, EventArgs e)
        {
            cnt[20]++;
            int temp = 0;
            if (cnt[20] % 2 != 0)
            {
                temp = buttonColor(1, F1, 21);
            }
            else if (cnt[20] % 2 == 0)
            {
                temp = buttonColor(2, F1, 21);
            }
            ttlseat = temp;
        }

        private void F2_Click(object sender, EventArgs e)
        {
            cnt[21]++;
            int temp = 0;
            if (cnt[21] % 2 != 0)
            {
                temp = buttonColor(1, F2, 22);
            }
            else if (cnt[21] % 2 == 0)
            {
                temp = buttonColor(2, F2, 22);
            }
            ttlseat = temp;
        }

        private void F3_Click(object sender, EventArgs e)
        {
            cnt[22]++;
            int temp = 0;
            if (cnt[22] % 2 != 0)
            {
                temp = buttonColor(1, F3, 23);
            }
            else if (cnt[22] % 2 == 0)
            {
                temp = buttonColor(2, F3, 23);
            }
            ttlseat = temp;
        }

        private void F4_Click(object sender, EventArgs e)
        {
            cnt[23]++;
            int temp = 0;
            if (cnt[23] % 2 != 0)
            {
                temp = buttonColor(1, F4, 24);
            }
            else if (cnt[23] % 2 == 0)
            {
                temp = buttonColor(2, F4, 24);
            }
            ttlseat = temp;
        }

        private void G1_Click(object sender, EventArgs e)
        {
            cnt[24]++;
            int temp = 0;
            if (cnt[24] % 2 != 0)
            {
                temp = buttonColor(1, G1, 25);
            }
            else if (cnt[24] % 2 == 0)
            {
                temp = buttonColor(2, G1, 25);
            }
            ttlseat = temp;
        }

        private void G2_Click(object sender, EventArgs e)
        {
            cnt[25]++;
            int temp = 0;
            if (cnt[25] % 2 != 0)
            {
                temp = buttonColor(1, G2, 26);
            }
            else if (cnt[25] % 2 == 0)
            {
                temp = buttonColor(2, G2, 26);
            }
            ttlseat = temp;
        }

        private void G3_Click(object sender, EventArgs e)
        {
            cnt[26]++;
            int temp = 0;
            if (cnt[26] % 2 != 0)
            {
                temp = buttonColor(1, G3, 27);
            }
            else if (cnt[26] % 2 == 0)
            {
                temp = buttonColor(2, G3, 27);
            }
            ttlseat = temp;
        }

        private void G4_Click(object sender, EventArgs e)
        {
            cnt[27]++;
            int temp = 0;
            if (cnt[27] % 2 != 0)
            {
                temp = buttonColor(1, G4, 28);
            }
            else if (cnt[27] % 2 == 0)
            {
                temp = buttonColor(2, G4, 28);
            }
            ttlseat = temp;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            order_details od = new order_details(tname, f_station, t_station,ttlseat.ToString(),datee.ToString());
            od.setUser(u1);
            od.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
