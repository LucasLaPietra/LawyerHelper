namespace LawyerHelper.UI.Documentos
{
    partial class AltaDocumento
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.CheckEnExpediente = new System.Windows.Forms.CheckBox();
            this.CuadroNombreDocumento = new System.Windows.Forms.TextBox();
            this.CuadroFoja = new System.Windows.Forms.TextBox();
            this.TimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.CuadroDetalle = new System.Windows.Forms.TextBox();
            this.CuadroTipoDocumento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de foja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "En expediente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Detalle";
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(249, 431);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(95, 24);
            this.BotonCancelar.TabIndex = 12;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Location = new System.Drawing.Point(37, 431);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(95, 24);
            this.BotonAceptar.TabIndex = 11;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // CheckEnExpediente
            // 
            this.CheckEnExpediente.AutoSize = true;
            this.CheckEnExpediente.Location = new System.Drawing.Point(122, 167);
            this.CheckEnExpediente.Name = "CheckEnExpediente";
            this.CheckEnExpediente.Size = new System.Drawing.Size(35, 17);
            this.CheckEnExpediente.TabIndex = 14;
            this.CheckEnExpediente.Text = "Si";
            this.CheckEnExpediente.UseVisualStyleBackColor = true;
            this.CheckEnExpediente.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CuadroNombreDocumento
            // 
            this.CuadroNombreDocumento.Location = new System.Drawing.Point(122, 38);
            this.CuadroNombreDocumento.Name = "CuadroNombreDocumento";
            this.CuadroNombreDocumento.Size = new System.Drawing.Size(250, 20);
            this.CuadroNombreDocumento.TabIndex = 16;
            // 
            // CuadroFoja
            // 
            this.CuadroFoja.Location = new System.Drawing.Point(122, 125);
            this.CuadroFoja.Name = "CuadroFoja";
            this.CuadroFoja.Size = new System.Drawing.Size(250, 20);
            this.CuadroFoja.TabIndex = 18;
            // 
            // TimePickerFecha
            // 
            this.TimePickerFecha.Location = new System.Drawing.Point(122, 211);
            this.TimePickerFecha.Name = "TimePickerFecha";
            this.TimePickerFecha.Size = new System.Drawing.Size(250, 20);
            this.TimePickerFecha.TabIndex = 22;
            // 
            // CuadroDetalle
            // 
            this.CuadroDetalle.Location = new System.Drawing.Point(122, 256);
            this.CuadroDetalle.Multiline = true;
            this.CuadroDetalle.Name = "CuadroDetalle";
            this.CuadroDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CuadroDetalle.Size = new System.Drawing.Size(250, 151);
            this.CuadroDetalle.TabIndex = 171;
            // 
            // CuadroTipoDocumento
            // 
            this.CuadroTipoDocumento.Location = new System.Drawing.Point(122, 78);
            this.CuadroTipoDocumento.Name = "CuadroTipoDocumento";
            this.CuadroTipoDocumento.Size = new System.Drawing.Size(250, 20);
            this.CuadroTipoDocumento.TabIndex = 172;
            // 
            // AltaDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 467);
            this.Controls.Add(this.CuadroTipoDocumento);
            this.Controls.Add(this.CuadroDetalle);
            this.Controls.Add(this.TimePickerFecha);
            this.Controls.Add(this.CuadroFoja);
            this.Controls.Add(this.CuadroNombreDocumento);
            this.Controls.Add(this.CheckEnExpediente);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaDocumento";
            this.Text = "AltaDocumento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.CheckBox CheckEnExpediente;
        private System.Windows.Forms.TextBox CuadroNombreDocumento;
        private System.Windows.Forms.TextBox CuadroFoja;
        private System.Windows.Forms.DateTimePicker TimePickerFecha;
        private System.Windows.Forms.TextBox CuadroDetalle;
        private System.Windows.Forms.TextBox CuadroTipoDocumento;
    }
}