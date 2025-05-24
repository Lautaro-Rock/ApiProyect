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
    public partial class frmCategoriaListado : Form
    {
        private List<Categoria> listaCategoria;
        public frmCategoriaListado()
        {
            InitializeComponent();
        }

        private void frmCategoriaListado_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCategoriaAgregar newVentana = new frmCategoriaAgregar();
            newVentana.ShowDialog();
            cargar();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Categoria Seleccionado;
            Seleccionado = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;

            frmCategoriaAgregar modificar = new frmCategoriaAgregar(Seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            CategoriaNegocio newNegocio = new CategoriaNegocio();
            try
            {
                DialogResult respuesta = MessageBox.Show("El registro no se podrá recuperar. ¿Confirmar elección?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    Categoria Seleccionado;
                    Seleccionado = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                    newNegocio.eliminar(Seleccionado);
                    MessageBox.Show("Eliminado exitosamente");
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargar()
        {
            try
            {
                CategoriaNegocio negocio = new CategoriaNegocio();
                listaCategoria = negocio.lista();
                dgvCategoria.DataSource = listaCategoria;
            }
            catch (SqlException)
            {
                MessageBox.Show("Error al acceder a la Base de Datos");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
