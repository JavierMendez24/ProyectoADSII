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
    public partial class Clientes : Form
    {
        SesionManager.CLS.Sesion oSesion = SesionManager.CLS.Sesion.Instancia;

        BindingSource _DATOSE = new BindingSource();

        BindingSource _DATOSP = new BindingSource();

        private void Cargar()
        {
            if (btnVerEmpresas.Checked == true)
            {
                _DATOSE.DataSource = CacheManager.CLS.Cache.TODOS_LOS_CLIENTES_EMPRESA();
            }
            else if (btnVerPersonas.Checked == true)
            {
                _DATOSP.DataSource = CacheManager.CLS.Cache.TODOS_LOS_CLIENTES_PERSONA();
            }
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txbBuscarClientes.TextLength > 0)
            {
                if (btnVerEmpresas.Checked == true)
                {
                    _DATOSE.Filter = "Nombre_Empresa LIKE '%" + txbBuscarClientes.Text + "%'";
                }
                else if(btnVerPersonas.Checked == true)
                {
                    _DATOSP.Filter = "Nombres_Cliente LIKE '%" + txbBuscarClientes.Text + "%'";
                }
            }
            else
            {
                _DATOSE.RemoveFilter();
                _DATOSP.RemoveFilter();
            }
            dtgClientesEmpresas.AutoGenerateColumns = false;
            dtgClientesEmpresas.DataSource = _DATOSE;
            dtgClientesPersonas.AutoGenerateColumns = false;
            dtgClientesPersonas.DataSource = _DATOSP;
        }
        public Clientes()
        {
            InitializeComponent();
            btnVerEmpresas.Checked = true;
            btnVerPersonas.Checked = false;
            panelDtgClientesPersonas.Visible = false;
            panelDtgClientesEmpresas.Visible = true;
            foreach (DataGridViewRow fila in dtgClientesEmpresas.Rows)
                fila.Height = 28;
            foreach (DataGridViewRow fila in dtgClientesPersonas.Rows)
                fila.Height = 28;
        }

        private void btnVerEmpresas_Click(object sender, EventArgs e)
        {
            btnVerEmpresas.Checked = true;
            btnVerPersonas.Checked = false;
            panelDtgClientesEmpresas.Visible = true;
            panelDtgClientesPersonas.Visible = false;
            Cargar();
        }

        private void btnVerPersonas_Click(object sender, EventArgs e)
        {
            btnVerPersonas.Checked = true;
            btnVerEmpresas.Checked = false;
            panelDtgClientesPersonas.Visible = true;
            panelDtgClientesEmpresas.Visible = false;
            Cargar();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermisos(3))
            {
                try
                {
                    AgregarCliente ac = new AgregarCliente();
                    ac.ShowDialog();
                    Cargar();
                    MessageBox.Show("Registro Agregado Correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("No se pudo Agregar el Registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermisos(3))
            {
                if (btnVerEmpresas.Checked == true)
                {
                    if (dtgClientesEmpresas.SelectedRows.Count > 0)
                    {
                        if (dtgClientesEmpresas.SelectedRows.Count == 0)
                        {
                            MessageBox.Show("Ningún elemento seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            try
                            {
                                if (MessageBox.Show("¿Realmente desea editar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    try { 

                                        string var = dtgClientesEmpresas.CurrentRow.Cells[0].Value.ToString();
                                        DataTable tClienteE = new DataTable();
                                        EditarClienteEmpresa ece = new EditarClienteEmpresa();

                                        tClienteE = CacheManager.CLS.Cache.SELECCIONAR_CLIENTE_EMPRESA(var);
                                        ece.lblIdCliente.Text = tClienteE.Rows[0]["ID_Cliente"].ToString();
                                        ece.txbNombre.Text = tClienteE.Rows[0]["Nombre_Empresa"].ToString();
                                        ece.txbNIT.Text = tClienteE.Rows[0]["NIT"].ToString();
                                        ece.txbTelefono.Text = tClienteE.Rows[0]["Telefono"].ToString();
                                        ece.txbDireccion.Text = tClienteE.Rows[0]["Direccion"].ToString();
                                        ece.txbCorreo.Text = tClienteE.Rows[0]["Correo"].ToString();
                                        ece.ShowDialog();
                                        Cargar();
                                        MessageBox.Show("Registro Editado Correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else if (btnVerPersonas.Checked == true)
                {
                    if (dtgClientesPersonas.SelectedRows.Count > 0)
                    {
                        if (dtgClientesPersonas.SelectedRows.Count == 0)
                        {
                            MessageBox.Show("Ningún elemento seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            try
                            {
                                string var = dtgClientesPersonas.CurrentRow.Cells[0].Value.ToString();
                                DataTable tClienteP = new DataTable();
                                EditarClientePersona ecp = new EditarClientePersona();

                                tClienteP = CacheManager.CLS.Cache.SELECCIONAR_CLIENTE_PERSONA(var);

                                ecp.lblIdCliente.Text = tClienteP.Rows[0]["ID_Cliente"].ToString();
                                ecp.txbNombres.Text = tClienteP.Rows[0]["Nombres_Cliente"].ToString();
                                ecp.txbApellidos.Text = tClienteP.Rows[0]["Apellidos_Cliente"].ToString();
                                ecp.txbDUI.Text = tClienteP.Rows[0]["DUI"].ToString();
                                ecp.txbNIT.Text = tClienteP.Rows[0]["NIT"].ToString();
                                ecp.txbTelefono.Text = tClienteP.Rows[0]["Telefono"].ToString();
                                ecp.txbDireccion.Text = tClienteP.Rows[0]["Direccion"].ToString();
                                ecp.txbCorreo.Text = tClienteP.Rows[0]["Correo"].ToString();

                                ecp.ShowDialog();
                                Cargar();
                                MessageBox.Show("Registro Editado Correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                MessageBox.Show("Registro no pudo ser Editado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay registros en esta tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            
        }

        private void btnDetallesCliente_Click(object sender, EventArgs e)
        {
            if (btnVerEmpresas.Checked == true)
            {
                if (dtgClientesEmpresas.SelectedRows.Count > 0)
                {
                    if (dtgClientesEmpresas.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Ningún elemento seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string var = dtgClientesEmpresas.CurrentRow.Cells[0].Value.ToString();

                        DataTable tClienteE = new DataTable();
                        DetallesClienteEmpresa dce = new DetallesClienteEmpresa();

                        tClienteE = CacheManager.CLS.Cache.SELECCIONAR_CLIENTE_EMPRESA(var);

                        dce.txbIDCliente.Text = tClienteE.Rows[0]["ID_Cliente"].ToString();
                        dce.txbNombre.Text = tClienteE.Rows[0]["Nombre_Empresa"].ToString();
                        dce.txbNIT.Text = tClienteE.Rows[0]["NIT"].ToString();
                        dce.txbTelefono.Text = tClienteE.Rows[0]["Telefono"].ToString();
                        dce.txbDireccion.Text = tClienteE.Rows[0]["Direccion"].ToString();
                        dce.txbCorreo.Text = tClienteE.Rows[0]["Correo"].ToString();

                        dce.ShowDialog();
                        Cargar();
                    }
                }
                else
                {
                    MessageBox.Show("No hay registros en esta tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (btnVerPersonas.Checked == true)
            {
                if (dtgClientesPersonas.SelectedRows.Count > 0)
                {
                    if (dtgClientesPersonas.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Ningún elemento seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string var = dtgClientesPersonas.CurrentRow.Cells[0].Value.ToString();

                        DataTable tClienteP = new DataTable();
                        DetallesClientePersona dcp = new DetallesClientePersona();

                        tClienteP = CacheManager.CLS.Cache.SELECCIONAR_CLIENTE_PERSONA(var);
                        dcp.txbIDCliente.Text = tClienteP.Rows[0]["ID_Cliente"].ToString();
                        dcp.txbNombres.Text = tClienteP.Rows[0]["Nombres_Cliente"].ToString();
                        dcp.txbApellidos.Text = tClienteP.Rows[0]["Apellidos_Cliente"].ToString();
                        dcp.txbDUI.Text = tClienteP.Rows[0]["DUI"].ToString();
                        dcp.txbNIT.Text = tClienteP.Rows[0]["NIT"].ToString();
                        dcp.txbTelefono.Text = tClienteP.Rows[0]["Telefono"].ToString();
                        dcp.txbDireccion.Text = tClienteP.Rows[0]["Direccion"].ToString();
                        dcp.txbCorreo.Text = tClienteP.Rows[0]["Correo"].ToString();

                        dcp.ShowDialog();
                        Cargar();
                    }
                }
                else
                {
                    MessageBox.Show("No hay registros en esta tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txbBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermisos(3))
            {
                CLS.Clientes oClt = new CLS.Clientes();
                if (btnVerEmpresas.Checked == true)
                {
                    if (dtgClientesEmpresas.SelectedRows.Count > 0)
                    {
                        if (dtgClientesEmpresas.SelectedRows.Count == 0)
                        {
                            MessageBox.Show("Ningún elemento seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            try
                            {
                                if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    oClt.IDCliente = dtgClientesEmpresas.CurrentRow.Cells[0].Value.ToString();
                                    if (oClt.Eliminar())
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
                else if (btnVerPersonas.Checked == true)
                {
                    if (dtgClientesPersonas.SelectedRows.Count > 0)
                    {
                        if (dtgClientesPersonas.SelectedRows.Count == 0)
                        {
                            MessageBox.Show("Ningún elemento seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            try
                            {
                                if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    oClt.IDCliente = dtgClientesPersonas.CurrentRow.Cells[0].Value.ToString();
                                    if (oClt.Eliminar())
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
        }
    }
}
