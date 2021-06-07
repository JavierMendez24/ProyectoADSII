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
    public partial class AgregarCliente : Form
    {
        private void Agregar()
        {
            CLS.Clientes oEntidad = new CLS.Clientes();

            if (cbbSeleccionarTipoCliente.Text == "Empresa")
            {
                oEntidad.TipoCliente = cbbSeleccionarTipoCliente.Text;
                oEntidad.DUI = null;
                oEntidad.Nombres = null;
                oEntidad.Apellidos = null;
                oEntidad.NIT = txbNIT.Text;
                oEntidad.RazonSocial = txbNombreEmpresa.Text;
                oEntidad.Telefono = txbTelefono.Text;
                oEntidad.Direccion = txbDireccion.Text;
                oEntidad.Correo = txbCorreo.Text;
                oEntidad.Guardar();
                Close();
            }
            else if (cbbSeleccionarTipoCliente.Text == "Persona Natural")
            {
                oEntidad.TipoCliente = cbbSeleccionarTipoCliente.Text;
                oEntidad.DUI = txbDUI.Text;
                oEntidad.Nombres = txbNombres.Text;
                oEntidad.Apellidos = txbApellidos.Text;
                oEntidad.NIT = txbNIT.Text;
                oEntidad.RazonSocial = null;
                oEntidad.Telefono = txbTelefono.Text;
                oEntidad.Direccion = txbDireccion.Text;
                oEntidad.Correo = txbCorreo.Text;
                oEntidad.Guardar();
                Close();
            }
            MessageBox.Show("Registro Agregado Correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Boolean Comprobar()
        {
            Boolean Resultado = true;
            Notificador.Clear();
            if (cbbSeleccionarTipoCliente.Text == "Empresa")
            {
                if (txbNombreEmpresa.TextLength == 0)
                {
                    Resultado = false;
                    Notificador.SetError(txbNombreEmpresa, "Este campo no puede quedar vacío");
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
            }
            else if (cbbSeleccionarTipoCliente.Text == "Persona Natural")
            {
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
            }   
            return Resultado;
        }

        public AgregarCliente()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            Size = new Size(444, 490);
        }

        private void customizeDesign()
        {
            panelDatosEmpresa.Visible = false;
            panelDatosPersona.Visible = false;
        }
        private void hideSubMenu()
        {

            if (panelDatosEmpresa.Visible == true)
            {
                panelDatosEmpresa.Visible = false;
            }
            if (panelDatosPersona.Visible == true)
            {
                panelDatosPersona.Visible = false;
            }
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void cbbSeleccionarTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSeleccionarTipoCliente.Text == "Empresa")
            {
                showSubmenu(panelDatosEmpresa);
                Size = new Size(444, 543);
            }
            else if (cbbSeleccionarTipoCliente.Text == "Persona Natural")
            {
                showSubmenu(panelDatosPersona);
                Size = new Size(444, 649);
            }
        }

        private void btnAgregarAddPdCl_Click(object sender, EventArgs e)
        {
            if (Comprobar())
            {
                Agregar();
            }
        }

        private void btnCancelarAddPdCl_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCerrarAgregarClt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
