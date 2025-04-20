using System;

namespace MinecraftManagerWinForms.Models
{
    public class Inventario
    {
        public int Id { get; set; }
        public int JugadorId { get; set; }
        public int BloqueId { get; set; }
        public int Cantidad { get; set; }
        
        // Navigation properties
        public string JugadorNombre { get; set; }
        public string BloqueNombre { get; set; }

        public Inventario()
        {
            // Default constructor
        }

        public Inventario(int id, int jugadorId, int bloqueId, int cantidad, string jugadorNombre = null, string bloqueNombre = null)
        {
            Id = id;
            JugadorId = jugadorId;
            BloqueId = bloqueId;
            Cantidad = cantidad;
            JugadorNombre = jugadorNombre;
            BloqueNombre = bloqueNombre;
        }

        public override string ToString()
        {
            return $"{Id} - Jugador: {JugadorNombre ?? JugadorId.ToString()}, Bloque: {BloqueNombre ?? BloqueId.ToString()}, Cantidad: {Cantidad}";
        }
    }
}