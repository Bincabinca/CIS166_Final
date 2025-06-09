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
