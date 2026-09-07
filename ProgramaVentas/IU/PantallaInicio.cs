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
    public partial class PantallaInicio : RoundedForm
    {
        public PantallaInicio()
        {
            InitializeComponent();
        }

        Funciones funciones = new Funciones();

        private void PantallaInicio_Load_1(object sender, EventArgs e)
        {
            funciones.ConfigurarPlaceholder(ingresoUsuario, "Usuario", usuarioEtiqueta);
            funciones.ConfigurarPlaceholder(ingresoDNI, "DNI", dniEtiqueta);
        }

        private void botonVerificarCredenciales_Click_1(object sender, EventArgs e)
        {
            AccesoBaseDatos acceso = new AccesoBaseDatos();
            //Usuario usuario = new Usuario();

            acceso.usuario = ingresoUsuario.Text == "Usuario" ? null : ingresoUsuario.Text;
            acceso.dni = ingresoDNI.Text == "DNI" ? null : ingresoDNI.Text;

            if (string.IsNullOrEmpty(acceso.usuario) || string.IsNullOrEmpty(acceso.dni))
            {
                MessageBox.Show("Ingrese los todos sus datos solicitados.", "Error");
                return;
            }
            else
            {
                //acceso.usuario = usuario;
                //acceso.dni = dni;
                using (SqlConnection cn = new SqlConnection(acceso.cadena))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(acceso.queryVerificarUsuario, cn);
                    cmd.Parameters.AddWithValue("@usuario", acceso.usuario);
                    cmd.Parameters.AddWithValue("@dni", acceso.dni);
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        UsuarioIniciado.EsValido = true;
                        Form principal = Application.OpenForms["Inicio"]; 
                        if (principal != null)
                            principal.Close();
                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas.", "Error");
                        return;
                    }
                }
            }

            using (SqlConnection cn = new SqlConnection(acceso.cadena))
            {
                cn.Open();
                SqlCommand cmdId = new SqlCommand(acceso.queryObtenerUsuario, cn);
                cmdId.Parameters.AddWithValue("@alias", acceso.usuario);
                UsuarioIniciado.usuario = (int)cmdId.ExecuteScalar();
            }

            string nombre;
            funciones.obtenerDatosUsuario(acceso.queryObtenerNombreIniciado, acceso.usuario, out nombre);
            UsuarioIniciado.nombre = nombre;
            string apellido;
            funciones.obtenerDatosUsuario(acceso.queryObtenerApellidoIniciado, acceso.usuario, out apellido);
            UsuarioIniciado.apellido = apellido;
            string sexo;
            funciones.obtenerDatosUsuario(acceso.queryObtenerSexoIniciado, acceso.usuario, out sexo);

            if (sexo == "F")
            {
                sexo = "Femenino";
            }
            else if (sexo == "M")
            {
                sexo = "Masculino";
            }
            UsuarioIniciado.sexo = sexo;

            string dni2;
            funciones.obtenerDatosUsuario(acceso.queryObtenerDniIniciado, acceso.usuario, out dni2);
            UsuarioIniciado.dni = dni2;

            UsuarioIniciado.alias = acceso.usuario;
        }

    }
}
