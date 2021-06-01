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
    public partial class Contratos : Form
    {
        public Contratos()
        {
            InitializeComponent();
            btnVerEmpresas.Checked = true;
            btnVerPersonas.Checked = false;
            panelDtgContratosPersonas.Visible = false;
            panelDtgContratosEmpresas.Visible = true;
            foreach (DataGridViewRow fila in dtgContratosEmpresas.Rows)
                fila.Height = 28;
            foreach (DataGridViewRow fila in dtgContratosPersonas.Rows)
                fila.Height = 28;
        }

        private void btnVerEmpresas_Click(object sender, EventArgs e)
        {
            btnVerEmpresas.Checked = true;
            btnVerPersonas.Checked = false;
            panelDtgContratosEmpresas.Visible = true;
            panelDtgContratosPersonas.Visible = false;
        }

        private void btnVerPersonas_Click_1(object sender, EventArgs e)
        {
            btnVerPersonas.Checked = true;
            btnVerEmpresas.Checked = false;
            panelDtgContratosPersonas.Visible = true;
            panelDtgContratosEmpresas.Visible = false;
        }

        private void btnAgregarContrato_Click(object sender, EventArgs e)
        {
            AgregarContrato aggc = new AgregarContrato();
            aggc.ShowDialog();
        }

        private void btnEditarContrato_Click(object sender, EventArgs e)
        {
            EditarContrato edc = new EditarContrato();
            edc.ShowDialog();
        }

        private void btnDetallesContrato_Click(object sender, EventArgs e)
        {
            DetallesContrato dctt = new DetallesContrato();
            dctt.ShowDialog();
        }

        
    }
}
