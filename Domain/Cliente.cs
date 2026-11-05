using System.ComponentModel.DataAnnotations;

namespace Taller_Reparacion.Domain
{
    public class Cliente
    {
        [Key]
        public int Id_Cliente { get; set; }
        public string Nombre { get; set; }
        public string telefono { get; set; }
    }
}
