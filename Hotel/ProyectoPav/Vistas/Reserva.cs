using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Servicios;
using Entidades;

namespace ProyectoPav.Vistas
{
    public partial class Reserva : MaterialForm
    {
        private ReservaService reservaService;
        public Reserva()
        {
            reservaService = new ReservaService();
            InitializeComponent();
            /* MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
             materialSkinManager.AddFormToManage(this);
             materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;


             // Configure color schema
             materialSkinManager.ColorScheme = new ColorScheme(
                 Primary.Blue400, Primary.Blue500,
                 Primary.Blue500, Accent.LightBlue200,
                 TextShade.WHITE
             );*/

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue400, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, Accent.Orange700, MaterialSkin.TextShade.WHITE);
            dgvReservas.DataSource = reservaService.ObtenerTodos();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnNuevaReserva_Click(object sender, EventArgs e)
        {
            Vistas.Modales.ModalReserva user = new Vistas.Modales.ModalReserva();
            user.ShowDialog();
            dgvReservas.DataSource = reservaService.ObtenerTodos();
        }

        private void JFlatButton2_Click(object sender, EventArgs e)
        {
            Vistas.Modales.ModalEstadoReserva form2 = new Vistas.Modales.ModalEstadoReserva();
            var reserva = (ReservaDatos)dgvReservas.CurrentRow.DataBoundItem;
            form2.InicializarFormulario(reserva);
            form2.ShowDialog();
            dgvReservas.DataSource = reservaService.ObtenerTodos();
        }

        private void JFlatButton3_Click(object sender, EventArgs e)
        {
            Vistas.Modales.ModalPago pago = new Vistas.Modales.ModalPago();
            pago.ShowDialog();
        }
    }
}
