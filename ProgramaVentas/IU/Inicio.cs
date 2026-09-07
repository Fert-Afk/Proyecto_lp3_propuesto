using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProgramaVentas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        Funciones funciones = new Funciones();

        private void Inicio_Load(object sender, EventArgs e)
        {
           botonInicioSesion.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            funciones.botonCheked(botonInicioSesion, new PantallaInicio(), ubicacionFormularioHijoInicio);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            funciones.botonCheked(botonRegistro, new PanelRegistro(), ubicacionFormularioHijoInicio);
        }
    }
}