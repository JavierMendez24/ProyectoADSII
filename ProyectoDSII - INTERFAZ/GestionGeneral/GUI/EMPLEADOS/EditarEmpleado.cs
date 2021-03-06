using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionGeneral.GUI.EMPLEADOS
{
    public partial class EditarEmpleado : Form
    {
        
        private void Editar()
        {
            CLS.Empleados oEmp = new CLS.Empleados();
            oEmp.IDEmpleado = lblIDEmpleado.Text;
            oEmp.DUI = txbDUI.Text;
            oEmp.NIT = txbNIT.Text;
            oEmp.Nombres = txbNombres.Text;
            oEmp.Apellidos = txbApellidos.Text;
            oEmp.FechaNacimiento = dtpFechaNac.Text;
            oEmp.Genero = cbbSeleccionarGenero.Text;
            oEmp.Telefono = txbTelefono.Text;
            oEmp.Direccion = txbDireccion.Text;
            oEmp.Correo = txbCorreo.Text;
            oEmp.Editar();
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
            if (txbTelefono.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbTelefono, "Este campo no puede quedar vacío");
            }
            if (txbDireccion.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbDireccion, "Este campo no puede quedar vacío");
            }
            return Resultado;
        }


        public EditarEmpleado()
        {
            InitializeComponent();
        }

        private void btnCloseEditEmpleado_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelarEditEmp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditarEmpleado_Load(object sender, EventArgs e)
        {
            dtpFechaNac.CustomFormat = "yyyy/MM/dd";
        }

        private void btnGuardarEditEmp_Click(object sender, EventArgs e)
        {
            if (Comprobar())
            {
                Editar();
            }
        }
    }
}
