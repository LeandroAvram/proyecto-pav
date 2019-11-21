namespace ProyectoPav.Vistas.Modales
{
    partial class ModalEstadoReserva
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
            this.LblIdReserva = new MaterialSkin.Controls.MaterialLabel();
            this.comboRolUsuario = new MetroFramework.Controls.MetroComboBox();
            this.lblRol = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancelarUsuario = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRegistrarHuesped = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Depth = 0;
            this.LblNombre.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblNombre.Location = new System.Drawing.Point(49, 97);
            this.LblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(80, 19);
            this.LblNombre.TabIndex = 120;
            this.LblNombre.Text = "ID Reserva";
            // 
            // LblIdReserva
            // 
            this.LblIdReserva.AutoSize = true;
            this.LblIdReserva.Depth = 0;
            this.LblIdReserva.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblIdReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblIdReserva.Location = new System.Drawing.Point(145, 97);
            this.LblIdReserva.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblIdReserva.Name = "LblIdReserva";
            this.LblIdReserva.Size = new System.Drawing.Size(0, 19);
            this.LblIdReserva.TabIndex = 151;
            // 
            // comboRolUsuario
            // 
            this.comboRolUsuario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboRolUsuario.FormattingEnabled = true;
            this.comboRolUsuario.IntegralHeight = false;
            this.comboRolUsuario.ItemHeight = 23;
            this.comboRolUsuario.Location = new System.Drawing.Point(149, 133);
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
            this.lblRol.Location = new System.Drawing.Point(19, 143);
            this.lblRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(113, 19);
            this.lblRol.TabIndex = 155;
            this.lblRol.Text = "Estado Reserva";
            // 
            // btnCancelarUsuario
            // 
            this.btnCancelarUsuario.AutoSize = true;
            this.btnCancelarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelarUsuario.Depth = 0;
            this.btnCancelarUsuario.Location = new System.Drawing.Point(211, 207);
            this.btnCancelarUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelarUsuario.Name = "btnCancelarUsuario";
            this.btnCancelarUsuario.Primary = false;
            this.btnCancelarUsuario.Size = new System.Drawing.Size(82, 36);
            this.btnCancelarUsuario.TabIndex = 163;
            this.btnCancelarUsuario.Text = "Cancelar";
            this.btnCancelarUsuario.UseVisualStyleBackColor = true;
            this.btnCancelarUsuario.Click += new System.EventHandler(this.BtnCancelarUsuario_Click);
            // 
            // btnRegistrarHuesped
            // 
            this.btnRegistrarHuesped.Depth = 0;
            this.btnRegistrarHuesped.Location = new System.Drawing.Point(65, 207);
            this.btnRegistrarHuesped.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarHuesped.Name = "btnRegistrarHuesped";
            this.btnRegistrarHuesped.Primary = true;
            this.btnRegistrarHuesped.Size = new System.Drawing.Size(126, 36);
            this.btnRegistrarHuesped.TabIndex = 162;
            this.btnRegistrarHuesped.Text = "Registrar";
            this.btnRegistrarHuesped.UseVisualStyleBackColor = true;
            this.btnRegistrarHuesped.Click += new System.EventHandler(this.BtnRegistrarHuesped_Click);
            // 
            // ModalEstadoReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 289);
            this.Controls.Add(this.btnCancelarUsuario);
            this.Controls.Add(this.btnRegistrarHuesped);
            this.Controls.Add(this.comboRolUsuario);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.LblIdReserva);
            this.Controls.Add(this.LblNombre);
            this.Name = "ModalEstadoReserva";
            this.Text = "ModalPago";
            this.Load += new System.EventHandler(this.ModalEstadoReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblNombre;
        private MaterialSkin.Controls.MaterialLabel LblIdReserva;
        private MetroFramework.Controls.MetroComboBox comboRolUsuario;
        private MaterialSkin.Controls.MaterialLabel lblRol;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelarUsuario;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegistrarHuesped;
    }
}