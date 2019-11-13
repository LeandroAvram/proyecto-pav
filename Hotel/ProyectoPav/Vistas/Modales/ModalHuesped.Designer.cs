namespace ProyectoPav.Vistas.Modales
{
    partial class ModalHuesped
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
            MaterialSkin.Controls.MaterialDivider materialDivider1;
            this.txtDocumentoCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDocumento = new MaterialSkin.Controls.MaterialLabel();
            this.txtTelefonoCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTelefono = new MaterialSkin.Controls.MaterialLabel();
            this.lblDatosHuesped = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancelarHuesped = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRegistrarHuesped = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboTipoDocumento = new MetroFramework.Controls.MetroComboBox();
            this.txtMailCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtApellidoCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTipo = new MaterialSkin.Controls.MaterialLabel();
            this.LblMail = new MaterialSkin.Controls.MaterialLabel();
            this.LblApellido = new MaterialSkin.Controls.MaterialLabel();
            this.LblNombre = new MaterialSkin.Controls.MaterialLabel();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            materialDivider1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            materialDivider1.CausesValidation = false;
            materialDivider1.Depth = 0;
            materialDivider1.Location = new System.Drawing.Point(366, 114);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new System.Drawing.Size(2, 125);
            materialDivider1.TabIndex = 107;
            materialDivider1.TabStop = false;
            // 
            // txtDocumentoCliente
            // 
            this.txtDocumentoCliente.Depth = 0;
            this.txtDocumentoCliente.Hint = "";
            this.txtDocumentoCliente.Location = new System.Drawing.Point(520, 204);
            this.txtDocumentoCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDocumentoCliente.Name = "txtDocumentoCliente";
            this.txtDocumentoCliente.PasswordChar = '\0';
            this.txtDocumentoCliente.SelectedText = "";
            this.txtDocumentoCliente.SelectionLength = 0;
            this.txtDocumentoCliente.SelectionStart = 0;
            this.txtDocumentoCliente.Size = new System.Drawing.Size(215, 23);
            this.txtDocumentoCliente.TabIndex = 6;
            this.txtDocumentoCliente.UseSystemPasswordChar = false;
            this.txtDocumentoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDocumentoCliente_KeyPress);
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Depth = 0;
            this.lblDocumento.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDocumento.Location = new System.Drawing.Point(395, 204);
            this.lblDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(87, 19);
            this.lblDocumento.TabIndex = 110;
            this.lblDocumento.Text = "Documento";
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Depth = 0;
            this.txtTelefonoCliente.Hint = "";
            this.txtTelefonoCliente.Location = new System.Drawing.Point(119, 205);
            this.txtTelefonoCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.PasswordChar = '\0';
            this.txtTelefonoCliente.SelectedText = "";
            this.txtTelefonoCliente.SelectionLength = 0;
            this.txtTelefonoCliente.SelectionStart = 0;
            this.txtTelefonoCliente.Size = new System.Drawing.Size(215, 23);
            this.txtTelefonoCliente.TabIndex = 3;
            this.txtTelefonoCliente.UseSystemPasswordChar = false;
            this.txtTelefonoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefonoCliente_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Depth = 0;
            this.lblTelefono.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTelefono.Location = new System.Drawing.Point(22, 205);
            this.lblTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(69, 19);
            this.lblTelefono.TabIndex = 108;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDatosHuesped
            // 
            this.lblDatosHuesped.AutoSize = true;
            this.lblDatosHuesped.Depth = 0;
            this.lblDatosHuesped.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDatosHuesped.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDatosHuesped.Location = new System.Drawing.Point(22, 82);
            this.lblDatosHuesped.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDatosHuesped.Name = "lblDatosHuesped";
            this.lblDatosHuesped.Size = new System.Drawing.Size(128, 19);
            this.lblDatosHuesped.TabIndex = 105;
            this.lblDatosHuesped.Text = "Datos Personales";
            // 
            // btnCancelarHuesped
            // 
            this.btnCancelarHuesped.AutoSize = true;
            this.btnCancelarHuesped.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelarHuesped.Depth = 0;
            this.btnCancelarHuesped.Location = new System.Drawing.Point(653, 261);
            this.btnCancelarHuesped.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelarHuesped.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelarHuesped.Name = "btnCancelarHuesped";
            this.btnCancelarHuesped.Primary = false;
            this.btnCancelarHuesped.Size = new System.Drawing.Size(82, 36);
            this.btnCancelarHuesped.TabIndex = 8;
            this.btnCancelarHuesped.Text = "Cancelar";
            this.btnCancelarHuesped.UseVisualStyleBackColor = true;
            this.btnCancelarHuesped.Click += new System.EventHandler(this.BtnCancelarHuesped_Click);
            // 
            // btnRegistrarHuesped
            // 
            this.btnRegistrarHuesped.Depth = 0;
            this.btnRegistrarHuesped.Location = new System.Drawing.Point(520, 261);
            this.btnRegistrarHuesped.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarHuesped.Name = "btnRegistrarHuesped";
            this.btnRegistrarHuesped.Primary = true;
            this.btnRegistrarHuesped.Size = new System.Drawing.Size(126, 36);
            this.btnRegistrarHuesped.TabIndex = 7;
            this.btnRegistrarHuesped.Text = "Registrar";
            this.btnRegistrarHuesped.UseVisualStyleBackColor = true;
            this.btnRegistrarHuesped.Click += new System.EventHandler(this.BtnRegistrarHuesped_Click);
            // 
            // comboTipoDocumento
            // 
            this.comboTipoDocumento.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboTipoDocumento.FormattingEnabled = true;
            this.comboTipoDocumento.IntegralHeight = false;
            this.comboTipoDocumento.ItemHeight = 23;
            this.comboTipoDocumento.Location = new System.Drawing.Point(520, 163);
            this.comboTipoDocumento.Name = "comboTipoDocumento";
            this.comboTipoDocumento.Size = new System.Drawing.Size(215, 29);
            this.comboTipoDocumento.TabIndex = 5;
            this.comboTipoDocumento.UseSelectable = true;
            // 
            // txtMailCliente
            // 
            this.txtMailCliente.Depth = 0;
            this.txtMailCliente.Hint = "";
            this.txtMailCliente.Location = new System.Drawing.Point(520, 122);
            this.txtMailCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMailCliente.Name = "txtMailCliente";
            this.txtMailCliente.PasswordChar = '\0';
            this.txtMailCliente.SelectedText = "";
            this.txtMailCliente.SelectionLength = 0;
            this.txtMailCliente.SelectionStart = 0;
            this.txtMailCliente.Size = new System.Drawing.Size(215, 23);
            this.txtMailCliente.TabIndex = 4;
            this.txtMailCliente.UseSystemPasswordChar = false;
            this.txtMailCliente.Click += new System.EventHandler(this.TxtMailCliente_Click);
            this.txtMailCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMailCliente_KeyPress);
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Depth = 0;
            this.txtApellidoCliente.Hint = "";
            this.txtApellidoCliente.Location = new System.Drawing.Point(119, 163);
            this.txtApellidoCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.PasswordChar = '\0';
            this.txtApellidoCliente.SelectedText = "";
            this.txtApellidoCliente.SelectionLength = 0;
            this.txtApellidoCliente.SelectionStart = 0;
            this.txtApellidoCliente.Size = new System.Drawing.Size(215, 23);
            this.txtApellidoCliente.TabIndex = 2;
            this.txtApellidoCliente.UseSystemPasswordChar = false;
            this.txtApellidoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidoCliente_KeyPress);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Depth = 0;
            this.txtNombreCliente.Hint = "";
            this.txtNombreCliente.Location = new System.Drawing.Point(119, 122);
            this.txtNombreCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.PasswordChar = '\0';
            this.txtNombreCliente.SelectedText = "";
            this.txtNombreCliente.SelectionLength = 0;
            this.txtNombreCliente.SelectionStart = 0;
            this.txtNombreCliente.Size = new System.Drawing.Size(215, 23);
            this.txtNombreCliente.TabIndex = 1;
            this.txtNombreCliente.UseSystemPasswordChar = false;
            this.txtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreCliente_KeyPress);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Depth = 0;
            this.lblTipo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTipo.Location = new System.Drawing.Point(395, 163);
            this.lblTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(121, 19);
            this.lblTipo.TabIndex = 100;
            this.lblTipo.Text = "Tipo Documento";
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Depth = 0;
            this.LblMail.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblMail.Location = new System.Drawing.Point(395, 122);
            this.LblMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(38, 19);
            this.LblMail.TabIndex = 98;
            this.LblMail.Text = "Mail";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Depth = 0;
            this.LblApellido.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblApellido.Location = new System.Drawing.Point(22, 163);
            this.LblApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(64, 19);
            this.LblApellido.TabIndex = 97;
            this.LblApellido.Text = "Apellido";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Depth = 0;
            this.LblNombre.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblNombre.Location = new System.Drawing.Point(22, 122);
            this.LblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(63, 19);
            this.LblNombre.TabIndex = 95;
            this.LblNombre.Text = "Nombre";
            // 
            // ModalHuesped
            // 
            this.AcceptButton = this.btnRegistrarHuesped;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 314);
            this.Controls.Add(this.txtDocumentoCliente);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.txtTelefonoCliente);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(materialDivider1);
            this.Controls.Add(this.lblDatosHuesped);
            this.Controls.Add(this.btnCancelarHuesped);
            this.Controls.Add(this.btnRegistrarHuesped);
            this.Controls.Add(this.comboTipoDocumento);
            this.Controls.Add(this.txtMailCliente);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.LblMail);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.Name = "ModalHuesped";
            this.Text = "Registrar Cliente";
            this.Load += new System.EventHandler(this.ModalHuesped_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtDocumentoCliente;
        private MaterialSkin.Controls.MaterialLabel lblDocumento;
        protected internal MaterialSkin.Controls.MaterialSingleLineTextField txtTelefonoCliente;
        private MaterialSkin.Controls.MaterialLabel lblTelefono;
        private MaterialSkin.Controls.MaterialLabel lblDatosHuesped;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelarHuesped;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegistrarHuesped;
        private MetroFramework.Controls.MetroComboBox comboTipoDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMailCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellidoCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreCliente;
        private MaterialSkin.Controls.MaterialLabel lblTipo;
        private MaterialSkin.Controls.MaterialLabel LblMail;
        private MaterialSkin.Controls.MaterialLabel LblApellido;
        private MaterialSkin.Controls.MaterialLabel LblNombre;
    }
}