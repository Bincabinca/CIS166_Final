﻿using CarDealership.DatabaseFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarDealership
{
    public partial class frmCarDealership : Form
    {
        // Dictionary to hold comments for each listing
        public Dictionary<string,List<string>> ListingComments = new Dictionary<string, List<string>>();

        // set page max and size for pagination
        private const int pageSize = 8;
        private bool LoggedIn = false;

        // Add an authorizer and userdb in here
        public Authorizer authorizer = new Authorizer();
        public List<string> users = UserDB.GetUsers();
        public int idx = -1; // index of the selected listing in the database

        public frmCarDealership()
        {
            InitializeComponent();
            btnMoreInfo.Enabled = false;
            bngPageSelect.BindingSource = bsrListings;
            bsrListings.CurrentChanged += new EventHandler(bindingSource1_CurrentChanged);
            bsrListings.DataSource = new PageOffsetList();
            ListingComments = CommentsDB.LoadComments();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            FillListings();
        }

        

        class PageOffsetList : IListSource
        {
            public bool ContainsListCollection { get; protected set; }

            public System.Collections.IList GetList()
            {
                // Return a list of page offsets based on total Records and "pageSize"
                var pageOffsets = new List<int>();
                for (int offset = 0; offset < CarListingsDB.GetListings().Count; offset += pageSize)
                    pageOffsets.Add(offset);
                return pageOffsets;
            }
        }

        //Populate cboTextBox filter menu and rich textbox upon loading form 
        private void frmCarDealership_Load(object sender, EventArgs e)
        {
            FillListings();
            FillFilters();
        }

        //Method to populate cboTextBox filter menu
        private void FillFilters()
        {
            cboFilterBy.Items.Clear();
            cboFilterBy.Items.AddRange(Filters.Get());
            cboFilterBy.SelectedIndex = 0;
        }

        //Method to populate DataGridView with listings
        private void FillListings()
        {
            dgvListings.Columns.Clear();

            // change page, fetch the page of records using the "Current" offset 
            int offset = (int)bsrListings.Current;
            var listings = CarListingsDB.GetListings().Select(l => new
            {
                Make = l.Car.Make,
                Model = l.Car.Model,
                Color = l.Car.Color,
                Age = l.Car.Age,
                Price = l.Car.Price,
                User = l.Car.User,
                CreationTime = l.CreationTime,
                //for unique perk
                Perk = (l.Car is IUniqueMember<string> unique) ? unique.Perk : null
            }).ToList();

            var pageListings = listings.Skip(offset).Take(pageSize).ToList();

            dgvListings.AutoGenerateColumns = true; // Let the grid auto-create columns
            dgvListings.DataSource = pageListings; // binds the current page to the grid view

            // Adjust column widths to fit contents with the dgvAdjust method
            dgvAdjust();
        }

        private void FillFilteredListings(string filter)
        {
            dgvListings.Columns.Clear();
            //rchListings.Clear();

            var listings = CarListingsDB.GetListings();

            FilterName filterName = FilterName.Null;
            if (CarMakesDB.Get().Contains(filter))
                filterName = FilterName.Make;
            else if (CarColorsDB.Get().Contains(filter))
                filterName = FilterName.Color;
            else if (CarAgeRangesDB.GetRanges().Contains(filter))
                filterName = FilterName.Age;
            else if (CarPriceRangesDB.GetRanges().Contains(filter))
                filterName = FilterName.Price;

            // Check if the filter is for Color, since it has a different handling
            if (filterName == FilterName.Color)
            {

                // Filter listings based on the selected filter
                var filteredListings = listings
                      // Use LINQ to filter listings based on the selected filter
                      .Where(l => l.GetFilteredString(filterName, filter) != null)

                      .Select(l => new
                      {
                          // Select the properties you want to display in the DataGridView
                          Make = l.Car.Make,
                          Model = l.Car.Model,
                          Age = l.Car.Age,
                          Price = l.Car.Price,
                          User = l.Car.User,
                          CreationTime = l.CreationTime,
                          //for unique perk
                          Perk = (l.Car is IUniqueMember<string> unique) ? unique.Perk : null
                      }).ToList();

                dgvListings.AutoGenerateColumns = true; // Let the grid auto-create columns
                dgvListings.DataSource = filteredListings; // binds the current page to the grid view
                dgvAdjust();

            }
            else

            { // Filter listings based on the selected filter
                var filteredListings = listings
                      // Use LINQ to filter listings based on the selected filter
                      .Where(l => l.GetFilteredString(filterName, filter) != null)

                      .Select(l => new
                      {
                          // Select the properties you want to display in the DataGridView
                          Make = l.Car.Make,
                          Model = l.Car.Model,
                          Color = l.Car.Color,
                          Age = l.Car.Age,
                          Price = l.Car.Price,
                          User = l.Car.User,
                          CreationTime = l.CreationTime,
                          //for unique perk
                          Perk = (l.Car is IUniqueMember<string> unique) ? unique.Perk : null
                      }).ToList();

                dgvListings.AutoGenerateColumns = true; // Let the grid auto-create columns
                dgvListings.DataSource = filteredListings; // binds the current page to the grid view
                dgvAdjust();

            }




            //foreach (var listing in listings)
            //{
            //    rchListings.Text += listing.GetFilteredString(filterName, filter);
            //    // Filter datagridview listing


            //}
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            var addFrm = new frmAddListing();
            addFrm.ShowDialog(); //Display new form to add listing

            FillListings();
            // Return to first page of dgvListings
            bsrListings.Position = 0;
            FillFilters();
        }

        //Show all unfiltered listings
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            FillListings();
            // Return to first page of dgvListings
            bsrListings.Position = 0;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //Check a filter is selected before filtering
            if (cboFilterBy.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a filter.", "Make a Selection");
            }
            else
            {
                string filter = cboFilterBy.SelectedItem.ToString();
                FillFilteredListings(filter.Trim());
            }

        }

        //Close the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var deleteFrm = new frmDeleteListing(CarListingsDB.GetListings(), cboFilterBy);
            deleteFrm.ShowDialog();

            FillListings();
            cboFilterBy.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Open UserLogin form
            UserLogin userLoginForm = new UserLogin();
            userLoginForm.ShowDialog();
        }

        private void dgvAdjust()
        {
            // Adjust column widths to fit contents
            dgvListings.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvListings.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvListings.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvListings.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvListings.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvListings.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvListings.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {

            var listings = CarListingsDB.GetListings();
            Comments commentsfrm = new Comments(listings[idx].ToString(),listings,ListingComments);
            commentsfrm.ShowDialog();

        }

        private void dgvListings_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            
            // get selected row in reference to the listings db
            idx = (pageSize * bsrListings.Position ) + e.RowIndex;
            btnMoreInfo.Enabled = true; // Enable the More Info button when a row is selected

        }

        private void dgvListings_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {

            // convert to double click args and pass to the CellContentClick event handler
            DataGridViewCellEventArgs passArgs = new DataGridViewCellEventArgs(e.ColumnIndex, e.RowIndex);
            dgvListings_CellContentClick(sender, passArgs);
        }
    }
}
