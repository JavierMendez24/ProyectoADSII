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
    public partial class ExtraerProductosdeBodega : Form
    {
        public ExtraerProductosdeBodega()
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgExtProductosBodega.Rows)
                fila.Height = 28;
        }

        private void btnSeleccionarClienteDltPd_Click(object sender, EventArgs e)
        {
            SeleccionarClienteLista scl = new SeleccionarClienteLista();
            scl.ShowDialog();
        }

        private void btnSeleccionarProductosdelCatalogo_Click(object sender, EventArgs e)
        {
            SeleccionarProductosdelCatalogo spdc = new SeleccionarProductosdelCatalogo();
            spdc.ShowDialog();
        }

        private void btnCerrarExtraerPddB_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
