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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboFilter = new MetroFramework.Controls.MetroComboBox();
            this.jFlatButton3 = new FlatButton.JFlatButton();
            this.jFlatButton2 = new FlatButton.JFlatButton();
            this.btnNuevaReserva = new FlatButton.JFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvReservas = new MetroFramework.Controls.MetroGrid();
            this.id_reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEgreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboFilter);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 121;
            this.label2.Text = "Filtro: ";
            // 
            // comboFilter
            // 
            this.comboFilter.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboFilter.FormattingEnabled = true;
            this.comboFilter.IntegralHeight = false;
            this.comboFilter.ItemHeight = 23;
            this.comboFilter.Location = new System.Drawing.Point(533, 25);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.Size = new System.Drawing.Size(171, 29);
            this.comboFilter.TabIndex = 120;
            this.comboFilter.UseSelectable = true;
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
            this.jFlatButton3.Location = new System.Drawing.Point(843, 576);
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
            this.jFlatButton2.Location = new System.Drawing.Point(828, 156);
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
            this.btnNuevaReserva.Location = new System.Drawing.Point(828, 72);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 7);
            this.panel2.TabIndex = 0;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_reserva,
            this.nro_habitacion,
            this.nombreCompleto,
            this.fechaIngreso,
            this.fechaEgreso,
            this.estadoReserva,
            this.cantPersonas});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservas.EnableHeadersVisualStyles = false;
            this.dgvReservas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvReservas.GridColor = System.Drawing.Color.Red;
            this.dgvReservas.Location = new System.Drawing.Point(0, 0);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvReservas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReservas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(762, 558);
            this.dgvReservas.TabIndex = 3;
            this.dgvReservas.UseCustomBackColor = true;
            this.dgvReservas.UseCustomForeColor = true;
            this.dgvReservas.UseStyleColors = true;
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
        private MetroFramework.Controls.MetroComboBox comboFilter;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroGrid dgvReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_reserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEgreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantPersonas;
    }
}