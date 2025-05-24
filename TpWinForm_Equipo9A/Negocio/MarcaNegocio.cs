using System;
using System.Collections.Generic;
using System.Globalization;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> lista()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion From MARCAS");
                datos.ejecutarLectura();

                while(datos.ConexionDataReader.Read())
                {
                    Marca aux = new Marca();
                    aux.ID = (int)datos.ConexionDataReader["Id"];
                    aux.Descripcion = (string)datos.ConexionDataReader["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            finally
            {
                datos.cerrarConexion();
            }
        }
        public void agregar(Marca nuevo)
        {
            AccesoDatos data = new AccesoDatos();

            try
            {
                data.setearConsulta("INSERT INTO MARCAS(Descripcion) VALUES (@Descripcion)");

                data.setearParametro("@Descripcion", nuevo.Descripcion);
                data.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                data.cerrarConexion();
            }
        }

        public void eliminar(Marca nuevo)
        {
            AccesoDatos data = new AccesoDatos();

            try
            {
                data.setearConsulta("DELETE FROM MARCAS WHERE Id='" + nuevo.ID + "'");
                data.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                data.cerrarConexion();
            }
        }

        public void editar(Marca edit)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta( "UPDATE MARCAS SET Descripcion = @Descripcion WHERE Id = @Id");
                datos.setearParametro("@Descripcion", edit.Descripcion);
                datos.setearParametro("@Id", edit.ID);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
    }

}
