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
    public partial class formularioRegistrarProducto : RoundedForm
    {
        public formularioRegistrarProducto()
        {
            InitializeComponent();
        }

        Funciones funciones = new Funciones();
        Marca marca = new Marca();
        Producto producto = new Producto();
        AccesoBaseDatos acceso = new AccesoBaseDatos();

        private void formularioRegistrarProducto_Load(object sender, EventArgs e)
        {
            CargarDatos();
            funciones.PanelClick(panel1);
            funciones.PanelClick(tableLayoutPanel1);
            funciones.GroupBoxClick(groupBox1);
            funciones.GroupBoxClick(groupBox4);
            funciones.GroupBoxClick(groupBox2);
        }

        private void CargarDatos()
        {
            funciones.ConfigurarPlaceholder(ingresoNombreProd, "Nombre", etiquetaNombreRegProd);
            funciones.ConfigurarPlaceholder(ingresoPrecioProd, "Precio", etiquetaPrecioRegProd);
            funciones.ConfigurarPlaceholder(ingresarNomMarca, "Nombre", etiquetaIngresarNomMarca);

            funciones.CargaComboBox(acceso.queryMarca, selecMarcaProd, "Marca", "id_marca", "Nombre", label6);
            funciones.CargaComboBox(acceso.queryDistribuidor, selectDistribuidor, "Seleccionar Distribuidor", "id_distribuidor", "Nombre", etiquetaSelecDistri);

            var columnas = new List<ColumnaDefinicion>
            {
                new ColumnaDefinicion {NombreInterno = "nombre", Encabezado = "Nombre", CampoTabla = "NOMBRE"},
                new ColumnaDefinicion {NombreInterno = "precio", Encabezado = "Precio", CampoTabla = "PRECIO"},
                new ColumnaDefinicion {NombreInterno = "stock", Encabezado = "Stock", CampoTabla = "STOCK"},
                new ColumnaDefinicion {NombreInterno = "marca", Encabezado = "Marca", CampoTabla = "MARCA"}
            };

            funciones.CargarDataGridView(
                dataGridView1,
                acceso.cadena,
                acceso.queryCargarTablaProducto,
                new List<SqlParameter> { new SqlParameter("@id_usuario", UsuarioIniciado.usuario) },
                columnas,
                incluirBotones: true
            );
        }

        private void RegProdBoton_Click(object sender, EventArgs e)
        {
            string nombre, marca;
            funciones.CondicionCajaLlena(out nombre, ingresoNombreProd, "Nombre");
            funciones.CondicionComboLleno(out marca, selecMarcaProd, "Marca");
            producto.nombre = nombre; 
            producto.marca = marca;

            if (string.IsNullOrEmpty(producto.nombre) || string.IsNullOrEmpty(producto.marca))
            {
                MessageBox.Show("Complete todos los datos solicitados.", "Error");
            }
            else
            {
                string aux_precio;
                funciones.CondicionCajaLlena(out aux_precio, ingresoPrecioProd, "Precio");

                if (double.TryParse(aux_precio, out double precio))
                {
                    producto.precio = precio;
                }
                else
                {
                    MessageBox.Show("Valor no válido en el Precio", "Error");
                }

                int id_marca;
                funciones.obtenerID(acceso.queryObtenerMarcaID, producto.marca, "@nombre", out id_marca);

                funciones.RegDatBasDat(
                    acceso.cadena,
                    acceso.queryRegistrarProducto,
                    new List<SqlParameter>
                    {
                        new SqlParameter("@nombre", producto.nombre),
                        new SqlParameter("@precio", producto.precio),
                        new SqlParameter("@stock", producto.stockInicial),
                        new SqlParameter("@producto_marca", id_marca),
                        new SqlParameter("@producto_usuario", UsuarioIniciado.usuario)
                    }
                );

                funciones.ConfigurarPlaceholder(ingresoNombreProd, "Nombre", etiquetaNombreRegProd);
                funciones.ConfigurarPlaceholder(ingresoPrecioProd, "Precio", etiquetaPrecioRegProd);
                CargarDatos();
                MessageBox.Show("Producto Registrado con éxito","Éxito");
            }


        }

        private void agregarMarca_Click(object sender, EventArgs e)
        {
            string nombre;
            funciones.CondicionCajaLlena(out nombre, ingresarNomMarca, "Nombre");
            marca.nombre = nombre;

            if (string.IsNullOrEmpty(marca.nombre))
            {
                MessageBox.Show("Complete todos los datos solicitados.", "Error");
            }
            else
            {
                funciones.RegDatBasDat(
                    acceso.cadena,
                    acceso.queryRegistrarMarca,
                    new List<SqlParameter>
                    {
                        new SqlParameter("@nombre", marca.nombre),
                        new SqlParameter("@marca_usuario", UsuarioIniciado.usuario)
                    }
                );

                funciones.ConfigurarPlaceholder(ingresarNomMarca, "Nombre", etiquetaIngresarNomMarca);
                funciones.CargaComboBox(acceso.queryMarca, selecMarcaProd, "Marca", "id_marca", "Nombre", label6);
                MessageBox.Show("Marca guardado con éxito", "Éxito");
            }
        }
    }
}
