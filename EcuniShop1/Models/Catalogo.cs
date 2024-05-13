using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcuniShop1.Models
{
    public class Catalogo
    {
        [Key]
        public int IdCatalogo { get; set; }
        [Required]
        public string Categoria { get; set; }
        public string FiltroBusqueda { get; set; }
        [ForeignKey("IdProducto")]
        public int? IdProducto { get; set; }
        public Producto? ListaProducto { get; set; }
    }
}
