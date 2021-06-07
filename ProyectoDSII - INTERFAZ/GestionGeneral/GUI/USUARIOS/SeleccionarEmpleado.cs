using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionGeneral.GUI.USUARIOS
{
    public partial class SeleccionarEmpleado : Form
    {
        

        BindingSource _DATOSUSEMP = new BindingSource();

        private void Cargar()
        {
            _DATOSUSEMP.DataSource = CacheManager.CLS.Cache.TODOS_LOS_EMPLEADOS();
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txbBuscarUsEmpleado.TextLength > 0)
            {
                _DATOSUSEMP.Filter = "Nombres LIKE '%" + txbBuscarUsEmpleado.Text + "%'";
            }
            else
            {
                _DATOSUSEMP.RemoveFilter();
            }
            dtgSeleccionarEmpleados.AutoGenerateColumns = false;
            dtgSeleccionarEmpleados.DataSource = _DATOSUSEMP;
        }

        private EditarEmpleado frmEmpleadoEdit;
        private AgregarUsuario frmEmpleado;

        public SeleccionarEmpleado(EditarEmpleado parametro)
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgSeleccionarEmpleados.Rows)
                fila.Height = 28;

            frmEmpleadoEdit = parametro;
        }

        public SeleccionarEmpleado(AgregarUsuario parametro)
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgSeleccionarEmpleados.Rows)
                fila.Height = 28;

            frmEmpleado = parametro;
        }

        private void btnCerrarSelecEmp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelarEmpleadoSeleccionado_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SeleccionarEmpleado_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void txbBuscarUsEmpleado_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnAceptarEmpleadoSeleccionado_Click(object sender, EventArgs e)
        {
            try { 
                frmEmpleado.txbEmpleado.Text = dtgSeleccionarEmpleados.CurrentRow.Cells[0].Value.ToString();
            }
            catch
            {
                frmEmpleadoEdit.txbEmpleado.Text = dtgSeleccionarEmpleados.CurrentRow.Cells[0].Value.ToString();
            }
            Close();
        }
    }
}
