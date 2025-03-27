namespace TP1_GRUPO_20
{
    partial class FormPrincipal
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
            this.btnEj1 = new System.Windows.Forms.Button();
            this.btnEj2 = new System.Windows.Forms.Button();
            this.btnEj3 = new System.Windows.Forms.Button();
            this.lblIntegrantes = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEj1
            // 
            this.btnEj1.Location = new System.Drawing.Point(77, 92);
            this.btnEj1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEj1.Name = "btnEj1";
            this.btnEj1.Size = new System.Drawing.Size(129, 50);
            this.btnEj1.TabIndex = 0;
            this.btnEj1.Text = "EJERCICIO 1";
            this.btnEj1.UseVisualStyleBackColor = true;
            this.btnEj1.Click += new System.EventHandler(this.btnEj1_Click);
            // 
            // btnEj2
            // 
            this.btnEj2.Location = new System.Drawing.Point(281, 92);
            this.btnEj2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEj2.Name = "btnEj2";
            this.btnEj2.Size = new System.Drawing.Size(129, 50);
            this.btnEj2.TabIndex = 1;
            this.btnEj2.Text = "EJERCICIO 2";
            this.btnEj2.UseVisualStyleBackColor = true;
            this.btnEj2.Click += new System.EventHandler(this.btnEj2_Click);
            // 
            // btnEj3
            // 
            this.btnEj3.Location = new System.Drawing.Point(493, 92);
            this.btnEj3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEj3.Name = "btnEj3";
            this.btnEj3.Size = new System.Drawing.Size(129, 50);
            this.btnEj3.TabIndex = 2;
            this.btnEj3.Text = "EJERCICIO 3";
            this.btnEj3.UseVisualStyleBackColor = true;
            this.btnEj3.Click += new System.EventHandler(this.btnEj3_Click);
            // 
            // lblIntegrantes
            // 
            this.lblIntegrantes.AutoSize = true;
            this.lblIntegrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegrantes.Location = new System.Drawing.Point(80, 176);
            this.lblIntegrantes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntegrantes.Name = "lblIntegrantes";
            this.lblIntegrantes.Size = new System.Drawing.Size(115, 25);
            this.lblIntegrantes.TabIndex = 3;
            this.lblIntegrantes.Text = "Integrantes:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(164, 231);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(331, 150);
            this.lblNombres.TabIndex = 4;
            this.lblNombres.Text = "Kovinvich Lautaro Flor.\r\nNicolin Jazmín Florencia .\r\nParlangeli Marcos.\r\nFondati " +
    "Velez Bruno Vladimir. \r\nVelazquez Isaias Emmanuel Alberto.\r\nBarrientos Ricardo M" +
    "atias.";
            this.lblNombres.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 465);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblIntegrantes);
            this.Controls.Add(this.btnEj3);
            this.Controls.Add(this.btnEj2);
            this.Controls.Add(this.btnEj1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEj1;
        private System.Windows.Forms.Button btnEj2;
        private System.Windows.Forms.Button btnEj3;
        private System.Windows.Forms.Label lblIntegrantes;
        private System.Windows.Forms.Label lblNombres;
    }
}

