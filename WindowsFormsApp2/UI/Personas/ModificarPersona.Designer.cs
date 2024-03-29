﻿namespace LawyerHelper.UI.Personas
{
    partial class ModificarPersona
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
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.CuadroApellido = new System.Windows.Forms.TextBox();
            this.CuadroNombre = new System.Windows.Forms.TextBox();
            this.LabelApellido = new System.Windows.Forms.Label();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.BotonBusquedaAvanzada = new System.Windows.Forms.Button();
            this.Layout = new System.Windows.Forms.TableLayoutPanel();
            this.LabelDNI = new System.Windows.Forms.Label();
            this.LabelDomicilio = new System.Windows.Forms.Label();
            this.LabelTelefono = new System.Windows.Forms.Label();
            this.LabelFechaNacimiento = new System.Windows.Forms.Label();
            this.LabelProfesion = new System.Windows.Forms.Label();
            this.LabelLugarTrabajo = new System.Windows.Forms.Label();
            this.LabelCUIL = new System.Windows.Forms.Label();
            this.LabelEstadoCivil = new System.Windows.Forms.Label();
            this.LabelRepresentante = new System.Windows.Forms.Label();
            this.LabelDomicilioLegal = new System.Windows.Forms.Label();
            this.LabelJuiciosAsociados = new System.Windows.Forms.Label();
            this.LabelCobrosAsociados = new System.Windows.Forms.Label();
            this.CuadroDNI = new System.Windows.Forms.TextBox();
            this.CuadroDomicilio = new System.Windows.Forms.TextBox();
            this.CuadroTelefono = new System.Windows.Forms.TextBox();
            this.CuadroProfesion = new System.Windows.Forms.TextBox();
            this.CuadroLugarTrabajo = new System.Windows.Forms.TextBox();
            this.CuadroCUIL = new System.Windows.Forms.TextBox();
            this.CuadroEstadoCivil = new System.Windows.Forms.TextBox();
            this.CuadroRepresentante = new System.Windows.Forms.TextBox();
            this.CuadroDomicilioLegal = new System.Windows.Forms.TextBox();
            this.CuadroFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.ListBoxJuicios = new System.Windows.Forms.ListBox();
            this.ListBoxCobros = new System.Windows.Forms.ListBox();
            this.BotonConsultarCobro = new System.Windows.Forms.Button();
            this.BotonConsultarJuicio = new System.Windows.Forms.Button();
            this.Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonBuscar.Location = new System.Drawing.Point(295, 50);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(75, 23);
            this.BotonBuscar.TabIndex = 9;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // CuadroApellido
            // 
            this.CuadroApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroApellido.Location = new System.Drawing.Point(61, 50);
            this.CuadroApellido.Name = "CuadroApellido";
            this.CuadroApellido.Size = new System.Drawing.Size(218, 20);
            this.CuadroApellido.TabIndex = 8;
            // 
            // CuadroNombre
            // 
            this.CuadroNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroNombre.Location = new System.Drawing.Point(61, 21);
            this.CuadroNombre.Name = "CuadroNombre";
            this.CuadroNombre.Size = new System.Drawing.Size(218, 20);
            this.CuadroNombre.TabIndex = 7;
            // 
            // LabelApellido
            // 
            this.LabelApellido.AutoSize = true;
            this.LabelApellido.Location = new System.Drawing.Point(11, 57);
            this.LabelApellido.Name = "LabelApellido";
            this.LabelApellido.Size = new System.Drawing.Size(44, 13);
            this.LabelApellido.TabIndex = 6;
            this.LabelApellido.Text = "Apellido";
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(11, 28);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(44, 13);
            this.LabelNombre.TabIndex = 5;
            this.LabelNombre.Text = "Nombre";
            // 
            // BotonBusquedaAvanzada
            // 
            this.BotonBusquedaAvanzada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonBusquedaAvanzada.Location = new System.Drawing.Point(12, 88);
            this.BotonBusquedaAvanzada.Name = "BotonBusquedaAvanzada";
            this.BotonBusquedaAvanzada.Size = new System.Drawing.Size(172, 23);
            this.BotonBusquedaAvanzada.TabIndex = 43;
            this.BotonBusquedaAvanzada.Text = "Buscar por otro campo";
            this.BotonBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.BotonBusquedaAvanzada.Click += new System.EventHandler(this.BotonBusquedaAvanzada_Click);
            // 
            // Layout
            // 
            this.Layout.ColumnCount = 2;
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.03352F));
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.96648F));
            this.Layout.Controls.Add(this.ListBoxCobros, 1, 11);
            this.Layout.Controls.Add(this.LabelDNI, 0, 0);
            this.Layout.Controls.Add(this.LabelDomicilio, 0, 1);
            this.Layout.Controls.Add(this.LabelTelefono, 0, 2);
            this.Layout.Controls.Add(this.LabelFechaNacimiento, 0, 3);
            this.Layout.Controls.Add(this.LabelProfesion, 0, 4);
            this.Layout.Controls.Add(this.LabelLugarTrabajo, 0, 5);
            this.Layout.Controls.Add(this.LabelCUIL, 0, 6);
            this.Layout.Controls.Add(this.LabelEstadoCivil, 0, 7);
            this.Layout.Controls.Add(this.LabelRepresentante, 0, 8);
            this.Layout.Controls.Add(this.LabelDomicilioLegal, 0, 9);
            this.Layout.Controls.Add(this.LabelJuiciosAsociados, 0, 10);
            this.Layout.Controls.Add(this.LabelCobrosAsociados, 0, 11);
            this.Layout.Controls.Add(this.CuadroDNI, 1, 0);
            this.Layout.Controls.Add(this.CuadroDomicilio, 1, 1);
            this.Layout.Controls.Add(this.CuadroTelefono, 1, 2);
            this.Layout.Controls.Add(this.CuadroProfesion, 1, 4);
            this.Layout.Controls.Add(this.CuadroLugarTrabajo, 1, 5);
            this.Layout.Controls.Add(this.CuadroCUIL, 1, 6);
            this.Layout.Controls.Add(this.CuadroEstadoCivil, 1, 7);
            this.Layout.Controls.Add(this.CuadroRepresentante, 1, 8);
            this.Layout.Controls.Add(this.CuadroDomicilioLegal, 1, 9);
            this.Layout.Controls.Add(this.CuadroFechaNacimiento, 1, 3);
            this.Layout.Controls.Add(this.ListBoxJuicios, 1, 10);
            this.Layout.Location = new System.Drawing.Point(12, 130);
            this.Layout.Name = "Layout";
            this.Layout.RowCount = 12;
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Layout.Size = new System.Drawing.Size(358, 412);
            this.Layout.TabIndex = 44;
            // 
            // LabelDNI
            // 
            this.LabelDNI.AutoSize = true;
            this.LabelDNI.Location = new System.Drawing.Point(3, 0);
            this.LabelDNI.Name = "LabelDNI";
            this.LabelDNI.Size = new System.Drawing.Size(26, 13);
            this.LabelDNI.TabIndex = 0;
            this.LabelDNI.Text = "DNI";
            // 
            // LabelDomicilio
            // 
            this.LabelDomicilio.AutoSize = true;
            this.LabelDomicilio.Location = new System.Drawing.Point(3, 26);
            this.LabelDomicilio.Name = "LabelDomicilio";
            this.LabelDomicilio.Size = new System.Drawing.Size(49, 13);
            this.LabelDomicilio.TabIndex = 2;
            this.LabelDomicilio.Text = "Domicilio";
            // 
            // LabelTelefono
            // 
            this.LabelTelefono.AutoSize = true;
            this.LabelTelefono.Location = new System.Drawing.Point(3, 52);
            this.LabelTelefono.Name = "LabelTelefono";
            this.LabelTelefono.Size = new System.Drawing.Size(49, 13);
            this.LabelTelefono.TabIndex = 4;
            this.LabelTelefono.Text = "Telefono";
            // 
            // LabelFechaNacimiento
            // 
            this.LabelFechaNacimiento.AutoSize = true;
            this.LabelFechaNacimiento.Location = new System.Drawing.Point(3, 78);
            this.LabelFechaNacimiento.Name = "LabelFechaNacimiento";
            this.LabelFechaNacimiento.Size = new System.Drawing.Size(106, 13);
            this.LabelFechaNacimiento.TabIndex = 6;
            this.LabelFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // LabelProfesion
            // 
            this.LabelProfesion.AutoSize = true;
            this.LabelProfesion.Location = new System.Drawing.Point(3, 104);
            this.LabelProfesion.Name = "LabelProfesion";
            this.LabelProfesion.Size = new System.Drawing.Size(51, 13);
            this.LabelProfesion.TabIndex = 8;
            this.LabelProfesion.Text = "Profesion";
            // 
            // LabelLugarTrabajo
            // 
            this.LabelLugarTrabajo.AutoSize = true;
            this.LabelLugarTrabajo.Location = new System.Drawing.Point(3, 130);
            this.LabelLugarTrabajo.Name = "LabelLugarTrabajo";
            this.LabelLugarTrabajo.Size = new System.Drawing.Size(84, 13);
            this.LabelLugarTrabajo.TabIndex = 10;
            this.LabelLugarTrabajo.Text = "Lugar de trabajo";
            // 
            // LabelCUIL
            // 
            this.LabelCUIL.AutoSize = true;
            this.LabelCUIL.Location = new System.Drawing.Point(3, 156);
            this.LabelCUIL.Name = "LabelCUIL";
            this.LabelCUIL.Size = new System.Drawing.Size(62, 13);
            this.LabelCUIL.TabIndex = 12;
            this.LabelCUIL.Text = "CUIL/CUID";
            // 
            // LabelEstadoCivil
            // 
            this.LabelEstadoCivil.AutoSize = true;
            this.LabelEstadoCivil.Location = new System.Drawing.Point(3, 182);
            this.LabelEstadoCivil.Name = "LabelEstadoCivil";
            this.LabelEstadoCivil.Size = new System.Drawing.Size(61, 13);
            this.LabelEstadoCivil.TabIndex = 14;
            this.LabelEstadoCivil.Text = "Estado civil";
            // 
            // LabelRepresentante
            // 
            this.LabelRepresentante.AutoSize = true;
            this.LabelRepresentante.Location = new System.Drawing.Point(3, 208);
            this.LabelRepresentante.Name = "LabelRepresentante";
            this.LabelRepresentante.Size = new System.Drawing.Size(77, 13);
            this.LabelRepresentante.TabIndex = 16;
            this.LabelRepresentante.Text = "Representante";
            // 
            // LabelDomicilioLegal
            // 
            this.LabelDomicilioLegal.AutoSize = true;
            this.LabelDomicilioLegal.Location = new System.Drawing.Point(3, 234);
            this.LabelDomicilioLegal.Name = "LabelDomicilioLegal";
            this.LabelDomicilioLegal.Size = new System.Drawing.Size(74, 13);
            this.LabelDomicilioLegal.TabIndex = 18;
            this.LabelDomicilioLegal.Text = "Domicilio legal";
            // 
            // LabelJuiciosAsociados
            // 
            this.LabelJuiciosAsociados.AutoSize = true;
            this.LabelJuiciosAsociados.Location = new System.Drawing.Point(3, 260);
            this.LabelJuiciosAsociados.Name = "LabelJuiciosAsociados";
            this.LabelJuiciosAsociados.Size = new System.Drawing.Size(90, 13);
            this.LabelJuiciosAsociados.TabIndex = 20;
            this.LabelJuiciosAsociados.Text = "Juicios asociados";
            // 
            // LabelCobrosAsociados
            // 
            this.LabelCobrosAsociados.AutoSize = true;
            this.LabelCobrosAsociados.Location = new System.Drawing.Point(3, 335);
            this.LabelCobrosAsociados.Name = "LabelCobrosAsociados";
            this.LabelCobrosAsociados.Size = new System.Drawing.Size(91, 13);
            this.LabelCobrosAsociados.TabIndex = 22;
            this.LabelCobrosAsociados.Text = "Cobros asociados";
            // 
            // CuadroDNI
            // 
            this.CuadroDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroDNI.Location = new System.Drawing.Point(132, 3);
            this.CuadroDNI.Name = "CuadroDNI";
            this.CuadroDNI.Size = new System.Drawing.Size(223, 20);
            this.CuadroDNI.TabIndex = 25;
            // 
            // CuadroDomicilio
            // 
            this.CuadroDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroDomicilio.Location = new System.Drawing.Point(132, 29);
            this.CuadroDomicilio.Name = "CuadroDomicilio";
            this.CuadroDomicilio.Size = new System.Drawing.Size(223, 20);
            this.CuadroDomicilio.TabIndex = 26;
            // 
            // CuadroTelefono
            // 
            this.CuadroTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroTelefono.Location = new System.Drawing.Point(132, 55);
            this.CuadroTelefono.Name = "CuadroTelefono";
            this.CuadroTelefono.Size = new System.Drawing.Size(223, 20);
            this.CuadroTelefono.TabIndex = 27;
            // 
            // CuadroProfesion
            // 
            this.CuadroProfesion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroProfesion.Location = new System.Drawing.Point(132, 107);
            this.CuadroProfesion.Name = "CuadroProfesion";
            this.CuadroProfesion.Size = new System.Drawing.Size(223, 20);
            this.CuadroProfesion.TabIndex = 29;
            // 
            // CuadroLugarTrabajo
            // 
            this.CuadroLugarTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroLugarTrabajo.Location = new System.Drawing.Point(132, 133);
            this.CuadroLugarTrabajo.Name = "CuadroLugarTrabajo";
            this.CuadroLugarTrabajo.Size = new System.Drawing.Size(223, 20);
            this.CuadroLugarTrabajo.TabIndex = 30;
            // 
            // CuadroCUIL
            // 
            this.CuadroCUIL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroCUIL.Location = new System.Drawing.Point(132, 159);
            this.CuadroCUIL.Name = "CuadroCUIL";
            this.CuadroCUIL.Size = new System.Drawing.Size(223, 20);
            this.CuadroCUIL.TabIndex = 31;
            // 
            // CuadroEstadoCivil
            // 
            this.CuadroEstadoCivil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroEstadoCivil.Location = new System.Drawing.Point(132, 185);
            this.CuadroEstadoCivil.Name = "CuadroEstadoCivil";
            this.CuadroEstadoCivil.Size = new System.Drawing.Size(223, 20);
            this.CuadroEstadoCivil.TabIndex = 32;
            // 
            // CuadroRepresentante
            // 
            this.CuadroRepresentante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroRepresentante.Location = new System.Drawing.Point(132, 211);
            this.CuadroRepresentante.Name = "CuadroRepresentante";
            this.CuadroRepresentante.Size = new System.Drawing.Size(223, 20);
            this.CuadroRepresentante.TabIndex = 33;
            // 
            // CuadroDomicilioLegal
            // 
            this.CuadroDomicilioLegal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroDomicilioLegal.Location = new System.Drawing.Point(132, 237);
            this.CuadroDomicilioLegal.Name = "CuadroDomicilioLegal";
            this.CuadroDomicilioLegal.Size = new System.Drawing.Size(223, 20);
            this.CuadroDomicilioLegal.TabIndex = 34;
            // 
            // CuadroFechaNacimiento
            // 
            this.CuadroFechaNacimiento.Location = new System.Drawing.Point(132, 81);
            this.CuadroFechaNacimiento.Name = "CuadroFechaNacimiento";
            this.CuadroFechaNacimiento.Size = new System.Drawing.Size(223, 20);
            this.CuadroFechaNacimiento.TabIndex = 35;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCancelar.Location = new System.Drawing.Point(365, 568);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(95, 24);
            this.BotonCancelar.TabIndex = 70;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAceptar.Location = new System.Drawing.Point(20, 568);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(95, 24);
            this.BotonAceptar.TabIndex = 69;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // ListBoxJuicios
            // 
            this.ListBoxJuicios.FormattingEnabled = true;
            this.ListBoxJuicios.Location = new System.Drawing.Point(132, 263);
            this.ListBoxJuicios.Name = "ListBoxJuicios";
            this.ListBoxJuicios.Size = new System.Drawing.Size(223, 69);
            this.ListBoxJuicios.TabIndex = 180;
            this.ListBoxJuicios.SelectedIndexChanged += new System.EventHandler(this.ListBoxJuicios_SelectedIndexChanged);
            // 
            // ListBoxCobros
            // 
            this.ListBoxCobros.FormattingEnabled = true;
            this.ListBoxCobros.Location = new System.Drawing.Point(132, 338);
            this.ListBoxCobros.Name = "ListBoxCobros";
            this.ListBoxCobros.Size = new System.Drawing.Size(223, 69);
            this.ListBoxCobros.TabIndex = 180;
            // 
            // BotonConsultarCobro
            // 
            this.BotonConsultarCobro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BotonConsultarCobro.Enabled = false;
            this.BotonConsultarCobro.Location = new System.Drawing.Point(387, 468);
            this.BotonConsultarCobro.Name = "BotonConsultarCobro";
            this.BotonConsultarCobro.Size = new System.Drawing.Size(73, 25);
            this.BotonConsultarCobro.TabIndex = 180;
            this.BotonConsultarCobro.Text = "Consultar";
            this.BotonConsultarCobro.UseVisualStyleBackColor = true;
            this.BotonConsultarCobro.Click += new System.EventHandler(this.BotonConsultarCobro_Click);
            // 
            // BotonConsultarJuicio
            // 
            this.BotonConsultarJuicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BotonConsultarJuicio.Enabled = false;
            this.BotonConsultarJuicio.Location = new System.Drawing.Point(387, 393);
            this.BotonConsultarJuicio.Name = "BotonConsultarJuicio";
            this.BotonConsultarJuicio.Size = new System.Drawing.Size(73, 25);
            this.BotonConsultarJuicio.TabIndex = 179;
            this.BotonConsultarJuicio.Text = "Consultar";
            this.BotonConsultarJuicio.UseVisualStyleBackColor = true;
            this.BotonConsultarJuicio.Click += new System.EventHandler(this.BotonConsultarJuicio_Click);
            // 
            // ModificarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 604);
            this.Controls.Add(this.BotonConsultarCobro);
            this.Controls.Add(this.BotonConsultarJuicio);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.Layout);
            this.Controls.Add(this.BotonBusquedaAvanzada);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.CuadroApellido);
            this.Controls.Add(this.CuadroNombre);
            this.Controls.Add(this.LabelApellido);
            this.Controls.Add(this.LabelNombre);
            this.Name = "ModificarPersona";
            this.Text = "ModificarPersona";
            this.Load += new System.EventHandler(this.ModificarPersona_Load);
            this.Layout.ResumeLayout(false);
            this.Layout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.TextBox CuadroApellido;
        private System.Windows.Forms.TextBox CuadroNombre;
        private System.Windows.Forms.Label LabelApellido;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.Button BotonBusquedaAvanzada;
        private System.Windows.Forms.TableLayoutPanel Layout;
        private System.Windows.Forms.Label LabelDNI;
        private System.Windows.Forms.Label LabelDomicilio;
        private System.Windows.Forms.Label LabelTelefono;
        private System.Windows.Forms.Label LabelFechaNacimiento;
        private System.Windows.Forms.Label LabelProfesion;
        private System.Windows.Forms.Label LabelLugarTrabajo;
        private System.Windows.Forms.Label LabelCUIL;
        private System.Windows.Forms.Label LabelEstadoCivil;
        private System.Windows.Forms.Label LabelRepresentante;
        private System.Windows.Forms.Label LabelDomicilioLegal;
        private System.Windows.Forms.Label LabelJuiciosAsociados;
        private System.Windows.Forms.Label LabelCobrosAsociados;
        private System.Windows.Forms.TextBox CuadroDNI;
        private System.Windows.Forms.TextBox CuadroDomicilio;
        private System.Windows.Forms.TextBox CuadroTelefono;
        private System.Windows.Forms.TextBox CuadroProfesion;
        private System.Windows.Forms.TextBox CuadroLugarTrabajo;
        private System.Windows.Forms.TextBox CuadroCUIL;
        private System.Windows.Forms.TextBox CuadroEstadoCivil;
        private System.Windows.Forms.TextBox CuadroRepresentante;
        private System.Windows.Forms.TextBox CuadroDomicilioLegal;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.DateTimePicker CuadroFechaNacimiento;
        private System.Windows.Forms.ListBox ListBoxJuicios;
        private System.Windows.Forms.ListBox ListBoxCobros;
        private System.Windows.Forms.Button BotonConsultarCobro;
        private System.Windows.Forms.Button BotonConsultarJuicio;
    }
}