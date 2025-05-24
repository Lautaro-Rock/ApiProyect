using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpWinForm_Equipo9A
{
    public partial class frmMarcaAgregar : Form
    {
        private Marca mar = null; 
        public frmMarcaAgregar()
        {
            InitializeComponent();
        }

        public frmMarcaAgregar(Marca marca)
        {
            InitializeComponent();
            this.mar = marca;
        }

        private void frmMarcaAgregar_Load(object sender, EventArgs e)
        {

            try
            {

                if (mar != null)
                {

                    inputDescripcion.Text = mar.Descripcion;

                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Error al acceder a la Base de Datos");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void newAceptar_Click(object sender, EventArgs e)
        {
            MarcaNegocio newNegocio = new MarcaNegocio();
            try
            {
                if (mar == null)
                {
                    mar = new Marca();
                }

                mar.Descripcion = inputDescripcion.Text;

                if (mar.ID != 0)
                {
                    newNegocio.editar(mar);
                    MessageBox.Show("Editado exitosamente");
                }
                else
                {
                    newNegocio.agregar(mar);
                    MessageBox.Show("Agregado exitosamente");
                }

                Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void newCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
