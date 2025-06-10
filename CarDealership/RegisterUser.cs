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
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text;


                var lines = System.IO.File.Exists(Authorizer.UsersPath)
                    ? System.IO.File.ReadAllLines(Authorizer.UsersPath)
                    : new string[0];

                bool usersExists = lines.Any(line =>
                line.StartsWith(username + "|",StringComparison.OrdinalIgnoreCase));

                if (usersExists)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Registration Error");
                }
                else
                {
          
                    string userEntry = $"{username}|{password}";

                    System.IO.File.AppendAllText(Authorizer.UsersPath, userEntry + Environment.NewLine);
                    MessageBox.Show("User created successfully!", "Success");
                    this.Close();
                }
            }
        }
        //Validate all input before creating login
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
