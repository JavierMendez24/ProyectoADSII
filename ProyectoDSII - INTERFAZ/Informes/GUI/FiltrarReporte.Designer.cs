namespace Informes.GUI
{
    partial class FiltrarReporte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.cbbSeleccionarZona = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDtgRptEntrada = new System.Windows.Forms.Panel();
            this.dtgRptEntrada = new System.Windows.Forms.DataGridView();
            this.idMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaReporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelDtgRptEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRptEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.panelMain.Controls.Add(this.cbbSeleccionarZona);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.panelDtgRptEntrada);
            this.panelMain.Controls.Add(this.lblCatalogo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(900, 595);
            this.panelMain.TabIndex = 7;
            // 
            // cbbSeleccionarZona
            // 
            this.cbbSeleccionarZona.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbSeleccionarZona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.cbbSeleccionarZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSeleccionarZona.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSeleccionarZona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.cbbSeleccionarZona.FormattingEnabled = true;
            this.cbbSeleccionarZona.Location = new System.Drawing.Point(88, 82);
            this.cbbSeleccionarZona.Name = "cbbSeleccionarZona";
            this.cbbSeleccionarZona.Size = new System.Drawing.Size(199, 29);
            this.cbbSeleccionarZona.TabIndex = 87;
            this.cbbSeleccionarZona.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(34, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Zona:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(448, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha:";
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
            this.dtgRptEntrada.AllowUserToAddRows = false;
            this.dtgRptEntrada.AllowUserToDeleteRows = false;
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
            this.zona,
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
            this.dtgRptEntrada.ReadOnly = true;
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
            this.idMovimiento.DataPropertyName = "ID_Movimiento";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idMovimiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.idMovimiento.HeaderText = "ID REPORTE";
            this.idMovimiento.Name = "idMovimiento";
            this.idMovimiento.ReadOnly = true;
            this.idMovimiento.Width = 130;
            // 
            // cliente
            // 
            this.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cliente.DataPropertyName = "Nombre_Cliente";
            this.cliente.HeaderText = "CLIENTE";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // zona
            // 
            this.zona.DataPropertyName = "Zona";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.zona.DefaultCellStyle = dataGridViewCellStyle3;
            this.zona.HeaderText = "ZONA";
            this.zona.Name = "zona";
            this.zona.ReadOnly = true;
            this.zona.Width = 170;
            // 
            // fechaReporte
            // 
            this.fechaReporte.DataPropertyName = "Fecha";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fechaReporte.DefaultCellStyle = dataGridViewCellStyle4;
            this.fechaReporte.HeaderText = "FECHA REPORTE";
            this.fechaReporte.Name = "fechaReporte";
            this.fechaReporte.ReadOnly = true;
            this.fechaReporte.Width = 170;
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
            // FiltrarReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 595);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FiltrarReporte";
            this.Text = "FiltrarReporte";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelDtgRptEntrada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRptEntrada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ComboBox cbbSeleccionarZona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDtgRptEntrada;
        private System.Windows.Forms.DataGridView dtgRptEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn zona;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaReporte;
        private System.Windows.Forms.Label lblCatalogo;
    }
}