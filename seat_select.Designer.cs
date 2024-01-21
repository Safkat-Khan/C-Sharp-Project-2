namespace C__project
{
    partial class seat_select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seat_select));
            panel4 = new Panel();
            label2 = new Label();
            label1 = new Label();
            button30 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            seatcnt = new Label();
            label3 = new Label();
            station2 = new Label();
            label6 = new Label();
            station1 = new Label();
            label4 = new Label();
            Date = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Location = new Point(-8, -3);
            panel4.Name = "panel4";
            panel4.Size = new Size(811, 143);
            panel4.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(138, 11);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 10;
            label2.Text = "Train name 1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(292, 166);
            label1.Name = "label1";
            label1.Size = new Size(173, 21);
            label1.TabIndex = 9;
            label1.Text = "Avaliable Trains Time";
            // 
            // button30
            // 
            button30.BackColor = Color.FromArgb(61, 140, 149);
            button30.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button30.ForeColor = Color.White;
            button30.Location = new Point(565, 403);
            button30.Name = "button30";
            button30.Size = new Size(175, 35);
            button30.TabIndex = 40;
            button30.Text = "Next";
            button30.UseVisualStyleBackColor = false;
            button30.Click += button30_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(61, 140, 149);
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(45, 403);
            button1.Name = "button1";
            button1.Size = new Size(175, 35);
            button1.TabIndex = 41;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(61, 140, 149);
            panel1.Controls.Add(Date);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(seatcnt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(station2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(station1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(168, 214);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 145);
            panel1.TabIndex = 42;
            // 
            // seatcnt
            // 
            seatcnt.AutoSize = true;
            seatcnt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            seatcnt.ForeColor = Color.White;
            seatcnt.Location = new Point(378, 115);
            seatcnt.Name = "seatcnt";
            seatcnt.Size = new Size(22, 17);
            seatcnt.TabIndex = 19;
            seatcnt.Text = "25";
            seatcnt.Click += seatcnt_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(281, 115);
            label3.Name = "label3";
            label3.Size = new Size(95, 17);
            label3.TabIndex = 18;
            label3.Text = "Available seat :";
            // 
            // station2
            // 
            station2.AutoSize = true;
            station2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            station2.ForeColor = Color.White;
            station2.Location = new Point(311, 56);
            station2.Name = "station2";
            station2.Size = new Size(55, 17);
            station2.TabIndex = 15;
            station2.Text = "Station2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(281, 56);
            label6.Name = "label6";
            label6.Size = new Size(29, 17);
            label6.TabIndex = 14;
            label6.Text = "To :";
            // 
            // station1
            // 
            station1.AutoSize = true;
            station1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            station1.ForeColor = Color.White;
            station1.Location = new Point(68, 56);
            station1.Name = "station1";
            station1.Size = new Size(55, 17);
            station1.TabIndex = 13;
            station1.Text = "Station1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(22, 56);
            label4.Name = "label4";
            label4.Size = new Size(45, 17);
            label4.TabIndex = 12;
            label4.Text = "From :";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Date.ForeColor = Color.White;
            Date.Location = new Point(123, 115);
            Date.Name = "Date";
            Date.Size = new Size(38, 17);
            Date.TabIndex = 21;
            Date.Text = "DATE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(22, 115);
            label8.Name = "label8";
            label8.Size = new Size(104, 17);
            label8.TabIndex = 20;
            label8.Text = "Travelling date : ";
            // 
            // seat_select
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(button30);
            Controls.Add(label1);
            Controls.Add(panel4);
            Name = "seat_select";
            Text = "seat_select";
            Load += seat_select_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel4;
        private Label label2;
        private Label label1;
        private Button button30;
        private Button button1;
        private Panel panel1;
        private Label station1;
        private Label label4;
        private Label seatcnt;
        private Label label3;
        private Label station2;
        private Label label6;
        private Label Date;
        private Label label8;
    }
}