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
    public partial class SeleccionarClienteContrato : Form
    {
        BindingSource _DATOSE = new BindingSource();

        BindingSource _DATOSP = new BindingSource();

        private void Cargar()
        {
            if (btnVerEmpresas.Checked == true)
            {
                _DATOSE.DataSource = CacheManager.CLS.Cache.TODOS_LOS_CLIENTES_EMPRESA();
            }
            else if (btnVerPersonas.Checked == true)
            {
                _DATOSP.DataSource = CacheManager.CLS.Cache.TODOS_LOS_CLIENTES_PERSONA();
            }
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txbBuscarClientes.TextLength > 0)
            {
                if (btnVerEmpresas.Checked == true)
                {
                    _DATOSE.Filter = "Nombre_Empresa LIKE '%" + txbBuscarClientes.Text + "%'";
                }
                else if (btnVerPersonas.Checked == true)
                {
                    _DATOSP.Filter = "Nombres_Cliente LIKE '%" + txbBuscarClientes.Text + "%'";
                }
            }
            else
            {
                _DATOSE.RemoveFilter();
                _DATOSP.RemoveFilter();
            }
            dtgClientesEmpresas.AutoGenerateColumns = false;
            dtgClientesEmpresas.DataSource = _DATOSE;
            dtgClientesPersonas.AutoGenerateColumns = false;
            dtgClientesPersonas.DataSource = _DATOSP;
        }

        private AgregarContrato frmEmpleado;

        public SeleccionarClienteContrato(AgregarContrato parametro)
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgClientesEmpresas.Rows)
                fila.Height = 28;
            foreach (DataGridViewRow fila in dtgClientesPersonas.Rows)
                fila.Height = 28;
            btnVerEmpresas.Checked = true;
            btnVerPersonas.Checked = false;
            panelDtgClientesPersonas.Visible = false;
            panelDtgClientesEmpresas.Visible = true;

            frmEmpleado = parametro;
        }

        private void btnSeleccionarClienteCtt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelarSeleccionarClt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerEmpresas_Click(object sender, EventArgs e)
        {
            btnVerEmpresas.Checked = true;
            btnVerPersonas.Checked = false;
            panelDtgClientesEmpresas.Visible = true;
            panelDtgClientesPersonas.Visible = false;
            Cargar();
        }

        private void btnVerPersonas_Click(object sender, EventArgs e)
        {
            btnVerPersonas.Checked = true;
            btnVerEmpresas.Checked = false;
            panelDtgClientesPersonas.Visible = true;
            panelDtgClientesEmpresas.Visible = false;
            Cargar();
        }

        private void btnCancelarSeleccionarClt_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void txbBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void SeleccionarClienteContrato_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAceptarSeleccionarClt_Click(object sender, EventArgs e)
        {
            if (btnVerEmpresas.Checked == true)
            {
                frmEmpleado.txbCliente.Text = dtgClientesEmpresas.CurrentRow.Cells[0].Value.ToString();
            }
            else if (btnVerPersonas.Checked == true)
            {
                frmEmpleado.txbCliente.Text = dtgClientesPersonas.CurrentRow.Cells[0].Value.ToString();
            }
            Close();
        }
    }
}
