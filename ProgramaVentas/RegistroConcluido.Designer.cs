namespace ProgramaVentas
{
    partial class RegistroConcluido
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
            this.volverInicioSesion = new System.Windows.Forms.Button();
            this.etiquetaCuentaRegistrada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // volverInicioSesion
            // 
            this.volverInicioSesion.Location = new System.Drawing.Point(166, 35);
            this.volverInicioSesion.Name = "volverInicioSesion";
            this.volverInicioSesion.Size = new System.Drawing.Size(77, 23);
            this.volverInicioSesion.TabIndex = 0;
            this.volverInicioSesion.Text = "Continuar";
            this.volverInicioSesion.UseVisualStyleBackColor = true;
            this.volverInicioSesion.Click += new System.EventHandler(this.volverInicioSesion_Click);
            // 
            // etiquetaCuentaRegistrada
            // 
            this.etiquetaCuentaRegistrada.AutoSize = true;
            this.etiquetaCuentaRegistrada.Location = new System.Drawing.Point(69, 9);
            this.etiquetaCuentaRegistrada.Name = "etiquetaCuentaRegistrada";
            this.etiquetaCuentaRegistrada.Size = new System.Drawing.Size(90, 13);
            this.etiquetaCuentaRegistrada.TabIndex = 1;
            this.etiquetaCuentaRegistrada.Text = "Cuenta registrada";
            // 
            // RegistroConcluido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 68);
            this.Controls.Add(this.etiquetaCuentaRegistrada);
            this.Controls.Add(this.volverInicioSesion);
            this.Name = "RegistroConcluido";
            this.Text = "Registro Concluido";
            this.Load += new System.EventHandler(this.RegistroConcluido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button volverInicioSesion;
        private System.Windows.Forms.Label etiquetaCuentaRegistrada;
    }
}