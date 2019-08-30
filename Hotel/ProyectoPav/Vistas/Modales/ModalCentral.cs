using MaterialSkin;
using MaterialSkin.Controls;

namespace ProyectoPav.Vistas.Modales
{
    public partial class ModalCentral : MaterialForm
    {
        public ModalCentral()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.LightBlue400, Primary.Blue500, Primary.Blue500, Accent.Orange700, TextShade.WHITE);
        }

        private void BtnModalHabitacion_Click(object sender, System.EventArgs e)
        {
            var modalHabitacion = new ModalHabitacion();
            modalHabitacion.Show();
        }

        private void BtnModalHuesped_Click(object sender, System.EventArgs e)
        {
            var modalHuesped = new ModalHuesped();
            modalHuesped.Show();
        }

        private void BtnModalUsuario_Click(object sender, System.EventArgs e)
        {
            var modalUsuario = new ModalUsuario();
            modalUsuario.Show();
        }
    }
}
