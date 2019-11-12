using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;

namespace ProyectoPav
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        int count = 0;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            count += 1;
            if (count == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if(this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
                if(UserLoginCache.IdRolUsuario == 1)
                {
                    PrincipalApp prin = new PrincipalApp();
                    prin.WindowState = FormWindowState.Maximized;
                    prin.Show();
                }
                else
                {

                    PrincipalAppUser prin2 = new PrincipalAppUser();
                    prin2.WindowState = FormWindowState.Maximized;
                    prin2.Show();
                }
                
            }
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
        }
    }
}
