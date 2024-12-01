namespace CRMApplication
{
    partial class ViewAnalyticsControl
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
            this.dgvAnalytics = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalytics)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAnalytics
            // 
            this.dgvAnalytics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAnalytics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnalytics.Location = new System.Drawing.Point(13, 21);
            this.dgvAnalytics.Name = "dgvAnalytics";
            this.dgvAnalytics.RowHeadersWidth = 180;
            this.dgvAnalytics.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAnalytics.RowTemplate.Height = 28;
            this.dgvAnalytics.Size = new System.Drawing.Size(693, 519);
            this.dgvAnalytics.TabIndex = 0;
            // 
            // ViewAnalyticsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAnalytics);
            this.Name = "ViewAnalyticsControl";
            this.Size = new System.Drawing.Size(730, 560);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalytics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnalytics;
    }
}
