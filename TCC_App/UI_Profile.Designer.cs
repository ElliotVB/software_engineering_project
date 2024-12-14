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
            Coming_EventBT = new Panel();
            pctProfileImage = new PictureBox();
            edit_BT = new Button();
            lblSubStatus = new Label();
            lblUserPhoneNumber = new Label();
            lblEmailAddress = new Label();
            lblUserFullName = new Label();
            event_name = new Label();
            lblHeader = new Label();
            Coming_EventBT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctProfileImage).BeginInit();
            SuspendLayout();
            // 
            // Coming_EventBT
            // 
            Coming_EventBT.BackColor = Color.FromArgb(255, 160, 174);
            Coming_EventBT.Controls.Add(pctProfileImage);
            Coming_EventBT.Controls.Add(edit_BT);
            Coming_EventBT.Controls.Add(lblSubStatus);
            Coming_EventBT.Controls.Add(lblUserPhoneNumber);
            Coming_EventBT.Controls.Add(lblEmailAddress);
            Coming_EventBT.Controls.Add(lblUserFullName);
            Coming_EventBT.Controls.Add(event_name);
            Coming_EventBT.Location = new Point(10, 155);
            Coming_EventBT.Margin = new Padding(3, 2, 3, 2);
            Coming_EventBT.Name = "Coming_EventBT";
            Coming_EventBT.Size = new Size(629, 198);
            Coming_EventBT.TabIndex = 2;
            // 
            // pctProfileImage
            // 
            pctProfileImage.Image = (Image)resources.GetObject("pctProfileImage.Image");
            pctProfileImage.InitialImage = null;
            pctProfileImage.Location = new Point(449, 25);
            pctProfileImage.Margin = new Padding(3, 2, 3, 2);
            pctProfileImage.Name = "pctProfileImage";
            pctProfileImage.Size = new Size(150, 76);
            pctProfileImage.SizeMode = PictureBoxSizeMode.Zoom;
            pctProfileImage.TabIndex = 7;
            pctProfileImage.TabStop = false;
            // 
            // edit_BT
            // 
            edit_BT.BackColor = Color.FromArgb(85, 44, 59);
            edit_BT.Cursor = Cursors.Hand;
            edit_BT.FlatAppearance.BorderSize = 0;
            edit_BT.FlatStyle = FlatStyle.Flat;
            edit_BT.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            edit_BT.ForeColor = SystemColors.ButtonHighlight;
            edit_BT.Location = new Point(449, 144);
            edit_BT.Margin = new Padding(3, 2, 3, 2);
            edit_BT.Name = "edit_BT";
            edit_BT.Size = new Size(150, 31);
            edit_BT.TabIndex = 6;
            edit_BT.Text = "edit";
            edit_BT.UseVisualStyleBackColor = false;
            edit_BT.Click += edit_BT_Click;
            // 
            // lblSubStatus
            // 
            lblSubStatus.AutoSize = true;
            lblSubStatus.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubStatus.ForeColor = Color.FromArgb(26, 0, 10);
            lblSubStatus.Location = new Point(28, 131);
            lblSubStatus.Name = "lblSubStatus";
            lblSubStatus.Size = new Size(346, 18);
            lblSubStatus.TabIndex = 5;
            lblSubStatus.Text = "Subscription status: Workspace Membership";
            // 
            // lblUserPhoneNumber
            // 
            lblUserPhoneNumber.AutoSize = true;
            lblUserPhoneNumber.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserPhoneNumber.ForeColor = Color.FromArgb(26, 0, 10);
            lblUserPhoneNumber.Location = new Point(28, 109);
            lblUserPhoneNumber.Name = "lblUserPhoneNumber";
            lblUserPhoneNumber.Size = new Size(280, 18);
            lblUserPhoneNumber.TabIndex = 4;
            lblUserPhoneNumber.Text = "Phone number: user_phone_number";
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmailAddress.ForeColor = Color.FromArgb(26, 0, 10);
            lblEmailAddress.Location = new Point(28, 83);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(276, 18);
            lblEmailAddress.TabIndex = 3;
            lblEmailAddress.Text = "Email address: user_email_address";
            // 
            // lblUserFullName
            // 
            lblUserFullName.AutoSize = true;
            lblUserFullName.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserFullName.ForeColor = Color.FromArgb(26, 0, 10);
            lblUserFullName.Location = new Point(30, 58);
            lblUserFullName.Name = "lblUserFullName";
            lblUserFullName.Size = new Size(286, 18);
            lblUserFullName.TabIndex = 2;
            lblUserFullName.Text = "Full Name: UserName_and_Surname";
            // 
            // event_name
            // 
            event_name.AutoSize = true;
            event_name.BackColor = Color.Transparent;
            event_name.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            event_name.ForeColor = Color.White;
            event_name.Location = new Point(30, 20);
            event_name.Name = "event_name";
            event_name.Size = new Size(205, 29);
            event_name.TabIndex = 1;
            event_name.Text = "User Information";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.FromArgb(26, 0, 10);
            lblHeader.Location = new Point(10, 66);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(390, 37);
            lblHeader.TabIndex = 3;
            lblHeader.Text = "UserName_and_Surname";
            // 
            // UI_Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblHeader);
            Controls.Add(Coming_EventBT);
            Name = "UI_Profile";
            Size = new Size(651, 450);
            Coming_EventBT.ResumeLayout(false);
            Coming_EventBT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctProfileImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
