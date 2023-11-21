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
    public partial class FormEditor : Form
    {
        private void FormEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        public FormEditor()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(FormEditor_KeyDown);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscar = txtBuscar.Text;
            if (string.IsNullOrWhiteSpace(buscar))
            {
                MessageBox.Show("¡Registro Exitoso!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string modificar = txtModificar.Text;
            if (string.IsNullOrWhiteSpace(modificar))
            {
                MessageBox.Show("¡Modificación exitosa!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void pctVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form inicio = new FormInicio();
            inicio.Show();
        }
    }
}
