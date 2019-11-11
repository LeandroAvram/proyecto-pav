using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Windows.Forms;
using Entidades;
using Negocio.Servicios;
using ProyectoPav.Vistas.Modales;

namespace ProyectoPav.Vistas.Grillas
{
    public partial class GrillaHabitaciones : MaterialForm
    {
        private HabitacionService oHabitacion;
        public ModalReserva instanciaReserva;
        public GrillaHabitaciones()
        {
            Inicializar();
        }

        public GrillaHabitaciones(ModalReserva instanciaModal)
        {
            Inicializar();
            this.instanciaReserva = instanciaModal;
        }

        private void Inicializar()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.LightBlue400, Primary.Blue500, Primary.Blue500, Accent.Orange700, TextShade.WHITE);
            oHabitacion = new HabitacionService();
            dgvHabitacion.DataSource = oHabitacion.ObtenerTodos();
        }

        private void BtnFiltrarHabitaciones_Click(object sender, EventArgs e)
        {
            if (DateIngreso.Text == "" || DateEgreso.Text == "")
            {
                //TODO validacion de fechas requeridas
                return;
            }

            //TODO generacion de filtros
            var filtros = new FiltrosHabitacion 
            {
            };

            dgvHabitacion.DataSource = oHabitacion.FiltrarHabitaciones(filtros);
        }

        private void BtnSeleccionarHabitacion_Click(object sender, EventArgs e)
        {
            if (dgvHabitacion.CurrentRow.DataBoundItem != null)
            {
                instanciaReserva.habitacionSeleccionada = (Habitacion) dgvHabitacion.CurrentRow.DataBoundItem;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una habitacion");
                return;
            }
            Close();
        }
    }
}
