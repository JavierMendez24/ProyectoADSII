using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skoll.GUI.REPORTES
{
    public partial class SeleccionarZona : Form
    {
        public SeleccionarZona()
        {
            InitializeComponent();
        }

        private void btnCerrarSeleccionarZonas_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelarAddZn_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
