namespace pryTPFinalChacón
{
    partial class FormRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tabControlDatos = new System.Windows.Forms.TabControl();
            this.tabPageDireccion = new System.Windows.Forms.TabPage();
            this.tabPageContactos = new System.Windows.Forms.TabPage();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pctRegistro = new System.Windows.Forms.PictureBox();
            this.pctVolver = new System.Windows.Forms.PictureBox();
            this.gbDatos.SuspendLayout();
            this.tabControlDatos.SuspendLayout();
            this.tabPageDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.pctRegistro);
            this.gbDatos.Controls.Add(this.txtApellido);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.lblApellido);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Location = new System.Drawing.Point(24, 59);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(537, 156);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(76, 80);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(285, 22);
            this.txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(285, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(6, 80);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // tabControlDatos
            // 
            this.tabControlDatos.Controls.Add(this.tabPageDireccion);
            this.tabControlDatos.Controls.Add(this.tabPageContactos);
            this.tabControlDatos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlDatos.Location = new System.Drawing.Point(24, 221);
            this.tabControlDatos.Name = "tabControlDatos";
            this.tabControlDatos.SelectedIndex = 0;
            this.tabControlDatos.Size = new System.Drawing.Size(537, 161);
            this.tabControlDatos.TabIndex = 1;
            // 
            // tabPageDireccion
            // 
            this.tabPageDireccion.Controls.Add(this.txtNumero);
            this.tabPageDireccion.Controls.Add(this.lblNumero);
            this.tabPageDireccion.Controls.Add(this.txtCalle);
            this.tabPageDireccion.Controls.Add(this.lblCiudad);
            this.tabPageDireccion.Controls.Add(this.txtCiudad);
            this.tabPageDireccion.Controls.Add(this.lblCalle);
            this.tabPageDireccion.Location = new System.Drawing.Point(4, 26);
            this.tabPageDireccion.Name = "tabPageDireccion";
            this.tabPageDireccion.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageDireccion.Size = new System.Drawing.Size(529, 131);
            this.tabPageDireccion.TabIndex = 0;
            this.tabPageDireccion.Text = "Dirección";
            this.tabPageDireccion.UseVisualStyleBackColor = true;
            // 
            // tabPageContactos
            // 
            this.tabPageContactos.Location = new System.Drawing.Point(4, 26);
            this.tabPageContactos.Name = "tabPageContactos";
            this.tabPageContactos.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageContactos.Size = new System.Drawing.Size(529, 171);
            this.tabPageContactos.TabIndex = 1;
            this.tabPageContactos.Text = "Contactos";
            this.tabPageContactos.UseVisualStyleBackColor = true;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(83, 52);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(285, 25);
            this.txtCalle.TabIndex = 12;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(83, 21);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(285, 25);
            this.txtCiudad.TabIndex = 10;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(13, 57);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(42, 20);
            this.lblCalle.TabIndex = 9;
            this.lblCalle.Text = "Calle";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(13, 26);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(56, 20);
            this.lblCiudad.TabIndex = 7;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(83, 83);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(140, 25);
            this.txtNumero.TabIndex = 14;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(13, 88);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(63, 20);
            this.lblNumero.TabIndex = 13;
            this.lblNumero.Text = "Número";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(401, 388);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 28);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(482, 388);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 28);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pctRegistro
            // 
            this.pctRegistro.Location = new System.Drawing.Point(383, 16);
            this.pctRegistro.Name = "pctRegistro";
            this.pctRegistro.Size = new System.Drawing.Size(140, 119);
            this.pctRegistro.TabIndex = 6;
            this.pctRegistro.TabStop = false;
            // 
            // pctVolver
            // 
            this.pctVolver.Image = global::pryTPFinalChacón.Properties.Resources.volver;
            this.pctVolver.Location = new System.Drawing.Point(24, 12);
            this.pctVolver.Name = "pctVolver";
            this.pctVolver.Size = new System.Drawing.Size(47, 38);
            this.pctVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctVolver.TabIndex = 4;
            this.pctVolver.TabStop = false;
            this.pctVolver.Click += new System.EventHandler(this.pctVolver_Click);
            // 
            // FormRegistro
            // 
            this.AcceptButton = this.btnRegistrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(582, 432);
            this.Controls.Add(this.pctVolver);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tabControlDatos);
            this.Controls.Add(this.gbDatos);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Empleados";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.tabControlDatos.ResumeLayout(false);
            this.tabPageDireccion.ResumeLayout(false);
            this.tabPageDireccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVolver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pctRegistro;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TabControl tabControlDatos;
        private System.Windows.Forms.TabPage tabPageDireccion;
        private System.Windows.Forms.TabPage tabPageContactos;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox pctVolver;
    }
}