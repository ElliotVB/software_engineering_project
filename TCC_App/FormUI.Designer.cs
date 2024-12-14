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
            SuspendLayout();
            // 
            // Display
            // 
            Display.BackColor = SystemColors.ControlLight;
            Display.Location = new Point(149, 0);
            Display.Margin = new Padding(0);
            Display.Name = "Display";
            Display.Size = new Size(650, 477);
            Display.TabIndex = 0;
            Display.Paint += Display_Paint;
            // 
            // NavigationPanel
            // 
            NavigationPanel.BackColor = SystemColors.ControlLight;
            NavigationPanel.Location = new Point(-1, 0);
            NavigationPanel.Margin = new Padding(0);
            NavigationPanel.Name = "NavigationPanel";
            NavigationPanel.Size = new Size(150, 477);
            NavigationPanel.TabIndex = 1;
            // 
            // FormUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(NavigationPanel);
            Controls.Add(Display);
            Name = "FormUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel Display;
        private Panel NavigationPanel;
    }
}