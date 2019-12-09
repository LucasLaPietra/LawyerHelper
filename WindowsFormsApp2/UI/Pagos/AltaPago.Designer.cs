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
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.CuadroImporte = new System.Windows.Forms.NumericUpDown();
            this.BotonAgregarJuicio = new System.Windows.Forms.Button();
            this.CuadroJuicio = new System.Windows.Forms.TextBox();
            this.LabelJuicio = new System.Windows.Forms.Label();
            this.CuadroDetalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CuadroMinutos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CuadroHora = new System.Windows.Forms.TextBox();
            this.CuadroFecha = new System.Windows.Forms.DateTimePicker();
            this.BotonCancelar1 = new System.Windows.Forms.Button();
            this.BotonAceptar1 = new System.Windows.Forms.Button();
            this.LabelDetalle = new System.Windows.Forms.Label();
            this.LabelImporte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CuadroImporte)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Location = new System.Drawing.Point(55, 383);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(95, 24);
            this.BotonAceptar.TabIndex = 9;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(221, 383);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(95, 24);
            this.BotonCancelar.TabIndex = 10;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            // 
            // CuadroImporte
            // 
            this.CuadroImporte.Location = new System.Drawing.Point(68, 92);
            this.CuadroImporte.Name = "CuadroImporte";
            this.CuadroImporte.Size = new System.Drawing.Size(221, 20);
            this.CuadroImporte.TabIndex = 190;
            // 
            // BotonAgregarJuicio
            // 
            this.BotonAgregarJuicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAgregarJuicio.Location = new System.Drawing.Point(214, 275);
            this.BotonAgregarJuicio.Name = "BotonAgregarJuicio";
            this.BotonAgregarJuicio.Size = new System.Drawing.Size(75, 23);
            this.BotonAgregarJuicio.TabIndex = 189;
            this.BotonAgregarJuicio.Text = "Agregar";
            this.BotonAgregarJuicio.UseVisualStyleBackColor = true;
            this.BotonAgregarJuicio.Click += new System.EventHandler(this.BotonAgregarJuicio_Click);
            // 
            // CuadroJuicio
            // 
            this.CuadroJuicio.Location = new System.Drawing.Point(68, 277);
            this.CuadroJuicio.Name = "CuadroJuicio";
            this.CuadroJuicio.Size = new System.Drawing.Size(140, 20);
            this.CuadroJuicio.TabIndex = 187;
            this.CuadroJuicio.Text = "Ninguno";
            // 
            // LabelJuicio
            // 
            this.LabelJuicio.AutoSize = true;
            this.LabelJuicio.Location = new System.Drawing.Point(25, 280);
            this.LabelJuicio.Name = "LabelJuicio";
            this.LabelJuicio.Size = new System.Drawing.Size(37, 13);
            this.LabelJuicio.TabIndex = 185;
            this.LabelJuicio.Text = "Juicio:";
            // 
            // CuadroDetalle
            // 
            this.CuadroDetalle.Location = new System.Drawing.Point(68, 123);
            this.CuadroDetalle.Multiline = true;
            this.CuadroDetalle.Name = "CuadroDetalle";
            this.CuadroDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CuadroDetalle.Size = new System.Drawing.Size(221, 108);
            this.CuadroDetalle.TabIndex = 183;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 181;
            this.label3.Text = ":";
            // 
            // CuadroMinutos
            // 
            this.CuadroMinutos.Location = new System.Drawing.Point(106, 54);
            this.CuadroMinutos.Name = "CuadroMinutos";
            this.CuadroMinutos.Size = new System.Drawing.Size(24, 20);
            this.CuadroMinutos.TabIndex = 180;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 179;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 178;
            this.label1.Text = "Hora:";
            // 
            // CuadroHora
            // 
            this.CuadroHora.Location = new System.Drawing.Point(68, 54);
            this.CuadroHora.Name = "CuadroHora";
            this.CuadroHora.Size = new System.Drawing.Size(24, 20);
            this.CuadroHora.TabIndex = 177;
            // 
            // CuadroFecha
            // 
            this.CuadroFecha.Location = new System.Drawing.Point(68, 19);
            this.CuadroFecha.Name = "CuadroFecha";
            this.CuadroFecha.Size = new System.Drawing.Size(221, 20);
            this.CuadroFecha.TabIndex = 176;
            this.CuadroFecha.ValueChanged += new System.EventHandler(this.CuadroFecha_ValueChanged);
            // 
            // BotonCancelar1
            // 
            this.BotonCancelar1.Location = new System.Drawing.Point(194, 338);
            this.BotonCancelar1.Name = "BotonCancelar1";
            this.BotonCancelar1.Size = new System.Drawing.Size(95, 24);
            this.BotonCancelar1.TabIndex = 175;
            this.BotonCancelar1.Text = "Cancelar";
            this.BotonCancelar1.UseVisualStyleBackColor = true;
            this.BotonCancelar1.Click += new System.EventHandler(this.BotonCancelar1_Click);
            // 
            // BotonAceptar1
            // 
            this.BotonAceptar1.Location = new System.Drawing.Point(12, 338);
            this.BotonAceptar1.Name = "BotonAceptar1";
            this.BotonAceptar1.Size = new System.Drawing.Size(95, 24);
            this.BotonAceptar1.TabIndex = 174;
            this.BotonAceptar1.Text = "Aceptar";
            this.BotonAceptar1.UseVisualStyleBackColor = true;
            this.BotonAceptar1.Click += new System.EventHandler(this.BotonAceptar1_Click);
            // 
            // LabelDetalle
            // 
            this.LabelDetalle.AutoSize = true;
            this.LabelDetalle.Location = new System.Drawing.Point(19, 123);
            this.LabelDetalle.Name = "LabelDetalle";
            this.LabelDetalle.Size = new System.Drawing.Size(43, 13);
            this.LabelDetalle.TabIndex = 173;
            this.LabelDetalle.Text = "Detalle:";
            // 
            // LabelImporte
            // 
            this.LabelImporte.AutoSize = true;
            this.LabelImporte.Location = new System.Drawing.Point(17, 94);
            this.LabelImporte.Name = "LabelImporte";
            this.LabelImporte.Size = new System.Drawing.Size(45, 13);
            this.LabelImporte.TabIndex = 172;
            this.LabelImporte.Text = "Importe:";
            // 
            // AltaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 381);
            this.Controls.Add(this.CuadroImporte);
            this.Controls.Add(this.BotonAgregarJuicio);
            this.Controls.Add(this.CuadroJuicio);
            this.Controls.Add(this.LabelJuicio);
            this.Controls.Add(this.CuadroDetalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CuadroMinutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CuadroHora);
            this.Controls.Add(this.CuadroFecha);
            this.Controls.Add(this.BotonCancelar1);
            this.Controls.Add(this.BotonAceptar1);
            this.Controls.Add(this.LabelDetalle);
            this.Controls.Add(this.LabelImporte);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAceptar);
            this.Name = "AltaPago";
            this.Text = "AltaPago";
            this.Load += new System.EventHandler(this.AltaPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CuadroImporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.NumericUpDown CuadroImporte;
        private System.Windows.Forms.Button BotonAgregarJuicio;
        private System.Windows.Forms.TextBox CuadroJuicio;
        private System.Windows.Forms.Label LabelJuicio;
        private System.Windows.Forms.TextBox CuadroDetalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CuadroMinutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CuadroHora;
        private System.Windows.Forms.DateTimePicker CuadroFecha;
        private System.Windows.Forms.Button BotonCancelar1;
        private System.Windows.Forms.Button BotonAceptar1;
        private System.Windows.Forms.Label LabelDetalle;
        private System.Windows.Forms.Label LabelImporte;
    }
}