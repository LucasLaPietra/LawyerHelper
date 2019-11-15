namespace LawyerHelper.UI.Cobros
{
    partial class ConsultaCobro
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
            this.LabelImporte2 = new System.Windows.Forms.Label();
            this.LabelDetalle = new System.Windows.Forms.Label();
            this.LabelImporte = new System.Windows.Forms.Label();
            this.LabelHora = new System.Windows.Forms.Label();
            this.LabelFecha = new System.Windows.Forms.Label();
            this.DateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.BotonPersonasAsociadas = new System.Windows.Forms.Button();
            this.BotonJuiciosAsignados = new System.Windows.Forms.Button();
            this.ListBoxCobros = new System.Windows.Forms.ListBox();
            this.CuadroDetalle = new System.Windows.Forms.TextBox();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.LabelHora2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelImporte2
            // 
            this.LabelImporte2.AutoSize = true;
            this.LabelImporte2.Location = new System.Drawing.Point(67, 282);
            this.LabelImporte2.Name = "LabelImporte2";
            this.LabelImporte2.Size = new System.Drawing.Size(10, 13);
            this.LabelImporte2.TabIndex = 146;
            this.LabelImporte2.Text = "-";
            // 
            // LabelDetalle
            // 
            this.LabelDetalle.AutoSize = true;
            this.LabelDetalle.Location = new System.Drawing.Point(9, 316);
            this.LabelDetalle.Name = "LabelDetalle";
            this.LabelDetalle.Size = new System.Drawing.Size(40, 13);
            this.LabelDetalle.TabIndex = 144;
            this.LabelDetalle.Text = "Detalle";
            // 
            // LabelImporte
            // 
            this.LabelImporte.AutoSize = true;
            this.LabelImporte.Location = new System.Drawing.Point(10, 282);
            this.LabelImporte.Name = "LabelImporte";
            this.LabelImporte.Size = new System.Drawing.Size(42, 13);
            this.LabelImporte.TabIndex = 143;
            this.LabelImporte.Text = "Importe";
            // 
            // LabelHora
            // 
            this.LabelHora.AutoSize = true;
            this.LabelHora.Location = new System.Drawing.Point(10, 247);
            this.LabelHora.Name = "LabelHora";
            this.LabelHora.Size = new System.Drawing.Size(30, 13);
            this.LabelHora.TabIndex = 142;
            this.LabelHora.Text = "Hora";
            // 
            // LabelFecha
            // 
            this.LabelFecha.AutoSize = true;
            this.LabelFecha.Location = new System.Drawing.Point(9, 19);
            this.LabelFecha.Name = "LabelFecha";
            this.LabelFecha.Size = new System.Drawing.Size(40, 13);
            this.LabelFecha.TabIndex = 140;
            this.LabelFecha.Text = "Fecha:";
            // 
            // DateTimePickerFecha
            // 
            this.DateTimePickerFecha.Location = new System.Drawing.Point(55, 13);
            this.DateTimePickerFecha.Name = "DateTimePickerFecha";
            this.DateTimePickerFecha.Size = new System.Drawing.Size(193, 20);
            this.DateTimePickerFecha.TabIndex = 139;
            this.DateTimePickerFecha.ValueChanged += new System.EventHandler(this.DateTimePickerFecha_ValueChanged);
            // 
            // BotonPersonasAsociadas
            // 
            this.BotonPersonasAsociadas.Location = new System.Drawing.Point(104, 422);
            this.BotonPersonasAsociadas.Name = "BotonPersonasAsociadas";
            this.BotonPersonasAsociadas.Size = new System.Drawing.Size(177, 23);
            this.BotonPersonasAsociadas.TabIndex = 169;
            this.BotonPersonasAsociadas.Text = "Ver Persona asociada";
            this.BotonPersonasAsociadas.UseVisualStyleBackColor = true;
            this.BotonPersonasAsociadas.Click += new System.EventHandler(this.BotonPersonasAsociadas_Click);
            // 
            // BotonJuiciosAsignados
            // 
            this.BotonJuiciosAsignados.Location = new System.Drawing.Point(104, 393);
            this.BotonJuiciosAsignados.Name = "BotonJuiciosAsignados";
            this.BotonJuiciosAsignados.Size = new System.Drawing.Size(177, 23);
            this.BotonJuiciosAsignados.TabIndex = 168;
            this.BotonJuiciosAsignados.Text = "Ver Juicio asociado";
            this.BotonJuiciosAsignados.UseVisualStyleBackColor = true;
            this.BotonJuiciosAsignados.Click += new System.EventHandler(this.BotonJuiciosAsignados_Click);
            // 
            // ListBoxCobros
            // 
            this.ListBoxCobros.FormattingEnabled = true;
            this.ListBoxCobros.Location = new System.Drawing.Point(12, 46);
            this.ListBoxCobros.Name = "ListBoxCobros";
            this.ListBoxCobros.Size = new System.Drawing.Size(360, 186);
            this.ListBoxCobros.TabIndex = 170;
            this.ListBoxCobros.SelectedIndexChanged += new System.EventHandler(this.ListBoxCobros_SelectedIndexChanged);
            // 
            // CuadroDetalle
            // 
            this.CuadroDetalle.Location = new System.Drawing.Point(59, 316);
            this.CuadroDetalle.Multiline = true;
            this.CuadroDetalle.Name = "CuadroDetalle";
            this.CuadroDetalle.ReadOnly = true;
            this.CuadroDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CuadroDetalle.Size = new System.Drawing.Size(313, 71);
            this.CuadroDetalle.TabIndex = 171;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCancelar.Location = new System.Drawing.Point(153, 460);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(95, 24);
            this.BotonCancelar.TabIndex = 172;
            this.BotonCancelar.Text = "Aceptar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            // 
            // LabelHora2
            // 
            this.LabelHora2.AutoSize = true;
            this.LabelHora2.Location = new System.Drawing.Point(67, 247);
            this.LabelHora2.Name = "LabelHora2";
            this.LabelHora2.Size = new System.Drawing.Size(10, 13);
            this.LabelHora2.TabIndex = 148;
            this.LabelHora2.Text = "-";
            // 
            // ConsultaCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 496);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.CuadroDetalle);
            this.Controls.Add(this.ListBoxCobros);
            this.Controls.Add(this.BotonPersonasAsociadas);
            this.Controls.Add(this.BotonJuiciosAsignados);
            this.Controls.Add(this.LabelHora2);
            this.Controls.Add(this.LabelImporte2);
            this.Controls.Add(this.LabelDetalle);
            this.Controls.Add(this.LabelImporte);
            this.Controls.Add(this.LabelHora);
            this.Controls.Add(this.LabelFecha);
            this.Controls.Add(this.DateTimePickerFecha);
            this.Name = "ConsultaCobro";
            this.Text = "ConsultaCobro";
            this.Load += new System.EventHandler(this.ConsultaCobro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelImporte2;
        private System.Windows.Forms.Label LabelDetalle;
        private System.Windows.Forms.Label LabelImporte;
        private System.Windows.Forms.Label LabelHora;
        private System.Windows.Forms.Label LabelFecha;
        private System.Windows.Forms.DateTimePicker DateTimePickerFecha;
        private System.Windows.Forms.Button BotonPersonasAsociadas;
        private System.Windows.Forms.Button BotonJuiciosAsignados;
        private System.Windows.Forms.ListBox ListBoxCobros;
        private System.Windows.Forms.TextBox CuadroDetalle;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Label LabelHora2;
    }
}