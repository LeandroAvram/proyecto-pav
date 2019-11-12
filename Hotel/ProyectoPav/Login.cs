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
using Negocio.Servicios;

namespace ProyectoPav
{
    public partial class Login : Form
    {
        private readonly UsuarioService userService;
        public Login()
        {
            InitializeComponent();
            userService = new UsuarioService();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Clear();
            }
            //imgUser.BackgroundImage = Properties.Resources.usuario_color;
            imgUser.Image = Presentacion.Properties.Resources.usuario_color;
            pan1.BackColor = Color.FromArgb(78, 184, 206);
            txtUser.ForeColor = Color.FromArgb(78, 184, 206);

        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
            }
            imgUser.Image = Presentacion.Properties.Resources.usuario;
            pan1.BackColor = Color.WhiteSmoke;
            txtUser.ForeColor = Color.WhiteSmoke;
        }

        private void TxtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Clear();
                txtPass.UseSystemPasswordChar = true;
            }
            imgPass.Image = Presentacion.Properties.Resources.candado_color;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txtPass.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void TxtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.UseSystemPasswordChar = false;
            }
            imgPass.Image = Presentacion.Properties.Resources.candado;
            panel2.BackColor = Color.WhiteSmoke;
            txtPass.ForeColor = Color.WhiteSmoke;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            var rpta = userService.LoginUser(txtUser.Text, txtPass.Text);
            if (rpta== true)
            {
                this.Hide();
                Bienvenida formbienvenida = new Bienvenida();
                formbienvenida.Show();
            }else
            {
                MessageBox.Show("Usuario o Password incorrecto");
            }
            
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            var objeto = e;
        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
