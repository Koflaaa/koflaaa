using System;
using System.Data.SqlClient;

namespace Datenbank_Krempl
{
    class Program
    {
        static void Main()
        {
            private SqlConnection con = null;

        private string connectionStr = "Integrated Security=SSPI;" +
        "Initial Catalog=SQLQuery2.sql;" + "Data Source=SONY\\SqlConnection;";

        private void CreateConnection()
        {
            try
            {
                con = new SqlConnection(connectionStr);
                con.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in connection: " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            using (var command = new SqlCommand())
            {
                command.Connection = CreateConnection();
            }
        }
    }
}
