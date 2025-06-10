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

    public partial class Comments : Form
    {
        List<CustomListing<Car>> CL; // List to hold custom listings of cars
        private string Listing; // Variable to hold the Listing ID for comments
        public Comments(string listing, List<CustomListing<Car>> cL)
        {
            
            InitializeComponent();
            Listing = listing;
            CL = cL;
            List<string> listingItems = listing.Split('\n').ToList();
            string headerItem = "";
            for (int i=0;i<5;i++) {
                headerItem += listingItems[i] + " ";
            }
            lblListingHeader.Text = $"Comments for Listing ID:\n{headerItem}";

            txtComment.Text = LoadComments();


        }
        private string LoadComments() {

            List<string> listingscomments = System.IO.File.ReadAllText(CarListingsDB.ListingCommentsPath).Split('\n').ToList();
            string commentsString = "";

            foreach (string l in listingscomments) {
                if (l.Split('|')[0] == Listing) {
                    foreach (string c in l.Split('|')) {
                        commentsString += c + "\n";
                    }
                }
            }
            return commentsString;

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //Close the comments form
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            frmAddComment addCommentForm = new frmAddComment(); // Create a new instance of the Add Comment form
            addCommentForm.ShowDialog();
        }
    }
}
