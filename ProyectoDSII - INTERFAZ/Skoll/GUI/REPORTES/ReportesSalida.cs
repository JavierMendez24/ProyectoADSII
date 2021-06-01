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
    public partial class ReportesSalida : Form
    {
        public ReportesSalida()
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgRptSalida.Rows)
                fila.Height = 28;
        }

        private void ReportesSalida_Load(object sender, EventArgs e)
        {
            dtpBuscarFecha.CustomFormat = "yyyy/MM/dd";
        }
    }
}
