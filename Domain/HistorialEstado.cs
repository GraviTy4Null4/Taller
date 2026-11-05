using System.ComponentModel.DataAnnotations;

namespace Taller_Reparacion.Domain
{
    public class HistorialEstado
    {
        [Key]
        public int Id_Historial { get; set; }
        public int Id_Orden { get; set; }
        public int Id_Estado { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
