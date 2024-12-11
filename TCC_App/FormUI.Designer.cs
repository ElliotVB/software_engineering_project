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
            SuspendLayout();
            // 
            // Display
            // 
            Display.BackColor = SystemColors.ControlLight;
            Display.Dock = DockStyle.Fill;
            Display.Location = new Point(0, 0);
            Display.Margin = new Padding(4, 5, 4, 5);
            Display.Name = "Display";
            Display.Size = new Size(1143, 750);
            Display.TabIndex = 0;
            // 
            // FormUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(Display);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel Display;
    }
}