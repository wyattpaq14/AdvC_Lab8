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
            //Declare list to put customers in
            List<String> customerID = new List<String>();

            string connectionString = "Data Source=SQL.NEIT.EDU;Initial Catalog=SE255_MMABooks;Persist Security Info=True;User ID=SE256_Paquin;Password=123456";

            SqlConnection con = new SqlConnection(connectionString);

            string stmnt = "SELECT CustomerID "
                + "FROM Customers ";

            SqlCommand cmd = new SqlCommand(stmnt, con);

            try
            {
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    customerID.Add(reader.GetString(0));
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                cbCustomer.DataSource = customerID;
            }


        }
    }
}
