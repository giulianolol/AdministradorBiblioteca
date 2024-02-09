using Cargarelementos;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }
        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarAlta_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();
            Autor autor = new Autor();        

            CargarElemento cargarElemento = new CargarElemento();

            try
            {
                libro.Titulo = txbTitulo.Text;
                //autor.NombreAutor = txbAutor.Text;
                libro.autor = txbAutor.Text;
                libro.Genero = txbGenero.Text;
                libro.AnioPublicacion = int.Parse(txbAñoPublicado.Text);
                libro.Stock = int.Parse(txbStock.Text);
                //autor.UrlFotoAutor = txbUrlPortada.Text;
                libro.UrlPortada = txbUrlPortada.Text;
                libro.UrlFotoAutor = txbUrlAutor.Text;

                cargarElemento.Agregar(libro);
                MessageBox.Show("El libro fue agregado exitosamente!");

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
                    txbGenero.Text = libro.Genero;
                    txbAñoPublicado.Text = libro.AnioPublicacion.ToString();
                    txbStock.Text = libro.Stock.ToString();
                    txbUrlPortada.Text = libro.UrlPortada;
                }
            }
            catch (Exception)
            {

                throw;
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
    }
}
