using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skoll.GUI.CONTRATOS
{
    public partial class SeleccionarClienteContrato : Form
    {
        public SeleccionarClienteContrato()
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgClienteCatalogo.Rows)
                fila.Height = 28;
        }

        private void btnSeleccionarClienteCtt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
