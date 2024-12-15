namespace TCC_App
{
    partial class UI_NavigationBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_NavigationBar));
            Navigation_Panel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            profile_BT = new Button();
            users_BT = new Button();
            admin_BT = new Button();
            Main_BT = new Button();
            events_BT = new Button();
            logo = new Label();
            Navigation_Panel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Navigation_Panel
            // 
            Navigation_Panel.BackColor = Color.FromArgb(75, 36, 74);
            Navigation_Panel.BorderStyle = BorderStyle.FixedSingle;
            Navigation_Panel.Controls.Add(tableLayoutPanel1);
            Navigation_Panel.Dock = DockStyle.Left;
            Navigation_Panel.Location = new Point(0, 0);
            Navigation_Panel.Name = "Navigation_Panel";
            Navigation_Panel.Size = new Size(171, 600);
            Navigation_Panel.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(254, 30, 60);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(profile_BT, 0, 4);
            tableLayoutPanel1.Controls.Add(users_BT, 0, 3);
            tableLayoutPanel1.Controls.Add(admin_BT, 0, 5);
            tableLayoutPanel1.Controls.Add(Main_BT, 0, 1);
            tableLayoutPanel1.Controls.Add(events_BT, 0, 2);
            tableLayoutPanel1.Controls.Add(logo, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(169, 598);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // profile_BT
            // 
            profile_BT.BackColor = Color.Transparent;
            profile_BT.Cursor = Cursors.Hand;
            profile_BT.Dock = DockStyle.Fill;
            profile_BT.FlatAppearance.BorderSize = 0;
            profile_BT.FlatStyle = FlatStyle.Flat;
            profile_BT.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            profile_BT.ForeColor = Color.White;
            profile_BT.Image = (Image)resources.GetObject("profile_BT.Image");
            profile_BT.Location = new Point(3, 419);
            profile_BT.Name = "profile_BT";
            profile_BT.Size = new Size(163, 83);
            profile_BT.TabIndex = 5;
            profile_BT.Text = "Profile";
            profile_BT.TextAlign = ContentAlignment.MiddleLeft;
            profile_BT.TextImageRelation = TextImageRelation.ImageBeforeText;
            profile_BT.UseVisualStyleBackColor = false;
            profile_BT.Click += profile_BT_Click;
            // 
            // users_BT
            // 
            users_BT.BackColor = Color.Transparent;
            users_BT.Cursor = Cursors.Hand;
            users_BT.Dock = DockStyle.Fill;
            users_BT.FlatAppearance.BorderSize = 0;
            users_BT.FlatStyle = FlatStyle.Flat;
            users_BT.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            users_BT.ForeColor = Color.White;
            users_BT.Image = (Image)resources.GetObject("users_BT.Image");
            users_BT.Location = new Point(3, 330);
            users_BT.Name = "users_BT";
            users_BT.Size = new Size(163, 83);
            users_BT.TabIndex = 1;
            users_BT.Text = "Users";
            users_BT.TextAlign = ContentAlignment.MiddleLeft;
            users_BT.TextImageRelation = TextImageRelation.ImageBeforeText;
            users_BT.UseVisualStyleBackColor = false;
            users_BT.Click += users_BT_Click;
            // 
            // admin_BT
            // 
            admin_BT.BackColor = Color.Transparent;
            admin_BT.Cursor = Cursors.Hand;
            admin_BT.Dock = DockStyle.Fill;
            admin_BT.FlatAppearance.BorderSize = 0;
            admin_BT.FlatStyle = FlatStyle.Flat;
            admin_BT.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            admin_BT.ForeColor = Color.White;
            admin_BT.Image = (Image)resources.GetObject("admin_BT.Image");
            admin_BT.Location = new Point(3, 508);
            admin_BT.Name = "admin_BT";
            admin_BT.Size = new Size(163, 87);
            admin_BT.TabIndex = 2;
            admin_BT.Text = "Admin";
            admin_BT.TextAlign = ContentAlignment.MiddleLeft;
            admin_BT.TextImageRelation = TextImageRelation.ImageBeforeText;
            admin_BT.UseVisualStyleBackColor = false;
            admin_BT.Click += admin_BT_Click;
            // 
            // Main_BT
            // 
            Main_BT.BackColor = Color.Transparent;
            Main_BT.Cursor = Cursors.Hand;
            Main_BT.Dock = DockStyle.Fill;
            Main_BT.FlatAppearance.BorderSize = 0;
            Main_BT.FlatStyle = FlatStyle.Flat;
            Main_BT.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Main_BT.ForeColor = Color.White;
            Main_BT.Image = (Image)resources.GetObject("Main_BT.Image");
            Main_BT.Location = new Point(3, 152);
            Main_BT.Name = "Main_BT";
            Main_BT.Size = new Size(163, 83);
            Main_BT.TabIndex = 0;
            Main_BT.Text = "Main";
            Main_BT.TextAlign = ContentAlignment.MiddleLeft;
            Main_BT.TextImageRelation = TextImageRelation.ImageBeforeText;
            Main_BT.UseVisualStyleBackColor = false;
            Main_BT.Click += Main_BT_Click;
            // 
            // events_BT
            // 
            events_BT.BackColor = Color.Transparent;
            events_BT.Cursor = Cursors.Hand;
            events_BT.Dock = DockStyle.Fill;
            events_BT.FlatAppearance.BorderSize = 0;
            events_BT.FlatStyle = FlatStyle.Flat;
            events_BT.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            events_BT.ForeColor = Color.White;
            events_BT.Image = (Image)resources.GetObject("events_BT.Image");
            events_BT.Location = new Point(3, 241);
            events_BT.Name = "events_BT";
            events_BT.Size = new Size(163, 83);
            events_BT.TabIndex = 3;
            events_BT.Text = "Events";
            events_BT.TextAlign = ContentAlignment.MiddleLeft;
            events_BT.TextImageRelation = TextImageRelation.ImageBeforeText;
            events_BT.UseVisualStyleBackColor = false;
            events_BT.Click += events_BT_Click;
            // 
            // logo
            // 
            logo.AutoSize = true;
            logo.BackColor = Color.FromArgb(254, 30, 60);
            logo.Dock = DockStyle.Fill;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(3, 0);
            logo.Name = "logo";
            logo.Size = new Size(163, 149);
            logo.TabIndex = 4;
            // 
            // UI_NavigationBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Navigation_Panel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UI_NavigationBar";
            Size = new Size(171, 600);
            Navigation_Panel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Navigation_Panel;
        private Button admin_BT;
        private Button users_BT;
        private Button Main_BT;
        private TableLayoutPanel tableLayoutPanel1;
        private Button events_BT;
        private Label logo;
        private Button profile_BT;
    }
}
