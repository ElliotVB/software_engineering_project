namespace Profile_Mainmenu
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
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            label7 = new Label();
            panel5 = new Panel();
            label8 = new Label();
            fontDialog1 = new FontDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
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
            label1.Location = new Point(236, 21);
            label1.Name = "label1";
            label1.Size = new Size(292, 65);
            label1.TabIndex = 1;
            label1.Text = "Hello, User";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Konkhmer Sleokchher", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(236, 104);
            label2.Name = "label2";
            label2.Size = new Size(112, 29);
            label2.TabIndex = 2;
            label2.Text = "coming event";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(72, 19, 38);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(236, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(846, 159);
            panel2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Onest", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 192, 192);
            label5.Location = new Point(23, 95);
            label5.Name = "label5";
            label5.Size = new Size(180, 27);
            label5.TabIndex = 2;
            label5.Text = "event_date_and_time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Onest", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 192, 192);
            label4.Location = new Point(23, 68);
            label4.Name = "label4";
            label4.Size = new Size(248, 27);
            label4.TabIndex = 1;
            label4.Text = "event_address_and_postcode";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Konkhmer Sleokchher", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(14, 14);
            label3.Name = "label3";
            label3.Size = new Size(236, 67);
            label3.TabIndex = 0;
            label3.Text = "Event_Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Inter Tight Light", 19.8000011F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(14, 14);
            label6.Name = "label6";
            label6.Size = new Size(207, 49);
            label6.TabIndex = 0;
            label6.Text = "Subscription";
            // 
            // panel3
            // 
            panel3.BackColor = Color.RosyBrown;
            panel3.Controls.Add(label6);
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(236, 338);
            panel3.Name = "panel3";
            panel3.Size = new Size(278, 215);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 229, 180);
            panel4.Controls.Add(label7);
            panel4.Cursor = Cursors.Hand;
            panel4.Location = new Point(804, 338);
            panel4.Name = "panel4";
            panel4.Size = new Size(278, 215);
            panel4.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Inter Tight Light", 19.8000011F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(14, 14);
            label7.Name = "label7";
            label7.Size = new Size(115, 49);
            label7.TabIndex = 0;
            label7.Text = "Profile";
            // 
            // panel5
            // 
            panel5.BackColor = Color.SlateGray;
            panel5.Controls.Add(label8);
            panel5.Cursor = Cursors.Hand;
            panel5.ForeColor = Color.CornflowerBlue;
            panel5.Location = new Point(520, 338);
            panel5.Name = "panel5";
            panel5.Size = new Size(278, 215);
            panel5.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Inter Tight Light", 19.8000011F);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(14, 14);
            label8.Name = "label8";
            label8.Size = new Size(156, 49);
            label8.TabIndex = 0;
            label8.Text = "Activities";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 565);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel3;
        private Panel panel4;
        private Label label7;
        private Panel panel5;
        private Label label8;
        private Button button2;
        private Button button1;
        private Button button3;
        private FontDialog fontDialog1;
    }
}
