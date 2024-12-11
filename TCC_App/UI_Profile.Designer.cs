namespace TCC_App
{
    partial class UI_Profile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_Profile));
            this.Coming_EventBT = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.edit_BT = new System.Windows.Forms.Button();
            this.Subs_status = new System.Windows.Forms.Label();
            this.phone_num = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.event_address_and_postcode = new System.Windows.Forms.Label();
            this.event_name = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.Coming_EventBT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Coming_EventBT
            // 
            this.Coming_EventBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.Coming_EventBT.Controls.Add(this.pictureBox1);
            this.Coming_EventBT.Controls.Add(this.edit_BT);
            this.Coming_EventBT.Controls.Add(this.Subs_status);
            this.Coming_EventBT.Controls.Add(this.phone_num);
            this.Coming_EventBT.Controls.Add(this.label1);
            this.Coming_EventBT.Controls.Add(this.event_address_and_postcode);
            this.Coming_EventBT.Controls.Add(this.event_name);
            this.Coming_EventBT.Location = new System.Drawing.Point(10, 155);
            this.Coming_EventBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Coming_EventBT.Name = "Coming_EventBT";
            this.Coming_EventBT.Size = new System.Drawing.Size(629, 198);
            this.Coming_EventBT.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(449, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // edit_BT
            // 
            this.edit_BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.edit_BT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_BT.FlatAppearance.BorderSize = 0;
            this.edit_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.edit_BT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit_BT.Location = new System.Drawing.Point(449, 144);
            this.edit_BT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edit_BT.Name = "edit_BT";
            this.edit_BT.Size = new System.Drawing.Size(150, 31);
            this.edit_BT.TabIndex = 6;
            this.edit_BT.Text = "edit";
            this.edit_BT.UseVisualStyleBackColor = false;
            this.edit_BT.Click += new System.EventHandler(this.edit_BT_Click);
            // 
            // Subs_status
            // 
            this.Subs_status.AutoSize = true;
            this.Subs_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Subs_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.Subs_status.Location = new System.Drawing.Point(28, 131);
            this.Subs_status.Name = "Subs_status";
            this.Subs_status.Size = new System.Drawing.Size(346, 18);
            this.Subs_status.TabIndex = 5;
            this.Subs_status.Text = "Subscription status: Workspace Membership";
            // 
            // phone_num
            // 
            this.phone_num.AutoSize = true;
            this.phone_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phone_num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.phone_num.Location = new System.Drawing.Point(28, 109);
            this.phone_num.Name = "phone_num";
            this.phone_num.Size = new System.Drawing.Size(280, 18);
            this.phone_num.TabIndex = 4;
            this.phone_num.Text = "Phone number: user_phone_number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(28, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email address: user_email_address";
            // 
            // event_address_and_postcode
            // 
            this.event_address_and_postcode.AutoSize = true;
            this.event_address_and_postcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.event_address_and_postcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.event_address_and_postcode.Location = new System.Drawing.Point(30, 58);
            this.event_address_and_postcode.Name = "event_address_and_postcode";
            this.event_address_and_postcode.Size = new System.Drawing.Size(286, 18);
            this.event_address_and_postcode.TabIndex = 2;
            this.event_address_and_postcode.Text = "Full Name: UserName_and_Surname";
            // 
            // event_name
            // 
            this.event_name.AutoSize = true;
            this.event_name.BackColor = System.Drawing.Color.Transparent;
            this.event_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.event_name.ForeColor = System.Drawing.Color.White;
            this.event_name.Location = new System.Drawing.Point(30, 20);
            this.event_name.Name = "event_name";
            this.event_name.Size = new System.Drawing.Size(205, 29);
            this.event_name.TabIndex = 1;
            this.event_name.Text = "User Information";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.label_username.Location = new System.Drawing.Point(10, 66);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(390, 37);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "UserName_and_Surname";
            // 
            // UI_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.Coming_EventBT);
            this.Name = "UI_Profile";
            this.Size = new System.Drawing.Size(651, 450);
            this.Coming_EventBT.ResumeLayout(false);
            this.Coming_EventBT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel Coming_EventBT;
        private PictureBox pictureBox1;
        private Button edit_BT;
        private Label Subs_status;
        private Label phone_num;
        private Label label1;
        private Label event_address_and_postcode;
        private Label event_name;
        private Label label_username;
    }
}
