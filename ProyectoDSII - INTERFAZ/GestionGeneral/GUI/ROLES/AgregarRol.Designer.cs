namespace GestionGeneral.GUI.ROLES
{
    partial class AgregarRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarRol));
            this.panelAgregarContrato = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelAddRol = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRol = new Guna.UI2.WinForms.Guna2Button();
            this.panelTituloAddPdCtg = new Guna.UI2.WinForms.Guna2Panel();
            this.lblEditarCatalogo = new System.Windows.Forms.Label();
            this.btnCloseAddRol = new System.Windows.Forms.PictureBox();
            this.txbRol = new Guna.UI2.WinForms.Guna2TextBox();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelAgregarContrato.SuspendLayout();
            this.panelTituloAddPdCtg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseAddRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAgregarContrato
            // 
            this.panelAgregarContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.panelAgregarContrato.BorderColor = System.Drawing.Color.Silver;
            this.panelAgregarContrato.BorderRadius = 4;
            this.panelAgregarContrato.BorderThickness = 1;
            this.panelAgregarContrato.Controls.Add(this.label1);
            this.panelAgregarContrato.Controls.Add(this.btnCancelAddRol);
            this.panelAgregarContrato.Controls.Add(this.btnAddRol);
            this.panelAgregarContrato.Controls.Add(this.panelTituloAddPdCtg);
            this.panelAgregarContrato.Controls.Add(this.txbRol);
            this.panelAgregarContrato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAgregarContrato.Location = new System.Drawing.Point(0, 0);
            this.panelAgregarContrato.Name = "panelAgregarContrato";
            this.panelAgregarContrato.ShadowDecoration.Parent = this.panelAgregarContrato;
            this.panelAgregarContrato.Size = new System.Drawing.Size(450, 210);
            this.panelAgregarContrato.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(19, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 69;
            this.label1.Text = "Nombre del Rol:";
            // 
            // btnCancelAddRol
            // 
            this.btnCancelAddRol.BorderRadius = 5;
            this.btnCancelAddRol.CheckedState.Parent = this.btnCancelAddRol;
            this.btnCancelAddRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelAddRol.CustomImages.Parent = this.btnCancelAddRol;
            this.btnCancelAddRol.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(79)))), ((int)(((byte)(83)))));
            this.btnCancelAddRol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddRol.ForeColor = System.Drawing.Color.White;
            this.btnCancelAddRol.HoverState.Parent = this.btnCancelAddRol;
            this.btnCancelAddRol.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelAddRol.Image")));
            this.btnCancelAddRol.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancelAddRol.ImageSize = new System.Drawing.Size(19, 19);
            this.btnCancelAddRol.Location = new System.Drawing.Point(307, 149);
            this.btnCancelAddRol.Name = "btnCancelAddRol";
            this.btnCancelAddRol.ShadowDecoration.Parent = this.btnCancelAddRol;
            this.btnCancelAddRol.Size = new System.Drawing.Size(110, 40);
            this.btnCancelAddRol.TabIndex = 67;
            this.btnCancelAddRol.Text = "CANCELAR";
            this.btnCancelAddRol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCancelAddRol.TextOffset = new System.Drawing.Point(4, 0);
            this.btnCancelAddRol.Click += new System.EventHandler(this.btnCancelAddRol_Click);
            // 
            // btnAddRol
            // 
            this.btnAddRol.BorderRadius = 5;
            this.btnAddRol.CheckedState.Parent = this.btnAddRol;
            this.btnAddRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRol.CustomImages.Parent = this.btnAddRol;
            this.btnAddRol.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(182)))), ((int)(((byte)(146)))));
            this.btnAddRol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRol.ForeColor = System.Drawing.Color.White;
            this.btnAddRol.HoverState.Parent = this.btnAddRol;
            this.btnAddRol.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRol.Image")));
            this.btnAddRol.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddRol.ImageSize = new System.Drawing.Size(19, 19);
            this.btnAddRol.Location = new System.Drawing.Point(191, 149);
            this.btnAddRol.Name = "btnAddRol";
            this.btnAddRol.ShadowDecoration.Parent = this.btnAddRol;
            this.btnAddRol.Size = new System.Drawing.Size(110, 40);
            this.btnAddRol.TabIndex = 66;
            this.btnAddRol.Text = "AGREGAR";
            this.btnAddRol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddRol.Click += new System.EventHandler(this.btnAddRol_Click);
            // 
            // panelTituloAddPdCtg
            // 
            this.panelTituloAddPdCtg.BackColor = System.Drawing.Color.White;
            this.panelTituloAddPdCtg.BorderColor = System.Drawing.Color.Silver;
            this.panelTituloAddPdCtg.BorderRadius = 4;
            this.panelTituloAddPdCtg.BorderThickness = 2;
            this.panelTituloAddPdCtg.Controls.Add(this.lblEditarCatalogo);
            this.panelTituloAddPdCtg.Controls.Add(this.btnCloseAddRol);
            this.panelTituloAddPdCtg.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloAddPdCtg.Location = new System.Drawing.Point(0, 0);
            this.panelTituloAddPdCtg.Name = "panelTituloAddPdCtg";
            this.panelTituloAddPdCtg.ShadowDecoration.Parent = this.panelTituloAddPdCtg;
            this.panelTituloAddPdCtg.Size = new System.Drawing.Size(450, 56);
            this.panelTituloAddPdCtg.TabIndex = 57;
            // 
            // lblEditarCatalogo
            // 
            this.lblEditarCatalogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditarCatalogo.AutoSize = true;
            this.lblEditarCatalogo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarCatalogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.lblEditarCatalogo.Location = new System.Drawing.Point(170, 23);
            this.lblEditarCatalogo.Name = "lblEditarCatalogo";
            this.lblEditarCatalogo.Size = new System.Drawing.Size(116, 19);
            this.lblEditarCatalogo.TabIndex = 20;
            this.lblEditarCatalogo.Text = "AGREGAR ROL";
            // 
            // btnCloseAddRol
            // 
            this.btnCloseAddRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseAddRol.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseAddRol.Image")));
            this.btnCloseAddRol.Location = new System.Drawing.Point(421, 7);
            this.btnCloseAddRol.Name = "btnCloseAddRol";
            this.btnCloseAddRol.Size = new System.Drawing.Size(21, 21);
            this.btnCloseAddRol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCloseAddRol.TabIndex = 19;
            this.btnCloseAddRol.TabStop = false;
            this.btnCloseAddRol.Click += new System.EventHandler(this.btnCloseAddRol_Click);
            // 
            // txbRol
            // 
            this.txbRol.BorderColor = System.Drawing.Color.Silver;
            this.txbRol.BorderRadius = 5;
            this.txbRol.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbRol.DefaultText = "";
            this.txbRol.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbRol.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbRol.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbRol.DisabledState.Parent = this.txbRol;
            this.txbRol.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbRol.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbRol.FocusedState.Parent = this.txbRol;
            this.txbRol.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.txbRol.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbRol.HoverState.Parent = this.txbRol;
            this.txbRol.Location = new System.Drawing.Point(152, 85);
            this.txbRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbRol.Name = "txbRol";
            this.txbRol.PasswordChar = '\0';
            this.txbRol.PlaceholderText = "";
            this.txbRol.SelectedText = "";
            this.txbRol.ShadowDecoration.Parent = this.txbRol;
            this.txbRol.Size = new System.Drawing.Size(265, 35);
            this.txbRol.TabIndex = 38;
            this.txbRol.TabStop = false;
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // AgregarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 210);
            this.Controls.Add(this.panelAgregarContrato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarRol";
            this.panelAgregarContrato.ResumeLayout(false);
            this.panelAgregarContrato.PerformLayout();
            this.panelTituloAddPdCtg.ResumeLayout(false);
            this.panelTituloAddPdCtg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseAddRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelAgregarContrato;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnCancelAddRol;
        private Guna.UI2.WinForms.Guna2Button btnAddRol;
        private Guna.UI2.WinForms.Guna2Panel panelTituloAddPdCtg;
        private System.Windows.Forms.Label lblEditarCatalogo;
        private System.Windows.Forms.PictureBox btnCloseAddRol;
        private Guna.UI2.WinForms.Guna2TextBox txbRol;
        private System.Windows.Forms.ErrorProvider Notificador;
    }
}