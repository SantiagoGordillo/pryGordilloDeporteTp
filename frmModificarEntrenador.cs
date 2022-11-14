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
    public partial class frmModificarEntrenador : Form
    {
        public frmModificarEntrenador()
        {
            InitializeComponent();
        }

        private void frmModificarEntrenador_Load(object sender, EventArgs e)
        {
            txtCodigoEntrenador.Focus();
            cmdGuardar.Enabled = false;
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string Codigo = txtCodigoEntrenador.Text;
            clsEntrenador Buscar = new clsEntrenador();
            Buscar.Buscar(Codigo);

            if (Buscar.CEntrenador != Codigo)
            {
                MessageBox.Show("El entrenador no se encuentra en la base de datos");
                txtCodigoEntrenador.Focus();
                Limpiar();
            }
            else
            {
                txtNombre.Text = Buscar.Nombre;
                txtApellido.Text = Buscar.Apellido;
                txtDireccion.Text = Buscar.Direccion;
                txtProvincia.Text = Buscar.Prov;
                lstDeporte.Text = Convert.ToString(Buscar.Deportes);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string CEntrenador = txtCodigoEntrenador.Text;
            clsEntrenador Modificar = new clsEntrenador();
            Modificar.Nombre = txtNombre.Text;
            Modificar.Apellido = txtApellido.Text;
            Modificar.Direccion = Convert.ToString(txtDireccion.Text);
            Modificar.Prov = txtProvincia.Text;
            Modificar.Deportes = Convert.ToString(lstDeporte.SelectedItem);
            Modificar.Modificar(CEntrenador);
            Limpiar();
            txtCodigoEntrenador.Focus();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar()
        {
            txtCodigoEntrenador.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtProvincia.Text = "";
            lstDeporte.SelectedIndex = -1;
        }

        private void Check()
        {
            if (txtCodigoEntrenador.Text != "" & txtNombre.Text != "" & txtApellido.Text != "" & txtDireccion.Text != "" & txtDireccion.Text != "" & txtProvincia.Text != "" & lstDeporte.SelectedIndex > -1)
            {
                cmdGuardar.Enabled = true;
            }
            else
            {
                cmdGuardar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtProvincia_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void lstDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check();
        }
    }
}
