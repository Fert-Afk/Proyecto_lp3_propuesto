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
    public partial class formularioProductos : RoundedForm
    {
        public formularioProductos()
        {
            InitializeComponent();
        }

        Funciones funciones = new Funciones();

        private void formularioProductos_Load(object sender, EventArgs e)
        {
            abrirRegistroProducto.Checked = true;
        }

        private void abrirRegistroProducto_CheckedChanged(object sender, EventArgs e)
        {
            funciones.botonCheked(abrirRegistroProducto, new formularioRegistrarProducto(), ubicacionFormularioHijoProducto);
        }

        private void abrirRegistroDistribuidor_CheckedChanged(object sender, EventArgs e)
        {
            funciones.botonCheked(abrirRegistroDistribuidor, new formularioRegistrarDistribuidor(), ubicacionFormularioHijoProducto);
        }

        private void ubicacionFormularioHijoProducto_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
