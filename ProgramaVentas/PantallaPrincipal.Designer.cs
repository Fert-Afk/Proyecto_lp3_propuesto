using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProgramaVentas
{
    partial class PantallaPrincipal
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
            this.pantallaCompleta = new System.Windows.Forms.TableLayoutPanel();
            this.pantallaMenuContenido = new System.Windows.Forms.TableLayoutPanel();
            this.contenido = new System.Windows.Forms.TableLayoutPanel();
            this.ubicacionFormulariosHijos = new System.Windows.Forms.Panel();
            this.pantallaDivisionMenu = new System.Windows.Forms.TableLayoutPanel();
            this.pantallaMenu = new System.Windows.Forms.TableLayoutPanel();
            this.abrirCuenta = new System.Windows.Forms.RadioButton();
            this.abrirInicio = new System.Windows.Forms.RadioButton();
            this.abrirVentas = new System.Windows.Forms.RadioButton();
            this.abrirProductos = new System.Windows.Forms.RadioButton();
            this.abrirMostrar = new System.Windows.Forms.RadioButton();
            this.pantallaCompleta.SuspendLayout();
            this.pantallaMenuContenido.SuspendLayout();
            this.contenido.SuspendLayout();
            this.pantallaDivisionMenu.SuspendLayout();
            this.pantallaMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pantallaCompleta
            // 
            this.pantallaCompleta.ColumnCount = 3;
            this.pantallaCompleta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.264368F));
            this.pantallaCompleta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.73563F));
            this.pantallaCompleta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.pantallaCompleta.Controls.Add(this.pantallaMenuContenido, 1, 1);
            this.pantallaCompleta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pantallaCompleta.Location = new System.Drawing.Point(0, 0);
            this.pantallaCompleta.Name = "pantallaCompleta";
            this.pantallaCompleta.RowCount = 3;
            this.pantallaCompleta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.217742F));
            this.pantallaCompleta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.78226F));
            this.pantallaCompleta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.pantallaCompleta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pantallaCompleta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pantallaCompleta.Size = new System.Drawing.Size(1013, 548);
            this.pantallaCompleta.TabIndex = 0;
            // 
            // pantallaMenuContenido
            // 
            this.pantallaMenuContenido.ColumnCount = 2;
            this.pantallaMenuContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.85181F));
            this.pantallaMenuContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.14819F));
            this.pantallaMenuContenido.Controls.Add(this.contenido, 1, 0);
            this.pantallaMenuContenido.Controls.Add(this.pantallaDivisionMenu, 0, 0);
            this.pantallaMenuContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pantallaMenuContenido.Location = new System.Drawing.Point(15, 14);
            this.pantallaMenuContenido.Name = "pantallaMenuContenido";
            this.pantallaMenuContenido.RowCount = 1;
            this.pantallaMenuContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pantallaMenuContenido.Size = new System.Drawing.Size(983, 519);
            this.pantallaMenuContenido.TabIndex = 0;
            // 
            // contenido
            // 
            this.contenido.ColumnCount = 1;
            this.contenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contenido.Controls.Add(this.ubicacionFormulariosHijos, 0, 1);
            this.contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenido.Location = new System.Drawing.Point(109, 3);
            this.contenido.Name = "contenido";
            this.contenido.RowCount = 2;
            this.contenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.936575F));
            this.contenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.06342F));
            this.contenido.Size = new System.Drawing.Size(871, 513);
            this.contenido.TabIndex = 1;
            // 
            // ubicacionFormulariosHijos
            // 
            this.ubicacionFormulariosHijos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ubicacionFormulariosHijos.Location = new System.Drawing.Point(3, 53);
            this.ubicacionFormulariosHijos.Name = "ubicacionFormulariosHijos";
            this.ubicacionFormulariosHijos.Size = new System.Drawing.Size(865, 457);
            this.ubicacionFormulariosHijos.TabIndex = 0;
            // 
            // pantallaDivisionMenu
            // 
            this.pantallaDivisionMenu.ColumnCount = 1;
            this.pantallaDivisionMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pantallaDivisionMenu.Controls.Add(this.pantallaMenu, 0, 0);
            this.pantallaDivisionMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pantallaDivisionMenu.Location = new System.Drawing.Point(3, 3);
            this.pantallaDivisionMenu.Name = "pantallaDivisionMenu";
            this.pantallaDivisionMenu.RowCount = 2;
            this.pantallaDivisionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.43763F));
            this.pantallaDivisionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.56237F));
            this.pantallaDivisionMenu.Size = new System.Drawing.Size(100, 513);
            this.pantallaDivisionMenu.TabIndex = 2;
            // 
            // pantallaMenu
            // 
            this.pantallaMenu.ColumnCount = 1;
            this.pantallaMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pantallaMenu.Controls.Add(this.abrirCuenta, 0, 0);
            this.pantallaMenu.Controls.Add(this.abrirInicio, 0, 1);
            this.pantallaMenu.Controls.Add(this.abrirVentas, 0, 2);
            this.pantallaMenu.Controls.Add(this.abrirProductos, 0, 3);
            this.pantallaMenu.Controls.Add(this.abrirMostrar, 0, 4);
            this.pantallaMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pantallaMenu.Location = new System.Drawing.Point(3, 3);
            this.pantallaMenu.Name = "pantallaMenu";
            this.pantallaMenu.RowCount = 5;
            this.pantallaMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.pantallaMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.pantallaMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.pantallaMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.pantallaMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.pantallaMenu.Size = new System.Drawing.Size(94, 206);
            this.pantallaMenu.TabIndex = 0;
            // 
            // abrirCuenta
            // 
            this.abrirCuenta.Appearance = System.Windows.Forms.Appearance.Button;
            this.abrirCuenta.AutoSize = true;
            this.abrirCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abrirCuenta.Location = new System.Drawing.Point(3, 3);
            this.abrirCuenta.Name = "abrirCuenta";
            this.abrirCuenta.Size = new System.Drawing.Size(88, 41);
            this.abrirCuenta.TabIndex = 0;
            this.abrirCuenta.Text = "Cuenta";
            this.abrirCuenta.UseVisualStyleBackColor = true;
            this.abrirCuenta.CheckedChanged += new System.EventHandler(this.abrirCuenta_CheckedChanged);
            // 
            // abrirInicio
            // 
            this.abrirInicio.Appearance = System.Windows.Forms.Appearance.Button;
            this.abrirInicio.AutoSize = true;
            this.abrirInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abrirInicio.Location = new System.Drawing.Point(3, 50);
            this.abrirInicio.Name = "abrirInicio";
            this.abrirInicio.Size = new System.Drawing.Size(88, 33);
            this.abrirInicio.TabIndex = 1;
            this.abrirInicio.Text = "Inicio";
            this.abrirInicio.UseVisualStyleBackColor = true;
            this.abrirInicio.CheckedChanged += new System.EventHandler(this.abrirInicio_CheckedChanged);
            // 
            // abrirVentas
            // 
            this.abrirVentas.Appearance = System.Windows.Forms.Appearance.Button;
            this.abrirVentas.AutoSize = true;
            this.abrirVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abrirVentas.Location = new System.Drawing.Point(3, 89);
            this.abrirVentas.Name = "abrirVentas";
            this.abrirVentas.Size = new System.Drawing.Size(88, 33);
            this.abrirVentas.TabIndex = 2;
            this.abrirVentas.Text = "Venta";
            this.abrirVentas.UseVisualStyleBackColor = true;
            this.abrirVentas.CheckedChanged += new System.EventHandler(this.abrirVentas_CheckedChanged);
            // 
            // abrirProductos
            // 
            this.abrirProductos.Appearance = System.Windows.Forms.Appearance.Button;
            this.abrirProductos.AutoSize = true;
            this.abrirProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abrirProductos.Location = new System.Drawing.Point(3, 128);
            this.abrirProductos.Name = "abrirProductos";
            this.abrirProductos.Size = new System.Drawing.Size(88, 33);
            this.abrirProductos.TabIndex = 3;
            this.abrirProductos.Text = "Producto";
            this.abrirProductos.UseVisualStyleBackColor = true;
            this.abrirProductos.CheckedChanged += new System.EventHandler(this.abrirProductos_CheckedChanged);
            // 
            // abrirMostrar
            // 
            this.abrirMostrar.Appearance = System.Windows.Forms.Appearance.Button;
            this.abrirMostrar.AutoSize = true;
            this.abrirMostrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abrirMostrar.Location = new System.Drawing.Point(3, 167);
            this.abrirMostrar.Name = "abrirMostrar";
            this.abrirMostrar.Size = new System.Drawing.Size(88, 36);
            this.abrirMostrar.TabIndex = 4;
            this.abrirMostrar.Text = "Mostrar";
            this.abrirMostrar.UseVisualStyleBackColor = true;
            this.abrirMostrar.CheckedChanged += new System.EventHandler(this.abrirMostrar_CheckedChanged);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 548);
            this.Controls.Add(this.pantallaCompleta);
            this.Name = "PantallaPrincipal";
            this.Text = "PantallaPrincipal";
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.pantallaCompleta.ResumeLayout(false);
            this.pantallaMenuContenido.ResumeLayout(false);
            this.contenido.ResumeLayout(false);
            this.pantallaDivisionMenu.ResumeLayout(false);
            this.pantallaMenu.ResumeLayout(false);
            this.pantallaMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel pantallaCompleta;
        private TableLayoutPanel pantallaMenuContenido;
        private TableLayoutPanel pantallaMenu;
        private RadioButton abrirInicio;
        private RadioButton abrirCuenta;
        private RadioButton abrirVentas;
        private RadioButton abrirProductos;
        private TableLayoutPanel contenido;
        private Panel ubicacionFormulariosHijos;
        private RadioButton abrirMostrar;
        private TableLayoutPanel pantallaDivisionMenu;
    }



}