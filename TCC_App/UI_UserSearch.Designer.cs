namespace TCC_App
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
            this.userSearchLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.usersFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchBoxPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.userSearchLayoutPanel.SuspendLayout();
            this.searchBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userSearchLayoutPanel
            // 
            this.userSearchLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.userSearchLayoutPanel.ColumnCount = 1;
            this.userSearchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.userSearchLayoutPanel.Controls.Add(this.usersFlowLayoutPanel, 0, 1);
            this.userSearchLayoutPanel.Controls.Add(this.searchBoxPanel, 0, 0);
            this.userSearchLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userSearchLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.userSearchLayoutPanel.Name = "userSearchLayoutPanel";
            this.userSearchLayoutPanel.RowCount = 2;
            this.userSearchLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.userSearchLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.userSearchLayoutPanel.Size = new System.Drawing.Size(651, 450);
            this.userSearchLayoutPanel.TabIndex = 0;
            // 
            // usersFlowLayoutPanel
            // 
            this.usersFlowLayoutPanel.AutoScroll = true;
            this.usersFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersFlowLayoutPanel.Location = new System.Drawing.Point(3, 39);
            this.usersFlowLayoutPanel.Name = "usersFlowLayoutPanel";
            this.usersFlowLayoutPanel.Size = new System.Drawing.Size(645, 408);
            this.usersFlowLayoutPanel.TabIndex = 0;
            // 
            // searchBoxPanel
            // 
            this.searchBoxPanel.ColumnCount = 2;
            this.searchBoxPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.searchBoxPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.searchBoxPanel.Controls.Add(this.searchButton, 0, 0);
            this.searchBoxPanel.Controls.Add(this.searchBox, 1, 0);
            this.searchBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBoxPanel.Location = new System.Drawing.Point(3, 3);
            this.searchBoxPanel.Name = "searchBoxPanel";
            this.searchBoxPanel.RowCount = 1;
            this.searchBoxPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchBoxPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.searchBoxPanel.Size = new System.Drawing.Size(645, 30);
            this.searchBoxPanel.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = global::TCC_App.Properties.Resources.GridiconsSearch;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchButton.Location = new System.Drawing.Point(3, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(26, 24);
            this.searchButton.TabIndex = 10;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBox.ForeColor = System.Drawing.Color.Gray;
            this.searchBox.Location = new System.Drawing.Point(35, 3);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(607, 23);
            this.searchBox.TabIndex = 9;
            this.searchBox.Text = "Search for users";
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            // 
            // UI_UserSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userSearchLayoutPanel);
            this.Name = "UI_UserSearch";
            this.Size = new System.Drawing.Size(651, 450);
            this.userSearchLayoutPanel.ResumeLayout(false);
            this.searchBoxPanel.ResumeLayout(false);
            this.searchBoxPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel userSearchLayoutPanel;
        private FlowLayoutPanel usersFlowLayoutPanel;
        private TableLayoutPanel searchBoxPanel;
        private TextBox searchBox;
        private Button searchButton;
    }
}
