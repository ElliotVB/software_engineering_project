namespace CRMApplication
{
    partial class ViewFeedbackControl
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
            this.dgvFeedback = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFeedback
            // 
            this.dgvFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFeedback.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedback.Location = new System.Drawing.Point(13, 21);
            this.dgvFeedback.Name = "dgvFeedback";
            this.dgvFeedback.RowHeadersWidth = 150;
            this.dgvFeedback.RowTemplate.Height = 28;
            this.dgvFeedback.Size = new System.Drawing.Size(693, 519);
            this.dgvFeedback.TabIndex = 0;
            // 
            // ViewFeedbackControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvFeedback);
            this.Name = "ViewFeedbackControl";
            this.Size = new System.Drawing.Size(730, 560);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFeedback;
    }
}
