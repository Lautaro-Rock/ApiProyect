using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dominio;
using Negocio;
using Api_Articulos.Models;
using Microsoft.Ajax.Utilities;

namespace Api_Articulos.Controllers
{
    public class ArticuloController : ApiController
    {

        // GET: api/Articulo
        [HttpGet]
        [Route("api/articulo")]
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
        [HttpPost]
        [Route("api/articulo")]
        public IHttpActionResult PostArticulo([FromBody] ArticuloDTO articulo)
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

            return Ok("Artículo agregado");
        }

        // POST: api/Articulo/agregar_imagenes
        [HttpPost]
        [Route("api/articulo/agregar_imagenes")]
        public IHttpActionResult PostImagenes([FromBody] ImagenesDTO imagenes)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo nuevo = new Articulo();
            nuevo.ID = imagenes.Id;
            nuevo.UrlImagens = new List<Imagen>();

            foreach (var item in imagenes.imagenDTOs) {

                Imagen imagen = new Imagen();
                imagen.ImagenUrl = item.ImagenUrl;
               // imagen.IdArticulo = imagenes.Id;
                nuevo.UrlImagens.Add(imagen);
            
            }
          negocio.agregar_imagenes(nuevo);
            return Ok("Imagenes agregadas");

        }


        // PUT: api/Articulo/5
        public void Put(int id, [FromBody] ArticuloDTO articulo)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo nuevo = new Articulo();
            nuevo.Nombre = articulo.Nombre;
            nuevo.Descripcion = articulo.Descripcion;
            nuevo.Precio = articulo.Precio;
            nuevo.Codigo = articulo.Codigo;
            nuevo.Categoria = new Categoria { ID = articulo.IdCategoria };
            nuevo.Marca = new Marca { ID = articulo.IdMarca };
            nuevo.ID = id;

            negocio.editar(nuevo);
      

        }

        // DELETE: api/Articulo/5
        public void Delete(int id)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo articulo = new Articulo();
            articulo.ID = id; 
            negocio.eliminar(articulo);
        }
    }
}
