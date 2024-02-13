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
            cbxCampo.Items.Add("Titulo");
            cbxCampo.Items.Add("Autor");
            cbxCampo.Items.Add("Año Publicación");
        }
        public void cargar()
        {
            try
            {
                CargarElemento elemento = new CargarElemento();
                listalibros = elemento.Listar();
                dgvLibros.DataSource = elemento.Listar();
                ocultarColumnas();
                pcbLibro.Load(listalibros[0].UrlPortada);
                pbxFotoAutor.Load(listalibros[0].UrlFotoAutor);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        private void ocultarColumnas()
        {
            dgvLibros.Columns["libroId"].Visible = false;
            dgvLibros.Columns["UrlPortada"].Visible = false;
            dgvLibros.Columns["UrlFotoAutor"].Visible = false;
        }
        private void dgvLibros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow != null)
            {
                Libro seleccionado = (Libro)dgvLibros.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado);
                cargarImagen(seleccionado);
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
            CargarElemento cargarElemento = new CargarElemento();
            try
            { 
                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = txbFiltroAvanzado.Text;

                dgvLibros.DataSource = cargarElemento.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.ToString());
            }
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

        private void cargarImagen(Libro seleccionado)
        {      
            try
            {
                pcbLibro.Load(seleccionado.UrlPortada);
                pbxFotoAutor.Load(seleccionado.UrlFotoAutor);
            }
            catch (Exception)
            {
                pcbLibro.Load("https://th.bing.com/th/id/OIP.mU5jJ2NcQFXHyq-VgQ1Q8wHaFj?rs=1&pid=ImgDetMain");
                pbxFotoAutor.Load("https://th.bing.com/th/id/OIP.mU5jJ2NcQFXHyq-VgQ1Q8wHaFj?rs=1&pid=ImgDetMain");
            }
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {        
            List<Libro> listafiltrada;
            if (txbFiltro.Text.Length >= 3)
            {
                listafiltrada = listalibros.FindAll(x => x.Titulo.ToUpper().Contains(txbFiltro.Text.ToUpper()) || x.Autor.ToUpper().Contains(txbFiltro.Text.ToUpper()));
            }
            else
            {
                listafiltrada = listalibros;
            }

            dgvLibros.DataSource = null;
            dgvLibros.DataSource = listafiltrada;
            ocultarColumnas();
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxCampo.SelectedItem.ToString();

            if (opcion == "Año Publicacion")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Mayor a");
                cbxCriterio.Items.Add("Menor a");
                cbxCriterio.Items.Add("Igual a");
            }
            else
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Comienza con");
                cbxCriterio.Items.Add("Termina con");
                cbxCriterio.Items.Add("Contiene");
            }
        }
    }
}
