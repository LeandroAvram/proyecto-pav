namespace ProyectoPav.Vistas.Modales
{
    partial class ModalPago
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
            this.LblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblfechaPago = new MaterialSkin.Controls.MaterialLabel();
            this.comboRolUsuario = new MetroFramework.Controls.MetroComboBox();
            this.lblRol = new MaterialSkin.Controls.MaterialLabel();
            this.monto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lbldate = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancelarUsuario = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRegistrarHuesped = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombreCom = new MaterialSkin.Controls.MaterialLabel();
            this.LblNumeroHabitacion = new MaterialSkin.Controls.MaterialLabel();
            this.lblNumHab = new MaterialSkin.Controls.MaterialLabel();
            this.lblidreserva = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaIngre = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaEgreso = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Depth = 0;
            this.LblNombre.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblNombre.Location = new System.Drawing.Point(31, 93);
            this.LblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(80, 19);
            this.LblNombre.TabIndex = 120;
            this.LblNombre.Text = "ID Reserva";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(373, 138);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 19);
            this.materialLabel1.TabIndex = 153;
            this.materialLabel1.Text = "Fecha de Pago";
            // 
            // lblfechaPago
            // 
            this.lblfechaPago.AutoSize = true;
            this.lblfechaPago.Depth = 0;
            this.lblfechaPago.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblfechaPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblfechaPago.Location = new System.Drawing.Point(493, 244);
            this.lblfechaPago.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblfechaPago.Name = "lblfechaPago";
            this.lblfechaPago.Size = new System.Drawing.Size(0, 19);
            this.lblfechaPago.TabIndex = 154;
            // 
            // comboRolUsuario
            // 
            this.comboRolUsuario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboRolUsuario.FormattingEnabled = true;
            this.comboRolUsuario.IntegralHeight = false;
            this.comboRolUsuario.ItemHeight = 23;
            this.comboRolUsuario.Location = new System.Drawing.Point(497, 180);
            this.comboRolUsuario.Name = "comboRolUsuario";
            this.comboRolUsuario.Size = new System.Drawing.Size(144, 29);
            this.comboRolUsuario.TabIndex = 156;
            this.comboRolUsuario.UseSelectable = true;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Depth = 0;
            this.lblRol.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRol.Location = new System.Drawing.Point(367, 190);
            this.lblRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(110, 19);
            this.lblRol.TabIndex = 155;
            this.lblRol.Text = "Forma de Pago";
            // 
            // monto
            // 
            this.monto.Depth = 0;
            this.monto.Hint = "";
            this.monto.Location = new System.Drawing.Point(497, 290);
            this.monto.MouseState = MaterialSkin.MouseState.HOVER;
            this.monto.Name = "monto";
            this.monto.PasswordChar = '\0';
            this.monto.SelectedText = "";
            this.monto.SelectionLength = 0;
            this.monto.SelectionStart = 0;
            this.monto.Size = new System.Drawing.Size(114, 23);
            this.monto.TabIndex = 157;
            this.monto.UseSystemPasswordChar = false;
            this.monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Monto_KeyPress);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(373, 290);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(107, 19);
            this.materialLabel4.TabIndex = 158;
            this.materialLabel4.Text = "Monto a Pagar";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(436, 244);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(44, 19);
            this.materialLabel2.TabIndex = 160;
            this.materialLabel2.Text = "Total";
            this.materialLabel2.Click += new System.EventHandler(this.MaterialLabel2_Click);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Depth = 0;
            this.lbldate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbldate.Location = new System.Drawing.Point(493, 138);
            this.lbldate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(0, 19);
            this.lbldate.TabIndex = 161;
            // 
            // btnCancelarUsuario
            // 
            this.btnCancelarUsuario.AutoSize = true;
            this.btnCancelarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelarUsuario.Depth = 0;
            this.btnCancelarUsuario.Location = new System.Drawing.Point(559, 364);
            this.btnCancelarUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelarUsuario.Name = "btnCancelarUsuario";
            this.btnCancelarUsuario.Primary = false;
            this.btnCancelarUsuario.Size = new System.Drawing.Size(82, 36);
            this.btnCancelarUsuario.TabIndex = 163;
            this.btnCancelarUsuario.Text = "Cancelar";
            this.btnCancelarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarHuesped
            // 
            this.btnRegistrarHuesped.Depth = 0;
            this.btnRegistrarHuesped.Location = new System.Drawing.Point(413, 364);
            this.btnRegistrarHuesped.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarHuesped.Name = "btnRegistrarHuesped";
            this.btnRegistrarHuesped.Primary = true;
            this.btnRegistrarHuesped.Size = new System.Drawing.Size(126, 36);
            this.btnRegistrarHuesped.TabIndex = 162;
            this.btnRegistrarHuesped.Text = "Registrar";
            this.btnRegistrarHuesped.UseVisualStyleBackColor = true;
            this.btnRegistrarHuesped.Click += new System.EventHandler(this.BtnRegistrarHuesped_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(24, 148);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(133, 19);
            this.materialLabel3.TabIndex = 164;
            this.materialLabel3.Text = "Nombre Completo";
            // 
            // lblNombreCom
            // 
            this.lblNombreCom.AutoSize = true;
            this.lblNombreCom.Depth = 0;
            this.lblNombreCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNombreCom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombreCom.Location = new System.Drawing.Point(163, 150);
            this.lblNombreCom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreCom.Name = "lblNombreCom";
            this.lblNombreCom.Size = new System.Drawing.Size(0, 18);
            this.lblNombreCom.TabIndex = 167;
            // 
            // LblNumeroHabitacion
            // 
            this.LblNumeroHabitacion.AutoSize = true;
            this.LblNumeroHabitacion.Depth = 0;
            this.LblNumeroHabitacion.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblNumeroHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblNumeroHabitacion.Location = new System.Drawing.Point(17, 188);
            this.LblNumeroHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblNumeroHabitacion.Name = "LblNumeroHabitacion";
            this.LblNumeroHabitacion.Size = new System.Drawing.Size(140, 19);
            this.LblNumeroHabitacion.TabIndex = 174;
            this.LblNumeroHabitacion.Text = "Numero Habitacion";
            // 
            // lblNumHab
            // 
            this.lblNumHab.AutoSize = true;
            this.lblNumHab.Depth = 0;
            this.lblNumHab.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNumHab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNumHab.Location = new System.Drawing.Point(163, 188);
            this.lblNumHab.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumHab.Name = "lblNumHab";
            this.lblNumHab.Size = new System.Drawing.Size(0, 19);
            this.lblNumHab.TabIndex = 178;
            // 
            // lblidreserva
            // 
            this.lblidreserva.AutoSize = true;
            this.lblidreserva.Depth = 0;
            this.lblidreserva.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblidreserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblidreserva.Location = new System.Drawing.Point(126, 93);
            this.lblidreserva.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblidreserva.Name = "lblidreserva";
            this.lblidreserva.Size = new System.Drawing.Size(0, 19);
            this.lblidreserva.TabIndex = 181;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(54, 232);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(103, 19);
            this.materialLabel6.TabIndex = 182;
            this.materialLabel6.Text = "Fecha Ingreso";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(54, 278);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(100, 19);
            this.materialLabel7.TabIndex = 183;
            this.materialLabel7.Text = "Fecha Egreso";
            // 
            // lblFechaIngre
            // 
            this.lblFechaIngre.AutoSize = true;
            this.lblFechaIngre.Depth = 0;
            this.lblFechaIngre.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaIngre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaIngre.Location = new System.Drawing.Point(163, 232);
            this.lblFechaIngre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaIngre.Name = "lblFechaIngre";
            this.lblFechaIngre.Size = new System.Drawing.Size(0, 19);
            this.lblFechaIngre.TabIndex = 184;
            // 
            // lblFechaEgreso
            // 
            this.lblFechaEgreso.AutoSize = true;
            this.lblFechaEgreso.Depth = 0;
            this.lblFechaEgreso.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaEgreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaEgreso.Location = new System.Drawing.Point(163, 278);
            this.lblFechaEgreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaEgreso.Name = "lblFechaEgreso";
            this.lblFechaEgreso.Size = new System.Drawing.Size(0, 19);
            this.lblFechaEgreso.TabIndex = 185;
            // 
            // ModalPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 447);
            this.Controls.Add(this.lblFechaEgreso);
            this.Controls.Add(this.lblFechaIngre);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.lblidreserva);
            this.Controls.Add(this.lblNumHab);
            this.Controls.Add(this.LblNumeroHabitacion);
            this.Controls.Add(this.lblNombreCom);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.btnCancelarUsuario);
            this.Controls.Add(this.btnRegistrarHuesped);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.monto);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.comboRolUsuario);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblfechaPago);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.LblNombre);
            this.Name = "ModalPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModalPago";
            this.Load += new System.EventHandler(this.ModalPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblNombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblfechaPago;
        private MetroFramework.Controls.MetroComboBox comboRolUsuario;
        private MaterialSkin.Controls.MaterialLabel lblRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField monto;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lbldate;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelarUsuario;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegistrarHuesped;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblNombreCom;
        private MaterialSkin.Controls.MaterialLabel LblNumeroHabitacion;
        private MaterialSkin.Controls.MaterialLabel lblNumHab;
        private MaterialSkin.Controls.MaterialLabel lblidreserva;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel lblFechaIngre;
        private MaterialSkin.Controls.MaterialLabel lblFechaEgreso;
    }
}