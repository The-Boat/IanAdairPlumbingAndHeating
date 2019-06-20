namespace IanAdairPlumbingAndHeating
{
    partial class frmMenu
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnEngineer = new System.Windows.Forms.Button();
            this.lbxRecents = new System.Windows.Forms.ListBox();
            this.lblRecent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(87, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(555, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ian Adair Plumbing and Heating";
            // 
            // btnInvoices
            // 
            this.btnInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoices.Location = new System.Drawing.Point(48, 125);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(288, 71);
            this.btnInvoices.TabIndex = 1;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(391, 125);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(288, 71);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Location = new System.Drawing.Point(48, 230);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(288, 71);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnEngineer
            // 
            this.btnEngineer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEngineer.Location = new System.Drawing.Point(391, 230);
            this.btnEngineer.Name = "btnEngineer";
            this.btnEngineer.Size = new System.Drawing.Size(288, 71);
            this.btnEngineer.TabIndex = 4;
            this.btnEngineer.Text = "Engineers";
            this.btnEngineer.UseVisualStyleBackColor = true;
            // 
            // lbxRecents
            // 
            this.lbxRecents.FormattingEnabled = true;
            this.lbxRecents.ItemHeight = 16;
            this.lbxRecents.Location = new System.Drawing.Point(48, 369);
            this.lbxRecents.Name = "lbxRecents";
            this.lbxRecents.Size = new System.Drawing.Size(631, 164);
            this.lbxRecents.TabIndex = 5;
            // 
            // lblRecent
            // 
            this.lblRecent.AutoSize = true;
            this.lblRecent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecent.Location = new System.Drawing.Point(45, 333);
            this.lblRecent.Name = "lblRecent";
            this.lblRecent.Size = new System.Drawing.Size(170, 20);
            this.lblRecent.TabIndex = 6;
            this.lblRecent.Text = "Most Recent Invoices";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.lblRecent);
            this.Controls.Add(this.lbxRecents);
            this.Controls.Add(this.btnEngineer);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnInvoices);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnEngineer;
        private System.Windows.Forms.ListBox lbxRecents;
        private System.Windows.Forms.Label lblRecent;
    }
}