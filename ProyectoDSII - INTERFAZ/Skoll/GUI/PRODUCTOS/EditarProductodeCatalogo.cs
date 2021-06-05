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
    public partial class EditarProductodeCatalogo : Form
    {
        private void Editar()
        {
            CLS.Catalogo oEntidad = new CLS.Catalogo();
            oEntidad.ID_Catalogo = lblIDCatalogo.Text;
            oEntidad.Nombre_Producto = txbNombre.Text;
            oEntidad.Marca = txbMarca.Text;
            oEntidad.Categoria = txbCategoria.Text;
            oEntidad.Descripcion = txbDescripcion.Text;
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

        public EditarProductodeCatalogo()
        {
            InitializeComponent();
        }

        private void btnCerrarEditarPdtdC_Click(object sender, EventArgs e)
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

        private void btnCancelarEditPdC_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
