using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryTPFinalChacón
{
    public partial class FormInicio : Form
    {
        private void FormInicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        public FormInicio()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(FormInicio_KeyDown);
        }

        private void registroDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form registro = new FormRegistro();
            registro.Show();
        }

        private void listadoDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form listado = new FormListado();
            listado.Show();
        }

        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form editor = new FormEditor();
            editor.Show();
        }

        private void statusStripFechaHora_Click(object sender, EventArgs e)
        {
            statusStripFechaHora.Text = Convert.ToString(DateTime.Now);
        }
    }
}
