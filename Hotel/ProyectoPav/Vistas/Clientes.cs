using Entidades;
using MaterialSkin;
using MaterialSkin.Controls;
using Negocio.Servicios;
using ProyectoPav.Vistas.Modales;
using System;

namespace ProyectoPav.Vistas
{
    public partial class Clientes : MaterialForm
    {
        private ClienteService clienteService;

        public Clientes()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue400, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, Accent.Orange700, MaterialSkin.TextShade.WHITE);
            clienteService = new ClienteService();
            dgvClientes.DataSource = clienteService.ObtenerTodos();

        }

        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            Vistas.Modales.ModalHuesped cliente = new Vistas.Modales.ModalHuesped();
            cliente.ShowDialog();
            dgvClientes.DataSource = clienteService.ObtenerTodos();
        }

        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {
            Vistas.Modales.ModalHuesped form = new ModalHuesped();
            var cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            form.InicializarFormulario(ModalHuesped.FormMode.update, cliente);
            form.ShowDialog();
            dgvClientes.DataSource = clienteService.ObtenerTodos();
        }
    }
}
