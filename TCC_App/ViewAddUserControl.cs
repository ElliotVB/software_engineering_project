using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;

namespace CRMApplication
{
    public partial class ViewAddUserControl : UserControl
    {
        public ViewAddUserControl()
        {
            InitializeComponent();
            txtHashedPassword.PasswordChar = '*';

        }

       

        private void AddUserControl_Load(object sender, EventArgs e)
        {
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No DB is Attached🧑");
           
        }

        private void ClearFormFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtHashedPassword.Clear();
            cmbStatus.SelectedIndex = -1;
            pictureBoximage.Image = null;
            selectedImagePath = string.Empty;
        }
    
        private string selectedImagePath = string.Empty;

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    pictureBoximage.Image = Image.FromFile(selectedImagePath);
                }
            }
        }


    }
}

