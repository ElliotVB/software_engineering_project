namespace UIDesign_EventView
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
            this.navigationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonChatroom = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonModules = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelEventTime = new System.Windows.Forms.Label();
            this.labelEventDate = new System.Windows.Forms.Label();
            this.labelEventName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelEventDescription = new System.Windows.Forms.Label();
            this.buttonBook = new System.Windows.Forms.Button();
            this.navigationPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
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
            this.navigationPanel.Location = new System.Drawing.Point(0, -1);
            this.navigationPanel.Margin = new System.Windows.Forms.Padding(0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.RowCount = 1;
            this.navigationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.navigationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.navigationPanel.Size = new System.Drawing.Size(801, 80);
            this.navigationPanel.TabIndex = 2;
            // 
            // buttonProfile
            // 
            this.buttonProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonProfile.BackgroundImage = global::UIDesign_EventView.Properties.Resources._3671896_circle_solid_user_icon;
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
            this.buttonHome.BackgroundImage = global::UIDesign_EventView.Properties.Resources.TCClogo1;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Location = new System.Drawing.Point(3, 5);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(127, 70);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.UseVisualStyleBackColor = true;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelEventTime, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelEventDate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelEventName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 98);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 340);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelEventTime
            // 
            this.labelEventTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEventTime.AutoSize = true;
            this.labelEventTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEventTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelEventTime.Location = new System.Drawing.Point(89, 306);
            this.labelEventTime.Name = "labelEventTime";
            this.labelEventTime.Size = new System.Drawing.Size(91, 20);
            this.labelEventTime.TabIndex = 2;
            this.labelEventTime.Text = "12pm - 3pm";
            // 
            // labelEventDate
            // 
            this.labelEventDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEventDate.AutoSize = true;
            this.labelEventDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEventDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelEventDate.Location = new System.Drawing.Point(50, 279);
            this.labelEventDate.Name = "labelEventDate";
            this.labelEventDate.Size = new System.Drawing.Size(169, 20);
            this.labelEventDate.TabIndex = 1;
            this.labelEventDate.Text = "Monday 1 October 2025";
            // 
            // labelEventName
            // 
            this.labelEventName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEventName.AutoSize = true;
            this.labelEventName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEventName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelEventName.Location = new System.Drawing.Point(59, 241);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(151, 28);
            this.labelEventName.TabIndex = 0;
            this.labelEventName.Text = "Example event";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::UIDesign_EventView.Properties.Resources._event;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 232);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelEventDescription, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonBook, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(282, 98);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(508, 340);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // labelEventDescription
            // 
            this.labelEventDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEventDescription.AutoSize = true;
            this.labelEventDescription.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEventDescription.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelEventDescription.Location = new System.Drawing.Point(34, 0);
            this.labelEventDescription.Name = "labelEventDescription";
            this.labelEventDescription.Size = new System.Drawing.Size(440, 196);
            this.labelEventDescription.TabIndex = 0;
            this.labelEventDescription.Text = resources.GetString("labelEventDescription.Text");
            this.labelEventDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBook
            // 
            this.buttonBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.buttonBook.FlatAppearance.BorderSize = 0;
            this.buttonBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBook.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBook.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBook.Location = new System.Drawing.Point(198, 280);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(112, 51);
            this.buttonBook.TabIndex = 1;
            this.buttonBook.Text = "Book";
            this.buttonBook.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.navigationPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.navigationPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel navigationPanel;
        private Button buttonProfile;
        private Button buttonChatroom;
        private Button buttonUsers;
        private Button buttonModules;
        private Button buttonHome;
        private Button buttonEvents;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelEventTime;
        private Label labelEventDate;
        private Label labelEventName;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelEventDescription;
        private Button buttonBook;
    }
}