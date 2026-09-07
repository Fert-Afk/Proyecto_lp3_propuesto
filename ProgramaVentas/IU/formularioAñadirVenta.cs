using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaVentas
{
    public partial class formularioAñadirVenta : RoundedForm
    {
        public formularioAñadirVenta()
        {
            InitializeComponent();
        }

        Funciones funciones = new Funciones();
        AccesoBaseDatos acceso = new AccesoBaseDatos();

        private void formularioAñadirVenta_Load(object sender, EventArgs e)
        {
            funciones.CargaComboBox(acceso.queryClientes, comboBox1, "Nombre", "id_cliente", "Nombre", label2);
            funciones.CargaComboBox(acceso.queryProductos, comboBox2, "Producto", "id_producto", "Nombre", label3);


            dataGridView2.Columns.Add("cliente", "Cliente");
            dataGridView2.Columns.Add("cantidad", "Cantidad");
            dataGridView2.Columns.Add("total", "Total");

            DataGridViewButtonColumn botonEditar = new DataGridViewButtonColumn();
            botonEditar.HeaderText = "";
            botonEditar.Name = "botonEditar";
            botonEditar.Text = "Editar";
            botonEditar.UseColumnTextForButtonValue = true;
            dataGridView2.Columns.Add(botonEditar);

            DataGridViewButtonColumn botonBorrar2 = new DataGridViewButtonColumn();
            botonBorrar2.HeaderText = "";
            botonBorrar2.Name = "botonBorrar2";
            botonBorrar2.Text = "Borrar";
            botonBorrar2.UseColumnTextForButtonValue = true;
            dataGridView2.Columns.Add(botonBorrar2);

            dataGridView2.CellClick += dataGridView2_CellClick;
        }

        private void CargarListaProductos()
        {
            dataGridView1.Columns.Add("producto", "Producto");
            dataGridView1.Columns.Add("cantidad", "Cantidad");
            dataGridView1.Columns.Add("precio", "Precio");
            dataGridView1.Columns.Add("total", "Total");

            DataGridViewButtonColumn botonBorrar = new DataGridViewButtonColumn();
            botonBorrar.HeaderText = "";
            botonBorrar.Name = "botonBorrar";
            botonBorrar.Text = "Borrar";
            botonBorrar.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(botonBorrar);

            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if (e.ColumnIndex == dataGridView1.Columns["botonBorrar"].Index)
                {
                    string producto = dataGridView1.Rows[e.RowIndex].Cells["producto"].Value.ToString();
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show($"Cliente {producto} eliminado");
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                /*if (e.ColumnIndex == dataGridView1.Columns["botonEditar"].Index)
                {
                    string nombre = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                    string apellido = dataGridView1.Rows[e.RowIndex].Cells["apellido"].Value.ToString();
                    string sexo = dataGridView1.Rows[e.RowIndex].Cells["sexo"].Value.ToString();

                    MessageBox.Show($"Editar cliente: {nombre} {apellido}, Sexo: {sexo}");
                }*/

                if (e.ColumnIndex == dataGridView2.Columns["botonBorrar2"].Index)
                {
                    string cliente = dataGridView2.Rows[e.RowIndex].Cells["cliente"].Value.ToString();
                    dataGridView2.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show($"Cliente {cliente} eliminado");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            //Persona cliente = new Persona();

            producto.nombre = comboBox2.Text;
            producto.cantidad = (int)numericUpDown1.Value;

            dataGridView1.Rows.Add(producto.nombre, producto.cantidad, 20.00);

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.IsNewRow) continue; // evita la fila vacía
                decimal precio = Convert.ToDecimal(fila.Cells["precio"].Value); 
                int cantidad = Convert.ToInt32(fila.Cells["cantidad"].Value); 
                decimal total = precio * cantidad; // Guardar el resultado en la columna "Total"
                fila.Cells["total"].Value = total; 
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Persona cliente = new Persona();
            cliente.nombre = comboBox1.Text;
            //int cantidad = dataGridView1.Rows.Count;
            int total = 0;
            decimal precioTotal = 0;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.IsNewRow) continue; // evita la fila vacía al final

                if (fila.Cells["cantidad"].Value != null)
                {
                    total += Convert.ToInt32(fila.Cells["cantidad"].Value);
                }

                if (fila.Cells["total"].Value != null)
                {
                    precioTotal += Convert.ToDecimal(fila.Cells["total"].Value);
                }
            }

            int cantidad = total;

            dataGridView2.Rows.Add(cliente.nombre, cantidad, precioTotal);

            dataGridView1.Rows.Clear();
        }
    }
}
