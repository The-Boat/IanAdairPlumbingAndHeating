namespace IanAdairPlumbingAndHeating
{
    partial class frmViewCustomers
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
            this.lblFilter = new System.Windows.Forms.Label();
            this.cbxFilters = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnNewInvoice = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.clbCustomers = new System.Windows.Forms.CheckedListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(432, 135);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(39, 17);
            this.lblFilter.TabIndex = 13;
            this.lblFilter.Text = "Filter";
            // 
            // cbxFilters
            // 
            this.cbxFilters.FormattingEnabled = true;
            this.cbxFilters.Location = new System.Drawing.Point(484, 132);
            this.cbxFilters.Name = "cbxFilters";
            this.cbxFilters.Size = new System.Drawing.Size(153, 24);
            this.cbxFilters.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(643, 83);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 38);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(12, 83);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(625, 38);
            this.tbxSearch.TabIndex = 10;
            // 
            // btnNewInvoice
            // 
            this.btnNewInvoice.Location = new System.Drawing.Point(643, 433);
            this.btnNewInvoice.Name = "btnNewInvoice";
            this.btnNewInvoice.Size = new System.Drawing.Size(145, 41);
            this.btnNewInvoice.TabIndex = 9;
            this.btnNewInvoice.Text = "New Customer";
            this.btnNewInvoice.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(492, 433);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(145, 41);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit Customer";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // clbCustomers
            // 
            this.clbCustomers.FormattingEnabled = true;
            this.clbCustomers.Location = new System.Drawing.Point(12, 170);
            this.clbCustomers.Name = "clbCustomers";
            this.clbCustomers.Size = new System.Drawing.Size(776, 242);
            this.clbCustomers.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(151, 32);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Customers";
            // 
            // frmViewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 503);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cbxFilters);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnNewInvoice);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.clbCustomers);
            this.Name = "frmViewCustomers";
            this.Text = "frmViewCustomers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cbxFilters;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnNewInvoice;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.CheckedListBox clbCustomers;
        private System.Windows.Forms.Label lblTitle;
    }
}