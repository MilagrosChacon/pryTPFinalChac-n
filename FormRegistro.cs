using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTPFinalChacón
{
    public partial class FormRegistro : Form
    {
        private void FormRegistro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        public FormRegistro()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(FormRegistro_KeyDown);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string ciudad = txtCiudad.Text;
            string calle = txtCalle.Text;
            string numero = txtNumero.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(ciudad) || string.IsNullOrWhiteSpace(calle) ||
                string.IsNullOrWhiteSpace(numero))
            {
                MessageBox.Show("Todos los campos deben ser completados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mensaje = $"¡Registro exitoso!\nNombre: {nombre}\nApellido: {apellido}\nCiudad: {ciudad}\nCalle: {calle}\nNúmero: {numero}";
            MessageBox.Show(mensaje, "¡Registro Exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form inicio = new FormInicio();
            inicio.Show();
        }

        private void pctVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form inicio = new FormInicio();
            inicio.Show();
        }
    }
}
