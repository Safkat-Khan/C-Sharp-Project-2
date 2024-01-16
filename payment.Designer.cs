namespace C__project
{
    partial class payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payment));
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            panel5 = new Panel();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label3 = new Label();
            radioButton3 = new RadioButton();
            label4 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(281, 105);
            label1.Name = "label1";
            label1.Size = new Size(256, 32);
            label1.TabIndex = 1;
            label1.Text = "Avaliable Trains Time";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(155, 185);
            panel1.Name = "panel1";
            panel1.Size = new Size(124, 78);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(347, 185);
            panel2.Name = "panel2";
            panel2.Size = new Size(124, 78);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(526, 185);
            panel3.Name = "panel3";
            panel3.Size = new Size(124, 78);
            panel3.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(61, 140, 149);
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(64, 394);
            button1.Name = "button1";
            button1.Size = new Size(144, 35);
            button1.TabIndex = 6;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Location = new Point(329, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(152, 82);
            panel5.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(164, 286);
            label2.Name = "label2";
            label2.Size = new Size(102, 19);
            label2.TabIndex = 8;
            label2.Text = "Pay with bKash";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(177, 269);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 21);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "bKash";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(374, 269);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(66, 21);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nagad";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(361, 286);
            label3.Name = "label3";
            label3.Size = new Size(105, 19);
            label3.TabIndex = 10;
            label3.Text = "Pay with Nagad";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.Location = new Point(548, 269);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 21);
            radioButton3.TabIndex = 13;
            radioButton3.TabStop = true;
            radioButton3.Text = "Mastercard";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(531, 286);
            label4.Name = "label4";
            label4.Size = new Size(134, 19);
            label4.TabIndex = 12;
            label4.Text = "Pay with Mastercard";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(61, 140, 149);
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(587, 394);
            button2.Name = "button2";
            button2.Size = new Size(144, 35);
            button2.TabIndex = 14;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(radioButton3);
            Controls.Add(label4);
            Controls.Add(radioButton2);
            Controls.Add(label3);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(panel5);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "payment";
            Text = "payment";
            Load += payment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Panel panel5;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label3;
        private RadioButton radioButton3;
        private Label label4;
        private Button button2;
    }
}