namespace Skoll.GUI.REPORTES
{
    partial class ReportesInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesInventario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnGenerarReporteInventario = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDtgExistencias = new System.Windows.Forms.Panel();
            this.dtgExistencias = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelcbb = new System.Windows.Forms.Panel();
            this.cbbOpciones = new System.Windows.Forms.ComboBox();
            this.lblAgregarProductosaBodega = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelDtgExistencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExistencias)).BeginInit();
            this.panelcbb.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.panelMain.Controls.Add(this.btnGenerarReporteInventario);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.panelDtgExistencias);
            this.panelMain.Controls.Add(this.panelcbb);
            this.panelMain.Controls.Add(this.lblAgregarProductosaBodega);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(900, 595);
            this.panelMain.TabIndex = 7;
            // 
            // btnGenerarReporteInventario
            // 
            this.btnGenerarReporteInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerarReporteInventario.BorderRadius = 6;
            this.btnGenerarReporteInventario.CheckedState.Parent = this.btnGenerarReporteInventario;
            this.btnGenerarReporteInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarReporteInventario.CustomImages.Parent = this.btnGenerarReporteInventario;
            this.btnGenerarReporteInventario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(182)))), ((int)(((byte)(146)))));
            this.btnGenerarReporteInventario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporteInventario.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporteInventario.HoverState.Parent = this.btnGenerarReporteInventario;
            this.btnGenerarReporteInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarReporteInventario.Image")));
            this.btnGenerarReporteInventario.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGenerarReporteInventario.ImageSize = new System.Drawing.Size(15, 15);
            this.btnGenerarReporteInventario.Location = new System.Drawing.Point(705, 79);
            this.btnGenerarReporteInventario.Name = "btnGenerarReporteInventario";
            this.btnGenerarReporteInventario.ShadowDecoration.Parent = this.btnGenerarReporteInventario;
            this.btnGenerarReporteInventario.Size = new System.Drawing.Size(167, 35);
            this.btnGenerarReporteInventario.TabIndex = 16;
            this.btnGenerarReporteInventario.Text = "GENERAR REPORTE";
            this.btnGenerarReporteInventario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnGenerarReporteInventario.TextOffset = new System.Drawing.Point(3, 0);
            this.btnGenerarReporteInventario.Click += new System.EventHandler(this.btnGenerarReporteInventario_Click);
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
            // panelDtgExistencias
            // 
            this.panelDtgExistencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDtgExistencias.Controls.Add(this.dtgExistencias);
            this.panelDtgExistencias.Location = new System.Drawing.Point(23, 129);
            this.panelDtgExistencias.Name = "panelDtgExistencias";
            this.panelDtgExistencias.Size = new System.Drawing.Size(849, 445);
            this.panelDtgExistencias.TabIndex = 8;
            // 
            // dtgExistencias
            // 
            this.dtgExistencias.AllowUserToResizeColumns = false;
            this.dtgExistencias.AllowUserToResizeRows = false;
            this.dtgExistencias.BackgroundColor = System.Drawing.Color.White;
            this.dtgExistencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgExistencias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgExistencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgExistencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgExistencias.ColumnHeadersHeight = 38;
            this.dtgExistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgExistencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombreProducto,
            this.marca,
            this.categoria,
            this.costo,
            this.cantidad,
            this.fechaVencimiento});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgExistencias.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgExistencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgExistencias.EnableHeadersVisualStyles = false;
            this.dtgExistencias.GridColor = System.Drawing.Color.White;
            this.dtgExistencias.Location = new System.Drawing.Point(0, 0);
            this.dtgExistencias.Name = "dtgExistencias";
            this.dtgExistencias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgExistencias.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgExistencias.RowHeadersVisible = false;
            this.dtgExistencias.RowTemplate.Height = 28;
            this.dtgExistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgExistencias.Size = new System.Drawing.Size(849, 445);
            this.dtgExistencias.TabIndex = 5;
            // 
            // idProducto
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idProducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.idProducto.HeaderText = "ID PRODUCTO";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.marca.DefaultCellStyle = dataGridViewCellStyle3;
            this.marca.HeaderText = "MARCA";
            this.marca.Name = "marca";
            this.marca.Width = 150;
            // 
            // categoria
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.categoria.DefaultCellStyle = dataGridViewCellStyle4;
            this.categoria.HeaderText = "CATEGORÍA";
            this.categoria.Name = "categoria";
            this.categoria.Width = 150;
            // 
            // costo
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.costo.DefaultCellStyle = dataGridViewCellStyle5;
            this.costo.HeaderText = "COSTO";
            this.costo.Name = "costo";
            // 
            // cantidad
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle6;
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 80;
            // 
            // fechaVencimiento
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fechaVencimiento.DefaultCellStyle = dataGridViewCellStyle7;
            this.fechaVencimiento.HeaderText = "FECHA VENCIMIENTO";
            this.fechaVencimiento.Name = "fechaVencimiento";
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
            this.lblAgregarProductosaBodega.Location = new System.Drawing.Point(334, 23);
            this.lblAgregarProductosaBodega.Name = "lblAgregarProductosaBodega";
            this.lblAgregarProductosaBodega.Size = new System.Drawing.Size(232, 22);
            this.lblAgregarProductosaBodega.TabIndex = 2;
            this.lblAgregarProductosaBodega.Text = "REPORTES DE EXISTENCIAS";
            // 
            // ReportesInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(900, 595);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportesInventario";
            this.Text = "ReportesInventario";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelDtgExistencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgExistencias)).EndInit();
            this.panelcbb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDtgExistencias;
        private System.Windows.Forms.DataGridView dtgExistencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimiento;
        private System.Windows.Forms.Panel panelcbb;
        public System.Windows.Forms.ComboBox cbbOpciones;
        private System.Windows.Forms.Label lblAgregarProductosaBodega;
        private Guna.UI2.WinForms.Guna2Button btnGenerarReporteInventario;
    }
}