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
    public partial class AgregarProductosaBodega : Form
    {

        private void Agregar()
        {
            SesionManager.CLS.Sesion item = SesionManager.CLS.Sesion.Instancia;

            
            DataTable tCliente = new DataTable();
            DataTable tMovimiento = new DataTable();
            Productos productos = new Productos();
            Movimientos movimiento = new Movimientos();

            String vZona = cbbSeleccionarZonaCtg.Text;
            String vIDContrato = lblIDContrato.Text;

            tCliente = CacheManager.CLS.Cache.CLIENTE_PARA_REGISTRO_ENTRADA(vIDContrato);
            String vCliente = tCliente.Rows[0]["Cliente"].ToString();
            String vIDCatalogo = dtgAddProductosBodega.CurrentRow.Cells[0].Value.ToString();

            productos.ID_Catalogo = vIDCatalogo; 
            productos.Costo = dtgAddProductosBodega.CurrentRow.Cells[2].Value.ToString(); 
            productos.Cantidad = dtgAddProductosBodega.CurrentRow.Cells[3].Value.ToString(); 
            productos.Fecha_Vencimiento = dtgAddProductosBodega.CurrentRow.Cells[4].Value.ToString(); 
            productos.Guardar();
            
            productos.GuardarZonaProducto(cbbSeleccionarZonaCtg.SelectedValue.ToString());
            
            movimiento.ID_Usuario = item.IDUsuario;
            movimiento.Zona = vZona;
            movimiento.Nombre_Producto = dtgAddProductosBodega.CurrentRow.Cells[1].Value.ToString();
            movimiento.Costo = dtgAddProductosBodega.CurrentRow.Cells[2].Value.ToString();
            movimiento.Cantidad_Movimiento = dtgAddProductosBodega.CurrentRow.Cells[3].Value.ToString();
            movimiento.Nombre_Cliente = vCliente;
            movimiento.Guardar(vIDCatalogo);

            tMovimiento = CacheManager.CLS.Cache.ULTIMO_MOVIMIENTO_ENTRADA();
            movimiento.ID_Movimiento = tMovimiento.Rows[0]["ID_Movimiento"].ToString();

            movimiento.GuardarMovimientoProducto();
            
            Close();
        }

        private Boolean Comprobar()
        {
            Boolean Resultado = true;
            Notificador.Clear();

            if (txbContrato.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbContrato, "Este campo no puede quedar vacío");
            }

            return Resultado;
        }

        public AgregarProductosaBodega()
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgAddProductosBodega.Rows)
                fila.Height = 28;
        }

        private void btnCerrarAgregarPdaB_Click(object sender, EventArgs e)
        {
            TransferenciaDatos item = TransferenciaDatos.getInstance();
            item.Valores.Clear();
            Close();
        }

        private void btnSeleccionarClienteAddPd_Click(object sender, EventArgs e)
        {
            SeleccionarClienteLista scl = new SeleccionarClienteLista(this);
            scl.ShowDialog();
        }

        private void btnSeleccionarProductosdelCatalogo_Click(object sender, EventArgs e)
        {
            SeleccionarProductosdelCatalogo spdc = new SeleccionarProductosdelCatalogo();
            spdc.ShowDialog();
            TransferenciaDatos item = TransferenciaDatos.getInstance();

            if (item.Ultimo != -1)
            {
                var index = dtgAddProductosBodega.Rows.Add();
                dtgAddProductosBodega.Rows[index].Cells[0].Value = item.Ultimo;
                dtgAddProductosBodega.Rows[index].Cells[1].Value = item.Valores[item.Ultimo];
                
                item.Ultimo = -1;
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TransferenciaDatos item = TransferenciaDatos.getInstance();
            item.Valores.Clear();
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TransferenciaDatos item = TransferenciaDatos.getInstance();
            if (Comprobar())
            {
                Agregar();
            }
            item.Valores.Clear();
            Close();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            TransferenciaDatos item = TransferenciaDatos.getInstance();
            String IDCatalogo = dtgAddProductosBodega.CurrentRow.Cells[0].Value.ToString();

            dtgAddProductosBodega.Rows.RemoveAt(dtgAddProductosBodega.CurrentRow.Index);

            item.Valores.Remove(Int32.Parse(IDCatalogo));
        }

        private void AgregarProductosaBodega_Load(object sender, EventArgs e)
        {
            
        }
    }
}
