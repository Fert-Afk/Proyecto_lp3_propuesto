using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.SqlClient;

namespace ProgramaVentas
{   
    public partial class PanelRegistro : RoundedForm
    {
        public PanelRegistro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        Funciones funciones = new Funciones();
        AccesoBaseDatos acceso = new AccesoBaseDatos();

        private void PanelRegistro_Load(object sender, EventArgs e)
        {
            CajaDeTextoFormat();
        }

        private void CajaDeTextoFormat()
        {
            botonFemenino.Checked = false;
            botonMasculino.Checked = false;

            funciones.ConfigurarPlaceholder(registroNombre, "Nombre", nombreEtiqueta);
            funciones.ConfigurarPlaceholder(registroApellido, "Apellido", apellidoEtiqueta);
            funciones.ConfigurarPlaceholder(registroDni, "DNI", dniEtiqueta);
            funciones.ConfigurarPlaceholder(registroUsuario, "Usuario", usuarioEtiqueta);
        }

        private void registrarCuenta_Click(object sender, EventArgs e)
        {
            string nombre;
            funciones.CondicionCajaLlena(out nombre, registroNombre, "Apellido");
            acceso.nombre = nombre;
            string apellido;
            funciones.CondicionCajaLlena(out apellido, registroApellido, "Apellido");
            acceso.apellido = apellido;

            string sexo;
            funciones.SiNoMascFem(out sexo, botonFemenino, botonMasculino);
            acceso.sexo = sexo;

            string dni;
            funciones.CondicionCajaLlena(out dni, registroDni, "DNI");
            acceso.dni = dni;
            string usuario;
            funciones.CondicionCajaLlena(out usuario, registroUsuario, "Usuario");
            acceso.usuario = usuario; 

            if (string.IsNullOrEmpty(acceso.nombre) || string.IsNullOrEmpty(acceso.apellido) || string.IsNullOrEmpty(acceso.dni) || string.IsNullOrEmpty(acceso.usuario) || botonFemenino.Checked == false && botonMasculino.Checked == false)
            {
                MessageBox.Show("Complete todos sus datos solicitados.", "Error");
            }
            else
            {
                funciones.RegDatBasDat(
                    acceso.cadena,
                    acceso.queryRegistroUsuario,
                    new List<SqlParameter> 
                    { 
                        new SqlParameter("@nombre", acceso.nombre),
                        new SqlParameter("@apellido", acceso.apellido),
                        new SqlParameter("@sexo", acceso.sexo),
                        new SqlParameter("@dni", acceso.dni),
                        new SqlParameter("@alias", acceso.usuario)
                    }
                );

                CajaDeTextoFormat();

                RegistroConcluido registroConcluido = new RegistroConcluido();
                registroConcluido.Show();
            }
        }
    }
}
