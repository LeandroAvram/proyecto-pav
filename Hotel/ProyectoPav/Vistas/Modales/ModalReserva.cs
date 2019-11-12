using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Windows.Forms;
using Common.Cache;
using Entidades;
using Negocio.Servicios;
using ProyectoPav.Vistas.Grillas;

namespace ProyectoPav.Vistas.Modales
{
    public partial class ModalReserva : MaterialForm
    {
        public Cliente clienteSeleccionado;
        public Habitacion habitacionSeleccionada;
        private ReservaService reservaService;
        public ModalReserva()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.LightBlue400, Primary.Blue500, Primary.Blue500, Accent.Orange700, TextShade.WHITE);
            reservaService = new ReservaService();
        }

        private void ModalReserva_Load(object sender, EventArgs e)
        {
            LlenarCombo(comboTipoReserva, "t_tipo_reserva", "id_tipo_reserva", "nombre");
        }

        private void BtnIngresarCliente_Click(object sender, EventArgs e)
        {
            GrillaClientes grillaCliente = new GrillaClientes(this);
            grillaCliente.ShowDialog();
            if (clienteSeleccionado != null)
            {
                LblApellidoCliente.Text = clienteSeleccionado.Apellido;
                LblNombreCliente.Text = clienteSeleccionado.Nombre;
                LblTipoDocumento.Text = clienteSeleccionado.TipoDocumento.Nombre;
                LblNumeroDocumento.Text = clienteSeleccionado.NroDocumento;
            }
        }

        private void LlenarCombo(ComboBox cbo, string tabla, string value, string display)
        {
            cbo.DataSource = reservaService.ComboTipoReserva(tabla);
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
        }
 
        private void BtnIngresarHabitacion_Click(object sender, EventArgs e)
        {
            GrillaHabitaciones grillaHabitaciones = new GrillaHabitaciones(this);
            grillaHabitaciones.ShowDialog();
            if (habitacionSeleccionada != null)
            {
                LblCatHabi.Text = habitacionSeleccionada.catHab.nombre;
                LblPrecioHabitacion.Text = habitacionSeleccionada.precio.ToString();
                LblNroHabitacion.Text = habitacionSeleccionada.nro_habitacion.ToString();
                LblTipoHab.Text = habitacionSeleccionada.tipoHab.nombre;
            }
        }

        private void MetroDateTime2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnRegistrarReserva_Click(object sender, EventArgs e)
        {
            var oReserva = new ReservaMod
            {
                id_tipo_reserva = (int) comboTipoReserva.SelectedValue,
                id_habitacion = habitacionSeleccionada.Id_habitacion,
                id_usuario = UserLoginCache.IdUser,
                id_cliente = clienteSeleccionado.Id,
                fecha_ingreso = datePickerIngreso.Value,
                fecha_egreso  = datePickerEgreso.Value,
                cant_persona = Int32.Parse(txtCantPersonas.Text)
            };

            if (reservaService.CrearReserva(oReserva))
            {
                MessageBox.Show("Reserva creada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("La reserva no se pudo crear!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
