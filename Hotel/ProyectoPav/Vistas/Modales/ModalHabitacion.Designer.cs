﻿namespace ProyectoPav.Vistas.Modales
{
    partial class ModalHabitacion
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
            this.btnCancelarHabitacion = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRegistrarHabitacion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboTipoHabitacion = new MetroFramework.Controls.MetroComboBox();
            this.txtPrecio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNumeroHabitacion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTipoHabitacion = new MaterialSkin.Controls.MaterialLabel();
            this.LblNumeroHabitacion = new MaterialSkin.Controls.MaterialLabel();
            this.comboCategoriaHabitacion = new MetroFramework.Controls.MetroComboBox();
            this.lblCategoriaHabitacion = new MaterialSkin.Controls.MaterialLabel();
            this.comboEstadoHabitacion = new MetroFramework.Controls.MetroComboBox();
            this.lblEstadoHabitacion = new MaterialSkin.Controls.MaterialLabel();
            this.lblPiso = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnCancelarHabitacion
            // 
            this.btnCancelarHabitacion.AutoSize = true;
            this.btnCancelarHabitacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelarHabitacion.Depth = 0;
            this.btnCancelarHabitacion.Location = new System.Drawing.Point(248, 295);
            this.btnCancelarHabitacion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelarHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelarHabitacion.Name = "btnCancelarHabitacion";
            this.btnCancelarHabitacion.Primary = false;
            this.btnCancelarHabitacion.Size = new System.Drawing.Size(82, 36);
            this.btnCancelarHabitacion.TabIndex = 121;
            this.btnCancelarHabitacion.Text = "Cancelar";
            this.btnCancelarHabitacion.UseVisualStyleBackColor = true;
            this.btnCancelarHabitacion.Click += new System.EventHandler(this.BtnCancelarHabitacion_Click);
            // 
            // btnRegistrarHabitacion
            // 
            this.btnRegistrarHabitacion.Depth = 0;
            this.btnRegistrarHabitacion.Location = new System.Drawing.Point(44, 295);
            this.btnRegistrarHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarHabitacion.Name = "btnRegistrarHabitacion";
            this.btnRegistrarHabitacion.Primary = true;
            this.btnRegistrarHabitacion.Size = new System.Drawing.Size(143, 36);
            this.btnRegistrarHabitacion.TabIndex = 120;
            this.btnRegistrarHabitacion.Text = "Registrar";
            this.btnRegistrarHabitacion.UseVisualStyleBackColor = true;
            this.btnRegistrarHabitacion.Click += new System.EventHandler(this.BtnRegistrarHabitacion_Click);
            // 
            // comboTipoHabitacion
            // 
            this.comboTipoHabitacion.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboTipoHabitacion.FormattingEnabled = true;
            this.comboTipoHabitacion.IntegralHeight = false;
            this.comboTipoHabitacion.ItemHeight = 23;
            this.comboTipoHabitacion.Location = new System.Drawing.Point(175, 153);
            this.comboTipoHabitacion.Name = "comboTipoHabitacion";
            this.comboTipoHabitacion.Size = new System.Drawing.Size(171, 29);
            this.comboTipoHabitacion.TabIndex = 119;
            this.comboTipoHabitacion.UseSelectable = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Depth = 0;
            this.txtPrecio.Hint = "";
            this.txtPrecio.Location = new System.Drawing.Point(175, 122);
            this.txtPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.Size = new System.Drawing.Size(171, 23);
            this.txtPrecio.TabIndex = 116;
            this.txtPrecio.UseSystemPasswordChar = false;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // txtNumeroHabitacion
            // 
            this.txtNumeroHabitacion.Depth = 0;
            this.txtNumeroHabitacion.Hint = "";
            this.txtNumeroHabitacion.Location = new System.Drawing.Point(175, 81);
            this.txtNumeroHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumeroHabitacion.Name = "txtNumeroHabitacion";
            this.txtNumeroHabitacion.PasswordChar = '\0';
            this.txtNumeroHabitacion.SelectedText = "";
            this.txtNumeroHabitacion.SelectionLength = 0;
            this.txtNumeroHabitacion.SelectionStart = 0;
            this.txtNumeroHabitacion.Size = new System.Drawing.Size(171, 23);
            this.txtNumeroHabitacion.TabIndex = 113;
            this.txtNumeroHabitacion.UseSystemPasswordChar = false;
            this.txtNumeroHabitacion.Click += new System.EventHandler(this.TxtNumeroHabitacion_Click);
            this.txtNumeroHabitacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroHabitacion_KeyPress);
            // 
            // lblTipoHabitacion
            // 
            this.lblTipoHabitacion.AutoSize = true;
            this.lblTipoHabitacion.Depth = 0;
            this.lblTipoHabitacion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTipoHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTipoHabitacion.Location = new System.Drawing.Point(21, 163);
            this.lblTipoHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipoHabitacion.Name = "lblTipoHabitacion";
            this.lblTipoHabitacion.Size = new System.Drawing.Size(116, 19);
            this.lblTipoHabitacion.TabIndex = 117;
            this.lblTipoHabitacion.Text = "Tipo Habitacion";
            // 
            // LblNumeroHabitacion
            // 
            this.LblNumeroHabitacion.AutoSize = true;
            this.LblNumeroHabitacion.Depth = 0;
            this.LblNumeroHabitacion.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblNumeroHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblNumeroHabitacion.Location = new System.Drawing.Point(21, 81);
            this.LblNumeroHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblNumeroHabitacion.Name = "LblNumeroHabitacion";
            this.LblNumeroHabitacion.Size = new System.Drawing.Size(63, 19);
            this.LblNumeroHabitacion.TabIndex = 112;
            this.LblNumeroHabitacion.Text = "Numero";
            // 
            // comboCategoriaHabitacion
            // 
            this.comboCategoriaHabitacion.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboCategoriaHabitacion.FormattingEnabled = true;
            this.comboCategoriaHabitacion.IntegralHeight = false;
            this.comboCategoriaHabitacion.ItemHeight = 23;
            this.comboCategoriaHabitacion.Location = new System.Drawing.Point(175, 194);
            this.comboCategoriaHabitacion.Name = "comboCategoriaHabitacion";
            this.comboCategoriaHabitacion.Size = new System.Drawing.Size(171, 29);
            this.comboCategoriaHabitacion.TabIndex = 123;
            this.comboCategoriaHabitacion.UseSelectable = true;
            // 
            // lblCategoriaHabitacion
            // 
            this.lblCategoriaHabitacion.AutoSize = true;
            this.lblCategoriaHabitacion.Depth = 0;
            this.lblCategoriaHabitacion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategoriaHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategoriaHabitacion.Location = new System.Drawing.Point(21, 204);
            this.lblCategoriaHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoriaHabitacion.Name = "lblCategoriaHabitacion";
            this.lblCategoriaHabitacion.Size = new System.Drawing.Size(74, 19);
            this.lblCategoriaHabitacion.TabIndex = 122;
            this.lblCategoriaHabitacion.Text = "Categoria";
            // 
            // comboEstadoHabitacion
            // 
            this.comboEstadoHabitacion.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboEstadoHabitacion.FormattingEnabled = true;
            this.comboEstadoHabitacion.IntegralHeight = false;
            this.comboEstadoHabitacion.ItemHeight = 23;
            this.comboEstadoHabitacion.Location = new System.Drawing.Point(175, 239);
            this.comboEstadoHabitacion.Name = "comboEstadoHabitacion";
            this.comboEstadoHabitacion.Size = new System.Drawing.Size(171, 29);
            this.comboEstadoHabitacion.TabIndex = 125;
            this.comboEstadoHabitacion.UseSelectable = true;
            // 
            // lblEstadoHabitacion
            // 
            this.lblEstadoHabitacion.AutoSize = true;
            this.lblEstadoHabitacion.Depth = 0;
            this.lblEstadoHabitacion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoHabitacion.Location = new System.Drawing.Point(21, 246);
            this.lblEstadoHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoHabitacion.Name = "lblEstadoHabitacion";
            this.lblEstadoHabitacion.Size = new System.Drawing.Size(56, 19);
            this.lblEstadoHabitacion.TabIndex = 124;
            this.lblEstadoHabitacion.Text = "Estado";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Depth = 0;
            this.lblPiso.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPiso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPiso.Location = new System.Drawing.Point(21, 122);
            this.lblPiso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(52, 19);
            this.lblPiso.TabIndex = 114;
            this.lblPiso.Text = "Precio";
            // 
            // ModalHabitacion
            // 
            this.AcceptButton = this.btnRegistrarHabitacion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 368);
            this.Controls.Add(this.comboEstadoHabitacion);
            this.Controls.Add(this.lblEstadoHabitacion);
            this.Controls.Add(this.comboCategoriaHabitacion);
            this.Controls.Add(this.lblCategoriaHabitacion);
            this.Controls.Add(this.btnCancelarHabitacion);
            this.Controls.Add(this.btnRegistrarHabitacion);
            this.Controls.Add(this.comboTipoHabitacion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNumeroHabitacion);
            this.Controls.Add(this.lblTipoHabitacion);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.LblNumeroHabitacion);
            this.Name = "ModalHabitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Habitacion";
            this.Load += new System.EventHandler(this.ModalHabitacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton btnCancelarHabitacion;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegistrarHabitacion;
        private MetroFramework.Controls.MetroComboBox comboTipoHabitacion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecio;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumeroHabitacion;
        private MaterialSkin.Controls.MaterialLabel lblTipoHabitacion;
        private MaterialSkin.Controls.MaterialLabel LblNumeroHabitacion;
        private MetroFramework.Controls.MetroComboBox comboCategoriaHabitacion;
        private MaterialSkin.Controls.MaterialLabel lblCategoriaHabitacion;
        private MetroFramework.Controls.MetroComboBox comboEstadoHabitacion;
        private MaterialSkin.Controls.MaterialLabel lblEstadoHabitacion;
        private MaterialSkin.Controls.MaterialLabel lblPiso;
    }
}