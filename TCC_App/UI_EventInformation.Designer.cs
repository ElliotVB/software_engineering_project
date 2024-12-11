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
            this.EventPrice = new System.Windows.Forms.Label();
            this.EventLocation = new System.Windows.Forms.Label();
            this.Contact2 = new System.Windows.Forms.Label();
            this.Contact1 = new System.Windows.Forms.Label();
            this.ContactsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.EventInfoLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EventDateTime = new System.Windows.Forms.Label();
            this.EventDescription = new System.Windows.Forms.Label();
            this.EventName = new System.Windows.Forms.Label();
            this.EventImage = new System.Windows.Forms.Panel();
            this.eventLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Book = new System.Windows.Forms.Button();
            this.ContactsTableLayout.SuspendLayout();
            this.EventInfoLayoutPanel.SuspendLayout();
            this.eventLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EventPrice
            // 
            this.EventPrice.AutoSize = true;
            this.EventPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventPrice.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EventPrice.Location = new System.Drawing.Point(3, 360);
            this.EventPrice.Name = "EventPrice";
            this.EventPrice.Size = new System.Drawing.Size(345, 45);
            this.EventPrice.TabIndex = 1;
            this.EventPrice.Text = "Price";
            this.EventPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventLocation
            // 
            this.EventLocation.AutoSize = true;
            this.EventLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EventLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventLocation.Location = new System.Drawing.Point(3, 270);
            this.EventLocation.Name = "EventLocation";
            this.EventLocation.Size = new System.Drawing.Size(345, 45);
            this.EventLocation.TabIndex = 3;
            this.EventLocation.Text = "Event location";
            this.EventLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Contact2
            // 
            this.Contact2.AutoSize = true;
            this.Contact2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contact2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Contact2.Location = new System.Drawing.Point(168, 0);
            this.Contact2.Name = "Contact2";
            this.Contact2.Size = new System.Drawing.Size(160, 17);
            this.Contact2.TabIndex = 1;
            this.Contact2.Text = "contact2@gmail.com";
            this.Contact2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Contact1
            // 
            this.Contact1.AutoSize = true;
            this.Contact1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contact1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Contact1.Location = new System.Drawing.Point(3, 0);
            this.Contact1.Name = "Contact1";
            this.Contact1.Size = new System.Drawing.Size(159, 17);
            this.Contact1.TabIndex = 0;
            this.Contact1.Text = "contact1@gmail.com";
            this.Contact1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContactsTableLayout
            // 
            this.ContactsTableLayout.ColumnCount = 2;
            this.ContactsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContactsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContactsTableLayout.Controls.Add(this.Contact2, 1, 0);
            this.ContactsTableLayout.Controls.Add(this.Contact1, 0, 0);
            this.ContactsTableLayout.Location = new System.Drawing.Point(10, 415);
            this.ContactsTableLayout.Margin = new System.Windows.Forms.Padding(10);
            this.ContactsTableLayout.Name = "ContactsTableLayout";
            this.ContactsTableLayout.RowCount = 1;
            this.ContactsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContactsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContactsTableLayout.Size = new System.Drawing.Size(331, 17);
            this.ContactsTableLayout.TabIndex = 0;
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
            this.EventInfoLayoutPanel.Location = new System.Drawing.Point(300, 0);
            this.EventInfoLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.EventInfoLayoutPanel.Name = "EventInfoLayoutPanel";
            this.EventInfoLayoutPanel.RowCount = 5;
            this.EventInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.EventInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.EventInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.EventInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.EventInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.EventInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.EventInfoLayoutPanel.Size = new System.Drawing.Size(351, 450);
            this.EventInfoLayoutPanel.TabIndex = 10;
            this.EventInfoLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.EventInfoLayoutPanel_Paint);
            // 
            // EventDateTime
            // 
            this.EventDateTime.AutoSize = true;
            this.EventDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EventDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventDateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventDateTime.Location = new System.Drawing.Point(3, 315);
            this.EventDateTime.Name = "EventDateTime";
            this.EventDateTime.Size = new System.Drawing.Size(345, 45);
            this.EventDateTime.TabIndex = 4;
            this.EventDateTime.Text = "Event DateTime";
            this.EventDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.EventDescription.Size = new System.Drawing.Size(321, 240);
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
            this.EventName.Location = new System.Drawing.Point(3, 265);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(294, 63);
            this.EventName.TabIndex = 0;
            this.EventName.Text = "Example event";
            this.EventName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventImage
            // 
            this.EventImage.BackgroundImage = global::TCC_App.Properties.Resources._event;
            this.EventImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EventImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventImage.Location = new System.Drawing.Point(3, 25);
            this.EventImage.Name = "EventImage";
            this.EventImage.Size = new System.Drawing.Size(294, 237);
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
            this.eventLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.eventLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.eventLayoutPanel.Name = "eventLayoutPanel";
            this.eventLayoutPanel.RowCount = 5;
            this.eventLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.eventLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54F));
            this.eventLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.eventLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.eventLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.eventLayoutPanel.Size = new System.Drawing.Size(300, 450);
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
            this.Book.Location = new System.Drawing.Point(3, 331);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(294, 70);
            this.Book.TabIndex = 8;
            this.Book.Text = "Book";
            this.Book.UseVisualStyleBackColor = false;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // UI_EventInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EventInfoLayoutPanel);
            this.Controls.Add(this.eventLayoutPanel);
            this.Name = "UI_EventInformation";
            this.Size = new System.Drawing.Size(651, 450);
            this.ContactsTableLayout.ResumeLayout(false);
            this.ContactsTableLayout.PerformLayout();
            this.EventInfoLayoutPanel.ResumeLayout(false);
            this.EventInfoLayoutPanel.PerformLayout();
            this.eventLayoutPanel.ResumeLayout(false);
            this.eventLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label EventPrice;
        private Label EventLocation;
        private Label Contact2;
        private Label Contact1;
        private TableLayoutPanel ContactsTableLayout;
        private TableLayoutPanel EventInfoLayoutPanel;
        private Label EventDescription;
        private Label EventName;
        private Panel EventImage;
        private TableLayoutPanel eventLayoutPanel;
        private Button Book;
        private Label EventDateTime;
    }
}
