namespace Skoll.GUI.PRODUCTOS
{
    partial class AgregarProductosaBodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProductosaBodega));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSPPB = new Guna.UI2.WinForms.Guna2Panel();
            this.btnEliminarProducto = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnSeleccionarProductosdelCatalogo = new Guna.UI2.WinForms.Guna2Button();
            this.btnSeleccionarClienteAddPd = new Guna.UI2.WinForms.Guna2Button();
            this.txbContrato = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paneltxbznctg = new Guna.UI2.WinForms.Guna2Panel();
            this.cbbSeleccionarZonaCtg = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelDtgCatalogos = new System.Windows.Forms.Panel();
            this.dtgAddProductosBodega = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTituloAddPdZnBd = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAgregaraCatalogo = new System.Windows.Forms.Label();
            this.btnCerrarAgregarPdaB = new System.Windows.Forms.PictureBox();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblIDContrato = new System.Windows.Forms.Label();
            this.panelSPPB.SuspendLayout();
            this.paneltxbznctg.SuspendLayout();
            this.panelDtgCatalogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAddProductosBodega)).BeginInit();
            this.panelTituloAddPdZnBd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarAgregarPdaB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSPPB
            // 
            this.panelSPPB.BorderColor = System.Drawing.Color.Silver;
            this.panelSPPB.BorderRadius = 5;
            this.panelSPPB.BorderThickness = 1;
            this.panelSPPB.Controls.Add(this.lblIDContrato);
            this.panelSPPB.Controls.Add(this.btnEliminarProducto);
            this.panelSPPB.Controls.Add(this.btnCancelar);
            this.panelSPPB.Controls.Add(this.btnAgregar);
            this.panelSPPB.Controls.Add(this.btnSeleccionarProductosdelCatalogo);
            this.panelSPPB.Controls.Add(this.btnSeleccionarClienteAddPd);
            this.panelSPPB.Controls.Add(this.txbContrato);
            this.panelSPPB.Controls.Add(this.label3);
            this.panelSPPB.Controls.Add(this.label2);
            this.panelSPPB.Controls.Add(this.paneltxbznctg);
            this.panelSPPB.Controls.Add(this.label4);
            this.panelSPPB.Controls.Add(this.panelDtgCatalogos);
            this.panelSPPB.Controls.Add(this.panelTituloAddPdZnBd);
            this.panelSPPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSPPB.Location = new System.Drawing.Point(0, 0);
            this.panelSPPB.Name = "panelSPPB";
            this.panelSPPB.ShadowDecoration.Parent = this.panelSPPB;
            this.panelSPPB.Size = new System.Drawing.Size(880, 635);
            this.panelSPPB.TabIndex = 1;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BorderRadius = 6;
            this.btnEliminarProducto.CheckedState.Parent = this.btnEliminarProducto;
            this.btnEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProducto.CustomImages.Parent = this.btnEliminarProducto;
            this.btnEliminarProducto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(79)))), ((int)(((byte)(83)))));
            this.btnEliminarProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProducto.HoverState.Parent = this.btnEliminarProducto;
            this.btnEliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarProducto.Image")));
            this.btnEliminarProducto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEliminarProducto.ImageSize = new System.Drawing.Size(15, 15);
            this.btnEliminarProducto.Location = new System.Drawing.Point(530, 209);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.ShadowDecoration.Parent = this.btnEliminarProducto;
            this.btnEliminarProducto.Size = new System.Drawing.Size(100, 35);
            this.btnEliminarProducto.TabIndex = 64;
            this.btnEliminarProducto.Text = "ELIMINAR";
            this.btnEliminarProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEliminarProducto.TextOffset = new System.Drawing.Point(3, 0);
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(748, 592);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(107, 32);
            this.btnCancelar.TabIndex = 63;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCancelar.TextOffset = new System.Drawing.Point(4, 0);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BorderRadius = 5;
            this.btnAgregar.CheckedState.Parent = this.btnAgregar;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.CustomImages.Parent = this.btnAgregar;
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(182)))), ((int)(((byte)(146)))));
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.HoverState.Parent = this.btnAgregar;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAgregar.ImageSize = new System.Drawing.Size(19, 19);
            this.btnAgregar.Location = new System.Drawing.Point(625, 592);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.ShadowDecoration.Parent = this.btnAgregar;
            this.btnAgregar.Size = new System.Drawing.Size(107, 32);
            this.btnAgregar.TabIndex = 62;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSeleccionarProductosdelCatalogo
            // 
            this.btnSeleccionarProductosdelCatalogo.BorderRadius = 3;
            this.btnSeleccionarProductosdelCatalogo.CheckedState.Parent = this.btnSeleccionarProductosdelCatalogo;
            this.btnSeleccionarProductosdelCatalogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarProductosdelCatalogo.CustomImages.Parent = this.btnSeleccionarProductosdelCatalogo;
            this.btnSeleccionarProductosdelCatalogo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.btnSeleccionarProductosdelCatalogo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarProductosdelCatalogo.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarProductosdelCatalogo.HoverState.Parent = this.btnSeleccionarProductosdelCatalogo;
            this.btnSeleccionarProductosdelCatalogo.Location = new System.Drawing.Point(410, 209);
            this.btnSeleccionarProductosdelCatalogo.Name = "btnSeleccionarProductosdelCatalogo";
            this.btnSeleccionarProductosdelCatalogo.ShadowDecoration.Parent = this.btnSeleccionarProductosdelCatalogo;
            this.btnSeleccionarProductosdelCatalogo.Size = new System.Drawing.Size(102, 35);
            this.btnSeleccionarProductosdelCatalogo.TabIndex = 61;
            this.btnSeleccionarProductosdelCatalogo.Text = "Seleccionar";
            this.btnSeleccionarProductosdelCatalogo.Click += new System.EventHandler(this.btnSeleccionarProductosdelCatalogo_Click);
            // 
            // btnSeleccionarClienteAddPd
            // 
            this.btnSeleccionarClienteAddPd.BorderRadius = 3;
            this.btnSeleccionarClienteAddPd.CheckedState.Parent = this.btnSeleccionarClienteAddPd;
            this.btnSeleccionarClienteAddPd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarClienteAddPd.CustomImages.Parent = this.btnSeleccionarClienteAddPd;
            this.btnSeleccionarClienteAddPd.FillColor = System.Drawing.Color.Teal;
            this.btnSeleccionarClienteAddPd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarClienteAddPd.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarClienteAddPd.HoverState.Parent = this.btnSeleccionarClienteAddPd;
            this.btnSeleccionarClienteAddPd.Location = new System.Drawing.Point(595, 101);
            this.btnSeleccionarClienteAddPd.Name = "btnSeleccionarClienteAddPd";
            this.btnSeleccionarClienteAddPd.ShadowDecoration.Parent = this.btnSeleccionarClienteAddPd;
            this.btnSeleccionarClienteAddPd.Size = new System.Drawing.Size(35, 35);
            this.btnSeleccionarClienteAddPd.TabIndex = 59;
            this.btnSeleccionarClienteAddPd.Text = "•••";
            this.btnSeleccionarClienteAddPd.Click += new System.EventHandler(this.btnSeleccionarClienteAddPd_Click);
            // 
            // txbContrato
            // 
            this.txbContrato.BorderColor = System.Drawing.Color.Silver;
            this.txbContrato.BorderRadius = 5;
            this.txbContrato.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbContrato.DefaultText = "";
            this.txbContrato.DisabledState.BorderColor = System.Drawing.Color.Silver;
            this.txbContrato.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbContrato.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.txbContrato.DisabledState.Parent = this.txbContrato;
            this.txbContrato.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.txbContrato.Enabled = false;
            this.txbContrato.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbContrato.FocusedState.Parent = this.txbContrato;
            this.txbContrato.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContrato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.txbContrato.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbContrato.HoverState.Parent = this.txbContrato;
            this.txbContrato.Location = new System.Drawing.Point(410, 101);
            this.txbContrato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbContrato.Name = "txbContrato";
            this.txbContrato.PasswordChar = '\0';
            this.txbContrato.PlaceholderText = "";
            this.txbContrato.SelectedText = "";
            this.txbContrato.ShadowDecoration.Parent = this.txbContrato;
            this.txbContrato.Size = new System.Drawing.Size(183, 35);
            this.txbContrato.TabIndex = 58;
            this.txbContrato.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label3.Location = new System.Drawing.Point(234, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 56;
            this.label3.Text = "Zona";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(234, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 55;
            this.label2.Text = "Contrato";
            // 
            // paneltxbznctg
            // 
            this.paneltxbznctg.BackColor = System.Drawing.Color.White;
            this.paneltxbznctg.BorderColor = System.Drawing.Color.Silver;
            this.paneltxbznctg.BorderRadius = 5;
            this.paneltxbznctg.BorderThickness = 1;
            this.paneltxbznctg.Controls.Add(this.cbbSeleccionarZonaCtg);
            this.paneltxbznctg.Location = new System.Drawing.Point(410, 155);
            this.paneltxbznctg.Name = "paneltxbznctg";
            this.paneltxbznctg.ShadowDecoration.Parent = this.paneltxbznctg;
            this.paneltxbznctg.Size = new System.Drawing.Size(220, 35);
            this.paneltxbznctg.TabIndex = 60;
            // 
            // cbbSeleccionarZonaCtg
            // 
            this.cbbSeleccionarZonaCtg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSeleccionarZonaCtg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbSeleccionarZonaCtg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSeleccionarZonaCtg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.cbbSeleccionarZonaCtg.FormattingEnabled = true;
            this.cbbSeleccionarZonaCtg.Location = new System.Drawing.Point(12, 3);
            this.cbbSeleccionarZonaCtg.Name = "cbbSeleccionarZonaCtg";
            this.cbbSeleccionarZonaCtg.Size = new System.Drawing.Size(205, 29);
            this.cbbSeleccionarZonaCtg.TabIndex = 0;
            this.cbbSeleccionarZonaCtg.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label4.Location = new System.Drawing.Point(234, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 57;
            this.label4.Text = "Elegir Productos";
            // 
            // panelDtgCatalogos
            // 
            this.panelDtgCatalogos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDtgCatalogos.Controls.Add(this.dtgAddProductosBodega);
            this.panelDtgCatalogos.Location = new System.Drawing.Point(26, 263);
            this.panelDtgCatalogos.Name = "panelDtgCatalogos";
            this.panelDtgCatalogos.Size = new System.Drawing.Size(829, 316);
            this.panelDtgCatalogos.TabIndex = 54;
            // 
            // dtgAddProductosBodega
            // 
            this.dtgAddProductosBodega.AllowUserToAddRows = false;
            this.dtgAddProductosBodega.AllowUserToDeleteRows = false;
            this.dtgAddProductosBodega.AllowUserToResizeColumns = false;
            this.dtgAddProductosBodega.AllowUserToResizeRows = false;
            this.dtgAddProductosBodega.BackgroundColor = System.Drawing.Color.White;
            this.dtgAddProductosBodega.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgAddProductosBodega.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgAddProductosBodega.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAddProductosBodega.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgAddProductosBodega.ColumnHeadersHeight = 38;
            this.dtgAddProductosBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgAddProductosBodega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombreProducto,
            this.costo,
            this.cantidad,
            this.fechaVencimiento});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgAddProductosBodega.DefaultCellStyle = dataGridViewCellStyle11;
            this.dtgAddProductosBodega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgAddProductosBodega.EnableHeadersVisualStyles = false;
            this.dtgAddProductosBodega.GridColor = System.Drawing.Color.White;
            this.dtgAddProductosBodega.Location = new System.Drawing.Point(0, 0);
            this.dtgAddProductosBodega.Name = "dtgAddProductosBodega";
            this.dtgAddProductosBodega.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAddProductosBodega.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgAddProductosBodega.RowHeadersVisible = false;
            this.dtgAddProductosBodega.RowTemplate.Height = 28;
            this.dtgAddProductosBodega.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAddProductosBodega.Size = new System.Drawing.Size(829, 316);
            this.dtgAddProductosBodega.TabIndex = 5;
            // 
            // idProducto
            // 
            this.idProducto.DataPropertyName = "ID_Catalogo";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idProducto.DefaultCellStyle = dataGridViewCellStyle8;
            this.idProducto.HeaderText = "ID CATÁLOGO";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Width = 110;
            // 
            // nombreProducto
            // 
            this.nombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreProducto.HeaderText = "NOMBRE DEL PRODUCTO";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            // 
            // costo
            // 
            this.costo.HeaderText = "COSTO";
            this.costo.Name = "costo";
            this.costo.Width = 170;
            // 
            // cantidad
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle9;
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 120;
            // 
            // fechaVencimiento
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "d";
            dataGridViewCellStyle10.NullValue = null;
            this.fechaVencimiento.DefaultCellStyle = dataGridViewCellStyle10;
            this.fechaVencimiento.HeaderText = "FECHA VENCIMIENTO";
            this.fechaVencimiento.Name = "fechaVencimiento";
            this.fechaVencimiento.Width = 140;
            // 
            // panelTituloAddPdZnBd
            // 
            this.panelTituloAddPdZnBd.BackColor = System.Drawing.Color.White;
            this.panelTituloAddPdZnBd.BorderColor = System.Drawing.Color.Silver;
            this.panelTituloAddPdZnBd.BorderRadius = 4;
            this.panelTituloAddPdZnBd.BorderThickness = 2;
            this.panelTituloAddPdZnBd.Controls.Add(this.lblAgregaraCatalogo);
            this.panelTituloAddPdZnBd.Controls.Add(this.btnCerrarAgregarPdaB);
            this.panelTituloAddPdZnBd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloAddPdZnBd.Location = new System.Drawing.Point(0, 0);
            this.panelTituloAddPdZnBd.Name = "panelTituloAddPdZnBd";
            this.panelTituloAddPdZnBd.ShadowDecoration.Parent = this.panelTituloAddPdZnBd;
            this.panelTituloAddPdZnBd.Size = new System.Drawing.Size(880, 85);
            this.panelTituloAddPdZnBd.TabIndex = 53;
            // 
            // lblAgregaraCatalogo
            // 
            this.lblAgregaraCatalogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAgregaraCatalogo.AutoSize = true;
            this.lblAgregaraCatalogo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregaraCatalogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.lblAgregaraCatalogo.Location = new System.Drawing.Point(308, 40);
            this.lblAgregaraCatalogo.Name = "lblAgregaraCatalogo";
            this.lblAgregaraCatalogo.Size = new System.Drawing.Size(266, 19);
            this.lblAgregaraCatalogo.TabIndex = 20;
            this.lblAgregaraCatalogo.Text = "AGREGAR PRODUCTOS A BODEGA";
            // 
            // btnCerrarAgregarPdaB
            // 
            this.btnCerrarAgregarPdaB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarAgregarPdaB.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarAgregarPdaB.Image")));
            this.btnCerrarAgregarPdaB.Location = new System.Drawing.Point(851, 8);
            this.btnCerrarAgregarPdaB.Name = "btnCerrarAgregarPdaB";
            this.btnCerrarAgregarPdaB.Size = new System.Drawing.Size(21, 21);
            this.btnCerrarAgregarPdaB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrarAgregarPdaB.TabIndex = 19;
            this.btnCerrarAgregarPdaB.TabStop = false;
            this.btnCerrarAgregarPdaB.Click += new System.EventHandler(this.btnCerrarAgregarPdaB_Click);
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // lblIDContrato
            // 
            this.lblIDContrato.AutoSize = true;
            this.lblIDContrato.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblIDContrato.Location = new System.Drawing.Point(46, 114);
            this.lblIDContrato.Name = "lblIDContrato";
            this.lblIDContrato.Size = new System.Drawing.Size(35, 13);
            this.lblIDContrato.TabIndex = 65;
            this.lblIDContrato.Text = "label1";
            this.lblIDContrato.Visible = false;
            // 
            // AgregarProductosaBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(880, 635);
            this.Controls.Add(this.panelSPPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarProductosaBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarProductosaBodega";
            this.Load += new System.EventHandler(this.AgregarProductosaBodega_Load);
            this.panelSPPB.ResumeLayout(false);
            this.panelSPPB.PerformLayout();
            this.paneltxbznctg.ResumeLayout(false);
            this.panelDtgCatalogos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAddProductosBodega)).EndInit();
            this.panelTituloAddPdZnBd.ResumeLayout(false);
            this.panelTituloAddPdZnBd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarAgregarPdaB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelSPPB;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnSeleccionarProductosdelCatalogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel paneltxbznctg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelDtgCatalogos;
        private Guna.UI2.WinForms.Guna2Panel panelTituloAddPdZnBd;
        private System.Windows.Forms.Label lblAgregaraCatalogo;
        private System.Windows.Forms.PictureBox btnCerrarAgregarPdaB;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimiento;
        private Guna.UI2.WinForms.Guna2Button btnSeleccionarClienteAddPd;
        public System.Windows.Forms.ComboBox cbbSeleccionarZonaCtg;
        public Guna.UI2.WinForms.Guna2TextBox txbContrato;
        public System.Windows.Forms.DataGridView dtgAddProductosBodega;
        private Guna.UI2.WinForms.Guna2Button btnEliminarProducto;
        private System.Windows.Forms.ErrorProvider Notificador;
        public System.Windows.Forms.Label lblIDContrato;
    }
}