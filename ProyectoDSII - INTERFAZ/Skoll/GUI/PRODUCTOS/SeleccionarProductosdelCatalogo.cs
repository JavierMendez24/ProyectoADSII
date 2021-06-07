using Skoll.CLS;
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
    public partial class SeleccionarProductosdelCatalogo : Form
    {

        BindingSource _DATOSP = new BindingSource();

        private void Cargar()
        {
            _DATOSP.DataSource = CacheManager.CLS.Cache.PRODUCTOS_CATALOGO();
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txbBuscarPDC.TextLength > 0)
            {
                //_DATOSP.Filter = "Nombre_Producto LIKE '%" + txbBuscarPDC.Text + "%'";
            }
            else
            {
                _DATOSP.RemoveFilter();
            }
            dtgCatalogo.AutoGenerateColumns = false;
            dtgCatalogo.DataSource = _DATOSP;
        }


        public SeleccionarProductosdelCatalogo()
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgCatalogo.Rows)
                fila.Height = 28;
        }

        private void btnCerrarSPC_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tProductos = new DataTable();
                Productos productos = new Productos();
                TransferenciaDatos item = TransferenciaDatos.getInstance();

                tProductos = CacheManager.CLS.Cache.SELECCIONAR_EL_PRODUCTO_ACTUAL();
                productos.ID_Producto = tProductos.Rows[0]["ID_Producto"].ToString();

                String IDCatalogo = dtgCatalogo.CurrentRow.Cells[0].Value.ToString();
                String Nombre = dtgCatalogo.CurrentRow.Cells[1].Value.ToString();

                if (item.Valores.ContainsKey(Int32.Parse(IDCatalogo)))
                {
                    MessageBox.Show("Ya existe este registro en la tabla.");
                }
                else
                {
                    item.Valores.Add(Int32.Parse(IDCatalogo), Nombre);
                    item.Ultimo = Int32.Parse(IDCatalogo);
                    productos.GuardarProductoMovimiento();
                    Close();
                }

                
            }
            catch
            {

            }
            
        }

        private void SeleccionarProductosdelCatalogo_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
