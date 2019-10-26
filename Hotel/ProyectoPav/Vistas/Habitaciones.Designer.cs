namespace ProyectoPav.Vistas
{
    partial class Habitaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Habitaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnEliminarHabitacion = new FlatButton.JFlatButton();
            this.btn_modificarHab = new FlatButton.JFlatButton();
            this.btnNuevaHabitacion = new FlatButton.JFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvHabitacion = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catHab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoHab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoHab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.btnEliminarHabitacion);
            this.panel1.Controls.Add(this.btn_modificarHab);
            this.panel1.Controls.Add(this.btnNuevaHabitacion);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 685);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(743, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 111;
            this.label2.Text = "Buscar: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 28);
            this.label1.TabIndex = 110;
            this.label1.Text = "HABITACION";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "";
            this.txtBuscar.Location = new System.Drawing.Point(837, 43);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(251, 23);
            this.txtBuscar.TabIndex = 109;
            this.txtBuscar.UseSystemPasswordChar = false;
            // 
            // btnEliminarHabitacion
            // 
            this.btnEliminarHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnEliminarHabitacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnEliminarHabitacion.ButtonText = "Eliminar Habitacion";
            this.btnEliminarHabitacion.CausesValidation = false;
            this.btnEliminarHabitacion.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnEliminarHabitacion.ErrorImageLeft")));
            this.btnEliminarHabitacion.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnEliminarHabitacion.ErrorImageRight")));
            this.btnEliminarHabitacion.FocusBackground = System.Drawing.Color.Empty;
            this.btnEliminarHabitacion.FocusFontColor = System.Drawing.Color.Empty;
            this.btnEliminarHabitacion.ForeColors = System.Drawing.Color.White;
            this.btnEliminarHabitacion.HoverBackground = System.Drawing.Color.Empty;
            this.btnEliminarHabitacion.HoverFontColor = System.Drawing.Color.Empty;
            this.btnEliminarHabitacion.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btnEliminarHabitacion.ImageLeft")));
            this.btnEliminarHabitacion.ImageRight = null;
            this.btnEliminarHabitacion.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnEliminarHabitacion.Location = new System.Drawing.Point(773, 601);
            this.btnEliminarHabitacion.Name = "btnEliminarHabitacion";
            this.btnEliminarHabitacion.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnEliminarHabitacion.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnEliminarHabitacion.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnEliminarHabitacion.Size = new System.Drawing.Size(254, 43);
            this.btnEliminarHabitacion.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnEliminarHabitacion.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnEliminarHabitacion.TabIndex = 108;
            this.btnEliminarHabitacion.Click += new System.EventHandler(this.BtnEliminarHabitacion_Click);
            // 
            // btn_modificarHab
            // 
            this.btn_modificarHab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btn_modificarHab.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btn_modificarHab.ButtonText = "Modificar Habitacion";
            this.btn_modificarHab.CausesValidation = false;
            this.btn_modificarHab.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btn_modificarHab.ErrorImageLeft")));
            this.btn_modificarHab.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btn_modificarHab.ErrorImageRight")));
            this.btn_modificarHab.FocusBackground = System.Drawing.Color.Empty;
            this.btn_modificarHab.FocusFontColor = System.Drawing.Color.Empty;
            this.btn_modificarHab.ForeColors = System.Drawing.Color.White;
            this.btn_modificarHab.HoverBackground = System.Drawing.Color.Empty;
            this.btn_modificarHab.HoverFontColor = System.Drawing.Color.Empty;
            this.btn_modificarHab.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btn_modificarHab.ImageLeft")));
            this.btn_modificarHab.ImageRight = null;
            this.btn_modificarHab.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btn_modificarHab.Location = new System.Drawing.Point(442, 601);
            this.btn_modificarHab.Name = "btn_modificarHab";
            this.btn_modificarHab.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btn_modificarHab.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btn_modificarHab.RightPictureColor = System.Drawing.Color.Transparent;
            this.btn_modificarHab.Size = new System.Drawing.Size(254, 43);
            this.btn_modificarHab.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_modificarHab.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btn_modificarHab.TabIndex = 107;
            this.btn_modificarHab.Click += new System.EventHandler(this.Btn_modificarHab_Click);
            // 
            // btnNuevaHabitacion
            // 
            this.btnNuevaHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnNuevaHabitacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnNuevaHabitacion.ButtonText = "Nueva Habitacion";
            this.btnNuevaHabitacion.CausesValidation = false;
            this.btnNuevaHabitacion.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnNuevaHabitacion.ErrorImageLeft")));
            this.btnNuevaHabitacion.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnNuevaHabitacion.ErrorImageRight")));
            this.btnNuevaHabitacion.FocusBackground = System.Drawing.Color.Empty;
            this.btnNuevaHabitacion.FocusFontColor = System.Drawing.Color.Empty;
            this.btnNuevaHabitacion.ForeColors = System.Drawing.Color.White;
            this.btnNuevaHabitacion.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnNuevaHabitacion.HoverFontColor = System.Drawing.Color.Black;
            this.btnNuevaHabitacion.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btnNuevaHabitacion.ImageLeft")));
            this.btnNuevaHabitacion.ImageRight = null;
            this.btnNuevaHabitacion.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnNuevaHabitacion.Location = new System.Drawing.Point(104, 601);
            this.btnNuevaHabitacion.Name = "btnNuevaHabitacion";
            this.btnNuevaHabitacion.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnNuevaHabitacion.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnNuevaHabitacion.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnNuevaHabitacion.Size = new System.Drawing.Size(254, 43);
            this.btnNuevaHabitacion.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnNuevaHabitacion.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnNuevaHabitacion.TabIndex = 106;
            this.btnNuevaHabitacion.Click += new System.EventHandler(this.BtnNuevaHabitacion_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvHabitacion);
            this.panel3.Location = new System.Drawing.Point(32, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1056, 454);
            this.panel3.TabIndex = 105;
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
            this.dgvHabitacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHabitacion_CellContentClick);
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
            this.nro_habitacion.DataPropertyName = "nro_habitacion";
            this.nro_habitacion.HeaderText = "Numero";
            this.nro_habitacion.Name = "nro_habitacion";
            this.nro_habitacion.ReadOnly = true;
            // 
            // catHab
            // 
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
            this.estadoHab.DataPropertyName = "estadoHab";
            this.estadoHab.HeaderText = "Estado";
            this.estadoHab.Name = "estadoHab";
            this.estadoHab.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 7);
            this.panel2.TabIndex = 2;
            // 
            // Habitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 685);
            this.Controls.Add(this.panel1);
            this.Name = "Habitaciones";
            this.Text = "Habitaciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private FlatButton.JFlatButton btnEliminarHabitacion;
        private FlatButton.JFlatButton btn_modificarHab;
        private FlatButton.JFlatButton btnNuevaHabitacion;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroGrid dgvHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn catHab;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoHab;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoHab;
    }
}