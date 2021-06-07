namespace GestionGeneral.GUI.PERMISOS
{
    partial class Permisos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbSeleccionarRol = new System.Windows.Forms.ComboBox();
            this.panelDtgListaPermisos = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgPermisos = new System.Windows.Forms.DataGridView();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID_Opcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PERMISO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelDtgListaPermisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.lblEmpleados);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(900, 595);
            this.panelMain.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cbbSeleccionarRol);
            this.panel2.Controls.Add(this.panelDtgListaPermisos);
            this.panel2.Controls.Add(this.guna2Panel2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(102, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 484);
            this.panel2.TabIndex = 10;
            // 
            // cbbSeleccionarRol
            // 
            this.cbbSeleccionarRol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbSeleccionarRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.cbbSeleccionarRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSeleccionarRol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSeleccionarRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.cbbSeleccionarRol.FormattingEnabled = true;
            this.cbbSeleccionarRol.Location = new System.Drawing.Point(271, 48);
            this.cbbSeleccionarRol.Name = "cbbSeleccionarRol";
            this.cbbSeleccionarRol.Size = new System.Drawing.Size(199, 29);
            this.cbbSeleccionarRol.TabIndex = 86;
            this.cbbSeleccionarRol.TabStop = false;
            this.cbbSeleccionarRol.SelectedValueChanged += new System.EventHandler(this.cbbSeleccionarRol_SelectedValueChanged);
            // 
            // panelDtgListaPermisos
            // 
            this.panelDtgListaPermisos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDtgListaPermisos.BackColor = System.Drawing.Color.Transparent;
            this.panelDtgListaPermisos.Controls.Add(this.dtgPermisos);
            this.panelDtgListaPermisos.FillColor = System.Drawing.Color.Maroon;
            this.panelDtgListaPermisos.Location = new System.Drawing.Point(17, 97);
            this.panelDtgListaPermisos.Name = "panelDtgListaPermisos";
            this.panelDtgListaPermisos.ShadowDecoration.Parent = this.panelDtgListaPermisos;
            this.panelDtgListaPermisos.Size = new System.Drawing.Size(655, 370);
            this.panelDtgListaPermisos.TabIndex = 2;
            // 
            // dtgPermisos
            // 
            this.dtgPermisos.AllowUserToAddRows = false;
            this.dtgPermisos.AllowUserToDeleteRows = false;
            this.dtgPermisos.AllowUserToResizeColumns = false;
            this.dtgPermisos.AllowUserToResizeRows = false;
            this.dtgPermisos.BackgroundColor = System.Drawing.Color.White;
            this.dtgPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPermisos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgPermisos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPermisos.ColumnHeadersHeight = 27;
            this.dtgPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion,
            this.ID_Opcion,
            this.nombres,
            this.ID_PERMISO});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPermisos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgPermisos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPermisos.EnableHeadersVisualStyles = false;
            this.dtgPermisos.GridColor = System.Drawing.Color.White;
            this.dtgPermisos.Location = new System.Drawing.Point(0, 0);
            this.dtgPermisos.MultiSelect = false;
            this.dtgPermisos.Name = "dtgPermisos";
            this.dtgPermisos.ReadOnly = true;
            this.dtgPermisos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPermisos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgPermisos.RowHeadersVisible = false;
            this.dtgPermisos.RowTemplate.Height = 28;
            this.dtgPermisos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPermisos.Size = new System.Drawing.Size(655, 370);
            this.dtgPermisos.TabIndex = 6;
            this.dtgPermisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPermisos_CellContentClick);
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
            // 
            // ID_Opcion
            // 
            this.ID_Opcion.DataPropertyName = "ID_Opcion";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID_Opcion.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID_Opcion.HeaderText = "ID";
            this.ID_Opcion.Name = "ID_Opcion";
            this.ID_Opcion.ReadOnly = true;
            this.ID_Opcion.Width = 70;
            // 
            // nombres
            // 
            this.nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombres.DataPropertyName = "Opcion";
            this.nombres.HeaderText = "OPCION";
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            // 
            // ID_PERMISO
            // 
            this.ID_PERMISO.DataPropertyName = "ID_Permiso";
            this.ID_PERMISO.HeaderText = "ID PERMISO";
            this.ID_PERMISO.Name = "ID_PERMISO";
            this.ID_PERMISO.ReadOnly = true;
            this.ID_PERMISO.Width = 105;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Teal;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(690, 29);
            this.guna2Panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label8.Location = new System.Drawing.Point(202, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 21);
            this.label8.TabIndex = 82;
            this.label8.Text = "Rol:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 2);
            this.panel1.TabIndex = 17;
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.lblEmpleados.Location = new System.Drawing.Point(400, 23);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(95, 22);
            this.lblEmpleados.TabIndex = 2;
            this.lblEmpleados.Text = "PERMISOS";
            // 
            // Permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 595);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Permisos";
            this.Text = "Permisos";
            this.Load += new System.EventHandler(this.Permisos_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelDtgListaPermisos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmpleados;
        public System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel panelDtgListaPermisos;
        public System.Windows.Forms.DataGridView dtgPermisos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbSeleccionarRol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Opcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PERMISO;
    }
}