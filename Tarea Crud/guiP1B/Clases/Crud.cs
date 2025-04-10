using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace guiP1B.Clases
{
    public class Crud
    {
        public string AgregarTarea(string carnet, string descripcion, DateTime fechaEntrega)
        {
            string query = "INSERT INTO Tarea (carnet, descripcion, fecha_entrega) VALUES (@carnet, @descripcion, @fechaEntrega)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@fechaEntrega", fechaEntrega);

                    connection.Open();
                    command.ExecuteNonQuery();
                    return "Tarea agregada exitosamente";
                }
            }
            catch (SqlException ex)
            {
                return $"Error de SQL: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        // Método para buscar tareas por número de carnet
        public List<string> BuscarTareasPorCarnet(string carnet)
        {
            string query = "SELECT descripcion, fecha_entrega FROM Tarea WHERE carnet = @carnet";
            List<string> tareas = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@carnet", carnet);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string descripcion = reader["descripcion"].ToString();
                            string fechaEntrega = Convert.ToDateTime(reader["fecha_entrega"]).ToString("dd/MM/yyyy");
                            tareas.Add($"Descripción: {descripcion}, Fecha de Entrega: {fechaEntrega}");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                tareas.Add($"Error de SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                tareas.Add($"Error: {ex.Message}");
            }

            return tareas;
        }
        private readonly string connectionString = "Server=MELANY\\SQLEXPRESS;Database=UMG_DB;Integrated Security=True; TrustServerCertificate=True;";

        public string MostrarInformacion(string carnet)
        {
            string nombre = "No Existe";
            string query = "SELECT estudiante FROM Tb_alumnos WHERE carnet = @carnet";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@carnet", carnet);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nombre = reader["estudiante"].ToString();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Manejo de errores específicos de SQL
                nombre = $"Error de SQL: {ex.Message}";
            }
            catch (Exception ex)
            {
                // Manejo de errores generales
                nombre = $"Error: {ex.Message}";
            }

            return nombre;
        }

        public string AgregarAlumno(string carnet, string nombre, string email, string seccion)
        {
            string query = "INSERT INTO Tb_alumnos (carnet, estudiante, email, seccion) VALUES (@carnet, @nombre, @email, @seccion)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@seccion", seccion);

                    connection.Open();
                    command.ExecuteNonQuery();
                    return "Registros insertados exitosamente";
                }
            }
            catch (SqlException ex)
            {
                // Manejo de errores específicos de SQL
                return $"Error de SQL: {ex.Message}";
            }
            catch (Exception ex)
            {
                // Manejo de errores generales
                return $"Error: {ex.Message}";
            }
        }
    }
}
