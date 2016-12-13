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
    public static class CustomerDB
    {

        public static List<String> GetCustomers()
        {
            string connectionString = "Data Source=SQL.NEIT.EDU;Initial Catalog=SE255_MMABooks;Persist Security Info=True;User ID=SE256_Paquin;Password=123456";

            List<String> customers = new List<String>();



            SqlConnection con = new SqlConnection(connectionString);

            string stmnt = "SELECT Name "
                + "FROM Customers ";

            SqlCommand cmd = new SqlCommand(stmnt, con);

            try
            {
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    customers.Add(reader.GetString(0));

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return customers;
        }
        


    }
}
