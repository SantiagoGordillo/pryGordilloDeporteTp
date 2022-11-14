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
    public partial class frmRegistroDeportista : Form
    {
        public frmRegistroDeportista()
        {
            InitializeComponent();
        }

        private void frmRegistroDeportista_Load(object sender, EventArgs e)
        {
            txtCodigo.Focus();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            /* Llamo a la clase y al procedimiento AGREGAR
            y la informacion con la que se llenen los campos */
            /* Los datos cargados se almacenaran en la variable local
            de la clase y posteriormente lo almacenara */
            clsDeportista Registro = new clsDeportista();
            Registro.CDeportista = txtCodigo.Text;
            Registro.Nombre = txtNombre.Text;
            Registro.Apellido = txtApellido.Text;
            Registro.Direccion = txtDireccion.Text;
            Registro.Telefono = Convert.ToInt32(txtTelefono.Text);
            Registro.Edad = Convert.ToInt32(txtEdad.Text);
            Registro.Deportes = Convert.ToString(lstDeporte.SelectedItem);
            Registro.Agregar();

            Limpiar();
        }

        private void Limpiar()
        {
            txtCodigo.Focus();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEdad.Text = "";
            lstDeporte.SelectedIndex = -1;
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Comprobar()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && txtDireccion.Text != "" && txtDireccion.Text != "" && txtTelefono.Text != "" && txtEdad.Text != "" && lstDeporte.SelectedIndex > -1)
            {
                cmdCargar.Enabled = true;
            }
            else
            {
                cmdCargar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void lstDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comprobar();
        }
    }
}
