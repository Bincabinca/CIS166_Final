using CarDealership.DatabaseFiles;
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
    public partial class frmDeleteListing : Form
    {
        List<CustomListing<Car>> CL;
        ComboBox Filters;
        public frmDeleteListing(List<CustomListing<Car>> cl, ComboBox filters)
        {
            CL = cl;
            Filters = filters;

            InitializeComponent();

            cboListings.Items.Add("Select a car to delete...");
            cboListings.SelectedIndex = 0;

            foreach (CustomListing<Car> listing in CL)
            {
                cboListings.Items.Add(listing.CreationTime + " " + listing.Car.Color + " " + listing.Car.Make + " " + listing.Car.Model + " $" + listing.Car.Price);
            }
        }

        private void cboListings_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboListings.SelectedIndex > 0)
            {


                //Remove the color from the database as well if its the only one
                bool removeColor = CarColorsDB.Remove(CL[cboListings.SelectedIndex - 1].Car.Color);

                if (removeColor) {
                    // remove color from the filter
                    Filters.Items.Remove(CL[cboListings.SelectedIndex - 1].Car.Color);
                }

                // check against which Delete() method to use
                switch (CL[cboListings.SelectedIndex - 1].Car.Make)
                {
                    case "BMW":
                        CarListingsDB.Delete((BMW)CL[cboListings.SelectedIndex - 1].Car, CL[cboListings.SelectedIndex - 1].CreationTime.ToString());
                        break;
                    case "Toyota":
                        CarListingsDB.Delete((Toyota)CL[cboListings.SelectedIndex - 1].Car, CL[cboListings.SelectedIndex - 1].CreationTime.ToString());
                        break;
                    case "Honda":
                        CarListingsDB.Delete((Honda)CL[cboListings.SelectedIndex - 1].Car, CL[cboListings.SelectedIndex - 1].CreationTime.ToString());
                        break;
                    default:
                        CarListingsDB.Delete((Mercedes)CL[cboListings.SelectedIndex - 1].Car, CL[cboListings.SelectedIndex - 1].CreationTime.ToString());
                        break;
                }

                Close();
                
            }

            else
            {
                MessageBox.Show("Please select a car to delete.", "Make a Selection");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
