namespace ProyectoPav.Vistas.Modales
{
    partial class ModalCentral
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
            this.btnModalHabitacion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnModalHuesped = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnModalUsuario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // btnModalHabitacion
            // 
            this.btnModalHabitacion.Depth = 0;
            this.btnModalHabitacion.Location = new System.Drawing.Point(76, 93);
            this.btnModalHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModalHabitacion.Name = "btnModalHabitacion";
            this.btnModalHabitacion.Primary = true;
            this.btnModalHabitacion.Size = new System.Drawing.Size(144, 50);
            this.btnModalHabitacion.TabIndex = 1;
            this.btnModalHabitacion.Text = "Modal Habitacion";
            this.btnModalHabitacion.UseVisualStyleBackColor = true;
            this.btnModalHabitacion.Click += new System.EventHandler(this.BtnModalHabitacion_Click);
            // 
            // btnModalHuesped
            // 
            this.btnModalHuesped.Depth = 0;
            this.btnModalHuesped.Location = new System.Drawing.Point(257, 93);
            this.btnModalHuesped.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModalHuesped.Name = "btnModalHuesped";
            this.btnModalHuesped.Primary = true;
            this.btnModalHuesped.Size = new System.Drawing.Size(144, 50);
            this.btnModalHuesped.TabIndex = 2;
            this.btnModalHuesped.Text = "Modal Huesped";
            this.btnModalHuesped.UseVisualStyleBackColor = true;
            this.btnModalHuesped.Click += new System.EventHandler(this.BtnModalHuesped_Click);
            // 
            // btnModalUsuario
            // 
            this.btnModalUsuario.Depth = 0;
            this.btnModalUsuario.Location = new System.Drawing.Point(437, 93);
            this.btnModalUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModalUsuario.Name = "btnModalUsuario";
            this.btnModalUsuario.Primary = true;
            this.btnModalUsuario.Size = new System.Drawing.Size(144, 50);
            this.btnModalUsuario.TabIndex = 3;
            this.btnModalUsuario.Text = "Modal Usuario";
            this.btnModalUsuario.UseVisualStyleBackColor = true;
            this.btnModalUsuario.Click += new System.EventHandler(this.BtnModalUsuario_Click);
            // 
            // ModalCentral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 173);
            this.Controls.Add(this.btnModalUsuario);
            this.Controls.Add(this.btnModalHuesped);
            this.Controls.Add(this.btnModalHabitacion);
            this.Name = "ModalCentral";
            this.Text = "ModalCentral";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnModalHabitacion;
        private MaterialSkin.Controls.MaterialRaisedButton btnModalHuesped;
        private MaterialSkin.Controls.MaterialRaisedButton btnModalUsuario;
    }
}