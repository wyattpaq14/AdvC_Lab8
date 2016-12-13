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
    public static class ProductDB
    {

        public static List<String> GetProducts()
        {
            string connectionString = "Data Source=SQL.NEIT.EDU;Initial Catalog=SE255_MMABooks;Persist Security Info=True;User ID=SE256_Paquin;Password=123456";


            List<String> products = new List<String>();



            SqlConnection con2 = new SqlConnection(connectionString);

            string stmnt2 = "SELECT Description "
                + "FROM Products ";

            SqlCommand cmd2 = new SqlCommand(stmnt2, con2);

            try
            {
                con2.Open();

                SqlDataReader reader2 = cmd2.ExecuteReader();

                while (reader2.Read())
                {
                    products.Add(reader2.GetString(0));

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con2.Close();

            }
            return products;
        }

    }
}
