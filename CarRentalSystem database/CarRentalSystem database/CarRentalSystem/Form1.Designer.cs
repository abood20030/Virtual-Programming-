namespace CarRentalSystem
{
    partial class MainForm
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
            this.btnManageCars = new System.Windows.Forms.Button();
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.btnManageRentals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageCars
            // 
            this.btnManageCars.BackColor = System.Drawing.Color.SteelBlue;
            this.btnManageCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCars.ForeColor = System.Drawing.SystemColors.Control;
            this.btnManageCars.Location = new System.Drawing.Point(121, 347);
            this.btnManageCars.Name = "btnManageCars";
            this.btnManageCars.Size = new System.Drawing.Size(130, 39);
            this.btnManageCars.TabIndex = 0;
            this.btnManageCars.Text = "Manage Cars";
            this.btnManageCars.UseVisualStyleBackColor = false;
            this.btnManageCars.Click += new System.EventHandler(this.btnManageCars_Click);
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.BackColor = System.Drawing.Color.SteelBlue;
            this.btnManageCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCustomers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnManageCustomers.Location = new System.Drawing.Point(280, 347);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(198, 39);
            this.btnManageCustomers.TabIndex = 1;
            this.btnManageCustomers.Text = "Manage Customers";
            this.btnManageCustomers.UseVisualStyleBackColor = false;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            // btnManageRentals
            // 
            this.btnManageRentals.BackColor = System.Drawing.Color.SteelBlue;
            this.btnManageRentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRentals.ForeColor = System.Drawing.SystemColors.Control;
            this.btnManageRentals.Location = new System.Drawing.Point(501, 347);
            this.btnManageRentals.Name = "btnManageRentals";
            this.btnManageRentals.Size = new System.Drawing.Size(168, 39);
            this.btnManageRentals.TabIndex = 2;
            this.btnManageRentals.Text = "Manage Rentals";
            this.btnManageRentals.UseVisualStyleBackColor = false;
            this.btnManageRentals.Click += new System.EventHandler(this.btnManageRentals_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRentalSystem.Properties.Resources.mainmenuback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnManageRentals);
            this.Controls.Add(this.btnManageCustomers);
            this.Controls.Add(this.btnManageCars);
            this.Name = "MainForm";
            this.Text = "Mainform";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageCars;
        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.Button btnManageRentals;
    }
}

