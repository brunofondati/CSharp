namespace TP1_GRUPO_20
{
    partial class Ejercicio2
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
            this.gBoxIngDatos = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gBoxElementos = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lbElementos = new System.Windows.Forms.ListBox();
            this.gBoxIngDatos.SuspendLayout();
            this.gBoxElementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxIngDatos
            // 
            this.gBoxIngDatos.Controls.Add(this.btnAgregar);
            this.gBoxIngDatos.Controls.Add(this.txtBoxApellido);
            this.gBoxIngDatos.Controls.Add(this.txtBoxNombre);
            this.gBoxIngDatos.Controls.Add(this.label1);
            this.gBoxIngDatos.Controls.Add(this.lblNombre);
            this.gBoxIngDatos.Location = new System.Drawing.Point(29, 30);
            this.gBoxIngDatos.Name = "gBoxIngDatos";
            this.gBoxIngDatos.Size = new System.Drawing.Size(200, 324);
            this.gBoxIngDatos.TabIndex = 3;
            this.gBoxIngDatos.TabStop = false;
            this.gBoxIngDatos.Text = "Ingreso de Datos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(57, 225);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 34);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(86, 166);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.txtBoxApellido.TabIndex = 3;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(86, 131);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 131);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // gBoxElementos
            // 
            this.gBoxElementos.Controls.Add(this.btnBorrar);
            this.gBoxElementos.Controls.Add(this.lbElementos);
            this.gBoxElementos.Location = new System.Drawing.Point(259, 30);
            this.gBoxElementos.Name = "gBoxElementos";
            this.gBoxElementos.Size = new System.Drawing.Size(221, 324);
            this.gBoxElementos.TabIndex = 0;
            this.gBoxElementos.TabStop = false;
            this.gBoxElementos.Text = "Elementos";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(70, 272);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(85, 34);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lbElementos
            // 
            this.lbElementos.FormattingEnabled = true;
            this.lbElementos.Location = new System.Drawing.Point(20, 29);
            this.lbElementos.Name = "lbElementos";
            this.lbElementos.Size = new System.Drawing.Size(182, 225);
            this.lbElementos.Sorted = true;
            this.lbElementos.TabIndex = 0;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 377);
            this.Controls.Add(this.gBoxElementos);
            this.Controls.Add(this.gBoxIngDatos);
            this.Name = "Ejercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombre y apellido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ejercicio2_FormClosed);
            this.Load += new System.EventHandler(this.Ejercicio2_Load);
            this.gBoxIngDatos.ResumeLayout(false);
            this.gBoxIngDatos.PerformLayout();
            this.gBoxElementos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gBoxIngDatos;
        private System.Windows.Forms.GroupBox gBoxElementos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ListBox lbElementos;
    }
}