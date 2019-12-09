namespace WindowsFormsApp2.Personas
{
    partial class AltaPersona
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
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.CuadroTelefono = new System.Windows.Forms.TextBox();
            this.CuadroDNI = new System.Windows.Forms.TextBox();
            this.CuadroNombre = new System.Windows.Forms.TextBox();
            this.CuadroApellido = new System.Windows.Forms.TextBox();
            this.LabelTelefono = new System.Windows.Forms.Label();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.LabelDNI = new System.Windows.Forms.Label();
            this.LabelApellido = new System.Windows.Forms.Label();
            this.LabelFecha = new System.Windows.Forms.Label();
            this.CuadroFecha = new System.Windows.Forms.DateTimePicker();
            this.CuadroCUIL = new System.Windows.Forms.TextBox();
            this.CuadroDomLegal = new System.Windows.Forms.TextBox();
            this.CuadroProfesion = new System.Windows.Forms.TextBox();
            this.LabelCUIL = new System.Windows.Forms.Label();
            this.LabelDomLegal = new System.Windows.Forms.Label();
            this.LabelProfesion = new System.Windows.Forms.Label();
            this.CuadroDomReal = new System.Windows.Forms.TextBox();
            this.LabelDomReal = new System.Windows.Forms.Label();
            this.CuadroEstadoCivil = new System.Windows.Forms.TextBox();
            this.CuadroLugarTrabajo = new System.Windows.Forms.TextBox();
            this.LabelEstadoCivil = new System.Windows.Forms.Label();
            this.LabelLugarTrabajo = new System.Windows.Forms.Label();
            this.CuadroRepresentante = new System.Windows.Forms.TextBox();
            this.LabelRepresentante = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCancelar.Location = new System.Drawing.Point(277, 450);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(95, 24);
            this.BotonCancelar.TabIndex = 68;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAceptar.Location = new System.Drawing.Point(14, 450);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(95, 24);
            this.BotonAceptar.TabIndex = 67;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // CuadroTelefono
            // 
            this.CuadroTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroTelefono.Location = new System.Drawing.Point(104, 129);
            this.CuadroTelefono.Name = "CuadroTelefono";
            this.CuadroTelefono.Size = new System.Drawing.Size(262, 20);
            this.CuadroTelefono.TabIndex = 63;
            // 
            // CuadroDNI
            // 
            this.CuadroDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroDNI.Location = new System.Drawing.Point(104, 94);
            this.CuadroDNI.Name = "CuadroDNI";
            this.CuadroDNI.Size = new System.Drawing.Size(262, 20);
            this.CuadroDNI.TabIndex = 62;
            this.CuadroDNI.TextChanged += new System.EventHandler(this.CuadroNombre_TextChanged);
            this.CuadroDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CuadroDNI_KeyPress);
            // 
            // CuadroNombre
            // 
            this.CuadroNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroNombre.Location = new System.Drawing.Point(104, 59);
            this.CuadroNombre.Name = "CuadroNombre";
            this.CuadroNombre.Size = new System.Drawing.Size(262, 20);
            this.CuadroNombre.TabIndex = 59;
            // 
            // CuadroApellido
            // 
            this.CuadroApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroApellido.Location = new System.Drawing.Point(104, 24);
            this.CuadroApellido.Name = "CuadroApellido";
            this.CuadroApellido.Size = new System.Drawing.Size(262, 20);
            this.CuadroApellido.TabIndex = 58;
            // 
            // LabelTelefono
            // 
            this.LabelTelefono.AutoSize = true;
            this.LabelTelefono.Location = new System.Drawing.Point(46, 131);
            this.LabelTelefono.Name = "LabelTelefono";
            this.LabelTelefono.Size = new System.Drawing.Size(52, 13);
            this.LabelTelefono.TabIndex = 55;
            this.LabelTelefono.Text = "Telefono:";
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(51, 61);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(47, 13);
            this.LabelNombre.TabIndex = 54;
            this.LabelNombre.Text = "Nombre:";
            // 
            // LabelDNI
            // 
            this.LabelDNI.AutoSize = true;
            this.LabelDNI.Location = new System.Drawing.Point(69, 96);
            this.LabelDNI.Name = "LabelDNI";
            this.LabelDNI.Size = new System.Drawing.Size(29, 13);
            this.LabelDNI.TabIndex = 51;
            this.LabelDNI.Text = "DNI:";
            // 
            // LabelApellido
            // 
            this.LabelApellido.AutoSize = true;
            this.LabelApellido.Location = new System.Drawing.Point(51, 26);
            this.LabelApellido.Name = "LabelApellido";
            this.LabelApellido.Size = new System.Drawing.Size(47, 13);
            this.LabelApellido.TabIndex = 50;
            this.LabelApellido.Text = "Apellido:";
            // 
            // LabelFecha
            // 
            this.LabelFecha.AutoSize = true;
            this.LabelFecha.Location = new System.Drawing.Point(2, 166);
            this.LabelFecha.Name = "LabelFecha";
            this.LabelFecha.Size = new System.Drawing.Size(96, 13);
            this.LabelFecha.TabIndex = 73;
            this.LabelFecha.Text = "Fecha Nacimiento:";
            this.LabelFecha.UseMnemonic = false;
            // 
            // CuadroFecha
            // 
            this.CuadroFecha.Location = new System.Drawing.Point(104, 160);
            this.CuadroFecha.Name = "CuadroFecha";
            this.CuadroFecha.Size = new System.Drawing.Size(262, 20);
            this.CuadroFecha.TabIndex = 72;
            this.CuadroFecha.ValueChanged += new System.EventHandler(this.CuadroFecha_ValueChanged);
            // 
            // CuadroCUIL
            // 
            this.CuadroCUIL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroCUIL.Location = new System.Drawing.Point(104, 269);
            this.CuadroCUIL.Name = "CuadroCUIL";
            this.CuadroCUIL.Size = new System.Drawing.Size(262, 20);
            this.CuadroCUIL.TabIndex = 80;
            // 
            // CuadroDomLegal
            // 
            this.CuadroDomLegal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroDomLegal.Location = new System.Drawing.Point(104, 304);
            this.CuadroDomLegal.Name = "CuadroDomLegal";
            this.CuadroDomLegal.Size = new System.Drawing.Size(262, 20);
            this.CuadroDomLegal.TabIndex = 79;
            // 
            // CuadroProfesion
            // 
            this.CuadroProfesion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroProfesion.Location = new System.Drawing.Point(104, 230);
            this.CuadroProfesion.Name = "CuadroProfesion";
            this.CuadroProfesion.Size = new System.Drawing.Size(262, 20);
            this.CuadroProfesion.TabIndex = 78;
            // 
            // LabelCUIL
            // 
            this.LabelCUIL.AutoSize = true;
            this.LabelCUIL.Location = new System.Drawing.Point(64, 271);
            this.LabelCUIL.Name = "LabelCUIL";
            this.LabelCUIL.Size = new System.Drawing.Size(34, 13);
            this.LabelCUIL.TabIndex = 76;
            this.LabelCUIL.Text = "CUIL:";
            // 
            // LabelDomLegal
            // 
            this.LabelDomLegal.AutoSize = true;
            this.LabelDomLegal.Location = new System.Drawing.Point(21, 306);
            this.LabelDomLegal.Name = "LabelDomLegal";
            this.LabelDomLegal.Size = new System.Drawing.Size(77, 13);
            this.LabelDomLegal.TabIndex = 75;
            this.LabelDomLegal.Text = "Domicilio legal:";
            // 
            // LabelProfesion
            // 
            this.LabelProfesion.AutoSize = true;
            this.LabelProfesion.Location = new System.Drawing.Point(44, 232);
            this.LabelProfesion.Name = "LabelProfesion";
            this.LabelProfesion.Size = new System.Drawing.Size(54, 13);
            this.LabelProfesion.TabIndex = 74;
            this.LabelProfesion.Text = "Profesion:";
            // 
            // CuadroDomReal
            // 
            this.CuadroDomReal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroDomReal.Location = new System.Drawing.Point(104, 195);
            this.CuadroDomReal.Name = "CuadroDomReal";
            this.CuadroDomReal.Size = new System.Drawing.Size(262, 20);
            this.CuadroDomReal.TabIndex = 82;
            // 
            // LabelDomReal
            // 
            this.LabelDomReal.AutoSize = true;
            this.LabelDomReal.Location = new System.Drawing.Point(26, 197);
            this.LabelDomReal.Name = "LabelDomReal";
            this.LabelDomReal.Size = new System.Drawing.Size(72, 13);
            this.LabelDomReal.TabIndex = 81;
            this.LabelDomReal.Text = "Domicilio real:";
            // 
            // CuadroEstadoCivil
            // 
            this.CuadroEstadoCivil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroEstadoCivil.Location = new System.Drawing.Point(104, 374);
            this.CuadroEstadoCivil.Name = "CuadroEstadoCivil";
            this.CuadroEstadoCivil.Size = new System.Drawing.Size(262, 20);
            this.CuadroEstadoCivil.TabIndex = 86;
            // 
            // CuadroLugarTrabajo
            // 
            this.CuadroLugarTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroLugarTrabajo.Location = new System.Drawing.Point(104, 339);
            this.CuadroLugarTrabajo.Name = "CuadroLugarTrabajo";
            this.CuadroLugarTrabajo.Size = new System.Drawing.Size(262, 20);
            this.CuadroLugarTrabajo.TabIndex = 85;
            // 
            // LabelEstadoCivil
            // 
            this.LabelEstadoCivil.AutoSize = true;
            this.LabelEstadoCivil.Location = new System.Drawing.Point(33, 376);
            this.LabelEstadoCivil.Name = "LabelEstadoCivil";
            this.LabelEstadoCivil.Size = new System.Drawing.Size(65, 13);
            this.LabelEstadoCivil.TabIndex = 84;
            this.LabelEstadoCivil.Text = "Estado Civil:";
            // 
            // LabelLugarTrabajo
            // 
            this.LabelLugarTrabajo.AutoSize = true;
            this.LabelLugarTrabajo.Location = new System.Drawing.Point(11, 341);
            this.LabelLugarTrabajo.Name = "LabelLugarTrabajo";
            this.LabelLugarTrabajo.Size = new System.Drawing.Size(87, 13);
            this.LabelLugarTrabajo.TabIndex = 83;
            this.LabelLugarTrabajo.Text = "Lugar de trabajo:";
            // 
            // CuadroRepresentante
            // 
            this.CuadroRepresentante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroRepresentante.Location = new System.Drawing.Point(104, 409);
            this.CuadroRepresentante.Name = "CuadroRepresentante";
            this.CuadroRepresentante.Size = new System.Drawing.Size(262, 20);
            this.CuadroRepresentante.TabIndex = 90;
            // 
            // LabelRepresentante
            // 
            this.LabelRepresentante.AutoSize = true;
            this.LabelRepresentante.Location = new System.Drawing.Point(18, 411);
            this.LabelRepresentante.Name = "LabelRepresentante";
            this.LabelRepresentante.Size = new System.Drawing.Size(80, 13);
            this.LabelRepresentante.TabIndex = 89;
            this.LabelRepresentante.Text = "Representante:";
            // 
            // AltaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 483);
            this.Controls.Add(this.CuadroRepresentante);
            this.Controls.Add(this.LabelRepresentante);
            this.Controls.Add(this.CuadroEstadoCivil);
            this.Controls.Add(this.CuadroLugarTrabajo);
            this.Controls.Add(this.LabelEstadoCivil);
            this.Controls.Add(this.LabelLugarTrabajo);
            this.Controls.Add(this.CuadroDomReal);
            this.Controls.Add(this.LabelDomReal);
            this.Controls.Add(this.CuadroCUIL);
            this.Controls.Add(this.CuadroDomLegal);
            this.Controls.Add(this.CuadroProfesion);
            this.Controls.Add(this.LabelCUIL);
            this.Controls.Add(this.LabelDomLegal);
            this.Controls.Add(this.LabelProfesion);
            this.Controls.Add(this.LabelFecha);
            this.Controls.Add(this.CuadroFecha);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.CuadroTelefono);
            this.Controls.Add(this.CuadroDNI);
            this.Controls.Add(this.CuadroNombre);
            this.Controls.Add(this.CuadroApellido);
            this.Controls.Add(this.LabelTelefono);
            this.Controls.Add(this.LabelNombre);
            this.Controls.Add(this.LabelDNI);
            this.Controls.Add(this.LabelApellido);
            this.Name = "AltaPersona";
            this.Text = "AltaPersona";
            this.Load += new System.EventHandler(this.AltaPersona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.TextBox CuadroTelefono;
        private System.Windows.Forms.TextBox CuadroDNI;
        private System.Windows.Forms.TextBox CuadroNombre;
        private System.Windows.Forms.TextBox CuadroApellido;
        private System.Windows.Forms.Label LabelTelefono;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.Label LabelDNI;
        private System.Windows.Forms.Label LabelApellido;
        private System.Windows.Forms.Label LabelFecha;
        private System.Windows.Forms.DateTimePicker CuadroFecha;
        private System.Windows.Forms.TextBox CuadroCUIL;
        private System.Windows.Forms.TextBox CuadroDomLegal;
        private System.Windows.Forms.TextBox CuadroProfesion;
        private System.Windows.Forms.Label LabelCUIL;
        private System.Windows.Forms.Label LabelDomLegal;
        private System.Windows.Forms.Label LabelProfesion;
        private System.Windows.Forms.TextBox CuadroDomReal;
        private System.Windows.Forms.Label LabelDomReal;
        private System.Windows.Forms.TextBox CuadroEstadoCivil;
        private System.Windows.Forms.TextBox CuadroLugarTrabajo;
        private System.Windows.Forms.Label LabelEstadoCivil;
        private System.Windows.Forms.Label LabelLugarTrabajo;
        private System.Windows.Forms.TextBox CuadroRepresentante;
        private System.Windows.Forms.Label LabelRepresentante;
    }
}