using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaVentas
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /*public class MyApplicationContext : ApplicationContext
        {
            /*private Inicio inicio;
            private PantallaPrincipal pantallaPrincipal;

            public MyApplicationContext()
            {
                inicio = new Inicio();
                inicio.Show();
                inicio.LoginSuccessful += (sender, e) => MostrarPantallaPrincipal();
            }

            private void MostrarPantallaPrincipal()
            {
                inicio.Hide();
                inicio = new PantallaPrincipal();
                pantallaPrincipal.Show();
            }
        }*/

        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MiContexto());
            //Application.Run(new MyApplicationContext());

            /*using (Inicio inicio = new Inicio())
            {
                if (inicio.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new PantallaPrincipal());
                }
            }*/
        }

        /*public class MiContexto : ApplicationContext
        {
            public MiContexto()
            {
                var formPrincipal = new Inicio();
                formPrincipal.FormClosed += (s, e) => ExitThread(); // termina todo
                formPrincipal.Show();
            }
        }*/
    }

    public class MiContexto : ApplicationContext
    {
        public MiContexto() 
        {
            Inicio login = new Inicio();
            login.FormClosed += (s, e) =>
            {
                if (UsuarioIniciado.EsValido == true)
                {
                    PantallaPrincipal principal = new PantallaPrincipal();
                    principal.FormClosed += (s2, e2) => ExitThread();
                    principal.Show();
                }
                else
                {
                    ExitThread();
                }
            };
            login.Show();
        }
    }

    /*public class MiContexto : ApplicationContext
    {
        public MiContexto()
        {
            // arrancamos con PantallaInicio
            Inicio inicio = new Inicio();
            inicio.FormClosed += (s, e) =>
            {
                if (UsuarioIniciado.EsValido) // condición de login correcto
                {
                    PantallaPrincipal principal = new PantallaPrincipal();
                    principal.FormClosed += (s2, e2) => ExitThread(); // cerrar todo al cerrar principal
                    principal.Show();
                }
                else
                {
                    ExitThread(); // cerrar aplicación si no hay login
                }
            };
            inicio.Show();
        }
    }*/

}
