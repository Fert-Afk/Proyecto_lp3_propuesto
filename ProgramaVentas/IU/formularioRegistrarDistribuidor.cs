using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProgramaVentas
{
    public partial class formularioRegistrarDistribuidor : RoundedForm
    {
        public formularioRegistrarDistribuidor()
        {
            InitializeComponent();
        }

        Funciones funciones = new Funciones();
        AccesoBaseDatos acceso = new AccesoBaseDatos();
        Distribuidor distribuidor = new Distribuidor();

        private void formularioRegistrarDistribuidor_Load(object sender, EventArgs e)
        {
            funciones.ConfigurarPlaceholder(ingresarNombreDistribuidor, "Nombre", etiquetaNombreDistribuidor);
            funciones.ConfigurarPlaceholder(ingresarNumTelDistribuidor, "Número Telefónico", etiquetaNumTelDistribuidor);
            funciones.ConfigurarPlaceholder(ingresarDireccionDistribuidor, "Dirección", etiquetaDireccionDistribuidor);
            CargarDatos();
        }

        private void CargarDatos()
        {
            var columnas = new List<ColumnaDefinicion>
            {
                new ColumnaDefinicion {NombreInterno = "nombre", Encabezado = "Nombre", CampoTabla = "NOMBRE"},
                new ColumnaDefinicion {NombreInterno = "telefono", Encabezado = "N° Telefónico", CampoTabla = "TELEFONO"},
                new ColumnaDefinicion {NombreInterno = "direccion", Encabezado = "Dirección", CampoTabla = "DIRECCION"},
            };

            funciones.CargarDataGridView(
                dataGridView1,
                acceso.cadena,
                acceso.queryCargarTablaDistribuidor,
                new List<SqlParameter> { new SqlParameter("@id_usuario", UsuarioIniciado.usuario) },
                columnas,
                incluirBotones: true
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre, numTelefono, direccion;

            funciones.CondicionCajaLlena(out nombre, ingresarNombreDistribuidor, "Nombre");
            funciones.CondicionCajaLlena(out numTelefono, ingresarNumTelDistribuidor, "Número Telefónico");
            funciones.CondicionCajaLlena(out direccion, ingresarDireccionDistribuidor, "Direccion");

            distribuidor.nombre = nombre;
            distribuidor.telefono = numTelefono;
            distribuidor.direccion = direccion;


            if (string.IsNullOrEmpty(distribuidor.nombre) || string.IsNullOrEmpty(distribuidor.telefono) || string.IsNullOrEmpty(distribuidor.direccion))
            {
                MessageBox.Show("Complete todos los datos solicitados");
            }
            else
            {
                funciones.RegDatBasDat(
                    acceso.cadena,
                    acceso.queryRegistrarDistribuidor,
                    new List<SqlParameter>
                    {
                        new SqlParameter("@nombre", distribuidor.nombre),
                        new SqlParameter("@telefono", distribuidor.telefono),
                        new SqlParameter("@direccion", distribuidor.direccion),
                        new SqlParameter("@distribuidor_usuario", UsuarioIniciado.usuario)
                    }
                );

                funciones.ConfigurarPlaceholder(ingresarNombreDistribuidor, "Nombre", etiquetaNombreDistribuidor);
                funciones.ConfigurarPlaceholder(ingresarNumTelDistribuidor, "Número Telefónico", etiquetaNumTelDistribuidor);
                funciones.ConfigurarPlaceholder(ingresarDireccionDistribuidor, "Dirección", etiquetaDireccionDistribuidor);
                CargarDatos();
            }

        }
    }
}
