namespace TCC_App
{
    partial class UI_MainPage
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
            Profile4352 = new Panel();
            Profile_BT = new Label();
            panel2 = new Panel();
            labelMembershipButton = new Label();
            Coming_EventBT = new Panel();
            labelEventsButton = new Label();
            labelWelcomeMessage = new Label();
            mainLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            Profile4352.SuspendLayout();
            panel2.SuspendLayout();
            Coming_EventBT.SuspendLayout();
            mainLayoutPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Profile4352
            // 
            Profile4352.BackColor = Color.FromArgb(255, 160, 174);
            Profile4352.Controls.Add(Profile_BT);
            Profile4352.Cursor = Cursors.Hand;
            Profile4352.Dock = DockStyle.Fill;
            Profile4352.Location = new Point(433, 2);
            Profile4352.Margin = new Padding(3, 2, 3, 2);
            Profile4352.Name = "Profile4352";
            Profile4352.Size = new Size(209, 395);
            Profile4352.TabIndex = 10;
            // 
            // Profile_BT
            // 
            Profile_BT.AutoSize = true;
            Profile_BT.BackColor = Color.Transparent;
            Profile_BT.Dock = DockStyle.Top;
            Profile_BT.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            Profile_BT.ForeColor = Color.FromArgb(26, 0, 10);
            Profile_BT.Location = new Point(0, 0);
            Profile_BT.Name = "Profile_BT";
            Profile_BT.Size = new Size(107, 36);
            Profile_BT.TabIndex = 3;
            Profile_BT.Text = "Profile";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 194, 138);
            panel2.Controls.Add(labelMembershipButton);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(218, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 395);
            panel2.TabIndex = 8;
            // 
            // labelMembershipButton
            // 
            labelMembershipButton.AutoSize = true;
            labelMembershipButton.BackColor = Color.Transparent;
            labelMembershipButton.Dock = DockStyle.Top;
            labelMembershipButton.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelMembershipButton.ForeColor = Color.FromArgb(26, 0, 10);
            labelMembershipButton.Location = new Point(0, 0);
            labelMembershipButton.Name = "labelMembershipButton";
            labelMembershipButton.Size = new Size(188, 36);
            labelMembershipButton.TabIndex = 2;
            labelMembershipButton.Text = "Membership";
            // 
            // Coming_EventBT
            // 
            Coming_EventBT.BackColor = Color.FromArgb(115, 49, 71);
            Coming_EventBT.Controls.Add(labelEventsButton);
            Coming_EventBT.Dock = DockStyle.Fill;
            Coming_EventBT.Location = new Point(3, 2);
            Coming_EventBT.Margin = new Padding(3, 2, 3, 2);
            Coming_EventBT.Name = "Coming_EventBT";
            Coming_EventBT.Size = new Size(209, 395);
            Coming_EventBT.TabIndex = 7;
            // 
            // labelEventsButton
            // 
            labelEventsButton.AutoSize = true;
            labelEventsButton.BackColor = Color.Transparent;
            labelEventsButton.Dock = DockStyle.Top;
            labelEventsButton.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelEventsButton.ForeColor = Color.White;
            labelEventsButton.Location = new Point(0, 0);
            labelEventsButton.Name = "labelEventsButton";
            labelEventsButton.Size = new Size(112, 36);
            labelEventsButton.TabIndex = 1;
            labelEventsButton.Text = "Events";
            // 
            // labelWelcomeMessage
            // 
            labelWelcomeMessage.AutoSize = true;
            labelWelcomeMessage.Dock = DockStyle.Left;
            labelWelcomeMessage.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcomeMessage.ForeColor = Color.FromArgb(26, 0, 10);
            labelWelcomeMessage.Location = new Point(3, 0);
            labelWelcomeMessage.Name = "labelWelcomeMessage";
            labelWelcomeMessage.Size = new Size(393, 45);
            labelWelcomeMessage.TabIndex = 6;
            labelWelcomeMessage.Text = "Good morning, UserName";
            // 
            // mainLayoutPanel
            // 
            mainLayoutPanel.ColumnCount = 1;
            mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayoutPanel.Controls.Add(labelWelcomeMessage, 0, 0);
            mainLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 1);
            mainLayoutPanel.Dock = DockStyle.Fill;
            mainLayoutPanel.Location = new Point(0, 0);
            mainLayoutPanel.Name = "mainLayoutPanel";
            mainLayoutPanel.RowCount = 2;
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            mainLayoutPanel.Size = new Size(651, 450);
            mainLayoutPanel.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.Controls.Add(Profile4352, 2, 0);
            tableLayoutPanel1.Controls.Add(Coming_EventBT, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 48);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(645, 399);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // UI_MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainLayoutPanel);
            Name = "UI_MainPage";
            Size = new Size(651, 450);
            Profile4352.ResumeLayout(false);
            Profile4352.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Coming_EventBT.ResumeLayout(false);
            Coming_EventBT.PerformLayout();
            mainLayoutPanel.ResumeLayout(false);
            mainLayoutPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Profile4352;
        private Label Profile_BT;
        private Panel panel2;
        private Label labelMembershipButton;
        private Panel Coming_EventBT;
        private Label labelEventsButton;
        private Label labelWelcomeMessage;
        private TableLayoutPanel mainLayoutPanel;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
