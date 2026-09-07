namespace ProgramaVentas
{
    partial class PanelRegistro
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
            this.etiquetaIngresarDatos = new System.Windows.Forms.Label();
            this.seleccionarSexos = new System.Windows.Forms.GroupBox();
            this.botonMasculino = new System.Windows.Forms.RadioButton();
            this.botonFemenino = new System.Windows.Forms.RadioButton();
            this.registrarCuenta = new System.Windows.Forms.Button();
            this.registroNombre = new System.Windows.Forms.TextBox();
            this.registroApellido = new System.Windows.Forms.TextBox();
            this.registroDni = new System.Windows.Forms.TextBox();
            this.registroUsuario = new System.Windows.Forms.TextBox();
            this.nombreEtiqueta = new System.Windows.Forms.Label();
            this.apellidoEtiqueta = new System.Windows.Forms.Label();
            this.dniEtiqueta = new System.Windows.Forms.Label();
            this.usuarioEtiqueta = new System.Windows.Forms.Label();
            this.botonNeutroInvisibleSexo = new System.Windows.Forms.RadioButton();
            this.seleccionarSexos.SuspendLayout();
            this.SuspendLayout();
            // 
            // etiquetaIngresarDatos
            // 
            this.etiquetaIngresarDatos.AutoSize = true;
            this.etiquetaIngresarDatos.Location = new System.Drawing.Point(119, 46);
            this.etiquetaIngresarDatos.Name = "etiquetaIngresarDatos";
            this.etiquetaIngresarDatos.Size = new System.Drawing.Size(90, 13);
            this.etiquetaIngresarDatos.TabIndex = 0;
            this.etiquetaIngresarDatos.Text = "Ingrese sus datos";
            // 
            // seleccionarSexos
            // 
            this.seleccionarSexos.Controls.Add(this.botonNeutroInvisibleSexo);
            this.seleccionarSexos.Controls.Add(this.botonMasculino);
            this.seleccionarSexos.Controls.Add(this.botonFemenino);
            this.seleccionarSexos.Location = new System.Drawing.Point(60, 148);
            this.seleccionarSexos.Name = "seleccionarSexos";
            this.seleccionarSexos.Size = new System.Drawing.Size(210, 44);
            this.seleccionarSexos.TabIndex = 6;
            this.seleccionarSexos.TabStop = false;
            this.seleccionarSexos.Text = "Sexo";
            // 
            // botonMasculino
            // 
            this.botonMasculino.AutoSize = true;
            this.botonMasculino.Location = new System.Drawing.Point(111, 19);
            this.botonMasculino.Name = "botonMasculino";
            this.botonMasculino.Size = new System.Drawing.Size(73, 17);
            this.botonMasculino.TabIndex = 1;
            this.botonMasculino.Text = "Masculino";
            this.botonMasculino.UseVisualStyleBackColor = true;
            // 
            // botonFemenino
            // 
            this.botonFemenino.AutoSize = true;
            this.botonFemenino.Location = new System.Drawing.Point(15, 19);
            this.botonFemenino.Name = "botonFemenino";
            this.botonFemenino.Size = new System.Drawing.Size(71, 17);
            this.botonFemenino.TabIndex = 0;
            this.botonFemenino.Text = "Femenino";
            this.botonFemenino.UseVisualStyleBackColor = true;
            // 
            // registrarCuenta
            // 
            this.registrarCuenta.Location = new System.Drawing.Point(60, 282);
            this.registrarCuenta.Name = "registrarCuenta";
            this.registrarCuenta.Size = new System.Drawing.Size(210, 23);
            this.registrarCuenta.TabIndex = 7;
            this.registrarCuenta.Text = "Registrar cuenta";
            this.registrarCuenta.UseVisualStyleBackColor = true;
            this.registrarCuenta.Click += new System.EventHandler(this.registrarCuenta_Click);
            // 
            // registroNombre
            // 
            this.registroNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.registroNombre.Location = new System.Drawing.Point(60, 78);
            this.registroNombre.Name = "registroNombre";
            this.registroNombre.Size = new System.Drawing.Size(210, 20);
            this.registroNombre.TabIndex = 10;
            this.registroNombre.Text = "Nombre";
            // 
            // registroApellido
            // 
            this.registroApellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.registroApellido.Location = new System.Drawing.Point(60, 115);
            this.registroApellido.Name = "registroApellido";
            this.registroApellido.Size = new System.Drawing.Size(210, 20);
            this.registroApellido.TabIndex = 11;
            this.registroApellido.Text = "Apellido";
            // 
            // registroDni
            // 
            this.registroDni.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.registroDni.Location = new System.Drawing.Point(60, 207);
            this.registroDni.Name = "registroDni";
            this.registroDni.Size = new System.Drawing.Size(210, 20);
            this.registroDni.TabIndex = 12;
            this.registroDni.Text = "DNI";
            // 
            // registroUsuario
            // 
            this.registroUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.registroUsuario.Location = new System.Drawing.Point(60, 243);
            this.registroUsuario.Name = "registroUsuario";
            this.registroUsuario.Size = new System.Drawing.Size(210, 20);
            this.registroUsuario.TabIndex = 13;
            this.registroUsuario.Text = "Usuario";
            // 
            // nombreEtiqueta
            // 
            this.nombreEtiqueta.AutoSize = true;
            this.nombreEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEtiqueta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.nombreEtiqueta.Location = new System.Drawing.Point(68, 68);
            this.nombreEtiqueta.Name = "nombreEtiqueta";
            this.nombreEtiqueta.Size = new System.Drawing.Size(38, 12);
            this.nombreEtiqueta.TabIndex = 14;
            this.nombreEtiqueta.Text = "Nombre";
            // 
            // apellidoEtiqueta
            // 
            this.apellidoEtiqueta.AutoSize = true;
            this.apellidoEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoEtiqueta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.apellidoEtiqueta.Location = new System.Drawing.Point(68, 105);
            this.apellidoEtiqueta.Name = "apellidoEtiqueta";
            this.apellidoEtiqueta.Size = new System.Drawing.Size(38, 12);
            this.apellidoEtiqueta.TabIndex = 15;
            this.apellidoEtiqueta.Text = "Apellido";
            // 
            // dniEtiqueta
            // 
            this.dniEtiqueta.AutoSize = true;
            this.dniEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniEtiqueta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dniEtiqueta.Location = new System.Drawing.Point(68, 197);
            this.dniEtiqueta.Name = "dniEtiqueta";
            this.dniEtiqueta.Size = new System.Drawing.Size(22, 12);
            this.dniEtiqueta.TabIndex = 16;
            this.dniEtiqueta.Text = "DNI";
            // 
            // usuarioEtiqueta
            // 
            this.usuarioEtiqueta.AutoSize = true;
            this.usuarioEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioEtiqueta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.usuarioEtiqueta.Location = new System.Drawing.Point(68, 233);
            this.usuarioEtiqueta.Name = "usuarioEtiqueta";
            this.usuarioEtiqueta.Size = new System.Drawing.Size(37, 12);
            this.usuarioEtiqueta.TabIndex = 17;
            this.usuarioEtiqueta.Text = "Usuario";
            // 
            // botonNeutroInvisibleSexo
            // 
            this.botonNeutroInvisibleSexo.AutoSize = true;
            this.botonNeutroInvisibleSexo.Checked = true;
            this.botonNeutroInvisibleSexo.Location = new System.Drawing.Point(190, 21);
            this.botonNeutroInvisibleSexo.Name = "botonNeutroInvisibleSexo";
            this.botonNeutroInvisibleSexo.Size = new System.Drawing.Size(14, 13);
            this.botonNeutroInvisibleSexo.TabIndex = 2;
            this.botonNeutroInvisibleSexo.TabStop = true;
            this.botonNeutroInvisibleSexo.UseVisualStyleBackColor = true;
            this.botonNeutroInvisibleSexo.Visible = false;
            // 
            // PanelRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 380);
            this.Controls.Add(this.usuarioEtiqueta);
            this.Controls.Add(this.dniEtiqueta);
            this.Controls.Add(this.apellidoEtiqueta);
            this.Controls.Add(this.nombreEtiqueta);
            this.Controls.Add(this.registroUsuario);
            this.Controls.Add(this.registroDni);
            this.Controls.Add(this.registroApellido);
            this.Controls.Add(this.registroNombre);
            this.Controls.Add(this.registrarCuenta);
            this.Controls.Add(this.seleccionarSexos);
            this.Controls.Add(this.etiquetaIngresarDatos);
            this.Name = "PanelRegistro";
            this.Text = "Panel de registro";
            this.Load += new System.EventHandler(this.PanelRegistro_Load);
            this.seleccionarSexos.ResumeLayout(false);
            this.seleccionarSexos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etiquetaIngresarDatos;
        private System.Windows.Forms.GroupBox seleccionarSexos;
        private System.Windows.Forms.Button registrarCuenta;
        private System.Windows.Forms.TextBox registroNombre;
        private System.Windows.Forms.TextBox registroApellido;
        private System.Windows.Forms.TextBox registroDni;
        private System.Windows.Forms.TextBox registroUsuario;
        private System.Windows.Forms.RadioButton botonMasculino;
        private System.Windows.Forms.RadioButton botonFemenino;
        private System.Windows.Forms.Label nombreEtiqueta;
        private System.Windows.Forms.Label apellidoEtiqueta;
        private System.Windows.Forms.Label dniEtiqueta;
        private System.Windows.Forms.Label usuarioEtiqueta;
        private System.Windows.Forms.RadioButton botonNeutroInvisibleSexo;
    }
}