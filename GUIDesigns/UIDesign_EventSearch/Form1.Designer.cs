namespace UIDesign_EventSearch
{
    partial class Form1
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
            this.navigationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.calendarsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.calendar1 = new System.Windows.Forms.Panel();
            this.eventsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calendarsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(16)))));
            this.navigationPanel.ColumnCount = 6;
            this.navigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.navigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.navigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.navigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.navigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.navigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Margin = new System.Windows.Forms.Padding(0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.RowCount = 1;
            this.navigationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.navigationPanel.Size = new System.Drawing.Size(801, 80);
            this.navigationPanel.TabIndex = 0;
            // 
            // calendarsPanel
            // 
            this.calendarsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.calendarsPanel.ColumnCount = 1;
            this.calendarsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.calendarsPanel.Controls.Add(this.panel1, 0, 1);
            this.calendarsPanel.Controls.Add(this.calendar1, 0, 0);
            this.calendarsPanel.Location = new System.Drawing.Point(0, 80);
            this.calendarsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.calendarsPanel.Name = "calendarsPanel";
            this.calendarsPanel.RowCount = 2;
            this.calendarsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarsPanel.Size = new System.Drawing.Size(213, 373);
            this.calendarsPanel.TabIndex = 1;
            // 
            // calendar1
            // 
            this.calendar1.BackgroundImage = global::UIDesign_EventSearch.Properties.Resources.calendar1;
            this.calendar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calendar1.Location = new System.Drawing.Point(3, 3);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(207, 180);
            this.calendar1.TabIndex = 0;
            // 
            // eventsPanel
            // 
            this.eventsPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.eventsPanel.ColumnCount = 3;
            this.eventsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.eventsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.eventsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.eventsPanel.Location = new System.Drawing.Point(213, 80);
            this.eventsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.eventsPanel.Name = "eventsPanel";
            this.eventsPanel.RowCount = 3;
            this.eventsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.eventsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.eventsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.eventsPanel.Size = new System.Drawing.Size(588, 373);
            this.eventsPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::UIDesign_EventSearch.Properties.Resources.calendar2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(3, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 180);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eventsPanel);
            this.Controls.Add(this.calendarsPanel);
            this.Controls.Add(this.navigationPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.calendarsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel navigationPanel;
        private TableLayoutPanel calendarsPanel;
        private TableLayoutPanel eventsPanel;
        private Panel calendar1;
        private Panel panel1;
    }
}