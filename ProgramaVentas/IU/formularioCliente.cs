using System;
using System.Collections;
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
    public partial class formularioCliente : RoundedForm
    {
        public formularioCliente()
        {
            InitializeComponent();
        }

        Funciones funciones = new Funciones();
        AccesoBaseDatos acceso = new AccesoBaseDatos();

        private void CargarDatos()
        {
            var columnas = new List<ColumnaDefinicion>
            {
                new ColumnaDefinicion {NombreInterno = "nombre", Encabezado = "Nombre", CampoTabla = "NOMBRE"},
                new ColumnaDefinicion {NombreInterno = "apellido", Encabezado = "Apellido", CampoTabla = "APELLIDO"},
                new ColumnaDefinicion {NombreInterno = "sexo", Encabezado = "Sexo", CampoTabla = "SEXO"}
            };

            funciones.CargarDataGridView(
                dataGridView1,
                acceso.cadena,
                acceso.queryCargarTablaCliente,
                new List<SqlParameter> { new SqlParameter("@id_usuario", UsuarioIniciado.usuario) },
                columnas,
                incluirBotones: true
            );
        }

        private void formularioCliente_Load(object sender, EventArgs e)
        {
            CajaDeTextoFormat();
            //dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void CajaDeTextoFormat()
        {
            funciones.ConfigurarPlaceholder(ingresarNombreCliente, "Nombre", etiquetaNombreCliente);
            funciones.ConfigurarPlaceholder(ingresarApellidoCliente, "Apellido", etiquetaApellidoCliente);

            opcionClienteMasculino.Checked = false;
            opcionClienteFemenino.Checked = false;

            CargarDatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns["botonEditar"].Index)
                {
                    string nombre = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                    string apellido = dataGridView1.Rows[e.RowIndex].Cells["apellido"].Value.ToString();
                    string sexo = dataGridView1.Rows[e.RowIndex].Cells["sexo"].Value.ToString();

                    MessageBox.Show($"Editar cliente: {nombre} {apellido}, Sexo: {sexo}");
                }

                if (e.ColumnIndex == dataGridView1.Columns["botonBorrar"].Index)
                {
                    string nombre = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show($"Cliente {nombre} eliminado");
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;
            funciones.CondicionCajaLlena(out nombre, ingresarNombreCliente, "Nombre");
            acceso.nombre = nombre;
            string apellido;
            funciones.CondicionCajaLlena(out apellido, ingresarApellidoCliente, "Apellido");
            acceso.apellido = apellido;
            string sexo;
            funciones.SiNoMascFem(out sexo, opcionClienteFemenino, opcionClienteMasculino);
            acceso.sexo = sexo;

            if (string.IsNullOrEmpty(acceso.nombre) || 
                string.IsNullOrEmpty(acceso.apellido) || 
                opcionClienteFemenino.Checked == false && 
                opcionClienteMasculino.Checked == false)
            {
                MessageBox.Show("Complete todos los datos solicitados.", "Error");
            }
            else
            {
                funciones.RegDatBasDat(
                    acceso.cadena,
                    acceso.queryRegistrarCliente,
                    new List<SqlParameter> 
                    { 
                        new SqlParameter("@nombre", acceso.nombre),
                        new SqlParameter("@apellido", acceso.apellido),
                        new SqlParameter("@sexo", acceso.sexo),
                        new SqlParameter("@cliente_usuario", UsuarioIniciado.usuario) 
                    }
                );

                CajaDeTextoFormat();
            }
        }
    }
}
