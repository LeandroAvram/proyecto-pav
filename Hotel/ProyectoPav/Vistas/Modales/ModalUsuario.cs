using MaterialSkin;
using MaterialSkin.Controls;

namespace ProyectoPav.Vistas.Modales
{
    public partial class ModalUsuario : MaterialForm
    {
        public ModalUsuario()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.LightBlue400, Primary.Blue500, Primary.Blue500, Accent.Orange700, TextShade.WHITE);
        }

        private void MaterialTabSelector1_Click(object sender, System.EventArgs e)
        {

        }

        private void MaterialSingleLineTextField3_Click(object sender, System.EventArgs e)
        {

        }
    }
}
