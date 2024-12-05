namespace CRMApplication
{
    partial class ScheduleAnnouncementControl
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
            this.txtContent = new System.Windows.Forms.TextBox();
            this.dtpScheduleDate = new System.Windows.Forms.DateTimePicker();
            this.dgvAnnouncements = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnouncements)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtContent.Location = new System.Drawing.Point(291, 18);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(294, 37);
            this.txtContent.TabIndex = 0;
            // 
            // dtpScheduleDate
            // 
            this.dtpScheduleDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpScheduleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpScheduleDate.Location = new System.Drawing.Point(291, 79);
            this.dtpScheduleDate.Name = "dtpScheduleDate";
            this.dtpScheduleDate.Size = new System.Drawing.Size(294, 35);
            this.dtpScheduleDate.TabIndex = 1;
            // 
            // dgvAnnouncements
            // 
            this.dgvAnnouncements.AllowUserToAddRows = false;
            this.dgvAnnouncements.AllowUserToDeleteRows = false;
            this.dgvAnnouncements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAnnouncements.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvAnnouncements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnnouncements.Location = new System.Drawing.Point(17, 273);
            this.dgvAnnouncements.Name = "dgvAnnouncements";
            this.dgvAnnouncements.ReadOnly = true;
            this.dgvAnnouncements.RowHeadersWidth = 155;
            this.dgvAnnouncements.RowTemplate.Height = 28;
            this.dgvAnnouncements.Size = new System.Drawing.Size(697, 268);
            this.dgvAnnouncements.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(183, 155);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(329, 87);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(113, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(113, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Content";
            // 
            // ScheduleAnnouncementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvAnnouncements);
            this.Controls.Add(this.dtpScheduleDate);
            this.Controls.Add(this.txtContent);
            this.Name = "ScheduleAnnouncementControl";
            this.Size = new System.Drawing.Size(730, 560);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnouncements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.DateTimePicker dtpScheduleDate;
        private System.Windows.Forms.DataGridView dgvAnnouncements;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
