using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
