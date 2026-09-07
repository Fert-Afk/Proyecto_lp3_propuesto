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
    public partial class formularioPerfil : RoundedForm
    {
        public formularioPerfil()
        {
            InitializeComponent();
        }

        private void formularioPerfil_Load(object sender, EventArgs e)
        {
            label2.Text = UsuarioIniciado.nombre;
            label3.Text = UsuarioIniciado.apellido;
            label4.Text = UsuarioIniciado.sexo;
            label5.Text = UsuarioIniciado.dni;
            label6.Text = UsuarioIniciado.alias;
        }

    }
}
