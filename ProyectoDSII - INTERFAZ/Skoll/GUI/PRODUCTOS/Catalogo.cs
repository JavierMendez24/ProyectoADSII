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
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgCatalogo.Rows)
                fila.Height = 28;
        }

        private void btnAñadirProductosaCatalogo_Click(object sender, EventArgs e)
        {
            AgregarProductosaCatalogo apac = new AgregarProductosaCatalogo();
            apac.ShowDialog();
        }

        private void btnEditarProductosdeCatalogo_Click(object sender, EventArgs e)
        {
            EditarProductodeCatalogo epdc = new EditarProductodeCatalogo();
            epdc.ShowDialog();
        }
    }
}
