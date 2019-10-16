namespace LawyerHelper.UI
{
    partial class Ajustes
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
            this.BotonClaro = new System.Windows.Forms.Button();
            this.BotonOscuro = new System.Windows.Forms.Button();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonClaro
            // 
            this.BotonClaro.Location = new System.Drawing.Point(47, 93);
            this.BotonClaro.Name = "BotonClaro";
            this.BotonClaro.Size = new System.Drawing.Size(75, 23);
            this.BotonClaro.TabIndex = 0;
            this.BotonClaro.Text = "Claro";
            this.BotonClaro.UseVisualStyleBackColor = true;
            this.BotonClaro.Click += new System.EventHandler(this.BotonClaro_Click);
            // 
            // BotonOscuro
            // 
            this.BotonOscuro.Location = new System.Drawing.Point(229, 93);
            this.BotonOscuro.Name = "BotonOscuro";
            this.BotonOscuro.Size = new System.Drawing.Size(75, 23);
            this.BotonOscuro.TabIndex = 1;
            this.BotonOscuro.Text = "Oscuro";
            this.BotonOscuro.UseVisualStyleBackColor = true;
            this.BotonOscuro.Click += new System.EventHandler(this.BotonOscuro_Click);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BotonAceptar.Location = new System.Drawing.Point(139, 175);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(75, 23);
            this.BotonAceptar.TabIndex = 2;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            // 
            // Ajustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 210);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.BotonOscuro);
            this.Controls.Add(this.BotonClaro);
            this.Name = "Ajustes";
            this.Text = "Ajustes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonClaro;
        private System.Windows.Forms.Button BotonOscuro;
        private System.Windows.Forms.Button BotonAceptar;
    }
}