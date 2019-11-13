namespace ProyectoPav.Vistas
{
    partial class Reserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reserva));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.jFlatButton1 = new FlatButton.JFlatButton();
            this.btnFiltro = new FlatButton.JFlatButton();
            this.comboRolUsuario = new MetroFramework.Controls.MetroComboBox();
            this.jFlatButton3 = new FlatButton.JFlatButton();
            this.jFlatButton2 = new FlatButton.JFlatButton();
            this.btnNuevaReserva = new FlatButton.JFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dgvReservas = new MetroFramework.Controls.MetroGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.id_reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEgreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.jFlatButton1);
            this.panel1.Controls.Add(this.btnFiltro);
            this.panel1.Controls.Add(this.comboRolUsuario);
            this.panel1.Controls.Add(this.jFlatButton3);
            this.panel1.Controls.Add(this.jFlatButton2);
            this.panel1.Controls.Add(this.btnNuevaReserva);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.metroPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 685);
            this.panel1.TabIndex = 0;
            // 
            // jFlatButton1
            // 
            this.jFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.jFlatButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.jFlatButton1.ButtonText = "Todos";
            this.jFlatButton1.CausesValidation = false;
            this.jFlatButton1.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("jFlatButton1.ErrorImageLeft")));
            this.jFlatButton1.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("jFlatButton1.ErrorImageRight")));
            this.jFlatButton1.FocusBackground = System.Drawing.Color.Empty;
            this.jFlatButton1.FocusFontColor = System.Drawing.Color.Empty;
            this.jFlatButton1.ForeColors = System.Drawing.Color.White;
            this.jFlatButton1.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.jFlatButton1.HoverFontColor = System.Drawing.Color.Black;
            this.jFlatButton1.ImageLeft = null;
            this.jFlatButton1.ImageRight = null;
            this.jFlatButton1.LeftPictureColor = System.Drawing.Color.Transparent;
            this.jFlatButton1.Location = new System.Drawing.Point(707, 24);
            this.jFlatButton1.Name = "jFlatButton1";
            this.jFlatButton1.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.jFlatButton1.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.jFlatButton1.RightPictureColor = System.Drawing.Color.Transparent;
            this.jFlatButton1.Size = new System.Drawing.Size(64, 28);
            this.jFlatButton1.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.jFlatButton1.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.jFlatButton1.TabIndex = 123;
            this.jFlatButton1.Click += new System.EventHandler(this.JFlatButton1_Click);
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnFiltro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnFiltro.ButtonText = "Consultar";
            this.btnFiltro.CausesValidation = false;
            this.btnFiltro.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnFiltro.ErrorImageLeft")));
            this.btnFiltro.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnFiltro.ErrorImageRight")));
            this.btnFiltro.FocusBackground = System.Drawing.Color.Empty;
            this.btnFiltro.FocusFontColor = System.Drawing.Color.Empty;
            this.btnFiltro.ForeColors = System.Drawing.Color.White;
            this.btnFiltro.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnFiltro.HoverFontColor = System.Drawing.Color.Black;
            this.btnFiltro.ImageLeft = null;
            this.btnFiltro.ImageRight = null;
            this.btnFiltro.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnFiltro.Location = new System.Drawing.Point(590, 24);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnFiltro.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnFiltro.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnFiltro.Size = new System.Drawing.Size(95, 28);
            this.btnFiltro.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnFiltro.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnFiltro.TabIndex = 122;
            this.btnFiltro.Click += new System.EventHandler(this.BtnFiltro_Click);
            // 
            // comboRolUsuario
            // 
            this.comboRolUsuario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboRolUsuario.FormattingEnabled = true;
            this.comboRolUsuario.IntegralHeight = false;
            this.comboRolUsuario.ItemHeight = 23;
            this.comboRolUsuario.Location = new System.Drawing.Point(413, 24);
            this.comboRolUsuario.Name = "comboRolUsuario";
            this.comboRolUsuario.Size = new System.Drawing.Size(171, 29);
            this.comboRolUsuario.TabIndex = 120;
            this.comboRolUsuario.UseSelectable = true;
            // 
            // jFlatButton3
            // 
            this.jFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.jFlatButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.jFlatButton3.ButtonText = "Realizar Pago";
            this.jFlatButton3.CausesValidation = false;
            this.jFlatButton3.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("jFlatButton3.ErrorImageLeft")));
            this.jFlatButton3.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("jFlatButton3.ErrorImageRight")));
            this.jFlatButton3.FocusBackground = System.Drawing.Color.Empty;
            this.jFlatButton3.FocusFontColor = System.Drawing.Color.Empty;
            this.jFlatButton3.ForeColors = System.Drawing.Color.White;
            this.jFlatButton3.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.jFlatButton3.HoverFontColor = System.Drawing.Color.Black;
            this.jFlatButton3.ImageLeft = ((System.Drawing.Image)(resources.GetObject("jFlatButton3.ImageLeft")));
            this.jFlatButton3.ImageRight = null;
            this.jFlatButton3.LeftPictureColor = System.Drawing.Color.Transparent;
            this.jFlatButton3.Location = new System.Drawing.Point(870, 576);
            this.jFlatButton3.Name = "jFlatButton3";
            this.jFlatButton3.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.jFlatButton3.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.jFlatButton3.RightPictureColor = System.Drawing.Color.Transparent;
            this.jFlatButton3.Size = new System.Drawing.Size(254, 43);
            this.jFlatButton3.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.jFlatButton3.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.jFlatButton3.TabIndex = 108;
            this.jFlatButton3.Click += new System.EventHandler(this.JFlatButton3_Click);
            // 
            // jFlatButton2
            // 
            this.jFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.jFlatButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.jFlatButton2.ButtonText = "Cambiar Estado";
            this.jFlatButton2.CausesValidation = false;
            this.jFlatButton2.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("jFlatButton2.ErrorImageLeft")));
            this.jFlatButton2.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("jFlatButton2.ErrorImageRight")));
            this.jFlatButton2.FocusBackground = System.Drawing.Color.Empty;
            this.jFlatButton2.FocusFontColor = System.Drawing.Color.Empty;
            this.jFlatButton2.ForeColors = System.Drawing.Color.White;
            this.jFlatButton2.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.jFlatButton2.HoverFontColor = System.Drawing.Color.Black;
            this.jFlatButton2.ImageLeft = ((System.Drawing.Image)(resources.GetObject("jFlatButton2.ImageLeft")));
            this.jFlatButton2.ImageRight = null;
            this.jFlatButton2.LeftPictureColor = System.Drawing.Color.Transparent;
            this.jFlatButton2.Location = new System.Drawing.Point(855, 156);
            this.jFlatButton2.Name = "jFlatButton2";
            this.jFlatButton2.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.jFlatButton2.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.jFlatButton2.RightPictureColor = System.Drawing.Color.Transparent;
            this.jFlatButton2.Size = new System.Drawing.Size(254, 43);
            this.jFlatButton2.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.jFlatButton2.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.jFlatButton2.TabIndex = 107;
            this.jFlatButton2.Click += new System.EventHandler(this.JFlatButton2_Click);
            // 
            // btnNuevaReserva
            // 
            this.btnNuevaReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnNuevaReserva.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnNuevaReserva.ButtonText = "Nueva Reserva";
            this.btnNuevaReserva.CausesValidation = false;
            this.btnNuevaReserva.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnNuevaReserva.ErrorImageLeft")));
            this.btnNuevaReserva.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnNuevaReserva.ErrorImageRight")));
            this.btnNuevaReserva.FocusBackground = System.Drawing.Color.Empty;
            this.btnNuevaReserva.FocusFontColor = System.Drawing.Color.Empty;
            this.btnNuevaReserva.ForeColors = System.Drawing.Color.White;
            this.btnNuevaReserva.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnNuevaReserva.HoverFontColor = System.Drawing.Color.Black;
            this.btnNuevaReserva.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btnNuevaReserva.ImageLeft")));
            this.btnNuevaReserva.ImageRight = null;
            this.btnNuevaReserva.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnNuevaReserva.Location = new System.Drawing.Point(855, 72);
            this.btnNuevaReserva.Name = "btnNuevaReserva";
            this.btnNuevaReserva.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnNuevaReserva.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnNuevaReserva.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnNuevaReserva.Size = new System.Drawing.Size(254, 43);
            this.btnNuevaReserva.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnNuevaReserva.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnNuevaReserva.TabIndex = 105;
            this.btnNuevaReserva.Click += new System.EventHandler(this.BtnNuevaReserva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 104;
            this.label1.Text = "RESERVAS";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.dgvReservas);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(60, 72);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(762, 558);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.AllowUserToOrderColumns = true;
            this.dgvReservas.AllowUserToResizeRows = false;
            this.dgvReservas.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvReservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_reserva,
            this.nro_habitacion,
            this.nombreCompleto,
            this.fechaIngreso,
            this.fechaEgreso,
            this.estadoReserva,
            this.cantPersonas,
            this.monto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservas.EnableHeadersVisualStyles = false;
            this.dgvReservas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvReservas.GridColor = System.Drawing.Color.Red;
            this.dgvReservas.Location = new System.Drawing.Point(0, 0);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvReservas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReservas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(762, 558);
            this.dgvReservas.TabIndex = 3;
            this.dgvReservas.UseCustomBackColor = true;
            this.dgvReservas.UseCustomForeColor = true;
            this.dgvReservas.UseStyleColors = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 7);
            this.panel2.TabIndex = 0;
            // 
            // id_reserva
            // 
            this.id_reserva.DataPropertyName = "id_reserva";
            this.id_reserva.HeaderText = "id_reserva";
            this.id_reserva.Name = "id_reserva";
            this.id_reserva.ReadOnly = true;
            this.id_reserva.Visible = false;
            // 
            // nro_habitacion
            // 
            this.nro_habitacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nro_habitacion.DataPropertyName = "nro_habitacion";
            this.nro_habitacion.HeaderText = "Numero Habitacion";
            this.nro_habitacion.Name = "nro_habitacion";
            this.nro_habitacion.ReadOnly = true;
            // 
            // nombreCompleto
            // 
            this.nombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreCompleto.DataPropertyName = "nombreCompleto";
            this.nombreCompleto.HeaderText = "Nombre Completo";
            this.nombreCompleto.Name = "nombreCompleto";
            this.nombreCompleto.ReadOnly = true;
            this.nombreCompleto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaIngreso.DataPropertyName = "fechaIngreso";
            this.fechaIngreso.HeaderText = "Fecha ingreso";
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.ReadOnly = true;
            // 
            // fechaEgreso
            // 
            this.fechaEgreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaEgreso.DataPropertyName = "fechaEgreso";
            this.fechaEgreso.HeaderText = "Fecha egreso";
            this.fechaEgreso.Name = "fechaEgreso";
            this.fechaEgreso.ReadOnly = true;
            // 
            // estadoReserva
            // 
            this.estadoReserva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estadoReserva.DataPropertyName = "estadoReserva";
            this.estadoReserva.HeaderText = "Estado";
            this.estadoReserva.Name = "estadoReserva";
            this.estadoReserva.ReadOnly = true;
            // 
            // cantPersonas
            // 
            this.cantPersonas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantPersonas.DataPropertyName = "cantPersonas";
            this.cantPersonas.HeaderText = "Cantidad Personas";
            this.cantPersonas.Name = "cantPersonas";
            this.cantPersonas.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.DataPropertyName = "monto";
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // Reserva
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1121, 685);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reserva";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label label1;
        private FlatButton.JFlatButton btnNuevaReserva;
        private FlatButton.JFlatButton jFlatButton3;
        private FlatButton.JFlatButton jFlatButton2;
        private MetroFramework.Controls.MetroComboBox comboRolUsuario;
        private MetroFramework.Controls.MetroGrid dgvReservas;
        private FlatButton.JFlatButton btnFiltro;
        private FlatButton.JFlatButton jFlatButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_reserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEgreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
    }
}