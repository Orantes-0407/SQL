using System;

namespace MinecraftManagerWinForms.Models
{
    public class Bloque
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Rareza { get; set; }

        public Bloque()
        {
            // Default constructor
        }

        public Bloque(int id, string nombre, string tipo, string rareza)
        {
            Id = id;
            Nombre = nombre;
            Tipo = tipo;
            Rareza = rareza;
        }

        public override string ToString()
        {
            return $"{Id} - {Nombre} ({Tipo}, {Rareza})";
        }
    }
}