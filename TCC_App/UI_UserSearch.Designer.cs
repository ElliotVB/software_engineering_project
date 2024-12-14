﻿namespace TCC_App
{
    partial class UI_UserSearch
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
            userSearchLayoutPanel = new TableLayoutPanel();
            usersFlowLayoutPanel = new FlowLayoutPanel();
            searchBoxPanel = new TableLayoutPanel();
            searchButton = new Button();
            searchBox = new TextBox();
            userSearchLayoutPanel.SuspendLayout();
            searchBoxPanel.SuspendLayout();
            SuspendLayout();
            // 
            // userSearchLayoutPanel
            // 
            userSearchLayoutPanel.BackColor = Color.FromArgb(255, 192, 192);
            userSearchLayoutPanel.ColumnCount = 1;
            userSearchLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            userSearchLayoutPanel.Controls.Add(usersFlowLayoutPanel, 0, 1);
            userSearchLayoutPanel.Controls.Add(searchBoxPanel, 0, 0);
            userSearchLayoutPanel.Dock = DockStyle.Fill;
            userSearchLayoutPanel.Location = new Point(0, 0);
            userSearchLayoutPanel.Name = "userSearchLayoutPanel";
            userSearchLayoutPanel.RowCount = 2;
            userSearchLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            userSearchLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 92F));
            userSearchLayoutPanel.Size = new Size(651, 450);
            userSearchLayoutPanel.TabIndex = 0;
            // 
            // usersFlowLayoutPanel
            // 
            usersFlowLayoutPanel.AutoScroll = true;
            usersFlowLayoutPanel.Dock = DockStyle.Fill;
            usersFlowLayoutPanel.Location = new Point(3, 39);
            usersFlowLayoutPanel.Name = "usersFlowLayoutPanel";
            usersFlowLayoutPanel.Size = new Size(645, 408);
            usersFlowLayoutPanel.TabIndex = 0;
            // 
            // searchBoxPanel
            // 
            searchBoxPanel.ColumnCount = 2;
            searchBoxPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            searchBoxPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95F));
            searchBoxPanel.Controls.Add(searchButton, 0, 0);
            searchBoxPanel.Controls.Add(searchBox, 1, 0);
            searchBoxPanel.Dock = DockStyle.Fill;
            searchBoxPanel.Location = new Point(3, 3);
            searchBoxPanel.Name = "searchBoxPanel";
            searchBoxPanel.RowCount = 1;
            searchBoxPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            searchBoxPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            searchBoxPanel.Size = new Size(645, 30);
            searchBoxPanel.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.BackgroundImage = Properties.Resources.GridiconsSearch;
            searchButton.BackgroundImageLayout = ImageLayout.Stretch;
            searchButton.Dock = DockStyle.Bottom;
            searchButton.Location = new Point(3, 3);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(26, 24);
            searchButton.TabIndex = 10;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchBox
            // 
            searchBox.Dock = DockStyle.Fill;
            searchBox.ForeColor = Color.Gray;
            searchBox.Location = new Point(35, 3);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(607, 23);
            searchBox.TabIndex = 9;
            searchBox.Text = "Search for users";
            searchBox.Click += searchBox_Clicked;
            // 
            // UI_UserSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(userSearchLayoutPanel);
            Name = "UI_UserSearch";
            Size = new Size(651, 450);
            userSearchLayoutPanel.ResumeLayout(false);
            searchBoxPanel.ResumeLayout(false);
            searchBoxPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel userSearchLayoutPanel;
        private FlowLayoutPanel usersFlowLayoutPanel;
        private TableLayoutPanel searchBoxPanel;
        private TextBox searchBox;
        private Button searchButton;
    }
}
