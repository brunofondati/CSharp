namespace TP1_GRUPO_20
{
    partial class Ejercicio3
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
            this.gBoxSexo = new System.Windows.Forms.GroupBox();
            this.radBtnMasc = new System.Windows.Forms.RadioButton();
            this.radBtnFem = new System.Windows.Forms.RadioButton();
            this.gBoxEsCivil = new System.Windows.Forms.GroupBox();
            this.radBtnSoltero = new System.Windows.Forms.RadioButton();
            this.radBtnCasado = new System.Windows.Forms.RadioButton();
            this.checkLstBox = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCont = new System.Windows.Forms.Label();
            this.gBoxSexo.SuspendLayout();
            this.gBoxEsCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxSexo
            // 
            this.gBoxSexo.Controls.Add(this.radBtnMasc);
            this.gBoxSexo.Controls.Add(this.radBtnFem);
            this.gBoxSexo.Location = new System.Drawing.Point(25, 35);
            this.gBoxSexo.Name = "gBoxSexo";
            this.gBoxSexo.Size = new System.Drawing.Size(143, 100);
            this.gBoxSexo.TabIndex = 0;
            this.gBoxSexo.TabStop = false;
            this.gBoxSexo.Text = "Sexo";
            // 
            // radBtnMasc
            // 
            this.radBtnMasc.AutoSize = true;
            this.radBtnMasc.Location = new System.Drawing.Point(26, 52);
            this.radBtnMasc.Name = "radBtnMasc";
            this.radBtnMasc.Size = new System.Drawing.Size(73, 17);
            this.radBtnMasc.TabIndex = 1;
            this.radBtnMasc.Text = "Masculino";
            this.radBtnMasc.UseVisualStyleBackColor = true;
            // 
            // radBtnFem
            // 
            this.radBtnFem.AutoSize = true;
            this.radBtnFem.Checked = true;
            this.radBtnFem.Location = new System.Drawing.Point(26, 29);
            this.radBtnFem.Name = "radBtnFem";
            this.radBtnFem.Size = new System.Drawing.Size(71, 17);
            this.radBtnFem.TabIndex = 0;
            this.radBtnFem.TabStop = true;
            this.radBtnFem.Text = "Femenino";
            this.radBtnFem.UseVisualStyleBackColor = true;
            // 
            // gBoxEsCivil
            // 
            this.gBoxEsCivil.Controls.Add(this.radBtnSoltero);
            this.gBoxEsCivil.Controls.Add(this.radBtnCasado);
            this.gBoxEsCivil.Location = new System.Drawing.Point(236, 35);
            this.gBoxEsCivil.Name = "gBoxEsCivil";
            this.gBoxEsCivil.Size = new System.Drawing.Size(143, 100);
            this.gBoxEsCivil.TabIndex = 1;
            this.gBoxEsCivil.TabStop = false;
            this.gBoxEsCivil.Text = "Estado Civil";
            // 
            // radBtnSoltero
            // 
            this.radBtnSoltero.AutoSize = true;
            this.radBtnSoltero.Location = new System.Drawing.Point(29, 52);
            this.radBtnSoltero.Name = "radBtnSoltero";
            this.radBtnSoltero.Size = new System.Drawing.Size(58, 17);
            this.radBtnSoltero.TabIndex = 3;
            this.radBtnSoltero.Text = "Soltero";
            this.radBtnSoltero.UseVisualStyleBackColor = true;
            // 
            // radBtnCasado
            // 
            this.radBtnCasado.AutoSize = true;
            this.radBtnCasado.Checked = true;
            this.radBtnCasado.Location = new System.Drawing.Point(29, 29);
            this.radBtnCasado.Name = "radBtnCasado";
            this.radBtnCasado.Size = new System.Drawing.Size(61, 17);
            this.radBtnCasado.TabIndex = 2;
            this.radBtnCasado.TabStop = true;
            this.radBtnCasado.Text = "Casado";
            this.radBtnCasado.UseVisualStyleBackColor = true;
            // 
            // checkLstBox
            // 
            this.checkLstBox.CheckOnClick = true;
            this.checkLstBox.FormattingEnabled = true;
            this.checkLstBox.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.checkLstBox.Location = new System.Drawing.Point(129, 150);
            this.checkLstBox.Name = "checkLstBox";
            this.checkLstBox.Size = new System.Drawing.Size(152, 79);
            this.checkLstBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(125, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mostrar lo que seleccionó";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCont.Location = new System.Drawing.Point(122, 294);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(63, 13);
            this.lblCont.TabIndex = 4;
            this.lblCont.Text = "contenido";
            this.lblCont.Visible = false;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 453);
            this.Controls.Add(this.lblCont);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkLstBox);
            this.Controls.Add(this.gBoxEsCivil);
            this.Controls.Add(this.gBoxSexo);
            this.Name = "Ejercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ejercicio3_FormClosed);
            this.gBoxSexo.ResumeLayout(false);
            this.gBoxSexo.PerformLayout();
            this.gBoxEsCivil.ResumeLayout(false);
            this.gBoxEsCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxSexo;
        private System.Windows.Forms.RadioButton radBtnMasc;
        private System.Windows.Forms.RadioButton radBtnFem;
        private System.Windows.Forms.GroupBox gBoxEsCivil;
        private System.Windows.Forms.RadioButton radBtnSoltero;
        private System.Windows.Forms.RadioButton radBtnCasado;
        private System.Windows.Forms.CheckedListBox checkLstBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCont;
    }
}