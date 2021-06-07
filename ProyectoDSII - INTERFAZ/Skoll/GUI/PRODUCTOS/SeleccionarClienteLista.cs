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
    public partial class SeleccionarClienteLista : Form
    {
        AgregarProductosaBodega apb = new AgregarProductosaBodega();

        BindingSource _DATOSCONT = new BindingSource();

        private void Cargar()
        {
            _DATOSCONT.DataSource = CacheManager.CLS.Cache.SELECCIONAR_CONTRATO_LISTA();
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txbBuscarPDC.TextLength > 0)
            {
                _DATOSCONT.Filter = "Cliente LIKE '%" + txbBuscarPDC.Text + "%'";
            }
            else
            {
                _DATOSCONT.RemoveFilter();
            }
            dtgSelecCliente.AutoGenerateColumns = false;
            dtgSelecCliente.DataSource = _DATOSCONT;
        }

        /*
        private void CargarZonas()
        {
            DataTable Zonas = new DataTable();
            try
            {
                Zonas = CacheManager.CLS.Cache.TODAS_LAS_ZONAS_DEL_CONTRATO(dtgSelecCliente.CurrentRow.Cells[0].Value.ToString());
                apb.cbbSeleccionarZonaCtg.DataSource = Zonas;
                apb.cbbSeleccionarZonaCtg.DisplayMember = "Nombre_Zona";
                apb.cbbSeleccionarZonaCtg.ValueMember = "ID_Zona";
            }
            catch
            {
                Zonas = new DataTable();
            }
            Close();
        }
        */

        private AgregarProductosaBodega frmContrato = new AgregarProductosaBodega();
        private ExtraerProductosdeBodega frmContratoEx = new ExtraerProductosdeBodega();

        public SeleccionarClienteLista(AgregarProductosaBodega parametro)
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgSelecCliente.Rows)
                fila.Height = 28;

            frmContrato = parametro;
        }

        public SeleccionarClienteLista(ExtraerProductosdeBodega parametro)
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgSelecCliente.Rows)
                fila.Height = 28;

            frmContratoEx = parametro;
        }

        private void btnCerrarSCL_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelarAddPdC_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Zonas = new DataTable();

                frmContrato.lblIDContrato.Text = dtgSelecCliente.CurrentRow.Cells[0].Value.ToString();
                Zonas = CacheManager.CLS.Cache.TODAS_LAS_ZONAS_DEL_CONTRATO(dtgSelecCliente.CurrentRow.Cells[0].Value.ToString());
                frmContrato.cbbSeleccionarZonaCtg.DataSource = Zonas;
                frmContrato.cbbSeleccionarZonaCtg.DisplayMember = "Nombre_Zona";
                frmContrato.cbbSeleccionarZonaCtg.ValueMember = "ID_Zona";

                frmContrato.txbContrato.Text = dtgSelecCliente.CurrentRow.Cells[1].Value.ToString();
            }
            catch(Exception ex)
            {
                
            }
            Close();
        }

        private void SeleccionarClienteLista_Load(object sender, EventArgs e)
        {
            Cargar();
            
        }
    }
}
