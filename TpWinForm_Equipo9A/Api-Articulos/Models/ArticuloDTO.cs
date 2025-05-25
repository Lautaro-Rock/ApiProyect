﻿using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Articulos.Models
{
    public class ArticuloDTO
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string Codigo { get; set; }
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }

    }
}