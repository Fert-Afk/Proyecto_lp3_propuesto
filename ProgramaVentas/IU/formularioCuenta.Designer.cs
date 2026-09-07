namespace ProgramaVentas
{
    partial class formularioCuenta
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.abrirPerfil = new System.Windows.Forms.RadioButton();
            this.abrirEditarPerfil = new System.Windows.Forms.RadioButton();
            this.ubicciónFormularioHijoCuenta = new System.Windows.Forms.Panel();
            this.abrirCerrarSesión = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9248555F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.2659F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9248555F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.750547F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.71773F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.750547F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(865, 457);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.21827F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.78173F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ubicciónFormularioHijoCuenta, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(843, 435);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.abrirPerfil, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.abrirEditarPerfil, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.abrirCerrarSesión, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(97, 101);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // abrirPerfil
            // 
            this.abrirPerfil.Appearance = System.Windows.Forms.Appearance.Button;
            this.abrirPerfil.AutoSize = true;
            this.abrirPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abrirPerfil.Location = new System.Drawing.Point(3, 3);
            this.abrirPerfil.Name = "abrirPerfil";
            this.abrirPerfil.Size = new System.Drawing.Size(91, 27);
            this.abrirPerfil.TabIndex = 0;
            this.abrirPerfil.TabStop = true;
            this.abrirPerfil.Text = "Perfil";
            this.abrirPerfil.UseVisualStyleBackColor = true;
            this.abrirPerfil.CheckedChanged += new System.EventHandler(this.abrirPerfil_CheckedChanged);
            // 
            // abrirEditarPerfil
            // 
            this.abrirEditarPerfil.Appearance = System.Windows.Forms.Appearance.Button;
            this.abrirEditarPerfil.AutoSize = true;
            this.abrirEditarPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abrirEditarPerfil.Location = new System.Drawing.Point(3, 36);
            this.abrirEditarPerfil.Name = "abrirEditarPerfil";
            this.abrirEditarPerfil.Size = new System.Drawing.Size(91, 27);
            this.abrirEditarPerfil.TabIndex = 1;
            this.abrirEditarPerfil.TabStop = true;
            this.abrirEditarPerfil.Text = "Editar Perfil";
            this.abrirEditarPerfil.UseVisualStyleBackColor = true;
            this.abrirEditarPerfil.CheckedChanged += new System.EventHandler(this.abrirEditarPerfil_CheckedChanged);
            // 
            // ubicciónFormularioHijoCuenta
            // 
            this.ubicciónFormularioHijoCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ubicciónFormularioHijoCuenta.Location = new System.Drawing.Point(106, 3);
            this.ubicciónFormularioHijoCuenta.Name = "ubicciónFormularioHijoCuenta";
            this.ubicciónFormularioHijoCuenta.Size = new System.Drawing.Size(734, 429);
            this.ubicciónFormularioHijoCuenta.TabIndex = 1;
            // 
            // abrirCerrarSesión
            // 
            this.abrirCerrarSesión.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abrirCerrarSesión.Location = new System.Drawing.Point(3, 69);
            this.abrirCerrarSesión.Name = "abrirCerrarSesión";
            this.abrirCerrarSesión.Size = new System.Drawing.Size(91, 29);
            this.abrirCerrarSesión.TabIndex = 2;
            this.abrirCerrarSesión.Text = "Cerrar Sesión";
            this.abrirCerrarSesión.UseVisualStyleBackColor = true;
            this.abrirCerrarSesión.Click += new System.EventHandler(this.abrirCerrarSesión_Click);
            // 
            // formularioCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 457);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "formularioCuenta";
            this.Text = "formularioCuenta";
            this.Load += new System.EventHandler(this.formularioCuenta_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel ubicciónFormularioHijoCuenta;
        private System.Windows.Forms.RadioButton abrirPerfil;
        private System.Windows.Forms.RadioButton abrirEditarPerfil;
        private System.Windows.Forms.Button abrirCerrarSesión;
    }
}