using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarDealership.DatabaseFiles;

namespace CarDealership {

    public partial class Comments : Form {
        Dictionary<string, List<string>> CommentsDict;
        List<CustomListing<Car>> CL; // List to hold custom listings of cars
        private string Listing; // Variable to hold the Listing ID for comments
        public Comments(string listing, List<CustomListing<Car>> cL, Dictionary<string, List<string>> commentsDB) {

            InitializeComponent();
            Listing = listing;
            CommentsDict = commentsDB; // Initialize the comments database
            CL = cL;
            List<string> listingItems = listing.Split('\n').ToList();
            string headerItem = "";
            for (int i = 0; i < 5; i++) {
                headerItem += listingItems[i] + ", ";
            }
            lblListingHeader.Text = $"Comments for Listing ID:\n{headerItem}";

            txtComment.Text = LoadComments();


        }
        private string LoadComments() {

           
            string commentsString = "";
            foreach (var comment in CommentsDict) {
                if (comment.Key == Listing) { 
                    foreach (var individualComment in comment.Value) {
                        commentsString += individualComment + "\n"; 
                    }
                }
            }
            return commentsString;

        }
        private void btnExit_Click(object sender, EventArgs e) {
            this.Close(); //Close the comments form
        }

        private void btnComment_Click(object sender, EventArgs e) {
            frmAddComment addCommentForm = new frmAddComment(Listing, CommentsDict); // Create a new instance of the Add Comment form
            addCommentForm.ShowDialog();
            ReloadComments();
        }

        private void ReloadComments() {
            txtComment.Text = LoadComments(); // Reload comments from the database

        }
    }
}
