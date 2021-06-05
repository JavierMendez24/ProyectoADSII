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

        private void Editar()
        {
            CLS.Contratos oEntidad = new CLS.Contratos();
            oEntidad.ID_Contrato = lblIDContrato.Text;
            oEntidad.ID_Cliente = txbCliente.Text;
            oEntidad.Numero_Zonas = lblNumeroZonas.Text;
            oEntidad.Costo_Arrendamiento = txbCostoArrendamiento.Text;
            oEntidad.Inicio_Arrendamiento = dtpInicio.Text;
            oEntidad.Fin_Arrendamiento = dtpFin.Text;
            oEntidad.Editar();
            oEntidad.GuardarContratoEnZona();
            Close();
        }

        private Boolean Comprobar()
        {
            Boolean Resultado = true;
            Notificador.Clear();

            if (txbCliente.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbCliente, "Este campo no puede quedar vacío");
            }
            return Resultado;
        }

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
            SeleccionarZonaContrato szc = new SeleccionarZonaContrato(this);
            szc.ShowDialog();
        }

        private void btnCancelarAddPdC_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Comprobar())
            {
                Editar();
            }
        }
    }
}
