using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionGeneral.GUI.ROLES
{
    public partial class Roles : Form
    {
        BindingSource _DATOSROL = new BindingSource();

        private void Cargar()
        {
            _DATOSROL.DataSource = CacheManager.CLS.Cache.TODOS_LOS_ROLES();
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txbBuscarRol.TextLength > 0)
            {
                _DATOSROL.Filter = "Rol LIKE '%" + txbBuscarRol.Text + "%'";
            }
            else
            {
                _DATOSROL.RemoveFilter();
            }
            dtgRoles.AutoGenerateColumns = false;
            dtgRoles.DataSource = _DATOSROL;
        }


        public Roles()
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgRoles.Rows)
                fila.Height = 28;
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            AgregarRol ar = new AgregarRol();
            ar.ShowDialog();
            Cargar();
        }

        private void btnEditarRol_Click(object sender, EventArgs e)
        {
            string var = dtgRoles.CurrentRow.Cells[0].Value.ToString();

            DataTable tEmpleado = new DataTable();
            EditarRol er = new EditarRol();

            tEmpleado = CacheManager.CLS.Cache.SELECCIONAR_ROL(var);
            er.txbIDRol.Text = var;
            er.txbRol.Text = tEmpleado.Rows[0]["Rol"].ToString();

            er.ShowDialog();
            Cargar();
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void txbBuscarRol_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            CLS.Roles oUsu = new CLS.Roles();

            oUsu.IDRol = dtgRoles.CurrentRow.Cells[0].Value.ToString();
            oUsu.Eliminar();
            Cargar();
        }
    }
}
