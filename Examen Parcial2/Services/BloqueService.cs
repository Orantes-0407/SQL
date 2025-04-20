using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using MinecraftManagerWinForms.Models;
using MinecraftManagerWinForms.Utils;

namespace MinecraftManagerWinForms.Services
{
    public class BloqueService
    {
        public List<Bloque> GetAllBloques()
        {
            List<Bloque> bloques = new List<Bloque>();
            
            string query = "SELECT * FROM Bloques ORDER BY Nombre";
            DataTable dataTable = DatabaseManager.ExecuteQuery(query);
            
            foreach (DataRow row in dataTable.Rows)
            {
                Bloque bloque = new Bloque
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nombre = row["Nombre"].ToString(),
                    Tipo = row["Tipo"].ToString(),
                    Rareza = row["Rareza"].ToString()
                };
                
                bloques.Add(bloque);
            }
            
            return bloques;
        }
        
        public Bloque GetBloqueById(int id)
        {
            string query = "SELECT * FROM Bloques WHERE Id = @Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };
            
            DataTable dataTable = DatabaseManager.ExecuteQuery(query, parameters);
            
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return new Bloque
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nombre = row["Nombre"].ToString(),
                    Tipo = row["Tipo"].ToString(),
                    Rareza = row["Rareza"].ToString()
                };
            }
            
            return null;
        }
        
        public void CreateBloque(Bloque bloque)
        {
            string query = @"
                INSERT INTO Bloques (Nombre, Tipo, Rareza) 
                VALUES (@Nombre, @Tipo, @Rareza);
                SELECT SCOPE_IDENTITY();";
                
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Nombre", bloque.Nombre),
                new SqlParameter("@Tipo", bloque.Tipo),
                new SqlParameter("@Rareza", bloque.Rareza)
            };
            
            int newId = DatabaseManager.ExecuteScalar<int>(query, parameters);
            bloque.Id = newId;
        }
        
        public void UpdateBloque(Bloque bloque)
        {
            string query = @"
                UPDATE Bloques 
                SET Nombre = @Nombre, 
                    Tipo = @Tipo, 
                    Rareza = @Rareza 
                WHERE Id = @Id";
                
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", bloque.Id),
                new SqlParameter("@Nombre", bloque.Nombre),
                new SqlParameter("@Tipo", bloque.Tipo),
                new SqlParameter("@Rareza", bloque.Rareza)
            };
            
            DatabaseManager.ExecuteNonQuery(query, parameters);
        }
        
        public void DeleteBloque(int id)
        {
            // First delete any inventory items for this block
            string deleteInventarioQuery = "DELETE FROM Inventario WHERE BloqueId = @Id";
            SqlParameter[] inventarioParameters = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };
            
            DatabaseManager.ExecuteNonQuery(deleteInventarioQuery, inventarioParameters);
            
            // Now delete the block
            string deleteBloqueQuery = "DELETE FROM Bloques WHERE Id = @Id";
            SqlParameter[] bloqueParameters = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };
            
            DatabaseManager.ExecuteNonQuery(deleteBloqueQuery, bloqueParameters);
        }
    }
}