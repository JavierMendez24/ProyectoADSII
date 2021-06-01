using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionGeneral.GUI.PERMISOS
{
    public partial class Permisos : Form
    {
        SesionManager.CLS.Sesion oSesion = SesionManager.CLS.Sesion.Instancia;

        BindingSource _DATOSPERM = new BindingSource();

        private void CargarPermisos()
        {
            try
            {
                _DATOSPERM.DataSource = CacheManager.CLS.Cache.PERMISOS_DE_UN_ROL(cbbSeleccionarRol.SelectedValue.ToString());
                dtgPermisos.AutoGenerateColumns = false;
                dtgPermisos.DataSource = _DATOSPERM;
            }
            catch
            {
            }
        }

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


        public Permisos()
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgPermisos.Rows)
                fila.Height = 28;
        }
        
        private void Permisos_Load(object sender, EventArgs e)
        {
            CargarRoles();
            
        }

        private void cbbSeleccionarRol_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarPermisos();
        }

        private void dtgPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String valor;
            try
            {
                if (e.ColumnIndex == 0)
                {
                    valor = dtgPermisos.CurrentRow.Cells["ID_Permiso"].Value.ToString();
                    CLS.Permisos Entidad = new CLS.Permisos();
                    if (valor.Equals("0"))
                    {
                        //ASIGNANDO EL PERMISO
                        Entidad.IDOpcion = dtgPermisos.CurrentRow.Cells["ID_Opcion"].Value.ToString();
                        Entidad.IDRol = cbbSeleccionarRol.SelectedValue.ToString();
                        if (Entidad.Guardar())
                        {
                            CargarPermisos();
                        }
                        
                    }
                    else
                    {
                        //REVOCANDO EL PERMISO
                        Entidad.IDPermiso = dtgPermisos.CurrentRow.Cells["ID_Permiso"].Value.ToString();
                        if (Entidad.Eliminar())
                        {
                            CargarPermisos();
                        }
                    }
                    oSesion.CargarPermisos();
                }
            }
            catch
            {

            }
        }
    }
}
