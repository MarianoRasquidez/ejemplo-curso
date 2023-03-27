using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica5
{
    public partial class frmVentana1 : Form
    {
        public frmVentana1()
        {
            InitializeComponent();
        }
        bool bApellido, bNombre, bEdad, bDireccion;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        string resultado;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.Red;
                bApellido = false;
            }
            else
            {
                txtApellido.BackColor = Color.White;
                bApellido = true;
            }
            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
                bNombre = false;
            }
            else
            {
                txtNombre.BackColor = Color.White;
                bNombre = true;
            }
            if (txtEdad.Text == "")
            {
                txtEdad.BackColor = Color.Red;
                bEdad = false;
            }
            else
            {
                txtEdad.BackColor = Color.White;
                bEdad = true;
            }
            if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.Red;
                bDireccion = false;
            }
            else
            {
                txtDireccion.BackColor = Color.White;
                bDireccion = true;
            }
            if (bApellido && bNombre && bEdad && bDireccion)
            {
                resultado = "Apellido y nombre: " + txtApellido.Text + ", " + txtNombre.Text + System.Environment.NewLine;
                resultado += "Edad:" + txtEdad.Text + " años" + System.Environment.NewLine;
                resultado += "Dirección: " + txtDireccion.Text;
                txtResultado.Text = resultado;
            }
            else
                txtResultado.Text = "";

        }
    }
}
