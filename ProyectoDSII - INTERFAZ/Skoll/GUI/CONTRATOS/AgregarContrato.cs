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
    public partial class AgregarContrato : Form
    {
        public AgregarContrato()
        {
            InitializeComponent();
        }

        private void btnCloseAddContract_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSeleccionarClienteContrato_Click(object sender, EventArgs e)
        {
            SeleccionarClienteContrato scctt = new SeleccionarClienteContrato();
            scctt.ShowDialog();
        }

        private void btnSeleccionarZonasContrato_Click(object sender, EventArgs e)
        {
            SeleccionarZonasContrato szctt = new SeleccionarZonasContrato();
            szctt.ShowDialog();
        }

        private void AgregarContrato_Load(object sender, EventArgs e)
        {
            dtpInicio.CustomFormat = "yyyy/MM/dd";
            dtpFin.CustomFormat = "yyyy/MM/dd";
        }
    }
}
