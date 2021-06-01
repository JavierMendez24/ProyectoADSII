using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionGeneral.GUI.EMPLEADOS
{
    public partial class Empleados : Form
    {
        BindingSource _DATOSEMP = new BindingSource();

        private void Cargar()
        {
            _DATOSEMP.DataSource = CacheManager.CLS.Cache.TODOS_LOS_EMPLEADOS();
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txbBuscarEmpleados.TextLength > 0)
            {
                _DATOSEMP.Filter = "Nombres LIKE '%" + txbBuscarEmpleados.Text + "%'";
            }
            else
            {
                _DATOSEMP.RemoveFilter();
            }
            dtgEmpleados.AutoGenerateColumns = false;
            dtgEmpleados.DataSource = _DATOSEMP;
        } 

        public Empleados()
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgEmpleados.Rows)
                fila.Height = 28;
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            AgregarEmpleado ae = new AgregarEmpleado();
            ae.ShowDialog();
            Cargar();
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            string var = dtgEmpleados.CurrentRow.Cells[0].Value.ToString();

            DataTable tEmpleado = new DataTable();
            EditarEmpleado ee = new EditarEmpleado();
            
            tEmpleado = CacheManager.CLS.Cache.SELECCIONAR_EMPLEADO(var);
            ee.lblIDEmpleado.Text = tEmpleado.Rows[0]["ID_Empleado"].ToString();
            ee.txbNombres.Text = tEmpleado.Rows[0]["Nombres"].ToString();
            ee.txbApellidos.Text = tEmpleado.Rows[0]["Apellidos"].ToString();
            ee.txbDUI.Text = tEmpleado.Rows[0]["DUI"].ToString();
            ee.txbNIT.Text = tEmpleado.Rows[0]["NIT"].ToString();
            ee.dtpFechaNac.Text = tEmpleado.Rows[0]["FechaNacimiento"].ToString();
            ee.cbbSeleccionarGenero.Text = tEmpleado.Rows[0]["Genero"].ToString();
            ee.txbTelefono.Text = tEmpleado.Rows[0]["Telefono"].ToString();
            ee.txbDireccion.Text = tEmpleado.Rows[0]["Direccion"].ToString();
            ee.txbCorreo.Text = tEmpleado.Rows[0]["Correo"].ToString();

            ee.ShowDialog();
            Cargar();
        }

        private void btnDetallesEmpleado_Click(object sender, EventArgs e)
        {
            string var = dtgEmpleados.CurrentRow.Cells[0].Value.ToString();

            DataTable tEmpleado = new DataTable();
            DetallesEmpleado de = new DetallesEmpleado();

            tEmpleado = CacheManager.CLS.Cache.SELECCIONAR_EMPLEADO(var);
            de.txbIDEmpleado.Text = tEmpleado.Rows[0]["ID_Empleado"].ToString();
            de.txbNombres.Text = tEmpleado.Rows[0]["Nombres"].ToString();
            de.txbApellidos.Text = tEmpleado.Rows[0]["Apellidos"].ToString();
            de.txbDUI.Text = tEmpleado.Rows[0]["DUI"].ToString();
            de.txbNIT.Text = tEmpleado.Rows[0]["NIT"].ToString();
            de.txbFechaNac.Text = tEmpleado.Rows[0]["FechaNacimiento"].ToString();
            de.txbGenero.Text = tEmpleado.Rows[0]["Genero"].ToString();
            de.txbTelefono.Text = tEmpleado.Rows[0]["Telefono"].ToString();
            de.txbDireccion.Text = tEmpleado.Rows[0]["Direccion"].ToString();
            de.txbCorreo.Text = tEmpleado.Rows[0]["Correo"].ToString();

            de.ShowDialog();
            Cargar();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void txbBuscarEmpleados_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            CLS.Empleados oEmp = new CLS.Empleados();

            oEmp.IDEmpleado = dtgEmpleados.CurrentRow.Cells[0].Value.ToString();
            oEmp.Eliminar();
            Cargar();
        }
    }
}
