using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaVentas
{
    public partial class formularioCuenta : RoundedForm
    {
        public formularioCuenta()
        {
            InitializeComponent();
        }

        private void formularioCuenta_Load(object sender, EventArgs e)
        {
            abrirPerfil.Checked = true;
        }

        Funciones funciones = new Funciones();
        private void abrirPerfil_CheckedChanged(object sender, EventArgs e)
        {
            funciones.botonCheked(abrirPerfil, new formularioPerfil(), ubicciónFormularioHijoCuenta);
        }

        private void abrirEditarPerfil_CheckedChanged(object sender, EventArgs e)
        {
            funciones.botonCheked(abrirEditarPerfil, new formularioEditarPerfil(), ubicciónFormularioHijoCuenta);
        }

        private void abrirCerrarSesión_Click(object sender, EventArgs e)
        {
            formularioCerrarSesion cerrarsesion = new formularioCerrarSesion();
            cerrarsesion.Show();
        }
    }
}
