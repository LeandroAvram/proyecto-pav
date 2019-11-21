using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Windows.Forms;
using Entidades;
using Negocio.Servicios;
using ProyectoPav.Vistas.Modales;

namespace ProyectoPav.Vistas.Grillas
{
    public partial class GrillaClientes : MaterialForm
    {
        private ClienteService clienteService;
        private ModalReserva instanciaReserva;
        public GrillaClientes()
        {
            InicializarGrilla();
        }

        public GrillaClientes(ModalReserva modalInstancia)
        {
            InicializarGrilla();
            instanciaReserva = modalInstancia;
        }

        public void InicializarGrilla()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.LightBlue400, Primary.Blue500, Primary.Blue500, Accent.Orange700, TextShade.WHITE);
            clienteService = new ClienteService();
            dgvClientes.DataSource = clienteService.ObtenerTodos();
        }

        private void BtnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow.DataBoundItem != null)
            {
                instanciaReserva.clienteSeleccionado = (Cliente) dgvClientes.CurrentRow.DataBoundItem;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente");
                return;
            }
            Close();
        }

        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            var cliente = new ModalHuesped();
            cliente.ShowDialog();
            dgvClientes.DataSource = clienteService.ObtenerTodos(); 
        }

        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != string.Empty)
            {

                dgvClientes.DataSource = clienteService.Busqueda(txtBuscar.Text);
            }
            else
            {
                dgvClientes.DataSource = clienteService.ObtenerTodos();
            }
        }
    }
}
