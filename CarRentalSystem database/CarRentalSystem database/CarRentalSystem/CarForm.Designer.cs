namespace CarRentalSystem
{
    partial class CarForm
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
            this.grpCarDetails = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtPricePerDay = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnUpdateCar = new System.Windows.Forms.Button();
            this.btnLoadCars = new System.Windows.Forms.Button();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.grpCarDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCarDetails
            // 
            this.grpCarDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpCarDetails.Controls.Add(this.label5);
            this.grpCarDetails.Controls.Add(this.label4);
            this.grpCarDetails.Controls.Add(this.label3);
            this.grpCarDetails.Controls.Add(this.label2);
            this.grpCarDetails.Controls.Add(this.label1);
            this.grpCarDetails.Controls.Add(this.txtStatus);
            this.grpCarDetails.Controls.Add(this.txtPricePerDay);
            this.grpCarDetails.Controls.Add(this.txtYear);
            this.grpCarDetails.Controls.Add(this.txtMake);
            this.grpCarDetails.Controls.Add(this.txtModel);
            this.grpCarDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCarDetails.ForeColor = System.Drawing.SystemColors.Control;
            this.grpCarDetails.Location = new System.Drawing.Point(40, 28);
            this.grpCarDetails.Name = "grpCarDetails";
            this.grpCarDetails.Size = new System.Drawing.Size(288, 290);
            this.grpCarDetails.TabIndex = 0;
            this.grpCarDetails.TabStop = false;
            this.grpCarDetails.Text = "Car Details";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(52, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Model:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(52, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(0, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price Per Day";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(52, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Year:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(52, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Make:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(143, 219);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(111, 22);
            this.txtStatus.TabIndex = 5;
            // 
            // txtPricePerDay
            // 
            this.txtPricePerDay.Location = new System.Drawing.Point(143, 173);
            this.txtPricePerDay.Name = "txtPricePerDay";
            this.txtPricePerDay.Size = new System.Drawing.Size(111, 22);
            this.txtPricePerDay.TabIndex = 2;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(143, 129);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(111, 22);
            this.txtYear.TabIndex = 3;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(143, 38);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(111, 22);
            this.txtMake.TabIndex = 4;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(143, 85);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(111, 22);
            this.txtModel.TabIndex = 1;
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddCar.Location = new System.Drawing.Point(66, 365);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(102, 39);
            this.btnAddCar.TabIndex = 2;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteCar.Location = new System.Drawing.Point(407, 365);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(113, 39);
            this.btnDeleteCar.TabIndex = 3;
            this.btnDeleteCar.Text = "Delete Car";
            this.btnDeleteCar.UseVisualStyleBackColor = false;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateCar.Location = new System.Drawing.Point(226, 365);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(112, 39);
            this.btnUpdateCar.TabIndex = 4;
            this.btnUpdateCar.Text = "Update Car";
            this.btnUpdateCar.UseVisualStyleBackColor = false;
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_Click);
            // 
            // btnLoadCars
            // 
            this.btnLoadCars.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLoadCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadCars.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLoadCars.Location = new System.Drawing.Point(597, 365);
            this.btnLoadCars.Name = "btnLoadCars";
            this.btnLoadCars.Size = new System.Drawing.Size(102, 39);
            this.btnLoadCars.TabIndex = 5;
            this.btnLoadCars.Text = "Load Cars";
            this.btnLoadCars.UseVisualStyleBackColor = false;
            this.btnLoadCars.Click += new System.EventHandler(this.btnLoadCars_Click);
            // 
            // dgvCars
            // 
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Location = new System.Drawing.Point(485, 28);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.Size = new System.Drawing.Size(292, 242);
            this.dgvCars.TabIndex = 6;
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRentalSystem.Properties.Resources.bookingback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCars);
            this.Controls.Add(this.btnLoadCars);
            this.Controls.Add(this.btnUpdateCar);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.grpCarDetails);
            this.Name = "CarForm";
            this.Text = "CarForm";
            this.grpCarDetails.ResumeLayout(false);
            this.grpCarDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCarDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtPricePerDay;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnUpdateCar;
        private System.Windows.Forms.Button btnLoadCars;
        private System.Windows.Forms.DataGridView dgvCars;
    }
}