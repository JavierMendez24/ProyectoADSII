using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skoll.GUI.PRODUCTOS
{
    public partial class AgregarProductosaCatalogo : Form
    {
        private void Agregar()
        {

            CLS.Catalogo oEntidad = new CLS.Catalogo();
            oEntidad.Nombre_Producto = txbNombre.Text;
            oEntidad.Marca = txbMarca.Text;
            oEntidad.Categoria = txbCategoria.Text;
            oEntidad.Descripcion = txbDescripcion.Text;
            oEntidad.Guardar();
            Close();
            MessageBox.Show("Registro Agregado Correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txbMarca.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbMarca, "Este campo no puede quedar vacío");
            }
            if (txbCategoria.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbCategoria, "Este campo no puede quedar vacío");
            }
            if (txbDescripcion.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbDescripcion, "Este campo no puede quedar vacío");
            }
            return Resultado;
        }

        public AgregarProductosaCatalogo()
        {
            InitializeComponent();
        }

        private void btnCerrarAgregarPdaC_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Comprobar())
            {
                Agregar();
            }
        }

        private void btnCancelarAddPdC_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
