namespace CarDealership
{
    partial class frmAddListing
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cboMake = new System.Windows.Forms.ComboBox();
            this.lblExtra = new System.Windows.Forms.Label();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(45, 246);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(104, 26);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(153, 246);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 26);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(39, 25);
            this.lblMake.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(34, 13);
            this.lblMake.TabIndex = 4;
            this.lblMake.Text = "Make";
            this.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(38, 58);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Model";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(40, 91);
            this.lblColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 6;
            this.lblColor.Text = "Color";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(43, 124);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Age";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(40, 157);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(80, 56);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(187, 20);
            this.txtModel.TabIndex = 1;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(80, 89);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(187, 20);
            this.txtColor.TabIndex = 2;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(80, 122);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(187, 20);
            this.txtAge.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(80, 155);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(187, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // cboMake
            // 
            this.cboMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMake.FormattingEnabled = true;
            this.cboMake.Location = new System.Drawing.Point(80, 22);
            this.cboMake.Margin = new System.Windows.Forms.Padding(2);
            this.cboMake.Name = "cboMake";
            this.cboMake.Size = new System.Drawing.Size(187, 21);
            this.cboMake.TabIndex = 0;
            this.cboMake.SelectedIndexChanged += new System.EventHandler(this.cboMake_SelectedIndexChanged);
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Enabled = false;
            this.lblExtra.Location = new System.Drawing.Point(40, 187);
            this.lblExtra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(31, 13);
            this.lblExtra.TabIndex = 16;
            this.lblExtra.Text = "Extra";
            this.lblExtra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblExtra.Visible = false;
            // 
            // txtExtra
            // 
            this.txtExtra.Enabled = false;
            this.txtExtra.Location = new System.Drawing.Point(80, 209);
            this.txtExtra.Margin = new System.Windows.Forms.Padding(2);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(187, 20);
            this.txtExtra.TabIndex = 5;
            this.txtExtra.Visible = false;
            // 
            // frmAddListing
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(293, 289);
            this.Controls.Add(this.txtExtra);
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.cboMake);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddListing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Listing";
            this.Load += new System.EventHandler(this.frmAddListing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cboMake;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.TextBox txtExtra;
    }
}