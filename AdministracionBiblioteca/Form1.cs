using Cargarelementos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

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
            cargar();
        }
        public void cargar()
        {
            try
            {
                CargarElemento elemento = new CargarElemento();
                listalibros = elemento.Listar();
                dgvLibros.DataSource = elemento.Listar();
                dgvLibros.Columns["libroId"].Visible = false;
                dgvLibros.Columns["UrlPortada"].Visible = false;
                dgvLibros.Columns["UrlFotoAutor"].Visible = false;
                //pbxFotoAutor.Load(listalibros[0].autor.UrlFotoAutor);
                pcbLibro.Load(listalibros[0].UrlPortada);
                pbxFotoAutor.Load(listalibros[0].UrlFotoAutor);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void dgvLibros_SelectionChanged(object sender, EventArgs e)
        {
            Libro seleccionado = (Libro)dgvLibros.CurrentRow.DataBoundItem;
            try
            {
                pcbLibro.Load(seleccionado.UrlPortada);
                pbxFotoAutor.Load(seleccionado.UrlFotoAutor);
            }
            catch(Exception)
            {
                pcbLibro.Load("https://th.bing.com/th/id/OIP.mU5jJ2NcQFXHyq-VgQ1Q8wHaFj?rs=1&pid=ImgDetMain");
                pbxFotoAutor.Load("https://th.bing.com/th/id/OIP.mU5jJ2NcQFXHyq-VgQ1Q8wHaFj?rs=1&pid=ImgDetMain");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormularioAltaLibro alta = new FormularioAltaLibro();
            alta.ShowDialog();
            CargarElemento elemento = new CargarElemento();
            listalibros = elemento.Listar();
            dgvLibros.DataSource = elemento.Listar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            CargarElemento elemento = new CargarElemento();
            Libro seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Segúro queres eliminar este libro?", "Eliminar",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes) 
                {
                    seleccionado = (Libro)dgvLibros.CurrentRow.DataBoundItem;
                    elemento.Eliminar(seleccionado.LibroId);
                    cargar();
                }                
            }
            catch (Exception)
            {

                throw;
            }           
        }

        private void btnModificarLibro_Click(object sender, EventArgs e)
        {
            Libro seleccionado;
            seleccionado = (Libro)dgvLibros.CurrentRow.DataBoundItem;

            FormularioAltaLibro modificar = new FormularioAltaLibro(seleccionado);
            modificar.ShowDialog();

            cargar();
        }
    }
}
