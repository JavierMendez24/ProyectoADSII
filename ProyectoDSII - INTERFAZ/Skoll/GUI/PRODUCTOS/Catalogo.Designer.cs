namespace Skoll.GUI.PRODUCTOS
{
    partial class Catalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnAñadirProductosaCatalogo = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditarProductosdeCatalogo = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarProductosdelCatalogo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.panelDtgCatalogos = new System.Windows.Forms.Panel();
            this.dtgCatalogo = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbBuscarProductosdeCatalogo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.RadiusCbb = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.panelDtgCatalogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.panelMain.Controls.Add(this.btnAñadirProductosaCatalogo);
            this.panelMain.Controls.Add(this.btnEditarProductosdeCatalogo);
            this.panelMain.Controls.Add(this.btnEliminarProductosdelCatalogo);
            this.panelMain.Controls.Add(this.guna2VSeparator1);
            this.panelMain.Controls.Add(this.pbSearch);
            this.panelMain.Controls.Add(this.panelDtgCatalogos);
            this.panelMain.Controls.Add(this.txbBuscarProductosdeCatalogo);
            this.panelMain.Controls.Add(this.lblCatalogo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(900, 595);
            this.panelMain.TabIndex = 5;
            // 
            // btnAñadirProductosaCatalogo
            // 
            this.btnAñadirProductosaCatalogo.BorderRadius = 6;
            this.btnAñadirProductosaCatalogo.CheckedState.Parent = this.btnAñadirProductosaCatalogo;
            this.btnAñadirProductosaCatalogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirProductosaCatalogo.CustomImages.Parent = this.btnAñadirProductosaCatalogo;
            this.btnAñadirProductosaCatalogo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(182)))), ((int)(((byte)(146)))));
            this.btnAñadirProductosaCatalogo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirProductosaCatalogo.ForeColor = System.Drawing.Color.White;
            this.btnAñadirProductosaCatalogo.HoverState.Parent = this.btnAñadirProductosaCatalogo;
            this.btnAñadirProductosaCatalogo.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadirProductosaCatalogo.Image")));
            this.btnAñadirProductosaCatalogo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAñadirProductosaCatalogo.ImageSize = new System.Drawing.Size(15, 15);
            this.btnAñadirProductosaCatalogo.Location = new System.Drawing.Point(38, 79);
            this.btnAñadirProductosaCatalogo.Name = "btnAñadirProductosaCatalogo";
            this.btnAñadirProductosaCatalogo.ShadowDecoration.Parent = this.btnAñadirProductosaCatalogo;
            this.btnAñadirProductosaCatalogo.Size = new System.Drawing.Size(100, 35);
            this.btnAñadirProductosaCatalogo.TabIndex = 15;
            this.btnAñadirProductosaCatalogo.Text = "AGREGAR";
            this.btnAñadirProductosaCatalogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAñadirProductosaCatalogo.TextOffset = new System.Drawing.Point(3, 0);
            this.btnAñadirProductosaCatalogo.Click += new System.EventHandler(this.btnAñadirProductosaCatalogo_Click);
            // 
            // btnEditarProductosdeCatalogo
            // 
            this.btnEditarProductosdeCatalogo.BorderRadius = 6;
            this.btnEditarProductosdeCatalogo.CheckedState.Parent = this.btnEditarProductosdeCatalogo;
            this.btnEditarProductosdeCatalogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarProductosdeCatalogo.CustomImages.Parent = this.btnEditarProductosdeCatalogo;
            this.btnEditarProductosdeCatalogo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(161)))), ((int)(((byte)(3)))));
            this.btnEditarProductosdeCatalogo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProductosdeCatalogo.ForeColor = System.Drawing.Color.White;
            this.btnEditarProductosdeCatalogo.HoverState.Parent = this.btnEditarProductosdeCatalogo;
            this.btnEditarProductosdeCatalogo.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarProductosdeCatalogo.Image")));
            this.btnEditarProductosdeCatalogo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEditarProductosdeCatalogo.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnEditarProductosdeCatalogo.ImageSize = new System.Drawing.Size(15, 15);
            this.btnEditarProductosdeCatalogo.Location = new System.Drawing.Point(144, 79);
            this.btnEditarProductosdeCatalogo.Name = "btnEditarProductosdeCatalogo";
            this.btnEditarProductosdeCatalogo.ShadowDecoration.Parent = this.btnEditarProductosdeCatalogo;
            this.btnEditarProductosdeCatalogo.Size = new System.Drawing.Size(100, 35);
            this.btnEditarProductosdeCatalogo.TabIndex = 14;
            this.btnEditarProductosdeCatalogo.Text = "EDITAR";
            this.btnEditarProductosdeCatalogo.TextOffset = new System.Drawing.Point(12, 0);
            this.btnEditarProductosdeCatalogo.Click += new System.EventHandler(this.btnEditarProductosdeCatalogo_Click);
            // 
            // btnEliminarProductosdelCatalogo
            // 
            this.btnEliminarProductosdelCatalogo.BorderRadius = 6;
            this.btnEliminarProductosdelCatalogo.CheckedState.Parent = this.btnEliminarProductosdelCatalogo;
            this.btnEliminarProductosdelCatalogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProductosdelCatalogo.CustomImages.Parent = this.btnEliminarProductosdelCatalogo;
            this.btnEliminarProductosdelCatalogo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(79)))), ((int)(((byte)(83)))));
            this.btnEliminarProductosdelCatalogo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProductosdelCatalogo.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProductosdelCatalogo.HoverState.Parent = this.btnEliminarProductosdelCatalogo;
            this.btnEliminarProductosdelCatalogo.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarProductosdelCatalogo.Image")));
            this.btnEliminarProductosdelCatalogo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEliminarProductosdelCatalogo.ImageSize = new System.Drawing.Size(15, 15);
            this.btnEliminarProductosdelCatalogo.Location = new System.Drawing.Point(250, 79);
            this.btnEliminarProductosdelCatalogo.Name = "btnEliminarProductosdelCatalogo";
            this.btnEliminarProductosdelCatalogo.ShadowDecoration.Parent = this.btnEliminarProductosdelCatalogo;
            this.btnEliminarProductosdelCatalogo.Size = new System.Drawing.Size(100, 35);
            this.btnEliminarProductosdelCatalogo.TabIndex = 13;
            this.btnEliminarProductosdelCatalogo.Text = "ELIMINAR";
            this.btnEliminarProductosdelCatalogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEliminarProductosdelCatalogo.TextOffset = new System.Drawing.Point(3, 0);
            this.btnEliminarProductosdelCatalogo.Click += new System.EventHandler(this.btnEliminarProductosdelCatalogo_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2VSeparator1.BackColor = System.Drawing.Color.White;
            this.guna2VSeparator1.FillColor = System.Drawing.Color.Silver;
            this.guna2VSeparator1.Location = new System.Drawing.Point(818, 83);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 27);
            this.guna2VSeparator1.TabIndex = 11;
            // 
            // pbSearch
            // 
            this.pbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSearch.BackColor = System.Drawing.Color.White;
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.Location = new System.Drawing.Point(828, 86);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(20, 20);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 10;
            this.pbSearch.TabStop = false;
            // 
            // panelDtgCatalogos
            // 
            this.panelDtgCatalogos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDtgCatalogos.Controls.Add(this.dtgCatalogo);
            this.panelDtgCatalogos.Location = new System.Drawing.Point(38, 131);
            this.panelDtgCatalogos.Name = "panelDtgCatalogos";
            this.panelDtgCatalogos.Size = new System.Drawing.Size(819, 443);
            this.panelDtgCatalogos.TabIndex = 8;
            // 
            // dtgCatalogo
            // 
            this.dtgCatalogo.AllowUserToAddRows = false;
            this.dtgCatalogo.AllowUserToDeleteRows = false;
            this.dtgCatalogo.AllowUserToResizeColumns = false;
            this.dtgCatalogo.AllowUserToResizeRows = false;
            this.dtgCatalogo.BackgroundColor = System.Drawing.Color.White;
            this.dtgCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgCatalogo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgCatalogo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCatalogo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgCatalogo.ColumnHeadersHeight = 35;
            this.dtgCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgCatalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombreProducto,
            this.marca,
            this.categoria,
            this.DESCRIPCION});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCatalogo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCatalogo.EnableHeadersVisualStyles = false;
            this.dtgCatalogo.GridColor = System.Drawing.Color.White;
            this.dtgCatalogo.Location = new System.Drawing.Point(0, 0);
            this.dtgCatalogo.Name = "dtgCatalogo";
            this.dtgCatalogo.ReadOnly = true;
            this.dtgCatalogo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCatalogo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgCatalogo.RowHeadersVisible = false;
            this.dtgCatalogo.RowTemplate.Height = 28;
            this.dtgCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCatalogo.Size = new System.Drawing.Size(819, 443);
            this.dtgCatalogo.TabIndex = 5;
            // 
            // idProducto
            // 
            this.idProducto.DataPropertyName = "ID_Catalogo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idProducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.idProducto.HeaderText = "ID PRODUCTO";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Width = 120;
            // 
            // nombreProducto
            // 
            this.nombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreProducto.DataPropertyName = "Nombre_Producto";
            this.nombreProducto.HeaderText = "NOMBRE DEL PRODUCTO";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.DataPropertyName = "Marca";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.marca.DefaultCellStyle = dataGridViewCellStyle3;
            this.marca.HeaderText = "MARCA";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Width = 150;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "Categoria";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.categoria.DefaultCellStyle = dataGridViewCellStyle4;
            this.categoria.HeaderText = "CATEGORÍA";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 160;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCRIPCION.DataPropertyName = "Descripcion";
            this.DESCRIPCION.HeaderText = "DESCRIPCIÓN";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            // 
            // txbBuscarProductosdeCatalogo
            // 
            this.txbBuscarProductosdeCatalogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbBuscarProductosdeCatalogo.BorderColor = System.Drawing.Color.Silver;
            this.txbBuscarProductosdeCatalogo.BorderRadius = 8;
            this.txbBuscarProductosdeCatalogo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbBuscarProductosdeCatalogo.DefaultText = "";
            this.txbBuscarProductosdeCatalogo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbBuscarProductosdeCatalogo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbBuscarProductosdeCatalogo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbBuscarProductosdeCatalogo.DisabledState.Parent = this.txbBuscarProductosdeCatalogo;
            this.txbBuscarProductosdeCatalogo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbBuscarProductosdeCatalogo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbBuscarProductosdeCatalogo.FocusedState.Parent = this.txbBuscarProductosdeCatalogo;
            this.txbBuscarProductosdeCatalogo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarProductosdeCatalogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.txbBuscarProductosdeCatalogo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbBuscarProductosdeCatalogo.HoverState.Parent = this.txbBuscarProductosdeCatalogo;
            this.txbBuscarProductosdeCatalogo.Location = new System.Drawing.Point(543, 79);
            this.txbBuscarProductosdeCatalogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbBuscarProductosdeCatalogo.Name = "txbBuscarProductosdeCatalogo";
            this.txbBuscarProductosdeCatalogo.PasswordChar = '\0';
            this.txbBuscarProductosdeCatalogo.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txbBuscarProductosdeCatalogo.PlaceholderText = "Ingrese el nombre del producto";
            this.txbBuscarProductosdeCatalogo.SelectedText = "";
            this.txbBuscarProductosdeCatalogo.ShadowDecoration.Parent = this.txbBuscarProductosdeCatalogo;
            this.txbBuscarProductosdeCatalogo.Size = new System.Drawing.Size(313, 35);
            this.txbBuscarProductosdeCatalogo.TabIndex = 4;
            // 
            // lblCatalogo
            // 
            this.lblCatalogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCatalogo.AutoSize = true;
            this.lblCatalogo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.lblCatalogo.Location = new System.Drawing.Point(328, 23);
            this.lblCatalogo.Name = "lblCatalogo";
            this.lblCatalogo.Size = new System.Drawing.Size(238, 22);
            this.lblCatalogo.TabIndex = 2;
            this.lblCatalogo.Text = "CATALOGO DE PRODUCTOS";
            // 
            // RadiusCbb
            // 
            this.RadiusCbb.BorderRadius = 8;
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(900, 595);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Catalogo";
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Catalogo_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.panelDtgCatalogos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCatalogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelMain;
        private Guna.UI2.WinForms.Guna2Button btnAñadirProductosaCatalogo;
        private Guna.UI2.WinForms.Guna2Button btnEditarProductosdeCatalogo;
        private Guna.UI2.WinForms.Guna2Button btnEliminarProductosdelCatalogo;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.Panel panelDtgCatalogos;
        private Guna.UI2.WinForms.Guna2TextBox txbBuscarProductosdeCatalogo;
        private System.Windows.Forms.Label lblCatalogo;
        private Guna.UI2.WinForms.Guna2Elipse RadiusCbb;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        public System.Windows.Forms.DataGridView dtgCatalogo;
    }
}