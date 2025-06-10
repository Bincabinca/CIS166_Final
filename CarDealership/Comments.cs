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
        private string Listingid; // Variable to hold the Listing ID for comments
        public Comments(string listingId, List<CustomListing<Car>> cL)
        {
            InitializeComponent();
      
            //LoadComments(); // Load comments for the given Listing ID
            //Listingid = listingId; // Initialize the Listing ID
            //CL = cL;// Initialize the list of custom listings

            //populateListingDropdown(); // Populate the listing dropdown with car makes
        }

        //private void LoadComments()
        //{
        //    List<string> comments = CommentStorage.getComments(Listingid); // Get comments for the Listing ID
        //    if (comments.Count > 0)
        //    {
        //        foreach (string comment in comments)
        //        {
        //            cboListing.Items.Add(comment); // Add each comment to the list box

        //        }
        //    }
        //    else
        //    {
        //        cboListing.Items.Add("No comments found for this listing."); // Display message if no comments are found
        //    }
        //}


        //private void populateListingDropdown() { 
        //    cboListing.Items.Clear(); // Clear the existing items in the combo box
        //    foreach (var listing in CL) {
        //        cboListing.Items.Add($"{listing.Car.Make}{listing.Car.Model}");

        //    }
        //    if (cboListing.Items.Count > 0)
        //        cboListing.SelectedIndex = 0; 
        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //Close the comments form
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            //string comment = txtComment.Text.Trim(); // Get the comment from the text box
            //if (!string.IsNullOrEmpty(comment)) // Check if the comment is not empty
            //{
            //    CommentStorage.addComment(Listingid, comment); // Add the comment to storage
            //    cboListing.Items.Add(comment); // Add the comment to the list box
            //    txtComment.Clear(); // Clear the text box after adding the comment
            //}
            //else
            //{
            //    MessageBox.Show("Please enter a comment before submitting."); // Show message if comment is empty
            //}

        }
    }
}
