namespace ProyectoPav.Vistas.Modales
{
    partial class ModalReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDocumento = new MaterialSkin.Controls.MaterialLabel();
            this.btnRegistrarReserva = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LblApellido = new MaterialSkin.Controls.MaterialLabel();
            this.LblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancelarReserva = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnIngresarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblTipo = new MaterialSkin.Controls.MaterialLabel();
            this.comboTipoReserva = new MetroFramework.Controls.MetroComboBox();
            this.lblRol = new MaterialSkin.Controls.MaterialLabel();
            this.datePickerIngreso = new MetroFramework.Controls.MetroDateTime();
            this.datePickerEgreso = new MetroFramework.Controls.MetroDateTime();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCantPersonas = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.BtnIngresarHabitacion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblCategoriaHabitacion = new MaterialSkin.Controls.MaterialLabel();
            this.lblTipoHabitacion = new MaterialSkin.Controls.MaterialLabel();
            this.lblPiso = new MaterialSkin.Controls.MaterialLabel();
            this.LblNumeroHabitacion = new MaterialSkin.Controls.MaterialLabel();
            this.txtMonto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.LblNombreCliente = new MaterialSkin.Controls.MaterialLabel();
            this.LblApellidoCliente = new MaterialSkin.Controls.MaterialLabel();
            this.LblNumeroDocumento = new MaterialSkin.Controls.MaterialLabel();
            this.LblTipoDocumento = new MaterialSkin.Controls.MaterialLabel();
            this.LblNroHabitacion = new MaterialSkin.Controls.MaterialLabel();
            this.LblPrecioHabitacion = new MaterialSkin.Controls.MaterialLabel();
            this.LblCatHabi = new MaterialSkin.Controls.MaterialLabel();
            this.LblTipoHab = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Depth = 0;
            this.lblDocumento.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDocumento.Location = new System.Drawing.Point(413, 185);
            this.lblDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(87, 19);
            this.lblDocumento.TabIndex = 126;
            this.lblDocumento.Text = "Documento";
            // 
            // btnRegistrarReserva
            // 
            this.btnRegistrarReserva.Depth = 0;
            this.btnRegistrarReserva.Location = new System.Drawing.Point(468, 560);
            this.btnRegistrarReserva.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarReserva.Name = "btnRegistrarReserva";
            this.btnRegistrarReserva.Primary = true;
            this.btnRegistrarReserva.Size = new System.Drawing.Size(126, 36);
            this.btnRegistrarReserva.TabIndex = 6;
            this.btnRegistrarReserva.Text = "Registrar";
            this.btnRegistrarReserva.UseVisualStyleBackColor = true;
            this.btnRegistrarReserva.Click += new System.EventHandler(this.BtnRegistrarReserva_Click);
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Depth = 0;
            this.LblApellido.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblApellido.Location = new System.Drawing.Point(34, 185);
            this.LblApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(64, 19);
            this.LblApellido.TabIndex = 120;
            this.LblApellido.Text = "Apellido";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Depth = 0;
            this.LblNombre.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblNombre.Location = new System.Drawing.Point(35, 144);
            this.LblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(63, 19);
            this.LblNombre.TabIndex = 119;
            this.LblNombre.Text = "Nombre";
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.AutoSize = true;
            this.btnCancelarReserva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelarReserva.Depth = 0;
            this.btnCancelarReserva.Location = new System.Drawing.Point(614, 560);
            this.btnCancelarReserva.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelarReserva.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Primary = false;
            this.btnCancelarReserva.Size = new System.Drawing.Size(82, 36);
            this.btnCancelarReserva.TabIndex = 7;
            this.btnCancelarReserva.Text = "Cancelar";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // BtnIngresarCliente
            // 
            this.BtnIngresarCliente.Depth = 0;
            this.BtnIngresarCliente.Location = new System.Drawing.Point(39, 85);
            this.BtnIngresarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnIngresarCliente.Name = "BtnIngresarCliente";
            this.BtnIngresarCliente.Primary = true;
            this.BtnIngresarCliente.Size = new System.Drawing.Size(113, 39);
            this.BtnIngresarCliente.TabIndex = 1;
            this.BtnIngresarCliente.Text = "Ingresar Cliente";
            this.BtnIngresarCliente.UseVisualStyleBackColor = true;
            this.BtnIngresarCliente.Click += new System.EventHandler(this.BtnIngresarCliente_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Depth = 0;
            this.lblTipo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTipo.Location = new System.Drawing.Point(379, 144);
            this.lblTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(121, 19);
            this.lblTipo.TabIndex = 130;
            this.lblTipo.Text = "Tipo Documento";
            // 
            // comboTipoReserva
            // 
            this.comboTipoReserva.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboTipoReserva.FormattingEnabled = true;
            this.comboTipoReserva.IntegralHeight = false;
            this.comboTipoReserva.ItemHeight = 23;
            this.comboTipoReserva.Location = new System.Drawing.Point(158, 404);
            this.comboTipoReserva.Name = "comboTipoReserva";
            this.comboTipoReserva.Size = new System.Drawing.Size(215, 29);
            this.comboTipoReserva.TabIndex = 3;
            this.comboTipoReserva.UseSelectable = true;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Depth = 0;
            this.lblRol.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRol.Location = new System.Drawing.Point(56, 409);
            this.lblRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(96, 19);
            this.lblRol.TabIndex = 131;
            this.lblRol.Text = "Tipo Reserva";
            // 
            // datePickerIngreso
            // 
            this.datePickerIngreso.Location = new System.Drawing.Point(173, 459);
            this.datePickerIngreso.MinimumSize = new System.Drawing.Size(0, 29);
            this.datePickerIngreso.Name = "datePickerIngreso";
            this.datePickerIngreso.Size = new System.Drawing.Size(200, 29);
            this.datePickerIngreso.TabIndex = 133;
            // 
            // datePickerEgreso
            // 
            this.datePickerEgreso.Location = new System.Drawing.Point(173, 521);
            this.datePickerEgreso.MinimumSize = new System.Drawing.Size(0, 29);
            this.datePickerEgreso.Name = "datePickerEgreso";
            this.datePickerEgreso.Size = new System.Drawing.Size(200, 29);
            this.datePickerEgreso.TabIndex = 134;
            this.datePickerEgreso.ValueChanged += new System.EventHandler(this.MetroDateTime2_ValueChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(43, 464);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(123, 19);
            this.materialLabel1.TabIndex = 135;
            this.materialLabel1.Text = "Fecha de ingreso";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(44, 526);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(119, 19);
            this.materialLabel2.TabIndex = 136;
            this.materialLabel2.Text = "Fecha de egreso";
            // 
            // txtCantPersonas
            // 
            this.txtCantPersonas.Depth = 0;
            this.txtCantPersonas.Hint = "";
            this.txtCantPersonas.Location = new System.Drawing.Point(429, 424);
            this.txtCantPersonas.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCantPersonas.Name = "txtCantPersonas";
            this.txtCantPersonas.PasswordChar = '\0';
            this.txtCantPersonas.SelectedText = "";
            this.txtCantPersonas.SelectionLength = 0;
            this.txtCantPersonas.SelectionStart = 0;
            this.txtCantPersonas.Size = new System.Drawing.Size(215, 23);
            this.txtCantPersonas.TabIndex = 4;
            this.txtCantPersonas.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(425, 392);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(126, 19);
            this.materialLabel3.TabIndex = 138;
            this.materialLabel3.Text = "Cant de personas";
            // 
            // BtnIngresarHabitacion
            // 
            this.BtnIngresarHabitacion.Depth = 0;
            this.BtnIngresarHabitacion.Location = new System.Drawing.Point(39, 227);
            this.BtnIngresarHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnIngresarHabitacion.Name = "BtnIngresarHabitacion";
            this.BtnIngresarHabitacion.Primary = true;
            this.BtnIngresarHabitacion.Size = new System.Drawing.Size(113, 39);
            this.BtnIngresarHabitacion.TabIndex = 2;
            this.BtnIngresarHabitacion.Text = "Ingresar Habitacion";
            this.BtnIngresarHabitacion.UseVisualStyleBackColor = true;
            this.BtnIngresarHabitacion.Click += new System.EventHandler(this.BtnIngresarHabitacion_Click);
            // 
            // lblCategoriaHabitacion
            // 
            this.lblCategoriaHabitacion.AutoSize = true;
            this.lblCategoriaHabitacion.Depth = 0;
            this.lblCategoriaHabitacion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategoriaHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategoriaHabitacion.Location = new System.Drawing.Point(325, 330);
            this.lblCategoriaHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoriaHabitacion.Name = "lblCategoriaHabitacion";
            this.lblCategoriaHabitacion.Size = new System.Drawing.Size(74, 19);
            this.lblCategoriaHabitacion.TabIndex = 146;
            this.lblCategoriaHabitacion.Text = "Categoria";
            // 
            // lblTipoHabitacion
            // 
            this.lblTipoHabitacion.AutoSize = true;
            this.lblTipoHabitacion.Depth = 0;
            this.lblTipoHabitacion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTipoHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTipoHabitacion.Location = new System.Drawing.Point(283, 288);
            this.lblTipoHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipoHabitacion.Name = "lblTipoHabitacion";
            this.lblTipoHabitacion.Size = new System.Drawing.Size(116, 19);
            this.lblTipoHabitacion.TabIndex = 144;
            this.lblTipoHabitacion.Text = "Tipo Habitacion";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Depth = 0;
            this.lblPiso.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPiso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPiso.Location = new System.Drawing.Point(55, 330);
            this.lblPiso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(52, 19);
            this.lblPiso.TabIndex = 142;
            this.lblPiso.Text = "Precio";
            // 
            // LblNumeroHabitacion
            // 
            this.LblNumeroHabitacion.AutoSize = true;
            this.LblNumeroHabitacion.Depth = 0;
            this.LblNumeroHabitacion.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblNumeroHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblNumeroHabitacion.Location = new System.Drawing.Point(44, 288);
            this.LblNumeroHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblNumeroHabitacion.Name = "LblNumeroHabitacion";
            this.LblNumeroHabitacion.Size = new System.Drawing.Size(63, 19);
            this.LblNumeroHabitacion.TabIndex = 140;
            this.LblNumeroHabitacion.Text = "Numero";
            // 
            // txtMonto
            // 
            this.txtMonto.Depth = 0;
            this.txtMonto.Hint = "";
            this.txtMonto.Location = new System.Drawing.Point(549, 486);
            this.txtMonto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PasswordChar = '\0';
            this.txtMonto.SelectedText = "";
            this.txtMonto.SelectionLength = 0;
            this.txtMonto.SelectionStart = 0;
            this.txtMonto.Size = new System.Drawing.Size(114, 23);
            this.txtMonto.TabIndex = 5;
            this.txtMonto.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(425, 486);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(107, 19);
            this.materialLabel4.TabIndex = 149;
            this.materialLabel4.Text = "Monto a Pagar";
            // 
            // LblNombreCliente
            // 
            this.LblNombreCliente.AutoSize = true;
            this.LblNombreCliente.Depth = 0;
            this.LblNombreCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblNombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblNombreCliente.Location = new System.Drawing.Point(126, 144);
            this.LblNombreCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblNombreCliente.Name = "LblNombreCliente";
            this.LblNombreCliente.Size = new System.Drawing.Size(0, 19);
            this.LblNombreCliente.TabIndex = 150;
            // 
            // LblApellidoCliente
            // 
            this.LblApellidoCliente.AutoSize = true;
            this.LblApellidoCliente.Depth = 0;
            this.LblApellidoCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblApellidoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblApellidoCliente.Location = new System.Drawing.Point(126, 185);
            this.LblApellidoCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblApellidoCliente.Name = "LblApellidoCliente";
            this.LblApellidoCliente.Size = new System.Drawing.Size(0, 19);
            this.LblApellidoCliente.TabIndex = 151;
            // 
            // LblNumeroDocumento
            // 
            this.LblNumeroDocumento.AutoSize = true;
            this.LblNumeroDocumento.Depth = 0;
            this.LblNumeroDocumento.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblNumeroDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblNumeroDocumento.Location = new System.Drawing.Point(519, 185);
            this.LblNumeroDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblNumeroDocumento.Name = "LblNumeroDocumento";
            this.LblNumeroDocumento.Size = new System.Drawing.Size(0, 19);
            this.LblNumeroDocumento.TabIndex = 153;
            // 
            // LblTipoDocumento
            // 
            this.LblTipoDocumento.AutoSize = true;
            this.LblTipoDocumento.Depth = 0;
            this.LblTipoDocumento.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblTipoDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTipoDocumento.Location = new System.Drawing.Point(519, 144);
            this.LblTipoDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTipoDocumento.Name = "LblTipoDocumento";
            this.LblTipoDocumento.Size = new System.Drawing.Size(0, 19);
            this.LblTipoDocumento.TabIndex = 152;
            // 
            // LblNroHabitacion
            // 
            this.LblNroHabitacion.AutoSize = true;
            this.LblNroHabitacion.Depth = 0;
            this.LblNroHabitacion.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblNroHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblNroHabitacion.Location = new System.Drawing.Point(126, 288);
            this.LblNroHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblNroHabitacion.Name = "LblNroHabitacion";
            this.LblNroHabitacion.Size = new System.Drawing.Size(0, 19);
            this.LblNroHabitacion.TabIndex = 154;
            // 
            // LblPrecioHabitacion
            // 
            this.LblPrecioHabitacion.AutoSize = true;
            this.LblPrecioHabitacion.Depth = 0;
            this.LblPrecioHabitacion.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblPrecioHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblPrecioHabitacion.Location = new System.Drawing.Point(126, 330);
            this.LblPrecioHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblPrecioHabitacion.Name = "LblPrecioHabitacion";
            this.LblPrecioHabitacion.Size = new System.Drawing.Size(0, 19);
            this.LblPrecioHabitacion.TabIndex = 155;
            // 
            // LblCatHabi
            // 
            this.LblCatHabi.AutoSize = true;
            this.LblCatHabi.Depth = 0;
            this.LblCatHabi.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblCatHabi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblCatHabi.Location = new System.Drawing.Point(413, 330);
            this.LblCatHabi.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCatHabi.Name = "LblCatHabi";
            this.LblCatHabi.Size = new System.Drawing.Size(0, 19);
            this.LblCatHabi.TabIndex = 157;
            // 
            // LblTipoHab
            // 
            this.LblTipoHab.AutoSize = true;
            this.LblTipoHab.Depth = 0;
            this.LblTipoHab.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblTipoHab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTipoHab.Location = new System.Drawing.Point(413, 288);
            this.LblTipoHab.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTipoHab.Name = "LblTipoHab";
            this.LblTipoHab.Size = new System.Drawing.Size(0, 19);
            this.LblTipoHab.TabIndex = 156;
            // 
            // ModalReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 611);
            this.Controls.Add(this.LblCatHabi);
            this.Controls.Add(this.LblTipoHab);
            this.Controls.Add(this.LblPrecioHabitacion);
            this.Controls.Add(this.LblNroHabitacion);
            this.Controls.Add(this.LblNumeroDocumento);
            this.Controls.Add(this.LblTipoDocumento);
            this.Controls.Add(this.LblApellidoCliente);
            this.Controls.Add(this.LblNombreCliente);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.lblCategoriaHabitacion);
            this.Controls.Add(this.lblTipoHabitacion);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.LblNumeroHabitacion);
            this.Controls.Add(this.BtnIngresarHabitacion);
            this.Controls.Add(this.txtCantPersonas);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.datePickerEgreso);
            this.Controls.Add(this.datePickerIngreso);
            this.Controls.Add(this.comboTipoReserva);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.BtnIngresarCliente);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.btnRegistrarReserva);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.Name = "ModalReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModalReserva";
            this.Load += new System.EventHandler(this.ModalReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblDocumento;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegistrarReserva;
        private MaterialSkin.Controls.MaterialLabel LblApellido;
        private MaterialSkin.Controls.MaterialLabel LblNombre;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelarReserva;
        private MaterialSkin.Controls.MaterialRaisedButton BtnIngresarCliente;
        private MaterialSkin.Controls.MaterialLabel lblTipo;
        private MetroFramework.Controls.MetroComboBox comboTipoReserva;
        private MaterialSkin.Controls.MaterialLabel lblRol;
        private MetroFramework.Controls.MetroDateTime datePickerIngreso;
        private MetroFramework.Controls.MetroDateTime datePickerEgreso;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCantPersonas;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton BtnIngresarHabitacion;
        private MaterialSkin.Controls.MaterialLabel lblCategoriaHabitacion;
        private MaterialSkin.Controls.MaterialLabel lblTipoHabitacion;
        private MaterialSkin.Controls.MaterialLabel lblPiso;
        private MaterialSkin.Controls.MaterialLabel LblNumeroHabitacion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMonto;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel LblNombreCliente;
        private MaterialSkin.Controls.MaterialLabel LblApellidoCliente;
        private MaterialSkin.Controls.MaterialLabel LblNumeroDocumento;
        private MaterialSkin.Controls.MaterialLabel LblTipoDocumento;
        private MaterialSkin.Controls.MaterialLabel LblNroHabitacion;
        private MaterialSkin.Controls.MaterialLabel LblPrecioHabitacion;
        private MaterialSkin.Controls.MaterialLabel LblCatHabi;
        private MaterialSkin.Controls.MaterialLabel LblTipoHab;
    }
}