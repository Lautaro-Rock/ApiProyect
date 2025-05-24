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
    public partial class frmCategoriaAgregar : Form
    {
        private Categoria cat = null; 
        public frmCategoriaAgregar()
        {
            InitializeComponent();
        }

        public frmCategoriaAgregar(Categoria categoria)
        {
            InitializeComponent();
            this.cat = categoria;  
        }

        private void newAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio newNegocio = new CategoriaNegocio();
            try
            {
                if (cat == null)
                {
                    cat = new Categoria();
                }

                cat.Descripcion = inputDescripcion.Text;

                if (cat.ID != 0)
                {
                    newNegocio.editar(cat);
                    MessageBox.Show("Editado exitosamente");
                }
                else
                {
                    newNegocio.agregar(cat);
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

        private void frmCategoriaAgregar_Load(object sender, EventArgs e)
        {
            try
            {

                if (cat != null)
                {

                    inputDescripcion.Text = cat.Descripcion;

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
    }
}
