using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dominio;


namespace Api_Articulos.Models
{
    public class ImagenesDTO
    {
        public int Id { get; set; }
        public List<imagenDTO> imagenDTOs { get; set; }
}
}