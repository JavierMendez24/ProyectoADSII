namespace Skoll.GUI.REPORTES
{
    partial class ReportesEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesEntrada));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBuscarFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnAñadirProductosaCatalogo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDtgRptEntrada = new System.Windows.Forms.Panel();
            this.dtgRptEntrada = new System.Windows.Forms.DataGridView();
            this.idMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaReporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbBuscarPDC = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.panelDtgRptEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRptEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.dtpBuscarFecha);
            this.panelMain.Controls.Add(this.btnAñadirProductosaCatalogo);
            this.panelMain.Controls.Add(this.guna2VSeparator1);
            this.panelMain.Controls.Add(this.pbSearch);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.panelDtgRptEntrada);
            this.panelMain.Controls.Add(this.txbBuscarPDC);
            this.panelMain.Controls.Add(this.lblCatalogo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(900, 595);
            this.panelMain.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(34, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Búsqueda por cliente:";
            // 
            // dtpBuscarFecha
            // 
            this.dtpBuscarFecha.BorderColor = System.Drawing.Color.Silver;
            this.dtpBuscarFecha.BorderRadius = 5;
            this.dtpBuscarFecha.BorderThickness = 1;
            this.dtpBuscarFecha.CheckedState.Parent = this.dtpBuscarFecha;
            this.dtpBuscarFecha.FillColor = System.Drawing.Color.White;
            this.dtpBuscarFecha.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBuscarFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.dtpBuscarFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBuscarFecha.HoverState.Parent = this.dtpBuscarFecha;
            this.dtpBuscarFecha.Location = new System.Drawing.Point(507, 79);
            this.dtpBuscarFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBuscarFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBuscarFecha.Name = "dtpBuscarFecha";
            this.dtpBuscarFecha.ShadowDecoration.Parent = this.dtpBuscarFecha;
            this.dtpBuscarFecha.Size = new System.Drawing.Size(133, 35);
            this.dtpBuscarFecha.TabIndex = 64;
            this.dtpBuscarFecha.Value = new System.DateTime(2021, 4, 13, 16, 31, 51, 340);
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
            this.btnAñadirProductosaCatalogo.Location = new System.Drawing.Point(690, 79);
            this.btnAñadirProductosaCatalogo.Name = "btnAñadirProductosaCatalogo";
            this.btnAñadirProductosaCatalogo.ShadowDecoration.Parent = this.btnAñadirProductosaCatalogo;
            this.btnAñadirProductosaCatalogo.Size = new System.Drawing.Size(167, 35);
            this.btnAñadirProductosaCatalogo.TabIndex = 15;
            this.btnAñadirProductosaCatalogo.Text = "GENERAR REPORTE";
            this.btnAñadirProductosaCatalogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAñadirProductosaCatalogo.TextOffset = new System.Drawing.Point(3, 0);
            this.btnAñadirProductosaCatalogo.Click += new System.EventHandler(this.btnAñadirProductosaCatalogo_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.BackColor = System.Drawing.Color.White;
            this.guna2VSeparator1.FillColor = System.Drawing.Color.Silver;
            this.guna2VSeparator1.Location = new System.Drawing.Point(308, 83);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 27);
            this.guna2VSeparator1.TabIndex = 11;
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.White;
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.Location = new System.Drawing.Point(318, 86);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(20, 20);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 10;
            this.pbSearch.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(353, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Búsqueda por fecha:";
            // 
            // panelDtgRptEntrada
            // 
            this.panelDtgRptEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDtgRptEntrada.Controls.Add(this.dtgRptEntrada);
            this.panelDtgRptEntrada.Location = new System.Drawing.Point(38, 131);
            this.panelDtgRptEntrada.Name = "panelDtgRptEntrada";
            this.panelDtgRptEntrada.Size = new System.Drawing.Size(819, 443);
            this.panelDtgRptEntrada.TabIndex = 8;
            // 
            // dtgRptEntrada
            // 
            this.dtgRptEntrada.AllowUserToResizeColumns = false;
            this.dtgRptEntrada.AllowUserToResizeRows = false;
            this.dtgRptEntrada.BackgroundColor = System.Drawing.Color.White;
            this.dtgRptEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgRptEntrada.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgRptEntrada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRptEntrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgRptEntrada.ColumnHeadersHeight = 35;
            this.dtgRptEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgRptEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMovimiento,
            this.cliente,
            this.tipoCliente,
            this.fechaReporte});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgRptEntrada.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgRptEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRptEntrada.EnableHeadersVisualStyles = false;
            this.dtgRptEntrada.GridColor = System.Drawing.Color.White;
            this.dtgRptEntrada.Location = new System.Drawing.Point(0, 0);
            this.dtgRptEntrada.Name = "dtgRptEntrada";
            this.dtgRptEntrada.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRptEntrada.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgRptEntrada.RowHeadersVisible = false;
            this.dtgRptEntrada.RowTemplate.Height = 28;
            this.dtgRptEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRptEntrada.Size = new System.Drawing.Size(819, 443);
            this.dtgRptEntrada.TabIndex = 5;
            // 
            // idMovimiento
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idMovimiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.idMovimiento.HeaderText = "ID REPORTE";
            this.idMovimiento.Name = "idMovimiento";
            this.idMovimiento.Width = 130;
            // 
            // cliente
            // 
            this.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cliente.HeaderText = "CLIENTE";
            this.cliente.Name = "cliente";
            // 
            // tipoCliente
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tipoCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.tipoCliente.HeaderText = "TIPO DE CLIENTE";
            this.tipoCliente.Name = "tipoCliente";
            this.tipoCliente.Width = 170;
            // 
            // fechaReporte
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fechaReporte.DefaultCellStyle = dataGridViewCellStyle4;
            this.fechaReporte.HeaderText = "FECHA REPORTE";
            this.fechaReporte.Name = "fechaReporte";
            this.fechaReporte.Width = 170;
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
            this.txbBuscarPDC.Location = new System.Drawing.Point(193, 79);
            this.txbBuscarPDC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbBuscarPDC.Name = "txbBuscarPDC";
            this.txbBuscarPDC.PasswordChar = '\0';
            this.txbBuscarPDC.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txbBuscarPDC.PlaceholderText = "Buscar..,";
            this.txbBuscarPDC.SelectedText = "";
            this.txbBuscarPDC.ShadowDecoration.Parent = this.txbBuscarPDC;
            this.txbBuscarPDC.Size = new System.Drawing.Size(153, 35);
            this.txbBuscarPDC.TabIndex = 4;
            // 
            // lblCatalogo
            // 
            this.lblCatalogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCatalogo.AutoSize = true;
            this.lblCatalogo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.lblCatalogo.Location = new System.Drawing.Point(348, 23);
            this.lblCatalogo.Name = "lblCatalogo";
            this.lblCatalogo.Size = new System.Drawing.Size(207, 22);
            this.lblCatalogo.TabIndex = 2;
            this.lblCatalogo.Text = "REPORTES DE ENTRADA";
            // 
            // ReportesEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(900, 595);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportesEntrada";
            this.Text = "ReportesEntrada";
            this.Load += new System.EventHandler(this.ReportesEntrada_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.panelDtgRptEntrada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRptEntrada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelMain;
        private Guna.UI2.WinForms.Guna2Button btnAñadirProductosaCatalogo;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDtgRptEntrada;
        private System.Windows.Forms.DataGridView dtgRptEntrada;
        private Guna.UI2.WinForms.Guna2TextBox txbBuscarPDC;
        private System.Windows.Forms.Label lblCatalogo;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBuscarFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaReporte;
    }
}