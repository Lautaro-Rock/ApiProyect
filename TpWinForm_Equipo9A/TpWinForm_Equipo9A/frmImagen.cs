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
    public partial class frmImagen : Form
    {
        private Articulo art = null;
        public frmImagen(Articulo art)
        {
            InitializeComponent();
            this.art = art;
        }


        private void newAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio newNegocio= new ArticuloNegocio();
            try
            {
                art.UrlImagen.ImagenUrl = txtUrlImagen.Text;

                newNegocio.agregarImagen(art);
                MessageBox.Show("Agregado exitosamente");
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

        private void cargarFoto(string imagen)
        {
            try
            {
                pboImagen.Load(imagen);
            }
            catch (Exception)
            {

                pboImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSf0ee70UsCrUU3czX7qfX0gCjXy9Qo8nfiuQ&s");
            }
        }
        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarFoto(txtUrlImagen.Text);
        }
    }
}
