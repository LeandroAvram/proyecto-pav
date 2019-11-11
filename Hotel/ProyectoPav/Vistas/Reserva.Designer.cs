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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboFilter = new MetroFramework.Controls.MetroComboBox();
            this.jFlatButton3 = new FlatButton.JFlatButton();
            this.jFlatButton2 = new FlatButton.JFlatButton();
            this.jFlatButton1 = new FlatButton.JFlatButton();
            this.btnNuevaReserva = new FlatButton.JFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboFilter);
            this.panel1.Controls.Add(this.jFlatButton3);
            this.panel1.Controls.Add(this.jFlatButton2);
            this.panel1.Controls.Add(this.jFlatButton1);
            this.panel1.Controls.Add(this.btnNuevaReserva);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.metroPanel1);
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
            this.jFlatButton2.Location = new System.Drawing.Point(828, 228);
            this.jFlatButton2.Name = "jFlatButton2";
            this.jFlatButton2.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.jFlatButton2.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.jFlatButton2.RightPictureColor = System.Drawing.Color.Transparent;
            this.jFlatButton2.Size = new System.Drawing.Size(254, 43);
            this.jFlatButton2.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.jFlatButton2.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.jFlatButton2.TabIndex = 107;
            // 
            // jFlatButton1
            // 
            this.jFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.jFlatButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.jFlatButton1.ButtonText = "Detalle de Reserva";
            this.jFlatButton1.CausesValidation = false;
            this.jFlatButton1.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("jFlatButton1.ErrorImageLeft")));
            this.jFlatButton1.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("jFlatButton1.ErrorImageRight")));
            this.jFlatButton1.FocusBackground = System.Drawing.Color.Empty;
            this.jFlatButton1.FocusFontColor = System.Drawing.Color.Empty;
            this.jFlatButton1.ForeColors = System.Drawing.Color.White;
            this.jFlatButton1.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.jFlatButton1.HoverFontColor = System.Drawing.Color.Black;
            this.jFlatButton1.ImageLeft = ((System.Drawing.Image)(resources.GetObject("jFlatButton1.ImageLeft")));
            this.jFlatButton1.ImageRight = null;
            this.jFlatButton1.LeftPictureColor = System.Drawing.Color.Transparent;
            this.jFlatButton1.Location = new System.Drawing.Point(828, 148);
            this.jFlatButton1.Name = "jFlatButton1";
            this.jFlatButton1.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.jFlatButton1.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.jFlatButton1.RightPictureColor = System.Drawing.Color.Transparent;
            this.jFlatButton1.Size = new System.Drawing.Size(254, 43);
            this.jFlatButton1.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.jFlatButton1.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.jFlatButton1.TabIndex = 106;
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
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.metroGrid1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(60, 72);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(644, 558);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.MetroPanel1_Paint);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToOrderColumns = true;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 0);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(644, 558);
            this.metroGrid1.TabIndex = 4;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MetroGrid1_CellContentClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Inoformacion";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 7);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
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
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
        private FlatButton.JFlatButton btnNuevaReserva;
        private FlatButton.JFlatButton jFlatButton3;
        private FlatButton.JFlatButton jFlatButton2;
        private FlatButton.JFlatButton jFlatButton1;
        private MetroFramework.Controls.MetroComboBox comboFilter;
        private System.Windows.Forms.Label label2;
    }
}