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
            this.Navigation_Panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.profile_BT = new System.Windows.Forms.Button();
            this.users_BT = new System.Windows.Forms.Button();
            this.admin_BT = new System.Windows.Forms.Button();
            this.Main_BT = new System.Windows.Forms.Button();
            this.events_BT = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Label();
            this.Navigation_Panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Navigation_Panel
            // 
            this.Navigation_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.Navigation_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Navigation_Panel.Controls.Add(this.tableLayoutPanel1);
            this.Navigation_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Navigation_Panel.Location = new System.Drawing.Point(0, 0);
            this.Navigation_Panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Navigation_Panel.Name = "Navigation_Panel";
            this.Navigation_Panel.Size = new System.Drawing.Size(150, 450);
            this.Navigation_Panel.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.profile_BT, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.users_BT, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.admin_BT, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Main_BT, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.events_BT, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.logo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(148, 448);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // profile_BT
            // 
            this.profile_BT.BackColor = System.Drawing.Color.Transparent;
            this.profile_BT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile_BT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profile_BT.FlatAppearance.BorderSize = 0;
            this.profile_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile_BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.profile_BT.ForeColor = System.Drawing.Color.White;
            this.profile_BT.Image = ((System.Drawing.Image)(resources.GetObject("profile_BT.Image")));
            this.profile_BT.Location = new System.Drawing.Point(3, 315);
            this.profile_BT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profile_BT.Name = "profile_BT";
            this.profile_BT.Size = new System.Drawing.Size(142, 63);
            this.profile_BT.TabIndex = 5;
            this.profile_BT.Text = "Profile";
            this.profile_BT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profile_BT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.profile_BT.UseVisualStyleBackColor = false;
            this.profile_BT.Click += new System.EventHandler(this.profile_BT_Click);
            // 
            // users_BT
            // 
            this.users_BT.BackColor = System.Drawing.Color.Transparent;
            this.users_BT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users_BT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.users_BT.FlatAppearance.BorderSize = 0;
            this.users_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.users_BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.users_BT.ForeColor = System.Drawing.Color.White;
            this.users_BT.Image = ((System.Drawing.Image)(resources.GetObject("users_BT.Image")));
            this.users_BT.Location = new System.Drawing.Point(3, 248);
            this.users_BT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.users_BT.Name = "users_BT";
            this.users_BT.Size = new System.Drawing.Size(142, 63);
            this.users_BT.TabIndex = 1;
            this.users_BT.Text = "Users";
            this.users_BT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.users_BT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.users_BT.UseVisualStyleBackColor = false;
            this.users_BT.Click += new System.EventHandler(this.users_BT_Click);
            // 
            // admin_BT
            // 
            this.admin_BT.BackColor = System.Drawing.Color.Transparent;
            this.admin_BT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_BT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_BT.FlatAppearance.BorderSize = 0;
            this.admin_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.admin_BT.ForeColor = System.Drawing.Color.White;
            this.admin_BT.Image = ((System.Drawing.Image)(resources.GetObject("admin_BT.Image")));
            this.admin_BT.Location = new System.Drawing.Point(3, 382);
            this.admin_BT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_BT.Name = "admin_BT";
            this.admin_BT.Size = new System.Drawing.Size(142, 64);
            this.admin_BT.TabIndex = 2;
            this.admin_BT.Text = "Admin";
            this.admin_BT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_BT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.admin_BT.UseVisualStyleBackColor = false;
            this.admin_BT.Click += new System.EventHandler(this.admin_BT_Click);
            // 
            // Main_BT
            // 
            this.Main_BT.BackColor = System.Drawing.Color.Transparent;
            this.Main_BT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Main_BT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_BT.FlatAppearance.BorderSize = 0;
            this.Main_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Main_BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Main_BT.ForeColor = System.Drawing.Color.White;
            this.Main_BT.Image = ((System.Drawing.Image)(resources.GetObject("Main_BT.Image")));
            this.Main_BT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_BT.Location = new System.Drawing.Point(3, 114);
            this.Main_BT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Main_BT.Name = "Main_BT";
            this.Main_BT.Size = new System.Drawing.Size(142, 63);
            this.Main_BT.TabIndex = 0;
            this.Main_BT.Text = "Main";
            this.Main_BT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_BT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Main_BT.UseVisualStyleBackColor = false;
            this.Main_BT.Click += new System.EventHandler(this.Main_BT_Click);
            // 
            // events_BT
            // 
            this.events_BT.BackColor = System.Drawing.Color.Transparent;
            this.events_BT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.events_BT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.events_BT.FlatAppearance.BorderSize = 0;
            this.events_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.events_BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.events_BT.ForeColor = System.Drawing.Color.White;
            this.events_BT.Image = ((System.Drawing.Image)(resources.GetObject("events_BT.Image")));
            this.events_BT.Location = new System.Drawing.Point(3, 181);
            this.events_BT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.events_BT.Name = "events_BT";
            this.events_BT.Size = new System.Drawing.Size(142, 63);
            this.events_BT.TabIndex = 3;
            this.events_BT.Text = "Events";
            this.events_BT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.events_BT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.events_BT.UseVisualStyleBackColor = false;
            this.events_BT.Click += new System.EventHandler(this.events_BT_Click);
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.Image = global::TCC_App.Properties.Resources.TCClogo;
            this.logo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.logo.Location = new System.Drawing.Point(3, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(142, 112);
            this.logo.TabIndex = 4;
            // 
            // UI_NavigationBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Navigation_Panel);
            this.Name = "UI_NavigationBar";
            this.Size = new System.Drawing.Size(150, 450);
            this.Navigation_Panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
