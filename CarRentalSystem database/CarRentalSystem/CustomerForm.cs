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
    public partial class CustomerForm : Form
    {
        string connectionString = @"Data Source=ABEDULRHMAN\SQLEXPRESS;Initial Catalog=CarRentalDB;Integrated Security=True";
        public CustomerForm()
        {
            InitializeComponent();
        }
        private void LoadCustomers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Customers";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvCustomers.DataSource = table;
            }
        }
        private void btnLoadCustomer_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void btnAddCustomer_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Customers (Name, Phone, Email) VALUES (@Name, @Phone, @Email)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Customer added successfully!");
                LoadCustomers();
            }
        }

        private void btnUpdateCustomer_Click_1(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                int customerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["CustomerID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Customers SET Name=@Name, Phone=@Phone, Email=@Email WHERE CustomerID=@CustomerID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Customer updated successfully!");
                    LoadCustomers();
                }
            }
        }

        private void btnDeleteCustomer_Click_1(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                int customerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["CustomerID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        
                        string deleteRentalsQuery = "DELETE FROM Rentals WHERE CustomerID=@CustomerID";
                        SqlCommand deleteRentalsCmd = new SqlCommand(deleteRentalsQuery, conn);
                        deleteRentalsCmd.Parameters.AddWithValue("@CustomerID", customerId);
                        deleteRentalsCmd.ExecuteNonQuery();

                        string deleteCustomerQuery = "DELETE FROM Customers WHERE CustomerID=@CustomerID";
                        SqlCommand deleteCustomerCmd = new SqlCommand(deleteCustomerQuery, conn);
                        deleteCustomerCmd.Parameters.AddWithValue("@CustomerID", customerId);
                        int rowsAffected = deleteCustomerCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Customer not found or could not be deleted.");
                        }

                        LoadCustomers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting customer: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }


        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                txtName.Text = dgvCustomers.CurrentRow.Cells["Name"].Value.ToString();
                txtPhone.Text = dgvCustomers.CurrentRow.Cells["Phone"].Value.ToString();
                txtEmail.Text = dgvCustomers.CurrentRow.Cells["Email"].Value.ToString();
            }
        }
    }
}
