using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TpWinForm_Equipo9A
{
    public partial class frmMenu: Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListado ventanaListado = new frmListado();
            ventanaListado.ShowDialog();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar ventanaAgregar = new frmAgregar();
            ventanaAgregar.ShowDialog();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Form7 ventanaBuscarArt = new Form7();
            //ventanaBuscarArt.Show();
            frmBuscar ventanaBuscarArt = new frmBuscar();
            ventanaBuscarArt.ShowDialog();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            frmMarcaListado ventanaMarca = new frmMarcaListado();
            ventanaMarca.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategoriaListado ventanaCategoria = new frmCategoriaListado();
            ventanaCategoria.ShowDialog();
        }
    }
}
