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
    public static class RegistrationDB
    {
        public static bool AddRegistration()
        {

            string connectionString = "Data Source=SQL.NEIT.EDU;Initial Catalog=SE255_MMABooks;Persist Security Info=True;User ID=SE256_Paquin;Password=123456";

            SqlConnection con = new SqlConnection(connectionString);

            string stmnt = "INSERT INTO dbo.Registrations(ProductCode, RegistrationDate) VALUES(@ProductCode, @RegistrationDate)";

            SqlCommand cmd = new SqlCommand(stmnt, con);
            cmd.Parameters.Add("@ProductCode", SqlDbType.Char, 10);
            cmd.Parameters.Add("@RegistrationDate", SqlDbType.DateTime);


            cmd.Parameters["@ProductCode"].Value = "fjaoijsf";
            cmd.Parameters["@RegistrationDate"].Value = new DateTime(2015, 10, 10);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error, the developer of this program is stupid and couldn't figure this out; " + "\n" + ex, "Error");
            }
            finally
            {
                con.Close();

            }



            if (5>2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
