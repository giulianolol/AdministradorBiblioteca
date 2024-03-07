using Accesodatos;
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

namespace AdministracionDinero
{
    public partial class AdministracionRecursosInterfaz : Form
    {
        List<Movimiento> listaMovimientos = new List<Movimiento>();
        public AdministracionRecursosInterfaz()
        {
            InitializeComponent();
        }

        private void AdministracionRecursosInterfaz_Load(object sender, EventArgs e)
        {
            try
            {
                CargarElemento elemento = new CargarElemento();
                listaMovimientos = elemento.ListarMovimientos();
                dgvMovmientos.DataSource = elemento.ListarMovimientos();
                dgvMovmientos.Columns["id"].Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
