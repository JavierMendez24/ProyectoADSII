namespace GestionGeneral.GUI.USUARIOS
{
    partial class EditarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarEmpleado));
            this.panelAgregarContrato = new Guna.UI2.WinForms.Guna2Panel();
            this.lblIDUsuario = new System.Windows.Forms.Label();
            this.panelSeleccionarRol = new Guna.UI2.WinForms.Guna2Panel();
            this.cbbSeleccionarRol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCancelEditUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditUser = new Guna.UI2.WinForms.Guna2Button();
            this.txbEmpleado = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panelTituloAddPdCtg = new Guna.UI2.WinForms.Guna2Panel();
            this.lblEditarCatalogo = new System.Windows.Forms.Label();
            this.btnCloseEditUser = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbClave = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblIDEmpleado = new System.Windows.Forms.Label();
            this.panelAgregarContrato.SuspendLayout();
            this.panelSeleccionarRol.SuspendLayout();
            this.panelTituloAddPdCtg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseEditUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAgregarContrato
            // 
            this.panelAgregarContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.panelAgregarContrato.BorderColor = System.Drawing.Color.Silver;
            this.panelAgregarContrato.BorderRadius = 4;
            this.panelAgregarContrato.BorderThickness = 1;
            this.panelAgregarContrato.Controls.Add(this.lblIDEmpleado);
            this.panelAgregarContrato.Controls.Add(this.lblIDUsuario);
            this.panelAgregarContrato.Controls.Add(this.panelSeleccionarRol);
            this.panelAgregarContrato.Controls.Add(this.label1);
            this.panelAgregarContrato.Controls.Add(this.txbUsuario);
            this.panelAgregarContrato.Controls.Add(this.btnCancelEditUser);
            this.panelAgregarContrato.Controls.Add(this.btnEditUser);
            this.panelAgregarContrato.Controls.Add(this.txbEmpleado);
            this.panelAgregarContrato.Controls.Add(this.label10);
            this.panelAgregarContrato.Controls.Add(this.panelTituloAddPdCtg);
            this.panelAgregarContrato.Controls.Add(this.label8);
            this.panelAgregarContrato.Controls.Add(this.txbClave);
            this.panelAgregarContrato.Controls.Add(this.label4);
            this.panelAgregarContrato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAgregarContrato.Location = new System.Drawing.Point(0, 0);
            this.panelAgregarContrato.Name = "panelAgregarContrato";
            this.panelAgregarContrato.ShadowDecoration.Parent = this.panelAgregarContrato;
            this.panelAgregarContrato.Size = new System.Drawing.Size(401, 440);
            this.panelAgregarContrato.TabIndex = 6;
            // 
            // lblIDUsuario
            // 
            this.lblIDUsuario.AutoSize = true;
            this.lblIDUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.lblIDUsuario.Location = new System.Drawing.Point(38, 101);
            this.lblIDUsuario.Name = "lblIDUsuario";
            this.lblIDUsuario.Size = new System.Drawing.Size(54, 13);
            this.lblIDUsuario.TabIndex = 83;
            this.lblIDUsuario.Text = "IDUsuario";
            this.lblIDUsuario.Visible = false;
            // 
            // panelSeleccionarRol
            // 
            this.panelSeleccionarRol.BackColor = System.Drawing.Color.White;
            this.panelSeleccionarRol.BorderColor = System.Drawing.Color.Silver;
            this.panelSeleccionarRol.BorderRadius = 5;
            this.panelSeleccionarRol.BorderThickness = 1;
            this.panelSeleccionarRol.Controls.Add(this.cbbSeleccionarRol);
            this.panelSeleccionarRol.Location = new System.Drawing.Point(145, 291);
            this.panelSeleccionarRol.Name = "panelSeleccionarRol";
            this.panelSeleccionarRol.ShadowDecoration.Parent = this.panelSeleccionarRol;
            this.panelSeleccionarRol.Size = new System.Drawing.Size(220, 35);
            this.panelSeleccionarRol.TabIndex = 81;
            // 
            // cbbSeleccionarRol
            // 
            this.cbbSeleccionarRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSeleccionarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbSeleccionarRol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSeleccionarRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.cbbSeleccionarRol.FormattingEnabled = true;
            this.cbbSeleccionarRol.Location = new System.Drawing.Point(12, 3);
            this.cbbSeleccionarRol.Name = "cbbSeleccionarRol";
            this.cbbSeleccionarRol.Size = new System.Drawing.Size(205, 29);
            this.cbbSeleccionarRol.TabIndex = 0;
            this.cbbSeleccionarRol.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(21, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 69;
            this.label1.Text = "Contraseña:";
            // 
            // txbUsuario
            // 
            this.txbUsuario.BorderColor = System.Drawing.Color.Silver;
            this.txbUsuario.BorderRadius = 5;
            this.txbUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbUsuario.DefaultText = "";
            this.txbUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbUsuario.DisabledState.Parent = this.txbUsuario;
            this.txbUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbUsuario.FocusedState.Parent = this.txbUsuario;
            this.txbUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.txbUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbUsuario.HoverState.Parent = this.txbUsuario;
            this.txbUsuario.Location = new System.Drawing.Point(145, 183);
            this.txbUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.PasswordChar = '\0';
            this.txbUsuario.PlaceholderText = "";
            this.txbUsuario.SelectedText = "";
            this.txbUsuario.ShadowDecoration.Parent = this.txbUsuario;
            this.txbUsuario.Size = new System.Drawing.Size(220, 35);
            this.txbUsuario.TabIndex = 68;
            this.txbUsuario.TabStop = false;
            // 
            // btnCancelEditUser
            // 
            this.btnCancelEditUser.BorderRadius = 5;
            this.btnCancelEditUser.CheckedState.Parent = this.btnCancelEditUser;
            this.btnCancelEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelEditUser.CustomImages.Parent = this.btnCancelEditUser;
            this.btnCancelEditUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(79)))), ((int)(((byte)(83)))));
            this.btnCancelEditUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEditUser.ForeColor = System.Drawing.Color.White;
            this.btnCancelEditUser.HoverState.Parent = this.btnCancelEditUser;
            this.btnCancelEditUser.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelEditUser.Image")));
            this.btnCancelEditUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancelEditUser.ImageSize = new System.Drawing.Size(19, 19);
            this.btnCancelEditUser.Location = new System.Drawing.Point(256, 372);
            this.btnCancelEditUser.Name = "btnCancelEditUser";
            this.btnCancelEditUser.ShadowDecoration.Parent = this.btnCancelEditUser;
            this.btnCancelEditUser.Size = new System.Drawing.Size(110, 40);
            this.btnCancelEditUser.TabIndex = 67;
            this.btnCancelEditUser.Text = "CANCELAR";
            this.btnCancelEditUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCancelEditUser.TextOffset = new System.Drawing.Point(4, 0);
            this.btnCancelEditUser.Click += new System.EventHandler(this.btnCancelEditUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.BorderRadius = 5;
            this.btnEditUser.CheckedState.Parent = this.btnEditUser;
            this.btnEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditUser.CustomImages.Parent = this.btnEditUser;
            this.btnEditUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(182)))), ((int)(((byte)(146)))));
            this.btnEditUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.ForeColor = System.Drawing.Color.White;
            this.btnEditUser.HoverState.Parent = this.btnEditUser;
            this.btnEditUser.Image = ((System.Drawing.Image)(resources.GetObject("btnEditUser.Image")));
            this.btnEditUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEditUser.ImageSize = new System.Drawing.Size(19, 19);
            this.btnEditUser.Location = new System.Drawing.Point(133, 372);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.ShadowDecoration.Parent = this.btnEditUser;
            this.btnEditUser.Size = new System.Drawing.Size(110, 40);
            this.btnEditUser.TabIndex = 66;
            this.btnEditUser.Text = "GUARDAR";
            this.btnEditUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // txbEmpleado
            // 
            this.txbEmpleado.BorderColor = System.Drawing.Color.Silver;
            this.txbEmpleado.BorderRadius = 5;
            this.txbEmpleado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEmpleado.DefaultText = "";
            this.txbEmpleado.DisabledState.BorderColor = System.Drawing.Color.Silver;
            this.txbEmpleado.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbEmpleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEmpleado.DisabledState.Parent = this.txbEmpleado;
            this.txbEmpleado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEmpleado.Enabled = false;
            this.txbEmpleado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEmpleado.FocusedState.Parent = this.txbEmpleado;
            this.txbEmpleado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.txbEmpleado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEmpleado.HoverState.Parent = this.txbEmpleado;
            this.txbEmpleado.Location = new System.Drawing.Point(145, 129);
            this.txbEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbEmpleado.Name = "txbEmpleado";
            this.txbEmpleado.PasswordChar = '\0';
            this.txbEmpleado.PlaceholderText = "";
            this.txbEmpleado.SelectedText = "";
            this.txbEmpleado.ShadowDecoration.Parent = this.txbEmpleado;
            this.txbEmpleado.Size = new System.Drawing.Size(221, 35);
            this.txbEmpleado.TabIndex = 59;
            this.txbEmpleado.TabStop = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label10.Location = new System.Drawing.Point(21, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 21);
            this.label10.TabIndex = 58;
            this.label10.Text = "Empleado: ";
            // 
            // panelTituloAddPdCtg
            // 
            this.panelTituloAddPdCtg.BackColor = System.Drawing.Color.White;
            this.panelTituloAddPdCtg.BorderColor = System.Drawing.Color.Silver;
            this.panelTituloAddPdCtg.BorderRadius = 4;
            this.panelTituloAddPdCtg.BorderThickness = 2;
            this.panelTituloAddPdCtg.Controls.Add(this.lblEditarCatalogo);
            this.panelTituloAddPdCtg.Controls.Add(this.btnCloseEditUser);
            this.panelTituloAddPdCtg.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloAddPdCtg.Location = new System.Drawing.Point(0, 0);
            this.panelTituloAddPdCtg.Name = "panelTituloAddPdCtg";
            this.panelTituloAddPdCtg.ShadowDecoration.Parent = this.panelTituloAddPdCtg;
            this.panelTituloAddPdCtg.Size = new System.Drawing.Size(401, 85);
            this.panelTituloAddPdCtg.TabIndex = 57;
            // 
            // lblEditarCatalogo
            // 
            this.lblEditarCatalogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditarCatalogo.AutoSize = true;
            this.lblEditarCatalogo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarCatalogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.lblEditarCatalogo.Location = new System.Drawing.Point(130, 40);
            this.lblEditarCatalogo.Name = "lblEditarCatalogo";
            this.lblEditarCatalogo.Size = new System.Drawing.Size(140, 19);
            this.lblEditarCatalogo.TabIndex = 20;
            this.lblEditarCatalogo.Text = "EDITAR USUARIO";
            // 
            // btnCloseEditUser
            // 
            this.btnCloseEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseEditUser.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseEditUser.Image")));
            this.btnCloseEditUser.Location = new System.Drawing.Point(371, 7);
            this.btnCloseEditUser.Name = "btnCloseEditUser";
            this.btnCloseEditUser.Size = new System.Drawing.Size(21, 21);
            this.btnCloseEditUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCloseEditUser.TabIndex = 19;
            this.btnCloseEditUser.TabStop = false;
            this.btnCloseEditUser.Click += new System.EventHandler(this.btnCloseEditUser_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label8.Location = new System.Drawing.Point(21, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 21);
            this.label8.TabIndex = 47;
            this.label8.Text = "Rol:";
            // 
            // txbClave
            // 
            this.txbClave.BorderColor = System.Drawing.Color.Silver;
            this.txbClave.BorderRadius = 5;
            this.txbClave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbClave.DefaultText = "";
            this.txbClave.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbClave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbClave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbClave.DisabledState.Parent = this.txbClave;
            this.txbClave.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbClave.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbClave.FocusedState.Parent = this.txbClave;
            this.txbClave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.txbClave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbClave.HoverState.Parent = this.txbClave;
            this.txbClave.Location = new System.Drawing.Point(145, 237);
            this.txbClave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbClave.Name = "txbClave";
            this.txbClave.PasswordChar = '\0';
            this.txbClave.PlaceholderText = "";
            this.txbClave.SelectedText = "";
            this.txbClave.ShadowDecoration.Parent = this.txbClave;
            this.txbClave.Size = new System.Drawing.Size(220, 35);
            this.txbClave.TabIndex = 38;
            this.txbClave.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label4.Location = new System.Drawing.Point(21, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Usuario:";
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // lblIDEmpleado
            // 
            this.lblIDEmpleado.AutoSize = true;
            this.lblIDEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.lblIDEmpleado.Location = new System.Drawing.Point(130, 101);
            this.lblIDEmpleado.Name = "lblIDEmpleado";
            this.lblIDEmpleado.Size = new System.Drawing.Size(54, 13);
            this.lblIDEmpleado.TabIndex = 84;
            this.lblIDEmpleado.Text = "IDUsuario";
            this.lblIDEmpleado.Visible = false;
            // 
            // EditarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 440);
            this.Controls.Add(this.panelAgregarContrato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarEmpleado";
            this.Load += new System.EventHandler(this.EditarEmpleado_Load);
            this.panelAgregarContrato.ResumeLayout(false);
            this.panelAgregarContrato.PerformLayout();
            this.panelSeleccionarRol.ResumeLayout(false);
            this.panelTituloAddPdCtg.ResumeLayout(false);
            this.panelTituloAddPdCtg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseEditUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelAgregarContrato;
        private Guna.UI2.WinForms.Guna2Panel panelSeleccionarRol;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnCancelEditUser;
        private Guna.UI2.WinForms.Guna2Button btnEditUser;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Panel panelTituloAddPdCtg;
        private System.Windows.Forms.Label lblEditarCatalogo;
        private System.Windows.Forms.PictureBox btnCloseEditUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider Notificador;
        public System.Windows.Forms.ComboBox cbbSeleccionarRol;
        public Guna.UI2.WinForms.Guna2TextBox txbUsuario;
        public Guna.UI2.WinForms.Guna2TextBox txbEmpleado;
        public Guna.UI2.WinForms.Guna2TextBox txbClave;
        public System.Windows.Forms.Label lblIDUsuario;
        public System.Windows.Forms.Label lblIDEmpleado;
    }
}