﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skoll.GUI.REPORTES
{
    public partial class ReportesEntrada : Form
    {
        public ReportesEntrada()
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in dtgRptEntrada.Rows)
                fila.Height = 28;
        }

        private void ReportesEntrada_Load(object sender, EventArgs e)
        {
            dtpBuscarFecha.CustomFormat = "yyyy/MM/dd";
        }
    }
}
