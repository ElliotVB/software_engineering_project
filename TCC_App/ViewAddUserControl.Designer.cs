namespace CRMApplication
{
    partial class ViewAddUserControl
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
            txtFirstName = new TextBox();
            cmbStatus = new ComboBox();
            txtLastName = new TextBox();
            btnAddUser = new Button();
            labelFirstName = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtHashedPassword = new TextBox();
            label1 = new Label();
            pictureBoximage = new PictureBox();
            btnUploadImage = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoximage).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(128, 72);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(230, 45);
            txtFirstName.TabIndex = 0;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "Not Active" });
            cmbStatus.Location = new Point(650, 325);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(230, 37);
            cmbStatus.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(650, 72);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(266, 45);
            txtLastName.TabIndex = 0;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.Green;
            btnAddUser.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(412, 595);
            btnAddUser.Margin = new Padding(3, 4, 3, 4);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(292, 81);
            btnAddUser.TabIndex = 2;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFirstName.Location = new Point(122, 32);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(131, 29);
            labelFirstName.TabIndex = 3;
            labelFirstName.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(644, 32);
            label2.Name = "label2";
            label2.Size = new Size(128, 29);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(644, 285);
            label3.Name = "label3";
            label3.Size = new Size(79, 29);
            label3.TabIndex = 3;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(644, 156);
            label4.Name = "label4";
            label4.Size = new Size(74, 29);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(122, 156);
            label5.Name = "label5";
            label5.Size = new Size(176, 29);
            label5.TabIndex = 7;
            label5.Text = "Phone Number";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(650, 196);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(266, 45);
            txtEmail.TabIndex = 4;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhoneNumber.Location = new Point(128, 196);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(230, 45);
            txtPhoneNumber.TabIndex = 5;
            // 
            // txtHashedPassword
            // 
            txtHashedPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHashedPassword.Location = new Point(128, 325);
            txtHashedPassword.Margin = new Padding(3, 4, 3, 4);
            txtHashedPassword.Multiline = true;
            txtHashedPassword.Name = "txtHashedPassword";
            txtHashedPassword.Size = new Size(266, 45);
            txtHashedPassword.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(122, 285);
            label1.Name = "label1";
            label1.Size = new Size(209, 29);
            label1.TabIndex = 6;
            label1.Text = "Hashed Password";
            // 
            // pictureBoximage
            // 
            pictureBoximage.Location = new Point(470, 454);
            pictureBoximage.Margin = new Padding(3, 4, 3, 4);
            pictureBoximage.Name = "pictureBoximage";
            pictureBoximage.Size = new Size(168, 133);
            pictureBoximage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoximage.TabIndex = 8;
            pictureBoximage.TabStop = false;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(450, 394);
            btnUploadImage.Margin = new Padding(3, 4, 3, 4);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(188, 52);
            btnUploadImage.TabIndex = 9;
            btnUploadImage.Text = "Upload Image";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // AddUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnUploadImage);
            Controls.Add(pictureBoximage);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtHashedPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(labelFirstName);
            Controls.Add(btnAddUser);
            Controls.Add(cmbStatus);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddUserControl";
            Size = new Size(1094, 782);
            Load += AddUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoximage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtHashedPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoximage;
        private System.Windows.Forms.Button btnUploadImage;
    }
}
