namespace pryTPFinalChacón
{
    partial class FormListado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListado));
            this.tabControlDatos = new System.Windows.Forms.TabControl();
            this.tabPageApellido = new System.Windows.Forms.TabPage();
            this.tabPageDireccion = new System.Windows.Forms.TabPage();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.dataGridViewListado = new System.Windows.Forms.DataGridView();
            this.pctVolver = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tabControlDatos.SuspendLayout();
            this.tabPageApellido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlDatos
            // 
            this.tabControlDatos.Controls.Add(this.tabPageApellido);
            this.tabControlDatos.Controls.Add(this.tabPageDireccion);
            this.tabControlDatos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlDatos.Location = new System.Drawing.Point(11, 58);
            this.tabControlDatos.Name = "tabControlDatos";
            this.tabControlDatos.SelectedIndex = 0;
            this.tabControlDatos.Size = new System.Drawing.Size(538, 159);
            this.tabControlDatos.TabIndex = 0;
            // 
            // tabPageApellido
            // 
            this.tabPageApellido.Controls.Add(this.txtApellido);
            this.tabPageApellido.Controls.Add(this.lblApellido);
            this.tabPageApellido.Location = new System.Drawing.Point(4, 26);
            this.tabPageApellido.Name = "tabPageApellido";
            this.tabPageApellido.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApellido.Size = new System.Drawing.Size(530, 129);
            this.tabPageApellido.TabIndex = 0;
            this.tabPageApellido.Text = "Apellido";
            this.tabPageApellido.UseVisualStyleBackColor = true;
            // 
            // tabPageDireccion
            // 
            this.tabPageDireccion.Location = new System.Drawing.Point(4, 24);
            this.tabPageDireccion.Name = "tabPageDireccion";
            this.tabPageDireccion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDireccion.Size = new System.Drawing.Size(530, 131);
            this.tabPageDireccion.TabIndex = 1;
            this.tabPageDireccion.Text = "Dirección";
            this.tabPageDireccion.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(154, 54);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(285, 25);
            this.txtApellido.TabIndex = 7;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(84, 54);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(470, 223);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 28);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dataGridViewListado
            // 
            this.dataGridViewListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListado.Location = new System.Drawing.Point(15, 266);
            this.dataGridViewListado.Name = "dataGridViewListado";
            this.dataGridViewListado.Size = new System.Drawing.Size(530, 179);
            this.dataGridViewListado.TabIndex = 5;
            // 
            // pctVolver
            // 
            this.pctVolver.Image = global::pryTPFinalChacón.Properties.Resources.volver;
            this.pctVolver.Location = new System.Drawing.Point(11, 12);
            this.pctVolver.Name = "pctVolver";
            this.pctVolver.Size = new System.Drawing.Size(47, 38);
            this.pctVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctVolver.TabIndex = 6;
            this.pctVolver.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(470, 451);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 28);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // FormListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(557, 491);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pctVolver);
            this.Controls.Add(this.dataGridViewListado);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.tabControlDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Empleados";
            this.tabControlDatos.ResumeLayout(false);
            this.tabPageApellido.ResumeLayout(false);
            this.tabPageApellido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVolver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDatos;
        private System.Windows.Forms.TabPage tabPageApellido;
        private System.Windows.Forms.TabPage tabPageDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dataGridViewListado;
        private System.Windows.Forms.PictureBox pctVolver;
        private System.Windows.Forms.Button btnVolver;
    }
}