namespace ProgramaVentas
{
    partial class formularioCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonGuardarDatos = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.opcionClienteFemenino = new System.Windows.Forms.RadioButton();
            this.opcionClienteMasculino = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.etiquetaApellidoCliente = new System.Windows.Forms.Label();
            this.etiquetaNombreCliente = new System.Windows.Forms.Label();
            this.ingresarApellidoCliente = new System.Windows.Forms.TextBox();
            this.ingresarNombreCliente = new System.Windows.Forms.TextBox();
            this.etiquetaCliente1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.103448F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.37931F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.517241F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.900238F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.962F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.137767F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(725, 421);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.botonGuardarDatos);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.etiquetaCliente1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 398);
            this.panel1.TabIndex = 0;
            // 
            // botonGuardarDatos
            // 
            this.botonGuardarDatos.Location = new System.Drawing.Point(6, 164);
            this.botonGuardarDatos.Name = "botonGuardarDatos";
            this.botonGuardarDatos.Size = new System.Drawing.Size(100, 23);
            this.botonGuardarDatos.TabIndex = 6;
            this.botonGuardarDatos.Text = "Guardar";
            this.botonGuardarDatos.UseVisualStyleBackColor = true;
            this.botonGuardarDatos.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(6, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(690, 202);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(684, 183);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.opcionClienteFemenino);
            this.groupBox2.Controls.Add(this.opcionClienteMasculino);
            this.groupBox2.Location = new System.Drawing.Point(6, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 55);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo";
            // 
            // opcionClienteFemenino
            // 
            this.opcionClienteFemenino.AutoSize = true;
            this.opcionClienteFemenino.Location = new System.Drawing.Point(15, 19);
            this.opcionClienteFemenino.Name = "opcionClienteFemenino";
            this.opcionClienteFemenino.Size = new System.Drawing.Size(71, 17);
            this.opcionClienteFemenino.TabIndex = 3;
            this.opcionClienteFemenino.TabStop = true;
            this.opcionClienteFemenino.Text = "Femenino";
            this.opcionClienteFemenino.UseVisualStyleBackColor = true;
            // 
            // opcionClienteMasculino
            // 
            this.opcionClienteMasculino.AutoSize = true;
            this.opcionClienteMasculino.Location = new System.Drawing.Point(174, 19);
            this.opcionClienteMasculino.Name = "opcionClienteMasculino";
            this.opcionClienteMasculino.Size = new System.Drawing.Size(73, 17);
            this.opcionClienteMasculino.TabIndex = 2;
            this.opcionClienteMasculino.TabStop = true;
            this.opcionClienteMasculino.Text = "Masculino";
            this.opcionClienteMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.etiquetaApellidoCliente);
            this.groupBox1.Controls.Add(this.etiquetaNombreCliente);
            this.groupBox1.Controls.Add(this.ingresarApellidoCliente);
            this.groupBox1.Controls.Add(this.ingresarNombreCliente);
            this.groupBox1.Location = new System.Drawing.Point(6, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombre y Apellido";
            // 
            // etiquetaApellidoCliente
            // 
            this.etiquetaApellidoCliente.AutoSize = true;
            this.etiquetaApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaApellidoCliente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.etiquetaApellidoCliente.Location = new System.Drawing.Point(362, 19);
            this.etiquetaApellidoCliente.Name = "etiquetaApellidoCliente";
            this.etiquetaApellidoCliente.Size = new System.Drawing.Size(38, 12);
            this.etiquetaApellidoCliente.TabIndex = 3;
            this.etiquetaApellidoCliente.Text = "Apellido";
            // 
            // etiquetaNombreCliente
            // 
            this.etiquetaNombreCliente.AutoSize = true;
            this.etiquetaNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaNombreCliente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.etiquetaNombreCliente.Location = new System.Drawing.Point(23, 19);
            this.etiquetaNombreCliente.Name = "etiquetaNombreCliente";
            this.etiquetaNombreCliente.Size = new System.Drawing.Size(38, 12);
            this.etiquetaNombreCliente.TabIndex = 2;
            this.etiquetaNombreCliente.Text = "Nombre";
            // 
            // ingresarApellidoCliente
            // 
            this.ingresarApellidoCliente.Location = new System.Drawing.Point(354, 29);
            this.ingresarApellidoCliente.Name = "ingresarApellidoCliente";
            this.ingresarApellidoCliente.Size = new System.Drawing.Size(298, 20);
            this.ingresarApellidoCliente.TabIndex = 1;
            // 
            // ingresarNombreCliente
            // 
            this.ingresarNombreCliente.Location = new System.Drawing.Point(15, 29);
            this.ingresarNombreCliente.Name = "ingresarNombreCliente";
            this.ingresarNombreCliente.Size = new System.Drawing.Size(298, 20);
            this.ingresarNombreCliente.TabIndex = 0;
            // 
            // etiquetaCliente1
            // 
            this.etiquetaCliente1.AutoSize = true;
            this.etiquetaCliente1.Location = new System.Drawing.Point(3, 4);
            this.etiquetaCliente1.Name = "etiquetaCliente1";
            this.etiquetaCliente1.Size = new System.Drawing.Size(72, 13);
            this.etiquetaCliente1.TabIndex = 0;
            this.etiquetaCliente1.Text = "Añadir Cliente";
            // 
            // formularioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 421);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "formularioCliente";
            this.Text = "formularioCliente";
            this.Load += new System.EventHandler(this.formularioCliente_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label etiquetaCliente1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton opcionClienteMasculino;
        private System.Windows.Forms.TextBox ingresarApellidoCliente;
        private System.Windows.Forms.TextBox ingresarNombreCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botonGuardarDatos;
        private System.Windows.Forms.RadioButton opcionClienteFemenino;
        private System.Windows.Forms.Label etiquetaApellidoCliente;
        private System.Windows.Forms.Label etiquetaNombreCliente;
    }
}