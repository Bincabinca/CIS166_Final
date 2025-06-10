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

namespace CarDealership {
    public partial class frmAddComment : Form {

        private string Listing;
        public Dictionary<string, List<string>> Dict; // Dictionary to hold comments
        public frmAddComment(string listing,Dictionary<string,List<string>> dict) {
            InitializeComponent();
            Listing = listing;
            Dict = dict; // Initialize the comments dictionary

        }

        private void btnSubmitComment_Click(object sender, EventArgs e) {
            if (!Dict.ContainsKey(Listing)) {
                Dict.Add(Listing, new List<string>());
            }
            Dict[Listing].Add(rchContent.Text);
            CommentsDB.SaveComments(Dict);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
