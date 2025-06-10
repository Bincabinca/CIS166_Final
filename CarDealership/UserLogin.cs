using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationLibrary;

namespace CarDealership
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            //Open RegisterUser form
            RegisterUser registerUserForm = new RegisterUser();
            registerUserForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (IsValid())
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text;

                // Read all users from the file
                var lines = System.IO.File.Exists(Authorizer.UsersPath)
                    ? System.IO.File.ReadAllLines(Authorizer.UsersPath)
                    : new string[0];

                // Check for a matching username and key
                bool authenticated = lines.Any(line =>
                    line.Equals($"{username}|{password}", StringComparison.OrdinalIgnoreCase));

                if (authenticated)
                {
                    MessageBox.Show("Login successful!", "Success");
                    this.DialogResult = DialogResult.OK; // Indicate success to the calling form
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed");
                }
            }
        }

        //Validate all input before logging in
        public bool IsValid()
        {
            bool success = true;
            string msg = "";

            msg += Validator.IsPresent(txtUsername.Text, "Username");
            msg += Validator.IsPresent(txtPassword.Text, "Password");

            //If there are invalid inputs
            if (msg != "")
            {
                success = false;
                MessageBox.Show(msg, "Entry Error");
            }

            //If all inputs are valid
            return success;
        }
    }
}
