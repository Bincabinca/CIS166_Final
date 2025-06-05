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
    public partial class frmCarDealership : Form
    {

        private const int totalRecords = 20;
        private const int pageSize = 2;

        public frmCarDealership()
        {
            InitializeComponent();
            dgvListings.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Index" });
            bngPageSelect.BindingSource = bsrListings;
            bsrListings.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
            bsrListings.DataSource = new PageOffsetList();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            // The desired page has changed, so fetch the page of records using the "Current" offset 
            int offset = (int)bsrListings.Current;
            var records = new List<Record>();
            for (int i = offset; i < offset + pageSize && i < totalRecords; i++)
                records.Add(new Record { Index = i });
            dgvListings.DataSource = records;
        }

        class Record
        {
            public int Index { get; set; }
        }

        class PageOffsetList : System.ComponentModel.IListSource
        {
            public bool ContainsListCollection { get; protected set; }

            public System.Collections.IList GetList()
            {
                // Return a list of page offsets based on "totalRecords" and "pageSize"
                var pageOffsets = new List<int>();
                for (int offset = 0; offset < totalRecords; offset += pageSize)
                    pageOffsets.Add(offset);
                return pageOffsets;
            }
        }
        ///

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
        
        //Method to populate rich textbox with listings
        private void FillListings()
        {
            rchListings.Clear();

            string[] listings = CarListingsDB.Get();
            foreach (var listing in listings)
                rchListings.Text += listing.ToString();
        }

        private void FillFilteredListings(string filter)
        {
            rchListings.Clear();

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

            foreach (var listing in listings)
            {
                rchListings.Text += listing.GetFilteredString(filterName, filter);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            var addFrm = new frmAddListing("Bianca");
            addFrm.ShowDialog(); //Display new form to add listing
            FillListings();
            FillFilters();
        }
        
        //Show all unfiltered listings
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            FillListings();
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
            var deleteFrm = new frmDeleteListing(CarListingsDB.GetListings(),cboFilterBy);
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
    }
}
