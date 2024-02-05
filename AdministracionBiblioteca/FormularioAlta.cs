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
        public FormularioAltaLibro()
        {
            InitializeComponent();
        }

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarAlta_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();
            Autor autor = new Autor();
            Genero genero = new Genero();
            CargarElemento cargarElemento = new CargarElemento();

            try
            {
                libro.Titulo = txbTitulo.Text;
                autor.Nombre = txbAutor.Text;
                genero.Nombre = txbGenero.Text;
                libro.AñoPublicado = int.Parse(txbAñoPublicado.Text);
                libro.Stock = int.Parse(txbStock.Text);
                autor.UrlFoto = txbUrlFoto.Text;
                libro.UrlFoto = txbUrlFoto.Text;

                cargarElemento.Agregar(libro, autor, genero);
                MessageBox.Show("El libro fue agregado exitosamente!");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
