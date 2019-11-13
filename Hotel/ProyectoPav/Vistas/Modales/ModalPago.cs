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
    public partial class ModalPago : MaterialForm
    {
        private Entidades.ReservaDatos reserva;
        ReservaService resService = new ReservaService();
        public ModalPago()
        {
            InitializeComponent(); MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.LightBlue400, Primary.Blue500, Primary.Blue500, Accent.Orange700, TextShade.WHITE);

        }

        private void MaterialLabel2_Click(object sender, EventArgs e)
        {

        }

        public void InicializarFormulario(ReservaDatos reservaa)
        {
            reserva = reservaa;
        }

        private void Monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }

        private void ModalPago_Load(object sender, EventArgs e)
        {
            LlenarCombo(comboRolUsuario, "T_Forma_Pago", "id_formaPago", "nombre");
            lblidreserva.Text = reserva.id_reserva.ToString();
            lblNombreCom.Text = reserva.nombreCompleto;
            lblNumHab.Text = reserva.nro_habitacion.ToString();
            lblFechaIngre.Text = reserva.fechaIngreso.ToShortDateString();
            lblFechaEgreso.Text = reserva.fechaEgreso.ToShortDateString();
            lbldate.Text = DateTime.Today.ToShortDateString();
            lblTotal.Text = reserva.monto.ToString();
        }

        private void LlenarCombo(ComboBox cbo, string tabla, string value, string display)
        {
            //cbo.DataSource = habService.combpgetCombOCategoria(tabla);
            //cbo.DataSource = habService.getCombOEstado(tabla);
            cbo.DataSource = resService.ComboTipoReserva(tabla);
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void BtnRegistrarHuesped_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Realizar el pago!", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DateTime diactual = DateTime.Today;
                int monto2 = Int32.Parse(monto.Text);
                if (resService.RegistrarPago(reserva, comboRolUsuario.SelectedIndex + 1, diactual, monto2))
                {
                    MessageBox.Show("Se registro el pago con exito", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        Close();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            }
        }
    }
}
