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
    public partial class AgregarUsuario : Form
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

        private void Agregar()
        {
            CLS.Usuarios oUsu = new CLS.Usuarios();
            oUsu.IDEmpleado = txbEmpleado.Text;
            oUsu.Usuario = txbUsuario.Text;
            oUsu.Clave = txbClave.Text;
            oUsu.IDRol = cbbSeleccionarRol.SelectedValue.ToString();
            oUsu.Guardar();
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


        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelAddUser_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCloseAddUser_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSeleccionarEmpleado_Click(object sender, EventArgs e)
        {
            SeleccionarEmpleado se = new SeleccionarEmpleado(this);
            se.ShowDialog();
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (Comprobar())
            {
                Agregar();
            }
        }
    }
}
