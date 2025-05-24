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
using Dominio;
using Negocio;


namespace TpWinForm_Equipo9A
{
    public partial class frmAgregar : Form
    {
        private Articulo art=null;

        public frmAgregar()
        {
            InitializeComponent();
        }

        public frmAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.art = articulo;
        }

        private void newAceptar_Click(object sender, EventArgs e)
        {
            //Articulo newArticulo = new Articulo();
            ArticuloNegocio newNegocio= new ArticuloNegocio();
            try
            {
                if (art == null)
                {
                    art = new Articulo();
                    art.UrlImagen = new Imagen(); 
                }
                art.Nombre = newNombre.Text;
                art.Descripcion = inputDescripcion.Text;
                art.Codigo = inputCod.Text;
                art.Precio = inputPrecio.Value;
                art.UrlImagen.ImagenUrl = txtImagen.Text;
                art.Marca = (Marca)cboMarca.SelectedItem;
                art.Categoria = (Categoria)cboCategoria.SelectedItem;

                if (art.ID != 0)
                {
                    newNegocio.editar(art);
                    MessageBox.Show("Editado exitosamente");
                }
                else
                {
                    newNegocio.agregar(art);
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

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            MarcaNegocio newMarca = new MarcaNegocio();
            CategoriaNegocio newCategoria = new CategoriaNegocio();
            try
            {
                cboMarca.DataSource = newMarca.lista();
                cboMarca.ValueMember = "ID";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = newCategoria.lista();
                cboCategoria.ValueMember = "ID";
                cboCategoria.DisplayMember = "Descripcion";

                if (art != null) { 
                 newNombre.Text= art.Nombre;
                 inputCod.Text= art.Codigo;
                 inputPrecio.Text= art.Precio.ToString();
                 inputDescripcion.Text= art.Descripcion;
                 txtImagen.Text = art.UrlImagen.ImagenUrl;
                 cargarImagen(art.UrlImagen.ImagenUrl);
                 cboMarca.SelectedValue = art.Marca.ID;
                 cboCategoria.SelectedValue = art.Categoria.ID;
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

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }
        private void cargarImagen(string imagen)
        {
          try
          {
            pbxImagen.Load(imagen);
          }
          catch (Exception)
          {

            pbxImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSf0ee70UsCrUU3czX7qfX0gCjXy9Qo8nfiuQ&s");
          }
       }
    }
}
