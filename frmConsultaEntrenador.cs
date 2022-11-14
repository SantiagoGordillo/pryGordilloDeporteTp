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
    public partial class frmConsultaEntrenador : Form
    {
        public frmConsultaEntrenador()
        {
            InitializeComponent();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            dgvConsultaEntrenadores.DataSource = null;
            clsEntrenador Consultar = new clsEntrenador();
            Consultar.Listar(dgvConsultaEntrenadores);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
