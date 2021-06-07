using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skoll.GUI.REPORTES
{
    public partial class ReportesEntrada : Form
    {
        SesionManager.CLS.Sesion oSesion = SesionManager.CLS.Sesion.Instancia;

        BindingSource _DATOSM = new BindingSource();

        private void Cargar()
        {
            _DATOSM.DataSource = CacheManager.CLS.Cache.DATOS_MOVIMIENTO_ENTRADA();
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            
            dtgRptEntrada.AutoGenerateColumns = false;
            dtgRptEntrada.DataSource = _DATOSM;
        }

        private void CargarZonas()
        {
            DataTable Zonas = new DataTable();
            try
            {
                Zonas = CacheManager.CLS.Cache.TODAS_LAS_ZONAS_REPORTE();
                cbbSeleccionarZona.DataSource = Zonas;
                cbbSeleccionarZona.DisplayMember = "Nombre_Zona";
                cbbSeleccionarZona.ValueMember = "ID_Zona";

            }
            catch
            {
                Zonas = new DataTable();
            }

        }

        public ReportesEntrada()
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgRptEntrada.Rows)
                fila.Height = 28;
        }

        private void ReportesEntrada_Load(object sender, EventArgs e)
        {
            dtpSeleccionarFecha.CustomFormat = "yyyy/MM/dd";
            Cargar();
            CargarZonas();
        }

        private void btnGenerarReporteEntrada_Click(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermisos(11))
            {
                try
                {
                    DataTable Datos = new DataTable();
                    Datos = CacheManager.CLS.Cache.REPORTE_DE_ENTRADA(cbbSeleccionarZona.Text, dtpSeleccionarFecha.Text);
                    Informes.REP.ReporteEntrada Reporte = new Informes.REP.ReporteEntrada();

                    Reporte.SetDataSource(Datos);
                    crvVisor.ReportSource = Reporte;
                }
                catch(Exception ex)
                {

                }
            }
        }
    }
}
