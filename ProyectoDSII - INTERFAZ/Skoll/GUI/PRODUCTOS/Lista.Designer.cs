namespace Skoll.GUI.PRODUCTOS
{
    partial class Lista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.txbNombreZona = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExtraerdeBodega = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregaraBodega = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDtgCatalogos = new System.Windows.Forms.Panel();
            this.dtgProductosaBodega = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAgregarProductosaBodega = new System.Windows.Forms.Label();
            this.Radiuscbb = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnSeleccionarZona = new Guna.UI2.WinForms.Guna2Button();
            this.panelMain.SuspendLayout();
            this.panelDtgCatalogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosaBodega)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.panelMain.Controls.Add(this.btnSeleccionarZona);
            this.panelMain.Controls.Add(this.txbNombreZona);
            this.panelMain.Controls.Add(this.btnExtraerdeBodega);
            this.panelMain.Controls.Add(this.btnAgregaraBodega);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.panelDtgCatalogos);
            this.panelMain.Controls.Add(this.lblAgregarProductosaBodega);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(900, 595);
            this.panelMain.TabIndex = 6;
            // 
            // txbNombreZona
            // 
            this.txbNombreZona.BorderColor = System.Drawing.Color.Silver;
            this.txbNombreZona.BorderRadius = 5;
            this.txbNombreZona.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNombreZona.DefaultText = "";
            this.txbNombreZona.DisabledState.BorderColor = System.Drawing.Color.Silver;
            this.txbNombreZona.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbNombreZona.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.txbNombreZona.DisabledState.Parent = this.txbNombreZona;
            this.txbNombreZona.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.txbNombreZona.Enabled = false;
            this.txbNombreZona.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNombreZona.FocusedState.Parent = this.txbNombreZona;
            this.txbNombreZona.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombreZona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.txbNombreZona.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNombreZona.HoverState.Parent = this.txbNombreZona;
            this.txbNombreZona.Location = new System.Drawing.Point(218, 79);
            this.txbNombreZona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbNombreZona.Name = "txbNombreZona";
            this.txbNombreZona.PasswordChar = '\0';
            this.txbNombreZona.PlaceholderText = "";
            this.txbNombreZona.SelectedText = "";
            this.txbNombreZona.ShadowDecoration.Parent = this.txbNombreZona;
            this.txbNombreZona.Size = new System.Drawing.Size(72, 35);
            this.txbNombreZona.TabIndex = 40;
            this.txbNombreZona.TabStop = false;
            // 
            // btnExtraerdeBodega
            // 
            this.btnExtraerdeBodega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtraerdeBodega.BorderRadius = 6;
            this.btnExtraerdeBodega.CheckedState.Parent = this.btnExtraerdeBodega;
            this.btnExtraerdeBodega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtraerdeBodega.CustomImages.Parent = this.btnExtraerdeBodega;
            this.btnExtraerdeBodega.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(79)))), ((int)(((byte)(83)))));
            this.btnExtraerdeBodega.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraerdeBodega.ForeColor = System.Drawing.Color.White;
            this.btnExtraerdeBodega.HoverState.Parent = this.btnExtraerdeBodega;
            this.btnExtraerdeBodega.Image = ((System.Drawing.Image)(resources.GetObject("btnExtraerdeBodega.Image")));
            this.btnExtraerdeBodega.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExtraerdeBodega.ImageSize = new System.Drawing.Size(14, 15);
            this.btnExtraerdeBodega.Location = new System.Drawing.Point(769, 79);
            this.btnExtraerdeBodega.Name = "btnExtraerdeBodega";
            this.btnExtraerdeBodega.ShadowDecoration.Parent = this.btnExtraerdeBodega;
            this.btnExtraerdeBodega.Size = new System.Drawing.Size(103, 35);
            this.btnExtraerdeBodega.TabIndex = 15;
            this.btnExtraerdeBodega.Text = "EXTRAER";
            this.btnExtraerdeBodega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnExtraerdeBodega.TextOffset = new System.Drawing.Point(3, 0);
            this.btnExtraerdeBodega.Click += new System.EventHandler(this.btnExtraerdeBodega_Click);
            // 
            // btnAgregaraBodega
            // 
            this.btnAgregaraBodega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregaraBodega.BorderRadius = 6;
            this.btnAgregaraBodega.CheckedState.Parent = this.btnAgregaraBodega;
            this.btnAgregaraBodega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregaraBodega.CustomImages.Parent = this.btnAgregaraBodega;
            this.btnAgregaraBodega.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(182)))), ((int)(((byte)(146)))));
            this.btnAgregaraBodega.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregaraBodega.ForeColor = System.Drawing.Color.White;
            this.btnAgregaraBodega.HoverState.Parent = this.btnAgregaraBodega;
            this.btnAgregaraBodega.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregaraBodega.Image")));
            this.btnAgregaraBodega.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAgregaraBodega.ImageSize = new System.Drawing.Size(14, 15);
            this.btnAgregaraBodega.Location = new System.Drawing.Point(660, 79);
            this.btnAgregaraBodega.Name = "btnAgregaraBodega";
            this.btnAgregaraBodega.ShadowDecoration.Parent = this.btnAgregaraBodega;
            this.btnAgregaraBodega.Size = new System.Drawing.Size(103, 35);
            this.btnAgregaraBodega.TabIndex = 14;
            this.btnAgregaraBodega.Text = "AGREGAR";
            this.btnAgregaraBodega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAgregaraBodega.TextOffset = new System.Drawing.Point(3, 0);
            this.btnAgregaraBodega.Click += new System.EventHandler(this.btnAgregaraBodega_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(27, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lista de Productos Zona:";
            // 
            // panelDtgCatalogos
            // 
            this.panelDtgCatalogos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDtgCatalogos.Controls.Add(this.dtgProductosaBodega);
            this.panelDtgCatalogos.Location = new System.Drawing.Point(23, 129);
            this.panelDtgCatalogos.Name = "panelDtgCatalogos";
            this.panelDtgCatalogos.Size = new System.Drawing.Size(849, 445);
            this.panelDtgCatalogos.TabIndex = 8;
            // 
            // dtgProductosaBodega
            // 
            this.dtgProductosaBodega.AllowUserToResizeColumns = false;
            this.dtgProductosaBodega.AllowUserToResizeRows = false;
            this.dtgProductosaBodega.BackgroundColor = System.Drawing.Color.White;
            this.dtgProductosaBodega.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgProductosaBodega.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgProductosaBodega.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductosaBodega.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dtgProductosaBodega.ColumnHeadersHeight = 38;
            this.dtgProductosaBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgProductosaBodega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombreProducto,
            this.marca,
            this.categoria,
            this.costo,
            this.cantidad,
            this.fechaVencimiento});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProductosaBodega.DefaultCellStyle = dataGridViewCellStyle26;
            this.dtgProductosaBodega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgProductosaBodega.EnableHeadersVisualStyles = false;
            this.dtgProductosaBodega.GridColor = System.Drawing.Color.White;
            this.dtgProductosaBodega.Location = new System.Drawing.Point(0, 0);
            this.dtgProductosaBodega.Name = "dtgProductosaBodega";
            this.dtgProductosaBodega.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductosaBodega.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dtgProductosaBodega.RowHeadersVisible = false;
            this.dtgProductosaBodega.RowTemplate.Height = 28;
            this.dtgProductosaBodega.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProductosaBodega.Size = new System.Drawing.Size(849, 445);
            this.dtgProductosaBodega.TabIndex = 5;
            // 
            // idProducto
            // 
            this.idProducto.DataPropertyName = "ID_Catalogo";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idProducto.DefaultCellStyle = dataGridViewCellStyle20;
            this.idProducto.HeaderText = "ID CATÁLOGO";
            this.idProducto.Name = "idProducto";
            this.idProducto.Width = 110;
            // 
            // nombreProducto
            // 
            this.nombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreProducto.HeaderText = "NOMBRE DEL PRODUCTO";
            this.nombreProducto.Name = "nombreProducto";
            // 
            // marca
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.marca.DefaultCellStyle = dataGridViewCellStyle21;
            this.marca.HeaderText = "MARCA";
            this.marca.Name = "marca";
            this.marca.Width = 150;
            // 
            // categoria
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.categoria.DefaultCellStyle = dataGridViewCellStyle22;
            this.categoria.HeaderText = "CATEGORÍA";
            this.categoria.Name = "categoria";
            this.categoria.Width = 150;
            // 
            // costo
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.costo.DefaultCellStyle = dataGridViewCellStyle23;
            this.costo.HeaderText = "COSTO";
            this.costo.Name = "costo";
            // 
            // cantidad
            // 
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle24;
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 80;
            // 
            // fechaVencimiento
            // 
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fechaVencimiento.DefaultCellStyle = dataGridViewCellStyle25;
            this.fechaVencimiento.HeaderText = "FECHA VENCIMIENTO";
            this.fechaVencimiento.Name = "fechaVencimiento";
            // 
            // lblAgregarProductosaBodega
            // 
            this.lblAgregarProductosaBodega.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAgregarProductosaBodega.AutoSize = true;
            this.lblAgregarProductosaBodega.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProductosaBodega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.lblAgregarProductosaBodega.Location = new System.Drawing.Point(354, 23);
            this.lblAgregarProductosaBodega.Name = "lblAgregarProductosaBodega";
            this.lblAgregarProductosaBodega.Size = new System.Drawing.Size(192, 22);
            this.lblAgregarProductosaBodega.TabIndex = 2;
            this.lblAgregarProductosaBodega.Text = "LISTA DE PRODUCTOS";
            // 
            // Radiuscbb
            // 
            this.Radiuscbb.BorderRadius = 5;
            // 
            // btnSeleccionarZona
            // 
            this.btnSeleccionarZona.BorderRadius = 3;
            this.btnSeleccionarZona.CheckedState.Parent = this.btnSeleccionarZona;
            this.btnSeleccionarZona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarZona.CustomImages.Parent = this.btnSeleccionarZona;
            this.btnSeleccionarZona.FillColor = System.Drawing.Color.Teal;
            this.btnSeleccionarZona.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarZona.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarZona.HoverState.Parent = this.btnSeleccionarZona;
            this.btnSeleccionarZona.Location = new System.Drawing.Point(297, 79);
            this.btnSeleccionarZona.Name = "btnSeleccionarZona";
            this.btnSeleccionarZona.ShadowDecoration.Parent = this.btnSeleccionarZona;
            this.btnSeleccionarZona.Size = new System.Drawing.Size(35, 35);
            this.btnSeleccionarZona.TabIndex = 61;
            this.btnSeleccionarZona.Text = "•••";
            this.btnSeleccionarZona.Click += new System.EventHandler(this.btnSeleccionarZona_Click);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(900, 595);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lista";
            this.Text = "Lista";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelDtgCatalogos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosaBodega)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelMain;
        private Guna.UI2.WinForms.Guna2Button btnExtraerdeBodega;
        private Guna.UI2.WinForms.Guna2Button btnAgregaraBodega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDtgCatalogos;
        private System.Windows.Forms.DataGridView dtgProductosaBodega;
        private System.Windows.Forms.Label lblAgregarProductosaBodega;
        public Guna.UI2.WinForms.Guna2Elipse Radiuscbb;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimiento;
        private Guna.UI2.WinForms.Guna2TextBox txbNombreZona;
        private Guna.UI2.WinForms.Guna2Button btnSeleccionarZona;
    }
}