namespace TCC_App
{
    partial class FormUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Display = new System.Windows.Forms.Panel();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Display.Location = new System.Drawing.Point(149, 0);
            this.Display.Margin = new System.Windows.Forms.Padding(0);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(650, 451);
            this.Display.TabIndex = 0;
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 1);
            this.NavigationPanel.Margin = new System.Windows.Forms.Padding(0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(149, 450);
            this.NavigationPanel.TabIndex = 1;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(800, 451);
            this.LoginPanel.TabIndex = 0;
            // 
            // FormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.LoginPanel);
            this.Name = "FormUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Display;
        private Panel NavigationPanel;
        private Panel LoginPanel;
    }
}