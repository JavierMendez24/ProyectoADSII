﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skoll.GUI.CLIENTES
{
    public partial class DetallesClientePersona : Form
    {
        public DetallesClientePersona()
        {
            InitializeComponent();
        }

        private void btnCerrarDetallesCltPr_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
