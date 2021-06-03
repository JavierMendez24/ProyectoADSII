using System;
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
    public partial class AgregarProductosaCatalogo : Form
    {
        public AgregarProductosaCatalogo()
        {
            InitializeComponent();
        }

        private void btnCerrarAgregarPdaC_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
