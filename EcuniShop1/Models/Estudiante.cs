using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcuniShop1.Models
{
    public class Estudiante
    {
        [Key]
        public int IdEstudiante { get; set; }
        [Required]
        public string NombreEstudiante { get; set; }
        public string ApellidoEstudiante { get; set; }
        public string Membresia { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [ForeignKey("IdUbicacion")]
        public int? IdUbicacion { get; set; }
        public Ubicacion? UbicacionEstudiante { get; set; }
    }
}
