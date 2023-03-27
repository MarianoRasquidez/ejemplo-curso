using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraAplicacion
{
    public partial class frmVentana1 : Form
    {
        public frmVentana1()
        {
            InitializeComponent();
        }
        bool colorFondo = true;

        private void frmVentana1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void frmVentana1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau, chau...");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparó el evento Click", "Atención");
            //this.BackColor = Color.Blue;
            //if (colorFondo)
            //{
            //    this.BackColor = Color.Blue;
            //    colorFondo = false;

            //}
            //else
            //{
            //    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            //    colorFondo = true;
            //}
            if (txtTexto1.Text == "")
                txtTexto1.BackColor = Color.Red;
            else
                txtTexto1.BackColor = System.Drawing.SystemColors.Control;
        }

        private void frmVentana1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presionó el botón izquierdo", "ATENCION");
            else if(click.Button == MouseButtons.Right)
                MessageBox.Show("Presionó el botón derecho", "ATENCION");
            else
                if(click.Button == MouseButtons.Middle)
                    MessageBox.Show("Presionó el botón del medio", "ATENCION");
        }

        private void lblEtiqueta1_MouseMove(object sender, MouseEventArgs e)
        {
            lblEtiqueta1.BackColor = Color.Cyan;
            lblEtiqueta1.ForeColor = Color.Black;
            lblEtiqueta1.Cursor = Cursors.Hand;
        }

        private void lblEtiqueta1_MouseLeave(object sender, EventArgs e)
        {
            lblEtiqueta1.BackColor = System.Drawing.Color.Transparent;
            lblEtiqueta1.ForeColor = Color.White;
            lblEtiqueta1.Cursor = Cursors.Arrow;
            //lblEtiqueta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void txtTexto1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtTexto2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtTexto2.Text.Length + " caracteres");
        }
    }
}
