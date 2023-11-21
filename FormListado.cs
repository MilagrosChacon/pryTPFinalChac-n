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
        private string cadenaConexion;
        private OleDbDataAdapter adaptador;
        private DataTable tablaEmpleados;

        private void FormListado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        public FormListado()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(FormListado_KeyDown);

            cadenaConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\EMPLEADO.accdb";
            ConfigurarDataGridView();
            CargarEmpleados();
        }

        private void ConfigurarDataGridView()
        {
            // Configuración del DataGridView
            dataGridViewListado.AutoGenerateColumns = true;
            dataGridViewListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CargarEmpleados()
        {
            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    adaptador = new OleDbDataAdapter("SELECT * FROM Empleados", conexion);
                    tablaEmpleados = new DataTable();
                    adaptador.Fill(tablaEmpleados);
                    dataGridViewListado.DataSource = tablaEmpleados;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string filtroApellido = txtApellido.Text.Trim();
            string filtroDireccion = txtDireccion.Text.Trim();

            if (!string.IsNullOrEmpty(filtroApellido))
            {
                DataView dv = tablaEmpleados.DefaultView;
                dv.RowFilter = $"Apellido LIKE '%{filtroApellido}%'";
            }
            else
            {
                // Si el filtro está vacío, mostrar todos los empleados
                tablaEmpleados.DefaultView.RowFilter = string.Empty;
            }

        }
    }

}
