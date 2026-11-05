using System.ComponentModel.DataAnnotations;

namespace Taller_Reparacion.Domain
{
    public class RefaccionUsada
    {
        [Key]
        public int Id_Refaccion { get; set; }
        public int Id_Orden { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public float Costo { get; set; }
    }
}
