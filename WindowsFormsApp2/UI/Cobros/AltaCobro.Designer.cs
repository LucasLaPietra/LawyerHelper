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
            this.label3 = new System.Windows.Forms.Label();
            this.CuadroMinutos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CuadroHora = new System.Windows.Forms.TextBox();
            this.CuadroFecha = new System.Windows.Forms.DateTimePicker();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.LabelDetalle = new System.Windows.Forms.Label();
            this.LabelImporte = new System.Windows.Forms.Label();
            this.CuadroDetalle = new System.Windows.Forms.TextBox();
            this.LabelPersona = new System.Windows.Forms.Label();
            this.LabelJuicio = new System.Windows.Forms.Label();
            this.CuadroPersona = new System.Windows.Forms.TextBox();
            this.CuadroJuicio = new System.Windows.Forms.TextBox();
            this.BotonAgregarPersona = new System.Windows.Forms.Button();
            this.BotonAgregarJuicio = new System.Windows.Forms.Button();
            this.CuadroImporte = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CuadroImporte)).BeginInit();
            this.SuspendLayout();
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
            // CuadroFecha
            // 
            this.CuadroFecha.Location = new System.Drawing.Point(68, 26);
            this.CuadroFecha.Name = "CuadroFecha";
            this.CuadroFecha.Size = new System.Drawing.Size(221, 20);
            this.CuadroFecha.TabIndex = 26;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(194, 345);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(95, 24);
            this.BotonCancelar.TabIndex = 25;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Location = new System.Drawing.Point(12, 345);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(95, 24);
            this.BotonAceptar.TabIndex = 24;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
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
            // CuadroDetalle
            // 
            this.CuadroDetalle.Location = new System.Drawing.Point(68, 130);
            this.CuadroDetalle.Multiline = true;
            this.CuadroDetalle.Name = "CuadroDetalle";
            this.CuadroDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CuadroDetalle.Size = new System.Drawing.Size(221, 108);
            this.CuadroDetalle.TabIndex = 164;
            // 
            // LabelPersona
            // 
            this.LabelPersona.AutoSize = true;
            this.LabelPersona.Location = new System.Drawing.Point(13, 255);
            this.LabelPersona.Name = "LabelPersona";
            this.LabelPersona.Size = new System.Drawing.Size(49, 13);
            this.LabelPersona.TabIndex = 165;
            this.LabelPersona.Text = "Persona:";
            // 
            // LabelJuicio
            // 
            this.LabelJuicio.AutoSize = true;
            this.LabelJuicio.Location = new System.Drawing.Point(25, 287);
            this.LabelJuicio.Name = "LabelJuicio";
            this.LabelJuicio.Size = new System.Drawing.Size(37, 13);
            this.LabelJuicio.TabIndex = 166;
            this.LabelJuicio.Text = "Juicio:";
            // 
            // CuadroPersona
            // 
            this.CuadroPersona.Location = new System.Drawing.Point(68, 252);
            this.CuadroPersona.Name = "CuadroPersona";
            this.CuadroPersona.Size = new System.Drawing.Size(140, 20);
            this.CuadroPersona.TabIndex = 167;
            this.CuadroPersona.Text = "Ninguna";
            // 
            // CuadroJuicio
            // 
            this.CuadroJuicio.Location = new System.Drawing.Point(68, 284);
            this.CuadroJuicio.Name = "CuadroJuicio";
            this.CuadroJuicio.Size = new System.Drawing.Size(140, 20);
            this.CuadroJuicio.TabIndex = 168;
            this.CuadroJuicio.Text = "Ninguno";
            // 
            // BotonAgregarPersona
            // 
            this.BotonAgregarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAgregarPersona.Location = new System.Drawing.Point(214, 250);
            this.BotonAgregarPersona.Name = "BotonAgregarPersona";
            this.BotonAgregarPersona.Size = new System.Drawing.Size(75, 23);
            this.BotonAgregarPersona.TabIndex = 169;
            this.BotonAgregarPersona.Text = "Agregar";
            this.BotonAgregarPersona.UseVisualStyleBackColor = true;
            this.BotonAgregarPersona.Click += new System.EventHandler(this.BotonAgregarPersona_Click);
            // 
            // BotonAgregarJuicio
            // 
            this.BotonAgregarJuicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAgregarJuicio.Location = new System.Drawing.Point(214, 282);
            this.BotonAgregarJuicio.Name = "BotonAgregarJuicio";
            this.BotonAgregarJuicio.Size = new System.Drawing.Size(75, 23);
            this.BotonAgregarJuicio.TabIndex = 170;
            this.BotonAgregarJuicio.Text = "Agregar";
            this.BotonAgregarJuicio.UseVisualStyleBackColor = true;
            this.BotonAgregarJuicio.Click += new System.EventHandler(this.BotonAgregarJuicio_Click);
            // 
            // CuadroImporte
            // 
            this.CuadroImporte.Location = new System.Drawing.Point(68, 99);
            this.CuadroImporte.Name = "CuadroImporte";
            this.CuadroImporte.Size = new System.Drawing.Size(221, 20);
            this.CuadroImporte.TabIndex = 171;
            // 
            // AltaCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 381);
            this.Controls.Add(this.CuadroImporte);
            this.Controls.Add(this.BotonAgregarJuicio);
            this.Controls.Add(this.BotonAgregarPersona);
            this.Controls.Add(this.CuadroJuicio);
            this.Controls.Add(this.CuadroPersona);
            this.Controls.Add(this.LabelJuicio);
            this.Controls.Add(this.LabelPersona);
            this.Controls.Add(this.CuadroDetalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CuadroMinutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CuadroHora);
            this.Controls.Add(this.CuadroFecha);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.LabelDetalle);
            this.Controls.Add(this.LabelImporte);
            this.Name = "AltaCobro";
            this.Text = "AltaCobro";
            ((System.ComponentModel.ISupportInitialize)(this.CuadroImporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CuadroMinutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CuadroHora;
        private System.Windows.Forms.DateTimePicker CuadroFecha;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Label LabelDetalle;
        private System.Windows.Forms.Label LabelImporte;
        private System.Windows.Forms.TextBox CuadroDetalle;
        private System.Windows.Forms.Label LabelPersona;
        private System.Windows.Forms.Label LabelJuicio;
        private System.Windows.Forms.TextBox CuadroPersona;
        private System.Windows.Forms.TextBox CuadroJuicio;
        private System.Windows.Forms.Button BotonAgregarPersona;
        private System.Windows.Forms.Button BotonAgregarJuicio;
        private System.Windows.Forms.NumericUpDown CuadroImporte;
    }
}