using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGordilloDeporteTp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void TSMRegistroDeportista_Click(object sender, EventArgs e)
        {
            frmRegistroDeportista RegistroDeportista = new frmRegistroDeportista();
            RegistroDeportista.ShowDialog();
        }

        private void TSMRegistroEntrenador_Click(object sender, EventArgs e)
        {
            frmRegistroEntrenador RegistroEntrenador = new frmRegistroEntrenador();
            RegistroEntrenador.ShowDialog();
        }

        private void TSMConsultaDeportista_Click(object sender, EventArgs e)
        {
            frmConsultaDeportista ConsultaDeportista = new frmConsultaDeportista();
            ConsultaDeportista.ShowDialog();
        }

        private void TSMConsultaEntrenador_Click(object sender, EventArgs e)
        {
            frmConsultaEntrenador ConsultaEntrenador = new frmConsultaEntrenador();
            ConsultaEntrenador.ShowDialog();
        }

        private void TSMModificarDeportista_Click(object sender, EventArgs e)
        {
            frmModificarDeportista ModificarDeportista = new frmModificarDeportista();
            ModificarDeportista.ShowDialog();
        }

        private void TSMModificarEntrenadores_Click(object sender, EventArgs e)
        {
            frmModificarEntrenador ModificarEntrenador = new frmModificarEntrenador();
            ModificarEntrenador.ShowDialog();
        }

        private void TSMEliminarDeportista_Click(object sender, EventArgs e)
        {
            frmEliminarDeportista EliminarDeportista = new frmEliminarDeportista();
            EliminarDeportista.ShowDialog();
        }

        private void TSMEliminarEntrenadores_Click(object sender, EventArgs e)
        {
            frmEliminarEntrenador EliminarEntrenador = new frmEliminarEntrenador();
            EliminarEntrenador.ShowDialog();
        }

        private void TSMSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
