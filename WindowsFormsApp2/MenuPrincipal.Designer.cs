namespace WindowsFormsApp2
{
    partial class MenuPrincipal
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
            this.BotonPersonas = new System.Windows.Forms.Button();
            this.BotonJuicios = new System.Windows.Forms.Button();
            this.BotonAgenda = new System.Windows.Forms.Button();
            this.BotonPagos = new System.Windows.Forms.Button();
            this.BotonCobros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonPersonas
            // 
            this.BotonPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BotonPersonas.Location = new System.Drawing.Point(57, 42);
            this.BotonPersonas.Name = "BotonPersonas";
            this.BotonPersonas.Size = new System.Drawing.Size(167, 45);
            this.BotonPersonas.TabIndex = 0;
            this.BotonPersonas.Text = "Personas";
            this.BotonPersonas.UseVisualStyleBackColor = true;
            this.BotonPersonas.Click += new System.EventHandler(this.BotonPersonas_Click);
            // 
            // BotonJuicios
            // 
            this.BotonJuicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BotonJuicios.Location = new System.Drawing.Point(57, 119);
            this.BotonJuicios.Name = "BotonJuicios";
            this.BotonJuicios.Size = new System.Drawing.Size(167, 45);
            this.BotonJuicios.TabIndex = 1;
            this.BotonJuicios.Text = "Juicios";
            this.BotonJuicios.UseVisualStyleBackColor = true;
            this.BotonJuicios.Click += new System.EventHandler(this.BotonJuicios_Click);
            // 
            // BotonAgenda
            // 
            this.BotonAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BotonAgenda.Location = new System.Drawing.Point(57, 196);
            this.BotonAgenda.Name = "BotonAgenda";
            this.BotonAgenda.Size = new System.Drawing.Size(167, 45);
            this.BotonAgenda.TabIndex = 2;
            this.BotonAgenda.Text = "Agenda";
            this.BotonAgenda.UseVisualStyleBackColor = true;
            this.BotonAgenda.Click += new System.EventHandler(this.BotonAgenda_Click);
            // 
            // BotonPagos
            // 
            this.BotonPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BotonPagos.Location = new System.Drawing.Point(57, 273);
            this.BotonPagos.Name = "BotonPagos";
            this.BotonPagos.Size = new System.Drawing.Size(167, 45);
            this.BotonPagos.TabIndex = 3;
            this.BotonPagos.Text = "Pagos";
            this.BotonPagos.UseVisualStyleBackColor = true;
            this.BotonPagos.Click += new System.EventHandler(this.BotonPagos_Click);
            // 
            // BotonCobros
            // 
            this.BotonCobros.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BotonCobros.Location = new System.Drawing.Point(57, 350);
            this.BotonCobros.Name = "BotonCobros";
            this.BotonCobros.Size = new System.Drawing.Size(167, 45);
            this.BotonCobros.TabIndex = 4;
            this.BotonCobros.Text = "Cobros";
            this.BotonCobros.UseVisualStyleBackColor = true;
            this.BotonCobros.Click += new System.EventHandler(this.BotonCobros_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 436);
            this.Controls.Add(this.BotonCobros);
            this.Controls.Add(this.BotonPagos);
            this.Controls.Add(this.BotonAgenda);
            this.Controls.Add(this.BotonJuicios);
            this.Controls.Add(this.BotonPersonas);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonPersonas;
        private System.Windows.Forms.Button BotonJuicios;
        private System.Windows.Forms.Button BotonAgenda;
        private System.Windows.Forms.Button BotonPagos;
        private System.Windows.Forms.Button BotonCobros;
    }
}

