using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaVentas
{
    internal class AccesoBaseDatos
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public string sexo { get; set; }
        public string usuario { get; set; }

        public string cadena = "Data Source = LordNieve\\LORDNIEVE; Initial Catalog = RegistroVentas; Integrated Security = true; Encrypt = True; TrustServerCertificate = True; Connection Timeout = 15;";
        public string queryRegistroUsuario = "insert into usuario (nombre, apellido, sexo, dni, alias) values (@nombre, @apellido, @sexo, @dni, @alias)";
        public string queryVerificarUsuario = "select count(*) from usuario where alias = @usuario and dni = @dni";
        public string queryRegistrarCliente = "insert into cliente (nombre, apellido, sexo, cliente_usuario) values (@nombre, @apellido, @sexo, @cliente_usuario)";
        public string queryObtenerUsuario = "select id_usuario FROM usuario WHERE alias = @alias";
        public string queryClientes = "SELECT id_cliente, nombre FROM cliente where cliente_usuario = @usuario";
        public string queryProductos = "select id_producto, nombre from producto where producto_usuario = @usuario";
        public string queryObtenerNombreIniciado = "select nombre FROM usuario WHERE alias = @alias";
        public string queryObtenerApellidoIniciado = "select apellido FROM usuario WHERE alias = @alias";
        public string queryObtenerSexoIniciado = "select sexo FROM usuario WHERE alias = @alias";
        public string queryObtenerDniIniciado = "select dni FROM usuario WHERE alias = @alias";
        public string queryCargarTablaCliente = "select nombre, apellido, sexo from cliente where cliente_usuario = @id_usuario";
        public string queryRegistrarMarca = "insert into marca (nombre, marca_usuario) values (@nombre, @marca_usuario)";
        public string queryRegistrarProducto = "insert into producto (nombre, precio, stock, producto_marca, producto_usuario) values (@nombre, @precio, @stock, @producto_marca, @producto_usuario)";
        public string queryRegistrarDistribuidor = "insert into distribuidor (nombre, telefono, direccion, distribuidor_usuario) values (@nombre, @telefono, @direccion, @distribuidor_usuario)";
        public string queryObtenerMarcaID = "select id_marca from marca where nombre = @nombre";
        public string queryCargarTablaProducto = "select p.nombre, p.precio, p.stock, m.nombre as marca from producto p join marca m on p.producto_marca = m.id_marca";
        public string queryCargarTablaDistribuidor = "select nombre, telefono, direccion from distribuidor where distribuidor_usuario = @id_usuario";
        public string queryMarca = "select id_marca, nombre from marca where marca_usuario = @usuario";
        public string queryDistribuidor = "select id_distribuidor, nombre from distribuidor where distribuidor_usuario = @usuario";
    }
}
