using MaterialSkin;
using MaterialSkin.Controls;

namespace ProyectoPav.Vistas.Modales
{
    public partial class ModalHabitacion : MaterialForm
    {
        public ModalHabitacion()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.LightBlue400, Primary.Blue500, Primary.Blue500, Accent.Orange700, TextShade.WHITE);
        }
    }
}
