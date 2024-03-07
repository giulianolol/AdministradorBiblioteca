using Accesodatos;
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
        public AdministracionRecursosInterfaz()
        {
            InitializeComponent();
        }

        private void AdministracionRecursosInterfaz_Load(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();

            datos.SetQuery("select id, dia, cantidad, descripcion, tipo from MovimientosDinero");
            datos.executeRead();


        }
    }
}
