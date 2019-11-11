namespace ProyectoPav.Vistas.Grillas
{
    partial class GrillaHabitaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrillaHabitaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnSeleccionarHabitacion = new FlatButton.JFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvHabitacion = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catHab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoHab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoHab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboCategoriaHabitacion = new MetroFramework.Controls.MetroComboBox();
            this.lblCategoriaHabitacion = new MaterialSkin.Controls.MaterialLabel();
            this.comboTipoHabitacion = new MetroFramework.Controls.MetroComboBox();
            this.lblTipoHabitacion = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.DateEgreso = new MetroFramework.Controls.MetroDateTime();
            this.DateIngreso = new MetroFramework.Controls.MetroDateTime();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.BtnFiltrarHabitaciones = new FlatButton.JFlatButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSeleccionarHabitacion
            // 
            this.BtnSeleccionarHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnSeleccionarHabitacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnSeleccionarHabitacion.ButtonText = "ACEPTAR";
            this.BtnSeleccionarHabitacion.CausesValidation = false;
            this.BtnSeleccionarHabitacion.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("BtnSeleccionarHabitacion.ErrorImageLeft")));
            this.BtnSeleccionarHabitacion.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("BtnSeleccionarHabitacion.ErrorImageRight")));
            this.BtnSeleccionarHabitacion.FocusBackground = System.Drawing.Color.Empty;
            this.BtnSeleccionarHabitacion.FocusFontColor = System.Drawing.Color.Empty;
            this.BtnSeleccionarHabitacion.ForeColors = System.Drawing.Color.White;
            this.BtnSeleccionarHabitacion.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.BtnSeleccionarHabitacion.HoverFontColor = System.Drawing.Color.Black;
            this.BtnSeleccionarHabitacion.ImageLeft = ((System.Drawing.Image)(resources.GetObject("BtnSeleccionarHabitacion.ImageLeft")));
            this.BtnSeleccionarHabitacion.ImageRight = null;
            this.BtnSeleccionarHabitacion.LeftPictureColor = System.Drawing.Color.Transparent;
            this.BtnSeleccionarHabitacion.Location = new System.Drawing.Point(901, 677);
            this.BtnSeleccionarHabitacion.Name = "BtnSeleccionarHabitacion";
            this.BtnSeleccionarHabitacion.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.BtnSeleccionarHabitacion.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.BtnSeleccionarHabitacion.RightPictureColor = System.Drawing.Color.Transparent;
            this.BtnSeleccionarHabitacion.Size = new System.Drawing.Size(167, 43);
            this.BtnSeleccionarHabitacion.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BtnSeleccionarHabitacion.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.BtnSeleccionarHabitacion.TabIndex = 109;
            this.BtnSeleccionarHabitacion.Click += new System.EventHandler(this.BtnSeleccionarHabitacion_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvHabitacion);
            this.panel3.Location = new System.Drawing.Point(12, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1056, 454);
            this.panel3.TabIndex = 110;
            // 
            // dgvHabitacion
            // 
            this.dgvHabitacion.AllowUserToAddRows = false;
            this.dgvHabitacion.AllowUserToDeleteRows = false;
            this.dgvHabitacion.AllowUserToOrderColumns = true;
            this.dgvHabitacion.AllowUserToResizeRows = false;
            this.dgvHabitacion.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHabitacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvHabitacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHabitacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nro_habitacion,
            this.precio,
            this.catHab,
            this.tipoHab,
            this.estadoHab});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHabitacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHabitacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHabitacion.EnableHeadersVisualStyles = false;
            this.dgvHabitacion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvHabitacion.GridColor = System.Drawing.Color.Red;
            this.dgvHabitacion.Location = new System.Drawing.Point(0, 0);
            this.dgvHabitacion.Name = "dgvHabitacion";
            this.dgvHabitacion.ReadOnly = true;
            this.dgvHabitacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvHabitacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHabitacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHabitacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHabitacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHabitacion.Size = new System.Drawing.Size(1056, 454);
            this.dgvHabitacion.TabIndex = 2;
            this.dgvHabitacion.UseCustomBackColor = true;
            this.dgvHabitacion.UseCustomForeColor = true;
            this.dgvHabitacion.UseStyleColors = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id_habitacion";
            this.id.HeaderText = "id_habitacion";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nro_habitacion
            // 
            this.nro_habitacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nro_habitacion.DataPropertyName = "nro_habitacion";
            this.nro_habitacion.HeaderText = "Numero";
            this.nro_habitacion.Name = "nro_habitacion";
            this.nro_habitacion.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // catHab
            // 
            this.catHab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.catHab.DataPropertyName = "catHab";
            this.catHab.HeaderText = "Categoria";
            this.catHab.Name = "catHab";
            this.catHab.ReadOnly = true;
            // 
            // tipoHab
            // 
            this.tipoHab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoHab.DataPropertyName = "tipoHab";
            this.tipoHab.HeaderText = "TipoHabitacion";
            this.tipoHab.Name = "tipoHab";
            this.tipoHab.ReadOnly = true;
            // 
            // estadoHab
            // 
            this.estadoHab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estadoHab.DataPropertyName = "estadoHab";
            this.estadoHab.HeaderText = "Estado";
            this.estadoHab.Name = "estadoHab";
            this.estadoHab.ReadOnly = true;
            // 
            // comboCategoriaHabitacion
            // 
            this.comboCategoriaHabitacion.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboCategoriaHabitacion.FormattingEnabled = true;
            this.comboCategoriaHabitacion.IntegralHeight = false;
            this.comboCategoriaHabitacion.ItemHeight = 23;
            this.comboCategoriaHabitacion.Location = new System.Drawing.Point(212, 162);
            this.comboCategoriaHabitacion.Name = "comboCategoriaHabitacion";
            this.comboCategoriaHabitacion.Size = new System.Drawing.Size(171, 29);
            this.comboCategoriaHabitacion.TabIndex = 151;
            this.comboCategoriaHabitacion.UseSelectable = true;
            // 
            // lblCategoriaHabitacion
            // 
            this.lblCategoriaHabitacion.AutoSize = true;
            this.lblCategoriaHabitacion.Depth = 0;
            this.lblCategoriaHabitacion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategoriaHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategoriaHabitacion.Location = new System.Drawing.Point(132, 168);
            this.lblCategoriaHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoriaHabitacion.Name = "lblCategoriaHabitacion";
            this.lblCategoriaHabitacion.Size = new System.Drawing.Size(74, 19);
            this.lblCategoriaHabitacion.TabIndex = 150;
            this.lblCategoriaHabitacion.Text = "Categoria";
            // 
            // comboTipoHabitacion
            // 
            this.comboTipoHabitacion.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboTipoHabitacion.FormattingEnabled = true;
            this.comboTipoHabitacion.IntegralHeight = false;
            this.comboTipoHabitacion.ItemHeight = 23;
            this.comboTipoHabitacion.Location = new System.Drawing.Point(212, 120);
            this.comboTipoHabitacion.Name = "comboTipoHabitacion";
            this.comboTipoHabitacion.Size = new System.Drawing.Size(171, 29);
            this.comboTipoHabitacion.TabIndex = 149;
            this.comboTipoHabitacion.UseSelectable = true;
            // 
            // lblTipoHabitacion
            // 
            this.lblTipoHabitacion.AutoSize = true;
            this.lblTipoHabitacion.Depth = 0;
            this.lblTipoHabitacion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTipoHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTipoHabitacion.Location = new System.Drawing.Point(90, 126);
            this.lblTipoHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipoHabitacion.Name = "lblTipoHabitacion";
            this.lblTipoHabitacion.Size = new System.Drawing.Size(116, 19);
            this.lblTipoHabitacion.TabIndex = 148;
            this.lblTipoHabitacion.Text = "Tipo Habitacion";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(417, 168);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(125, 19);
            this.materialLabel2.TabIndex = 155;
            this.materialLabel2.Text = "Fecha de egreso*";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(417, 126);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(129, 19);
            this.materialLabel1.TabIndex = 154;
            this.materialLabel1.Text = "Fecha de ingreso*";
            // 
            // DateEgreso
            // 
            this.DateEgreso.Location = new System.Drawing.Point(551, 162);
            this.DateEgreso.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateEgreso.Name = "DateEgreso";
            this.DateEgreso.Size = new System.Drawing.Size(200, 29);
            this.DateEgreso.TabIndex = 153;
            // 
            // DateIngreso
            // 
            this.DateIngreso.Location = new System.Drawing.Point(551, 120);
            this.DateIngreso.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateIngreso.Name = "DateIngreso";
            this.DateIngreso.Size = new System.Drawing.Size(200, 29);
            this.DateIngreso.TabIndex = 152;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(90, 82);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(142, 19);
            this.materialLabel3.TabIndex = 156;
            this.materialLabel3.Text = "Filtrar habitaciones:";
            // 
            // BtnFiltrarHabitaciones
            // 
            this.BtnFiltrarHabitaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnFiltrarHabitaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnFiltrarHabitaciones.ButtonText = "Filtrar";
            this.BtnFiltrarHabitaciones.CausesValidation = false;
            this.BtnFiltrarHabitaciones.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("BtnFiltrarHabitaciones.ErrorImageLeft")));
            this.BtnFiltrarHabitaciones.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("BtnFiltrarHabitaciones.ErrorImageRight")));
            this.BtnFiltrarHabitaciones.FocusBackground = System.Drawing.Color.Empty;
            this.BtnFiltrarHabitaciones.FocusFontColor = System.Drawing.Color.Empty;
            this.BtnFiltrarHabitaciones.ForeColors = System.Drawing.Color.White;
            this.BtnFiltrarHabitaciones.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.BtnFiltrarHabitaciones.HoverFontColor = System.Drawing.Color.Black;
            this.BtnFiltrarHabitaciones.ImageLeft = null;
            this.BtnFiltrarHabitaciones.ImageRight = null;
            this.BtnFiltrarHabitaciones.LeftPictureColor = System.Drawing.Color.Transparent;
            this.BtnFiltrarHabitaciones.Location = new System.Drawing.Point(805, 148);
            this.BtnFiltrarHabitaciones.Name = "BtnFiltrarHabitaciones";
            this.BtnFiltrarHabitaciones.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.BtnFiltrarHabitaciones.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.BtnFiltrarHabitaciones.RightPictureColor = System.Drawing.Color.Transparent;
            this.BtnFiltrarHabitaciones.Size = new System.Drawing.Size(134, 43);
            this.BtnFiltrarHabitaciones.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BtnFiltrarHabitaciones.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.BtnFiltrarHabitaciones.TabIndex = 157;
            this.BtnFiltrarHabitaciones.Click += new System.EventHandler(this.BtnFiltrarHabitaciones_Click);
            // 
            // GrillaHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 732);
            this.Controls.Add(this.BtnFiltrarHabitaciones);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.DateEgreso);
            this.Controls.Add(this.DateIngreso);
            this.Controls.Add(this.comboCategoriaHabitacion);
            this.Controls.Add(this.lblCategoriaHabitacion);
            this.Controls.Add(this.comboTipoHabitacion);
            this.Controls.Add(this.lblTipoHabitacion);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BtnSeleccionarHabitacion);
            this.Name = "GrillaHabitaciones";
            this.Text = "GrillaHabitaciones";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FlatButton.JFlatButton BtnSeleccionarHabitacion;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroGrid dgvHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn catHab;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoHab;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoHab;
        private MetroFramework.Controls.MetroComboBox comboCategoriaHabitacion;
        private MaterialSkin.Controls.MaterialLabel lblCategoriaHabitacion;
        private MetroFramework.Controls.MetroComboBox comboTipoHabitacion;
        private MaterialSkin.Controls.MaterialLabel lblTipoHabitacion;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MetroFramework.Controls.MetroDateTime DateEgreso;
        private MetroFramework.Controls.MetroDateTime DateIngreso;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private FlatButton.JFlatButton BtnFiltrarHabitaciones;
    }
}