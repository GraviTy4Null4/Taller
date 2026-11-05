using System.ComponentModel.DataAnnotations;


namespace Taller_Reparacion.Domain
{
    public class Equipo
    {
        [Key]
        public int Id_Equipo { get; set; }
        public int Id_Cliente { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NoSerie { get; set; }
    }
}
