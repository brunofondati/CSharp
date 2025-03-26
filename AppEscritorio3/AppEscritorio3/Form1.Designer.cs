namespace AppEscritorio3
{
    partial class Form1
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
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.txtBoxNombreApellido = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbPersonas = new System.Windows.Forms.ListBox();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApellido.Location = new System.Drawing.Point(55, 69);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(210, 20);
            this.lblNombreApellido.TabIndex = 0;
            this.lblNombreApellido.Text = "Ingrese nombre y apellido: ";
            this.lblNombreApellido.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxNombreApellido
            // 
            this.txtBoxNombreApellido.Location = new System.Drawing.Point(313, 67);
            this.txtBoxNombreApellido.Name = "txtBoxNombreApellido";
            this.txtBoxNombreApellido.Size = new System.Drawing.Size(319, 22);
            this.txtBoxNombreApellido.TabIndex = 1;
            this.txtBoxNombreApellido.TextChanged += new System.EventHandler(this.txtBoxNombreApellido_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(660, 58);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(74, 31);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbPersonas
            // 
            this.lbPersonas.FormattingEnabled = true;
            this.lbPersonas.ItemHeight = 16;
            this.lbPersonas.Location = new System.Drawing.Point(58, 122);
            this.lbPersonas.Name = "lbPersonas";
            this.lbPersonas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbPersonas.Size = new System.Drawing.Size(637, 84);
            this.lbPersonas.TabIndex = 3;
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.Location = new System.Drawing.Point(593, 225);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(102, 26);
            this.btnSeleccion.TabIndex = 4;
            this.btnSeleccion.Text = "Mostrar";
            this.btnSeleccion.UseVisualStyleBackColor = true;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSeleccion);
            this.Controls.Add(this.lbPersonas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBoxNombreApellido);
            this.Controls.Add(this.lblNombreApellido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreApellido;
        private System.Windows.Forms.TextBox txtBoxNombreApellido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lbPersonas;
        private System.Windows.Forms.Button btnSeleccion;
    }
}

