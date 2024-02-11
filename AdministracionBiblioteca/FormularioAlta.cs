using Cargarelementos;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionBiblioteca
{
    public partial class FormularioAltaLibro : Form
    {
        private Libro libro = null;       
        public FormularioAltaLibro()
        {
            InitializeComponent();
        }
        public FormularioAltaLibro(Libro libro)
        {
            InitializeComponent();
            this.libro = libro;
            Text = "Modificar Libro";
        }
        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarAlta_Click(object sender, EventArgs e)
        {                     
            CargarElemento cargarElemento = new CargarElemento();
            try
            {
                if (libro == null)
                    libro = new Libro();
                libro.Titulo = txbTitulo.Text;
                libro.Autor = txbAutor.Text;
                libro.Genero = txbGenero.Text;
                libro.AnioPublicacion = int.Parse(txbAñoPublicado.Text);
                libro.Stock = int.Parse(txbStock.Text);                
                libro.UrlPortada = txbUrlPortada.Text;
                libro.UrlFotoAutor = txbUrlAutor.Text;

                if (libro.LibroId != 0)
                {
                cargarElemento.Modificar(libro);
                    MessageBox.Show("El libro fue modificado exitosamente!");
                }
                else
                {
                    cargarElemento.Agregar(libro);
                    MessageBox.Show("El libro fue agregado exitosamente!");
                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }           
        }

        private void txbUrlPortada_Leave(object sender, EventArgs e)
        {
            try
            {
                pcbLibro.Load(txbUrlPortada.Text);
            }
            catch (Exception)
            {
                pcbLibro.Load("https://th.bing.com/th/id/OIP.mU5jJ2NcQFXHyq-VgQ1Q8wHaFj?rs=1&pid=ImgDetMain");
            }
        }

        private void txbUrlAutor_Leave(object sender, EventArgs e)
        {
            try
            {
                pcbAutor.Load(txbUrlAutor.Text);
            }
            catch (Exception)
            {
                pcbAutor.Load("https://th.bing.com/th/id/OIP.mU5jJ2NcQFXHyq-VgQ1Q8wHaFj?rs=1&pid=ImgDetMain");
            }
        }

        private void FormularioAltaLibro_Load(object sender, EventArgs e)
        {
            try
            {

                if (libro != null)
                {
                    txbTitulo.Text = libro.Titulo;
                    txbAutor.Text = libro.Autor;
                    txbGenero.Text = libro.Genero;
                    txbAñoPublicado.Text = libro.AnioPublicacion.ToString();
                    txbStock.Text = libro.Stock.ToString();                    
                    txbUrlPortada.Text = libro.UrlPortada;
                    loadImagenPortada(libro.UrlPortada);
                    txbUrlAutor.Text = libro.UrlFotoAutor;
                    loadImagenAutor(libro.UrlFotoAutor);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txbAñoPublicado_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txbStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void loadImagenPortada(string imagen)
        {
            try
            {
                pcbLibro.Load(imagen);
            }
            catch (Exception)
            {

                pcbLibro.Load("https://th.bing.com/th/id/OIP.mU5jJ2NcQFXHyq-VgQ1Q8wHaFj?rs=1&pid=ImgDetMain");
            }
        }
        private void loadImagenAutor(string imagen)
        {
            try
            {
                pcbAutor.Load(imagen);
            }
            catch (Exception)
            {
                pcbAutor.Load("https://th.bing.com/th/id/OIP.mU5jJ2NcQFXHyq-VgQ1Q8wHaFj?rs=1&pid=ImgDetMain");
            }
        }
    }
}
