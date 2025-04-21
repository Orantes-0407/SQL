using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using MinecraftManagerWinForms.Models;
using MinecraftManagerWinForms.Utils;

namespace MinecraftManagerWinForms.Services
{
    public class InventarioService
    {
        public List<Inventario> GetAllInventarios()
        {
            List<Inventario> inventarios = new List<Inventario>();
            
            string query = @"
                SELECT i.*, j.Nombre AS JugadorNombre, b.Nombre AS BloqueNombre
                FROM Inventario i
                INNER JOIN Jugadores j ON i.JugadorId = j.Id
                INNER JOIN Bloques b ON i.BloqueId = b.Id
                ORDER BY j.Nombre, b.Nombre";
                
            DataTable dataTable = DatabaseManager.ExecuteQuery(query);
            
            foreach (DataRow row in dataTable.Rows)
            {
                Inventario inventario = new Inventario
                {
                    Id = Convert.ToInt32(row["Id"]),
                    JugadorId = Convert.ToInt32(row["JugadorId"]),
                    BloqueId = Convert.ToInt32(row["BloqueId"]),
                    Cantidad = Convert.ToInt32(row["Cantidad"]),
                    JugadorNombre = row["JugadorNombre"].ToString(),
                    BloqueNombre = row["BloqueNombre"].ToString()
                };
                
                inventarios.Add(inventario);
            }
            
            return inventarios;
        }
        
        public List<Inventario> GetInventariosByJugador(int jugadorId)
        {
            List<Inventario> inventarios = new List<Inventario>();
            
            string query = @"
                SELECT i.*, j.Nombre AS JugadorNombre, b.Nombre AS BloqueNombre
                FROM Inventario i
                INNER JOIN Jugadores j ON i.JugadorId = j.Id
                INNER JOIN Bloques b ON i.BloqueId = b.Id
                WHERE i.JugadorId = @JugadorId
                ORDER BY b.Nombre";
                
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@JugadorId", jugadorId)
            };
            
            DataTable dataTable = DatabaseManager.ExecuteQuery(query, parameters);
            
            foreach (DataRow row in dataTable.Rows)
            {
                Inventario inventario = new Inventario
                {
                    Id = Convert.ToInt32(row["Id"]),
                    JugadorId = Convert.ToInt32(row["JugadorId"]),
                    BloqueId = Convert.ToInt32(row["BloqueId"]),
                    Cantidad = Convert.ToInt32(row["Cantidad"]),
                    JugadorNombre = row["JugadorNombre"].ToString(),
                    BloqueNombre = row["BloqueNombre"].ToString()
                };
                
                inventarios.Add(inventario);
            }
            
            return inventarios;
        }
        
        public Inventario GetInventarioById(int id)
        {
            string query = @"
                SELECT i.*, j.Nombre AS JugadorNombre, b.Nombre AS BloqueNombre
                FROM Inventario i
                INNER JOIN Jugadores j ON i.JugadorId = j.Id
                INNER JOIN Bloques b ON i.BloqueId = b.Id
                WHERE i.Id = @Id";
                
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };
            
            DataTable dataTable = DatabaseManager.ExecuteQuery(query, parameters);
            
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return new Inventario
                {
                    Id = Convert.ToInt32(row["Id"]),
                    JugadorId = Convert.ToInt32(row["JugadorId"]),
                    BloqueId = Convert.ToInt32(row["BloqueId"]),
                    Cantidad = Convert.ToInt32(row["Cantidad"]),
                    JugadorNombre = row["JugadorNombre"].ToString(),
                    BloqueNombre = row["BloqueNombre"].ToString()
                };
            }
            
            return null;
        }
        
        public void CreateInventario(Inventario inventario)
        {
            // Check if the player already has this block in inventory
            string checkQuery = "SELECT Id, Cantidad FROM Inventario WHERE JugadorId = @JugadorId AND BloqueId = @BloqueId";
            SqlParameter[] checkParams = new SqlParameter[]
            {
                new SqlParameter("@JugadorId", inventario.JugadorId),
                new SqlParameter("@BloqueId", inventario.BloqueId)
            };
            
            DataTable existingTable = DatabaseManager.ExecuteQuery(checkQuery, checkParams);
            
            if (existingTable.Rows.Count > 0)
            {
                // Update existing inventory entry
                int existingId = Convert.ToInt32(existingTable.Rows[0]["Id"]);
                int existingCantidad = Convert.ToInt32(existingTable.Rows[0]["Cantidad"]);
                int newCantidad = existingCantidad + inventario.Cantidad;
                
                string updateQuery = "UPDATE Inventario SET Cantidad = @Cantidad WHERE Id = @Id";
                SqlParameter[] updateParams = new SqlParameter[]
                {
                    new SqlParameter("@Id", existingId),
                    new SqlParameter("@Cantidad", newCantidad)
                };
                
                DatabaseManager.ExecuteNonQuery(updateQuery, updateParams);
                inventario.Id = existingId;
                inventario.Cantidad = newCantidad;
            }
            else
            {
                // Create new inventory entry
                string insertQuery = @"
                    INSERT INTO Inventario (JugadorId, BloqueId, Cantidad)
                    VALUES (@JugadorId, @BloqueId, @Cantidad);
                    SELECT SCOPE_IDENTITY();";
                    
                SqlParameter[] insertParams = new SqlParameter[]
                {
                    new SqlParameter("@JugadorId", inventario.JugadorId),
                    new SqlParameter("@BloqueId", inventario.BloqueId),
                    new SqlParameter("@Cantidad", inventario.Cantidad)
                };
                
                int newId = DatabaseManager.ExecuteScalar<int>(insertQuery, insertParams);
                inventario.Id = newId;
            }
        }
        
        public void UpdateInventario(Inventario inventario)
        {
            string query = @"
                UPDATE Inventario 
                SET JugadorId = @JugadorId,
                    BloqueId = @BloqueId,
                    Cantidad = @Cantidad
                WHERE Id = @Id";
                
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", inventario.Id),
                new SqlParameter("@JugadorId", inventario.JugadorId),
                new SqlParameter("@BloqueId", inventario.BloqueId),
                new SqlParameter("@Cantidad", inventario.Cantidad)
            };
            
            DatabaseManager.ExecuteNonQuery(query, parameters);
        }
        
        public void DeleteInventario(int id)
        {
            string query = "DELETE FROM Inventario WHERE Id = @Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };
            
            DatabaseManager.ExecuteNonQuery(query, parameters);
        }
    }
}