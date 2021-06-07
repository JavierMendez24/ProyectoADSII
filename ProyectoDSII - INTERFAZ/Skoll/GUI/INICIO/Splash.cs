using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skoll.GUI.INICIO
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void progressBarTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Width != panelProgressBar.Width)
            {
                progressBar.Width = progressBar.Width + 9;
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            progressBarTimer.Start();
            Cronometro.Start();
        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            Cronometro.Stop();
            progressBarTimer.Stop();
            Close();
        }
    }
}
