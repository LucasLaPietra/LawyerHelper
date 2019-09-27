namespace WindowsFormsApp2.Cobros
{
    partial class AltaCobro
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
            this.CuadroAM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CuadroMinutos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CuadroHora = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.BotonPersona = new System.Windows.Forms.Button();
            this.CuadroDetalle = new System.Windows.Forms.TextBox();
            this.CuadroImporte = new System.Windows.Forms.TextBox();
            this.LabelDetalle = new System.Windows.Forms.Label();
            this.LabelImporte = new System.Windows.Forms.Label();
            this.BotonJuicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CuadroAM
            // 
            this.CuadroAM.FormattingEnabled = true;
            this.CuadroAM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.CuadroAM.Location = new System.Drawing.Point(136, 60);
            this.CuadroAM.Name = "CuadroAM";
            this.CuadroAM.Size = new System.Drawing.Size(46, 21);
            this.CuadroAM.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = ":";
            // 
            // CuadroMinutos
            // 
            this.CuadroMinutos.Location = new System.Drawing.Point(106, 61);
            this.CuadroMinutos.Name = "CuadroMinutos";
            this.CuadroMinutos.Size = new System.Drawing.Size(24, 20);
            this.CuadroMinutos.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Hora:";
            // 
            // CuadroHora
            // 
            this.CuadroHora.Location = new System.Drawing.Point(68, 61);
            this.CuadroHora.Name = "CuadroHora";
            this.CuadroHora.Size = new System.Drawing.Size(24, 20);
            this.CuadroHora.TabIndex = 27;
            this.CuadroHora.TextChanged += new System.EventHandler(this.CuadroHora_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(68, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(178, 330);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(95, 24);
            this.BotonCancelar.TabIndex = 25;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Location = new System.Drawing.Point(12, 330);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(95, 24);
            this.BotonAceptar.TabIndex = 24;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            // 
            // BotonPersona
            // 
            this.BotonPersona.Location = new System.Drawing.Point(53, 254);
            this.BotonPersona.Name = "BotonPersona";
            this.BotonPersona.Size = new System.Drawing.Size(180, 26);
            this.BotonPersona.TabIndex = 23;
            this.BotonPersona.Text = "Asignar cobro a persona";
            this.BotonPersona.UseVisualStyleBackColor = true;
            // 
            // CuadroDetalle
            // 
            this.CuadroDetalle.Location = new System.Drawing.Point(68, 130);
            this.CuadroDetalle.Multiline = true;
            this.CuadroDetalle.Name = "CuadroDetalle";
            this.CuadroDetalle.Size = new System.Drawing.Size(193, 108);
            this.CuadroDetalle.TabIndex = 22;
            // 
            // CuadroImporte
            // 
            this.CuadroImporte.Location = new System.Drawing.Point(68, 98);
            this.CuadroImporte.Name = "CuadroImporte";
            this.CuadroImporte.Size = new System.Drawing.Size(193, 20);
            this.CuadroImporte.TabIndex = 21;
            // 
            // LabelDetalle
            // 
            this.LabelDetalle.AutoSize = true;
            this.LabelDetalle.Location = new System.Drawing.Point(19, 130);
            this.LabelDetalle.Name = "LabelDetalle";
            this.LabelDetalle.Size = new System.Drawing.Size(43, 13);
            this.LabelDetalle.TabIndex = 20;
            this.LabelDetalle.Text = "Detalle:";
            // 
            // LabelImporte
            // 
            this.LabelImporte.AutoSize = true;
            this.LabelImporte.Location = new System.Drawing.Point(17, 101);
            this.LabelImporte.Name = "LabelImporte";
            this.LabelImporte.Size = new System.Drawing.Size(45, 13);
            this.LabelImporte.TabIndex = 19;
            this.LabelImporte.Text = "Importe:";
            // 
            // BotonJuicio
            // 
            this.BotonJuicio.Location = new System.Drawing.Point(53, 286);
            this.BotonJuicio.Name = "BotonJuicio";
            this.BotonJuicio.Size = new System.Drawing.Size(180, 26);
            this.BotonJuicio.TabIndex = 33;
            this.BotonJuicio.Text = "Asignar cobro a juicio";
            this.BotonJuicio.UseVisualStyleBackColor = true;
            // 
            // AltaCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 381);
            this.Controls.Add(this.BotonJuicio);
            this.Controls.Add(this.CuadroAM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CuadroMinutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CuadroHora);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.BotonPersona);
            this.Controls.Add(this.CuadroDetalle);
            this.Controls.Add(this.CuadroImporte);
            this.Controls.Add(this.LabelDetalle);
            this.Controls.Add(this.LabelImporte);
            this.Name = "AltaCobro";
            this.Text = "AltaCobro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CuadroAM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CuadroMinutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CuadroHora;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Button BotonPersona;
        private System.Windows.Forms.TextBox CuadroDetalle;
        private System.Windows.Forms.TextBox CuadroImporte;
        private System.Windows.Forms.Label LabelDetalle;
        private System.Windows.Forms.Label LabelImporte;
        private System.Windows.Forms.Button BotonJuicio;
    }
}