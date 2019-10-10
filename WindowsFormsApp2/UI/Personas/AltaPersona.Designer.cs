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
            this.CuadroGrupoFamiliar = new System.Windows.Forms.TextBox();
            this.CuadroTelefono = new System.Windows.Forms.TextBox();
            this.CuadroNombre = new System.Windows.Forms.TextBox();
            this.CuadroDNI = new System.Windows.Forms.TextBox();
            this.CuadroApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.LabelDNI = new System.Windows.Forms.Label();
            this.LabelApellido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CuadroFecha = new System.Windows.Forms.DateTimePicker();
            this.CuadroCUIL = new System.Windows.Forms.TextBox();
            this.CuadroDomLegal = new System.Windows.Forms.TextBox();
            this.CuadroProfesion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CuadroDomReal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CuadroEstadoCivil = new System.Windows.Forms.TextBox();
            this.CuadroLugarTrabajo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CuadroBienes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CuadroAbogado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotonCancelar
            // 
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
            this.BotonAceptar.Location = new System.Drawing.Point(14, 450);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(95, 24);
            this.BotonAceptar.TabIndex = 67;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // CuadroGrupoFamiliar
            // 
            this.CuadroGrupoFamiliar.Location = new System.Drawing.Point(104, 208);
            this.CuadroGrupoFamiliar.Multiline = true;
            this.CuadroGrupoFamiliar.Name = "CuadroGrupoFamiliar";
            this.CuadroGrupoFamiliar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CuadroGrupoFamiliar.Size = new System.Drawing.Size(265, 70);
            this.CuadroGrupoFamiliar.TabIndex = 65;
            // 
            // CuadroTelefono
            // 
            this.CuadroTelefono.Location = new System.Drawing.Point(272, 51);
            this.CuadroTelefono.Name = "CuadroTelefono";
            this.CuadroTelefono.Size = new System.Drawing.Size(97, 20);
            this.CuadroTelefono.TabIndex = 63;
            // 
            // CuadroNombre
            // 
            this.CuadroNombre.Location = new System.Drawing.Point(272, 24);
            this.CuadroNombre.Name = "CuadroNombre";
            this.CuadroNombre.Size = new System.Drawing.Size(97, 20);
            this.CuadroNombre.TabIndex = 62;
            // 
            // CuadroDNI
            // 
            this.CuadroDNI.Location = new System.Drawing.Point(104, 51);
            this.CuadroDNI.Name = "CuadroDNI";
            this.CuadroDNI.Size = new System.Drawing.Size(97, 20);
            this.CuadroDNI.TabIndex = 59;
            // 
            // CuadroApellido
            // 
            this.CuadroApellido.Location = new System.Drawing.Point(104, 24);
            this.CuadroApellido.Name = "CuadroApellido";
            this.CuadroApellido.Size = new System.Drawing.Size(97, 20);
            this.CuadroApellido.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Grupo familiar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Telefono:";
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(225, 27);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(47, 13);
            this.LabelNombre.TabIndex = 54;
            this.LabelNombre.Text = "Nombre:";
            // 
            // LabelDNI
            // 
            this.LabelDNI.AutoSize = true;
            this.LabelDNI.Location = new System.Drawing.Point(69, 54);
            this.LabelDNI.Name = "LabelDNI";
            this.LabelDNI.Size = new System.Drawing.Size(29, 13);
            this.LabelDNI.TabIndex = 51;
            this.LabelDNI.Text = "DNI:";
            // 
            // LabelApellido
            // 
            this.LabelApellido.AutoSize = true;
            this.LabelApellido.Location = new System.Drawing.Point(51, 27);
            this.LabelApellido.Name = "LabelApellido";
            this.LabelApellido.Size = new System.Drawing.Size(47, 13);
            this.LabelApellido.TabIndex = 50;
            this.LabelApellido.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Fecha Nacimiento:";
            this.label2.UseMnemonic = false;
            // 
            // CuadroFecha
            // 
            this.CuadroFecha.Location = new System.Drawing.Point(104, 77);
            this.CuadroFecha.Name = "CuadroFecha";
            this.CuadroFecha.Size = new System.Drawing.Size(265, 20);
            this.CuadroFecha.TabIndex = 72;
            // 
            // CuadroCUIL
            // 
            this.CuadroCUIL.Location = new System.Drawing.Point(272, 103);
            this.CuadroCUIL.Name = "CuadroCUIL";
            this.CuadroCUIL.Size = new System.Drawing.Size(97, 20);
            this.CuadroCUIL.TabIndex = 80;
            // 
            // CuadroDomLegal
            // 
            this.CuadroDomLegal.Location = new System.Drawing.Point(104, 130);
            this.CuadroDomLegal.Name = "CuadroDomLegal";
            this.CuadroDomLegal.Size = new System.Drawing.Size(265, 20);
            this.CuadroDomLegal.TabIndex = 79;
            // 
            // CuadroProfesion
            // 
            this.CuadroProfesion.Location = new System.Drawing.Point(104, 103);
            this.CuadroProfesion.Name = "CuadroProfesion";
            this.CuadroProfesion.Size = new System.Drawing.Size(97, 20);
            this.CuadroProfesion.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "CUIL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "Domicilio legal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "Profesion:";
            // 
            // CuadroDomReal
            // 
            this.CuadroDomReal.Location = new System.Drawing.Point(104, 156);
            this.CuadroDomReal.Name = "CuadroDomReal";
            this.CuadroDomReal.Size = new System.Drawing.Size(265, 20);
            this.CuadroDomReal.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Domicilio real:";
            // 
            // CuadroEstadoCivil
            // 
            this.CuadroEstadoCivil.Location = new System.Drawing.Point(272, 182);
            this.CuadroEstadoCivil.Name = "CuadroEstadoCivil";
            this.CuadroEstadoCivil.Size = new System.Drawing.Size(97, 20);
            this.CuadroEstadoCivil.TabIndex = 86;
            // 
            // CuadroLugarTrabajo
            // 
            this.CuadroLugarTrabajo.Location = new System.Drawing.Point(104, 182);
            this.CuadroLugarTrabajo.Name = "CuadroLugarTrabajo";
            this.CuadroLugarTrabajo.Size = new System.Drawing.Size(97, 20);
            this.CuadroLugarTrabajo.TabIndex = 85;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 84;
            this.label9.Text = "Estado Civil:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 83;
            this.label10.Text = "Lugar de trabajo:";
            // 
            // CuadroBienes
            // 
            this.CuadroBienes.Location = new System.Drawing.Point(104, 284);
            this.CuadroBienes.Multiline = true;
            this.CuadroBienes.Name = "CuadroBienes";
            this.CuadroBienes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CuadroBienes.Size = new System.Drawing.Size(265, 70);
            this.CuadroBienes.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "Bienes:";
            // 
            // CuadroAbogado
            // 
            this.CuadroAbogado.Location = new System.Drawing.Point(104, 360);
            this.CuadroAbogado.Name = "CuadroAbogado";
            this.CuadroAbogado.Size = new System.Drawing.Size(265, 20);
            this.CuadroAbogado.TabIndex = 90;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 89;
            this.label11.Text = "Abogado:";
            // 
            // AltaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 496);
            this.Controls.Add(this.CuadroAbogado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CuadroBienes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CuadroEstadoCivil);
            this.Controls.Add(this.CuadroLugarTrabajo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CuadroDomReal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CuadroCUIL);
            this.Controls.Add(this.CuadroDomLegal);
            this.Controls.Add(this.CuadroProfesion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CuadroFecha);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.CuadroGrupoFamiliar);
            this.Controls.Add(this.CuadroTelefono);
            this.Controls.Add(this.CuadroNombre);
            this.Controls.Add(this.CuadroDNI);
            this.Controls.Add(this.CuadroApellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.TextBox CuadroGrupoFamiliar;
        private System.Windows.Forms.TextBox CuadroTelefono;
        private System.Windows.Forms.TextBox CuadroNombre;
        private System.Windows.Forms.TextBox CuadroDNI;
        private System.Windows.Forms.TextBox CuadroApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.Label LabelDNI;
        private System.Windows.Forms.Label LabelApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker CuadroFecha;
        private System.Windows.Forms.TextBox CuadroCUIL;
        private System.Windows.Forms.TextBox CuadroDomLegal;
        private System.Windows.Forms.TextBox CuadroProfesion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CuadroDomReal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CuadroEstadoCivil;
        private System.Windows.Forms.TextBox CuadroLugarTrabajo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CuadroBienes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CuadroAbogado;
        private System.Windows.Forms.Label label11;
    }
}