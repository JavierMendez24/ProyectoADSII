namespace GestionGeneral.GUI.EMPLEADOS
{
    partial class Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.txbBuscarEmpleados = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDtgEmpleados = new System.Windows.Forms.Panel();
            this.dtgEmpleados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDetallesEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregarEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditarEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.panelDtgEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.panelMain.Controls.Add(this.guna2VSeparator1);
            this.panelMain.Controls.Add(this.pbSearch);
            this.panelMain.Controls.Add(this.txbBuscarEmpleados);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.panelDtgEmpleados);
            this.panelMain.Controls.Add(this.btnDetallesEmpleado);
            this.panelMain.Controls.Add(this.btnAgregarEmpleado);
            this.panelMain.Controls.Add(this.btnEditarEmpleado);
            this.panelMain.Controls.Add(this.btnEliminarEmpleado);
            this.panelMain.Controls.Add(this.lblEmpleados);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(900, 595);
            this.panelMain.TabIndex = 8;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2VSeparator1.BackColor = System.Drawing.Color.White;
            this.guna2VSeparator1.FillColor = System.Drawing.Color.Silver;
            this.guna2VSeparator1.Location = new System.Drawing.Point(823, 87);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 27);
            this.guna2VSeparator1.TabIndex = 20;
            // 
            // pbSearch
            // 
            this.pbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSearch.BackColor = System.Drawing.Color.White;
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.Location = new System.Drawing.Point(833, 90);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(20, 20);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 19;
            this.pbSearch.TabStop = false;
            // 
            // txbBuscarEmpleados
            // 
            this.txbBuscarEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbBuscarEmpleados.BorderColor = System.Drawing.Color.Silver;
            this.txbBuscarEmpleados.BorderRadius = 8;
            this.txbBuscarEmpleados.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbBuscarEmpleados.DefaultText = "";
            this.txbBuscarEmpleados.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbBuscarEmpleados.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbBuscarEmpleados.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbBuscarEmpleados.DisabledState.Parent = this.txbBuscarEmpleados;
            this.txbBuscarEmpleados.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbBuscarEmpleados.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbBuscarEmpleados.FocusedState.Parent = this.txbBuscarEmpleados;
            this.txbBuscarEmpleados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarEmpleados.ForeColor = System.Drawing.Color.Black;
            this.txbBuscarEmpleados.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbBuscarEmpleados.HoverState.Parent = this.txbBuscarEmpleados;
            this.txbBuscarEmpleados.Location = new System.Drawing.Point(539, 83);
            this.txbBuscarEmpleados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbBuscarEmpleados.Name = "txbBuscarEmpleados";
            this.txbBuscarEmpleados.PasswordChar = '\0';
            this.txbBuscarEmpleados.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txbBuscarEmpleados.PlaceholderText = "Ingrese el nombre";
            this.txbBuscarEmpleados.SelectedText = "";
            this.txbBuscarEmpleados.ShadowDecoration.Parent = this.txbBuscarEmpleados;
            this.txbBuscarEmpleados.Size = new System.Drawing.Size(318, 35);
            this.txbBuscarEmpleados.TabIndex = 18;
            this.txbBuscarEmpleados.TextChanged += new System.EventHandler(this.txbBuscarEmpleados_TextChanged);
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
            // panelDtgEmpleados
            // 
            this.panelDtgEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDtgEmpleados.Controls.Add(this.dtgEmpleados);
            this.panelDtgEmpleados.Location = new System.Drawing.Point(38, 133);
            this.panelDtgEmpleados.Name = "panelDtgEmpleados";
            this.panelDtgEmpleados.Size = new System.Drawing.Size(819, 441);
            this.panelDtgEmpleados.TabIndex = 9;
            // 
            // dtgEmpleados
            // 
            this.dtgEmpleados.AllowUserToAddRows = false;
            this.dtgEmpleados.AllowUserToDeleteRows = false;
            this.dtgEmpleados.AllowUserToResizeColumns = false;
            this.dtgEmpleados.AllowUserToResizeRows = false;
            this.dtgEmpleados.BackgroundColor = System.Drawing.Color.White;
            this.dtgEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgEmpleados.ColumnHeadersHeight = 35;
            this.dtgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nombres,
            this.apellidos,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgEmpleados.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgEmpleados.EnableHeadersVisualStyles = false;
            this.dtgEmpleados.GridColor = System.Drawing.Color.White;
            this.dtgEmpleados.Location = new System.Drawing.Point(0, 0);
            this.dtgEmpleados.MultiSelect = false;
            this.dtgEmpleados.Name = "dtgEmpleados";
            this.dtgEmpleados.ReadOnly = true;
            this.dtgEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgEmpleados.RowHeadersVisible = false;
            this.dtgEmpleados.RowTemplate.Height = 28;
            this.dtgEmpleados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEmpleados.Size = new System.Drawing.Size(819, 441);
            this.dtgEmpleados.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Empleado";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID EMPLEADO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // nombres
            // 
            this.nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombres.DataPropertyName = "Nombres";
            this.nombres.HeaderText = "NOMBRES";
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            // 
            // apellidos
            // 
            this.apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellidos.DataPropertyName = "Apellidos";
            this.apellidos.HeaderText = "APELLIDOS";
            this.apellidos.Name = "apellidos";
            this.apellidos.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NIT";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "NIT";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 160;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefono";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn4.HeaderText = "TELÉFONO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 140;
            // 
            // btnDetallesEmpleado
            // 
            this.btnDetallesEmpleado.BorderRadius = 6;
            this.btnDetallesEmpleado.CheckedState.Parent = this.btnDetallesEmpleado;
            this.btnDetallesEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetallesEmpleado.CustomImages.Parent = this.btnDetallesEmpleado;
            this.btnDetallesEmpleado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(132)))), ((int)(((byte)(194)))));
            this.btnDetallesEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetallesEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnDetallesEmpleado.HoverState.Parent = this.btnDetallesEmpleado;
            this.btnDetallesEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnDetallesEmpleado.Image")));
            this.btnDetallesEmpleado.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDetallesEmpleado.ImageSize = new System.Drawing.Size(15, 15);
            this.btnDetallesEmpleado.Location = new System.Drawing.Point(356, 83);
            this.btnDetallesEmpleado.Name = "btnDetallesEmpleado";
            this.btnDetallesEmpleado.ShadowDecoration.Parent = this.btnDetallesEmpleado;
            this.btnDetallesEmpleado.Size = new System.Drawing.Size(100, 35);
            this.btnDetallesEmpleado.TabIndex = 16;
            this.btnDetallesEmpleado.Text = "VER MÁS";
            this.btnDetallesEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDetallesEmpleado.TextOffset = new System.Drawing.Point(3, 0);
            this.btnDetallesEmpleado.Click += new System.EventHandler(this.btnDetallesEmpleado_Click);
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.BorderRadius = 6;
            this.btnAgregarEmpleado.CheckedState.Parent = this.btnAgregarEmpleado;
            this.btnAgregarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarEmpleado.CustomImages.Parent = this.btnAgregarEmpleado;
            this.btnAgregarEmpleado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(182)))), ((int)(((byte)(146)))));
            this.btnAgregarEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEmpleado.HoverState.Parent = this.btnAgregarEmpleado;
            this.btnAgregarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEmpleado.Image")));
            this.btnAgregarEmpleado.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAgregarEmpleado.ImageSize = new System.Drawing.Size(15, 15);
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(38, 83);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.ShadowDecoration.Parent = this.btnAgregarEmpleado;
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(100, 35);
            this.btnAgregarEmpleado.TabIndex = 15;
            this.btnAgregarEmpleado.Text = "AGREGAR";
            this.btnAgregarEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAgregarEmpleado.TextOffset = new System.Drawing.Point(3, 0);
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // btnEditarEmpleado
            // 
            this.btnEditarEmpleado.BorderRadius = 6;
            this.btnEditarEmpleado.CheckedState.Parent = this.btnEditarEmpleado;
            this.btnEditarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarEmpleado.CustomImages.Parent = this.btnEditarEmpleado;
            this.btnEditarEmpleado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(161)))), ((int)(((byte)(3)))));
            this.btnEditarEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEditarEmpleado.HoverState.Parent = this.btnEditarEmpleado;
            this.btnEditarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarEmpleado.Image")));
            this.btnEditarEmpleado.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEditarEmpleado.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnEditarEmpleado.ImageSize = new System.Drawing.Size(15, 15);
            this.btnEditarEmpleado.Location = new System.Drawing.Point(144, 83);
            this.btnEditarEmpleado.Name = "btnEditarEmpleado";
            this.btnEditarEmpleado.ShadowDecoration.Parent = this.btnEditarEmpleado;
            this.btnEditarEmpleado.Size = new System.Drawing.Size(100, 35);
            this.btnEditarEmpleado.TabIndex = 14;
            this.btnEditarEmpleado.Text = "EDITAR";
            this.btnEditarEmpleado.TextOffset = new System.Drawing.Point(12, 0);
            this.btnEditarEmpleado.Click += new System.EventHandler(this.btnEditarEmpleado_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.BorderRadius = 6;
            this.btnEliminarEmpleado.CheckedState.Parent = this.btnEliminarEmpleado;
            this.btnEliminarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEmpleado.CustomImages.Parent = this.btnEliminarEmpleado;
            this.btnEliminarEmpleado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(79)))), ((int)(((byte)(83)))));
            this.btnEliminarEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEmpleado.HoverState.Parent = this.btnEliminarEmpleado;
            this.btnEliminarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarEmpleado.Image")));
            this.btnEliminarEmpleado.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEliminarEmpleado.ImageSize = new System.Drawing.Size(15, 15);
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(250, 83);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.ShadowDecoration.Parent = this.btnEliminarEmpleado;
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(100, 35);
            this.btnEliminarEmpleado.TabIndex = 13;
            this.btnEliminarEmpleado.Text = "ELIMINAR";
            this.btnEliminarEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEliminarEmpleado.TextOffset = new System.Drawing.Point(3, 0);
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.lblEmpleados.Location = new System.Drawing.Point(370, 23);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(190, 22);
            this.lblEmpleados.TabIndex = 2;
            this.lblEmpleados.Text = "LISTA DE EMPLEADOS";
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 595);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.panelDtgEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panelDtgEmpleados;
        public System.Windows.Forms.DataGridView dtgEmpleados;
        private Guna.UI2.WinForms.Guna2Button btnDetallesEmpleado;
        private Guna.UI2.WinForms.Guna2Button btnAgregarEmpleado;
        private Guna.UI2.WinForms.Guna2Button btnEditarEmpleado;
        private Guna.UI2.WinForms.Guna2Button btnEliminarEmpleado;
        private System.Windows.Forms.Label lblEmpleados;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.PictureBox pbSearch;
        private Guna.UI2.WinForms.Guna2TextBox txbBuscarEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}