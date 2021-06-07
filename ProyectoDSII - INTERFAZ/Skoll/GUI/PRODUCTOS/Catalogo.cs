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
    public partial class Catalogo : Form
    {
        SesionManager.CLS.Sesion oSesion = SesionManager.CLS.Sesion.Instancia;

        BindingSource _DATOSC = new BindingSource();

        private void Cargar()
        {
            _DATOSC.DataSource = CacheManager.CLS.Cache.PRODUCTOS_CATALOGO();
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txbBuscarProductosdeCatalogo.TextLength > 0)
            {
                _DATOSC.Filter = "Nombre_Producto LIKE '%" + txbBuscarProductosdeCatalogo.Text + "%'";
            }
            else
            {
                _DATOSC.RemoveFilter();
            }
            dtgCatalogo.AutoGenerateColumns = false;
            dtgCatalogo.DataSource = _DATOSC;
        }

        public Catalogo()
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgCatalogo.Rows)
                fila.Height = 28;
        }

        private void btnAñadirProductosaCatalogo_Click(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermisos(7))
            {
                try
                {
                    AgregarProductosaCatalogo apac = new AgregarProductosaCatalogo();
                    apac.ShowDialog();
                    Cargar();
                }
                catch
                {
                    MessageBox.Show("No se pudo Agregar el Registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnEditarProductosdeCatalogo_Click(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermisos(7))
            {
                if (dtgCatalogo.SelectedRows.Count > 0)
                {
                    if (dtgCatalogo.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Ningún elemento seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            if (MessageBox.Show("¿Realmente desea editar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                try
                                {

                                    string var = dtgCatalogo.CurrentRow.Cells[0].Value.ToString();
                                    DataTable tCatalogo = new DataTable();
                                    EditarProductodeCatalogo epc = new EditarProductodeCatalogo();

                                    tCatalogo = CacheManager.CLS.Cache.SELECCIONAR_PRODUCTO_CATALOGO(var);
                                    epc.lblIDCatalogo.Text = tCatalogo.Rows[0]["ID_Catalogo"].ToString();
                                    epc.txbNombre.Text = tCatalogo.Rows[0]["Nombre_Producto"].ToString();
                                    epc.txbMarca.Text = tCatalogo.Rows[0]["Marca"].ToString();
                                    epc.txbCategoria.Text = tCatalogo.Rows[0]["Categoria"].ToString();
                                    epc.txbDescripcion.Text = tCatalogo.Rows[0]["Descripcion"].ToString();
                                    epc.ShowDialog();
                                    Cargar();
                                }

                                catch
                                {
                                    MessageBox.Show("Registro no pudo ser Editado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        catch
                        {

                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay registros en esta tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void btnEliminarProductosdelCatalogo_Click(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermisos(7))
            {
                CLS.Catalogo oCtg = new CLS.Catalogo();
                if (dtgCatalogo.SelectedRows.Count > 0)
                {
                    if (dtgCatalogo.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Ningún elemento seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                oCtg.ID_Catalogo = dtgCatalogo.CurrentRow.Cells[0].Value.ToString();
                                if (oCtg.Eliminar())
                                {
                                    Cargar();
                                    MessageBox.Show("Registro Eliminado Correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Registro no pudo ser eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                            }
                        }
                        catch
                        {

                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay registros en esta tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
