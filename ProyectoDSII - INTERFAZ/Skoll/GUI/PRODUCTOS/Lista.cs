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
    public partial class Lista : Form
    {
        SesionManager.CLS.Sesion oSesion = SesionManager.CLS.Sesion.Instancia;

        BindingSource _DATOSP = new BindingSource();

        private void Cargar()
        {
            _DATOSP.DataSource = CacheManager.CLS.Cache.PRODUCTOS_LISTA_BODEGA();
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txbNombreZona.TextLength > 0)
            {
                _DATOSP.Filter = "Nombre_Producto LIKE '%" + txbNombreZona.Text + "%'";
            }
            else
            {
                _DATOSP.RemoveFilter();
            }
            dtgProductosaBodega.AutoGenerateColumns = false;
            dtgProductosaBodega.DataSource = _DATOSP;
        }

        public Lista()
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgProductosaBodega.Rows)
                fila.Height = 28;
        }

        private void btnAgregaraBodega_Click(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermisos(9))
            {
                try
                {
                    AgregarProductosaBodega apab = new AgregarProductosaBodega();
                    apab.ShowDialog();
                    Cargar();
                }
                catch
                {
                    MessageBox.Show("No se pudo Agregar el Registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            
        }

        private void btnExtraerdeBodega_Click(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermisos(9))
            {
                ExtraerProductosdeBodega epdb = new ExtraerProductosdeBodega();
                epdb.ShowDialog();
            }
            
        }

        private void btnSeleccionarZona_Click(object sender, EventArgs e)
        {
            Seleccionar_Zona sz = new Seleccionar_Zona();
            sz.ShowDialog();
        }

        private void Lista_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
