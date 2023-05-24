using eMuOnline.Models;

namespace eMuOnline.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Categoria
                if(!context.Categorias.Any())
                {
                    context.Categorias.AddRange(new List<Categoria>()
                    {
                        new Categoria()
                        {
                            NombreCategoria = "Sets Clasicos",
                            DescripcionCategoria = "Sets clasicos desde la season 1 a la season 4"
                        }
                    });
                    context.SaveChanges();
                }
                //Personajes
                if (!context.Personajes.Any())
                {
                    context.Personajes.AddRange(new List<Personaje>() 
                    {
                        new Personaje()
                        {
                            ImagenURLPersonaje = "https://cdn.discordapp.com/attachments/1093991925218033716/1103790017110880306/latest.png",
                            NombreFullPersonaje = "Dark Knight",
                            NombreCortoPersonaje = "DK",
                            BiografiaPersonaje = "Primer Personaje y el mas iconico del juego."
                        }
                    });
                    context.SaveChanges();
                }
                //ItemProductos
                if (!context.ItemProductos.Any())
                {
                    context.ItemProductos.AddRange(new List<ItemProducto>()
                    {
                        new ItemProducto()
                        {
                            NombreItemProducto = "Set Dragon",
                            DescripcionItemProducto = "Full Opciones +15",
                            PrecioItemProducto = 20.90,
                            ImagenItemProducto = "https://cdn.discordapp.com/attachments/1093991925218033716/1103791930527199394/Z.png",
                            StartDateItem = DateTime.Now,
                            EndDateItem = DateTime.Now.AddDays(365),
                            IdCategoria = 1
                        }
                    });
                    context.SaveChanges();
                }
                //ItemProductos % Personajes
                if (!context.ItemProductos_Personajes.Any())
                {
                    context.ItemProductos_Personajes.AddRange(new List<ItemProducto_Personaje>()
                    {
                        new ItemProducto_Personaje()
                        {
                            IdItemProducto = 1,
                            IdPersonaje = 1
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
