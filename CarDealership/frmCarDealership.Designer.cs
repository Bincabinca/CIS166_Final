namespace CarDealership
{
    partial class frmCarDealership
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.cboFilterBy = new System.Windows.Forms.ComboBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.rchListings = new System.Windows.Forms.RichTextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(336, 255);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 26);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(336, 147);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(71, 26);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(336, 117);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(71, 26);
            this.btnViewAll.TabIndex = 3;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // cboFilterBy
            // 
            this.cboFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterBy.FormattingEnabled = true;
            this.cboFilterBy.Location = new System.Drawing.Point(83, 13);
            this.cboFilterBy.Margin = new System.Windows.Forms.Padding(2);
            this.cboFilterBy.Name = "cboFilterBy";
            this.cboFilterBy.Size = new System.Drawing.Size(238, 21);
            this.cboFilterBy.TabIndex = 0;
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Location = new System.Drawing.Point(16, 18);
            this.lblFilterBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(47, 13);
            this.lblFilterBy.TabIndex = 5;
            this.lblFilterBy.Text = "Filter By:";
            // 
            // rchListings
            // 
            this.rchListings.Location = new System.Drawing.Point(19, 51);
            this.rchListings.Margin = new System.Windows.Forms.Padding(2);
            this.rchListings.Name = "rchListings";
            this.rchListings.Size = new System.Drawing.Size(302, 230);
            this.rchListings.TabIndex = 6;
            this.rchListings.Text = "";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(336, 11);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(71, 26);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(336, 178);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 26);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(336, 49);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(71, 26);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmCarDealership
            // 
            this.AcceptButton = this.btnFilter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(426, 300);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.rchListings);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.cboFilterBy);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCarDealership";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listings";
            this.Load += new System.EventHandler(this.frmCarDealership_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.ComboBox cboFilterBy;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.RichTextBox rchListings;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLogin;
    }
}

