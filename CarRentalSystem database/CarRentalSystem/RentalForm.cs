using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class RentalForm : Form
    {
        string connectionString = @"Data Source=ABEDULRHMAN\SQLEXPRESS;Initial Catalog=CarRentalDB;Integrated Security=True";
        public RentalForm()
        {
            InitializeComponent();
            LoadComboBoxes();
        }
        private void LoadComboBoxes()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmdCars = new SqlCommand("SELECT CarID FROM Cars WHERE Status = 'Available'", conn);
                SqlDataReader readerCars = cmdCars.ExecuteReader();
                cmbCarID.Items.Clear();
                while (readerCars.Read())
                {
                    cmbCarID.Items.Add(readerCars["CarID"].ToString());
                }
                readerCars.Close();

                SqlCommand cmdCustomers = new SqlCommand("SELECT CustomerID FROM Customers", conn);
                SqlDataReader readerCustomers = cmdCustomers.ExecuteReader();
                cmbCustomerID.Items.Clear();
                while (readerCustomers.Read())
                {
                    cmbCustomerID.Items.Add(readerCustomers["CustomerID"].ToString());
                }
                readerCustomers.Close();

                conn.Close();
            }
        }

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbCarID.Text) || string.IsNullOrEmpty(cmbCustomerID.Text))
            {
                MessageBox.Show("Please select both Car ID and Customer ID.");
                return;
            }

            if (!int.TryParse(cmbCarID.Text, out int carId) || !int.TryParse(cmbCustomerID.Text, out int customerId))
            {
                MessageBox.Show("Invalid Car ID or Customer ID format.");
                return;
            }

            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            int rentalDays = (endDate - startDate).Days;
            if (rentalDays <= 0)
            {
                MessageBox.Show("End date must be after start date.");
                return;
            }

            decimal pricePerDay = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string getPriceQuery = "SELECT PricePerDay FROM Cars WHERE CarID = @CarID";
                SqlCommand priceCmd = new SqlCommand(getPriceQuery, conn);
                priceCmd.Parameters.AddWithValue("@CarID", carId);
                object result = priceCmd.ExecuteScalar();

                if (result != null)
                {
                    pricePerDay = Convert.ToDecimal(result);
                }
                else
                {
                    MessageBox.Show("Invalid Car ID.");
                    return;
                }
                conn.Close();
            }

            decimal totalPrice = pricePerDay * rentalDays;
            txtTotalPrice.Text = totalPrice.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string insertQuery = "INSERT INTO Rentals (CarID, CustomerID, StartDate, EndDate, TotalPrice) VALUES (@CarID, @CustomerID, @StartDate, @EndDate, @TotalPrice)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@CarID", carId);
                insertCmd.Parameters.AddWithValue("@CustomerID", customerId);
                insertCmd.Parameters.AddWithValue("@StartDate", startDate);
                insertCmd.Parameters.AddWithValue("@EndDate", endDate);
                insertCmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                insertCmd.ExecuteNonQuery();

                string updateQuery = "UPDATE Cars SET Status='Rented' WHERE CarID=@CarID";
                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@CarID", carId);
                updateCmd.ExecuteNonQuery();

                conn.Close();
            }

            MessageBox.Show("Rental added successfully!");
            LoadRentals();
            LoadComboBoxes(); 
        }

        private void LoadRentals()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Rentals";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvRentals.DataSource = table;
            }
        }

        private void btnLoadRentals_Click(object sender, EventArgs e)
        {
            LoadRentals();
        }
    }
}