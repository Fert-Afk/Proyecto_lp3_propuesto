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
    public partial class formularioEditarPerfil : RoundedForm
    {
        public formularioEditarPerfil()
        {
            InitializeComponent();
        }

        Funciones funciones = new Funciones();

        private void formularioEditarPerfil_Load(object sender, EventArgs e)
        {
            funciones.ConfigurarPlaceholder(editNombre, "Nombre", editNombreEtiqueta);
            funciones.ConfigurarPlaceholder(editApelido, "Apellido", editApellidoEtiqueta);

            funciones.ConfigurarPlaceholderNoLabel(editDni, "DNI");
            funciones.ConfigurarPlaceholderNoLabel(editUsuario, "Usuario");
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
