using MagicVilla_API.Model;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Datos
{
    public class AplicationDbContext:DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)    
        {

        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Nombre = "Villa Real",
                    Detalle = "Detalle de la Real...",
                    ImagenUrl = "",
                    Ocupantes = 4,
                    MetrosCuadrados = 150,
                    Amenidad = "",
                },
                new Villa()
                {
                    Id = 2,
                    Nombre = "Villa Grande",
                    Detalle = "Detalle de la Villa...",
                    ImagenUrl = "",
                    Ocupantes = 4,
                    MetrosCuadrados = 150,
                    Amenidad = "",
                },
                new Villa()
                {
                    Id = 3,
                    Nombre = "Villa Rodrigo",
                    Detalle = "Detalle de la Villa...",
                    ImagenUrl = "",
                    Ocupantes = 5,
                    MetrosCuadrados = 150,
                    Amenidad = "",
                }
                );
        }
            
          
    }
}
