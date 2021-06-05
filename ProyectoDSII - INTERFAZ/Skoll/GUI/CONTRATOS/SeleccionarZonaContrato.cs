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
    public partial class SeleccionarZonaContrato : Form
    {
        BindingSource _DATOSZONA = new BindingSource();

        private void CargarZonas()
        {
            
            try
            {
                _DATOSZONA.DataSource = CacheManager.CLS.Cache.TODAS_LAS_ZONAS();
                dtgZonasCatalogo.AutoGenerateColumns = false;
                dtgZonasCatalogo.DataSource = _DATOSZONA;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private AgregarContrato frmEmpleado = new AgregarContrato();
        private EditarContrato frmEmpleadoEdit = new EditarContrato();

        public SeleccionarZonaContrato(AgregarContrato parametro)
        {
            InitializeComponent();

            frmEmpleado = parametro;
        }

        public SeleccionarZonaContrato(EditarContrato parametro)
        {
            InitializeComponent();

            frmEmpleadoEdit = parametro;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SeleccionarZonaContrato_Load(object sender, EventArgs e)
        {
            CargarZonas();
        }

        private void dtgZonasCatalogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String valor;
            try
            {
                if (e.ColumnIndex == 0)
                {
                    valor = dtgZonasCatalogo.CurrentRow.Cells["IDDetalleContrato"].Value.ToString();
                    CLS.DetalleContrato Entidad = new CLS.DetalleContrato();
                    if (valor.Equals("0"))
                    {
                        //ASIGNANDO LA ZONA
                        Entidad.ID_Zona = dtgZonasCatalogo.CurrentRow.Cells["ID_Zona"].Value.ToString();
                        if (Entidad.Guardar())
                        {
                            CargarZonas();
                        }

                    }else
                    {
                        //REVOCANDO EL PERMISO
                        Entidad.ID_Detalle_Contrato = dtgZonasCatalogo.CurrentRow.Cells["IDDetalleContrato"].Value.ToString();
                        if (Entidad.Eliminar())
                        {
                            CargarZonas();
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is AgregarContrato);

            if (frm != null)
            {
                DataTable tZonas = new DataTable();

                tZonas = CacheManager.CLS.Cache.TODAS_LAS_ZONAS_SIN_CONTRATO();
                frmEmpleado.txbZonas.Text = tZonas.Rows[0]["Zonas"].ToString();
                Close();
            }
            else
            {
                DataTable tZonas = new DataTable();
                DataTable tZonasAsignadas = new DataTable();
                
                tZonas = CacheManager.CLS.Cache.TODAS_LAS_ZONAS_SIN_CONTRATO();
                tZonasAsignadas = CacheManager.CLS.Cache.TODAS_LAS_ZONAS_ASIGNADAS(frmEmpleadoEdit.lblIDContrato.Text);
                
                frmEmpleadoEdit.lblNumeroZonas.Text = tZonas.Rows[0]["Zonas"].ToString();
                frmEmpleadoEdit.txbNumeroZona.Text = tZonasAsignadas.Rows[0]["Zonas"].ToString();
                Close();
            }
            
        }
    }
}
