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
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgProductosaBodega.Rows)
                fila.Height = 28;
        }

        private void btnAgregaraBodega_Click(object sender, EventArgs e)
        {
            AgregarProductosaBodega apab = new AgregarProductosaBodega();
            apab.ShowDialog();
        }

        private void btnExtraerdeBodega_Click(object sender, EventArgs e)
        {
            ExtraerProductosdeBodega epdb = new ExtraerProductosdeBodega();
            epdb.ShowDialog();
        }

        private void btnSeleccionarZona_Click(object sender, EventArgs e)
        {
            Seleccionar_Zona sz = new Seleccionar_Zona();
            sz.ShowDialog();
        }
    }
}
