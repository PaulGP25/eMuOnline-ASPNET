using eMuOnline.Models;
using Microsoft.EntityFrameworkCore;

namespace eMuOnline.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemProducto_Personaje>().HasKey(ip => new
            {
                ip.IdPersonaje,
                ip.IdItemProducto
            });
            modelBuilder.Entity<ItemProducto_Personaje>().HasOne(i => i.ItemProducto).WithMany(ip => ip.ItemProductos_Personajes).HasForeignKey(i => i.IdItemProducto);
            modelBuilder.Entity<ItemProducto_Personaje>().HasOne(p => p.Personaje).WithMany(ip => ip.ItemProductos_Personajes).HasForeignKey(p => p.IdPersonaje);



            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Personaje> Personajes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ItemProducto> ItemProductos { get; set; }
        public DbSet<ItemProducto_Personaje> ItemProductos_Personajes { get; set; }
    }
}
