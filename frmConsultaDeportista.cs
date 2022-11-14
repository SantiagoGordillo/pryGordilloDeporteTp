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
    public partial class frmConsultaDeportista : Form
    {
        public frmConsultaDeportista()
        {
            InitializeComponent();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            dgvConsultaDeportista.DataSource = null;
            clsDeportista Consulta = new clsDeportista();
            Consulta.Listar(dgvConsultaDeportista);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
