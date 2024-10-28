namespace Software_Engineering_2024
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundGlobal = new System.Windows.Forms.Panel();
            this.backgroundCalendar = new System.Windows.Forms.Panel();
            this.backgroundHeader = new System.Windows.Forms.Panel();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.buttonChatroom = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonModules = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.eventsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.event1 = new System.Windows.Forms.Button();
=======
            this.calendarsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.calendar1 = new System.Windows.Forms.Panel();
            this.calendar2 = new System.Windows.Forms.Panel();
>>>>>>> parent of b50eccb (Added container for events)
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.backgroundGlobal.SuspendLayout();
            this.backgroundCalendar.SuspendLayout();
            this.backgroundHeader.SuspendLayout();
            this.calendarsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundGlobal
            // 
            this.backgroundGlobal.AutoSize = true;
            this.backgroundGlobal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backgroundGlobal.BackColor = System.Drawing.Color.White;
            this.backgroundGlobal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundGlobal.Controls.Add(this.backgroundCalendar);
            this.backgroundGlobal.Controls.Add(this.backgroundHeader);
            this.backgroundGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundGlobal.Location = new System.Drawing.Point(0, 0);
            this.backgroundGlobal.Name = "backgroundGlobal";
            this.backgroundGlobal.Size = new System.Drawing.Size(800, 450);
            this.backgroundGlobal.TabIndex = 0;
            this.backgroundGlobal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // backgroundCalendar
            // 
            this.backgroundCalendar.BackColor = System.Drawing.Color.Silver;
            this.backgroundCalendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundCalendar.Controls.Add(this.calendarsContainer);
            this.backgroundCalendar.Dock = System.Windows.Forms.DockStyle.Left;
            this.backgroundCalendar.Location = new System.Drawing.Point(0, 74);
            this.backgroundCalendar.Name = "backgroundCalendar";
            this.backgroundCalendar.Size = new System.Drawing.Size(220, 374);
            this.backgroundCalendar.TabIndex = 1;
            // 
<<<<<<< HEAD
            // calendarsContainer
            // 
            this.calendarsContainer.ColumnCount = 1;
            this.calendarsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarsContainer.Controls.Add(this.calendar2, 0, 1);
            this.calendarsContainer.Controls.Add(this.calendar1, 0, 0);
            this.calendarsContainer.Location = new System.Drawing.Point(0, 0);
            this.calendarsContainer.Name = "calendarsContainer";
            this.calendarsContainer.RowCount = 2;
            this.calendarsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarsContainer.Size = new System.Drawing.Size(222, 373);
            this.calendarsContainer.TabIndex = 0;
            // 
            // calendar2
            // 
            this.calendar2.BackgroundImage = global::Software_Engineering_2024.Properties.Resources.calendar2;
            this.calendar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calendar2.Location = new System.Drawing.Point(3, 189);
            this.calendar2.Name = "calendar2";
            this.calendar2.Size = new System.Drawing.Size(213, 181);
            this.calendar2.TabIndex = 0;
            // 
            // calendar1
            // 
            this.calendar1.BackgroundImage = global::Software_Engineering_2024.Properties.Resources.calendar1;
            this.calendar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calendar1.Location = new System.Drawing.Point(3, 3);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(213, 180);
            this.calendar1.TabIndex = 0;
            this.calendar1.Paint += new System.Windows.Forms.PaintEventHandler(this.calendar1_Paint);
            // 
=======
>>>>>>> parent of b50eccb (Added container for events)
            // backgroundHeader
            // 
            this.backgroundHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(16)))));
            this.backgroundHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundHeader.Controls.Add(this.buttonProfile);
            this.backgroundHeader.Controls.Add(this.buttonEvents);
            this.backgroundHeader.Controls.Add(this.buttonChatroom);
            this.backgroundHeader.Controls.Add(this.buttonUsers);
            this.backgroundHeader.Controls.Add(this.buttonModules);
            this.backgroundHeader.Controls.Add(this.buttonHome);
            this.backgroundHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.backgroundHeader.Location = new System.Drawing.Point(0, 0);
            this.backgroundHeader.Name = "backgroundHeader";
            this.backgroundHeader.Size = new System.Drawing.Size(798, 74);
            this.backgroundHeader.TabIndex = 0;
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackgroundImage = global::Software_Engineering_2024.Properties.Resources.profilePic;
            this.buttonProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProfile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonProfile.FlatAppearance.BorderSize = 2;
            this.buttonProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonProfile.ForeColor = System.Drawing.Color.White;
            this.buttonProfile.Location = new System.Drawing.Point(730, 11);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(50, 50);
            this.buttonProfile.TabIndex = 5;
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonEvents
            // 
            this.buttonEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEvents.FlatAppearance.BorderSize = 0;
            this.buttonEvents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEvents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEvents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEvents.ForeColor = System.Drawing.Color.White;
            this.buttonEvents.Location = new System.Drawing.Point(150, 11);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(120, 50);
            this.buttonEvents.TabIndex = 4;
            this.buttonEvents.Text = "Events";
            this.buttonEvents.UseVisualStyleBackColor = true;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // buttonChatroom
            // 
            this.buttonChatroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChatroom.FlatAppearance.BorderSize = 0;
            this.buttonChatroom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonChatroom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonChatroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChatroom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChatroom.ForeColor = System.Drawing.Color.White;
            this.buttonChatroom.Location = new System.Drawing.Point(600, 11);
            this.buttonChatroom.Name = "buttonChatroom";
            this.buttonChatroom.Size = new System.Drawing.Size(120, 50);
            this.buttonChatroom.TabIndex = 3;
            this.buttonChatroom.Text = "Member-only chatroom";
            this.buttonChatroom.UseVisualStyleBackColor = true;
            // 
            // buttonUsers
            // 
            this.buttonUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUsers.FlatAppearance.BorderSize = 0;
            this.buttonUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUsers.ForeColor = System.Drawing.Color.White;
            this.buttonUsers.Location = new System.Drawing.Point(450, 11);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(120, 50);
            this.buttonUsers.TabIndex = 2;
            this.buttonUsers.Text = "Connect with others";
            this.buttonUsers.UseVisualStyleBackColor = true;
            // 
            // buttonModules
            // 
            this.buttonModules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModules.FlatAppearance.BorderSize = 0;
            this.buttonModules.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonModules.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonModules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModules.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonModules.ForeColor = System.Drawing.Color.White;
            this.buttonModules.Location = new System.Drawing.Point(300, 11);
            this.buttonModules.Name = "buttonModules";
            this.buttonModules.Size = new System.Drawing.Size(120, 50);
            this.buttonModules.TabIndex = 1;
            this.buttonModules.Text = "Digital content modules";
            this.buttonModules.UseVisualStyleBackColor = true;
            this.buttonModules.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // buttonHome
            // 
            this.buttonHome.BackgroundImage = global::Software_Engineering_2024.Properties.Resources.TCClogo;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Location = new System.Drawing.Point(10, 8);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(117, 59);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // calendarsContainer
            // 
<<<<<<< HEAD
            this.eventsLayout.BackColor = System.Drawing.Color.DarkGray;
            this.eventsLayout.ColumnCount = 3;
            this.eventsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.eventsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.eventsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.eventsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.eventsLayout.Controls.Add(this.event1, 0, 0);
            this.eventsLayout.Location = new System.Drawing.Point(220, 74);
            this.eventsLayout.Name = "eventsLayout";
            this.eventsLayout.RowCount = 2;
            this.eventsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.eventsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.eventsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.eventsLayout.Size = new System.Drawing.Size(578, 374);
            this.eventsLayout.TabIndex = 0;
            this.eventsLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.eventsLayout_Paint);
            // 
            // event1
            // 
            this.event1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.event1.BackColor = System.Drawing.Color.IndianRed;
            this.event1.BackgroundImage = global::Software_Engineering_2024.Properties.Resources._event;
            this.event1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.event1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.event1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.event1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.event1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.event1.Location = new System.Drawing.Point(6, 11);
            this.event1.Name = "event1";
            this.event1.Size = new System.Drawing.Size(179, 164);
            this.event1.TabIndex = 0;
            this.event1.Text = "Example event";
            this.event1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.event1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.event1.UseVisualStyleBackColor = false;
=======
            this.calendarsContainer.ColumnCount = 1;
            this.calendarsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarsContainer.Controls.Add(this.calendar2, 0, 1);
            this.calendarsContainer.Controls.Add(this.calendar1, 0, 0);
            this.calendarsContainer.Location = new System.Drawing.Point(0, 0);
            this.calendarsContainer.Name = "calendarsContainer";
            this.calendarsContainer.RowCount = 2;
            this.calendarsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarsContainer.Size = new System.Drawing.Size(219, 373);
            this.calendarsContainer.TabIndex = 0;
            // 
            // calendar1
            // 
            this.calendar1.BackgroundImage = global::Software_Engineering_2024.Properties.Resources.calendar1;
            this.calendar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calendar1.Location = new System.Drawing.Point(3, 3);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(213, 180);
            this.calendar1.TabIndex = 0;
            // 
            // calendar2
            // 
            this.calendar2.BackgroundImage = global::Software_Engineering_2024.Properties.Resources.calendar2;
            this.calendar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calendar2.Location = new System.Drawing.Point(3, 189);
            this.calendar2.Name = "calendar2";
            this.calendar2.Size = new System.Drawing.Size(213, 181);
            this.calendar2.TabIndex = 0;
>>>>>>> parent of b50eccb (Added container for events)
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backgroundGlobal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.backgroundGlobal.ResumeLayout(false);
            this.backgroundCalendar.ResumeLayout(false);
            this.backgroundHeader.ResumeLayout(false);
            this.calendarsContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource bindingSource1;
        private Panel backgroundGlobal;
        private Panel backgroundCalendar;
        private Panel backgroundHeader;
        private Button buttonHome;
        private Button buttonChatroom;
        private Button buttonUsers;
        private Button buttonModules;
        private Button buttonEvents;
        private Button buttonProfile;
        private TableLayoutPanel calendarsContainer;
        private Panel calendar2;
        private Panel calendar1;
<<<<<<< HEAD
        private TableLayoutPanel eventsLayout;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button event1;
=======
>>>>>>> parent of b50eccb (Added container for events)
    }
}