using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace MinecraftManagerWinForms.Utils
{
    public class DatabaseManager
    {
        // Updated connection string to use MELANY\SQLEXPRESS and DB_PARCIAL2 database
        private static string connectionString = @"Data Source=MELANY\SQLEXPRESS;Initial Catalog=DB_PARCIAL2;Integrated Security=True;TrustServerCertificate=True";

        public static string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        // Method to test the connection
        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    return connection.State == ConnectionState.Open;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error en la base de datos: {ex.Message}", ex);
                }
            }
        }

        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error en la consulta: {ex.Message}", ex);
                }
            }
            
            return dataTable;
        }

        public static T ExecuteScalar<T>(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    
                    object result = command.ExecuteScalar();
                    if (result == null || result == DBNull.Value)
                    {
                        return default(T);
                    }
                    
                    return (T)Convert.ChangeType(result, typeof(T));
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error en la consulta escalar: {ex.Message}", ex);
                }
            }
        }
    }
}