namespace TP1_GRUPO_20
{
    partial class Ejercicio1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstBoxIzquierda = new System.Windows.Forms.ListBox();
            this.lstBoxDerecha = new System.Windows.Forms.ListBox();
            this.btnSimple = new System.Windows.Forms.Button();
            this.btnDoble = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(52, 89);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(151, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Ingrese un Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNombre.Location = new System.Drawing.Point(209, 93);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(155, 13);
            this.txtBoxNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(370, 86);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 26);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstBoxIzquierda
            // 
            this.lstBoxIzquierda.FormattingEnabled = true;
            this.lstBoxIzquierda.Location = new System.Drawing.Point(46, 153);
            this.lstBoxIzquierda.Name = "lstBoxIzquierda";
            this.lstBoxIzquierda.Size = new System.Drawing.Size(171, 160);
            this.lstBoxIzquierda.TabIndex = 3;
            // 
            // lstBoxDerecha
            // 
            this.lstBoxDerecha.FormattingEnabled = true;
            this.lstBoxDerecha.Location = new System.Drawing.Point(301, 153);
            this.lstBoxDerecha.Name = "lstBoxDerecha";
            this.lstBoxDerecha.Size = new System.Drawing.Size(171, 160);
            this.lstBoxDerecha.TabIndex = 4;
            // 
            // btnSimple
            // 
            this.btnSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimple.Location = new System.Drawing.Point(223, 181);
            this.btnSimple.Name = "btnSimple";
            this.btnSimple.Size = new System.Drawing.Size(75, 23);
            this.btnSimple.TabIndex = 5;
            this.btnSimple.Text = ">";
            this.btnSimple.UseVisualStyleBackColor = true;
            this.btnSimple.Click += new System.EventHandler(this.btnSimple_Click);
            // 
            // btnDoble
            // 
            this.btnDoble.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoble.Location = new System.Drawing.Point(223, 231);
            this.btnDoble.Name = "btnDoble";
            this.btnDoble.Size = new System.Drawing.Size(75, 23);
            this.btnDoble.TabIndex = 6;
            this.btnDoble.Text = ">>";
            this.btnDoble.UseVisualStyleBackColor = true;
            this.btnDoble.Click += new System.EventHandler(this.btnDoble_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 376);
            this.Controls.Add(this.btnDoble);
            this.Controls.Add(this.btnSimple);
            this.Controls.Add(this.lstBoxDerecha);
            this.Controls.Add(this.lstBoxIzquierda);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Ejercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombres";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ejercicio1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstBoxIzquierda;
        private System.Windows.Forms.ListBox lstBoxDerecha;
        private System.Windows.Forms.Button btnSimple;
        private System.Windows.Forms.Button btnDoble;
    }
}