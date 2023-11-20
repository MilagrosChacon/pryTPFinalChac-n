namespace pryTPFinalChacón
{
    partial class FormInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStripFechaHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripInicio = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaPreviaDeImpresiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorDeTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStripInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripFechaHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 285);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(536, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStripFechaHora
            // 
            this.statusStripFechaHora.BackColor = System.Drawing.Color.Transparent;
            this.statusStripFechaHora.Name = "statusStripFechaHora";
            this.statusStripFechaHora.Size = new System.Drawing.Size(76, 17);
            this.statusStripFechaHora.Text = "Fecha y Hora";
            this.statusStripFechaHora.Click += new System.EventHandler(this.statusStripFechaHora_Click);
            // 
            // menuStripInicio
            // 
            this.menuStripInicio.BackColor = System.Drawing.Color.Transparent;
            this.menuStripInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.listadosToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStripInicio.Location = new System.Drawing.Point(0, 0);
            this.menuStripInicio.Name = "menuStripInicio";
            this.menuStripInicio.Size = new System.Drawing.Size(536, 24);
            this.menuStripInicio.TabIndex = 1;
            this.menuStripInicio.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeEmpleadosToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.vistaPreviaDeImpresiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeEmpleadosToolStripMenuItem});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorDeTextoToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // registroDeEmpleadosToolStripMenuItem
            // 
            this.registroDeEmpleadosToolStripMenuItem.Image = global::pryTPFinalChacón.Properties.Resources.page;
            this.registroDeEmpleadosToolStripMenuItem.Name = "registroDeEmpleadosToolStripMenuItem";
            this.registroDeEmpleadosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.registroDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.registroDeEmpleadosToolStripMenuItem.Text = "Registro de empleados";
            this.registroDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.registroDeEmpleadosToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = global::pryTPFinalChacón.Properties.Resources.folder;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Image = global::pryTPFinalChacón.Properties.Resources.printer;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // vistaPreviaDeImpresiónToolStripMenuItem
            // 
            this.vistaPreviaDeImpresiónToolStripMenuItem.Image = global::pryTPFinalChacón.Properties.Resources.preview;
            this.vistaPreviaDeImpresiónToolStripMenuItem.Name = "vistaPreviaDeImpresiónToolStripMenuItem";
            this.vistaPreviaDeImpresiónToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.vistaPreviaDeImpresiónToolStripMenuItem.Text = "Vista previa de impresión";
            // 
            // listadoDeEmpleadosToolStripMenuItem
            // 
            this.listadoDeEmpleadosToolStripMenuItem.Image = global::pryTPFinalChacón.Properties.Resources.page;
            this.listadoDeEmpleadosToolStripMenuItem.Name = "listadoDeEmpleadosToolStripMenuItem";
            this.listadoDeEmpleadosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.listadoDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.listadoDeEmpleadosToolStripMenuItem.Text = "Listado de empleados";
            this.listadoDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeEmpleadosToolStripMenuItem_Click);
            // 
            // editorDeTextoToolStripMenuItem
            // 
            this.editorDeTextoToolStripMenuItem.Image = global::pryTPFinalChacón.Properties.Resources.page;
            this.editorDeTextoToolStripMenuItem.Name = "editorDeTextoToolStripMenuItem";
            this.editorDeTextoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editorDeTextoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.editorDeTextoToolStripMenuItem.Text = "Editor de texto";
            this.editorDeTextoToolStripMenuItem.Click += new System.EventHandler(this.editorDeTextoToolStripMenuItem_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(536, 307);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripInicio;
            this.MaximizeBox = false;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión - Módulo Recursos Humanos";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStripInicio.ResumeLayout(false);
            this.menuStripInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripFechaHora;
        private System.Windows.Forms.MenuStrip menuStripInicio;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vistaPreviaDeImpresiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorDeTextoToolStripMenuItem;
    }
}

