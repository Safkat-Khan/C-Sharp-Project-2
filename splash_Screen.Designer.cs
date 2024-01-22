namespace C__project
{
    partial class splash_Screen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash_Screen));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(194, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 272);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(118, 167);
            label1.Name = "label1";
            label1.Size = new Size(155, 24);
            label1.TabIndex = 0;
            label1.Text = "Epic Ticketing";
            // 
            // panel2
            // 
            panel2.Location = new Point(1, 426);
            panel2.Name = "panel2";
            panel2.Size = new Size(799, 27);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(230, 135, 60);
            panel3.Location = new Point(1, 426);
            panel3.Name = "panel3";
            panel3.Size = new Size(20, 24);
            panel3.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // splash_Screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 140, 149);
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "splash_Screen";
            Text = "splash_Screen";
            Load += splash_Screen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private System.Windows.Forms.Timer timer1;
    }
}