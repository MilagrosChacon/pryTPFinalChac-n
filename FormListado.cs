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
    public partial class FormListado : Form
    {
        private void FormListado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private ClassEmpleados empleados;

        public FormListado()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(FormListado_KeyDown);

            empleados = new ClassEmpleados(@"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\EMPLEADO.accdb");

            dataGridViewListado.AutoGenerateColumns = true;
            dataGridViewListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            CargarDatos();
        }

        private void CargarDatos()
        {
            DataTable tablaEmpleados = empleados.ObtenerEmpleados();
            dataGridViewListado.DataSource = empleados;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string apellido = txtApellido.Text;
            string direccion = txtApellido.Text;

            DataTable empleadosFiltrados;

            if (!string.IsNullOrWhiteSpace(apellido))
            {
                empleadosFiltrados = empleados.FiltrarPorApellido(apellido);
            }
            else if (!string.IsNullOrWhiteSpace(direccion))
            {
                empleadosFiltrados = empleados.FiltrarPorDireccion(direccion);
            }
            else
            {
                CargarDatos();
                return;
            }

            dataGridViewListado.DataSource = empleadosFiltrados;
        }

        private void pctVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form inicio = new FormInicio();
            inicio.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form inicio = new FormInicio();
            inicio.Show();
        }
    }
}
