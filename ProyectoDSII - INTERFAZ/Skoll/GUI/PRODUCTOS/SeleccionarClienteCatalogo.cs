using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skoll.GUI.PRODUCTOS
{
    public partial class SeleccionarClienteCatalogo : Form
    {
        public SeleccionarClienteCatalogo()
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgClienteCatalogo.Rows)
                fila.Height = 28;
        }

        private void btnSeleccionarClienteCt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
