namespace C__project
{
    partial class user_profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_profile));
            panel3 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            label6 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            panel6 = new Panel();
            name = new Label();
            label9 = new Label();
            panel7 = new Panel();
            phone = new Label();
            label12 = new Label();
            panel8 = new Panel();
            email = new Label();
            label14 = new Label();
            panel9 = new Panel();
            gender = new Label();
            label16 = new Label();
            panel10 = new Panel();
            password = new Label();
            label18 = new Label();
            button1 = new Button();
            panel11 = new Panel();
            dob = new Label();
            label20 = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(61, 140, 149);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(251, 169);
            panel3.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(39, 11);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(118, 80);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 135);
            label2.Name = "label2";
            label2.Size = new Size(185, 23);
            label2.TabIndex = 2;
            label2.Text = "Shafin1231@gmail.com";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 112);
            label1.Name = "label1";
            label1.Size = new Size(161, 23);
            label1.TabIndex = 1;
            label1.Text = "Tafsirul Islam Shafin";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(230, 135, 60);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 157);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 445);
            panel1.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(61, 140, 149);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(-10, 396);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(262, 52);
            panel5.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(23, 8);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 3;
            label6.Text = "Sign Out";
            label6.Click += label6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(13, 227);
            label8.Name = "label8";
            label8.Size = new Size(122, 25);
            label8.TabIndex = 5;
            label8.Text = "Avaible Train";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 176);
            label7.Name = "label7";
            label7.Size = new Size(100, 25);
            label7.TabIndex = 4;
            label7.Text = "Buy Ticket";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(13, 275);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 2;
            label5.Text = "Cart";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(13, 124);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 1;
            label4.Text = "Profile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 76);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 0;
            label3.Text = "Home";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Location = new Point(495, 11);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(134, 124);
            panel4.TabIndex = 6;
            panel4.Paint += panel4_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gainsboro;
            panel6.Controls.Add(name);
            panel6.Controls.Add(label9);
            panel6.Location = new Point(354, 157);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(431, 48);
            panel6.TabIndex = 7;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            name.Location = new Point(141, 12);
            name.Name = "name";
            name.Size = new Size(0, 23);
            name.TabIndex = 1;
            name.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(14, 12);
            label9.Name = "label9";
            label9.Size = new Size(67, 23);
            label9.TabIndex = 0;
            label9.Text = "Name :";
            label9.Click += label9_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Gainsboro;
            panel7.Controls.Add(phone);
            panel7.Controls.Add(label12);
            panel7.Location = new Point(354, 213);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(431, 48);
            panel7.TabIndex = 8;
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            phone.Location = new Point(141, 12);
            phone.Name = "phone";
            phone.Size = new Size(0, 23);
            phone.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(14, 12);
            label12.Name = "label12";
            label12.Size = new Size(69, 23);
            label12.TabIndex = 0;
            label12.Text = "Phone :";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Gainsboro;
            panel8.Controls.Add(email);
            panel8.Controls.Add(label14);
            panel8.Location = new Point(354, 269);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(431, 48);
            panel8.TabIndex = 9;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            email.Location = new Point(141, 12);
            email.Name = "email";
            email.Size = new Size(0, 23);
            email.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(14, 12);
            label14.Name = "label14";
            label14.Size = new Size(64, 23);
            label14.TabIndex = 0;
            label14.Text = "Email :";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Gainsboro;
            panel9.Controls.Add(gender);
            panel9.Controls.Add(label16);
            panel9.Location = new Point(354, 384);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(431, 48);
            panel9.TabIndex = 10;
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gender.Location = new Point(141, 12);
            gender.Name = "gender";
            gender.Size = new Size(0, 23);
            gender.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(14, 12);
            label16.Name = "label16";
            label16.Size = new Size(78, 23);
            label16.TabIndex = 0;
            label16.Text = "Gender :";
            // 
            // panel10
            // 
            panel10.BackColor = Color.Gainsboro;
            panel10.Controls.Add(password);
            panel10.Controls.Add(label18);
            panel10.Location = new Point(354, 440);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(431, 48);
            panel10.TabIndex = 8;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            password.Location = new Point(141, 12);
            password.Name = "password";
            password.Size = new Size(0, 23);
            password.TabIndex = 1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(14, 12);
            label18.Name = "label18";
            label18.Size = new Size(95, 23);
            label18.TabIndex = 0;
            label18.Text = "Password :";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(61, 140, 149);
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(726, 541);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(165, 47);
            button1.TabIndex = 11;
            button1.Text = "Update Profile";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Gainsboro;
            panel11.Controls.Add(dob);
            panel11.Controls.Add(label20);
            panel11.Location = new Point(354, 325);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(431, 48);
            panel11.TabIndex = 11;
            // 
            // dob
            // 
            dob.AutoSize = true;
            dob.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dob.Location = new Point(141, 12);
            dob.Name = "dob";
            dob.Size = new Size(0, 23);
            dob.TabIndex = 1;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(14, 12);
            label20.Name = "label20";
            label20.Size = new Size(57, 23);
            label20.TabIndex = 0;
            label20.Text = "DOB :";
            // 
            // user_profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(panel11);
            Controls.Add(button1);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "user_profile";
            Text = "user_profile";
            Load += user_profile_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel panel5;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel4;
        private Panel panel6;
        private Label name;
        private Label label9;
        private Panel panel7;
        private Label phone;
        private Label label12;
        private Panel panel8;
        private Label email;
        private Label label14;
        private Panel panel9;
        private Label gender;
        private Label label16;
        private Panel panel10;
        private Label password;
        private Label label18;
        private Button button1;
        private Panel panel11;
        private Label dob;
        private Label label20;
    }
}