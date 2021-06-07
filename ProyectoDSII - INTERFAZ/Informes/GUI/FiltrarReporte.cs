using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes.GUI
{
    public partial class FiltrarReporte : Form
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

        public FiltrarReporte()
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgRptEntrada.Rows)
                fila.Height = 28;
        }

        private void FiltrarReporte_Load(object sender, EventArgs e)
        {
            dtpFecha.CustomFormat = "yyyy/MM/dd";
            Cargar();
            CargarZonas();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermisos(11))
            {
                DataTable Datos = new DataTable();
                
                Datos = CacheManager.CLS.Cache.REPORTE_DE_ENTRADA(cbbSeleccionarZona.Text, dtpFecha.Text);
                REP.ReporteEntrada reporte = new REP.ReporteEntrada();
                reporte.SetDataSource(Datos);
                ReporteDeEntrada rpt = new ReporteDeEntrada();

                rpt.crvVisor.ReportSource = reporte;
                rpt.ShowDialog();                
            }
        }
    }
}
