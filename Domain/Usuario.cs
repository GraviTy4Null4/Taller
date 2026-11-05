using System.ComponentModel.DataAnnotations;

namespace Taller_Reparacion.Domain
{
    public class Usuario
    {
        [Key]
        public int Id_Usuario { get; set; }
        public String Nombre { get; set; }
        public String Nombre_usuario { get; set; }
        public String Contraseña { get; set; }
        public String Rol { get; set; }
        public Boolean Activo { get; set; }
    }
}
