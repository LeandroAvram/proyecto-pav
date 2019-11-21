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
using Entidades;

namespace ProyectoPav.Vistas
{
    public partial class Usuarios : MaterialForm
    {
        private UsuarioService oUserService;
        public Usuarios()
        {
            oUserService = new UsuarioService();
            InitializeComponent();
            //InitializeDataGridView();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue400, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, Accent.Orange700, MaterialSkin.TextShade.WHITE);

            dgvUsers.DataSource = oUserService.ObtenerTodos();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MetroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            Vistas.Modales.ModalUsuario user = new Vistas.Modales.ModalUsuario();
            user.ShowDialog();
            dgvUsers.DataSource = oUserService.ObtenerTodos();
        }

        private void JFlatButton2_Click(object sender, EventArgs e)
        {
            Vistas.Modales.ModalUsuario form = new Vistas.Modales.ModalUsuario();
            var usuario = (Usuario)dgvUsers.CurrentRow.DataBoundItem;
            form.InicializarFormulario(Modales.ModalUsuario.FormMode.update, usuario);
            form.ShowDialog();
            dgvUsers.DataSource = oUserService.ObtenerTodos();
        }

        private void BtnEliminarUsuario_Click(object sender, EventArgs e)
        {
            var usuario = (Usuario)dgvUsers.CurrentRow.DataBoundItem;
            if (MessageBox.Show("Seguro que desea habilitar/deshabilitar el usuario seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (oUserService.ModificarEstadoUsuario(usuario))
                {
                    MessageBox.Show("Usuario Habilitado/Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvUsers.DataSource = oUserService.ObtenerTodos();
                }
                else
                    MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscar.Text != string.Empty)
            {

                dgvUsers.DataSource = oUserService.Busqueda(txtBuscar.Text);
            }else
            {
                dgvUsers.DataSource = oUserService.ObtenerTodos();
            }
        }
    }
}
