using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taller_Reparacion.Domain
{
    public class Comprobante
    {
        [Key]
        public int Id_Comprobante {get; set;}
        [ForeignKey(nameof(Id_Orden))]
        public int Id_Orden {get; set;}
        public DateTime FechaEmision {get; set;}
        public int Formato {get; set;}

    }
}
