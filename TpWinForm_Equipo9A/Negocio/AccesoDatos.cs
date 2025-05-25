using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand conexionCommand;
        private SqlDataReader conexionDataReader;
        public SqlDataReader ConexionDataReader
        {
            get { return conexionDataReader; }
        }

        public AccesoDatos()
        {
            conexion= new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");
            conexionCommand = new SqlCommand();
        }
        public void setearConsulta(string consulta)
        {
            
            conexionCommand.CommandType=System.Data.CommandType.Text;
            conexionCommand.CommandText=consulta;
        }
        public void ejecutarLectura()
        {
            conexionCommand.Connection = conexion;
            try
            {
                conexion.Open();
                conexionDataReader = conexionCommand.ExecuteReader();

            }
            catch (Exception ex) {
                throw ex;
            }
 
        }

        public void setearParametro(string nombre, object valor)
        {
            conexionCommand.Parameters.AddWithValue(nombre, valor);
        }
        public void ejecutarAccion()
        {
            conexionCommand.Connection= conexion;
            try
            {
                conexion.Open();
                conexionCommand.ExecuteNonQuery();
            }
            catch(Exception ex) {
                throw ex;
            }
            finally {
                conexion.Close();
                conexionCommand.Parameters.Clear();
            }
               }

        public void cerrarConexion()
        {
            if (conexionDataReader != null) { 
            conexionDataReader.Close(); 
            }
            conexion.Close();   
        }
    }
}
