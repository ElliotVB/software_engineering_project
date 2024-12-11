namespace TCC_App
{
    partial class placeholder
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
            label1 = new Label();
            buttonEvents = new Button();
            btnAdminView = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 25);
            label1.TabIndex = 0;
            label1.Text = "placeholder user form";
            // 
            // buttonEvents
            // 
            buttonEvents.Location = new Point(4, 68);
            buttonEvents.Margin = new Padding(4, 5, 4, 5);
            buttonEvents.Name = "buttonEvents";
            buttonEvents.Size = new Size(136, 58);
            buttonEvents.TabIndex = 1;
            buttonEvents.Text = "Event search";
            buttonEvents.UseVisualStyleBackColor = true;
            buttonEvents.Click += buttonEvents_Click;
            // 
            // btnAdminView
            // 
            btnAdminView.Location = new Point(194, 68);
            btnAdminView.Margin = new Padding(4, 5, 4, 5);
            btnAdminView.Name = "btnAdminView";
            btnAdminView.Size = new Size(136, 58);
            btnAdminView.TabIndex = 2;
            btnAdminView.Text = "Admin View";
            btnAdminView.UseVisualStyleBackColor = true;
            btnAdminView.Click += btnAdminView_Click;
            // 
            // placeholder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAdminView);
            Controls.Add(buttonEvents);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "placeholder";
            Size = new Size(747, 577);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonEvents;
        private Button btnAdminView;
    }
}
