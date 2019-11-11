using Entidades;
using MaterialSkin;
using MaterialSkin.Controls;
using Negocio.Servicios;
using ProyectoPav.Vistas.Modales;
using System;
using System.Windows.Forms;

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
            var cliente = new ModalHuesped();
            cliente.ShowDialog();
            dgvClientes.DataSource = clienteService.ObtenerTodos();
        }

        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {
            var form = new ModalHuesped();
            var cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            form.InicializarFormulario(ModalHuesped.FormMode.update, cliente);
            form.ShowDialog();
            dgvClientes.DataSource = clienteService.ObtenerTodos();
        }

        private void BtnEliminarCliente_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            if (MessageBox.Show("Seguro que desea habilitar/deshabilitar el usuario seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clienteService.EliminarCliente(cliente))
                {
                    MessageBox.Show("Usuario Habilitado/Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvClientes.DataSource = clienteService.ObtenerTodos();
                }
                else
                    MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
