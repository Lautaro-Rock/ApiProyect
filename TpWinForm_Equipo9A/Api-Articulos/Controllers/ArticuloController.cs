using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dominio;
using Negocio;
using Api_Articulos.Models;

namespace Api_Articulos.Controllers
{
    public class ArticuloController : ApiController
    {
        // GET: api/Articulo
        public IEnumerable<Articulo> Get()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            return articuloNegocio.listar();
        }

        // GET: api/Articulo/5
        public Articulo Get(int id)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            List<Articulo> lista = articuloNegocio.listar();

            return lista.Find(z => z.ID == id);
        }

        // POST: api/Articulo
        public void Post([FromBody]ArticuloDTO articulo)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo nuevo = new Articulo();
            nuevo.Nombre = articulo.Nombre;
            nuevo.Descripcion = articulo.Descripcion;
            nuevo.Precio = articulo.Precio;
            nuevo.Codigo = articulo.Codigo;
            nuevo.Categoria = new Categoria { ID = articulo.IdCategoria };
            nuevo.Marca = new Marca { ID = articulo.IdMarca };

            negocio.agregarDTO(nuevo);
        }

        // PUT: api/Articulo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Articulo/5
        public void Delete(int id)
        {
        }
    }
}
