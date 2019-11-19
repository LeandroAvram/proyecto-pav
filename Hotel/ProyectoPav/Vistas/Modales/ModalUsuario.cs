using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using Negocio.Servicios;
using Entidades;
using System.Drawing;
using System;

namespace ProyectoPav.Vistas.Modales
{
    public partial class ModalUsuario : MaterialForm
    {
        private FormMode formMode = FormMode.insert;
        private readonly UsuarioService userService;
        private Usuario oUsuarioSelected;
        public ModalUsuario()
        {
  
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.LightBlue400, Primary.Blue500, Primary.Blue500, Accent.Orange700, TextShade.WHITE);
            userService = new UsuarioService();
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }

        private void ModalUsuario_Load(object sender, System.EventArgs e)
        {
            LlenarCombo(comboRolUsuario, "T_Rol", "id_rol", "nombre");
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Usuario";
                        break;
                    }
                case FormMode.update:
                    {
                        this.Text = "Actualizar Usuario";
                        this.btnModalUsuario.Text = "Actualizar";
                        //Recuperar usuario seleccionado
                        MostrarDatos();
                        break;
                    }
            }
        }

        public void InicializarFormulario(FormMode op, Usuario usuarioSelected)
        {
            formMode = op;
            oUsuarioSelected = usuarioSelected;
        }

        private void MostrarDatos()
        {
            if(oUsuarioSelected != null)
            {
                txtNombreUsuario.Text = oUsuarioSelected.nombre;
                txtApellidoUsuario.Text = oUsuarioSelected.apellido;
                txtTelefonoUsuario.Text = oUsuarioSelected.telefono.ToString();
                txtMailUsuario.Text = oUsuarioSelected.email;
                txtPassUsuario.Text = oUsuarioSelected.pass;
                comboRolUsuario.Text = oUsuarioSelected.rolUsuario.Nombre;
            }
        }

        private void LlenarCombo(ComboBox cbo, string tabla, string value, string display)
        {
            cbo.DataSource = userService.ComboRol(tabla);
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
        }

        private void MaterialSingleLineTextField3_Click(object sender, System.EventArgs e)
        {

        }

        private void BtnRegistrarUsuario_Click(object sender, System.EventArgs e)
        {
       
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if(true)//ExisteUsuario()==false
                        {
                            if(ValidarCampos())
                            {
                                var oUsuario = new Usuario();
                                oUsuario.nombre = txtNombreUsuario.Text;
                                oUsuario.apellido = txtApellidoUsuario.Text;
                                oUsuario.telefono = txtTelefonoUsuario.Text;
                                oUsuario.email = txtMailUsuario.Text;
                                oUsuario.pass = txtPassUsuario.Text;
                                oUsuario.rolUsuario = new RolUsuario();
                                oUsuario.rolUsuario.IdRolUsuario = (int)comboRolUsuario.SelectedValue;

                                if(userService.CrearUsuario(oUsuario))
                                {
                                    MessageBox.Show("Usuario insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //Vistas.Usuarios.dgvUsers.DataSource = oUserService.ObtenerTodos();
                                    Close();
                                }
                                else
                                {
                                    MessageBox.Show("Usuario no insertado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("Nombre de usuario encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            oUsuarioSelected.nombre = txtNombreUsuario.Text;
                            oUsuarioSelected.apellido = txtApellidoUsuario.Text;
                            oUsuarioSelected.telefono = txtTelefonoUsuario.Text;
                            oUsuarioSelected.email = txtMailUsuario.Text;
                            oUsuarioSelected.pass = txtPassUsuario.Text;
                            oUsuarioSelected.rolUsuario.IdRolUsuario = (int)comboRolUsuario.SelectedValue;

                            if (userService.ActualActualizarUsuario(oUsuarioSelected))
                            {
                                MessageBox.Show("Usuario actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
            }
        }


        private bool ValidarCampos()
        {
            if(txtNombreUsuario.Text == string.Empty)
            {
                txtNombreUsuario.BackColor = Color.Red;
                txtNombreUsuario.Focus();
                return false;
            }
            else
            {
                txtNombreUsuario.BackColor = Color.White;
            }
            if(txtApellidoUsuario.Text == string.Empty)
            {
                txtApellidoUsuario.BackColor = Color.Red;
                txtApellidoUsuario.Focus();
                return false;
            }
            else
            {
                txtApellidoUsuario.BackColor = Color.White;
            }
            if (txtTelefonoUsuario.Text == string.Empty)
            {
                txtTelefonoUsuario.BackColor = Color.Red;
                txtTelefonoUsuario.Focus();
                return false;
            }
            else
            {
                txtTelefonoUsuario.BackColor = Color.White;
            }
            if (txtMailUsuario.Text == string.Empty)
            {
                txtMailUsuario.BackColor = Color.Red;
                txtMailUsuario.Focus();
                return false;
            }
            else
            {
                txtMailUsuario.BackColor = Color.White;
            }
            if (txtPassUsuario.Text == string.Empty)
            {
                txtPassUsuario.BackColor = Color.Red;
                txtPassUsuario.Focus();
                return false;
            }
            else
            {
                txtPassUsuario.BackColor = Color.White;
            }
            if (comboRolUsuario.Text == string.Empty)
            {
                comboRolUsuario.BackColor = Color.Red;
                comboRolUsuario.Focus();
                return false;
            }
            else
            {
                comboRolUsuario.BackColor = Color.White;
            }
            return true;
        }

        private void TxtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch.Equals('\b') || ch.Equals('\r'))
            {
                return;
            }
            if (!char.IsDigit(ch))
            {
                return;
            }
            if (txtNombreUsuario.Text.Length > 15)
            {
                e.Handled = true;
            }
        }

        private void TxtApellidoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch.Equals('\b') || ch.Equals('\r'))
            {
                return;
            }
            if (txtApellidoUsuario.Text.Length > 30)
            {
                e.Handled = true;
            }
        }

        private void TxtTelefonoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch.Equals('\b') || ch.Equals('\r'))
            {
                return;
            }
            if (!char.IsDigit(ch) || txtTelefonoUsuario.Text.Length > 15)
            {
                e.Handled = true;
            }
        }

        private void TxtMailUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch.Equals('\b') || ch.Equals('\r'))
            {
                return;
            }
            if (txtMailUsuario.Text.Length > 45)
            {
                e.Handled = true;
            }
        }

        private void TxtPassUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch.Equals('\b') || ch.Equals('\r'))
            {
                return;
            }
            if (txtPassUsuario.Text.Length > 30)
            {
                e.Handled = true;
            }
        }

        private void BtnCancelarUsuario_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
