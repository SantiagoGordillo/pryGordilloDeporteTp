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
    public partial class frmEliminarDeportista : Form
    {
        public frmEliminarDeportista()
        {
            InitializeComponent();
        }

        private void frmEliminarDeportista_Load(object sender, EventArgs e)
        {
            cmdEliminar.Enabled = false;
            txtCodigoDeportista.Focus();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string Codigo = txtCodigoDeportista.Text;
            clsDeportista Buscar = new clsDeportista();
            Buscar.Buscar(Codigo);

            if (Buscar.CDeportista != Codigo)
            {
                MessageBox.Show("El deportista no se encuentra en la base de datos");
                cmdEliminar.Enabled = false;
                txtCodigoDeportista.Focus();
                Limpiar();
            }
            else
            {
                cmdEliminar.Enabled = true;
                lblNombreED.Text = Buscar.Nombre;
                lblApellidoED.Text = Buscar.Apellido;
                lblDireccionED.Text = Buscar.Direccion;
                lblTelefonoED.Text = Convert.ToString(Buscar.Telefono);
                lblEdadED.Text = Convert.ToString(Buscar.Edad);
                lblDeporteED.Text = Convert.ToString(Buscar.Deportes);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            string CodigoDeportista = txtCodigoDeportista.Text;
            clsDeportista EliminarED = new clsDeportista();
            EliminarED.Eliminar(CodigoDeportista);

            Limpiar();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar()
        {
            txtCodigoDeportista.Text = "";
            lblNombreED.Text = "";
            lblApellidoED.Text = "";
            lblDireccionED.Text = "";
            lblTelefonoED.Text = "";
            lblEdadED.Text = "";
            lblDeporteED.Text = "";
            txtCodigoDeportista.Focus();
        }
    }
}
