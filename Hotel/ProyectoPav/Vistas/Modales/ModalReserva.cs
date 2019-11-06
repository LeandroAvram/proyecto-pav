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
    public partial class ModalReserva : MaterialForm
    {
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

        private void MaterialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void LblRol_Click(object sender, EventArgs e)
        {

        }

        private void ComboRolUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            Vistas.Grillas.GrillaClientes grillaCliente = new Vistas.Grillas.GrillaClientes();
            grillaCliente.ShowDialog();
        }

        private void MaterialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void MaterialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }
    }
}
