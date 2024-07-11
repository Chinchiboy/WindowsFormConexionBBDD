using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormConexionBBDD
{
    internal class DBConnection
    {
        private static SqlConnection _connection;

        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source = 200.234.224.123,54321;" +
                "Initial Catalog = IvanEmployees; " +
                "User ID = sa; " +
                "Password = Sql#123456789;";

            try
            {
                _connection = new SqlConnection(connectionString);
                _connection.Open();
                return _connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static void CloseConnection()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
            else
            {
                MessageBox.Show("No hay una conexión abierta para cerrar.");
            }
        }
    }
}
