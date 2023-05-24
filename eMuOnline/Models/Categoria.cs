using System.ComponentModel.DataAnnotations;

namespace eMuOnline.Models
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }

        public string NombreCategoria { get; set; }

        public string DescripcionCategoria { get; set; }

        //Relationships

        public List<ItemProducto> ItemProductos { get; set; }

    }
}
