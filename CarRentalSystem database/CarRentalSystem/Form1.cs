using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnManageCars_Click(object sender, EventArgs e)
        {
            CarForm carForm = new CarForm();
            carForm.Show();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }

        private void btnManageRentals_Click(object sender, EventArgs e)
        {
            RentalForm rentalForm = new RentalForm();
            rentalForm.Show();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
