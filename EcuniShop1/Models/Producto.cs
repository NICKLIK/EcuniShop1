using System.ComponentModel.DataAnnotations;

namespace EcuniShop1.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        [Required]
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public float Precio { get; set; }
        public int Cantidad { get; set; }
    }
}
