using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcuniShop1.Models
{
    public class Compra
    {
        [Key]
        public int IdCompra { get; set; }
        [Required]
        public string MetodoPago { get; set; }
        public float Descuento { get; set; }
        [ForeignKey("IdEstudiante")]
        public int? IdEstudiante { get; set; }
        public Estudiante? EspecificacionEstudiante { get; set; }

        [ForeignKey("IdProducto")]
        public int? IdProducto { get; set; }
        public Producto? EspecificacionProducto { get; set; }
        [ForeignKey("IdUbicacion")]
        public int? IdUbicacion { get; set; }
        public Ubicacion? Ubicacion { get; set; }    
    }
}
