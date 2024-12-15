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
            this.pctProfileImage = new System.Windows.Forms.PictureBox();
            this.edit_BT = new System.Windows.Forms.Button();
            this.lblSubStatus = new System.Windows.Forms.Label();
            this.lblUserPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.event_name = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.Coming_EventBT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Coming_EventBT
            // 
            this.Coming_EventBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.Coming_EventBT.Controls.Add(this.pctProfileImage);
            this.Coming_EventBT.Controls.Add(this.edit_BT);
            this.Coming_EventBT.Controls.Add(this.lblSubStatus);
            this.Coming_EventBT.Controls.Add(this.lblUserPhoneNumber);
            this.Coming_EventBT.Controls.Add(this.lblEmailAddress);
            this.Coming_EventBT.Controls.Add(this.lblUserFullName);
            this.Coming_EventBT.Controls.Add(this.event_name);
            this.Coming_EventBT.Location = new System.Drawing.Point(32, 156);
            this.Coming_EventBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Coming_EventBT.Name = "Coming_EventBT";
            this.Coming_EventBT.Size = new System.Drawing.Size(604, 198);
            this.Coming_EventBT.TabIndex = 2;
            // 
            // pctProfileImage
            // 
            this.pctProfileImage.Image = ((System.Drawing.Image)(resources.GetObject("pctProfileImage.Image")));
            this.pctProfileImage.InitialImage = null;
            this.pctProfileImage.Location = new System.Drawing.Point(389, 20);
            this.pctProfileImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctProfileImage.Name = "pctProfileImage";
            this.pctProfileImage.Size = new System.Drawing.Size(150, 76);
            this.pctProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctProfileImage.TabIndex = 7;
            this.pctProfileImage.TabStop = false;
            // 
            // edit_BT
            // 
            this.edit_BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.edit_BT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_BT.FlatAppearance.BorderSize = 0;
            this.edit_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.edit_BT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit_BT.Location = new System.Drawing.Point(389, 142);
            this.edit_BT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edit_BT.Name = "edit_BT";
            this.edit_BT.Size = new System.Drawing.Size(150, 31);
            this.edit_BT.TabIndex = 6;
            this.edit_BT.Text = "edit";
            this.edit_BT.UseVisualStyleBackColor = false;
            // 
            // lblSubStatus
            // 
            this.lblSubStatus.AutoSize = true;
            this.lblSubStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.lblSubStatus.Location = new System.Drawing.Point(28, 142);
            this.lblSubStatus.Name = "lblSubStatus";
            this.lblSubStatus.Size = new System.Drawing.Size(317, 21);
            this.lblSubStatus.TabIndex = 5;
            this.lblSubStatus.Text = "Subscription status: Workspace Membership";
            // 
            // lblUserPhoneNumber
            // 
            this.lblUserPhoneNumber.AutoSize = true;
            this.lblUserPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.lblUserPhoneNumber.Location = new System.Drawing.Point(28, 119);
            this.lblUserPhoneNumber.Name = "lblUserPhoneNumber";
            this.lblUserPhoneNumber.Size = new System.Drawing.Size(263, 21);
            this.lblUserPhoneNumber.TabIndex = 4;
            this.lblUserPhoneNumber.Text = "Phone number: user_phone_number";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmailAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.lblEmailAddress.Location = new System.Drawing.Point(28, 94);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(249, 21);
            this.lblEmailAddress.TabIndex = 3;
            this.lblEmailAddress.Text = "Email address: user_email_address";
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.AutoSize = true;
            this.lblUserFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.lblUserFullName.Location = new System.Drawing.Point(30, 68);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.Size = new System.Drawing.Size(265, 21);
            this.lblUserFullName.TabIndex = 2;
            this.lblUserFullName.Text = "Full Name: UserName_and_Surname";
            // 
            // event_name
            // 
            this.event_name.AutoSize = true;
            this.event_name.BackColor = System.Drawing.Color.Transparent;
            this.event_name.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.event_name.ForeColor = System.Drawing.Color.White;
            this.event_name.Location = new System.Drawing.Point(30, 20);
            this.event_name.Name = "event_name";
            this.event_name.Size = new System.Drawing.Size(237, 37);
            this.event_name.TabIndex = 1;
            this.event_name.Text = "User Information";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.lblHeader.Location = new System.Drawing.Point(32, 82);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(389, 45);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "UserName_and_Surname";
            // 
            // UI_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.Coming_EventBT);
            this.Name = "UI_Profile";
            this.Size = new System.Drawing.Size(651, 450);
            this.Coming_EventBT.ResumeLayout(false);
            this.Coming_EventBT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctProfileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel Coming_EventBT;
        private PictureBox pctProfileImage;
        private Button edit_BT;
        private Label lblSubStatus;
        private Label lblUserPhoneNumber;
        private Label lblEmailAddress;
        private Label lblUserFullName;
        private Label event_name;
        private Label lblHeader;
    }
}
