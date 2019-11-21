using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ProyectoPav.Vistas.Modales;
using Common.Cache;

namespace ProyectoPav
{
    public partial class PrincipalApp : Form
    {
        public PrincipalApp()
        {
            InitializeComponent();
            
            if(UserLoginCache.IdRolUsuario == 1)
            {
                lblUser.Text ="Administrador: " + UserLoginCache.nombre + " " + UserLoginCache.apellido;
            }
            else
            {
                lblUser.Text = "Usuario: " + UserLoginCache.nombre + " " + UserLoginCache.apellido;
                btnUsuarios.Visible = false;
            }
        }
        #region Funcionalidades del formulario
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
            //SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            //e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //-------------------------------------------------------------------
        #endregion

        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        private void AbrirFormEnPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = pan_form.Controls.OfType<Forms>().FirstOrDefault();
            //si el formulario/instancia no existe, creamos nueva instancia y mostramos Jaiflyer - Candela
            if (formulario == null)
            {
                
                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pan_form.Controls.Add(formulario);
                pan_form.Tag = formulario;
                formulario.Show();

                formulario.BringToFront();
            }
            else
            {
                //si la Formulario/instancia existe, lo traemos a frente
                formulario.BringToFront();

                //Si la instancia esta minimizada mostramos
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

            }
        }


        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Capturar pocicion y tamaño antes de maximizar para restaurar 
        int lx, ly;
        int sw, sh;

        private void Pan_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btn_minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnModales_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.Show();
            UserLoginCache.IdUser = 0;
            UserLoginCache.nombre = "";
            UserLoginCache.apellido = "";
            UserLoginCache.email = "";
            UserLoginCache.IdRolUsuario = 0;
            UserLoginCache.telefono = "";
            UserLoginCache.pass = "";


        }

        private void BtnRes_Enter(object sender, EventArgs e)
        {
            btnReserva.Image = Presentacion.Properties.Resources.cama_color;
            btnReserva.ForeColor = Color.FromArgb(78, 184, 206);
            barra_boton.Height = btnReserva.Height;
            barra_boton.Top = btnReserva.Top;
            AbrirFormEnPanel<Vistas.Reserva>();
        }

        private void BtnRes_Leave(object sender, EventArgs e)
        {
            btnReserva.Image = Presentacion.Properties.Resources.cama1;
            btnReserva.ForeColor = Color.White;
        }

        private void BtnHab_Enter(object sender, EventArgs e)
        {
            btnHabitacion.Image = Presentacion.Properties.Resources.cama_color;
            btnHabitacion.ForeColor = Color.FromArgb(78, 184, 206);
            barra_boton.Height = btnHabitacion.Height;
            barra_boton.Top = btnHabitacion.Top;
            AbrirFormEnPanel<Vistas.Habitaciones>();
        }

        private void BtnHab_Leave(object sender, EventArgs e)
        {
            btnHabitacion.Image = Presentacion.Properties.Resources.cama1;
            btnHabitacion.ForeColor = Color.White;
        }

        private void BtnCli_Enter(object sender, EventArgs e)
        {
            btnClientes.Image = Presentacion.Properties.Resources.cama_color;
            btnClientes.ForeColor = Color.FromArgb(78, 184, 206);
            barra_boton.Height = btnClientes.Height;
            barra_boton.Top = btnClientes.Top;
            AbrirFormEnPanel<Vistas.Clientes>();
        }

        private void BtnCli_Leave(object sender, EventArgs e)
        {
            btnClientes.Image = Presentacion.Properties.Resources.cama1;
            btnClientes.ForeColor = Color.White;
        }

        private void BtnUsu_Enter(object sender, EventArgs e)
        {
            btnUsuarios.Image = Presentacion.Properties.Resources.cama_color;
            btnUsuarios.ForeColor = Color.FromArgb(78, 184, 206);
            barra_boton.Height = btnUsuarios.Height;
            barra_boton.Top = btnUsuarios.Top;
            AbrirFormEnPanel<Vistas.Usuarios>();
        }

        private void BtnUsu_Leave(object sender, EventArgs e)
        {
            btnUsuarios.Image = Presentacion.Properties.Resources.cama1;
            btnUsuarios.ForeColor = Color.White;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_maximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            btn_maximizar.Visible = false;
            btn_restaurar.Visible = true;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void Btn_restaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);

            btn_maximizar.Visible = true;
            btn_restaurar.Visible = false;
        }
    }
}
