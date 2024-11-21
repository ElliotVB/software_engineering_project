namespace UIDesign_EventSearch
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
            this.navigationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonChatroom = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonModules = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.calendarsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calendar1 = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.eventFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navigationPanel.SuspendLayout();
            this.calendarsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Margin = new System.Windows.Forms.Padding(0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.RowCount = 1;
            this.navigationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.navigationPanel.Size = new System.Drawing.Size(801, 80);
            this.navigationPanel.TabIndex = 0;
            this.navigationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.navigationPanel_Paint);
            // 
            // buttonProfile
            // 
            this.buttonProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonProfile.BackgroundImage = global::UIDesign_EventSearch.Properties.Resources._3671896_circle_solid_user_icon;
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
            this.buttonHome.BackgroundImage = global::UIDesign_EventSearch.Properties.Resources.TCClogo1;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Location = new System.Drawing.Point(3, 3);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(123, 74);
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
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // calendarsPanel
            // 
            this.calendarsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.calendarsPanel.ColumnCount = 1;
            this.calendarsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.calendarsPanel.Controls.Add(this.panel1, 0, 1);
            this.calendarsPanel.Controls.Add(this.calendar1, 0, 0);
            this.calendarsPanel.Location = new System.Drawing.Point(0, 80);
            this.calendarsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.calendarsPanel.Name = "calendarsPanel";
            this.calendarsPanel.RowCount = 2;
            this.calendarsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarsPanel.Size = new System.Drawing.Size(213, 373);
            this.calendarsPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::UIDesign_EventSearch.Properties.Resources.calendar2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(3, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 180);
            this.panel1.TabIndex = 1;
            // 
            // calendar1
            // 
            this.calendar1.BackgroundImage = global::UIDesign_EventSearch.Properties.Resources.calendar1;
            this.calendar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calendar1.Location = new System.Drawing.Point(3, 3);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(207, 180);
            this.calendar1.TabIndex = 0;
            // 
            // searchBox
            // 
            this.searchBox.ForeColor = System.Drawing.Color.Gray;
            this.searchBox.Location = new System.Drawing.Point(238, 83);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(552, 23);
            this.searchBox.TabIndex = 3;
            this.searchBox.Text = "Search for events";
            this.searchBox.Click += new System.EventHandler(this.searchBox_Clicked);
            // 
            // eventFlowLayout
            // 
            this.eventFlowLayout.AutoScroll = true;
            this.eventFlowLayout.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.eventFlowLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eventFlowLayout.Location = new System.Drawing.Point(213, 111);
            this.eventFlowLayout.Margin = new System.Windows.Forms.Padding(0);
            this.eventFlowLayout.Name = "eventFlowLayout";
            this.eventFlowLayout.Size = new System.Drawing.Size(588, 338);
            this.eventFlowLayout.TabIndex = 4;
            this.eventFlowLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.eventFlowLayout_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::UIDesign_EventSearch.Properties.Resources.GridiconsSearch;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(217, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.eventFlowLayout);
            this.Controls.Add(this.calendarsPanel);
            this.Controls.Add(this.navigationPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.navigationPanel.ResumeLayout(false);
            this.calendarsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel navigationPanel;
        private TableLayoutPanel calendarsPanel;
        private Panel calendar1;
        private Panel panel1;
        private Button buttonHome;
        private Button buttonEvents;
        private Button buttonChatroom;
        private Button buttonUsers;
        private Button buttonModules;
        private Button buttonProfile;
        private TextBox searchBox;
        private FlowLayoutPanel eventFlowLayout;
        private PictureBox pictureBox1;
    }
}