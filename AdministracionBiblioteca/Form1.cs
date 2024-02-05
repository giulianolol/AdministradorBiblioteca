using Cargarelementos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AdministracionBiblioteca
{
    public partial class Form1 : Form
    {
        List<Libro> listalibros = new List<Libro>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cuando el formulario se carga, con estas lineas de comando primero creamos un nuevo objeto de tipo CargarElemento que lo usamos para poder acceder al metodo Listar()
            CargarElemento elemento = new CargarElemento();
            listalibros = elemento.Listar();
            dgvLibros.DataSource = elemento.Listar();

            //En este fragmento configuramos las columnas que queremos que no se vean
            dgvLibros.Columns["UrlImagen"].Visible = false;
            dgvLibros.Columns["GeneroID"].Visible = false;
            dgvLibros.Columns["AutorID"].Visible = false;
            dgvLibros.Columns["UrlFoto"].Visible = false;

            pbxFotoAutor.Load(listalibros[0].UrlFoto);
            pcbLibro.Load(listalibros[0].UrlImagen);
        }

        private void dgvLibros_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Libro seleccionado = (Libro)dgvLibros.CurrentRow.DataBoundItem;
                pcbLibro.Load(seleccionado.UrlImagen);
            }
            catch (Exception ex)
            {

                pcbLibro.Load("https://th.bing.com/th/id/OIP.mU5jJ2NcQFXHyq-VgQ1Q8wHaFj?rs=1&pid=ImgDetMain");
            }
            try
            {
                Libro seleccionado = (Libro)dgvLibros.CurrentRow.DataBoundItem;
                pbxFotoAutor.Load(seleccionado.UrlFoto);
            }
            catch (Exception ex)
            {

                pcbLibro.Load("https://th.bing.com/th/id/OIP.mU5jJ2NcQFXHyq-VgQ1Q8wHaFj?rs=1&pid=ImgDetMain");
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormularioAltaLibro alta = new FormularioAltaLibro();
            alta.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
