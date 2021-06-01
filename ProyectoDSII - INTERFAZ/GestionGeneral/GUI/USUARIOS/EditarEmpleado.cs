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
    public partial class EditarEmpleado : Form
    {

        private void CargarRoles()
        {
            DataTable Roles = new DataTable();
            try
            {
                Roles = CacheManager.CLS.Cache.TODOS_LOS_ROLES();
                cbbSeleccionarRol.DataSource = Roles;
                cbbSeleccionarRol.DisplayMember = "Rol";
                cbbSeleccionarRol.ValueMember = "ID_Rol";
            }
            catch
            {
                Roles = new DataTable();
            }

        }

        private void Editar()
        {
            CLS.Usuarios oUsu = new CLS.Usuarios();
            oUsu.IDUsuario = lblIDUsuario.Text;
            oUsu.IDEmpleado = txbEmpleado.Text;
            oUsu.Usuario = txbUsuario.Text;
            oUsu.Clave = txbClave.Text;
            oUsu.IDRol = cbbSeleccionarRol.SelectedValue.ToString();
            oUsu.Editar();
            Close();
        }

        private Boolean Comprobar()
        {
            Boolean Resultado = true;
            Notificador.Clear();

            if (txbEmpleado.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbEmpleado, "Este campo no puede quedar vacío");
            }
            if (txbUsuario.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbUsuario, "Este campo no puede quedar vacío");
            }
            if (txbClave.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbClave, "Este campo no puede quedar vacío");
            }
            return Resultado;
        }



        public EditarEmpleado()
        {
            InitializeComponent();
        }

        private void btnCancelEditUser_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCloseEditUser_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditarEmpleado_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (Comprobar())
            {
                Editar();
            }
        }

        private void btnSeleccionarEmpleado_Click(object sender, EventArgs e)
        {
            SeleccionarEmpleado se = new SeleccionarEmpleado(this);
            se.ShowDialog();
        }
    }
}
