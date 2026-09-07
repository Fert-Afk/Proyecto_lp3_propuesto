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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        Funciones funciones = new Funciones();

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            abrirInicio.Checked = true;
        }

        private void abrirInicio_CheckedChanged(object sender, EventArgs e)
        {
            funciones.botonCheked(abrirInicio, new formularioInicio(), ubicacionFormulariosHijos);
        }

        private void abrirCuenta_CheckedChanged(object sender, EventArgs e)
        {
            funciones.botonCheked(abrirCuenta, new formularioCuenta(), ubicacionFormulariosHijos);
        }

        private void abrirVentas_CheckedChanged(object sender, EventArgs e)
        {
            funciones.botonCheked(abrirVentas, new formularioVentas(), ubicacionFormulariosHijos);
        }

        private void abrirProductos_CheckedChanged(object sender, EventArgs e)
        {
            funciones.botonCheked(abrirProductos, new formularioProductos(), ubicacionFormulariosHijos);
        }

        private void abrirMostrar_CheckedChanged(object sender, EventArgs e)
        {
            funciones.botonCheked(abrirMostrar, new formularioMostrar(), ubicacionFormulariosHijos);
        }
    }
}
