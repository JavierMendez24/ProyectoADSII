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
    public partial class EditarRol : Form
    {

        private void Editar()
        {
            CLS.Roles oRol = new CLS.Roles();
            oRol.IDRol = txbIDRol.Text;
            oRol.Rol = txbRol.Text;
            oRol.Editar();
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


        public EditarRol()
        {
            InitializeComponent();
        }

        private void btnCancelEditRol_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCloseEditRol_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveEditRol_Click(object sender, EventArgs e)
        {
            if (Comprobar())
            {
                Editar();
            }
        }
    }
}
