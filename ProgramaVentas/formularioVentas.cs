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
    public partial class formularioVentas : RoundedForm
    {
        public formularioVentas()
        {
            InitializeComponent();
        }

        private void formularioVentas_Load(object sender, EventArgs e)
        {
            botonDetalles.Checked = true;
        }

        Funciones funciones = new Funciones();

        private void botonDetalles_CheckedChanged(object sender, EventArgs e)
        {
            funciones.botonCheked(botonDetalles, new formularioAñadirVenta(), ubicacionFormularioHijoVentas);
        }

        private void botonCliente_CheckedChanged(object sender, EventArgs e)
        {
            funciones.botonCheked(botonCliente, new formularioCliente(), ubicacionFormularioHijoVentas);
        }
    }
}
