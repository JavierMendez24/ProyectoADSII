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
    public partial class EditarContrato : Form
    {
        public EditarContrato()
        {
            InitializeComponent();
        }

        private void btnCloseEditContract_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditarContrato_Load(object sender, EventArgs e)
        {
            dtpInicio.CustomFormat = "yyyy/MM/dd";
            dtpFin.CustomFormat = "yyyy/MM/dd";
        }

        private void btnSeleccionarZona_Click(object sender, EventArgs e)
        {
            SeleccionarZonaContrato szc = new SeleccionarZonaContrato();
            szc.ShowDialog();
        }

        private void btnCancelarAddPdC_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
