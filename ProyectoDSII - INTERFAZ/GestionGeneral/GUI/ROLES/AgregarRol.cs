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
    public partial class AgregarRol : Form
    {

        private void Agregar()
        {
            CLS.Roles oRol = new CLS.Roles();
            oRol.Rol = txbRol.Text;
            oRol.Guardar();
            Close();
        }

        private Boolean Comprobar()
        {
            Boolean Resultado = true;
            Notificador.Clear();

            if (txbRol.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbRol, "Este campo no puede quedar vacío");
            }
            return Resultado;
        }


        public AgregarRol()
        {
            InitializeComponent();
        }

        private void btnCancelAddRol_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCloseAddRol_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddRol_Click(object sender, EventArgs e)
        {
            if (Comprobar())
            {
                Agregar();
            }
        }
    }
}
