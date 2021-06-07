using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skoll.GUI.INICIO
{
    public partial class Principal : Form 
    {
        SesionManager.CLS.Sesion oSesion = SesionManager.CLS.Sesion.Instancia;

        public Principal()
        {
                InitializeComponent();
                customizeDesign();
                btnRolesAdmin.Visible = false;
                btnUsuariosAdmin.Visible = false;
                btnEmpleadosAdmin.Visible = false;
                btnPermisosAdmin.Visible = false;
                btnRolesAdmin2.Visible = true;
                btnUsuariosAdmin2.Visible = true;
                btnEmpleadosAdmin2.Visible = true;
                btnPermisosAdmin2.Visible = true;
                btnConfig2.Visible = false;
                panelConfig.Visible = false;
                BODEGAS.Bodegas bdg = new BODEGAS.Bodegas();
                AddFormulario(bdg);
                btnBodegas.Checked = true;
        }

        public void AddFormulario(Form f)
        {
            if (this.panelMainContent.Controls.Count > 0)
            {
                this.panelMainContent.Controls.RemoveAt(0);
            }

            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMainContent.Controls.Add(f);
            f.Show();
        }

        private void customizeDesign()
        {
            
            panelSubmenuProductos.Visible = false;
            panelSubmenuReportes.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubmenuProductos.Visible == true)
            {
                panelSubmenuProductos.Visible = false;
            }
            if (panelSubmenuReportes.Visible == true)
            {
                panelSubmenuReportes.Visible = false;
            }
          
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnUsuariosAdmin2_Click_1(object sender, EventArgs e)
        {
            GestionGeneral.GUI.USUARIOS.Usuarios user = new GestionGeneral.GUI.USUARIOS.Usuarios();
            AddFormulario(user);
            btnRolesAdmin.Visible = false;
            btnUsuariosAdmin.Visible = true;
            btnRolesAdmin2.Visible = true;
            btnUsuariosAdmin2.Visible = false;
            btnEmpleadosAdmin.Visible = false;
            btnEmpleadosAdmin2.Visible = true;
            btnPermisosAdmin.Visible = false;
            btnPermisosAdmin2.Visible = true;
            btnConfiguracion.Visible = true;
            btnConfig2.Visible = false;
            panelConfig.Visible = false;
            btnBodegas.Checked = false;
            btnCatalogo.Checked = false;
            btnLista.Checked = false;
            btnClientes.Checked = false;
            btnContratos.Checked = false;
            btnInputReports.Checked = false;
            btnOutputReports.Checked = false;
            btnConteo.Checked = false;
            btnKardex.Checked = false;
        }
        private void btnRolesAdmin2_Click_1(object sender, EventArgs e)
        {
            GestionGeneral.GUI.ROLES.Roles rl = new GestionGeneral.GUI.ROLES.Roles();
            AddFormulario(rl);
            btnRolesAdmin.Visible = true;
            btnUsuariosAdmin.Visible = false;
            btnRolesAdmin2.Visible = false;
            btnUsuariosAdmin2.Visible = true;
            btnEmpleadosAdmin.Visible = false;
            btnEmpleadosAdmin2.Visible = true;
            btnPermisosAdmin.Visible = false;
            btnPermisosAdmin2.Visible = true;
            btnConfiguracion.Visible = true;
            btnConfig2.Visible = false;
            panelConfig.Visible = false;
            btnBodegas.Checked = false;
            btnCatalogo.Checked = false;
            btnLista.Checked = false;
            btnClientes.Checked = false;
            btnContratos.Checked = false;
            btnInputReports.Checked = false;
            btnOutputReports.Checked = false;
            btnConteo.Checked = false;
            btnKardex.Checked = false;
        }

        private void btnEmpleadosAdmin2_Click_1(object sender, EventArgs e)
        {
            GestionGeneral.GUI.EMPLEADOS.Empleados emp = new GestionGeneral.GUI.EMPLEADOS.Empleados();
            AddFormulario(emp);
            btnEmpleadosAdmin.Visible = true;
            btnEmpleadosAdmin2.Visible = false;
            btnRolesAdmin.Visible = false;
            btnUsuariosAdmin.Visible = false;
            btnRolesAdmin2.Visible = true;
            btnUsuariosAdmin2.Visible = true;
            btnPermisosAdmin.Visible = false;
            btnPermisosAdmin2.Visible = true;
            btnConfiguracion.Visible = true;
            btnConfig2.Visible = false;
            panelConfig.Visible = false;
            btnBodegas.Checked = false;
            btnCatalogo.Checked = false;
            btnLista.Checked = false;
            btnClientes.Checked = false;
            btnContratos.Checked = false;
            btnInputReports.Checked = false;
            btnOutputReports.Checked = false;
            btnConteo.Checked = false;
            btnKardex.Checked = false;
        }


        private void btnPermisosAdmin2_Click_1(object sender, EventArgs e)
        {
            GestionGeneral.GUI.PERMISOS.Permisos per = new GestionGeneral.GUI.PERMISOS.Permisos();
            AddFormulario(per);
            btnPermisosAdmin.Visible = true;
            btnPermisosAdmin2.Visible = false;
            btnEmpleadosAdmin.Visible = false;
            btnEmpleadosAdmin2.Visible = true;
            btnRolesAdmin.Visible = false;
            btnUsuariosAdmin.Visible = false;
            btnRolesAdmin2.Visible = true;
            btnUsuariosAdmin2.Visible = true;
            btnConfiguracion.Visible = true;
            btnConfig2.Visible = false;
            panelConfig.Visible = false;
            btnBodegas.Checked = false;
            btnCatalogo.Checked = false;
            btnLista.Checked = false;
            btnClientes.Checked = false;
            btnContratos.Checked = false;
            btnInputReports.Checked = false;
            btnOutputReports.Checked = false;
            btnConteo.Checked = false;
            btnKardex.Checked = false;
        }

        private void panelUsuario_Click(object sender, EventArgs e)
        {
            cbbUs.DroppedDown = true;

        }
        

        private void imgUsuario_Click(object sender, EventArgs e)
        {
            cbbUs.DroppedDown = true;
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            btnConfiguracion.Visible = false;
            btnConfig2.Visible = true;
            panelConfig.Visible = true;
            btnBodegas.Checked = false;
            btnCatalogo.Checked = false;
            btnLista.Checked = false;
            btnClientes.Checked = false;
            btnContratos.Checked = false;
            btnInputReports.Checked = false;
            btnOutputReports.Checked = false;
            btnConteo.Checked = false;
            btnKardex.Checked = false;
            btnUsuariosAdmin.Visible = false;
            btnUsuariosAdmin2.Visible = true;
            btnRolesAdmin.Visible = false;
            btnRolesAdmin2.Visible = true;
            btnPermisosAdmin.Visible = false;
            btnPermisosAdmin2.Visible = true;
            btnEmpleadosAdmin.Visible = false;
            btnEmpleadosAdmin2.Visible = true;
        }

        private void subpanel_Click(object sender, EventArgs e)
        {
            cbbUs.DroppedDown = true;
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
            cbbUs.DroppedDown = true;
        }

        private void btnBodegas_Click(object sender, EventArgs e)
        {
            if (btnBodegas.Checked == true) {
                //evita recargar el form       
            }
            else { 
                BODEGAS.Bodegas b = new BODEGAS.Bodegas();
                AddFormulario(b);
                btnBodegas.Checked = true;
                btnCatalogo.Checked = false;
                btnLista.Checked = false;
                btnClientes.Checked = false;
                btnContratos.Checked = false;
                btnInputReports.Checked = false;
                btnOutputReports.Checked = false;
                btnConteo.Checked = false;
                btnKardex.Checked = false;
                btnUsuariosAdmin.Visible = false;
                btnUsuariosAdmin2.Visible = true;
                btnRolesAdmin.Visible = false;
                btnRolesAdmin2.Visible = true;
                btnPermisosAdmin.Visible = false;
                btnPermisosAdmin2.Visible = true;
                btnEmpleadosAdmin.Visible = false;
                btnEmpleadosAdmin2.Visible = true;
                btnConfiguracion.Visible = true;
                btnConfig2.Visible = false;
                panelConfig.Visible = false;
            }
        }


        private void btnClientes_Click(object sender, EventArgs e)
        {
            // VER CLIENTES
            if (oSesion.ComprobarPermisos(2))
            {
                if (btnClientes.Checked == true)
                {
                    //evita recargar el form
                }
                else
                {
                    CLIENTES.Clientes cte = new CLIENTES.Clientes();
                    AddFormulario(cte);
                    btnBodegas.Checked = false;
                    btnCatalogo.Checked = false;
                    btnLista.Checked = false;
                    btnClientes.Checked = true;
                    btnContratos.Checked = false;
                    btnInputReports.Checked = false;
                    btnOutputReports.Checked = false;
                    btnConteo.Checked = false;
                    btnKardex.Checked = false;
                    btnUsuariosAdmin.Visible = false;
                    btnUsuariosAdmin2.Visible = true;
                    btnRolesAdmin.Visible = false;
                    btnRolesAdmin2.Visible = true;
                    btnPermisosAdmin.Visible = false;
                    btnPermisosAdmin2.Visible = true;
                    btnEmpleadosAdmin.Visible = false;
                    btnEmpleadosAdmin2.Visible = true;
                    btnConfiguracion.Visible = true;
                    btnConfig2.Visible = false;
                    panelConfig.Visible = false;
                }
            }
            
        }

        private void btnContratos_Click(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermisos(4))
            {
                if (btnContratos.Checked == true)
                {
                    //evita recargar el form       
                }
                else
                {
                    CONTRATOS.Contratos ctt = new CONTRATOS.Contratos();
                    AddFormulario(ctt);
                    btnBodegas.Checked = false;
                    btnCatalogo.Checked = false;
                    btnLista.Checked = false;
                    btnClientes.Checked = false;
                    btnContratos.Checked = true;
                    btnInputReports.Checked = false;
                    btnOutputReports.Checked = false;
                    btnConteo.Checked = false;
                    btnKardex.Checked = false;
                    btnUsuariosAdmin.Visible = false;
                    btnUsuariosAdmin2.Visible = true;
                    btnRolesAdmin.Visible = false;
                    btnRolesAdmin2.Visible = true;
                    btnPermisosAdmin.Visible = false;
                    btnPermisosAdmin2.Visible = true;
                    btnEmpleadosAdmin.Visible = false;
                    btnEmpleadosAdmin2.Visible = true;
                    btnConfiguracion.Visible = true;
                    btnConfig2.Visible = false;
                    panelConfig.Visible = false;
                }
            }
            
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenuProductos);
        }

        private void btnCatalogo_Click_1(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermisos(6))
            {
                if (btnCatalogo.Checked == true)
                {
                    //evita recargar el form       
                }
                else
                {
                    GUI.PRODUCTOS.Catalogo ctg = new GUI.PRODUCTOS.Catalogo();
                    AddFormulario(ctg);
                    btnBodegas.Checked = false;
                    btnCatalogo.Checked = true;
                    btnLista.Checked = false;
                    btnClientes.Checked = false;
                    btnContratos.Checked = false;
                    btnInputReports.Checked = false;
                    btnOutputReports.Checked = false;
                    btnConteo.Checked = false;
                    btnKardex.Checked = false;
                    btnUsuariosAdmin.Visible = false;
                    btnUsuariosAdmin2.Visible = true;
                    btnRolesAdmin.Visible = false;
                    btnRolesAdmin2.Visible = true;
                    btnPermisosAdmin.Visible = false;
                    btnPermisosAdmin2.Visible = true;
                    btnEmpleadosAdmin.Visible = false;
                    btnEmpleadosAdmin2.Visible = true;
                    btnConfiguracion.Visible = true;
                    btnConfig2.Visible = false;
                    panelConfig.Visible = false;
                }
            }
            
        }

        private void btnLista_Click_1(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermisos(8))
            {
                if (btnLista.Checked == true)
                {
                    //evita recargar el form       
                }
                else
                {
                    GUI.PRODUCTOS.Lista lst = new GUI.PRODUCTOS.Lista();
                    AddFormulario(lst);
                    btnBodegas.Checked = false;
                    btnCatalogo.Checked = false;
                    btnLista.Checked = true;
                    btnClientes.Checked = false;
                    btnContratos.Checked = false;
                    btnInputReports.Checked = false;
                    btnOutputReports.Checked = false;
                    btnConteo.Checked = false;
                    btnKardex.Checked = false;
                    btnUsuariosAdmin.Visible = false;
                    btnUsuariosAdmin2.Visible = true;
                    btnRolesAdmin.Visible = false;
                    btnRolesAdmin2.Visible = true;
                    btnPermisosAdmin.Visible = false;
                    btnPermisosAdmin2.Visible = true;
                    btnEmpleadosAdmin.Visible = false;
                    btnEmpleadosAdmin2.Visible = true;
                    btnConfiguracion.Visible = true;
                    btnConfig2.Visible = false;
                    panelConfig.Visible = false;
                }
            }
            
        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenuReportes);
        }

        private void btnInputReports_Click_1(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermisos(10))
            {
                if (btnInputReports.Checked == true)
                {
                    //evita recargar el form       
                }
                else
                {
                    REPORTES.ReportesEntrada rpte = new REPORTES.ReportesEntrada();
                    AddFormulario(rpte);
                    btnBodegas.Checked = false;
                    btnCatalogo.Checked = false;
                    btnLista.Checked = false;
                    btnClientes.Checked = false;
                    btnContratos.Checked = false;
                    btnInputReports.Checked = true;
                    btnOutputReports.Checked = false;
                    btnConteo.Checked = false;
                    btnKardex.Checked = false;
                    btnUsuariosAdmin.Visible = false;
                    btnUsuariosAdmin2.Visible = true;
                    btnRolesAdmin.Visible = false;
                    btnRolesAdmin2.Visible = true;
                    btnPermisosAdmin.Visible = false;
                    btnPermisosAdmin2.Visible = true;
                    btnEmpleadosAdmin.Visible = false;
                    btnEmpleadosAdmin2.Visible = true;
                    btnConfiguracion.Visible = true;
                    btnConfig2.Visible = false;
                    panelConfig.Visible = false;
                }
            }
            
        }

        private void btnOutputReports_Click_1(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermisos(12))
            {
                if (btnOutputReports.Checked == true)
                {
                    //evita recargar el form       
                }
                else
                {
                    REPORTES.ReportesSalida rpts = new REPORTES.ReportesSalida();
                    AddFormulario(rpts);
                    btnBodegas.Checked = false;
                    btnCatalogo.Checked = false;
                    btnLista.Checked = false;
                    btnClientes.Checked = false;
                    btnContratos.Checked = false;
                    btnInputReports.Checked = false;
                    btnOutputReports.Checked = true;
                    btnConteo.Checked = false;
                    btnKardex.Checked = false;
                    btnUsuariosAdmin.Visible = false;
                    btnUsuariosAdmin2.Visible = true;
                    btnRolesAdmin.Visible = false;
                    btnRolesAdmin2.Visible = true;
                    btnPermisosAdmin.Visible = false;
                    btnPermisosAdmin2.Visible = true;
                    btnEmpleadosAdmin.Visible = false;
                    btnEmpleadosAdmin2.Visible = true;
                    btnConfiguracion.Visible = true;
                    btnConfig2.Visible = false;
                    panelConfig.Visible = false;
                }
            }
            
        }

        private void btnConteo_Click_1(object sender, EventArgs e)
        {
            if (btnConteo.Checked == true)
            {
                //evita recargar el form       
            }
            else
            {
                REPORTES.ReportesInventario rpti = new REPORTES.ReportesInventario();
                AddFormulario(rpti);
                btnBodegas.Checked = false;
                btnCatalogo.Checked = false;
                btnLista.Checked = false;
                btnClientes.Checked = false;
                btnContratos.Checked = false;
                btnInputReports.Checked = false;
                btnOutputReports.Checked = false;
                btnConteo.Checked = true;
                btnKardex.Checked = false;
                btnUsuariosAdmin.Visible = false;
                btnUsuariosAdmin2.Visible = true;
                btnRolesAdmin.Visible = false;
                btnRolesAdmin2.Visible = true;
                btnPermisosAdmin.Visible = false;
                btnPermisosAdmin2.Visible = true;
                btnEmpleadosAdmin.Visible = false;
                btnEmpleadosAdmin2.Visible = true;
                btnConfiguracion.Visible = true;
                btnConfig2.Visible = false;
                panelConfig.Visible = false;
            }
        }

        private void btnKardex_Click_1(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermisos(15))
            {
                if (btnKardex.Checked == true)
                {
                    //evita recargar el form       
                }
                else
                {
                    REPORTES.ReportesKardex rptk = new REPORTES.ReportesKardex();
                    AddFormulario(rptk);
                    btnBodegas.Checked = false;
                    btnCatalogo.Checked = false;
                    btnLista.Checked = false;
                    btnClientes.Checked = false;
                    btnContratos.Checked = false;
                    btnInputReports.Checked = false;
                    btnOutputReports.Checked = false;
                    btnConteo.Checked = false;
                    btnKardex.Checked = true;
                    btnUsuariosAdmin.Visible = false;
                    btnUsuariosAdmin2.Visible = true;
                    btnRolesAdmin.Visible = false;
                    btnRolesAdmin2.Visible = true;
                    btnPermisosAdmin.Visible = false;
                    btnPermisosAdmin2.Visible = true;
                    btnEmpleadosAdmin.Visible = false;
                    btnEmpleadosAdmin2.Visible = true;
                    btnConfiguracion.Visible = true;
                    btnConfig2.Visible = false;
                    panelConfig.Visible = false;
                }
            }
            
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            oSesion.CargarPermisos();
            if (oSesion.ComprobarPermisosMenuGeneral(17))
            {
                panelGestionGeneral.Visible = true;
            }
            else
            {
                panelGestionGeneral.Visible = false;
            }
            lblUsuario.Text = oSesion.Usuario;
        }

        private Boolean LoginScreen()
        {
            Boolean Resultado = true;
            Login f = new Login();
            f.ShowDialog();
            Resultado = f.Validado;
            return Resultado;
        }

        private void cbbUs_SelectedIndexChanged(object sender, EventArgs e)
        {
            String item = cbbUs.Text;

            if (item == "CERRAR SESIÓN")
            {
                this.Hide();
                if (LoginScreen())
                {
                    Principal f = new Principal();
                    f.ShowDialog();
                }
            }
        }

    }
}
