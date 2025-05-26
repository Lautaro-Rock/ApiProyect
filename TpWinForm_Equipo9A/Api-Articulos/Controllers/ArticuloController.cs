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
        [Route("api/Articulo")]
        public  IEnumerable<Articulo> Get()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            return articuloNegocio.listar();
        }

        // GET: api/Articulo/5
        [HttpGet]
        [Route("api/Articulo/{id}")]
        public Articulo Get(int id)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            List<Articulo> lista = articuloNegocio.listar();

            return lista.Find(z => z.ID == id);
        }

       
        // POST: api/Articulo
        [HttpPost]
        [Route("api/Articulo")]
        public HttpResponseMessage PostArticulo([FromBody] ArticuloDTO articulo)
        {
            try
            {
               if(articulo.Precio < 0)
                {
                    var mensaje = new { error = "No se puede agregar el artículo, el precio no debe ser negativo." };
                    return Request.CreateResponse(HttpStatusCode.BadRequest, mensaje);
                
                }else if(articulo.Precio == 0)
                {
                    var mensaje = new { error = "No se puede agregar el artículo, el precio no debe ser igual a cero." };
                    return Request.CreateResponse(HttpStatusCode.BadRequest, mensaje);
                }
                
               if(articulo.IdMarca <=0 || articulo.IdMarca > 5)
                {
                    var mensaje = new { error = "No se puede agregar el artículo, el ID de la marca no existe o es incorrecto." };
                    return Request.CreateResponse(HttpStatusCode.BadRequest, mensaje);
                }

                if (articulo.IdCategoria <= 0 || articulo.IdCategoria > 4)
                {
                    var mensaje = new { error = "No se puede agregar el artículo, el ID de la categoria no existeo es incorrecto" };
                    return Request.CreateResponse(HttpStatusCode.BadRequest, mensaje);
                }


                ArticuloNegocio negocio = new ArticuloNegocio();
                Articulo nuevo = new Articulo();
                nuevo.Nombre = articulo.Nombre;
                nuevo.Descripcion = articulo.Descripcion;
                nuevo.Precio = articulo.Precio;
                nuevo.Codigo = articulo.Codigo;
                nuevo.Categoria = new Categoria { ID = articulo.IdCategoria };
                nuevo.Marca = new Marca { ID = articulo.IdMarca };
                negocio.agregarDTO(nuevo);

                return Request.CreateResponse(HttpStatusCode.Created, "Articulo creado correctamente");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
          
        }

        // POST: api/Articulo/agregar_imagenes
        [HttpPost]
        [Route("api/Articulo/agregar_imagenes")]
        public HttpResponseMessage PostImagenes([FromBody] ImagenesDTO imagenes)
        {
            try
            {
                if(imagenes.Id <=0) {
                    var mensaje = new { error = "ID de artículo ingresado no es valido." };
                    return Request.CreateResponse(HttpStatusCode.BadRequest, mensaje);
                }

                ArticuloNegocio negocio = new ArticuloNegocio();

                if (!negocio.consutar_id_articulo(imagenes.Id))
                {
                    var mensaje = new { error = "No se puede agregar las imagenes, el ID de artículo no existe." };
                    return Request.CreateResponse(HttpStatusCode.BadRequest, mensaje);
                }

                if (imagenes.imagenDTOs == null || imagenes.imagenDTOs.Count == 0)
                {
                    var mensaje = new { error = "Debes agregar al menos una imagen para el artículo." };
                    return Request.CreateResponse(HttpStatusCode.BadRequest, mensaje);
                }

                Articulo nuevo = new Articulo();
                nuevo.ID = imagenes.Id;
                nuevo.UrlImagens = new List<Imagen>();

                foreach (var item in imagenes.imagenDTOs)
                {

                    Imagen imagen = new Imagen();
                    imagen.ImagenUrl = item.ImagenUrl;
                    // imagen.IdArticulo = imagenes.Id;
                    nuevo.UrlImagens.Add(imagen);

                }
                negocio.agregar_imagenes(nuevo);

                return Request.CreateResponse(HttpStatusCode.Created, "Imagen agregada correctamente");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
            

        }


        // PUT: api/Articulo/5
        [HttpPut]
        [Route("api/Articulo/{id}")]
        public HttpResponseMessage Put(int id, [FromBody] ArticuloDTO articulo)
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();

                if (id <= 0)
                {
                    var mensaje = new { error = "No se puede modificar el artículo, el ID especificado no debe ser negativo o cero." };
                    return Request.CreateResponse(HttpStatusCode.BadRequest, mensaje);
                }

                if (!negocio.consutar_id_articulo(id))
                {
                    var mensaje = new { error = "No se puede modificar el artículo: el ID especificado no existe." };
                    return Request.CreateResponse(HttpStatusCode.BadRequest, mensaje);
                }

                if (articulo.Precio < 0)
                {
                    var mensaje = new { error = "No se puede modificar el artículo: el precio no debe ser negativo." };
                    return Request.CreateResponse(HttpStatusCode.BadRequest, mensaje);
                }

                if (articulo.Precio == 0)
                {
                    var mensaje = new { error = "No se puede modificar el artículo: el precio no debe ser igual a cero." };
                    return Request.CreateResponse(HttpStatusCode.BadRequest, mensaje);
                }

                if (articulo.IdMarca <= 0 || articulo.IdMarca > 5) 
                {
                    var mensaje = new { error = "No se puede modificar el artículo: el ID de la marca no existe o es incorrecto." };
                    return Request.CreateResponse(HttpStatusCode.BadRequest, mensaje);
                }

                if (articulo.IdCategoria <= 0 || articulo.IdCategoria > 4)
                {
                    var mensaje = new { error = "No se puede modificar el artículo: el ID de la categoría no existe o es incorrecto." };
                    return Request.CreateResponse(HttpStatusCode.BadRequest, mensaje);
                }

                Articulo nuevo = new Articulo
                {
                    ID = id,
                    Nombre = articulo.Nombre,
                    Descripcion = articulo.Descripcion,
                    Precio = articulo.Precio,
                    Codigo = articulo.Codigo,
                    Categoria = new Categoria { ID = articulo.IdCategoria },
                    Marca = new Marca { ID = articulo.IdMarca }
                };

                negocio.editar(nuevo);
                return Request.CreateResponse(HttpStatusCode.OK, "Artículo modificado correctamente.");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { error = ex.Message });
            }
        }

        // DELETE: api/Articulo/5
        [HttpDelete]
        [Route("api/Articulo/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                if (id <= 0)
                {
                    var mensaje = new { error = "No se puede eliminar el artículo, el ID especificado no debe ser negativo o cero." };
                    return Request.CreateResponse(HttpStatusCode.BadRequest, mensaje);
                }

                if (!negocio.consutar_id_articulo(id))
                {
                    var mensaje = new { error = "No se puede eliminar el artículo: el ID especificado no existe." };
                    return Request.CreateResponse(HttpStatusCode.BadRequest, mensaje);
                }
                Articulo articulo = new Articulo();
                articulo.ID = id;
                negocio.eliminar(articulo);

                return Request.CreateResponse(HttpStatusCode.OK, "Producto eliminado correctamente");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        
        }
    }
}
