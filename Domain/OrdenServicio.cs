using System.ComponentModel.DataAnnotations;

namespace Taller_Reparacion.Domain
{
    public class OrdenServicio
    {
        [Key] 
        public int Id_Orden { get; set; }
        public int Id_Equipo { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Falla { get; set; }
        public int Id_Estado { get; set; }
        public int Folio { get; set; }
        public DateOnly Fecha_recepcion { get; set; }
        public string Falla { get; set; }
        public String Diagnostico { get; set; }
        public float Costo_MO { get; set; }
    }
}
