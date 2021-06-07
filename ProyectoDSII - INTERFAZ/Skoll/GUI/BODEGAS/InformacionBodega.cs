using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skoll.GUI.BODEGAS
{
    public partial class InformacionBodega : Form
    {
        public InformacionBodega()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCerrarInfo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
