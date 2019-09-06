namespace LawyerHelper.UI.Juicios
{
    partial class BajaJuicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.CuadroNumeroDeExpediente = new System.Windows.Forms.TextBox();
            this.BotonDarDeBaja = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro. de expediente:";
            // 
            // CuadroNumeroDeExpediente
            // 
            this.CuadroNumeroDeExpediente.Location = new System.Drawing.Point(118, 19);
            this.CuadroNumeroDeExpediente.Name = "CuadroNumeroDeExpediente";
            this.CuadroNumeroDeExpediente.Size = new System.Drawing.Size(193, 20);
            this.CuadroNumeroDeExpediente.TabIndex = 22;
            // 
            // BotonDarDeBaja
            // 
            this.BotonDarDeBaja.Location = new System.Drawing.Point(15, 124);
            this.BotonDarDeBaja.Name = "BotonDarDeBaja";
            this.BotonDarDeBaja.Size = new System.Drawing.Size(117, 25);
            this.BotonDarDeBaja.TabIndex = 23;
            this.BotonDarDeBaja.Text = "Dar de baja";
            this.BotonDarDeBaja.UseVisualStyleBackColor = true;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(227, 125);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(95, 24);
            this.BotonCancelar.TabIndex = 26;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 24);
            this.button1.TabIndex = 27;
            this.button1.Text = "Buscar por otro campo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BajaJuicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonDarDeBaja);
            this.Controls.Add(this.CuadroNumeroDeExpediente);
            this.Controls.Add(this.label1);
            this.Name = "BajaJuicio";
            this.Text = "BajaJuicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CuadroNumeroDeExpediente;
        private System.Windows.Forms.Button BotonDarDeBaja;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button button1;
    }
}