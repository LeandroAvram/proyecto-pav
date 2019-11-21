namespace ProyectoPav.Vistas.Grillas
{
    partial class GrillaClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrillaClientes));
            this.dgvClientes = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSeleccionarCliente = new FlatButton.JFlatButton();
            this.btnNuevoCliente = new FlatButton.JFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.Email,
            this.Telefono,
            this.TipoDocumento,
            this.NumDocumento,
            this.Estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvClientes.GridColor = System.Drawing.Color.Red;
            this.dgvClientes.Location = new System.Drawing.Point(0, 0);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(936, 392);
            this.dgvClientes.TabIndex = 101;
            this.dgvClientes.UseCustomBackColor = true;
            this.dgvClientes.UseCustomForeColor = true;
            this.dgvClientes.UseStyleColors = true;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipoDocumento.DataPropertyName = "TipoDocumento";
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // NumDocumento
            // 
            this.NumDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumDocumento.DataPropertyName = "NroDocumento";
            this.NumDocumento.HeaderText = "NumDocumento";
            this.NumDocumento.Name = "NumDocumento";
            this.NumDocumento.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvClientes);
            this.panel1.Location = new System.Drawing.Point(13, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 392);
            this.panel1.TabIndex = 102;
            // 
            // BtnSeleccionarCliente
            // 
            this.BtnSeleccionarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnSeleccionarCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnSeleccionarCliente.ButtonText = "ACEPTAR";
            this.BtnSeleccionarCliente.CausesValidation = false;
            this.BtnSeleccionarCliente.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("BtnSeleccionarCliente.ErrorImageLeft")));
            this.BtnSeleccionarCliente.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("BtnSeleccionarCliente.ErrorImageRight")));
            this.BtnSeleccionarCliente.FocusBackground = System.Drawing.Color.Empty;
            this.BtnSeleccionarCliente.FocusFontColor = System.Drawing.Color.Empty;
            this.BtnSeleccionarCliente.ForeColors = System.Drawing.Color.White;
            this.BtnSeleccionarCliente.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.BtnSeleccionarCliente.HoverFontColor = System.Drawing.Color.Black;
            this.BtnSeleccionarCliente.ImageLeft = ((System.Drawing.Image)(resources.GetObject("BtnSeleccionarCliente.ImageLeft")));
            this.BtnSeleccionarCliente.ImageRight = null;
            this.BtnSeleccionarCliente.LeftPictureColor = System.Drawing.Color.Transparent;
            this.BtnSeleccionarCliente.Location = new System.Drawing.Point(782, 518);
            this.BtnSeleccionarCliente.Name = "BtnSeleccionarCliente";
            this.BtnSeleccionarCliente.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.BtnSeleccionarCliente.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.BtnSeleccionarCliente.RightPictureColor = System.Drawing.Color.Transparent;
            this.BtnSeleccionarCliente.Size = new System.Drawing.Size(167, 43);
            this.BtnSeleccionarCliente.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BtnSeleccionarCliente.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.BtnSeleccionarCliente.TabIndex = 108;
            this.BtnSeleccionarCliente.Click += new System.EventHandler(this.BtnSeleccionarCliente_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnNuevoCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnNuevoCliente.ButtonText = "Nuevo Cliente";
            this.btnNuevoCliente.CausesValidation = false;
            this.btnNuevoCliente.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnNuevoCliente.ErrorImageLeft")));
            this.btnNuevoCliente.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnNuevoCliente.ErrorImageRight")));
            this.btnNuevoCliente.FocusBackground = System.Drawing.Color.Empty;
            this.btnNuevoCliente.FocusFontColor = System.Drawing.Color.Empty;
            this.btnNuevoCliente.ForeColors = System.Drawing.Color.White;
            this.btnNuevoCliente.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnNuevoCliente.HoverFontColor = System.Drawing.Color.Black;
            this.btnNuevoCliente.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btnNuevoCliente.ImageLeft")));
            this.btnNuevoCliente.ImageRight = null;
            this.btnNuevoCliente.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnNuevoCliente.Location = new System.Drawing.Point(27, 518);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnNuevoCliente.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnNuevoCliente.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnNuevoCliente.Size = new System.Drawing.Size(254, 43);
            this.btnNuevoCliente.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnNuevoCliente.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnNuevoCliente.TabIndex = 107;
            this.btnNuevoCliente.Click += new System.EventHandler(this.BtnNuevoCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(602, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 113;
            this.label2.Text = "Buscar: ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "";
            this.txtBuscar.Location = new System.Drawing.Point(696, 82);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(251, 23);
            this.txtBuscar.TabIndex = 112;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // GrillaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 573);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.BtnSeleccionarCliente);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.panel1);
            this.Name = "GrillaClientes";
            this.Text = "GrillaClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Panel panel1;
        private FlatButton.JFlatButton btnNuevoCliente;
        private FlatButton.JFlatButton BtnSeleccionarCliente;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
    }
}