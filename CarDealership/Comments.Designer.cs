namespace CarDealership
{
    partial class Comments
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
            this.cboListing = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnComment = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cboListing
            // 
            this.cboListing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboListing.FormattingEnabled = true;
            this.cboListing.Location = new System.Drawing.Point(52, 28);
            this.cboListing.Name = "cboListing";
            this.cboListing.Size = new System.Drawing.Size(350, 21);
            this.cboListing.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(68, 360);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnComment
            // 
            this.btnComment.Location = new System.Drawing.Point(294, 360);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(75, 23);
            this.btnComment.TabIndex = 2;
            this.btnComment.Text = "Comment";
            this.btnComment.UseVisualStyleBackColor = true;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(52, 104);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(350, 194);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Comments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cboListing);
            this.Name = "Comments";
            this.Text = "Comments";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboListing;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}