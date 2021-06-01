using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skoll.GUI.CLIENTES
{
    public partial class Clientes : Form
    {
        SesionManager.CLS.Sesion oSesion = SesionManager.CLS.Sesion.Instancia;

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
                else if(btnVerPersonas.Checked == true)
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
        public Clientes()
        {
            InitializeComponent();
            btnVerEmpresas.Checked = true;
            btnVerPersonas.Checked = false;
            panelDtgClientesPersonas.Visible = false;
            panelDtgClientesEmpresas.Visible = true;
            foreach (DataGridViewRow fila in dtgClientesEmpresas.Rows)
                fila.Height = 28;
            foreach (DataGridViewRow fila in dtgClientesPersonas.Rows)
                fila.Height = 28;
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

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermisos(3))
            {
                AgregarCliente ac = new AgregarCliente();
                ac.ShowDialog();
                Cargar();
            }
            
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermisos(3))
            {
                EditarClienteEmpresa ece = new EditarClienteEmpresa();
                ece.ShowDialog();
            }
            
        }

        private void btnDetallesCliente_Click(object sender, EventArgs e)
        {
            DetallesClientePersona dcp = new DetallesClientePersona();
            dcp.ShowDialog();
        }

        private void txbBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermisos(3))
            {
                // CODIGO DE ELIMINAR AQUI
            }
        }
    }
}
