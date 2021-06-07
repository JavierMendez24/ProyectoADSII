namespace GestionGeneral.GUI.USUARIOS
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.txbBuscarUsuarios = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDtgUsuarios = new System.Windows.Forms.Panel();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditarUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.panelDtgUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.panelMain.Controls.Add(this.guna2VSeparator1);
            this.panelMain.Controls.Add(this.pbSearch);
            this.panelMain.Controls.Add(this.txbBuscarUsuarios);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.panelDtgUsuarios);
            this.panelMain.Controls.Add(this.btnAgregarUsuario);
            this.panelMain.Controls.Add(this.btnEditarUsuario);
            this.panelMain.Controls.Add(this.btnEliminarUsuario);
            this.panelMain.Controls.Add(this.lblEmpleados);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(900, 595);
            this.panelMain.TabIndex = 9;
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
            // txbBuscarUsuarios
            // 
            this.txbBuscarUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbBuscarUsuarios.BorderColor = System.Drawing.Color.Silver;
            this.txbBuscarUsuarios.BorderRadius = 8;
            this.txbBuscarUsuarios.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbBuscarUsuarios.DefaultText = "";
            this.txbBuscarUsuarios.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbBuscarUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbBuscarUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbBuscarUsuarios.DisabledState.Parent = this.txbBuscarUsuarios;
            this.txbBuscarUsuarios.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbBuscarUsuarios.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbBuscarUsuarios.FocusedState.Parent = this.txbBuscarUsuarios;
            this.txbBuscarUsuarios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarUsuarios.ForeColor = System.Drawing.Color.Black;
            this.txbBuscarUsuarios.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbBuscarUsuarios.HoverState.Parent = this.txbBuscarUsuarios;
            this.txbBuscarUsuarios.Location = new System.Drawing.Point(539, 83);
            this.txbBuscarUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbBuscarUsuarios.Name = "txbBuscarUsuarios";
            this.txbBuscarUsuarios.PasswordChar = '\0';
            this.txbBuscarUsuarios.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txbBuscarUsuarios.PlaceholderText = "Ingrese el nombre";
            this.txbBuscarUsuarios.SelectedText = "";
            this.txbBuscarUsuarios.ShadowDecoration.Parent = this.txbBuscarUsuarios;
            this.txbBuscarUsuarios.Size = new System.Drawing.Size(318, 35);
            this.txbBuscarUsuarios.TabIndex = 18;
            this.txbBuscarUsuarios.TextChanged += new System.EventHandler(this.txbBuscarUsuarios_TextChanged);
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
            // panelDtgUsuarios
            // 
            this.panelDtgUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDtgUsuarios.Controls.Add(this.dtgUsuarios);
            this.panelDtgUsuarios.Location = new System.Drawing.Point(38, 133);
            this.panelDtgUsuarios.Name = "panelDtgUsuarios";
            this.panelDtgUsuarios.Size = new System.Drawing.Size(819, 441);
            this.panelDtgUsuarios.TabIndex = 9;
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AllowUserToAddRows = false;
            this.dtgUsuarios.AllowUserToDeleteRows = false;
            this.dtgUsuarios.AllowUserToResizeColumns = false;
            this.dtgUsuarios.AllowUserToResizeRows = false;
            this.dtgUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dtgUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgUsuarios.ColumnHeadersHeight = 35;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dtgUsuarios.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgUsuarios.EnableHeadersVisualStyles = false;
            this.dtgUsuarios.GridColor = System.Drawing.Color.White;
            this.dtgUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dtgUsuarios.MultiSelect = false;
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgUsuarios.RowHeadersVisible = false;
            this.dtgUsuarios.RowTemplate.Height = 28;
            this.dtgUsuarios.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUsuarios.Size = new System.Drawing.Size(819, 441);
            this.dtgUsuarios.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Empleado";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID EMPLEADO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 135;
            // 
            // nombres
            // 
            this.nombres.DataPropertyName = "ID_Usuario";
            this.nombres.HeaderText = "ID USUARIO";
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            this.nombres.Width = 135;
            // 
            // apellidos
            // 
            this.apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellidos.DataPropertyName = "Usuario";
            this.apellidos.HeaderText = "USUARIO";
            this.apellidos.Name = "apellidos";
            this.apellidos.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Clave";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "CLAVE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 160;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_Rol";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn4.HeaderText = "ROL";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 155;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BorderRadius = 6;
            this.btnAgregarUsuario.CheckedState.Parent = this.btnAgregarUsuario;
            this.btnAgregarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarUsuario.CustomImages.Parent = this.btnAgregarUsuario;
            this.btnAgregarUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(182)))), ((int)(((byte)(146)))));
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUsuario.HoverState.Parent = this.btnAgregarUsuario;
            this.btnAgregarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarUsuario.Image")));
            this.btnAgregarUsuario.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAgregarUsuario.ImageSize = new System.Drawing.Size(15, 15);
            this.btnAgregarUsuario.Location = new System.Drawing.Point(38, 83);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.ShadowDecoration.Parent = this.btnAgregarUsuario;
            this.btnAgregarUsuario.Size = new System.Drawing.Size(100, 35);
            this.btnAgregarUsuario.TabIndex = 15;
            this.btnAgregarUsuario.Text = "AGREGAR";
            this.btnAgregarUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAgregarUsuario.TextOffset = new System.Drawing.Point(3, 0);
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.BorderRadius = 6;
            this.btnEditarUsuario.CheckedState.Parent = this.btnEditarUsuario;
            this.btnEditarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarUsuario.CustomImages.Parent = this.btnEditarUsuario;
            this.btnEditarUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(161)))), ((int)(((byte)(3)))));
            this.btnEditarUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnEditarUsuario.HoverState.Parent = this.btnEditarUsuario;
            this.btnEditarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarUsuario.Image")));
            this.btnEditarUsuario.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEditarUsuario.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnEditarUsuario.ImageSize = new System.Drawing.Size(15, 15);
            this.btnEditarUsuario.Location = new System.Drawing.Point(144, 83);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.ShadowDecoration.Parent = this.btnEditarUsuario;
            this.btnEditarUsuario.Size = new System.Drawing.Size(100, 35);
            this.btnEditarUsuario.TabIndex = 14;
            this.btnEditarUsuario.Text = "EDITAR";
            this.btnEditarUsuario.TextOffset = new System.Drawing.Point(12, 0);
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BorderRadius = 6;
            this.btnEliminarUsuario.CheckedState.Parent = this.btnEliminarUsuario;
            this.btnEliminarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarUsuario.CustomImages.Parent = this.btnEliminarUsuario;
            this.btnEliminarUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(79)))), ((int)(((byte)(83)))));
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnEliminarUsuario.HoverState.Parent = this.btnEliminarUsuario;
            this.btnEliminarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarUsuario.Image")));
            this.btnEliminarUsuario.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEliminarUsuario.ImageSize = new System.Drawing.Size(15, 15);
            this.btnEliminarUsuario.Location = new System.Drawing.Point(250, 83);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.ShadowDecoration.Parent = this.btnEliminarUsuario;
            this.btnEliminarUsuario.Size = new System.Drawing.Size(100, 35);
            this.btnEliminarUsuario.TabIndex = 13;
            this.btnEliminarUsuario.Text = "ELIMINAR";
            this.btnEliminarUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEliminarUsuario.TextOffset = new System.Drawing.Point(3, 0);
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.lblEmpleados.Location = new System.Drawing.Point(370, 23);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(173, 22);
            this.lblEmpleados.TabIndex = 2;
            this.lblEmpleados.Text = "LISTA DE USUARIOS";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 595);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.panelDtgUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelMain;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.PictureBox pbSearch;
        private Guna.UI2.WinForms.Guna2TextBox txbBuscarUsuarios;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panelDtgUsuarios;
        public System.Windows.Forms.DataGridView dtgUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnAgregarUsuario;
        private Guna.UI2.WinForms.Guna2Button btnEditarUsuario;
        private Guna.UI2.WinForms.Guna2Button btnEliminarUsuario;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}