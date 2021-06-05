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
        SesionManager.CLS.Sesion oSesion = SesionManager.CLS.Sesion.Instancia;

        BindingSource _DATOSE = new BindingSource();

        BindingSource _DATOSP = new BindingSource();

        private void Cargar()
        {
            if (btnVerEmpresas.Checked == true)
            {
                _DATOSE.DataSource = CacheManager.CLS.Cache.TODOS_LOS_CONTRATOS_EMPRESA();
            }
            else if (btnVerPersonas.Checked == true)
            {
                _DATOSP.DataSource = CacheManager.CLS.Cache.TODOS_LOS_CONTRATOS_PERSONA();
            }
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txbBuscarPDC.TextLength > 0)
            {
                if (btnVerEmpresas.Checked == true)
                {
                    _DATOSE.Filter = "Nombre_Empresa LIKE '%" + txbBuscarPDC.Text + "%'";
                }
                else if (btnVerPersonas.Checked == true)
                {
                    _DATOSP.Filter = "Nombres_Cliente LIKE '%" + txbBuscarPDC.Text + "%'";
                }
            }
            else
            {
                _DATOSE.RemoveFilter();
                _DATOSP.RemoveFilter();
            }
            dtgContratosEmpresas.AutoGenerateColumns = false;
            dtgContratosEmpresas.DataSource = _DATOSE;
            dtgContratosPersonas.AutoGenerateColumns = false;
            dtgContratosPersonas.DataSource = _DATOSP;
        }


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
            Cargar();
        }

        private void btnVerPersonas_Click_1(object sender, EventArgs e)
        {
            btnVerPersonas.Checked = true;
            btnVerEmpresas.Checked = false;
            panelDtgContratosPersonas.Visible = true;
            panelDtgContratosEmpresas.Visible = false;
            Cargar();
        }

        private void btnAgregarContrato_Click(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermisos(5))
            {
                AgregarContrato aggc = new AgregarContrato();
                aggc.ShowDialog();
                Cargar();
            }
            
        }

        private void btnEditarContrato_Click(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermisos(5))
            {
                if (btnVerEmpresas.Checked == true)
                {
                    if (dtgContratosEmpresas.SelectedRows.Count > 0)
                    {
                        if (dtgContratosEmpresas.SelectedRows.Count == 0)
                        {
                            MessageBox.Show("Ningún elemento seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            try
                            {
                                if (MessageBox.Show("¿Realmente desea editar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    try
                                    {

                                        string var = dtgContratosEmpresas.CurrentRow.Cells[0].Value.ToString();
                                        DataTable tContratoE = new DataTable();
                                        EditarContrato ece = new EditarContrato();
                                        DataTable tZonasAsignadas = new DataTable();

                                        tContratoE = CacheManager.CLS.Cache.SELECCIONAR_CONTRATO_EMPRESA(var);
                                        tZonasAsignadas = CacheManager.CLS.Cache.TODAS_LAS_ZONAS_ASIGNADAS(var);
                                        
                                        ece.lblIDContrato.Text = tContratoE.Rows[0]["ID_Contrato"].ToString();
                                        ece.txbCliente.Text = tContratoE.Rows[0]["Nombre_Empresa"].ToString();
                                        ece.lblNumeroZonas.Text = tContratoE.Rows[0]["Numero_Zonas"].ToString();
                                        ece.txbNumeroZona.Text = tZonasAsignadas.Rows[0]["Zonas"].ToString();
                                        ece.txbCostoArrendamiento.Text = tContratoE.Rows[0]["Costo_Arrendamiento"].ToString();
                                        ece.dtpInicio.Text = tContratoE.Rows[0]["Inicio_Arrendamiento"].ToString();
                                        ece.dtpFin.Text = tContratoE.Rows[0]["Fin_Arrendamiento"].ToString();

                                        ece.ShowDialog();
                                        Cargar();
                                    }

                                    catch(Exception ex)
                                    {
                                        MessageBox.Show("Registro no pudo ser Editado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                            catch
                            {

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay registros en esta tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (btnVerPersonas.Checked == true)
                {
                    if (dtgContratosPersonas.SelectedRows.Count > 0)
                    {
                        if (dtgContratosPersonas.SelectedRows.Count == 0)
                        {
                            MessageBox.Show("Ningún elemento seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            try
                            {
                                if (MessageBox.Show("¿Realmente desea editar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    try
                                    {
                                        string var = dtgContratosPersonas.CurrentRow.Cells[0].Value.ToString();
                                        DataTable tContratoP = new DataTable();
                                        EditarContrato ecp = new EditarContrato();
                                        DataTable tZonasAsignadas = new DataTable();

                                        tZonasAsignadas = CacheManager.CLS.Cache.TODAS_LAS_ZONAS_ASIGNADAS(var);
                                        tContratoP = CacheManager.CLS.Cache.SELECCIONAR_CONTRATO_PERSONA(var);

                                        ecp.lblIDContrato.Text = tContratoP.Rows[0]["ID_Contrato"].ToString();
                                        ecp.txbCliente.Text = tContratoP.Rows[0]["Nombres_cliente"].ToString();
                                        ecp.lblNumeroZonas.Text = tContratoP.Rows[0]["Numero_Zonas"].ToString();
                                        ecp.txbNumeroZona.Text = tZonasAsignadas.Rows[0]["Zonas"].ToString();
                                        ecp.txbCostoArrendamiento.Text = tContratoP.Rows[0]["Costo_Arrendamiento"].ToString();
                                        ecp.dtpInicio.Text = tContratoP.Rows[0]["Inicio_Arrendamiento"].ToString();
                                        ecp.dtpFin.Text = tContratoP.Rows[0]["Fin_Arrendamiento"].ToString();

                                        ecp.ShowDialog();
                                        Cargar();
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Registro no pudo ser Editado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                            catch
                            {

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay registros en esta tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            
        }

        private void btnDetallesContrato_Click(object sender, EventArgs e)
        {
            if (btnVerEmpresas.Checked == true)
            {
                if (dtgContratosEmpresas.SelectedRows.Count > 0)
                {
                    if (dtgContratosEmpresas.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Ningún elemento seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string var = dtgContratosEmpresas.CurrentRow.Cells[0].Value.ToString();

                        DataTable tContratoE = new DataTable();
                        DetallesContrato dctt = new DetallesContrato();

                        tContratoE = CacheManager.CLS.Cache.DETALLES_CONTRATO_EMPRESA(var);

                        dctt.txbIDContrato.Text = tContratoE.Rows[0]["ID_Contrato"].ToString();
                        dctt.txbCliente.Text = tContratoE.Rows[0]["Nombre_Empresa"].ToString();
                        dctt.txbNumeroZona.Text = tContratoE.Rows[0]["Numero_Zonas"].ToString();
                        dctt.txbZonas.Text = tContratoE.Rows[0]["Zonas"].ToString();
                        dctt.txbArrendamientoMensual.Text = tContratoE.Rows[0]["Costo_Arrendamiento"].ToString();
                        dctt.txbArrendamientoTotal.Text = tContratoE.Rows[0]["Costo_Total"].ToString();
                        dctt.txbInicioArrendamiento.Text = tContratoE.Rows[0]["Inicio_Arrendamiento"].ToString();
                        dctt.txbFinArrendamiento.Text = tContratoE.Rows[0]["Fin_Arrendamiento"].ToString();
                        dctt.txbDuracion.Text = tContratoE.Rows[0]["Duracion"].ToString();

                        dctt.ShowDialog();
                        Cargar();
                    }
                }
                else
                {
                    MessageBox.Show("No hay registros en esta tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (btnVerPersonas.Checked == true)
            {
                if (dtgContratosPersonas.SelectedRows.Count > 0)
                {
                    if (dtgContratosPersonas.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Ningún elemento seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string var = dtgContratosPersonas.CurrentRow.Cells[0].Value.ToString();

                        DataTable tContratoP = new DataTable();
                        DetallesContrato dcp = new DetallesContrato();

                        tContratoP = CacheManager.CLS.Cache.DETALLES_CONTRATO_PERSONA(var);

                        dcp.txbIDContrato.Text = tContratoP.Rows[0]["ID_Contrato"].ToString();
                        dcp.txbCliente.Text = tContratoP.Rows[0]["Nombres_cliente"].ToString();
                        dcp.txbNumeroZona.Text = tContratoP.Rows[0]["Numero_Zonas"].ToString();
                        dcp.txbZonas.Text = tContratoP.Rows[0]["Zonas"].ToString();
                        dcp.txbArrendamientoMensual.Text = tContratoP.Rows[0]["Costo_Arrendamiento"].ToString();
                        dcp.txbArrendamientoTotal.Text = tContratoP.Rows[0]["Costo_Total"].ToString();
                        dcp.txbInicioArrendamiento.Text = tContratoP.Rows[0]["Inicio_Arrendamiento"].ToString();
                        dcp.txbFinArrendamiento.Text = tContratoP.Rows[0]["Fin_Arrendamiento"].ToString();
                        dcp.txbDuracion.Text = tContratoP.Rows[0]["Duracion"].ToString();

                        dcp.ShowDialog();
                        Cargar();
                    }
                }
                else
                {
                    MessageBox.Show("No hay registros en esta tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Contratos_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void txbBuscarPDC_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }
    }
}
