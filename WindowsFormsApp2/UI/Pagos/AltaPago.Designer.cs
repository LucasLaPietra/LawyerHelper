namespace WindowsFormsApp2.Pagos
{
    partial class AltaPago
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
            this.LabelImporte = new System.Windows.Forms.Label();
            this.LabelDetalle = new System.Windows.Forms.Label();
            this.CuadroImporte = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BotonJuicio = new System.Windows.Forms.Button();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CuadroHora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CuadroMinutos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CuadroAM = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LabelImporte
            // 
            this.LabelImporte.AutoSize = true;
            this.LabelImporte.Location = new System.Drawing.Point(21, 126);
            this.LabelImporte.Name = "LabelImporte";
            this.LabelImporte.Size = new System.Drawing.Size(45, 13);
            this.LabelImporte.TabIndex = 2;
            this.LabelImporte.Text = "Importe:";
            // 
            // LabelDetalle
            // 
            this.LabelDetalle.AutoSize = true;
            this.LabelDetalle.Location = new System.Drawing.Point(21, 175);
            this.LabelDetalle.Name = "LabelDetalle";
            this.LabelDetalle.Size = new System.Drawing.Size(43, 13);
            this.LabelDetalle.TabIndex = 3;
            this.LabelDetalle.Text = "Detalle:";
            // 
            // CuadroImporte
            // 
            this.CuadroImporte.Location = new System.Drawing.Point(67, 122);
            this.CuadroImporte.Name = "CuadroImporte";
            this.CuadroImporte.Size = new System.Drawing.Size(290, 20);
            this.CuadroImporte.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 177);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 165);
            this.textBox1.TabIndex = 7;
            // 
            // BotonJuicio
            // 
            this.BotonJuicio.Location = new System.Drawing.Point(97, 372);
            this.BotonJuicio.Name = "BotonJuicio";
            this.BotonJuicio.Size = new System.Drawing.Size(180, 26);
            this.BotonJuicio.TabIndex = 8;
            this.BotonJuicio.Text = "Asignar pago a juicio";
            this.BotonJuicio.UseVisualStyleBackColor = true;
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Location = new System.Drawing.Point(54, 433);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(95, 24);
            this.BotonAceptar.TabIndex = 9;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(220, 433);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(95, 24);
            this.BotonCancelar.TabIndex = 10;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(67, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(290, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // CuadroHora
            // 
            this.CuadroHora.Location = new System.Drawing.Point(67, 73);
            this.CuadroHora.Name = "CuadroHora";
            this.CuadroHora.Size = new System.Drawing.Size(24, 20);
            this.CuadroHora.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha:";
            // 
            // CuadroMinutos
            // 
            this.CuadroMinutos.Location = new System.Drawing.Point(105, 73);
            this.CuadroMinutos.Name = "CuadroMinutos";
            this.CuadroMinutos.Size = new System.Drawing.Size(24, 20);
            this.CuadroMinutos.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = ":";
            // 
            // CuadroAM
            // 
            this.CuadroAM.FormattingEnabled = true;
            this.CuadroAM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.CuadroAM.Location = new System.Drawing.Point(135, 73);
            this.CuadroAM.Name = "CuadroAM";
            this.CuadroAM.Size = new System.Drawing.Size(46, 21);
            this.CuadroAM.TabIndex = 18;
            this.CuadroAM.SelectedIndexChanged += new System.EventHandler(this.CuadroAM_SelectedIndexChanged);
            // 
            // AltaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 496);
            this.Controls.Add(this.CuadroAM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CuadroMinutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CuadroHora);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.BotonJuicio);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CuadroImporte);
            this.Controls.Add(this.LabelDetalle);
            this.Controls.Add(this.LabelImporte);
            this.Name = "AltaPago";
            this.Text = "AltaPago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelImporte;
        private System.Windows.Forms.Label LabelDetalle;
        private System.Windows.Forms.TextBox CuadroImporte;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BotonJuicio;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox CuadroHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CuadroMinutos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CuadroAM;
    }
}