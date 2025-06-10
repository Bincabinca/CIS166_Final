using CarDealership.DatabaseFiles;
using System;
using System.CodeDom;
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
    public partial class frmAddListing : Form
    {
        string User { get; set; }
        public frmAddListing()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //Check data is valid before add to listings
            if (IsValid())
                {
                if (cboMake.SelectedText != null)
                {
                    var selectedMake = cboMake.SelectedItem.ToString().Trim();
                    if (selectedMake == nameof(BMW))
                    {
                        BMW newCar = new BMW(txtModel.Text.ToString(),
                                        txtColor.Text.ToString(),
                                        Convert.ToInt32(txtAge.Text.ToString()),
                                        Convert.ToDecimal(txtPrice.Text.ToString()),
                                        txtExtra.Text.ToString(),
                                        User);
                        newCar.User = "Bianca";
                        CarListingsDB.Save(newCar);
                    }
                    else if (selectedMake == nameof(Toyota))
                    {
                        Toyota newCar = new Toyota(txtModel.Text.ToString(),
                                        txtColor.Text.ToString(),
                                        Convert.ToInt32(txtAge.Text.ToString()),
                                        Convert.ToDecimal(txtPrice.Text.ToString()),
                                        txtExtra.Text.ToString(),
                                        User);
                        newCar.User = "Bianca";
                        CarListingsDB.Save(newCar);
                    }
                    else if (selectedMake == nameof(Honda))
                    {
                        Honda newCar = new Honda(txtModel.Text.ToString(),
                                        txtColor.Text.ToString(),
                                        Convert.ToInt32(txtAge.Text.ToString()),
                                        Convert.ToDecimal(txtPrice.Text.ToString()),
                                        txtExtra.Text.ToString(),
                                        User);
                        newCar.User = "Bianca";
                        CarListingsDB.Save(newCar);
                    }
                    else if (selectedMake == nameof(Mercedes))
                    {
                        Mercedes newCar = new Mercedes(txtModel.Text.ToString(),
                                        txtColor.Text.ToString(),
                                        Convert.ToInt32(txtAge.Text.ToString()),
                                        Convert.ToDecimal(txtPrice.Text.ToString()),
                                        txtExtra.Text.ToString(),
                                        User);
                        newCar.User = "Bianca";
                        CarListingsDB.Save(newCar);
                    }
                }
                this.Close();
            }
        }

        private void frmAddListing_Load(object sender, EventArgs e)
        {
            cboMake.Items.Clear();
            cboMake.Items.Add("Select a car make...");
            cboMake.SelectedIndex = 0;
            cboMake.Items.AddRange(CarMakesDB.Get().ToArray());
        }

   
        private void cboMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMake = cboMake.SelectedItem.ToString().Trim();

            if(selectedMake != null)
            {
                lblExtra.Visible = true;
                txtExtra.Visible = true;
                lblExtra.Enabled = true;
                txtExtra.Enabled = true;
                switch (selectedMake) {
                    case nameof(BMW): lblExtra.Text = "Engine: "; break;
                    case nameof(Honda): lblExtra.Text = "Safety Rating: ";break;
                    case nameof(Toyota): lblExtra.Text = "Mileage: ";break;
                    case nameof(Mercedes): lblExtra.Text = "Horsepower: "; break;
                    default: 
                    lblExtra.Text = "Select Make... ";
                    txtExtra.Enabled = false; break; // no extra field with no make
                }
            }
        }
        
        //Validate all input before adding to listings
        public bool IsValid()
        {
            bool success = true;
            string msg = "";
            
            //Check a car make is selected
            if (cboMake.SelectedIndex == 0)
            {
                msg += "Please select a car make.\n";
            }
            else
            {
                msg += Validator.IsPresent(txtExtra.Text, lblExtra.ToString());
            }

            msg += Validator.IsPresent(txtModel.Text, "Model");
            msg += Validator.IsPresent(txtColor.Text, "Color");
            msg += Validator.IsInt32(txtAge.Text, "Age");
            msg += Validator.IsDecimal(txtPrice.Text, "Price");

            //If there are invalid inputs
            if (msg != "")
            {
                success = false;
                MessageBox.Show(msg, "Entry Error");
            }

            //If all inputs are valid
            return success;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
