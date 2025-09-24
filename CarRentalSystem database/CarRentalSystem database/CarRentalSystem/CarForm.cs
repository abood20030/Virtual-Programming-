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
    public partial class CarForm : Form
    {
        string connectionString = @"Data Source=ABEDULRHMAN\SQLEXPRESS;Initial Catalog=CarRentalDB;Integrated Security=True";
        public CarForm()
        {
            InitializeComponent();
        }
        private void LoadCars()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Cars";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvCars.DataSource = table;
            }
        }
        private void btnLoadCars_Click(object sender, EventArgs e)
        {
            LoadCars();
        }
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Cars (Make, Model, Year, PricePerDay, Status) VALUES (@Make, @Model, @Year, @PricePerDay, @Status)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Make", txtMake.Text);
                cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                cmd.Parameters.AddWithValue("@Year", int.Parse(txtYear.Text));
                cmd.Parameters.AddWithValue("@PricePerDay", decimal.Parse(txtPricePerDay.Text));
                cmd.Parameters.AddWithValue("@Status", txtStatus.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Car added successfully!");
                LoadCars();
            }
        }

        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            if (dgvCars.CurrentRow != null)
            {
                int carId = Convert.ToInt32(dgvCars.CurrentRow.Cells["CarID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Cars SET Make=@Make, Model=@Model, Year=@Year, PricePerDay=@PricePerDay, Status=@Status WHERE CarID=@CarID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Make", txtMake.Text);
                    cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                    cmd.Parameters.AddWithValue("@Year", int.Parse(txtYear.Text));
                    cmd.Parameters.AddWithValue("@PricePerDay", decimal.Parse(txtPricePerDay.Text));
                    cmd.Parameters.AddWithValue("@Status", txtStatus.Text);
                    cmd.Parameters.AddWithValue("@CarID", carId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Car updated successfully!");
                    LoadCars();
                }
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (dgvCars.CurrentRow != null)
            {
                int carId = Convert.ToInt32(dgvCars.CurrentRow.Cells["CarID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string deleteRentalsQuery = "DELETE FROM Rentals WHERE CarID=@CarID";
                        SqlCommand deleteRentalsCmd = new SqlCommand(deleteRentalsQuery, conn);
                        deleteRentalsCmd.Parameters.AddWithValue("@CarID", carId);
                        deleteRentalsCmd.ExecuteNonQuery();

                        string deleteCarQuery = "DELETE FROM Cars WHERE CarID=@CarID";
                        SqlCommand deleteCarCmd = new SqlCommand(deleteCarQuery, conn);
                        deleteCarCmd.Parameters.AddWithValue("@CarID", carId);
                        int rowsAffected = deleteCarCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Car deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Car not found or could not be deleted.");
                        }

                        LoadCars();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting car: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a car to delete.");
            }
        }


        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCars.CurrentRow != null)
            {
                txtMake.Text = dgvCars.CurrentRow.Cells["Make"].Value.ToString();
                txtModel.Text = dgvCars.CurrentRow.Cells["Model"].Value.ToString();
                txtYear.Text = dgvCars.CurrentRow.Cells["Year"].Value.ToString();
                txtPricePerDay.Text = dgvCars.CurrentRow.Cells["PricePerDay"].Value.ToString();
                txtStatus.Text = dgvCars.CurrentRow.Cells["Status"].Value.ToString();
            }
        }
    }
}
