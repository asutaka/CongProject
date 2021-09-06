using System;
using System.Data;
using System.Data.SqlClient;

namespace CongProject.DAL
{
    public static class Data
    {
        private static SqlConnection cnn;
        public static string connectionString = string.Empty;
        public static SqlConnection Connect()
        {
            try
            {
                if (cnn == null)
                    cnn = new SqlConnection(connectionString);
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                Console.WriteLine("Connection is Opened ! ");
                return cnn;
            }
            catch
            {
                Console.WriteLine("Connection is not Open ! ");
                throw;
            }
        }
    }
}
