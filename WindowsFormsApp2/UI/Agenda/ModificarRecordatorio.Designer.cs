namespace LawyerHelper.UI.Agenda
{
    partial class ModificarRecordatorio
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
            this.LabelListaRecordatorios = new System.Windows.Forms.Label();
            this.CuadroTipo = new System.Windows.Forms.TextBox();
            this.LabelTipo = new System.Windows.Forms.Label();
            this.CuadroAM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CuadroMinutos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CuadroHora = new System.Windows.Forms.TextBox();
            this.CuadroFecha = new System.Windows.Forms.DateTimePicker();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.CuadroDescripcion = new System.Windows.Forms.TextBox();
            this.CuadroLugar = new System.Windows.Forms.TextBox();
            this.LabelDescripcion = new System.Windows.Forms.Label();
            this.LabelLugar = new System.Windows.Forms.Label();
            this.ListBoxRecordatorios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LabelListaRecordatorios
            // 
            this.LabelListaRecordatorios.AutoSize = true;
            this.LabelListaRecordatorios.Location = new System.Drawing.Point(11, 7);
            this.LabelListaRecordatorios.Name = "LabelListaRecordatorios";
            this.LabelListaRecordatorios.Size = new System.Drawing.Size(111, 13);
            this.LabelListaRecordatorios.TabIndex = 176;
            this.LabelListaRecordatorios.Text = "Lista de recordatorios:";
            // 
            // CuadroTipo
            // 
            this.CuadroTipo.Location = new System.Drawing.Point(135, 296);
            this.CuadroTipo.Name = "CuadroTipo";
            this.CuadroTipo.Size = new System.Drawing.Size(222, 20);
            this.CuadroTipo.TabIndex = 174;
            // 
            // LabelTipo
            // 
            this.LabelTipo.AutoSize = true;
            this.LabelTipo.Location = new System.Drawing.Point(22, 299);
            this.LabelTipo.Name = "LabelTipo";
            this.LabelTipo.Size = new System.Drawing.Size(31, 13);
            this.LabelTipo.TabIndex = 173;
            this.LabelTipo.Text = "Tipo:";
            // 
            // CuadroAM
            // 
            this.CuadroAM.FormattingEnabled = true;
            this.CuadroAM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.CuadroAM.Location = new System.Drawing.Point(203, 222);
            this.CuadroAM.Name = "CuadroAM";
            this.CuadroAM.Size = new System.Drawing.Size(46, 21);
            this.CuadroAM.TabIndex = 172;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 171;
            this.label3.Text = ":";
            // 
            // CuadroMinutos
            // 
            this.CuadroMinutos.Location = new System.Drawing.Point(173, 223);
            this.CuadroMinutos.Name = "CuadroMinutos";
            this.CuadroMinutos.Size = new System.Drawing.Size(24, 20);
            this.CuadroMinutos.TabIndex = 170;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 169;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 168;
            this.label1.Text = "Hora:";
            // 
            // CuadroHora
            // 
            this.CuadroHora.Location = new System.Drawing.Point(135, 223);
            this.CuadroHora.Name = "CuadroHora";
            this.CuadroHora.Size = new System.Drawing.Size(24, 20);
            this.CuadroHora.TabIndex = 167;
            // 
            // CuadroFecha
            // 
            this.CuadroFecha.Location = new System.Drawing.Point(135, 188);
            this.CuadroFecha.Name = "CuadroFecha";
            this.CuadroFecha.Size = new System.Drawing.Size(222, 20);
            this.CuadroFecha.TabIndex = 166;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(262, 491);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(95, 24);
            this.BotonCancelar.TabIndex = 165;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Location = new System.Drawing.Point(38, 491);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(95, 24);
            this.BotonAceptar.TabIndex = 164;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // CuadroDescripcion
            // 
            this.CuadroDescripcion.Location = new System.Drawing.Point(135, 335);
            this.CuadroDescripcion.Multiline = true;
            this.CuadroDescripcion.Name = "CuadroDescripcion";
            this.CuadroDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CuadroDescripcion.Size = new System.Drawing.Size(222, 136);
            this.CuadroDescripcion.TabIndex = 163;
            // 
            // CuadroLugar
            // 
            this.CuadroLugar.Location = new System.Drawing.Point(135, 260);
            this.CuadroLugar.Name = "CuadroLugar";
            this.CuadroLugar.Size = new System.Drawing.Size(222, 20);
            this.CuadroLugar.TabIndex = 162;
            // 
            // LabelDescripcion
            // 
            this.LabelDescripcion.AutoSize = true;
            this.LabelDescripcion.Location = new System.Drawing.Point(22, 335);
            this.LabelDescripcion.Name = "LabelDescripcion";
            this.LabelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.LabelDescripcion.TabIndex = 161;
            this.LabelDescripcion.Text = "Descripcion:";
            // 
            // LabelLugar
            // 
            this.LabelLugar.AutoSize = true;
            this.LabelLugar.Location = new System.Drawing.Point(22, 263);
            this.LabelLugar.Name = "LabelLugar";
            this.LabelLugar.Size = new System.Drawing.Size(37, 13);
            this.LabelLugar.TabIndex = 160;
            this.LabelLugar.Text = "Lugar:";
            // 
            // ListBoxRecordatorios
            // 
            this.ListBoxRecordatorios.FormattingEnabled = true;
            this.ListBoxRecordatorios.Location = new System.Drawing.Point(25, 34);
            this.ListBoxRecordatorios.Name = "ListBoxRecordatorios";
            this.ListBoxRecordatorios.Size = new System.Drawing.Size(331, 134);
            this.ListBoxRecordatorios.TabIndex = 177;
            this.ListBoxRecordatorios.SelectedIndexChanged += new System.EventHandler(this.ListBoxRecordatorios_SelectedIndexChanged);
            // 
            // ModificarRecordatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 524);
            this.Controls.Add(this.ListBoxRecordatorios);
            this.Controls.Add(this.LabelListaRecordatorios);
            this.Controls.Add(this.CuadroTipo);
            this.Controls.Add(this.LabelTipo);
            this.Controls.Add(this.CuadroAM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CuadroMinutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CuadroHora);
            this.Controls.Add(this.CuadroFecha);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.CuadroDescripcion);
            this.Controls.Add(this.CuadroLugar);
            this.Controls.Add(this.LabelDescripcion);
            this.Controls.Add(this.LabelLugar);
            this.Name = "ModificarRecordatorio";
            this.Text = "BajaRecordatorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelListaRecordatorios;
        private System.Windows.Forms.TextBox CuadroTipo;
        private System.Windows.Forms.Label LabelTipo;
        private System.Windows.Forms.ComboBox CuadroAM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CuadroMinutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CuadroHora;
        private System.Windows.Forms.DateTimePicker CuadroFecha;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.TextBox CuadroDescripcion;
        private System.Windows.Forms.TextBox CuadroLugar;
        private System.Windows.Forms.Label LabelDescripcion;
        private System.Windows.Forms.Label LabelLugar;
        private System.Windows.Forms.ListBox ListBoxRecordatorios;
    }
}