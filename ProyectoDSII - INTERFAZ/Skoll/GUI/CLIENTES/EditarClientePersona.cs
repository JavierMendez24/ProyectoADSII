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
    public partial class EditarClientePersona : Form
    {
        private void Editar()
        {
            CLS.Clientes oEntidad = new CLS.Clientes();
            oEntidad.IDCliente = lblIdCliente.Text;
            oEntidad.TipoCliente = "Persona Natural ";
            oEntidad.DUI = txbDUI.Text;
            oEntidad.Nombres = txbNombres.Text;
            oEntidad.Apellidos = txbApellidos.Text;
            oEntidad.NIT = txbNIT.Text;
            oEntidad.RazonSocial = null;
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
            if (txbNombres.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbNombres, "Este campo no puede quedar vacío");
            }
            if (txbApellidos.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbApellidos, "Este campo no puede quedar vacío");
            }
            if (txbDUI.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbDUI, "Este campo no puede quedar vacío");
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
        public EditarClientePersona()
        {
            InitializeComponent();
        }

        private void btnCerrarEditarCltPer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Comprobar())
            {
                Editar();
            }
        }
    }
}
