namespace Profile_Mainmenu.Pages
{
    partial class Form1
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

        private void InitializeComponent()
        {
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            fontDialog1 = new FontDialog();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 567);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Font = new Font("Onest", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 308);
            button3.Name = "button3";
            button3.Size = new Size(186, 52);
            button3.TabIndex = 2;
            button3.Text = "settings";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Onest", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 250);
            button2.Name = "button2";
            button2.Size = new Size(186, 52);
            button2.TabIndex = 1;
            button2.Text = "search";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Onest", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 192);
            button1.Name = "button1";
            button1.Size = new Size(186, 52);
            button1.TabIndex = 0;
            button1.Text = "menu";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 47);
            label1.Name = "label1";
            label1.Size = new Size(649, 65);
            label1.TabIndex = 1;
            label1.Text = "UserName_and_Surname";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(72, 19, 38);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(236, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(846, 238);
            panel2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Onest", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 192, 192);
            label5.Location = new Point(23, 85);
            label5.Name = "label5";
            label5.Size = new Size(292, 27);
            label5.TabIndex = 2;
            label5.Text = "Full name: Username_and_Surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Onest", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 21);
            label4.Name = "label4";
            label4.Size = new Size(317, 51);
            label4.TabIndex = 1;
            label4.Text = "Profile Information";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Onest", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 192, 192);
            label3.Location = new Point(23, 112);
            label3.Name = "label3";
            label3.Size = new Size(238, 27);
            label3.TabIndex = 3;
            label3.Text = "Email address: User_address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Onest", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 192, 192);
            label6.Location = new Point(23, 139);
            label6.Name = "label6";
            label6.Size = new Size(343, 27);
            label6.TabIndex = 4;
            label6.Text = "Phone number: Username_phone_number";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Onest", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(255, 192, 192);
            label7.Location = new Point(23, 168);
            label7.Name = "label7";
            label7.Size = new Size(377, 27);
            label7.TabIndex = 5;
            label7.Text = "Subscription status:  Workspace Membership ";
            label7.Click += label7_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(115, 49, 71);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(236, 413);
            panel3.Name = "panel3";
            panel3.Size = new Size(846, 140);
            panel3.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Onest", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(255, 192, 192);
            label9.Location = new Point(31, 98);
            label9.Name = "label9";
            label9.Size = new Size(280, 27);
            label9.TabIndex = 3;
            label9.Text = "you attended {number} of events";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Onest", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(255, 192, 192);
            label10.Location = new Point(31, 62);
            label10.Name = "label10";
            label10.Size = new Size(300, 27);
            label10.TabIndex = 2;
            label10.Text = "you bought a subscription to  (Date)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Onest", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(23, 11);
            label11.Name = "label11";
            label11.Size = new Size(282, 51);
            label11.TabIndex = 1;
            label11.Text = "Profile Statistics";
            label11.Click += label11_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 565);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Button button2;
        private Button button1;
        private Button button3;
        private FontDialog fontDialog1;
        private Label label6;
        private Label label3;
        private Label label7;
        private Panel panel3;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}
