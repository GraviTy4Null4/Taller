using System.ComponentModel.DataAnnotations;

namespace Taller_Reparacion.Domain
{
    public class EstadoOrden
    {
        [Key]
        public int Id_Estado { get; set; }
        public string Nombre { get; set; }
    }
}
