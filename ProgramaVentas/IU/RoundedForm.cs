using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProgramaVentas
{

    public class RoundedForm : Form
    {
        private int cornerRadius = 20;

        public RoundedForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Activar suavizado
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Crear ruta redondeada
            using (GraphicsPath path = new GraphicsPath())
            {
                int r = cornerRadius;
                path.AddArc(0, 0, r, r, 180, 90);
                path.AddArc(this.Width - r, 0, r, r, 270, 90);
                path.AddArc(this.Width - r, this.Height - r, r, r, 0, 90);
                path.AddArc(0, this.Height - r, r, r, 90, 90);
                path.CloseFigure();

                // Asignar región
                this.Region = new Region(path);

                // Opcional: dibujar borde suave
                using (Pen pen = new Pen(Color.LightGray, 2))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate(); // Redibuja con suavizado al cambiar tamaño
        }
    }

}
