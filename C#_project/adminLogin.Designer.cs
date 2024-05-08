namespace C__project
{
    partial class adminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminLogin));
            button1 = new Button();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(61, 140, 149);
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(470, 301);
            button1.Name = "button1";
            button1.Size = new Size(263, 32);
            button1.TabIndex = 17;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(470, 245);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(470, 210);
            textBox2.Margin = new Padding(5);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter Your Password";
            textBox2.Size = new Size(263, 27);
            textBox2.TabIndex = 15;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(470, 164);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Your Email";
            textBox1.Size = new Size(263, 27);
            textBox1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(61, 140, 149);
            label3.Location = new Point(534, 114);
            label3.Name = "label3";
            label3.Size = new Size(113, 24);
            label3.TabIndex = 13;
            label3.Text = "Admin Sign In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(470, 66);
            label2.Name = "label2";
            label2.Size = new Size(120, 17);
            label2.TabIndex = 12;
            label2.Text = "To Epic Ticketing";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(61, 140, 149);
            label1.Location = new Point(470, 33);
            label1.Name = "label1";
            label1.Size = new Size(126, 33);
            label1.TabIndex = 11;
            label1.Text = "Welcome ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.ForeColor = SystemColors.Control;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 451);
            panel1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(422, 7);
            label6.Name = "label6";
            label6.Size = new Size(49, 17);
            label6.TabIndex = 18;
            label6.Text = "< Back";
            label6.Click += label6_Click;
            // 
            // adminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "adminLogin";
            Text = "adminLogin";
            Load += adminLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label6;
    }
}