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
    public partial class ReportesKardex : Form
    {
        public ReportesKardex()
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgLstPdrKardex.Rows)
                fila.Height = 28;
        }

        private void cbbOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbOpciones.Text == "Por Cliente")
            {
                SeleccionarCliente sc = new SeleccionarCliente();
                sc.ShowDialog();
            }
            else if (cbbOpciones.Text == "Por Zona")
            {
                SeleccionarZona sz = new SeleccionarZona();
                sz.ShowDialog();
            }
            else
            {

            }
        }
    }
}
