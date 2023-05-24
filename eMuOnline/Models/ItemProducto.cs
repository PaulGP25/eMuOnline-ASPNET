using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eMuOnline.Models
{
    public class ItemProducto
    {
        [Key]
        public int IdItemProducto { get; set; }

        public string NombreItemProducto { get; set; }

        public double PrecioItemProducto { get; set; }

        public string DescripcionItemProducto { get; set; }

        public string ImagenItemProducto { get; set; }

        public DateTime StartDateItem { get; set; }

        public DateTime EndDateItem { get; set; }

        //Relationship
        public List<ItemProducto_Personaje> ItemProductos_Personajes { get; set; }


        //Categoria
        public int IdCategoria { get; set; }

        [ForeignKey("IdCategoria")]
        public Categoria Categoria { get; set; }
    }
}
