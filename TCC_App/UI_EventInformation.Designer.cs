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
            EventPrice = new Label();
            EventLocation = new Label();
            Contact2 = new Label();
            Contact1 = new Label();
            ContactsTableLayout = new TableLayoutPanel();
            EventInfoLayoutPanel = new TableLayoutPanel();
            EventDateTime = new Label();
            EventDescription = new Label();
            EventName = new Label();
            pctEventImage = new Panel();
            eventLayoutPanel = new TableLayoutPanel();
            Book = new Button();
            ContactsTableLayout.SuspendLayout();
            EventInfoLayoutPanel.SuspendLayout();
            eventLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // EventPrice
            // 
            EventPrice.AutoSize = true;
            EventPrice.Dock = DockStyle.Fill;
            EventPrice.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            EventPrice.Location = new Point(3, 360);
            EventPrice.Name = "EventPrice";
            EventPrice.Size = new Size(345, 45);
            EventPrice.TabIndex = 1;
            EventPrice.Text = "Price";
            EventPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EventLocation
            // 
            EventLocation.AutoSize = true;
            EventLocation.BackColor = Color.FromArgb(255, 192, 192);
            EventLocation.Dock = DockStyle.Fill;
            EventLocation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EventLocation.Location = new Point(3, 270);
            EventLocation.Name = "EventLocation";
            EventLocation.Size = new Size(345, 45);
            EventLocation.TabIndex = 3;
            EventLocation.Text = "Event location";
            EventLocation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Contact2
            // 
            Contact2.AutoSize = true;
            Contact2.Dock = DockStyle.Fill;
            Contact2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Contact2.Location = new Point(168, 0);
            Contact2.Name = "Contact2";
            Contact2.Size = new Size(160, 17);
            Contact2.TabIndex = 1;
            Contact2.Text = "contact2@gmail.com";
            Contact2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Contact1
            // 
            Contact1.AutoSize = true;
            Contact1.Dock = DockStyle.Fill;
            Contact1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Contact1.Location = new Point(3, 0);
            Contact1.Name = "Contact1";
            Contact1.Size = new Size(159, 17);
            Contact1.TabIndex = 0;
            Contact1.Text = "contact1@gmail.com";
            Contact1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ContactsTableLayout
            // 
            ContactsTableLayout.ColumnCount = 2;
            ContactsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ContactsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ContactsTableLayout.Controls.Add(Contact2, 1, 0);
            ContactsTableLayout.Controls.Add(Contact1, 0, 0);
            ContactsTableLayout.Location = new Point(10, 415);
            ContactsTableLayout.Margin = new Padding(10);
            ContactsTableLayout.Name = "ContactsTableLayout";
            ContactsTableLayout.RowCount = 1;
            ContactsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ContactsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ContactsTableLayout.Size = new Size(331, 17);
            ContactsTableLayout.TabIndex = 0;
            // 
            // EventInfoLayoutPanel
            // 
            EventInfoLayoutPanel.BackColor = Color.FromArgb(255, 192, 192);
            EventInfoLayoutPanel.ColumnCount = 1;
            EventInfoLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            EventInfoLayoutPanel.Controls.Add(EventDateTime, 0, 2);
            EventInfoLayoutPanel.Controls.Add(ContactsTableLayout, 0, 4);
            EventInfoLayoutPanel.Controls.Add(EventPrice, 0, 3);
            EventInfoLayoutPanel.Controls.Add(EventDescription, 0, 0);
            EventInfoLayoutPanel.Controls.Add(EventLocation, 0, 1);
            EventInfoLayoutPanel.Location = new Point(300, 0);
            EventInfoLayoutPanel.Margin = new Padding(0);
            EventInfoLayoutPanel.Name = "EventInfoLayoutPanel";
            EventInfoLayoutPanel.RowCount = 5;
            EventInfoLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            EventInfoLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EventInfoLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EventInfoLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EventInfoLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EventInfoLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            EventInfoLayoutPanel.Size = new Size(351, 450);
            EventInfoLayoutPanel.TabIndex = 10;
            EventInfoLayoutPanel.Paint += EventInfoLayoutPanel_Paint;
            // 
            // EventDateTime
            // 
            EventDateTime.AutoSize = true;
            EventDateTime.BackColor = Color.FromArgb(255, 192, 192);
            EventDateTime.Dock = DockStyle.Fill;
            EventDateTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EventDateTime.Location = new Point(3, 315);
            EventDateTime.Name = "EventDateTime";
            EventDateTime.Size = new Size(345, 45);
            EventDateTime.TabIndex = 4;
            EventDateTime.Text = "Event DateTime";
            EventDateTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EventDescription
            // 
            EventDescription.AutoSize = true;
            EventDescription.BackColor = Color.FromArgb(255, 192, 192);
            EventDescription.Dock = DockStyle.Fill;
            EventDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EventDescription.Location = new Point(15, 15);
            EventDescription.Margin = new Padding(15);
            EventDescription.Name = "EventDescription";
            EventDescription.Size = new Size(321, 240);
            EventDescription.TabIndex = 2;
            EventDescription.Text = resources.GetString("EventDescription.Text");
            EventDescription.TextAlign = ContentAlignment.TopCenter;
            // 
            // EventName
            // 
            EventName.AutoSize = true;
            EventName.Dock = DockStyle.Fill;
            EventName.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            EventName.ForeColor = SystemColors.ControlLightLight;
            EventName.Location = new Point(3, 265);
            EventName.Name = "EventName";
            EventName.Size = new Size(294, 63);
            EventName.TabIndex = 0;
            EventName.Text = "Example event";
            EventName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pctEventImage
            // 
            pctEventImage.BackgroundImage = Properties.Resources._event;
            pctEventImage.BackgroundImageLayout = ImageLayout.Stretch;
            pctEventImage.Dock = DockStyle.Fill;
            pctEventImage.Location = new Point(3, 25);
            pctEventImage.Name = "pctEventImage";
            pctEventImage.Size = new Size(294, 237);
            pctEventImage.TabIndex = 9;
            // 
            // eventLayoutPanel
            // 
            eventLayoutPanel.BackColor = Color.FromArgb(72, 19, 38);
            eventLayoutPanel.ColumnCount = 1;
            eventLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            eventLayoutPanel.Controls.Add(EventName, 0, 2);
            eventLayoutPanel.Controls.Add(pctEventImage, 0, 1);
            eventLayoutPanel.Controls.Add(Book, 0, 3);
            eventLayoutPanel.Location = new Point(0, 0);
            eventLayoutPanel.Margin = new Padding(0);
            eventLayoutPanel.Name = "eventLayoutPanel";
            eventLayoutPanel.RowCount = 5;
            eventLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            eventLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 54F));
            eventLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            eventLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            eventLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            eventLayoutPanel.Size = new Size(300, 450);
            eventLayoutPanel.TabIndex = 8;
            // 
            // Book
            // 
            Book.BackColor = Color.FromArgb(254, 30, 60);
            Book.Dock = DockStyle.Fill;
            Book.FlatAppearance.BorderSize = 0;
            Book.FlatStyle = FlatStyle.Flat;
            Book.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            Book.ForeColor = SystemColors.ControlLightLight;
            Book.Location = new Point(3, 331);
            Book.Name = "Book";
            Book.Size = new Size(294, 70);
            Book.TabIndex = 8;
            Book.Text = "Book";
            Book.UseVisualStyleBackColor = false;
            Book.Click += Book_Click;
            // 
            // UI_EventInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EventInfoLayoutPanel);
            Controls.Add(eventLayoutPanel);
            Name = "UI_EventInformation";
            Size = new Size(651, 450);
            ContactsTableLayout.ResumeLayout(false);
            ContactsTableLayout.PerformLayout();
            EventInfoLayoutPanel.ResumeLayout(false);
            EventInfoLayoutPanel.PerformLayout();
            eventLayoutPanel.ResumeLayout(false);
            eventLayoutPanel.PerformLayout();
            ResumeLayout(false);
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
        private Panel pctEventImage;
        private TableLayoutPanel eventLayoutPanel;
        private Button Book;
        private Label EventDateTime;
    }
}
