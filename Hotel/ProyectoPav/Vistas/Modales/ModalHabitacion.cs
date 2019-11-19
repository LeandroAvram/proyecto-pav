using Entidades;
using MaterialSkin;
using MaterialSkin.Controls;
using Negocio.Servicios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoPav.Vistas.Modales
{
    public partial class ModalHabitacion : MaterialForm
    {
        private FormMode formMode = FormMode.insert;
        private readonly HabitacionService habService;
        private Entidades.Habitacion oHabitacion;


        public ModalHabitacion()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.LightBlue400, Primary.Blue500, Primary.Blue500, Accent.Orange700, TextShade.WHITE);
            habService = new HabitacionService();
        }
        public enum FormMode
        {
            insert,
            update,
            delete
        }

        private void ModalHabitacion_Load(object sender, System.EventArgs e)
        {
            LlenarCombo(comboEstadoHabitacion, "T_Estado_Habitacion", "id_estado_habitacion", "nombre");
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nueva Habitacion";
                        break;
                    }
                case FormMode.update:
                    {
                        this.Text = "Actualizar habitacion";
                        this.btnRegistrarHabitacion.Text = "Actualizar";
                        //Recuperar usuario seleccionado
                        MostrarDatos();
                        break;
                    }

            }

            LlenarCombo(comboCategoriaHabitacion, "T_Categoria_Habitacion", "id_cat_habitacion", "nombre");
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nueva Habitacion";
                        break;
                    }
                case FormMode.update:
                    {
                        this.Text = "Actualizar habitacion";
                        this.btnRegistrarHabitacion.Text = "Actualizar";
                        //Recuperar usuario seleccionado
                        MostrarDatos();
                        break;
                    }

            }

            LlenarCombo(comboTipoHabitacion, "T_Tipo_Habitacion", "id_tipo_habitacion", "nombre");
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nueva Habitacion";
                        break;
                    }
                case FormMode.update:
                    {
                        this.Text = "Actualizar habitacion";
                        this.btnRegistrarHabitacion.Text = "Actualizar";
                        //Recuperar usuario seleccionado
                        MostrarDatos();
                        break;
                    }

            }

        }

        public void InicializarFormulario(FormMode op, Habitacion habitacionSelec)
        {
            formMode = op;
            oHabitacion = habitacionSelec;
        }

        private void MostrarDatos()
        {
            if (oHabitacion != null)
            {
                txtNumeroHabitacion.Text = oHabitacion.Id_habitacion.ToString();
                txtPrecio.Text = oHabitacion.precio.ToString();
                comboEstadoHabitacion.Text = oHabitacion.estadoHab.nombre;
                comboCategoriaHabitacion.Text = oHabitacion.catHab.nombre;
                comboTipoHabitacion.Text = oHabitacion.tipoHab.nombre;
            }
        }
        private void LlenarCombo(ComboBox cbo, string tabla, string value, string display)
        {
            //cbo.DataSource = habService.combpgetCombOCategoria(tabla);
            //cbo.DataSource = habService.getCombOEstado(tabla);
            cbo.DataSource = habService.getCombOTipoHab(tabla);
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void BtnRegistrarHabitacion_Click(object sender, System.EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                       
                        if (true)//ExisteUsuario()==false
                        {
                            if (ValidarCampos())
                            {
                                var ohabit = new Habitacion();
                                ohabit.nro_habitacion = Int32.Parse(txtNumeroHabitacion.Text);
                                ohabit.precio = Int32.Parse(txtPrecio.Text);
                                ohabit.tipoHab = new TipoHabitacion();
                                ohabit.tipoHab.id_tipo_habitacion = (int)comboTipoHabitacion.SelectedValue;
                                ohabit.catHab = new Cathabitacion();
                                ohabit.catHab.id_cat_habitacion = (int)comboCategoriaHabitacion.SelectedValue;
                                ohabit.estadoHab = new Estadohabit();
                                ohabit.estadoHab.id_estado_habitacion = (int)comboEstadoHabitacion.SelectedValue;

                                if (habService.CrearHabitacion(ohabit))
                                {
                                    MessageBox.Show("Habitacion insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //Vistas.Usuarios.dgvUsers.DataSource = oUserService.ObtenerTodos();
                                    this.Close();
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("Numero de habitacion encontrado!. Ingrese un numero diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {

                            var ohabit = new Habitacion();
                            ohabit.nro_habitacion = Int32.Parse(txtNumeroHabitacion.Text);
                            ohabit.precio = Int32.Parse(txtPrecio.Text);
                            ohabit.tipoHab = new TipoHabitacion();
                            ohabit.tipoHab.id_tipo_habitacion = (int)comboTipoHabitacion.SelectedValue;
                            ohabit.catHab = new Cathabitacion();
                            ohabit.catHab.id_cat_habitacion = (int)comboCategoriaHabitacion.SelectedValue;
                            ohabit.estadoHab = new Estadohabit();
                            ohabit.estadoHab.id_estado_habitacion = (int)comboEstadoHabitacion.SelectedValue;

                            if (habService.ActualizarHabitacion(ohabit))
                            {
                                MessageBox.Show("Habitacion actualizada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar la habitacion!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
            }
        }

        private bool ValidarCampos()
        {
            if (txtNumeroHabitacion.Text == string.Empty)
            {
                txtNumeroHabitacion.BackColor = Color.Red;
                txtNumeroHabitacion.Focus();
                return false;
            }
            else
            {
                txtNumeroHabitacion.BackColor = Color.White;
            }
            if (txtPrecio.Text == string.Empty)
            {
                txtPrecio.BackColor = Color.Red;
                txtPrecio.Focus();
                return false;
            }
            else
            {
                txtPrecio.BackColor = Color.White;
            }
            

            
          if (comboEstadoHabitacion.Text == string.Empty)
            {
                comboEstadoHabitacion.BackColor = Color.Red;
                comboEstadoHabitacion.Focus();
                return false;
            }
            else
            {
                comboEstadoHabitacion.BackColor = Color.White;
            }

            if (comboCategoriaHabitacion.Text == string.Empty)
            {
                comboCategoriaHabitacion.BackColor = Color.Red;
                comboCategoriaHabitacion.Focus();
                return false;
            }
            else
            {
                comboCategoriaHabitacion.BackColor = Color.White;
            }

            if (comboTipoHabitacion.Text == string.Empty)
            {
                comboTipoHabitacion.BackColor = Color.Red;
                comboTipoHabitacion.Focus();
                return false;
            }
            else
            {
                comboTipoHabitacion.BackColor = Color.White;
            }

            return true;
        }

        private void TxtNumeroHabitacion_Click(object sender, EventArgs e)
        {

        }

        private void TxtNumeroHabitacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch.Equals('\b') || ch.Equals('\r'))
            {
                return;
            }
            if (!char.IsDigit(ch) || txtNumeroHabitacion.Text.Length > 7)
            {
                e.Handled = true;
            }
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch.Equals('\b') || ch.Equals('\r'))
            {
                return;
            }
            if (!char.IsDigit(ch) || txtPrecio.Text.Length > 8)
            {
                e.Handled = true;
            }
        }

        private void BtnCancelarHabitacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
