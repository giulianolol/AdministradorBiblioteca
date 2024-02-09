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
    public partial class Formulario_Eliminar : Form
    {
        List<Libro> listalibros = new List<Libro>();
        public Formulario_Eliminar()
        {
            InitializeComponent();
        }

        private void Formulario_Eliminar_Load(object sender, EventArgs e)
        {
            Libro libro = new Libro();
            

            try
            {
                CargarElemento cargarElemento = new CargarElemento();

                listalibros = cargarElemento.Listar();
                dgvLibros.DataSource = listalibros;

                dgvLibros.Columns["genero"].Visible= false;
                dgvLibros.Columns["UrlPortada"].Visible = false;
                dgvLibros.Columns["AnioPublicacion"].Visible = false;
                dgvLibros.Columns["Stock"].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnEliminarBaja_Click(object sender, EventArgs e)
        {
            //Close();
        }

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
