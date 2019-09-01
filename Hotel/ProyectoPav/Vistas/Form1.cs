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

namespace ProyectoPav.Vistas
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
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
        }

        private void MaterialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Material_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MetroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void JFlatButton3_MouseMove(object sender, EventArgs e)
        {

        }
    }
}
