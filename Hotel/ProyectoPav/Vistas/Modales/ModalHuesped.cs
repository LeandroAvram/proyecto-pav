using MaterialSkin;
using MaterialSkin.Controls;
using Negocio.Servicios;
using Entidades;
using System.Drawing;
using System;
using System.Windows.Forms;

namespace ProyectoPav.Vistas.Modales
{
    public partial class ModalHuesped : MaterialForm
    {
        private FormMode formMode = FormMode.insert;
        private readonly ClienteService clienteService;
        private Cliente oClienteSelected;

        public ModalHuesped()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.LightBlue400, Primary.Blue500, Primary.Blue500, Accent.Orange700, TextShade.WHITE);
            clienteService = new ClienteService();
        }

        public void InicializarFormulario(FormMode op, Cliente clienteSelected)
        {
            formMode = op;
            oClienteSelected = clienteSelected;
        }

        public enum FormMode
        {
            insert,
            update
        }

        private void BtnRegistrarHuesped_Click(object sender, System.EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (true)//ExisteUsuario()==false
                        {
                            if (ValidarCampos())
                            {
                                var oCliente = new Cliente();
                                oCliente.Nombre = txtNombreCliente.Text;
                                oCliente.Apellido = txtApellidoCliente.Text;
                                oCliente.Telefono = txtTelefonoCliente.Text;
                                oCliente.Email = txtMailCliente.Text;
                                oCliente.NroDocumento = txtDocumentoCliente.Text;
                                oCliente.TipoDocumento = new TipoDocumento{
                                    Id = (int) comboTipoDocumento.SelectedValue
                                };

                                if (clienteService.CrearUsuario(oCliente))
                                {
                                    MessageBox.Show("Usuario insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Close();
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
                            oClienteSelected.Nombre = txtNombreCliente.Text;
                            oClienteSelected.Apellido = txtApellidoCliente.Text;
                            oClienteSelected.Telefono = txtTelefonoCliente.Text;
                            oClienteSelected.Email = txtMailCliente.Text;
                            oClienteSelected.NroDocumento =txtDocumentoCliente.Text;
                            oClienteSelected.TipoDocumento = new TipoDocumento
                            {
                                Id = (int)comboTipoDocumento.SelectedValue
                            };

                            if (clienteService.ActualActualizarCliente(oClienteSelected))
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

        private void ModalHuesped_Load(object sender, System.EventArgs e)
        {
            LlenarCombo(comboTipoDocumento, "T_Tipo_Documento", "id_tipo_documento", "nombre");
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Cliente";
                        break;
                    }
                case FormMode.update:
                    {
                        this.Text = "Actualizar Cliente";
                        this.btnRegistrarHuesped.Text = "Actualizar";
                        //Recuperar usuario seleccionado
                        MostrarDatos();
                        break;
                    }
            }
        }

        private void MostrarDatos()
        {
            if (oClienteSelected != null)
            {
                txtNombreCliente.Text = oClienteSelected.Nombre;
                txtApellidoCliente.Text = oClienteSelected.Apellido;
                txtTelefonoCliente.Text = oClienteSelected.Telefono.ToString();
                txtMailCliente.Text = oClienteSelected.Email;
                txtDocumentoCliente.Text = oClienteSelected.NroDocumento.ToString();
            }
        }

        private void LlenarCombo(ComboBox cbo, string tabla, string value, string display)
        {
            cbo.DataSource = clienteService.ComboTipoDocumento(tabla);
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
        }

        private bool ValidarCampos()
        {
            if (txtNombreCliente.Text == string.Empty)
            {
                txtNombreCliente.BackColor = Color.Red;
                txtNombreCliente.Focus();
                return false;
            }
            else
            {
                txtNombreCliente.BackColor = Color.White;
            }
            if (txtApellidoCliente.Text == string.Empty)
            {
                txtApellidoCliente.BackColor = Color.Red;
                txtApellidoCliente.Focus();
                return false;
            }
            else
            {
                txtApellidoCliente.BackColor = Color.White;
            }
            if (txtTelefonoCliente.Text == string.Empty)
            {
                txtTelefonoCliente.BackColor = Color.Red;
                txtTelefonoCliente.Focus();
                return false;
            }
            else
            {
                txtTelefonoCliente.BackColor = Color.White;
            }
            if (txtMailCliente.Text == string.Empty)
            {
                txtMailCliente.BackColor = Color.Red;
                txtMailCliente.Focus();
                return false;
            }
            else
            {
                txtMailCliente.BackColor = Color.White;
            }
            if (txtDocumentoCliente.Text == string.Empty)
            {
                txtDocumentoCliente.BackColor = Color.Red;
                txtDocumentoCliente.Focus();
                return false;
            }
            else
            {
                txtDocumentoCliente.BackColor = Color.White;
            }
            if (comboTipoDocumento.Text == string.Empty)
            {
                comboTipoDocumento.BackColor = Color.Red;
                comboTipoDocumento.Focus();
                return false;
            }
            else
            {
                comboTipoDocumento.BackColor = Color.White;
            }
            return true;
        }

        private void TxtMailCliente_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelarHuesped_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch.Equals('\b') || ch.Equals('\r'))
            {
                return;
            }
            if (txtNombreCliente.Text.Length > 30)
            {
                e.Handled = true;
            }
        }

        private void TxtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch.Equals('\b') || ch.Equals('\r'))
            {
                return;
            }
            if (txtApellidoCliente.Text.Length > 30)
            {
                e.Handled = true;
            }
        }

        private void TxtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch.Equals('\b') || ch.Equals('\r'))
            {
                return;
            }
            if (!char.IsDigit(ch) || txtTelefonoCliente.Text.Length > 15)
            {
                e.Handled = true;
            }
        }

        private void TxtMailCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch.Equals('\b') || ch.Equals('\r'))
            {
                return;
            }
            if (txtMailCliente.Text.Length > 45)
            {
                e.Handled = true;
            }
        }

        private void TxtDocumentoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch.Equals('\b') || ch.Equals('\r'))
            {
                return;
            }
            if (!char.IsDigit(ch) || txtDocumentoCliente.Text.Length > 9)
            {
                e.Handled = true;
            }
        }
    }
}
