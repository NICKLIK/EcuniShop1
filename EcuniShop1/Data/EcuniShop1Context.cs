using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EcuniShop1.Models;

namespace EcuniShop1.Data
{
    public class EcuniShop1Context : DbContext
    {
        public EcuniShop1Context (DbContextOptions<EcuniShop1Context> options)
            : base(options)
        {
        }

        public DbSet<EcuniShop1.Models.Ubicacion> Ubicacion { get; set; } = default!;
        public DbSet<EcuniShop1.Models.Producto> Producto { get; set; } = default!;
        public DbSet<EcuniShop1.Models.Estudiante> Estudiante { get; set; } = default!;
        public DbSet<EcuniShop1.Models.Catalogo> Catalogo { get; set; } = default!;
        public DbSet<EcuniShop1.Models.Compra> Compra { get; set; } = default!;
    }
}
