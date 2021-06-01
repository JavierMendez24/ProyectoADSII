namespace Skoll.GUI.CLIENTES
{
    partial class AgregarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCliente));
            this.panelConte = new System.Windows.Forms.Panel();
            this.panelConten = new Guna.UI2.WinForms.Guna2Panel();
            this.panelDatosGenerales = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCancelarAddPdCl = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregarAddPdCl = new Guna.UI2.WinForms.Guna2Button();
            this.txbCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbDireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbNIT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelDatosEmpresa = new Guna.UI2.WinForms.Guna2Panel();
            this.txbNombreEmpresa = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDatosPersona = new Guna.UI2.WinForms.Guna2Panel();
            this.txbDUI = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNombres = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbApellidos = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTipoCliente = new Guna.UI2.WinForms.Guna2Panel();
            this.paneltxbTipoCliente = new Guna.UI2.WinForms.Guna2Panel();
            this.cbbSeleccionarTipoCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTituloAddClt = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAgregaraCatalogo = new System.Windows.Forms.Label();
            this.btnCerrarAgregarClt = new System.Windows.Forms.PictureBox();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelConte.SuspendLayout();
            this.panelConten.SuspendLayout();
            this.panelDatosGenerales.SuspendLayout();
            this.panelDatosEmpresa.SuspendLayout();
            this.panelDatosPersona.SuspendLayout();
            this.panelTipoCliente.SuspendLayout();
            this.paneltxbTipoCliente.SuspendLayout();
            this.panelTituloAddClt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarAgregarClt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConte
            // 
            this.panelConte.Controls.Add(this.panelConten);
            this.panelConte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConte.Location = new System.Drawing.Point(0, 78);
            this.panelConte.Name = "panelConte";
            this.panelConte.Size = new System.Drawing.Size(444, 623);
            this.panelConte.TabIndex = 3;
            // 
            // panelConten
            // 
            this.panelConten.BorderColor = System.Drawing.Color.Silver;
            this.panelConten.BorderThickness = 1;
            this.panelConten.Controls.Add(this.panelDatosGenerales);
            this.panelConten.Controls.Add(this.panelDatosEmpresa);
            this.panelConten.Controls.Add(this.panelDatosPersona);
            this.panelConten.Controls.Add(this.panelTipoCliente);
            this.panelConten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConten.Location = new System.Drawing.Point(0, 0);
            this.panelConten.Name = "panelConten";
            this.panelConten.ShadowDecoration.Parent = this.panelConten;
            this.panelConten.Size = new System.Drawing.Size(444, 623);
            this.panelConten.TabIndex = 0;
            // 
            // panelDatosGenerales
            // 
            this.panelDatosGenerales.Controls.Add(this.btnCancelarAddPdCl);
            this.panelDatosGenerales.Controls.Add(this.btnAgregarAddPdCl);
            this.panelDatosGenerales.Controls.Add(this.txbCorreo);
            this.panelDatosGenerales.Controls.Add(this.label11);
            this.panelDatosGenerales.Controls.Add(this.txbDireccion);
            this.panelDatosGenerales.Controls.Add(this.label6);
            this.panelDatosGenerales.Controls.Add(this.txbNIT);
            this.panelDatosGenerales.Controls.Add(this.txbTelefono);
            this.panelDatosGenerales.Controls.Add(this.label7);
            this.panelDatosGenerales.Controls.Add(this.label8);
            this.panelDatosGenerales.CustomBorderColor = System.Drawing.Color.Silver;
            this.panelDatosGenerales.CustomBorderThickness = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.panelDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDatosGenerales.Location = new System.Drawing.Point(0, 310);
            this.panelDatosGenerales.Name = "panelDatosGenerales";
            this.panelDatosGenerales.ShadowDecoration.Parent = this.panelDatosGenerales;
            this.panelDatosGenerales.Size = new System.Drawing.Size(444, 314);
            this.panelDatosGenerales.TabIndex = 20;
            // 
            // btnCancelarAddPdCl
            // 
            this.btnCancelarAddPdCl.BorderRadius = 5;
            this.btnCancelarAddPdCl.CheckedState.Parent = this.btnCancelarAddPdCl;
            this.btnCancelarAddPdCl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarAddPdCl.CustomImages.Parent = this.btnCancelarAddPdCl;
            this.btnCancelarAddPdCl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(79)))), ((int)(((byte)(83)))));
            this.btnCancelarAddPdCl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAddPdCl.ForeColor = System.Drawing.Color.White;
            this.btnCancelarAddPdCl.HoverState.Parent = this.btnCancelarAddPdCl;
            this.btnCancelarAddPdCl.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarAddPdCl.Image")));
            this.btnCancelarAddPdCl.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancelarAddPdCl.ImageSize = new System.Drawing.Size(19, 19);
            this.btnCancelarAddPdCl.Location = new System.Drawing.Point(290, 247);
            this.btnCancelarAddPdCl.Name = "btnCancelarAddPdCl";
            this.btnCancelarAddPdCl.ShadowDecoration.Parent = this.btnCancelarAddPdCl;
            this.btnCancelarAddPdCl.Size = new System.Drawing.Size(110, 35);
            this.btnCancelarAddPdCl.TabIndex = 73;
            this.btnCancelarAddPdCl.Text = "CANCELAR";
            this.btnCancelarAddPdCl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCancelarAddPdCl.TextOffset = new System.Drawing.Point(4, 0);
            this.btnCancelarAddPdCl.Click += new System.EventHandler(this.btnCancelarAddPdCl_Click);
            // 
            // btnAgregarAddPdCl
            // 
            this.btnAgregarAddPdCl.BorderRadius = 5;
            this.btnAgregarAddPdCl.CheckedState.Parent = this.btnAgregarAddPdCl;
            this.btnAgregarAddPdCl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarAddPdCl.CustomImages.Parent = this.btnAgregarAddPdCl;
            this.btnAgregarAddPdCl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(182)))), ((int)(((byte)(146)))));
            this.btnAgregarAddPdCl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAddPdCl.ForeColor = System.Drawing.Color.White;
            this.btnAgregarAddPdCl.HoverState.Parent = this.btnAgregarAddPdCl;
            this.btnAgregarAddPdCl.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarAddPdCl.Image")));
            this.btnAgregarAddPdCl.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAgregarAddPdCl.ImageSize = new System.Drawing.Size(19, 19);
            this.btnAgregarAddPdCl.Location = new System.Drawing.Point(174, 247);
            this.btnAgregarAddPdCl.Name = "btnAgregarAddPdCl";
            this.btnAgregarAddPdCl.ShadowDecoration.Parent = this.btnAgregarAddPdCl;
            this.btnAgregarAddPdCl.Size = new System.Drawing.Size(110, 35);
            this.btnAgregarAddPdCl.TabIndex = 72;
            this.btnAgregarAddPdCl.Text = "AGREGAR";
            this.btnAgregarAddPdCl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAgregarAddPdCl.Click += new System.EventHandler(this.btnAgregarAddPdCl_Click);
            // 
            // txbCorreo
            // 
            this.txbCorreo.BorderColor = System.Drawing.Color.Silver;
            this.txbCorreo.BorderRadius = 5;
            this.txbCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCorreo.DefaultText = "";
            this.txbCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCorreo.DisabledState.Parent = this.txbCorreo;
            this.txbCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCorreo.FocusedState.Parent = this.txbCorreo;
            this.txbCorreo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.txbCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCorreo.HoverState.Parent = this.txbCorreo;
            this.txbCorreo.Location = new System.Drawing.Point(180, 167);
            this.txbCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbCorreo.Name = "txbCorreo";
            this.txbCorreo.PasswordChar = '\0';
            this.txbCorreo.PlaceholderText = "";
            this.txbCorreo.SelectedText = "";
            this.txbCorreo.ShadowDecoration.Parent = this.txbCorreo;
            this.txbCorreo.Size = new System.Drawing.Size(220, 35);
            this.txbCorreo.TabIndex = 69;
            this.txbCorreo.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label11.Location = new System.Drawing.Point(24, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 21);
            this.label11.TabIndex = 66;
            this.label11.Text = "Correo:";
            // 
            // txbDireccion
            // 
            this.txbDireccion.BorderColor = System.Drawing.Color.Silver;
            this.txbDireccion.BorderRadius = 5;
            this.txbDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDireccion.DefaultText = "";
            this.txbDireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbDireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbDireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbDireccion.DisabledState.Parent = this.txbDireccion;
            this.txbDireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbDireccion.FocusedState.Parent = this.txbDireccion;
            this.txbDireccion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.txbDireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbDireccion.HoverState.Parent = this.txbDireccion;
            this.txbDireccion.Location = new System.Drawing.Point(180, 114);
            this.txbDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.PasswordChar = '\0';
            this.txbDireccion.PlaceholderText = "";
            this.txbDireccion.SelectedText = "";
            this.txbDireccion.ShadowDecoration.Parent = this.txbDireccion;
            this.txbDireccion.Size = new System.Drawing.Size(220, 35);
            this.txbDireccion.TabIndex = 65;
            this.txbDireccion.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label6.Location = new System.Drawing.Point(24, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 64;
            this.label6.Text = "Dirección:";
            // 
            // txbNIT
            // 
            this.txbNIT.BorderColor = System.Drawing.Color.Silver;
            this.txbNIT.BorderRadius = 5;
            this.txbNIT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNIT.DefaultText = "";
            this.txbNIT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbNIT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbNIT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNIT.DisabledState.Parent = this.txbNIT;
            this.txbNIT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNIT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNIT.FocusedState.Parent = this.txbNIT;
            this.txbNIT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNIT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.txbNIT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNIT.HoverState.Parent = this.txbNIT;
            this.txbNIT.Location = new System.Drawing.Point(180, 8);
            this.txbNIT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbNIT.Name = "txbNIT";
            this.txbNIT.PasswordChar = '\0';
            this.txbNIT.PlaceholderText = "";
            this.txbNIT.SelectedText = "";
            this.txbNIT.ShadowDecoration.Parent = this.txbNIT;
            this.txbNIT.Size = new System.Drawing.Size(220, 35);
            this.txbNIT.TabIndex = 63;
            this.txbNIT.TabStop = false;
            // 
            // txbTelefono
            // 
            this.txbTelefono.BorderColor = System.Drawing.Color.Silver;
            this.txbTelefono.BorderRadius = 5;
            this.txbTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTelefono.DefaultText = "";
            this.txbTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTelefono.DisabledState.Parent = this.txbTelefono;
            this.txbTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTelefono.FocusedState.Parent = this.txbTelefono;
            this.txbTelefono.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.txbTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTelefono.HoverState.Parent = this.txbTelefono;
            this.txbTelefono.Location = new System.Drawing.Point(180, 62);
            this.txbTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.PasswordChar = '\0';
            this.txbTelefono.PlaceholderText = "";
            this.txbTelefono.SelectedText = "";
            this.txbTelefono.ShadowDecoration.Parent = this.txbTelefono;
            this.txbTelefono.Size = new System.Drawing.Size(220, 35);
            this.txbTelefono.TabIndex = 62;
            this.txbTelefono.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label7.Location = new System.Drawing.Point(24, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 21);
            this.label7.TabIndex = 61;
            this.label7.Text = "Teléfono:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label8.Location = new System.Drawing.Point(24, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 21);
            this.label8.TabIndex = 60;
            this.label8.Text = "NIT:";
            // 
            // panelDatosEmpresa
            // 
            this.panelDatosEmpresa.Controls.Add(this.txbNombreEmpresa);
            this.panelDatosEmpresa.Controls.Add(this.label1);
            this.panelDatosEmpresa.CustomBorderColor = System.Drawing.Color.Silver;
            this.panelDatosEmpresa.CustomBorderThickness = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.panelDatosEmpresa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDatosEmpresa.Location = new System.Drawing.Point(0, 257);
            this.panelDatosEmpresa.Name = "panelDatosEmpresa";
            this.panelDatosEmpresa.ShadowDecoration.Parent = this.panelDatosEmpresa;
            this.panelDatosEmpresa.Size = new System.Drawing.Size(444, 53);
            this.panelDatosEmpresa.TabIndex = 19;
            // 
            // txbNombreEmpresa
            // 
            this.txbNombreEmpresa.BorderColor = System.Drawing.Color.Silver;
            this.txbNombreEmpresa.BorderRadius = 5;
            this.txbNombreEmpresa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNombreEmpresa.DefaultText = "";
            this.txbNombreEmpresa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbNombreEmpresa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbNombreEmpresa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNombreEmpresa.DisabledState.Parent = this.txbNombreEmpresa;
            this.txbNombreEmpresa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNombreEmpresa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNombreEmpresa.FocusedState.Parent = this.txbNombreEmpresa;
            this.txbNombreEmpresa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombreEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.txbNombreEmpresa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNombreEmpresa.HoverState.Parent = this.txbNombreEmpresa;
            this.txbNombreEmpresa.Location = new System.Drawing.Point(180, 9);
            this.txbNombreEmpresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbNombreEmpresa.Name = "txbNombreEmpresa";
            this.txbNombreEmpresa.PasswordChar = '\0';
            this.txbNombreEmpresa.PlaceholderText = "";
            this.txbNombreEmpresa.SelectedText = "";
            this.txbNombreEmpresa.ShadowDecoration.Parent = this.txbNombreEmpresa;
            this.txbNombreEmpresa.Size = new System.Drawing.Size(220, 35);
            this.txbNombreEmpresa.TabIndex = 47;
            this.txbNombreEmpresa.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Razón Social:";
            // 
            // panelDatosPersona
            // 
            this.panelDatosPersona.Controls.Add(this.txbDUI);
            this.panelDatosPersona.Controls.Add(this.label2);
            this.panelDatosPersona.Controls.Add(this.txbNombres);
            this.panelDatosPersona.Controls.Add(this.txbApellidos);
            this.panelDatosPersona.Controls.Add(this.label5);
            this.panelDatosPersona.Controls.Add(this.label4);
            this.panelDatosPersona.CustomBorderColor = System.Drawing.Color.Silver;
            this.panelDatosPersona.CustomBorderThickness = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.panelDatosPersona.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDatosPersona.Location = new System.Drawing.Point(0, 98);
            this.panelDatosPersona.Name = "panelDatosPersona";
            this.panelDatosPersona.ShadowDecoration.Parent = this.panelDatosPersona;
            this.panelDatosPersona.Size = new System.Drawing.Size(444, 159);
            this.panelDatosPersona.TabIndex = 18;
            // 
            // txbDUI
            // 
            this.txbDUI.BorderColor = System.Drawing.Color.Silver;
            this.txbDUI.BorderRadius = 5;
            this.txbDUI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDUI.DefaultText = "";
            this.txbDUI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbDUI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbDUI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbDUI.DisabledState.Parent = this.txbDUI;
            this.txbDUI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbDUI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbDUI.FocusedState.Parent = this.txbDUI;
            this.txbDUI.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDUI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.txbDUI.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbDUI.HoverState.Parent = this.txbDUI;
            this.txbDUI.Location = new System.Drawing.Point(180, 115);
            this.txbDUI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbDUI.Name = "txbDUI";
            this.txbDUI.PasswordChar = '\0';
            this.txbDUI.PlaceholderText = "";
            this.txbDUI.SelectedText = "";
            this.txbDUI.ShadowDecoration.Parent = this.txbDUI;
            this.txbDUI.Size = new System.Drawing.Size(220, 35);
            this.txbDUI.TabIndex = 51;
            this.txbDUI.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(24, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "DUI:";
            // 
            // txbNombres
            // 
            this.txbNombres.BorderColor = System.Drawing.Color.Silver;
            this.txbNombres.BorderRadius = 5;
            this.txbNombres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNombres.DefaultText = "";
            this.txbNombres.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbNombres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbNombres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNombres.DisabledState.Parent = this.txbNombres;
            this.txbNombres.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNombres.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNombres.FocusedState.Parent = this.txbNombres;
            this.txbNombres.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.txbNombres.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNombres.HoverState.Parent = this.txbNombres;
            this.txbNombres.Location = new System.Drawing.Point(180, 9);
            this.txbNombres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbNombres.Name = "txbNombres";
            this.txbNombres.PasswordChar = '\0';
            this.txbNombres.PlaceholderText = "";
            this.txbNombres.SelectedText = "";
            this.txbNombres.ShadowDecoration.Parent = this.txbNombres;
            this.txbNombres.Size = new System.Drawing.Size(220, 35);
            this.txbNombres.TabIndex = 49;
            this.txbNombres.TabStop = false;
            // 
            // txbApellidos
            // 
            this.txbApellidos.BorderColor = System.Drawing.Color.Silver;
            this.txbApellidos.BorderRadius = 5;
            this.txbApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbApellidos.DefaultText = "";
            this.txbApellidos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbApellidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbApellidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbApellidos.DisabledState.Parent = this.txbApellidos;
            this.txbApellidos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbApellidos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbApellidos.FocusedState.Parent = this.txbApellidos;
            this.txbApellidos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.txbApellidos.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbApellidos.HoverState.Parent = this.txbApellidos;
            this.txbApellidos.Location = new System.Drawing.Point(180, 63);
            this.txbApellidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbApellidos.Name = "txbApellidos";
            this.txbApellidos.PasswordChar = '\0';
            this.txbApellidos.PlaceholderText = "";
            this.txbApellidos.SelectedText = "";
            this.txbApellidos.ShadowDecoration.Parent = this.txbApellidos;
            this.txbApellidos.Size = new System.Drawing.Size(220, 35);
            this.txbApellidos.TabIndex = 48;
            this.txbApellidos.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label5.Location = new System.Drawing.Point(24, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label4.Location = new System.Drawing.Point(24, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Nombres:";
            // 
            // panelTipoCliente
            // 
            this.panelTipoCliente.BorderColor = System.Drawing.Color.Silver;
            this.panelTipoCliente.Controls.Add(this.paneltxbTipoCliente);
            this.panelTipoCliente.Controls.Add(this.label3);
            this.panelTipoCliente.CustomBorderColor = System.Drawing.Color.Silver;
            this.panelTipoCliente.CustomBorderThickness = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.panelTipoCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTipoCliente.Location = new System.Drawing.Point(0, 0);
            this.panelTipoCliente.Name = "panelTipoCliente";
            this.panelTipoCliente.ShadowDecoration.Parent = this.panelTipoCliente;
            this.panelTipoCliente.Size = new System.Drawing.Size(444, 98);
            this.panelTipoCliente.TabIndex = 17;
            // 
            // paneltxbTipoCliente
            // 
            this.paneltxbTipoCliente.BackColor = System.Drawing.Color.White;
            this.paneltxbTipoCliente.BorderColor = System.Drawing.Color.Silver;
            this.paneltxbTipoCliente.BorderRadius = 5;
            this.paneltxbTipoCliente.BorderThickness = 1;
            this.paneltxbTipoCliente.Controls.Add(this.cbbSeleccionarTipoCliente);
            this.paneltxbTipoCliente.Location = new System.Drawing.Point(180, 51);
            this.paneltxbTipoCliente.Name = "paneltxbTipoCliente";
            this.paneltxbTipoCliente.ShadowDecoration.Parent = this.paneltxbTipoCliente;
            this.paneltxbTipoCliente.Size = new System.Drawing.Size(220, 35);
            this.paneltxbTipoCliente.TabIndex = 49;
            // 
            // cbbSeleccionarTipoCliente
            // 
            this.cbbSeleccionarTipoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbSeleccionarTipoCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSeleccionarTipoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.cbbSeleccionarTipoCliente.FormattingEnabled = true;
            this.cbbSeleccionarTipoCliente.Items.AddRange(new object[] {
            "Empresa",
            "Persona Natural"});
            this.cbbSeleccionarTipoCliente.Location = new System.Drawing.Point(12, 3);
            this.cbbSeleccionarTipoCliente.Name = "cbbSeleccionarTipoCliente";
            this.cbbSeleccionarTipoCliente.Size = new System.Drawing.Size(205, 29);
            this.cbbSeleccionarTipoCliente.TabIndex = 0;
            this.cbbSeleccionarTipoCliente.TabStop = false;
            this.cbbSeleccionarTipoCliente.Text = "Seleccionar";
            this.cbbSeleccionarTipoCliente.SelectedIndexChanged += new System.EventHandler(this.cbbSeleccionarTipoCliente_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label3.Location = new System.Drawing.Point(24, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Tipo de Cliente:";
            // 
            // panelTituloAddClt
            // 
            this.panelTituloAddClt.BackColor = System.Drawing.Color.White;
            this.panelTituloAddClt.BorderColor = System.Drawing.Color.Silver;
            this.panelTituloAddClt.BorderRadius = 4;
            this.panelTituloAddClt.BorderThickness = 2;
            this.panelTituloAddClt.Controls.Add(this.lblAgregaraCatalogo);
            this.panelTituloAddClt.Controls.Add(this.btnCerrarAgregarClt);
            this.panelTituloAddClt.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloAddClt.Location = new System.Drawing.Point(0, 0);
            this.panelTituloAddClt.Name = "panelTituloAddClt";
            this.panelTituloAddClt.ShadowDecoration.Parent = this.panelTituloAddClt;
            this.panelTituloAddClt.Size = new System.Drawing.Size(444, 78);
            this.panelTituloAddClt.TabIndex = 2;
            // 
            // lblAgregaraCatalogo
            // 
            this.lblAgregaraCatalogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAgregaraCatalogo.AutoSize = true;
            this.lblAgregaraCatalogo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregaraCatalogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.lblAgregaraCatalogo.Location = new System.Drawing.Point(148, 40);
            this.lblAgregaraCatalogo.Name = "lblAgregaraCatalogo";
            this.lblAgregaraCatalogo.Size = new System.Drawing.Size(149, 19);
            this.lblAgregaraCatalogo.TabIndex = 20;
            this.lblAgregaraCatalogo.Text = "AGREGAR CLIENTE";
            // 
            // btnCerrarAgregarClt
            // 
            this.btnCerrarAgregarClt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarAgregarClt.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarAgregarClt.Image")));
            this.btnCerrarAgregarClt.Location = new System.Drawing.Point(416, 7);
            this.btnCerrarAgregarClt.Name = "btnCerrarAgregarClt";
            this.btnCerrarAgregarClt.Size = new System.Drawing.Size(21, 21);
            this.btnCerrarAgregarClt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrarAgregarClt.TabIndex = 19;
            this.btnCerrarAgregarClt.TabStop = false;
            this.btnCerrarAgregarClt.Click += new System.EventHandler(this.btnCerrarAgregarClt_Click);
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(444, 701);
            this.Controls.Add(this.panelConte);
            this.Controls.Add(this.panelTituloAddClt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AgregarCliente";
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            this.panelConte.ResumeLayout(false);
            this.panelConten.ResumeLayout(false);
            this.panelDatosGenerales.ResumeLayout(false);
            this.panelDatosGenerales.PerformLayout();
            this.panelDatosEmpresa.ResumeLayout(false);
            this.panelDatosEmpresa.PerformLayout();
            this.panelDatosPersona.ResumeLayout(false);
            this.panelDatosPersona.PerformLayout();
            this.panelTipoCliente.ResumeLayout(false);
            this.panelTipoCliente.PerformLayout();
            this.paneltxbTipoCliente.ResumeLayout(false);
            this.panelTituloAddClt.ResumeLayout(false);
            this.panelTituloAddClt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarAgregarClt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConte;
        private Guna.UI2.WinForms.Guna2Panel panelConten;
        private Guna.UI2.WinForms.Guna2Panel panelDatosGenerales;
        private Guna.UI2.WinForms.Guna2Button btnCancelarAddPdCl;
        private Guna.UI2.WinForms.Guna2Button btnAgregarAddPdCl;
        private Guna.UI2.WinForms.Guna2TextBox txbCorreo;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txbDireccion;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txbNIT;
        private Guna.UI2.WinForms.Guna2TextBox txbTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Panel panelDatosEmpresa;
        private Guna.UI2.WinForms.Guna2TextBox txbNombreEmpresa;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel panelDatosPersona;
        private Guna.UI2.WinForms.Guna2TextBox txbDUI;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txbNombres;
        private Guna.UI2.WinForms.Guna2TextBox txbApellidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel panelTipoCliente;
        private Guna.UI2.WinForms.Guna2Panel paneltxbTipoCliente;
        private System.Windows.Forms.ComboBox cbbSeleccionarTipoCliente;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel panelTituloAddClt;
        private System.Windows.Forms.Label lblAgregaraCatalogo;
        private System.Windows.Forms.PictureBox btnCerrarAgregarClt;
        public System.Windows.Forms.ErrorProvider Notificador;
    }
}