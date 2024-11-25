namespace FormSwitchTest
{
    partial class main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.placeholder = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // placeholder
            // 
            this.placeholder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeholder.Location = new System.Drawing.Point(0, 0);
            this.placeholder.Name = "placeholder";
            this.placeholder.Size = new System.Drawing.Size(542, 333);
            this.placeholder.TabIndex = 1;
            // 
            // main
            // 
            this.ClientSize = new System.Drawing.Size(542, 333);
            this.Controls.Add(this.placeholder);
            this.Name = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel placeholder;
    }
}