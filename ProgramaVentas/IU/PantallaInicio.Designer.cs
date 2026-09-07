namespace ProgramaVentas
{
    partial class PantallaInicio
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
            this.botonVerificarCredenciales = new System.Windows.Forms.Button();
            this.ingresoUsuario = new System.Windows.Forms.TextBox();
            this.ingresoDNI = new System.Windows.Forms.TextBox();
            this.etiquetaInicioSesion = new System.Windows.Forms.Label();
            this.dniEtiqueta = new System.Windows.Forms.Label();
            this.usuarioEtiqueta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonVerificarCredenciales
            // 
            this.botonVerificarCredenciales.Location = new System.Drawing.Point(63, 212);
            this.botonVerificarCredenciales.Name = "botonVerificarCredenciales";
            this.botonVerificarCredenciales.Size = new System.Drawing.Size(210, 23);
            this.botonVerificarCredenciales.TabIndex = 14;
            this.botonVerificarCredenciales.Text = "Iniciar Sesión";
            this.botonVerificarCredenciales.UseVisualStyleBackColor = true;
            this.botonVerificarCredenciales.Click += new System.EventHandler(this.botonVerificarCredenciales_Click_1);
            // 
            // ingresoUsuario
            // 
            this.ingresoUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ingresoUsuario.Location = new System.Drawing.Point(63, 154);
            this.ingresoUsuario.Name = "ingresoUsuario";
            this.ingresoUsuario.Size = new System.Drawing.Size(210, 20);
            this.ingresoUsuario.TabIndex = 15;
            this.ingresoUsuario.Text = "Usuario";
            // 
            // ingresoDNI
            // 
            this.ingresoDNI.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ingresoDNI.Location = new System.Drawing.Point(63, 186);
            this.ingresoDNI.Name = "ingresoDNI";
            this.ingresoDNI.Size = new System.Drawing.Size(210, 20);
            this.ingresoDNI.TabIndex = 15;
            this.ingresoDNI.Text = "DNI";
            // 
            // etiquetaInicioSesion
            // 
            this.etiquetaInicioSesion.AutoSize = true;
            this.etiquetaInicioSesion.Location = new System.Drawing.Point(147, 114);
            this.etiquetaInicioSesion.Name = "etiquetaInicioSesion";
            this.etiquetaInicioSesion.Size = new System.Drawing.Size(32, 13);
            this.etiquetaInicioSesion.TabIndex = 13;
            this.etiquetaInicioSesion.Text = "Inicio";
            // 
            // dniEtiqueta
            // 
            this.dniEtiqueta.AutoSize = true;
            this.dniEtiqueta.BackColor = System.Drawing.Color.Transparent;
            this.dniEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniEtiqueta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dniEtiqueta.Location = new System.Drawing.Point(72, 176);
            this.dniEtiqueta.Name = "dniEtiqueta";
            this.dniEtiqueta.Size = new System.Drawing.Size(22, 12);
            this.dniEtiqueta.TabIndex = 19;
            this.dniEtiqueta.Text = "DNI";
            // 
            // usuarioEtiqueta
            // 
            this.usuarioEtiqueta.AutoSize = true;
            this.usuarioEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioEtiqueta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.usuarioEtiqueta.Location = new System.Drawing.Point(71, 143);
            this.usuarioEtiqueta.Name = "usuarioEtiqueta";
            this.usuarioEtiqueta.Size = new System.Drawing.Size(37, 12);
            this.usuarioEtiqueta.TabIndex = 20;
            this.usuarioEtiqueta.Text = "Usuario";
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 380);
            this.Controls.Add(this.usuarioEtiqueta);
            this.Controls.Add(this.ingresoUsuario);
            this.Controls.Add(this.dniEtiqueta);
            this.Controls.Add(this.etiquetaInicioSesion);
            this.Controls.Add(this.ingresoDNI);
            this.Controls.Add(this.botonVerificarCredenciales);
            this.Name = "PantallaInicio";
            this.Text = "PantallaInicio";
            this.Load += new System.EventHandler(this.PantallaInicio_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonVerificarCredenciales;
        public System.Windows.Forms.TextBox ingresoUsuario;
        private System.Windows.Forms.TextBox ingresoDNI;
        private System.Windows.Forms.Label etiquetaInicioSesion;
        private System.Windows.Forms.Label dniEtiqueta;
        private System.Windows.Forms.Label usuarioEtiqueta;
    }
}