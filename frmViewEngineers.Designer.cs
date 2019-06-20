namespace IanAdairPlumbingAndHeating
{
    partial class frmViewEngineers
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
            this.lbxEngineers = new System.Windows.Forms.ListBox();
            this.btnNewEngineer = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxEngineers
            // 
            this.lbxEngineers.FormattingEnabled = true;
            this.lbxEngineers.ItemHeight = 16;
            this.lbxEngineers.Location = new System.Drawing.Point(12, 90);
            this.lbxEngineers.Name = "lbxEngineers";
            this.lbxEngineers.Size = new System.Drawing.Size(558, 84);
            this.lbxEngineers.TabIndex = 0;
            // 
            // btnNewEngineer
            // 
            this.btnNewEngineer.Location = new System.Drawing.Point(427, 186);
            this.btnNewEngineer.Name = "btnNewEngineer";
            this.btnNewEngineer.Size = new System.Drawing.Size(143, 46);
            this.btnNewEngineer.TabIndex = 1;
            this.btnNewEngineer.Text = "New Engineer";
            this.btnNewEngineer.UseVisualStyleBackColor = true;
            this.btnNewEngineer.Click += new System.EventHandler(this.BtnNewEngineer_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 32);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Engineers";
            // 
            // frmViewEngineers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 253);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnNewEngineer);
            this.Controls.Add(this.lbxEngineers);
            this.Name = "frmViewEngineers";
            this.Text = "frmViewEngineers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxEngineers;
        private System.Windows.Forms.Button btnNewEngineer;
        private System.Windows.Forms.Label lblTitle;
    }
}