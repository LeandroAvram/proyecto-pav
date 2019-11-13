using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio.Servicios;

namespace ProyectoPav.Vistas.Modales
{
    public partial class ModalEstadoReserva : MaterialForm
    {
        private Entidades.ReservaDatos reserva;
        ReservaService resService = new ReservaService();
        public ModalEstadoReserva()
        {
            
            InitializeComponent(); MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.LightBlue400, Primary.Blue500, Primary.Blue500, Accent.Orange700, TextShade.WHITE);
            LlenarCombo(comboRolUsuario,"T_Estado_Reserva","id_estado_reserva", "nombre");
        }

        private void ModalEstadoReserva_Load(object sender, EventArgs e)
        {
            LblIdReserva.Text = reserva.id_reserva.ToString();
            comboRolUsuario.Text = reserva.estadoReserva;
        }

        public void InicializarFormulario(ReservaDatos reservaa)
        {
            reserva = reservaa;
        }

        private void LlenarCombo(ComboBox cbo, string tabla, string value, string display)
        {
            cbo.DataSource = resService.ComboTipoReserva(tabla);
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
        }

        private void BtnCancelarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRegistrarHuesped_Click(object sender, EventArgs e)
        {
            if (resService.ModificarEstado(comboRolUsuario.SelectedIndex + 1, reserva.id_reserva))
            {
                MessageBox.Show("Reserva Modificada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Vistas.Usuarios.dgvUsers.DataSource = oUserService.ObtenerTodos();
                Close();
            }
            else
            {
                MessageBox.Show("Reserva No Modificada!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
