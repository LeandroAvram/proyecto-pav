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
using Negocio.Servicios;

namespace ProyectoPav.Vistas.Grillas
{
    public partial class GrillaClientes : MaterialForm
    {
        private ClienteService clienteService;
        public GrillaClientes()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.LightBlue400, Primary.Blue500, Primary.Blue500, Accent.Orange700, TextShade.WHITE);
            clienteService = new ClienteService();
            dgvClientes.DataSource = clienteService.ObtenerTodos();
        }
    }
}
