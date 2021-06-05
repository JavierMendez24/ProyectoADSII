namespace Skoll.GUI.CONTRATOS
{
    partial class SeleccionarZonaContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarZonaContrato));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSCC = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAceptar = new Guna.UI2.WinForms.Guna2Button();
            this.panelDtgCatalogos = new System.Windows.Forms.Panel();
            this.dtgZonasCatalogo = new System.Windows.Forms.DataGridView();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID_Zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDetalleContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbBuscarZona = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelTituloAddPdZnBd = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblAgregaraCatalogo = new System.Windows.Forms.Label();
            this.btnCerrarAgregarPdC2 = new System.Windows.Forms.PictureBox();
            this.panelSCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.panelDtgCatalogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgZonasCatalogo)).BeginInit();
            this.panelTituloAddPdZnBd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarAgregarPdC2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSCC
            // 
            this.panelSCC.BorderColor = System.Drawing.Color.Silver;
            this.panelSCC.BorderRadius = 5;
            this.panelSCC.BorderThickness = 1;
            this.panelSCC.Controls.Add(this.guna2VSeparator1);
            this.panelSCC.Controls.Add(this.pbSearch);
            this.panelSCC.Controls.Add(this.label2);
            this.panelSCC.Controls.Add(this.btnCancelar);
            this.panelSCC.Controls.Add(this.btnAceptar);
            this.panelSCC.Controls.Add(this.panelDtgCatalogos);
            this.panelSCC.Controls.Add(this.txbBuscarZona);
            this.panelSCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.panelSCC.Location = new System.Drawing.Point(0, 39);
            this.panelSCC.Name = "panelSCC";
            this.panelSCC.ShadowDecoration.Parent = this.panelSCC;
            this.panelSCC.Size = new System.Drawing.Size(730, 426);
            this.panelSCC.TabIndex = 62;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.BackColor = System.Drawing.Color.White;
            this.guna2VSeparator1.FillColor = System.Drawing.Color.Silver;
            this.guna2VSeparator1.Location = new System.Drawing.Point(667, 35);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 27);
            this.guna2VSeparator1.TabIndex = 48;
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.White;
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.Location = new System.Drawing.Point(677, 38);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(20, 20);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 47;
            this.pbSearch.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(19, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Zonas asignadas al cliente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderRadius = 5;
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(79)))), ((int)(((byte)(83)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancelar.ImageSize = new System.Drawing.Size(19, 19);
            this.btnCancelar.Location = new System.Drawing.Point(594, 375);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(110, 40);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCancelar.TextOffset = new System.Drawing.Point(4, 0);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BorderRadius = 5;
            this.btnAceptar.CheckedState.Parent = this.btnAceptar;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.CustomImages.Parent = this.btnAceptar;
            this.btnAceptar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(182)))), ((int)(((byte)(146)))));
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.HoverState.Parent = this.btnAceptar;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAceptar.ImageSize = new System.Drawing.Size(19, 19);
            this.btnAceptar.Location = new System.Drawing.Point(471, 375);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.ShadowDecoration.Parent = this.btnAceptar;
            this.btnAceptar.Size = new System.Drawing.Size(110, 40);
            this.btnAceptar.TabIndex = 45;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // panelDtgCatalogos
            // 
            this.panelDtgCatalogos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDtgCatalogos.Controls.Add(this.dtgZonasCatalogo);
            this.panelDtgCatalogos.Location = new System.Drawing.Point(23, 83);
            this.panelDtgCatalogos.Name = "panelDtgCatalogos";
            this.panelDtgCatalogos.Size = new System.Drawing.Size(681, 274);
            this.panelDtgCatalogos.TabIndex = 9;
            // 
            // dtgZonasCatalogo
            // 
            this.dtgZonasCatalogo.AllowUserToAddRows = false;
            this.dtgZonasCatalogo.AllowUserToDeleteRows = false;
            this.dtgZonasCatalogo.AllowUserToResizeColumns = false;
            this.dtgZonasCatalogo.AllowUserToResizeRows = false;
            this.dtgZonasCatalogo.BackgroundColor = System.Drawing.Color.White;
            this.dtgZonasCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgZonasCatalogo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgZonasCatalogo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgZonasCatalogo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgZonasCatalogo.ColumnHeadersHeight = 35;
            this.dtgZonasCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgZonasCatalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion,
            this.ID_Zona,
            this.nombre,
            this.apellidos,
            this.IDDetalleContrato});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgZonasCatalogo.DefaultCellStyle = dataGridViewCellStyle11;
            this.dtgZonasCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgZonasCatalogo.EnableHeadersVisualStyles = false;
            this.dtgZonasCatalogo.GridColor = System.Drawing.Color.White;
            this.dtgZonasCatalogo.Location = new System.Drawing.Point(0, 0);
            this.dtgZonasCatalogo.Name = "dtgZonasCatalogo";
            this.dtgZonasCatalogo.ReadOnly = true;
            this.dtgZonasCatalogo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgZonasCatalogo.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgZonasCatalogo.RowHeadersVisible = false;
            this.dtgZonasCatalogo.RowTemplate.Height = 28;
            this.dtgZonasCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgZonasCatalogo.Size = new System.Drawing.Size(681, 274);
            this.dtgZonasCatalogo.TabIndex = 5;
            this.dtgZonasCatalogo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgZonasCatalogo_CellContentClick);
            // 
            // Seleccion
            // 
            this.Seleccion.DataPropertyName = "Seleccion";
            this.Seleccion.FalseValue = "0";
            this.Seleccion.HeaderText = "SELECCIÓN";
            this.Seleccion.IndeterminateValue = "0";
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.ReadOnly = true;
            this.Seleccion.TrueValue = "1";
            this.Seleccion.Width = 130;
            // 
            // ID_Zona
            // 
            this.ID_Zona.DataPropertyName = "ID_Zona";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID_Zona.DefaultCellStyle = dataGridViewCellStyle8;
            this.ID_Zona.HeaderText = "ID ZONA";
            this.ID_Zona.Name = "ID_Zona";
            this.ID_Zona.ReadOnly = true;
            this.ID_Zona.Width = 130;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.DataPropertyName = "Nombre_Zona";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.nombre.DefaultCellStyle = dataGridViewCellStyle9;
            this.nombre.HeaderText = "ZONA";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellidos
            // 
            this.apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellidos.DataPropertyName = "Nombre_Bodega";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.apellidos.DefaultCellStyle = dataGridViewCellStyle10;
            this.apellidos.HeaderText = "BODEGA";
            this.apellidos.Name = "apellidos";
            this.apellidos.ReadOnly = true;
            // 
            // IDDetalleContrato
            // 
            this.IDDetalleContrato.DataPropertyName = "ID_Detalle_Contrato";
            this.IDDetalleContrato.HeaderText = "IDDetalleContrato";
            this.IDDetalleContrato.Name = "IDDetalleContrato";
            this.IDDetalleContrato.ReadOnly = true;
            this.IDDetalleContrato.Visible = false;
            // 
            // txbBuscarZona
            // 
            this.txbBuscarZona.BorderColor = System.Drawing.Color.Silver;
            this.txbBuscarZona.BorderRadius = 8;
            this.txbBuscarZona.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbBuscarZona.DefaultText = "Buscar...";
            this.txbBuscarZona.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbBuscarZona.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbBuscarZona.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbBuscarZona.DisabledState.Parent = this.txbBuscarZona;
            this.txbBuscarZona.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbBuscarZona.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbBuscarZona.FocusedState.Parent = this.txbBuscarZona;
            this.txbBuscarZona.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarZona.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbBuscarZona.HoverState.Parent = this.txbBuscarZona;
            this.txbBuscarZona.Location = new System.Drawing.Point(441, 31);
            this.txbBuscarZona.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbBuscarZona.Name = "txbBuscarZona";
            this.txbBuscarZona.PasswordChar = '\0';
            this.txbBuscarZona.PlaceholderText = "";
            this.txbBuscarZona.SelectedText = "";
            this.txbBuscarZona.SelectionStart = 9;
            this.txbBuscarZona.ShadowDecoration.Parent = this.txbBuscarZona;
            this.txbBuscarZona.Size = new System.Drawing.Size(263, 35);
            this.txbBuscarZona.TabIndex = 5;
            // 
            // panelTituloAddPdZnBd
            // 
            this.panelTituloAddPdZnBd.BackColor = System.Drawing.Color.White;
            this.panelTituloAddPdZnBd.BorderColor = System.Drawing.Color.Silver;
            this.panelTituloAddPdZnBd.BorderRadius = 4;
            this.panelTituloAddPdZnBd.BorderThickness = 1;
            this.panelTituloAddPdZnBd.Controls.Add(this.btnCerrar);
            this.panelTituloAddPdZnBd.Controls.Add(this.lblAgregaraCatalogo);
            this.panelTituloAddPdZnBd.Controls.Add(this.btnCerrarAgregarPdC2);
            this.panelTituloAddPdZnBd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloAddPdZnBd.Location = new System.Drawing.Point(0, 0);
            this.panelTituloAddPdZnBd.Name = "panelTituloAddPdZnBd";
            this.panelTituloAddPdZnBd.ShadowDecoration.Parent = this.panelTituloAddPdZnBd;
            this.panelTituloAddPdZnBd.Size = new System.Drawing.Size(730, 39);
            this.panelTituloAddPdZnBd.TabIndex = 61;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(703, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 21);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblAgregaraCatalogo
            // 
            this.lblAgregaraCatalogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAgregaraCatalogo.AutoSize = true;
            this.lblAgregaraCatalogo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregaraCatalogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.lblAgregaraCatalogo.Location = new System.Drawing.Point(264, 9);
            this.lblAgregaraCatalogo.Name = "lblAgregaraCatalogo";
            this.lblAgregaraCatalogo.Size = new System.Drawing.Size(174, 19);
            this.lblAgregaraCatalogo.TabIndex = 20;
            this.lblAgregaraCatalogo.Text = "SELECCIONAR ZONAS";
            // 
            // btnCerrarAgregarPdC2
            // 
            this.btnCerrarAgregarPdC2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarAgregarPdC2.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarAgregarPdC2.Image")));
            this.btnCerrarAgregarPdC2.Location = new System.Drawing.Point(851, 8);
            this.btnCerrarAgregarPdC2.Name = "btnCerrarAgregarPdC2";
            this.btnCerrarAgregarPdC2.Size = new System.Drawing.Size(21, 21);
            this.btnCerrarAgregarPdC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrarAgregarPdC2.TabIndex = 19;
            this.btnCerrarAgregarPdC2.TabStop = false;
            // 
            // SeleccionarZonaContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 465);
            this.Controls.Add(this.panelSCC);
            this.Controls.Add(this.panelTituloAddPdZnBd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeleccionarZonaContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionarZonaContrato";
            this.Load += new System.EventHandler(this.SeleccionarZonaContrato_Load);
            this.panelSCC.ResumeLayout(false);
            this.panelSCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.panelDtgCatalogos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgZonasCatalogo)).EndInit();
            this.panelTituloAddPdZnBd.ResumeLayout(false);
            this.panelTituloAddPdZnBd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarAgregarPdC2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelSCC;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnAceptar;
        private System.Windows.Forms.Panel panelDtgCatalogos;
        private System.Windows.Forms.DataGridView dtgZonasCatalogo;
        private Guna.UI2.WinForms.Guna2TextBox txbBuscarZona;
        private Guna.UI2.WinForms.Guna2Panel panelTituloAddPdZnBd;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblAgregaraCatalogo;
        private System.Windows.Forms.PictureBox btnCerrarAgregarPdC2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Zona;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDetalleContrato;
    }
}