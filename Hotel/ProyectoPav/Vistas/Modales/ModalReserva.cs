using MaterialSkin.Controls;
using MaterialSkin;
using System;
using Entidades;
using ProyectoPav.Vistas.Grillas;

namespace ProyectoPav.Vistas.Modales
{
    public partial class ModalReserva : MaterialForm
    {
        public Cliente clienteSeleccionado;
        public Habitacion habitacionSeleccionada;
        public ModalReserva()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.LightBlue400, Primary.Blue500, Primary.Blue500, Accent.Orange700, TextShade.WHITE);
        }

        private void ModalReserva_Load(object sender, EventArgs e)
        {

        }

        private void LblRol_Click(object sender, EventArgs e)
        {

        }

        private void ComboRolUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void MaterialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void MaterialSingleLineTextField2_Click(object sender, EventArgs e)
        {

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

        private void ComboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtDocumentoCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
