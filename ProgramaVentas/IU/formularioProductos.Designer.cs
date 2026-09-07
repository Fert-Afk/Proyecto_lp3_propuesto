namespace ProgramaVentas
{
    partial class formularioProductos
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
            this.ubicacionFormularioHijoProducto = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.abrirRegistroProducto = new System.Windows.Forms.RadioButton();
            this.abrirRegistroDistribuidor = new System.Windows.Forms.RadioButton();
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
            this.tableLayoutPanel2.Controls.Add(this.ubicacionFormularioHijoProducto, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(843, 435);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ubicacionFormularioHijoProducto
            // 
            this.ubicacionFormularioHijoProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ubicacionFormularioHijoProducto.Location = new System.Drawing.Point(106, 3);
            this.ubicacionFormularioHijoProducto.Name = "ubicacionFormularioHijoProducto";
            this.ubicacionFormularioHijoProducto.Size = new System.Drawing.Size(734, 429);
            this.ubicacionFormularioHijoProducto.TabIndex = 1;
            this.ubicacionFormularioHijoProducto.Paint += new System.Windows.Forms.PaintEventHandler(this.ubicacionFormularioHijoProducto_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.abrirRegistroProducto, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.abrirRegistroDistribuidor, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(97, 67);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // abrirRegistroProducto
            // 
            this.abrirRegistroProducto.Appearance = System.Windows.Forms.Appearance.Button;
            this.abrirRegistroProducto.AutoSize = true;
            this.abrirRegistroProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abrirRegistroProducto.Location = new System.Drawing.Point(3, 3);
            this.abrirRegistroProducto.Name = "abrirRegistroProducto";
            this.abrirRegistroProducto.Size = new System.Drawing.Size(91, 27);
            this.abrirRegistroProducto.TabIndex = 0;
            this.abrirRegistroProducto.TabStop = true;
            this.abrirRegistroProducto.Text = "Productos";
            this.abrirRegistroProducto.UseVisualStyleBackColor = true;
            this.abrirRegistroProducto.CheckedChanged += new System.EventHandler(this.abrirRegistroProducto_CheckedChanged);
            // 
            // abrirRegistroDistribuidor
            // 
            this.abrirRegistroDistribuidor.Appearance = System.Windows.Forms.Appearance.Button;
            this.abrirRegistroDistribuidor.AutoSize = true;
            this.abrirRegistroDistribuidor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abrirRegistroDistribuidor.Location = new System.Drawing.Point(3, 36);
            this.abrirRegistroDistribuidor.Name = "abrirRegistroDistribuidor";
            this.abrirRegistroDistribuidor.Size = new System.Drawing.Size(91, 28);
            this.abrirRegistroDistribuidor.TabIndex = 1;
            this.abrirRegistroDistribuidor.TabStop = true;
            this.abrirRegistroDistribuidor.Text = "Distribuidor";
            this.abrirRegistroDistribuidor.UseVisualStyleBackColor = true;
            this.abrirRegistroDistribuidor.CheckedChanged += new System.EventHandler(this.abrirRegistroDistribuidor_CheckedChanged);
            // 
            // formularioProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 457);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "formularioProductos";
            this.Text = "formularioProductos";
            this.Load += new System.EventHandler(this.formularioProductos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel ubicacionFormularioHijoProducto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton abrirRegistroProducto;
        private System.Windows.Forms.RadioButton abrirRegistroDistribuidor;
    }
}