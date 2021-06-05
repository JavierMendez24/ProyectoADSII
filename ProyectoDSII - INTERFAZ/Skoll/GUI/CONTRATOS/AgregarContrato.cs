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

        private void Agregar()
        {
            DataTable dContrato = new DataTable();

            CLS.Contratos oEntidad = new CLS.Contratos();
            
            oEntidad.ID_Cliente = txbCliente.Text;
            oEntidad.Numero_Zonas = txbZonas.Text;
            oEntidad.Costo_Arrendamiento = txbCostoArrendamiento.Text;
            oEntidad.Inicio_Arrendamiento = dtpInicio.Text;
            oEntidad.Fin_Arrendamiento = dtpFin.Text;
            oEntidad.Tipo_Contrato = cbbSeleccionarTipoContrato.Text;
            oEntidad.Guardar();

            dContrato = CacheManager.CLS.Cache.CONTRATO_ACTUAL();

            oEntidad.ID_Contrato = dContrato.Rows[0]["ID_Contrato"].ToString();
            oEntidad.GuardarContratoEnZona();

            Close();

            MessageBox.Show("Registro Agregado Correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Boolean Comprobar()
        {
            Boolean Resultado = true;
            Notificador.Clear();

            if (txbCostoArrendamiento.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbCostoArrendamiento, "Este campo no puede quedar vacío");
            }

            return Resultado;
        }


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
            SeleccionarClienteContrato scctt = new SeleccionarClienteContrato(this);
            scctt.ShowDialog();
        }

        private void btnSeleccionarZonasContrato_Click(object sender, EventArgs e)
        {
            SeleccionarZonaContrato szctt = new SeleccionarZonaContrato(this);
            szctt.ShowDialog();
        }

        private void AgregarContrato_Load(object sender, EventArgs e)
        {
            dtpInicio.CustomFormat = "yyyy/MM/dd";
            dtpFin.CustomFormat = "yyyy/MM/dd";
        }

        private void btnCancelarAddPdC_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Comprobar())
            {
                Agregar();
            }
        }
    }
}
