
using System.Collections.Generic;

namespace Dominio
{
    public class Articulo
    {
        public int ID { get; set; }
        public string Nombre {  get; set; }
        public string Descripcion { get; set; }
        public decimal Precio {  get; set; } 
        public string Codigo { get; set; }

        public Marca Marca { get; set; }

        public Categoria Categoria { get; set; }

        
        public Imagen UrlImagen { get; set; }

        public List<Imagen> UrlImagens { get; set; }

    }
}
