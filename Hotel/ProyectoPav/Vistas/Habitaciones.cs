using Entidades;
using MaterialSkin;
using MaterialSkin.Controls;
using Negocio.Servicios;
using System;
using Common.Cache;

namespace ProyectoPav.Vistas
{
    public partial class Habitaciones : MaterialForm
    {

        private HabitacionService ohabitacion;
        public Habitaciones()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue400, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, Accent.Orange700, MaterialSkin.TextShade.WHITE);
            ohabitacion = new HabitacionService();
            dgvHabitacion.DataSource = ohabitacion.ObtenerTodos();
            if (UserLoginCache.IdRolUsuario != 1)
            {
                btn_modificarHab.Visible = false;
                btnNuevaHabitacion.Visible = false;
                btnEliminarHabitacion.Visible = false;

            }
        }


        private void BtnNuevaHabitacion_Click(object sender, EventArgs e)
        {
            Vistas.Modales.ModalHabitacion hab = new Vistas.Modales.ModalHabitacion();
            hab.ShowDialog();
            dgvHabitacion.DataSource = ohabitacion.ObtenerTodos();
        }

        private void Btn_modificarHab_Click(object sender, EventArgs e)
        {
            Vistas.Modales.ModalHabitacion form2 = new Vistas.Modales.ModalHabitacion();
            var habitacion = (Habitacion)dgvHabitacion.CurrentRow.DataBoundItem;
            form2.InicializarFormulario(Modales.ModalHabitacion.FormMode.update, habitacion);
            form2.ShowDialog();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != string.Empty)
            {
                dgvHabitacion.DataSource = ohabitacion.Busqueda(txtBuscar.Text);
            }
            else
            {
                dgvHabitacion.DataSource = ohabitacion.ObtenerTodos();
            }
        }
    }
}
