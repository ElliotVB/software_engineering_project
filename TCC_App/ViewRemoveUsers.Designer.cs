﻿namespace CRMApplication
{
    partial class RemoveUserControl
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
            dataGridViewUsers = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(21, 26);
            dataGridViewUsers.Margin = new Padding(3, 4, 3, 4);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 180;
            dataGridViewUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewUsers.RowTemplate.Height = 28;
            dataGridViewUsers.Size = new Size(1053, 546);
            dataGridViewUsers.TabIndex = 2;
            dataGridViewUsers.CellClick += dataGridViewUsers_CellClick;
            dataGridViewUsers.CellContentClick += dataGridViewUsers_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(465, 595);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(228, 74);
            button1.TabIndex = 3;
            button1.Text = "Remove User";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnRemoveUser;
            // 
            // RemoveUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(dataGridViewUsers);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RemoveUserControl";
            Size = new Size(1094, 782);
            Load += RemoveUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion
        // private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button button1;
    }
}
