namespace eMuOnline.Models
{
    public class ItemProducto_Personaje
    {
        public int IdItemProducto { get; set; }
        public ItemProducto ItemProducto { get; set; }

        public int IdPersonaje { get; set; }
        public Personaje Personaje { get; set; }


    }
}
