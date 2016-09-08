using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BorrowerLibrary;
using System.Net.Mail;

namespace Manager
{
    public partial class frmRegister : Form
    {
        Borrower _borrower;
        public frmRegister()
        {
            InitializeComponent();

            cbxGender.SelectedIndex = 0;
            cbxUserType.SelectedIndex = 0;

            _borrower = new Borrower();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (CheckInput())
                if (Register())
                {
                    MessageBox.Show(txtEmail.Text + " Successfuly Registered!");
                    this.Close();
                }
        }

        private void cbxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private bool CheckInput()
        {
            if (txtFirstname.Text.Length == 0)
            {
                MessageBox.Show("Please provide a valid First Name");
                return false;
            }
            if (txtMI.Text.Length == 0)
            {
                MessageBox.Show("Please provide a valid Middle Initial");
                return false;
            }
            if (txtLastName.Text.Length == 0)
            {
                MessageBox.Show("Please provide a valid Last Name");
                return false;
            }
            if (txtStudentEmployeeId.Text.Length == 0)
            {
                MessageBox.Show("Please provide a valid Student Number");
                return false;
            }
            if (txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Please provide a valid Email");
                return false;
            }
            else if(!IsValid(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Please provide a valid Email");
                return false;
            }
            else if(!CheckEmailAvailability(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Please provide a different Email. " + txtEmail.Text.Trim() + " is already registed!");
                return false;
            }
            if (txtPassword.Text.Length == 0 || txtPassword.Text != txtRepeatPassword.Text)
            {
                MessageBox.Show("Invalid Password");
                return false;
            }
            return true;
        }
        private bool Register()
        {
            _borrower.FirstName = txtFirstname.Text.Trim();
            _borrower.MiddleInitial = txtMI.Text.Trim();
            _borrower.LastName = txtLastName.Text.Trim();

            _borrower.StudentEmployeeId = int.Parse(txtStudentEmployeeId.Text.Trim());
            _borrower.Email = txtEmail.Text.Trim();
            _borrower.Gender = cbxGender.SelectedIndex + 1;

            BorrowerType status;
            Enum.TryParse<BorrowerType>(cbxUserType.Text, out status);

            _borrower.UserType = status;
            _borrower.Password = txtPassword.Text.Trim();

            if (_borrower.Register() > 0)
                return true;
            else
                return false;
        }

        private bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private bool CheckEmailAvailability(string email)
        {
            return _borrower.CheckEmailAvailability(email);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
