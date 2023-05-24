using System.ComponentModel.DataAnnotations;

namespace eMuOnline.Models
{
    public class Personaje
    {
        [Key]
        public int IdPersonaje { get; set; }

        public string ImagenURLPersonaje { get; set; }

        public string NombreCortoPersonaje { get; set; }

        public string NombreFullPersonaje { get; set; }

        public string BiografiaPersonaje { get; set; }

        //Relationship
        public List<ItemProducto_Personaje> ItemProductos_Personajes { get; set; }
    }
}
