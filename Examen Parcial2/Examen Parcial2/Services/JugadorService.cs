using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using MinecraftManagerWinForms.Models;
using MinecraftManagerWinForms.Utils;

namespace MinecraftManagerWinForms.Services
{
    public class JugadorService
    {
        public List<Jugador> GetAllJugadores()
        {
            List<Jugador> jugadores = new List<Jugador>();
            
            string query = "SELECT * FROM Jugadores ORDER BY Nombre";
            DataTable dataTable = DatabaseManager.ExecuteQuery(query);
            
            foreach (DataRow row in dataTable.Rows)
            {
                Jugador jugador = new Jugador
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nombre = row["Nombre"].ToString(),
                    Nivel = Convert.ToInt32(row["Nivel"]),
                    FechaCreacion = Convert.ToDateTime(row["FechaCreacion"])
                };
                
                jugadores.Add(jugador);
            }
            
            return jugadores;
        }
        
        public Jugador GetJugadorById(int id)
        {
            string query = "SELECT * FROM Jugadores WHERE Id = @Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };
            
            DataTable dataTable = DatabaseManager.ExecuteQuery(query, parameters);
            
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return new Jugador
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nombre = row["Nombre"].ToString(),
                    Nivel = Convert.ToInt32(row["Nivel"]),
                    FechaCreacion = Convert.ToDateTime(row["FechaCreacion"])
                };
            }
            
            return null;
        }
        
        public void CreateJugador(Jugador jugador)
        {
            string query = @"
                INSERT INTO Jugadores (Nombre, Nivel, FechaCreacion) 
                VALUES (@Nombre, @Nivel, @FechaCreacion);
                SELECT SCOPE_IDENTITY();";
                
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Nombre", jugador.Nombre),
                new SqlParameter("@Nivel", jugador.Nivel),
                new SqlParameter("@FechaCreacion", jugador.FechaCreacion)
            };
            
            int newId = DatabaseManager.ExecuteScalar<int>(query, parameters);
            jugador.Id = newId;
        }
        
        public void UpdateJugador(Jugador jugador)
        {
            string query = @"
                UPDATE Jugadores 
                SET Nombre = @Nombre, 
                    Nivel = @Nivel, 
                    FechaCreacion = @FechaCreacion 
                WHERE Id = @Id";
                
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", jugador.Id),
                new SqlParameter("@Nombre", jugador.Nombre),
                new SqlParameter("@Nivel", jugador.Nivel),
                new SqlParameter("@FechaCreacion", jugador.FechaCreacion)
            };
            
            DatabaseManager.ExecuteNonQuery(query, parameters);
        }
        
        public void DeleteJugador(int id)
        {
            // First delete any inventory items for this player
            string deleteInventarioQuery = "DELETE FROM Inventario WHERE JugadorId = @Id";
            SqlParameter[] inventarioParameters = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };
            
            DatabaseManager.ExecuteNonQuery(deleteInventarioQuery, inventarioParameters);
            
            // Now delete the player
            string deleteJugadorQuery = "DELETE FROM Jugadores WHERE Id = @Id";
            SqlParameter[] jugadorParameters = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };
            
            DatabaseManager.ExecuteNonQuery(deleteJugadorQuery, jugadorParameters);
        }
    }
}