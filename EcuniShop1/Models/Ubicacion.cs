using System.ComponentModel.DataAnnotations;

namespace EcuniShop1.Models
{
    public class Ubicacion
    {
        [Key]
        public int IdUbicacion { get; set; }
        [Required]
        public string Provincia { get; set; }
        public string Ciudad { get; set; }
        public float DescuentoUbicacion { get; set; }

    }
}
