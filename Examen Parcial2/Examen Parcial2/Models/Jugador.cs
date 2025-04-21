using System;

namespace MinecraftManagerWinForms.Models
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Jugador()
        {
            // Default constructor
        }

        public Jugador(int id, string nombre, int nivel, DateTime fechaCreacion)
        {
            Id = id;
            Nombre = nombre;
            Nivel = nivel;
            FechaCreacion = fechaCreacion;
        }

        public override string ToString()
        {
            return $"{Id} - {Nombre} (Nivel {Nivel})";
        }
    }
}