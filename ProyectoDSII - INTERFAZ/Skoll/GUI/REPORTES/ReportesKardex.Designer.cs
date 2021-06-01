namespace Skoll.GUI.REPORTES
{
    partial class ReportesKardex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesKardex));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.txbBuscarPDC = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAñadirProductosaCatalogo = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDtgLstPdrKardex = new System.Windows.Forms.Panel();
            this.dtgLstPdrKardex = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelcbb = new System.Windows.Forms.Panel();
            this.cbbOpciones = new System.Windows.Forms.ComboBox();
            this.lblAgregarProductosaBodega = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.panelDtgLstPdrKardex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLstPdrKardex)).BeginInit();
            this.panelcbb.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.guna2VSeparator1);
            this.panelMain.Controls.Add(this.pbSearch);
            this.panelMain.Controls.Add(this.txbBuscarPDC);
            this.panelMain.Controls.Add(this.btnAñadirProductosaCatalogo);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.panelDtgLstPdrKardex);
            this.panelMain.Controls.Add(this.panelcbb);
            this.panelMain.Controls.Add(this.lblAgregarProductosaBodega);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(900, 595);
            this.panelMain.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(295, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "Búsqueda por nombre:";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.BackColor = System.Drawing.Color.White;
            this.guna2VSeparator1.FillColor = System.Drawing.Color.Silver;
            this.guna2VSeparator1.Location = new System.Drawing.Point(623, 83);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 27);
            this.guna2VSeparator1.TabIndex = 68;
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.White;
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.Location = new System.Drawing.Point(633, 86);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(20, 20);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 67;
            this.pbSearch.TabStop = false;
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
            this.txbBuscarPDC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarPDC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.txbBuscarPDC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbBuscarPDC.HoverState.Parent = this.txbBuscarPDC;
            this.txbBuscarPDC.Location = new System.Drawing.Point(462, 79);
            this.txbBuscarPDC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbBuscarPDC.Name = "txbBuscarPDC";
            this.txbBuscarPDC.PasswordChar = '\0';
            this.txbBuscarPDC.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txbBuscarPDC.PlaceholderText = "Buscar..,";
            this.txbBuscarPDC.SelectedText = "";
            this.txbBuscarPDC.ShadowDecoration.Parent = this.txbBuscarPDC;
            this.txbBuscarPDC.Size = new System.Drawing.Size(199, 35);
            this.txbBuscarPDC.TabIndex = 66;
            // 
            // btnAñadirProductosaCatalogo
            // 
            this.btnAñadirProductosaCatalogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnAñadirProductosaCatalogo.Location = new System.Drawing.Point(715, 79);
            this.btnAñadirProductosaCatalogo.Name = "btnAñadirProductosaCatalogo";
            this.btnAñadirProductosaCatalogo.ShadowDecoration.Parent = this.btnAñadirProductosaCatalogo;
            this.btnAñadirProductosaCatalogo.Size = new System.Drawing.Size(157, 35);
            this.btnAñadirProductosaCatalogo.TabIndex = 16;
            this.btnAñadirProductosaCatalogo.Text = "GENERAR KARDEX";
            this.btnAñadirProductosaCatalogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAñadirProductosaCatalogo.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(27, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ver existencias:";
            // 
            // panelDtgLstPdrKardex
            // 
            this.panelDtgLstPdrKardex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDtgLstPdrKardex.Controls.Add(this.dtgLstPdrKardex);
            this.panelDtgLstPdrKardex.Location = new System.Drawing.Point(23, 129);
            this.panelDtgLstPdrKardex.Name = "panelDtgLstPdrKardex";
            this.panelDtgLstPdrKardex.Size = new System.Drawing.Size(849, 445);
            this.panelDtgLstPdrKardex.TabIndex = 8;
            // 
            // dtgLstPdrKardex
            // 
            this.dtgLstPdrKardex.AllowUserToResizeColumns = false;
            this.dtgLstPdrKardex.AllowUserToResizeRows = false;
            this.dtgLstPdrKardex.BackgroundColor = System.Drawing.Color.White;
            this.dtgLstPdrKardex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgLstPdrKardex.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgLstPdrKardex.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgLstPdrKardex.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgLstPdrKardex.ColumnHeadersHeight = 35;
            this.dtgLstPdrKardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgLstPdrKardex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombreProducto,
            this.marca,
            this.categoria});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgLstPdrKardex.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgLstPdrKardex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgLstPdrKardex.EnableHeadersVisualStyles = false;
            this.dtgLstPdrKardex.GridColor = System.Drawing.Color.White;
            this.dtgLstPdrKardex.Location = new System.Drawing.Point(0, 0);
            this.dtgLstPdrKardex.Name = "dtgLstPdrKardex";
            this.dtgLstPdrKardex.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgLstPdrKardex.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgLstPdrKardex.RowHeadersVisible = false;
            this.dtgLstPdrKardex.RowTemplate.Height = 28;
            this.dtgLstPdrKardex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLstPdrKardex.Size = new System.Drawing.Size(849, 445);
            this.dtgLstPdrKardex.TabIndex = 6;
            // 
            // idProducto
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idProducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.idProducto.HeaderText = "ID PRODUCTO";
            this.idProducto.Name = "idProducto";
            this.idProducto.Width = 130;
            // 
            // nombreProducto
            // 
            this.nombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreProducto.HeaderText = "NOMBRE DEL PRODUCTO";
            this.nombreProducto.Name = "nombreProducto";
            // 
            // marca
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.marca.DefaultCellStyle = dataGridViewCellStyle3;
            this.marca.HeaderText = "MARCA";
            this.marca.Name = "marca";
            this.marca.Width = 170;
            // 
            // categoria
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.categoria.DefaultCellStyle = dataGridViewCellStyle4;
            this.categoria.HeaderText = "CATEGORÍA";
            this.categoria.Name = "categoria";
            this.categoria.Width = 190;
            // 
            // panelcbb
            // 
            this.panelcbb.BackColor = System.Drawing.Color.White;
            this.panelcbb.Controls.Add(this.cbbOpciones);
            this.panelcbb.ForeColor = System.Drawing.Color.Coral;
            this.panelcbb.Location = new System.Drawing.Point(149, 79);
            this.panelcbb.Name = "panelcbb";
            this.panelcbb.Size = new System.Drawing.Size(129, 35);
            this.panelcbb.TabIndex = 6;
            // 
            // cbbOpciones
            // 
            this.cbbOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbOpciones.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbOpciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.cbbOpciones.FormattingEnabled = true;
            this.cbbOpciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbbOpciones.ItemHeight = 20;
            this.cbbOpciones.Items.AddRange(new object[] {
            "Global",
            "Por Cliente",
            "Por Zona"});
            this.cbbOpciones.Location = new System.Drawing.Point(4, 4);
            this.cbbOpciones.Name = "cbbOpciones";
            this.cbbOpciones.Size = new System.Drawing.Size(121, 28);
            this.cbbOpciones.TabIndex = 5;
            this.cbbOpciones.Text = "Seleccione";
            this.cbbOpciones.SelectedIndexChanged += new System.EventHandler(this.cbbOpciones_SelectedIndexChanged);
            // 
            // lblAgregarProductosaBodega
            // 
            this.lblAgregarProductosaBodega.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAgregarProductosaBodega.AutoSize = true;
            this.lblAgregarProductosaBodega.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProductosaBodega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.lblAgregarProductosaBodega.Location = new System.Drawing.Point(424, 23);
            this.lblAgregarProductosaBodega.Name = "lblAgregarProductosaBodega";
            this.lblAgregarProductosaBodega.Size = new System.Drawing.Size(77, 22);
            this.lblAgregarProductosaBodega.TabIndex = 2;
            this.lblAgregarProductosaBodega.Text = "KARDEX";
            // 
            // ReportesKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(900, 595);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportesKardex";
            this.Text = "ReportesKardex";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.panelDtgLstPdrKardex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLstPdrKardex)).EndInit();
            this.panelcbb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelMain;
        private Guna.UI2.WinForms.Guna2Button btnAñadirProductosaCatalogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelcbb;
        public System.Windows.Forms.ComboBox cbbOpciones;
        private System.Windows.Forms.Label lblAgregarProductosaBodega;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.PictureBox pbSearch;
        private Guna.UI2.WinForms.Guna2TextBox txbBuscarPDC;
        private System.Windows.Forms.Panel panelDtgLstPdrKardex;
        private System.Windows.Forms.DataGridView dtgLstPdrKardex;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
    }
}