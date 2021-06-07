﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skoll.GUI.PRODUCTOS
{
    public partial class Seleccionar_Zona : Form
    {
        public Seleccionar_Zona()
        {
            InitializeComponent();
        }

        private void btnCancelarAddZn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCerrarSeleccionarZonas_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbx1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx1.Checked == true)
            {
                cbx2.Checked = false;
                cbx3.Checked = false;
            }
        }

        private void cbx2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx2.Checked == true)
            {
                cbx1.Checked = false;
                cbx3.Checked = false;
            }
        }

        private void cbx3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx3.Checked == true)
            {
                cbx1.Checked = false;
                cbx2.Checked = false;
            }
        }
    }
}