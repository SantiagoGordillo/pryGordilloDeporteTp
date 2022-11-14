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
    public partial class frmEliminarEntrenador : Form
    {
        public frmEliminarEntrenador()
        {
            InitializeComponent();
        }

        private void frmEliminarEntrenador_Load(object sender, EventArgs e)
        {
            cmdEliminar.Enabled = false;
            txtCodigoEntrenador.Focus();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string Codigo = txtCodigoEntrenador.Text;
            clsEntrenador Buscar = new clsEntrenador();
            Buscar.Buscar(Codigo);

            if (Buscar.CEntrenador != Codigo)
            {
                MessageBox.Show("El entrenador no se encuentra en la base de datos");
                cmdEliminar.Enabled = false;
                txtCodigoEntrenador.Focus();
                Limpiar();
            }
            else
            {
                cmdEliminar.Enabled = true;
                lblNombreEE.Text = Buscar.Nombre;
                lblApellidoEE.Text = Buscar.Apellido;
                lblDireccionEE.Text = Buscar.Direccion;
                lblProvinciaEE.Text = Buscar.Prov;
                lblDeporteEE.Text = Convert.ToString(Buscar.Deportes);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            string CodigoEntrenadores = txtCodigoEntrenador.Text;
            clsEntrenador Eliminar = new clsEntrenador();
            Eliminar.Eliminar(CodigoEntrenadores);

            Limpiar();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar()
        {
            txtCodigoEntrenador.Text = "";
            lblNombreEE.Text = "";
            lblApellidoEE.Text = "";
            lblDireccionEE.Text = "";
            lblProvinciaEE.Text = "";
            lblDeporteEE.Text = "";
            txtCodigoEntrenador.Focus();
        }
    }
}
