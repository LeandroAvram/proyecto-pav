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

namespace ProyectoPav.Vistas.Modales
{
    public partial class ModalPago : MaterialForm
    {
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

        private void MaterialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void Monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }
    }
}
