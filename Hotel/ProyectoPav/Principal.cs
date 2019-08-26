using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPav
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            barra_boton.Height = btn1.Height; 
        }

        //-------------------------------------------------------------------
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(64, 64, 64));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            //base.OnPaint(e);
            //ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent , sizeGripRectangle);
        }
        
        //-------------------------------------------------------------------

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn1_Enter(object sender, EventArgs e)
        {
            btn1.Image = Properties.Resources.cama_color;
            btn1.ForeColor = Color.FromArgb(78, 184, 206);
            barra_boton.Height = btn1.Height;
            barra_boton.Top = btn1.Top;

        }

        private void Btn2_Enter(object sender, EventArgs e)
        {
            btn2.Image = Properties.Resources.cama_color;
            btn2.ForeColor = Color.FromArgb(78, 184, 206);
            barra_boton.Height = btn2.Height;
            barra_boton.Top = btn2.Top;
        }

        private void Btn1_Leave(object sender, EventArgs e)
        {
            btn1.Image = Properties.Resources.cama1;
            btn1.ForeColor = Color.White;
        }

        private void Btn2_Leave(object sender, EventArgs e)
        {
            btn2.Image = Properties.Resources.cama1;
            btn2.ForeColor = Color.White;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
