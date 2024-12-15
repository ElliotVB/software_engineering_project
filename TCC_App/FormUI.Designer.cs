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
            Display = new Panel();
            NavigationPanel = new Panel();
            LoginPanel = new Panel();
            LoginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Display
            // 
            Display.BackColor = SystemColors.ControlLight;
            Display.Location = new Point(192, 0);
            Display.Margin = new Padding(0);
            Display.Name = "Display";
            Display.Size = new Size(910, 593);
            Display.TabIndex = 0;
            // 
            // NavigationPanel
            // 
            NavigationPanel.BackColor = SystemColors.ControlLight;
            NavigationPanel.Location = new Point(0, 1);
            NavigationPanel.Margin = new Padding(0);
            NavigationPanel.Name = "NavigationPanel";
            NavigationPanel.Size = new Size(193, 593);
            NavigationPanel.TabIndex = 1;
            // 
            // LoginPanel
            // 
            LoginPanel.Controls.Add(Display);
            LoginPanel.Dock = DockStyle.Fill;
            LoginPanel.Location = new Point(0, 0);
            LoginPanel.Margin = new Padding(3, 4, 3, 4);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(1102, 593);
            LoginPanel.TabIndex = 0;
            // 
            // FormUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 593);
            Controls.Add(NavigationPanel);
            Controls.Add(LoginPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            LoginPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Display;
        private Panel NavigationPanel;
        private Panel LoginPanel;
    }
}