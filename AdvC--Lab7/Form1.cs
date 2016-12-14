using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdvC__Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Fill combo boxes based on datasources

            cbCustomer.DataSource = CustomerDB.GetCustomers();

            cbProoduct.DataSource = ProductDB.GetProducts();

            

        }

        private void btnRegisterProduct_Click(object sender, EventArgs e)
        {
            //Registration class
            Registration reg = new Registration();
            reg.CustomerName = cbCustomer.SelectedValue.ToString();
            reg.ProductCode = cbProoduct.SelectedValue.ToString();
            

            //try convert to check for valid date

            try
            {
                reg.RegistrationDate = Convert.ToDateTime(txtDate.Text);
            }
            catch
            {
                MessageBox.Show("Error, invalid date!", "Error");
            }

            //Registration printout
            MessageBox.Show("Customer Name: " + cbCustomer.SelectedValue + "\n" + "Product Code: " + cbProoduct.SelectedValue +
                "\n" + "Registration Date: " + txtDate.Text);

            

            //save registration
            RegistrationDB.AddRegistration();
        }
    }
}
