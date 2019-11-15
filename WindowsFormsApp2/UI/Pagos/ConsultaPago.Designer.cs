namespace LawyerHelper.UI.Pagos
{
    partial class ConsultaPago
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
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.LabelFecha = new System.Windows.Forms.Label();
            this.LabelHora2 = new System.Windows.Forms.Label();
            this.LabelImporte2 = new System.Windows.Forms.Label();
            this.LabelDetalle = new System.Windows.Forms.Label();
            this.LabelImporte = new System.Windows.Forms.Label();
            this.LabelHora = new System.Windows.Forms.Label();
            this.BotonJuiciosAsignados = new System.Windows.Forms.Button();
            this.ListBoxPagos = new System.Windows.Forms.ListBox();
            this.CuadroDetalle = new System.Windows.Forms.TextBox();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(57, 35);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(314, 20);
            this.dateTimePickerFecha.TabIndex = 9;
            this.dateTimePickerFecha.ValueChanged += new System.EventHandler(this.dateTimePickerFecha_ValueChanged);
            // 
            // LabelFecha
            // 
            this.LabelFecha.AutoSize = true;
            this.LabelFecha.Location = new System.Drawing.Point(14, 39);
            this.LabelFecha.Name = "LabelFecha";
            this.LabelFecha.Size = new System.Drawing.Size(37, 13);
            this.LabelFecha.TabIndex = 7;
            this.LabelFecha.Text = "Fecha";
            // 
            // LabelHora2
            // 
            this.LabelHora2.AutoSize = true;
            this.LabelHora2.Location = new System.Drawing.Point(67, 272);
            this.LabelHora2.Name = "LabelHora2";
            this.LabelHora2.Size = new System.Drawing.Size(10, 13);
            this.LabelHora2.TabIndex = 123;
            this.LabelHora2.Text = "-";
            // 
            // LabelImporte2
            // 
            this.LabelImporte2.AutoSize = true;
            this.LabelImporte2.Location = new System.Drawing.Point(67, 307);
            this.LabelImporte2.Name = "LabelImporte2";
            this.LabelImporte2.Size = new System.Drawing.Size(10, 13);
            this.LabelImporte2.TabIndex = 121;
            this.LabelImporte2.Text = "-";
            // 
            // LabelDetalle
            // 
            this.LabelDetalle.AutoSize = true;
            this.LabelDetalle.Location = new System.Drawing.Point(10, 341);
            this.LabelDetalle.Name = "LabelDetalle";
            this.LabelDetalle.Size = new System.Drawing.Size(40, 13);
            this.LabelDetalle.TabIndex = 119;
            this.LabelDetalle.Text = "Detalle";
            // 
            // LabelImporte
            // 
            this.LabelImporte.AutoSize = true;
            this.LabelImporte.Location = new System.Drawing.Point(10, 307);
            this.LabelImporte.Name = "LabelImporte";
            this.LabelImporte.Size = new System.Drawing.Size(42, 13);
            this.LabelImporte.TabIndex = 118;
            this.LabelImporte.Text = "Importe";
            // 
            // LabelHora
            // 
            this.LabelHora.AutoSize = true;
            this.LabelHora.Location = new System.Drawing.Point(10, 272);
            this.LabelHora.Name = "LabelHora";
            this.LabelHora.Size = new System.Drawing.Size(30, 13);
            this.LabelHora.TabIndex = 117;
            this.LabelHora.Text = "Hora";
            // 
            // BotonJuiciosAsignados
            // 
            this.BotonJuiciosAsignados.Location = new System.Drawing.Point(104, 442);
            this.BotonJuiciosAsignados.Name = "BotonJuiciosAsignados";
            this.BotonJuiciosAsignados.Size = new System.Drawing.Size(177, 23);
            this.BotonJuiciosAsignados.TabIndex = 127;
            this.BotonJuiciosAsignados.Text = "Ver Juicios asignados";
            this.BotonJuiciosAsignados.UseVisualStyleBackColor = true;
            this.BotonJuiciosAsignados.Click += new System.EventHandler(this.BotonJuiciosAsignados_Click);
            // 
            // ListBoxPagos
            // 
            this.ListBoxPagos.FormattingEnabled = true;
            this.ListBoxPagos.Location = new System.Drawing.Point(11, 72);
            this.ListBoxPagos.Name = "ListBoxPagos";
            this.ListBoxPagos.Size = new System.Drawing.Size(360, 186);
            this.ListBoxPagos.TabIndex = 129;
            this.ListBoxPagos.SelectedIndexChanged += new System.EventHandler(this.ListBoxPagos_SelectedIndexChanged);
            // 
            // CuadroDetalle
            // 
            this.CuadroDetalle.Location = new System.Drawing.Point(70, 341);
            this.CuadroDetalle.Multiline = true;
            this.CuadroDetalle.Name = "CuadroDetalle";
            this.CuadroDetalle.ReadOnly = true;
            this.CuadroDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CuadroDetalle.Size = new System.Drawing.Size(302, 62);
            this.CuadroDetalle.TabIndex = 175;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCancelar.Location = new System.Drawing.Point(150, 495);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(95, 24);
            this.BotonCancelar.TabIndex = 176;
            this.BotonCancelar.Text = "Aceptar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click_1);
            // 
            // ConsultaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 531);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.CuadroDetalle);
            this.Controls.Add(this.ListBoxPagos);
            this.Controls.Add(this.BotonJuiciosAsignados);
            this.Controls.Add(this.LabelHora2);
            this.Controls.Add(this.LabelImporte2);
            this.Controls.Add(this.LabelDetalle);
            this.Controls.Add(this.LabelImporte);
            this.Controls.Add(this.LabelHora);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.LabelFecha);
            this.Name = "ConsultaPago";
            this.Text = "ConsultaPago";
            this.Load += new System.EventHandler(this.ConsultaPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Label LabelFecha;
        private System.Windows.Forms.Label LabelHora2;
        private System.Windows.Forms.Label LabelImporte2;
        private System.Windows.Forms.Label LabelDetalle;
        private System.Windows.Forms.Label LabelImporte;
        private System.Windows.Forms.Label LabelHora;
        private System.Windows.Forms.Button BotonJuiciosAsignados;
        private System.Windows.Forms.ListBox ListBoxPagos;
        private System.Windows.Forms.TextBox CuadroDetalle;
        private System.Windows.Forms.Button BotonCancelar;
    }
}