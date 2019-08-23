namespace WindowsFormsApp2
{
    partial class MenuAgenda
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
            this.BotonAtras = new System.Windows.Forms.Button();
            this.BotonConsulta = new System.Windows.Forms.Button();
            this.BotonModificacion = new System.Windows.Forms.Button();
            this.BotonBaja = new System.Windows.Forms.Button();
            this.BotonAlta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonAtras
            // 
            this.BotonAtras.Location = new System.Drawing.Point(12, 402);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(105, 27);
            this.BotonAtras.TabIndex = 17;
            this.BotonAtras.Text = "Atras";
            this.BotonAtras.UseVisualStyleBackColor = true;
            // 
            // BotonConsulta
            // 
            this.BotonConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BotonConsulta.Location = new System.Drawing.Point(60, 312);
            this.BotonConsulta.Name = "BotonConsulta";
            this.BotonConsulta.Size = new System.Drawing.Size(167, 45);
            this.BotonConsulta.TabIndex = 16;
            this.BotonConsulta.Text = "Consulta";
            this.BotonConsulta.UseVisualStyleBackColor = true;
            // 
            // BotonModificacion
            // 
            this.BotonModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BotonModificacion.Location = new System.Drawing.Point(60, 235);
            this.BotonModificacion.Name = "BotonModificacion";
            this.BotonModificacion.Size = new System.Drawing.Size(167, 45);
            this.BotonModificacion.TabIndex = 15;
            this.BotonModificacion.Text = "Modificacion";
            this.BotonModificacion.UseVisualStyleBackColor = true;
            // 
            // BotonBaja
            // 
            this.BotonBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BotonBaja.Location = new System.Drawing.Point(60, 158);
            this.BotonBaja.Name = "BotonBaja";
            this.BotonBaja.Size = new System.Drawing.Size(167, 45);
            this.BotonBaja.TabIndex = 14;
            this.BotonBaja.Text = "Baja";
            this.BotonBaja.UseVisualStyleBackColor = true;
            // 
            // BotonAlta
            // 
            this.BotonAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BotonAlta.Location = new System.Drawing.Point(60, 81);
            this.BotonAlta.Name = "BotonAlta";
            this.BotonAlta.Size = new System.Drawing.Size(167, 45);
            this.BotonAlta.TabIndex = 13;
            this.BotonAlta.Text = "Alta";
            this.BotonAlta.UseVisualStyleBackColor = true;
            // 
            // MenuAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 441);
            this.Controls.Add(this.BotonAtras);
            this.Controls.Add(this.BotonConsulta);
            this.Controls.Add(this.BotonModificacion);
            this.Controls.Add(this.BotonBaja);
            this.Controls.Add(this.BotonAlta);
            this.Name = "MenuAgenda";
            this.Text = "MenuAgenda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonAtras;
        private System.Windows.Forms.Button BotonConsulta;
        private System.Windows.Forms.Button BotonModificacion;
        private System.Windows.Forms.Button BotonBaja;
        private System.Windows.Forms.Button BotonAlta;
    }
}