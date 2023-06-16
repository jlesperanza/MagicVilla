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
                    Id= 1,
                    Nombre="Villa Real",
                    Detalle="Detalle de la Villa...",
                    ImagenUrl="",
                    Ocupantes=5,
                    MetrosCuadrados=200,
                    Amenidad="",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion=DateTime.Now
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
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                }
                );
        }
            
          
    }
}
