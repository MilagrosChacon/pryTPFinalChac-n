using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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

        private ClassEmpleados empleados;

        public FormRegistro()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(FormRegistro_KeyDown);

            empleados = new ClassEmpleados(@"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\EMPLEADO.accdb");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string ciudad = txtCiudad.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(ciudad) || string.IsNullOrWhiteSpace(direccion)||
                string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Todos los campos deben ser completados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            empleados.RegistrarEmpleado(nombre, apellido, ciudad, direccion);
            string mensaje = $"¡Registro exitoso!\nNombre: {nombre}\nApellido: {apellido}\nCiudad: {ciudad}\nDirección: {direccion}\nTeléfono: {telefono}";
            MessageBox.Show(mensaje, "¡Registro Exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCiudad.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtNombre.Focus();

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
