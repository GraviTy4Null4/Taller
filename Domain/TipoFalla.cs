using System.ComponentModel.DataAnnotations;

namespace Taller_Reparacion.Domain
{
    public class TipoFalla
    {
        [Key] 
        public int Id_Falla { get; set; }
        public String Nombre { get; set; }
    }
}
