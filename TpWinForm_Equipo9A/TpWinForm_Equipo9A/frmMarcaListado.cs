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
    public partial class frmMarcaListado : Form
    {
        private List<Marca> listaMarca;
        public frmMarcaListado()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            try
            {
                MarcaNegocio negocio = new MarcaNegocio();
                listaMarca = negocio.lista();
                dgvMarca.DataSource = listaMarca;
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

        private void frmMarcaListado_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        { 
            frmMarcaAgregar newVentana = new frmMarcaAgregar();
            newVentana.ShowDialog();
            cargar();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Marca Seleccionado;
            Seleccionado = (Marca)dgvMarca.CurrentRow.DataBoundItem;

            frmMarcaAgregar modificar = new frmMarcaAgregar(Seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            MarcaNegocio newNegocio = new MarcaNegocio();
            try
            {
                DialogResult respuesta = MessageBox.Show("El registro no se podrá recuperar. ¿Confirmar elección?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    Marca Seleccionado;
                    Seleccionado = (Marca)dgvMarca.CurrentRow.DataBoundItem;
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
    }
}
