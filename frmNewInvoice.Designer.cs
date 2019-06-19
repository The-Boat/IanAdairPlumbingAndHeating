namespace IanAdairPlumbingAndHeating
{
    partial class frmNewInvoice
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
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cbxCustomer = new System.Windows.Forms.ComboBox();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.dtpVisitDate = new System.Windows.Forms.DateTimePicker();
            this.tbxTimeOnSite = new System.Windows.Forms.TextBox();
            this.tbxTravelTime = new System.Windows.Forms.TextBox();
            this.nudMilage = new System.Windows.Forms.NumericUpDown();
            this.cbxDoubleTime = new System.Windows.Forms.CheckBox();
            this.cbxTimeAndAHalf = new System.Windows.Forms.CheckBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTimeOnSite = new System.Windows.Forms.Label();
            this.lblTravelTime = new System.Windows.Forms.Label();
            this.lblMilage = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.tbxMaterials = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblOverallTotal = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.clbVisits = new System.Windows.Forms.CheckedListBox();
            this.btnAddMaterials = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMilage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(12, 9);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(91, 24);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer";
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.FormattingEnabled = true;
            this.cbxCustomer.Location = new System.Drawing.Point(15, 35);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.Size = new System.Drawing.Size(350, 21);
            this.cbxCustomer.TabIndex = 1;
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Location = new System.Drawing.Point(380, 36);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(350, 20);
            this.dtpInvoiceDate.TabIndex = 2;
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.Location = new System.Drawing.Point(376, 9);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(113, 24);
            this.lblInvoiceDate.TabIndex = 3;
            this.lblInvoiceDate.Text = "Invoice Date";
            // 
            // dtpVisitDate
            // 
            this.dtpVisitDate.Location = new System.Drawing.Point(15, 98);
            this.dtpVisitDate.Name = "dtpVisitDate";
            this.dtpVisitDate.Size = new System.Drawing.Size(167, 20);
            this.dtpVisitDate.TabIndex = 4;
            // 
            // tbxTimeOnSite
            // 
            this.tbxTimeOnSite.Location = new System.Drawing.Point(198, 98);
            this.tbxTimeOnSite.Name = "tbxTimeOnSite";
            this.tbxTimeOnSite.Size = new System.Drawing.Size(167, 20);
            this.tbxTimeOnSite.TabIndex = 5;
            // 
            // tbxTravelTime
            // 
            this.tbxTravelTime.Location = new System.Drawing.Point(380, 98);
            this.tbxTravelTime.Name = "tbxTravelTime";
            this.tbxTravelTime.Size = new System.Drawing.Size(167, 20);
            this.tbxTravelTime.TabIndex = 6;
            // 
            // nudMilage
            // 
            this.nudMilage.Location = new System.Drawing.Point(563, 98);
            this.nudMilage.Name = "nudMilage";
            this.nudMilage.Size = new System.Drawing.Size(167, 20);
            this.nudMilage.TabIndex = 7;
            // 
            // cbxDoubleTime
            // 
            this.cbxDoubleTime.AutoSize = true;
            this.cbxDoubleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDoubleTime.Location = new System.Drawing.Point(450, 147);
            this.cbxDoubleTime.Name = "cbxDoubleTime";
            this.cbxDoubleTime.Size = new System.Drawing.Size(97, 19);
            this.cbxDoubleTime.TabIndex = 8;
            this.cbxDoubleTime.Text = "Double Time";
            this.cbxDoubleTime.UseVisualStyleBackColor = true;
            // 
            // cbxTimeAndAHalf
            // 
            this.cbxTimeAndAHalf.AutoSize = true;
            this.cbxTimeAndAHalf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTimeAndAHalf.Location = new System.Drawing.Point(331, 147);
            this.cbxTimeAndAHalf.Name = "cbxTimeAndAHalf";
            this.cbxTimeAndAHalf.Size = new System.Drawing.Size(113, 19);
            this.cbxTimeAndAHalf.TabIndex = 9;
            this.cbxTimeAndAHalf.Text = "Time and a Half";
            this.cbxTimeAndAHalf.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(13, 79);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 16);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date";
            // 
            // lblTimeOnSite
            // 
            this.lblTimeOnSite.AutoSize = true;
            this.lblTimeOnSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeOnSite.Location = new System.Drawing.Point(195, 79);
            this.lblTimeOnSite.Name = "lblTimeOnSite";
            this.lblTimeOnSite.Size = new System.Drawing.Size(85, 16);
            this.lblTimeOnSite.TabIndex = 11;
            this.lblTimeOnSite.Text = "Time On Site";
            // 
            // lblTravelTime
            // 
            this.lblTravelTime.AutoSize = true;
            this.lblTravelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTravelTime.Location = new System.Drawing.Point(377, 79);
            this.lblTravelTime.Name = "lblTravelTime";
            this.lblTravelTime.Size = new System.Drawing.Size(81, 16);
            this.lblTravelTime.TabIndex = 12;
            this.lblTravelTime.Text = "Travel Time";
            // 
            // lblMilage
            // 
            this.lblMilage.AutoSize = true;
            this.lblMilage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilage.Location = new System.Drawing.Point(560, 79);
            this.lblMilage.Name = "lblMilage";
            this.lblMilage.Size = new System.Drawing.Size(49, 16);
            this.lblMilage.TabIndex = 13;
            this.lblMilage.Text = "Milage";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(563, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 36);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add Visit";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(19, 383);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(84, 24);
            this.lblMaterial.TabIndex = 16;
            this.lblMaterial.Text = "Materials";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(109, 381);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(20, 24);
            this.lblCurrency.TabIndex = 17;
            this.lblCurrency.Text = "£";
            // 
            // tbxMaterials
            // 
            this.tbxMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaterials.Location = new System.Drawing.Point(135, 378);
            this.tbxMaterials.Name = "tbxMaterials";
            this.tbxMaterials.Size = new System.Drawing.Size(239, 29);
            this.tbxMaterials.TabIndex = 18;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(11, 437);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(66, 24);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "Total : ";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(144, 437);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(63, 24);
            this.lblVat.TabIndex = 20;
            this.lblVat.Text = "VAT : ";
            // 
            // lblOverallTotal
            // 
            this.lblOverallTotal.AutoSize = true;
            this.lblOverallTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallTotal.Location = new System.Drawing.Point(275, 437);
            this.lblOverallTotal.Name = "lblOverallTotal";
            this.lblOverallTotal.Size = new System.Drawing.Size(130, 24);
            this.lblOverallTotal.TabIndex = 21;
            this.lblOverallTotal.Text = "Overall Total : ";
            // 
            // btnComplete
            // 
            this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(12, 480);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(724, 56);
            this.btnComplete.TabIndex = 23;
            this.btnComplete.Text = "Complete Invoice";
            this.btnComplete.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(563, 377);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(167, 30);
            this.btnRemoveSelected.TabIndex = 24;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            // 
            // clbVisits
            // 
            this.clbVisits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clbVisits.FormattingEnabled = true;
            this.clbVisits.Location = new System.Drawing.Point(16, 200);
            this.clbVisits.Name = "clbVisits";
            this.clbVisits.Size = new System.Drawing.Size(714, 151);
            this.clbVisits.TabIndex = 25;
            // 
            // btnAddMaterials
            // 
            this.btnAddMaterials.Location = new System.Drawing.Point(380, 377);
            this.btnAddMaterials.Name = "btnAddMaterials";
            this.btnAddMaterials.Size = new System.Drawing.Size(167, 30);
            this.btnAddMaterials.TabIndex = 26;
            this.btnAddMaterials.Text = "Add";
            this.btnAddMaterials.UseVisualStyleBackColor = true;
            // 
            // frmNewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 548);
            this.Controls.Add(this.btnAddMaterials);
            this.Controls.Add(this.clbVisits);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.lblOverallTotal);
            this.Controls.Add(this.lblVat);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tbxMaterials);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblMilage);
            this.Controls.Add(this.lblTravelTime);
            this.Controls.Add(this.lblTimeOnSite);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cbxTimeAndAHalf);
            this.Controls.Add(this.cbxDoubleTime);
            this.Controls.Add(this.nudMilage);
            this.Controls.Add(this.tbxTravelTime);
            this.Controls.Add(this.tbxTimeOnSite);
            this.Controls.Add(this.dtpVisitDate);
            this.Controls.Add(this.lblInvoiceDate);
            this.Controls.Add(this.dtpInvoiceDate);
            this.Controls.Add(this.cbxCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Name = "frmNewInvoice";
            this.Text = "frmNewInvoice";
            ((System.ComponentModel.ISupportInitialize)(this.nudMilage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cbxCustomer;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.DateTimePicker dtpVisitDate;
        private System.Windows.Forms.TextBox tbxTimeOnSite;
        private System.Windows.Forms.TextBox tbxTravelTime;
        private System.Windows.Forms.NumericUpDown nudMilage;
        private System.Windows.Forms.CheckBox cbxDoubleTime;
        private System.Windows.Forms.CheckBox cbxTimeAndAHalf;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTimeOnSite;
        private System.Windows.Forms.Label lblTravelTime;
        private System.Windows.Forms.Label lblMilage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.TextBox tbxMaterials;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblOverallTotal;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.CheckedListBox clbVisits;
        private System.Windows.Forms.Button btnAddMaterials;
    }
}