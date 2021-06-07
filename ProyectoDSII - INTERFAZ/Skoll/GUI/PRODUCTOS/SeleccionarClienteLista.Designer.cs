namespace Skoll.GUI.PRODUCTOS
{
    partial class SeleccionarClienteLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarClienteLista));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSCL = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSCA = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelarAddPdC = new Guna.UI2.WinForms.Guna2Button();
            this.btnAceptar = new Guna.UI2.WinForms.Guna2Button();
            this.panelDtgCatalogos = new System.Windows.Forms.Panel();
            this.dtgSelecCliente = new System.Windows.Forms.DataGridView();
            this.txbBuscarPDC = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelTituloAddPdZnBd = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCerrarSCL = new System.Windows.Forms.PictureBox();
            this.lblAgregaraCatalogo = new System.Windows.Forms.Label();
            this.btnCerrarAgregarPdC2 = new System.Windows.Forms.PictureBox();
            this.IDContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InicioArrendamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinArrendamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSCL.SuspendLayout();
            this.panelSCA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.panelDtgCatalogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSelecCliente)).BeginInit();
            this.panelTituloAddPdZnBd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSCL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarAgregarPdC2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSCL
            // 
            this.panelSCL.Controls.Add(this.panelSCA);
            this.panelSCL.Controls.Add(this.panelTituloAddPdZnBd);
            this.panelSCL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSCL.Location = new System.Drawing.Point(0, 0);
            this.panelSCL.Name = "panelSCL";
            this.panelSCL.ShadowDecoration.Parent = this.panelSCL;
            this.panelSCL.Size = new System.Drawing.Size(730, 465);
            this.panelSCL.TabIndex = 0;
            // 
            // panelSCA
            // 
            this.panelSCA.BorderColor = System.Drawing.Color.Silver;
            this.panelSCA.BorderRadius = 5;
            this.panelSCA.BorderThickness = 1;
            this.panelSCA.Controls.Add(this.guna2VSeparator1);
            this.panelSCA.Controls.Add(this.pbSearch);
            this.panelSCA.Controls.Add(this.label2);
            this.panelSCA.Controls.Add(this.btnCancelarAddPdC);
            this.panelSCA.Controls.Add(this.btnAceptar);
            this.panelSCA.Controls.Add(this.panelDtgCatalogos);
            this.panelSCA.Controls.Add(this.txbBuscarPDC);
            this.panelSCA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSCA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.panelSCA.Location = new System.Drawing.Point(0, 39);
            this.panelSCA.Name = "panelSCA";
            this.panelSCA.ShadowDecoration.Parent = this.panelSCA;
            this.panelSCA.Size = new System.Drawing.Size(730, 426);
            this.panelSCA.TabIndex = 57;
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
            this.label2.Location = new System.Drawing.Point(195, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ingrese el Nombre del Cliente:";
            // 
            // btnCancelarAddPdC
            // 
            this.btnCancelarAddPdC.BorderRadius = 5;
            this.btnCancelarAddPdC.CheckedState.Parent = this.btnCancelarAddPdC;
            this.btnCancelarAddPdC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarAddPdC.CustomImages.Parent = this.btnCancelarAddPdC;
            this.btnCancelarAddPdC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(79)))), ((int)(((byte)(83)))));
            this.btnCancelarAddPdC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAddPdC.ForeColor = System.Drawing.Color.White;
            this.btnCancelarAddPdC.HoverState.Parent = this.btnCancelarAddPdC;
            this.btnCancelarAddPdC.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarAddPdC.Image")));
            this.btnCancelarAddPdC.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancelarAddPdC.ImageSize = new System.Drawing.Size(19, 19);
            this.btnCancelarAddPdC.Location = new System.Drawing.Point(594, 375);
            this.btnCancelarAddPdC.Name = "btnCancelarAddPdC";
            this.btnCancelarAddPdC.ShadowDecoration.Parent = this.btnCancelarAddPdC;
            this.btnCancelarAddPdC.Size = new System.Drawing.Size(110, 40);
            this.btnCancelarAddPdC.TabIndex = 46;
            this.btnCancelarAddPdC.Text = "CANCELAR";
            this.btnCancelarAddPdC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCancelarAddPdC.TextOffset = new System.Drawing.Point(4, 0);
            this.btnCancelarAddPdC.Click += new System.EventHandler(this.btnCancelarAddPdC_Click);
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
            this.panelDtgCatalogos.Controls.Add(this.dtgSelecCliente);
            this.panelDtgCatalogos.Location = new System.Drawing.Point(23, 83);
            this.panelDtgCatalogos.Name = "panelDtgCatalogos";
            this.panelDtgCatalogos.Size = new System.Drawing.Size(681, 274);
            this.panelDtgCatalogos.TabIndex = 9;
            // 
            // dtgSelecCliente
            // 
            this.dtgSelecCliente.AllowUserToAddRows = false;
            this.dtgSelecCliente.AllowUserToDeleteRows = false;
            this.dtgSelecCliente.AllowUserToResizeColumns = false;
            this.dtgSelecCliente.AllowUserToResizeRows = false;
            this.dtgSelecCliente.BackgroundColor = System.Drawing.Color.White;
            this.dtgSelecCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgSelecCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgSelecCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSelecCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgSelecCliente.ColumnHeadersHeight = 45;
            this.dtgSelecCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgSelecCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDContrato,
            this.Cliente,
            this.TipoContrato,
            this.InicioArrendamiento,
            this.FinArrendamiento});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSelecCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgSelecCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgSelecCliente.EnableHeadersVisualStyles = false;
            this.dtgSelecCliente.GridColor = System.Drawing.Color.White;
            this.dtgSelecCliente.Location = new System.Drawing.Point(0, 0);
            this.dtgSelecCliente.MultiSelect = false;
            this.dtgSelecCliente.Name = "dtgSelecCliente";
            this.dtgSelecCliente.ReadOnly = true;
            this.dtgSelecCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSelecCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgSelecCliente.RowHeadersVisible = false;
            this.dtgSelecCliente.RowTemplate.Height = 28;
            this.dtgSelecCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSelecCliente.Size = new System.Drawing.Size(681, 274);
            this.dtgSelecCliente.TabIndex = 5;
            // 
            // txbBuscarPDC
            // 
            this.txbBuscarPDC.BorderColor = System.Drawing.Color.Silver;
            this.txbBuscarPDC.BorderRadius = 8;
            this.txbBuscarPDC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbBuscarPDC.DefaultText = "";
            this.txbBuscarPDC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbBuscarPDC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbBuscarPDC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbBuscarPDC.DisabledState.Parent = this.txbBuscarPDC;
            this.txbBuscarPDC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbBuscarPDC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbBuscarPDC.FocusedState.Parent = this.txbBuscarPDC;
            this.txbBuscarPDC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbBuscarPDC.HoverState.Parent = this.txbBuscarPDC;
            this.txbBuscarPDC.Location = new System.Drawing.Point(441, 31);
            this.txbBuscarPDC.Name = "txbBuscarPDC";
            this.txbBuscarPDC.PasswordChar = '\0';
            this.txbBuscarPDC.PlaceholderText = "Buscar...";
            this.txbBuscarPDC.SelectedText = "";
            this.txbBuscarPDC.ShadowDecoration.Parent = this.txbBuscarPDC;
            this.txbBuscarPDC.Size = new System.Drawing.Size(263, 35);
            this.txbBuscarPDC.TabIndex = 5;
            // 
            // panelTituloAddPdZnBd
            // 
            this.panelTituloAddPdZnBd.BackColor = System.Drawing.Color.White;
            this.panelTituloAddPdZnBd.BorderColor = System.Drawing.Color.Silver;
            this.panelTituloAddPdZnBd.BorderRadius = 4;
            this.panelTituloAddPdZnBd.BorderThickness = 1;
            this.panelTituloAddPdZnBd.Controls.Add(this.btnCerrarSCL);
            this.panelTituloAddPdZnBd.Controls.Add(this.lblAgregaraCatalogo);
            this.panelTituloAddPdZnBd.Controls.Add(this.btnCerrarAgregarPdC2);
            this.panelTituloAddPdZnBd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloAddPdZnBd.Location = new System.Drawing.Point(0, 0);
            this.panelTituloAddPdZnBd.Name = "panelTituloAddPdZnBd";
            this.panelTituloAddPdZnBd.ShadowDecoration.Parent = this.panelTituloAddPdZnBd;
            this.panelTituloAddPdZnBd.Size = new System.Drawing.Size(730, 39);
            this.panelTituloAddPdZnBd.TabIndex = 56;
            // 
            // btnCerrarSCL
            // 
            this.btnCerrarSCL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSCL.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSCL.Image")));
            this.btnCerrarSCL.Location = new System.Drawing.Point(703, 6);
            this.btnCerrarSCL.Name = "btnCerrarSCL";
            this.btnCerrarSCL.Size = new System.Drawing.Size(21, 21);
            this.btnCerrarSCL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrarSCL.TabIndex = 21;
            this.btnCerrarSCL.TabStop = false;
            this.btnCerrarSCL.Click += new System.EventHandler(this.btnCerrarSCL_Click);
            // 
            // lblAgregaraCatalogo
            // 
            this.lblAgregaraCatalogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAgregaraCatalogo.AutoSize = true;
            this.lblAgregaraCatalogo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregaraCatalogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.lblAgregaraCatalogo.Location = new System.Drawing.Point(274, 9);
            this.lblAgregaraCatalogo.Name = "lblAgregaraCatalogo";
            this.lblAgregaraCatalogo.Size = new System.Drawing.Size(205, 19);
            this.lblAgregaraCatalogo.TabIndex = 20;
            this.lblAgregaraCatalogo.Text = "SELECCIONAR CONTRATO";
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
            // IDContrato
            // 
            this.IDContrato.DataPropertyName = "ID_Contrato";
            this.IDContrato.HeaderText = "IDContrato";
            this.IDContrato.Name = "IDContrato";
            this.IDContrato.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // TipoContrato
            // 
            this.TipoContrato.DataPropertyName = "Tipo_Contrato";
            this.TipoContrato.HeaderText = "Tipo de Contrato";
            this.TipoContrato.Name = "TipoContrato";
            this.TipoContrato.ReadOnly = true;
            this.TipoContrato.Width = 120;
            // 
            // InicioArrendamiento
            // 
            this.InicioArrendamiento.DataPropertyName = "Inicio_Arrendamiento";
            this.InicioArrendamiento.HeaderText = "Inicio Arrendamiento";
            this.InicioArrendamiento.Name = "InicioArrendamiento";
            this.InicioArrendamiento.ReadOnly = true;
            this.InicioArrendamiento.Width = 115;
            // 
            // FinArrendamiento
            // 
            this.FinArrendamiento.DataPropertyName = "Fin_Arrendamiento";
            this.FinArrendamiento.HeaderText = "Fin Arrendamiento";
            this.FinArrendamiento.Name = "FinArrendamiento";
            this.FinArrendamiento.ReadOnly = true;
            this.FinArrendamiento.Width = 115;
            // 
            // SeleccionarClienteLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(730, 465);
            this.Controls.Add(this.panelSCL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeleccionarClienteLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionarClienteLista";
            this.Load += new System.EventHandler(this.SeleccionarClienteLista_Load);
            this.panelSCL.ResumeLayout(false);
            this.panelSCA.ResumeLayout(false);
            this.panelSCA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.panelDtgCatalogos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSelecCliente)).EndInit();
            this.panelTituloAddPdZnBd.ResumeLayout(false);
            this.panelTituloAddPdZnBd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSCL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarAgregarPdC2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelSCL;
        private Guna.UI2.WinForms.Guna2Panel panelSCA;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnCancelarAddPdC;
        private Guna.UI2.WinForms.Guna2Button btnAceptar;
        private System.Windows.Forms.Panel panelDtgCatalogos;
        private System.Windows.Forms.DataGridView dtgSelecCliente;
        private Guna.UI2.WinForms.Guna2TextBox txbBuscarPDC;
        private Guna.UI2.WinForms.Guna2Panel panelTituloAddPdZnBd;
        private System.Windows.Forms.PictureBox btnCerrarSCL;
        private System.Windows.Forms.Label lblAgregaraCatalogo;
        private System.Windows.Forms.PictureBox btnCerrarAgregarPdC2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn InicioArrendamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinArrendamiento;
    }
}