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
    public partial class AgregarProductosaBodega : Form
    {
        public AgregarProductosaBodega()
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgAddProductosBodega.Rows)
                fila.Height = 28;
        }

        private void btnCerrarAgregarPdaB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSeleccionarClienteAddPd_Click(object sender, EventArgs e)
        {
            SeleccionarClienteLista scl = new SeleccionarClienteLista();
            scl.ShowDialog();
        }

        private void btnSeleccionarProductosdelCatalogo_Click(object sender, EventArgs e)
        {
            SeleccionarProductosdelCatalogo spdc = new SeleccionarProductosdelCatalogo();
            spdc.ShowDialog();
        }
    }
}
