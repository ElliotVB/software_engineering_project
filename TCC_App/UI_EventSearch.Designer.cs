namespace TCC_App
{
    partial class UI_EventSearch
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
            calendarsPanel = new TableLayoutPanel();
            panel1 = new Panel();
            calendar1 = new Panel();
            searchBox = new TextBox();
            eventFlowLayout = new FlowLayoutPanel();
            searchButton = new Button();
            eventSearchLayoutPanel = new TableLayoutPanel();
            searchBoxLayoutPanel = new TableLayoutPanel();
            calendarsPanel.SuspendLayout();
            eventSearchLayoutPanel.SuspendLayout();
            searchBoxLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // calendarsPanel
            // 
            calendarsPanel.BackColor = Color.FromArgb(72, 19, 38);
            calendarsPanel.ColumnCount = 1;
            calendarsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            calendarsPanel.Controls.Add(panel1, 0, 1);
            calendarsPanel.Controls.Add(calendar1, 0, 0);
            calendarsPanel.Location = new Point(0, 0);
            calendarsPanel.Margin = new Padding(0);
            calendarsPanel.Name = "calendarsPanel";
            calendarsPanel.RowCount = 2;
            calendarsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            calendarsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            calendarsPanel.Size = new Size(243, 604);
            calendarsPanel.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.calendarDEC;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(6, 322);
            panel1.Margin = new Padding(6, 20, 6, 13);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(11, 13, 11, 13);
            panel1.Size = new Size(231, 269);
            panel1.TabIndex = 1;
            // 
            // calendar1
            // 
            calendar1.BackgroundImage = Properties.Resources.calendarNOV;
            calendar1.BackgroundImageLayout = ImageLayout.Stretch;
            calendar1.Dock = DockStyle.Fill;
            calendar1.Location = new Point(6, 13);
            calendar1.Margin = new Padding(6, 13, 6, 20);
            calendar1.Name = "calendar1";
            calendar1.Padding = new Padding(11, 13, 11, 13);
            calendar1.Size = new Size(231, 269);
            calendar1.TabIndex = 0;
            // 
            // searchBox
            // 
            searchBox.Dock = DockStyle.Fill;
            searchBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchBox.ForeColor = Color.Gray;
            searchBox.Location = new Point(55, 4);
            searchBox.Margin = new Padding(3, 4, 3, 4);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(603, 34);
            searchBox.TabIndex = 8;
            searchBox.Text = "Search for events";
            searchBox.Click += searchBox_Clicked;
            // 
            // eventFlowLayout
            // 
            eventFlowLayout.AutoScroll = true;
            eventFlowLayout.AutoScrollMargin = new Size(5, 5);
            eventFlowLayout.BackColor = Color.FromArgb(255, 192, 192);
            eventFlowLayout.Dock = DockStyle.Fill;
            eventFlowLayout.Location = new Point(0, 48);
            eventFlowLayout.Margin = new Padding(0);
            eventFlowLayout.Name = "eventFlowLayout";
            eventFlowLayout.Size = new Size(667, 556);
            eventFlowLayout.TabIndex = 9;
            // 
            // searchButton
            // 
            searchButton.BackgroundImage = Properties.Resources.GridiconsSearch;
            searchButton.BackgroundImageLayout = ImageLayout.Stretch;
            searchButton.Dock = DockStyle.Bottom;
            searchButton.Location = new Point(3, 4);
            searchButton.Margin = new Padding(3, 4, 3, 4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(46, 32);
            searchButton.TabIndex = 0;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // eventSearchLayoutPanel
            // 
            eventSearchLayoutPanel.BackColor = Color.FromArgb(255, 192, 192);
            eventSearchLayoutPanel.ColumnCount = 1;
            eventSearchLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            eventSearchLayoutPanel.Controls.Add(searchBoxLayoutPanel, 0, 0);
            eventSearchLayoutPanel.Controls.Add(eventFlowLayout, 0, 1);
            eventSearchLayoutPanel.Location = new Point(243, 0);
            eventSearchLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            eventSearchLayoutPanel.Name = "eventSearchLayoutPanel";
            eventSearchLayoutPanel.RowCount = 2;
            eventSearchLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            eventSearchLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 92F));
            eventSearchLayoutPanel.Size = new Size(667, 604);
            eventSearchLayoutPanel.TabIndex = 0;
            // 
            // searchBoxLayoutPanel
            // 
            searchBoxLayoutPanel.ColumnCount = 2;
            searchBoxLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            searchBoxLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92F));
            searchBoxLayoutPanel.Controls.Add(searchButton, 0, 0);
            searchBoxLayoutPanel.Controls.Add(searchBox, 1, 0);
            searchBoxLayoutPanel.Dock = DockStyle.Fill;
            searchBoxLayoutPanel.Location = new Point(3, 4);
            searchBoxLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            searchBoxLayoutPanel.Name = "searchBoxLayoutPanel";
            searchBoxLayoutPanel.RowCount = 1;
            searchBoxLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            searchBoxLayoutPanel.Size = new Size(661, 40);
            searchBoxLayoutPanel.TabIndex = 0;
            // 
            // UI_EventSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(calendarsPanel);
            Controls.Add(eventSearchLayoutPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UI_EventSearch";
            Size = new Size(910, 593);
            calendarsPanel.ResumeLayout(false);
            eventSearchLayoutPanel.ResumeLayout(false);
            searchBoxLayoutPanel.ResumeLayout(false);
            searchBoxLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel calendarsPanel;
        private Panel panel1;
        private Panel calendar1;
        private TextBox searchBox;
        private FlowLayoutPanel eventFlowLayout;
        private Button searchButton;
        private TableLayoutPanel searchBoxLayoutPanel;
        private TableLayoutPanel eventSearchLayoutPanel;
    }
}
