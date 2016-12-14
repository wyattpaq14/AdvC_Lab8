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
            //Registration printout

            MessageBox.Show("Customer Name: " + cbCustomer.SelectedValue + "\n" + "Product Code: " + cbProoduct.SelectedValue);
            


            //save registration
            RegistrationDB.AddRegistration();
        }
    }
}
