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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
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
            this.BtnSeleccionarHabitacion.Location = new System.Drawing.Point(903, 610);
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
            this.panel3.Location = new System.Drawing.Point(15, 136);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(721, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 115;
            this.label2.Text = "Buscar: ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "";
            this.txtBuscar.Location = new System.Drawing.Point(815, 90);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(251, 23);
            this.txtBuscar.TabIndex = 114;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // GrillaHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 663);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
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
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
    }
}