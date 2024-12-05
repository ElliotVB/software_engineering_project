namespace CRMApplication
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewTasks = new System.Windows.Forms.Button();
            this.btnViewFeedback = new System.Windows.Forms.Button();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.btnEditPermissions = new System.Windows.Forms.Button();
            this.btnViewAnalytics = new System.Windows.Forms.Button();
            this.btnScheduleAnnouncement = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Together";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(16)))));
            this.panel2.Controls.Add(this.btnViewTasks);
            this.panel2.Controls.Add(this.btnViewFeedback);
            this.panel2.Controls.Add(this.btnAddUsers);
            this.panel2.Controls.Add(this.btnEditPermissions);
            this.panel2.Controls.Add(this.btnViewAnalytics);
            this.panel2.Controls.Add(this.btnScheduleAnnouncement);
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 610);
            this.panel2.TabIndex = 1;
            // 
            // btnViewTasks
            // 
            this.btnViewTasks.Location = new System.Drawing.Point(3, 479);
            this.btnViewTasks.Name = "btnViewTasks";
            this.btnViewTasks.Size = new System.Drawing.Size(190, 59);
            this.btnViewTasks.TabIndex = 5;
            this.btnViewTasks.Text = "View Tasks";
            this.btnViewTasks.UseVisualStyleBackColor = true;
            this.btnViewTasks.Click += new System.EventHandler(this.btnViewTasks_Click);
            // 
            // btnViewFeedback
            // 
            this.btnViewFeedback.Location = new System.Drawing.Point(4, 390);
            this.btnViewFeedback.Name = "btnViewFeedback";
            this.btnViewFeedback.Size = new System.Drawing.Size(190, 59);
            this.btnViewFeedback.TabIndex = 4;
            this.btnViewFeedback.Text = "View Feedback";
            this.btnViewFeedback.UseVisualStyleBackColor = true;
            this.btnViewFeedback.Click += new System.EventHandler(this.btnViewFeedback_Click);
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.Location = new System.Drawing.Point(3, 301);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(190, 59);
            this.btnAddUsers.TabIndex = 3;
            this.btnAddUsers.Text = "Add Users";
            this.btnAddUsers.UseVisualStyleBackColor = true;
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUsers_Click);
            // 
            // btnEditPermissions
            // 
            this.btnEditPermissions.Location = new System.Drawing.Point(4, 216);
            this.btnEditPermissions.Name = "btnEditPermissions";
            this.btnEditPermissions.Size = new System.Drawing.Size(190, 59);
            this.btnEditPermissions.TabIndex = 2;
            this.btnEditPermissions.Text = "Edit Permissions";
            this.btnEditPermissions.UseVisualStyleBackColor = true;
            this.btnEditPermissions.Click += new System.EventHandler(this.btnEditPermissions_Click);
            // 
            // btnViewAnalytics
            // 
            this.btnViewAnalytics.Location = new System.Drawing.Point(4, 134);
            this.btnViewAnalytics.Name = "btnViewAnalytics";
            this.btnViewAnalytics.Size = new System.Drawing.Size(190, 59);
            this.btnViewAnalytics.TabIndex = 1;
            this.btnViewAnalytics.Text = "View Analytics";
            this.btnViewAnalytics.UseVisualStyleBackColor = true;
            this.btnViewAnalytics.Click += new System.EventHandler(this.btnViewAnalytics_Click);
            // 
            // btnScheduleAnnouncement
            // 
            this.btnScheduleAnnouncement.Location = new System.Drawing.Point(4, 55);
            this.btnScheduleAnnouncement.Name = "btnScheduleAnnouncement";
            this.btnScheduleAnnouncement.Size = new System.Drawing.Size(190, 59);
            this.btnScheduleAnnouncement.TabIndex = 0;
            this.btnScheduleAnnouncement.Text = "Schedule Announcement";
            this.btnScheduleAnnouncement.UseVisualStyleBackColor = true;
            this.btnScheduleAnnouncement.Click += new System.EventHandler(this.btnScheduleAnnouncement_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Location = new System.Drawing.Point(212, 152);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(721, 568);
            this.panelMain.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Culture";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cambridge";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(206, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Administrative View";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(239, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(370, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(503, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(640, 39);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 52);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(773, 39);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(59, 52);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 720);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViewTasks;
        private System.Windows.Forms.Button btnViewFeedback;
        private System.Windows.Forms.Button btnAddUsers;
        private System.Windows.Forms.Button btnEditPermissions;
        private System.Windows.Forms.Button btnViewAnalytics;
        private System.Windows.Forms.Button btnScheduleAnnouncement;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

