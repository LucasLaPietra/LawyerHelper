namespace LawyerHelper.UI.Pagos
{
    partial class BajaPago
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
            this.LabelFecha = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.BotonJuiciosAsignados = new System.Windows.Forms.Button();
            this.LabelHora = new System.Windows.Forms.Label();
            this.LabelImporte = new System.Windows.Forms.Label();
            this.LabelDetalle = new System.Windows.Forms.Label();
            this.LabelImporte2 = new System.Windows.Forms.Label();
            this.LabelHora2 = new System.Windows.Forms.Label();
            this.ListBoxPagos = new System.Windows.Forms.ListBox();
            this.CuadroDetalle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelFecha
            // 
            this.LabelFecha.AutoSize = true;
            this.LabelFecha.Location = new System.Drawing.Point(10, 39);
            this.LabelFecha.Name = "LabelFecha";
            this.LabelFecha.Size = new System.Drawing.Size(37, 13);
            this.LabelFecha.TabIndex = 3;
            this.LabelFecha.Text = "Fecha";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(53, 35);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(319, 20);
            this.dateTimePickerFecha.TabIndex = 6;
            this.dateTimePickerFecha.ValueChanged += new System.EventHandler(this.dateTimePickerFecha_ValueChanged);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(275, 495);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(97, 24);
            this.BotonCancelar.TabIndex = 70;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Location = new System.Drawing.Point(12, 495);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(95, 24);
            this.BotonAceptar.TabIndex = 69;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // BotonJuiciosAsignados
            // 
            this.BotonJuiciosAsignados.Location = new System.Drawing.Point(109, 438);
            this.BotonJuiciosAsignados.Name = "BotonJuiciosAsignados";
            this.BotonJuiciosAsignados.Size = new System.Drawing.Size(177, 23);
            this.BotonJuiciosAsignados.TabIndex = 94;
            this.BotonJuiciosAsignados.Text = "Ver Juicio asignado";
            this.BotonJuiciosAsignados.UseVisualStyleBackColor = true;
            this.BotonJuiciosAsignados.Click += new System.EventHandler(this.BotonJuiciosAsignados_Click);
            // 
            // LabelHora
            // 
            this.LabelHora.AutoSize = true;
            this.LabelHora.Location = new System.Drawing.Point(10, 270);
            this.LabelHora.Name = "LabelHora";
            this.LabelHora.Size = new System.Drawing.Size(30, 13);
            this.LabelHora.TabIndex = 97;
            this.LabelHora.Text = "Hora";
            // 
            // LabelImporte
            // 
            this.LabelImporte.AutoSize = true;
            this.LabelImporte.Location = new System.Drawing.Point(10, 305);
            this.LabelImporte.Name = "LabelImporte";
            this.LabelImporte.Size = new System.Drawing.Size(42, 13);
            this.LabelImporte.TabIndex = 98;
            this.LabelImporte.Text = "Importe";
            // 
            // LabelDetalle
            // 
            this.LabelDetalle.AutoSize = true;
            this.LabelDetalle.Location = new System.Drawing.Point(10, 342);
            this.LabelDetalle.Name = "LabelDetalle";
            this.LabelDetalle.Size = new System.Drawing.Size(40, 13);
            this.LabelDetalle.TabIndex = 99;
            this.LabelDetalle.Text = "Detalle";
            // 
            // LabelImporte2
            // 
            this.LabelImporte2.AutoSize = true;
            this.LabelImporte2.Location = new System.Drawing.Point(67, 305);
            this.LabelImporte2.Name = "LabelImporte2";
            this.LabelImporte2.Size = new System.Drawing.Size(10, 13);
            this.LabelImporte2.TabIndex = 110;
            this.LabelImporte2.Text = "-";
            // 
            // LabelHora2
            // 
            this.LabelHora2.AutoSize = true;
            this.LabelHora2.Location = new System.Drawing.Point(67, 270);
            this.LabelHora2.Name = "LabelHora2";
            this.LabelHora2.Size = new System.Drawing.Size(10, 13);
            this.LabelHora2.TabIndex = 112;
            this.LabelHora2.Text = "-";
            // 
            // ListBoxPagos
            // 
            this.ListBoxPagos.FormattingEnabled = true;
            this.ListBoxPagos.Location = new System.Drawing.Point(12, 72);
            this.ListBoxPagos.Name = "ListBoxPagos";
            this.ListBoxPagos.Size = new System.Drawing.Size(360, 186);
            this.ListBoxPagos.TabIndex = 130;
            this.ListBoxPagos.SelectedIndexChanged += new System.EventHandler(this.ListBoxPagos_SelectedIndexChanged);
            // 
            // CuadroDetalle
            // 
            this.CuadroDetalle.Location = new System.Drawing.Point(70, 342);
            this.CuadroDetalle.Multiline = true;
            this.CuadroDetalle.Name = "CuadroDetalle";
            this.CuadroDetalle.ReadOnly = true;
            this.CuadroDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CuadroDetalle.Size = new System.Drawing.Size(302, 62);
            this.CuadroDetalle.TabIndex = 176;
            // 
            // BajaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 531);
            this.Controls.Add(this.CuadroDetalle);
            this.Controls.Add(this.ListBoxPagos);
            this.Controls.Add(this.LabelHora2);
            this.Controls.Add(this.LabelImporte2);
            this.Controls.Add(this.LabelDetalle);
            this.Controls.Add(this.LabelImporte);
            this.Controls.Add(this.LabelHora);
            this.Controls.Add(this.BotonJuiciosAsignados);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.LabelFecha);
            this.Name = "BajaPago";
            this.Text = "BajaPagos";
            this.Load += new System.EventHandler(this.BajaPagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelFecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Button BotonJuiciosAsignados;
        private System.Windows.Forms.Label LabelHora;
        private System.Windows.Forms.Label LabelImporte;
        private System.Windows.Forms.Label LabelDetalle;
        private System.Windows.Forms.Label LabelImporte2;
        private System.Windows.Forms.Label LabelHora2;
        private System.Windows.Forms.ListBox ListBoxPagos;
        private System.Windows.Forms.TextBox CuadroDetalle;
    }
}