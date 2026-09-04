namespace ProgramaVentas
{
    partial class Inicio
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
            this.ubicacionFormularioHijoInicio = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.botonInicioSesion = new System.Windows.Forms.RadioButton();
            this.botonRegistro = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ubicacionFormularioHijoInicio
            // 
            this.ubicacionFormularioHijoInicio.BackColor = System.Drawing.SystemColors.Control;
            this.ubicacionFormularioHijoInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ubicacionFormularioHijoInicio.Location = new System.Drawing.Point(3, 44);
            this.ubicacionFormularioHijoInicio.Name = "ubicacionFormularioHijoInicio";
            this.ubicacionFormularioHijoInicio.Size = new System.Drawing.Size(330, 380);
            this.ubicacionFormularioHijoInicio.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.26021F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.73979F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(661, 433);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.ubicacionFormularioHijoInicio, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(322, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.601873F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.39812F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(336, 427);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.botonInicioSesion, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.botonRegistro, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(330, 35);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // botonInicioSesion
            // 
            this.botonInicioSesion.Appearance = System.Windows.Forms.Appearance.Button;
            this.botonInicioSesion.AutoSize = true;
            this.botonInicioSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonInicioSesion.Location = new System.Drawing.Point(3, 3);
            this.botonInicioSesion.Name = "botonInicioSesion";
            this.botonInicioSesion.Size = new System.Drawing.Size(159, 29);
            this.botonInicioSesion.TabIndex = 0;
            this.botonInicioSesion.TabStop = true;
            this.botonInicioSesion.Text = "Iniciar Sesion";
            this.botonInicioSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.botonInicioSesion.UseVisualStyleBackColor = true;
            this.botonInicioSesion.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // botonRegistro
            // 
            this.botonRegistro.Appearance = System.Windows.Forms.Appearance.Button;
            this.botonRegistro.AutoSize = true;
            this.botonRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonRegistro.Location = new System.Drawing.Point(168, 3);
            this.botonRegistro.Name = "botonRegistro";
            this.botonRegistro.Size = new System.Drawing.Size(159, 29);
            this.botonRegistro.TabIndex = 1;
            this.botonRegistro.TabStop = true;
            this.botonRegistro.Text = "Registrarse";
            this.botonRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.botonRegistro.UseVisualStyleBackColor = true;
            this.botonRegistro.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 433);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Inicio";
            this.Text = "Mi Bodega";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel ubicacionFormularioHijoInicio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton botonInicioSesion;
        private System.Windows.Forms.RadioButton botonRegistro;
    }
}

