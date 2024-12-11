namespace TCC_App
{
    partial class UI_EventInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_EventInformation));
            this.EventLocation = new System.Windows.Forms.Label();
            this.EventInfoLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EventDateTime = new System.Windows.Forms.Label();
            this.ContactsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Contact2 = new System.Windows.Forms.Label();
            this.Contact1 = new System.Windows.Forms.Label();
            this.EventPrice = new System.Windows.Forms.Label();
            this.EventDescription = new System.Windows.Forms.Label();
            this.EventName = new System.Windows.Forms.Label();
            this.EventImage = new System.Windows.Forms.Panel();
            this.eventLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Book = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonChatroom = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonModules = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.navigationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EventInfoLayoutPanel.SuspendLayout();
            this.ContactsTableLayout.SuspendLayout();
            this.eventLayoutPanel.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EventLocation
            // 
            this.EventLocation.AutoSize = true;
            this.EventLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EventLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventLocation.Location = new System.Drawing.Point(3, 222);
            this.EventLocation.Name = "EventLocation";
            this.EventLocation.Size = new System.Drawing.Size(495, 37);
            this.EventLocation.TabIndex = 3;
            this.EventLocation.Text = "Event location";
            this.EventLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EventLocation.Click += new System.EventHandler(this.EventLocation_Click);
            // 
            // EventInfoLayoutPanel
            // 
            this.EventInfoLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EventInfoLayoutPanel.ColumnCount = 1;
            this.EventInfoLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EventInfoLayoutPanel.Controls.Add(this.EventDateTime, 0, 2);
            this.EventInfoLayoutPanel.Controls.Add(this.ContactsTableLayout, 0, 4);
            this.EventInfoLayoutPanel.Controls.Add(this.EventPrice, 0, 3);
            this.EventInfoLayoutPanel.Controls.Add(this.EventDescription, 0, 0);
            this.EventInfoLayoutPanel.Controls.Add(this.EventLocation, 0, 1);
            this.EventInfoLayoutPanel.Location = new System.Drawing.Point(300, 80);
            this.EventInfoLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.EventInfoLayoutPanel.Name = "EventInfoLayoutPanel";
            this.EventInfoLayoutPanel.RowCount = 5;
            this.EventInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.EventInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.EventInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.EventInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.EventInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.EventInfoLayoutPanel.Size = new System.Drawing.Size(501, 370);
            this.EventInfoLayoutPanel.TabIndex = 10;
            // 
            // EventDateTime
            // 
            this.EventDateTime.AutoSize = true;
            this.EventDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EventDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventDateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventDateTime.Location = new System.Drawing.Point(3, 259);
            this.EventDateTime.Name = "EventDateTime";
            this.EventDateTime.Size = new System.Drawing.Size(495, 37);
            this.EventDateTime.TabIndex = 4;
            this.EventDateTime.Text = "Event DateTime";
            this.EventDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContactsTableLayout
            // 
            this.ContactsTableLayout.ColumnCount = 2;
            this.ContactsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContactsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContactsTableLayout.Controls.Add(this.Contact2, 1, 0);
            this.ContactsTableLayout.Controls.Add(this.Contact1, 0, 0);
            this.ContactsTableLayout.Location = new System.Drawing.Point(10, 343);
            this.ContactsTableLayout.Margin = new System.Windows.Forms.Padding(10);
            this.ContactsTableLayout.Name = "ContactsTableLayout";
            this.ContactsTableLayout.RowCount = 1;
            this.ContactsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContactsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContactsTableLayout.Size = new System.Drawing.Size(481, 17);
            this.ContactsTableLayout.TabIndex = 0;
            // 
            // Contact2
            // 
            this.Contact2.AutoSize = true;
            this.Contact2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contact2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Contact2.Location = new System.Drawing.Point(243, 0);
            this.Contact2.Name = "Contact2";
            this.Contact2.Size = new System.Drawing.Size(235, 17);
            this.Contact2.TabIndex = 1;
            this.Contact2.Text = "contact2@gmail.com";
            this.Contact2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Contact1
            // 
            this.Contact1.AutoSize = true;
            this.Contact1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contact1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Contact1.Location = new System.Drawing.Point(3, 0);
            this.Contact1.Name = "Contact1";
            this.Contact1.Size = new System.Drawing.Size(234, 17);
            this.Contact1.TabIndex = 0;
            this.Contact1.Text = "contact1@gmail.com";
            this.Contact1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EventPrice
            // 
            this.EventPrice.AutoSize = true;
            this.EventPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventPrice.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EventPrice.Location = new System.Drawing.Point(3, 296);
            this.EventPrice.Name = "EventPrice";
            this.EventPrice.Size = new System.Drawing.Size(495, 37);
            this.EventPrice.TabIndex = 1;
            this.EventPrice.Text = "Price";
            this.EventPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventDescription
            // 
            this.EventDescription.AutoSize = true;
            this.EventDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EventDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventDescription.Location = new System.Drawing.Point(15, 15);
            this.EventDescription.Margin = new System.Windows.Forms.Padding(15);
            this.EventDescription.Name = "EventDescription";
            this.EventDescription.Size = new System.Drawing.Size(471, 192);
            this.EventDescription.TabIndex = 2;
            this.EventDescription.Text = resources.GetString("EventDescription.Text");
            this.EventDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EventName
            // 
            this.EventName.AutoSize = true;
            this.EventName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EventName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EventName.Location = new System.Drawing.Point(3, 217);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(294, 51);
            this.EventName.TabIndex = 0;
            this.EventName.Text = "Example event";
            this.EventName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventImage
            // 
            this.EventImage.BackgroundImage = global::TCC_App.Properties.Resources._event;
            this.EventImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EventImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventImage.Location = new System.Drawing.Point(3, 21);
            this.EventImage.Name = "EventImage";
            this.EventImage.Size = new System.Drawing.Size(294, 193);
            this.EventImage.TabIndex = 9;
            // 
            // eventLayoutPanel
            // 
            this.eventLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.eventLayoutPanel.ColumnCount = 1;
            this.eventLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.eventLayoutPanel.Controls.Add(this.EventName, 0, 2);
            this.eventLayoutPanel.Controls.Add(this.EventImage, 0, 1);
            this.eventLayoutPanel.Controls.Add(this.Book, 0, 3);
            this.eventLayoutPanel.Location = new System.Drawing.Point(0, 80);
            this.eventLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.eventLayoutPanel.Name = "eventLayoutPanel";
            this.eventLayoutPanel.RowCount = 5;
            this.eventLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.eventLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54F));
            this.eventLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.eventLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.eventLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.eventLayoutPanel.Size = new System.Drawing.Size(300, 370);
            this.eventLayoutPanel.TabIndex = 8;
            // 
            // Book
            // 
            this.Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.Book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Book.FlatAppearance.BorderSize = 0;
            this.Book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Book.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Book.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Book.Location = new System.Drawing.Point(3, 271);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(294, 56);
            this.Book.TabIndex = 8;
            this.Book.Text = "Book";
            this.Book.UseVisualStyleBackColor = false;
            // 
            // buttonProfile
            // 
            this.buttonProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonProfile.BackgroundImage = global::TCC_App.Properties.Resources.pfpPlaceholder;
            this.buttonProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Location = new System.Drawing.Point(725, 7);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(65, 65);
            this.buttonProfile.TabIndex = 5;
            this.buttonProfile.UseVisualStyleBackColor = true;
            // 
            // buttonChatroom
            // 
            this.buttonChatroom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChatroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChatroom.FlatAppearance.BorderSize = 0;
            this.buttonChatroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChatroom.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChatroom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonChatroom.Location = new System.Drawing.Point(611, 12);
            this.buttonChatroom.Name = "buttonChatroom";
            this.buttonChatroom.Size = new System.Drawing.Size(81, 55);
            this.buttonChatroom.TabIndex = 4;
            this.buttonChatroom.Text = "Member chatroom";
            this.buttonChatroom.UseVisualStyleBackColor = true;
            // 
            // buttonUsers
            // 
            this.buttonUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUsers.FlatAppearance.BorderSize = 0;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUsers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUsers.Location = new System.Drawing.Point(476, 25);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(99, 29);
            this.buttonUsers.TabIndex = 3;
            this.buttonUsers.Text = "Connections";
            this.buttonUsers.UseVisualStyleBackColor = true;
            // 
            // buttonModules
            // 
            this.buttonModules.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonModules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModules.FlatAppearance.BorderSize = 0;
            this.buttonModules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModules.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonModules.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonModules.Location = new System.Drawing.Point(362, 9);
            this.buttonModules.Name = "buttonModules";
            this.buttonModules.Size = new System.Drawing.Size(75, 62);
            this.buttonModules.TabIndex = 2;
            this.buttonModules.Text = "Digital modules";
            this.buttonModules.UseVisualStyleBackColor = true;
            // 
            // buttonHome
            // 
            this.buttonHome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonHome.BackgroundImage = global::TCC_App.Properties.Resources.TCClogo;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Location = new System.Drawing.Point(3, 3);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(123, 74);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonEvents
            // 
            this.buttonEvents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEvents.FlatAppearance.BorderSize = 0;
            this.buttonEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEvents.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEvents.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEvents.Location = new System.Drawing.Point(236, 25);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(75, 29);
            this.buttonEvents.TabIndex = 1;
            this.buttonEvents.Text = "Events";
            this.buttonEvents.UseVisualStyleBackColor = true;
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.navigationPanel.ColumnCount = 6;
            this.navigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.46615F));
            this.navigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.77954F));
            this.navigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.77954F));
            this.navigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.77954F));
            this.navigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.77954F));
            this.navigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.4157F));
            this.navigationPanel.Controls.Add(this.buttonProfile, 5, 0);
            this.navigationPanel.Controls.Add(this.buttonChatroom, 4, 0);
            this.navigationPanel.Controls.Add(this.buttonUsers, 3, 0);
            this.navigationPanel.Controls.Add(this.buttonModules, 2, 0);
            this.navigationPanel.Controls.Add(this.buttonHome, 0, 0);
            this.navigationPanel.Controls.Add(this.buttonEvents, 1, 0);
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Margin = new System.Windows.Forms.Padding(0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.RowCount = 1;
            this.navigationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.navigationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.navigationPanel.Size = new System.Drawing.Size(801, 80);
            this.navigationPanel.TabIndex = 9;
            // 
            // UI_EventInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EventInfoLayoutPanel);
            this.Controls.Add(this.eventLayoutPanel);
            this.Controls.Add(this.navigationPanel);
            this.Name = "UI_EventInformation";
            this.Size = new System.Drawing.Size(800, 450);
            this.EventInfoLayoutPanel.ResumeLayout(false);
            this.EventInfoLayoutPanel.PerformLayout();
            this.ContactsTableLayout.ResumeLayout(false);
            this.ContactsTableLayout.PerformLayout();
            this.eventLayoutPanel.ResumeLayout(false);
            this.eventLayoutPanel.PerformLayout();
            this.navigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label EventLocation;
        private TableLayoutPanel EventInfoLayoutPanel;
        private Label EventDescription;
        private Label EventName;
        private Panel EventImage;
        private TableLayoutPanel eventLayoutPanel;
        private Button Book;
        private Button buttonProfile;
        private Button buttonChatroom;
        private Button buttonUsers;
        private Button buttonModules;
        private Button buttonHome;
        private Button buttonEvents;
        private TableLayoutPanel navigationPanel;
        private Label EventDateTime;
        private TableLayoutPanel ContactsTableLayout;
        private Label Contact2;
        private Label Contact1;
        private Label EventPrice;
    }
}
