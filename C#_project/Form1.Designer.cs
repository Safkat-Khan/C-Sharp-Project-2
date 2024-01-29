namespace C__project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            shafin1 = new TextBox();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.ForeColor = SystemColors.Control;
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 451);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(61, 140, 149);
            label1.Location = new Point(465, 37);
            label1.Name = "label1";
            label1.Size = new Size(126, 33);
            label1.TabIndex = 1;
            label1.Text = "Welcome ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(465, 70);
            label2.Name = "label2";
            label2.Size = new Size(120, 17);
            label2.TabIndex = 2;
            label2.Text = "To Epic Ticketing";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(61, 140, 149);
            label3.Location = new Point(554, 113);
            label3.Name = "label3";
            label3.Size = new Size(61, 24);
            label3.TabIndex = 3;
            label3.Text = "Sign In";
            // 
            // shafin1
            // 
            shafin1.BorderStyle = BorderStyle.FixedSingle;
            shafin1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            shafin1.Location = new Point(465, 163);
            shafin1.Margin = new Padding(5);
            shafin1.Name = "shafin1";
            shafin1.PlaceholderText = "Enter Your Email";
            shafin1.Size = new Size(263, 27);
            shafin1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(465, 209);
            textBox2.Margin = new Padding(5);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter Your Password";
            textBox2.Size = new Size(263, 27);
            textBox2.TabIndex = 5;
            textBox2.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(465, 244);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(61, 140, 149);
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(465, 300);
            button1.Name = "button1";
            button1.Size = new Size(263, 32);
            button1.TabIndex = 7;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(501, 347);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 8;
            label4.Text = "Dont have any account?";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(230, 135, 60);
            label5.Location = new Point(639, 347);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 9;
            label5.Text = "Sign Up";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(416, 9);
            label6.Name = "label6";
            label6.Size = new Size(49, 17);
            label6.TabIndex = 10;
            label6.Text = "< Back";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(shafin1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "6";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;

        private Label label2;
        private Label label3;
        private TextBox shafin1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}