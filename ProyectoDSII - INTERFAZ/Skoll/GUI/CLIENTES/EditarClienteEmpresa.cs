using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skoll.GUI.CLIENTES
{
    public partial class EditarClienteEmpresa : Form
    {
        private void Editar()
        {
            CLS.Clientes oEntidad = new CLS.Clientes();
            oEntidad.IDCliente = lblIdCliente.Text;
            oEntidad.TipoCliente = "Empresa";
            oEntidad.DUI = null;
            oEntidad.Nombres = null;
            oEntidad.Apellidos = null;
            oEntidad.NIT = txbNIT.Text;
            oEntidad.RazonSocial = txbNombre.Text;
            oEntidad.Telefono = txbTelefono.Text;
            oEntidad.Direccion = txbDireccion.Text;
            oEntidad.Correo = txbCorreo.Text;
            oEntidad.Editar();
            Close();
        }

        private Boolean Comprobar()
        {
            Boolean Resultado = true;
            Notificador.Clear();
            if (txbNombre.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbNombre, "Este campo no puede quedar vacío");
            }
            if (txbNIT.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbNIT, "Este campo no puede quedar vacío");
            }
            if (txbDireccion.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbDireccion, "Este campo no puede quedar vacío");
            }
            if (txbTelefono.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbTelefono, "Este campo no puede quedar vacío");
            }
            return Resultado;
        }
        public EditarClienteEmpresa()
        {
            InitializeComponent();
        }

        private void btnCerrarEditarCltEmp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Comprobar())
            {
                Editar();
                MessageBox.Show("Registro Editado Correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
