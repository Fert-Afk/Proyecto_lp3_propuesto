namespace ProgramaVentas
{
    partial class formularioVentas
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
            this.pantallaCompletaVenta = new System.Windows.Forms.TableLayoutPanel();
            this.divisiónOpcionesContenido = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.botonDetalles = new System.Windows.Forms.RadioButton();
            this.botonCliente = new System.Windows.Forms.RadioButton();
            this.ubicacionFormularioHijoVentas = new System.Windows.Forms.Panel();
            this.pantallaCompletaVenta.SuspendLayout();
            this.divisiónOpcionesContenido.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pantallaCompletaVenta
            // 
            this.pantallaCompletaVenta.ColumnCount = 3;
            this.pantallaCompletaVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9248555F));
            this.pantallaCompletaVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.2659F));
            this.pantallaCompletaVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9248555F));
            this.pantallaCompletaVenta.Controls.Add(this.divisiónOpcionesContenido, 1, 1);
            this.pantallaCompletaVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pantallaCompletaVenta.Location = new System.Drawing.Point(0, 0);
            this.pantallaCompletaVenta.Name = "pantallaCompletaVenta";
            this.pantallaCompletaVenta.RowCount = 3;
            this.pantallaCompletaVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.750547F));
            this.pantallaCompletaVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.71773F));
            this.pantallaCompletaVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.750547F));
            this.pantallaCompletaVenta.Size = new System.Drawing.Size(865, 457);
            this.pantallaCompletaVenta.TabIndex = 0;
            // 
            // divisiónOpcionesContenido
            // 
            this.divisiónOpcionesContenido.ColumnCount = 2;
            this.divisiónOpcionesContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.divisiónOpcionesContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.7551F));
            this.divisiónOpcionesContenido.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.divisiónOpcionesContenido.Controls.Add(this.ubicacionFormularioHijoVentas, 1, 0);
            this.divisiónOpcionesContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divisiónOpcionesContenido.Location = new System.Drawing.Point(10, 10);
            this.divisiónOpcionesContenido.Name = "divisiónOpcionesContenido";
            this.divisiónOpcionesContenido.RowCount = 1;
            this.divisiónOpcionesContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.divisiónOpcionesContenido.Size = new System.Drawing.Size(843, 435);
            this.divisiónOpcionesContenido.TabIndex = 0;            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.botonDetalles, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.botonCliente, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(97, 67);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // botonDetalles
            // 
            this.botonDetalles.Appearance = System.Windows.Forms.Appearance.Button;
            this.botonDetalles.AutoSize = true;
            this.botonDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonDetalles.Location = new System.Drawing.Point(3, 3);
            this.botonDetalles.Name = "botonDetalles";
            this.botonDetalles.Size = new System.Drawing.Size(91, 27);
            this.botonDetalles.TabIndex = 1;
            this.botonDetalles.TabStop = true;
            this.botonDetalles.Text = "Detalles";
            this.botonDetalles.UseVisualStyleBackColor = true;
            this.botonDetalles.CheckedChanged += new System.EventHandler(this.botonDetalles_CheckedChanged);
            // 
            // botonCliente
            // 
            this.botonCliente.Appearance = System.Windows.Forms.Appearance.Button;
            this.botonCliente.AutoSize = true;
            this.botonCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonCliente.Location = new System.Drawing.Point(3, 36);
            this.botonCliente.Name = "botonCliente";
            this.botonCliente.Size = new System.Drawing.Size(91, 28);
            this.botonCliente.TabIndex = 0;
            this.botonCliente.TabStop = true;
            this.botonCliente.Text = "Cliente";
            this.botonCliente.UseVisualStyleBackColor = true;
            this.botonCliente.CheckedChanged += new System.EventHandler(this.botonCliente_CheckedChanged);
            // 
            // ubicacionFormularioHijoVentas
            // 
            this.ubicacionFormularioHijoVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ubicacionFormularioHijoVentas.Location = new System.Drawing.Point(106, 3);
            this.ubicacionFormularioHijoVentas.Name = "ubicacionFormularioHijoVentas";
            this.ubicacionFormularioHijoVentas.Size = new System.Drawing.Size(734, 429);
            this.ubicacionFormularioHijoVentas.TabIndex = 1;            // 
            // formularioVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 457);
            this.Controls.Add(this.pantallaCompletaVenta);
            this.Name = "formularioVentas";
            this.Text = "formularioVentas";
            this.Load += new System.EventHandler(this.formularioVentas_Load);
            this.pantallaCompletaVenta.ResumeLayout(false);
            this.divisiónOpcionesContenido.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pantallaCompletaVenta;
        private System.Windows.Forms.TableLayoutPanel divisiónOpcionesContenido;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton botonCliente;
        private System.Windows.Forms.RadioButton botonDetalles;
        private System.Windows.Forms.Panel ubicacionFormularioHijoVentas;
    }
}