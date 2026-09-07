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
    public partial class RegistroConcluido : Form
    {
        public RegistroConcluido()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void volverInicioSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistroConcluido_Load(object sender, EventArgs e)
        {

        }
    }
}
