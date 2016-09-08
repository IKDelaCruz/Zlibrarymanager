using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BorrowerLibrary;

namespace Manager
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void lnlSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmRegister().ShowDialog();
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                Login();
        }
        private void Login()
        {
            var borrower = new Borrower();
            var user = borrower.Login(txtEmail.Text.Trim(), txtPassword.Text);
            if (user != null)
            {
                Program.CurrentBorrower = user;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid User", "Simplified Library System");
            }
        }
    }
}
