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
    public partial class Usuarios : Form
    {

        BindingSource _DATOSUS = new BindingSource();

        private void Cargar()
        {
            _DATOSUS.DataSource = CacheManager.CLS.Cache.TODOS_LOS_USUARIOS();
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txbBuscarUsuarios.TextLength > 0)
            {
                _DATOSUS.Filter = "Usuario LIKE '%" + txbBuscarUsuarios.Text + "%'";
            }
            else
            {
                _DATOSUS.RemoveFilter();
            }
            dtgUsuarios.AutoGenerateColumns = false;
            dtgUsuarios.DataSource = _DATOSUS;
        }


        public Usuarios()
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgUsuarios.Rows)
                fila.Height = 28;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            AgregarUsuario au = new AgregarUsuario();
            au.ShowDialog();
            Cargar();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            string var = dtgUsuarios.CurrentRow.Cells[0].Value.ToString();

            DataTable tItem = new DataTable();
            EditarEmpleado ee = new EditarEmpleado();

            tItem = CacheManager.CLS.Cache.SELECCIONAR_USUARIO(var);
            ee.txbEmpleado.Text = tItem.Rows[0]["Nombres"].ToString();
            ee.txbUsuario.Text = tItem.Rows[0]["Usuario"].ToString();
            ee.txbClave.Text = tItem.Rows[0]["Clave"].ToString();
            ee.cbbSeleccionarRol.Text = tItem.Rows[0]["ID_Rol"].ToString();
            ee.lblIDUsuario.Text = tItem.Rows[0]["ID_Usuario"].ToString();
            ee.lblIDEmpleado.Text = var;
            ee.ShowDialog();
            Cargar();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void txbBuscarUsuarios_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            CLS.Usuarios oEmp = new CLS.Usuarios();

            oEmp.IDUsuario = dtgUsuarios.CurrentRow.Cells[1].Value.ToString();
            oEmp.Eliminar();
            Cargar();
        }
    }
}
