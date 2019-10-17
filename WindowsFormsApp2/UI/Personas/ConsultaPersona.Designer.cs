namespace LawyerHelper.UI.Personas
{
    partial class ConsultaPersona
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
            this.LabelNombre = new System.Windows.Forms.Label();
            this.LabelApellido = new System.Windows.Forms.Label();
            this.CuadroNombre = new System.Windows.Forms.TextBox();
            this.CuadroApellido = new System.Windows.Forms.TextBox();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.Layout = new System.Windows.Forms.TableLayoutPanel();
            this.LabelDNI = new System.Windows.Forms.Label();
            this.LabelDNI2 = new System.Windows.Forms.Label();
            this.LabelDomicilio = new System.Windows.Forms.Label();
            this.LabelDomicilio2 = new System.Windows.Forms.Label();
            this.LabelTelefono = new System.Windows.Forms.Label();
            this.LabelTelefono2 = new System.Windows.Forms.Label();
            this.LabelFechaNacimiento = new System.Windows.Forms.Label();
            this.LabelFechaNacimiento2 = new System.Windows.Forms.Label();
            this.LabelProfesion = new System.Windows.Forms.Label();
            this.LabelProfesion2 = new System.Windows.Forms.Label();
            this.LabelLugarTrabajo = new System.Windows.Forms.Label();
            this.LabelLugarTrabajo2 = new System.Windows.Forms.Label();
            this.LabelCUIL = new System.Windows.Forms.Label();
            this.LabelCUIL2 = new System.Windows.Forms.Label();
            this.LabelEstadoCivil = new System.Windows.Forms.Label();
            this.LabelEstadoCivil2 = new System.Windows.Forms.Label();
            this.LabelRepresentante = new System.Windows.Forms.Label();
            this.LabelRepresentante2 = new System.Windows.Forms.Label();
            this.LabelDomicilioLegal = new System.Windows.Forms.Label();
            this.LabelDomicilioLegal2 = new System.Windows.Forms.Label();
            this.LabelJuiciosAsociados = new System.Windows.Forms.Label();
            this.LabelCobrosAsociados = new System.Windows.Forms.Label();
            this.BotonVerJuicios = new System.Windows.Forms.Button();
            this.BotonVerCobros = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonBusquedaAvanzada = new System.Windows.Forms.Button();
            this.Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(12, 28);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(44, 13);
            this.LabelNombre.TabIndex = 0;
            this.LabelNombre.Text = "Nombre";
            // 
            // LabelApellido
            // 
            this.LabelApellido.AutoSize = true;
            this.LabelApellido.Location = new System.Drawing.Point(12, 57);
            this.LabelApellido.Name = "LabelApellido";
            this.LabelApellido.Size = new System.Drawing.Size(44, 13);
            this.LabelApellido.TabIndex = 1;
            this.LabelApellido.Text = "Apellido";
            // 
            // CuadroNombre
            // 
            this.CuadroNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroNombre.Location = new System.Drawing.Point(62, 21);
            this.CuadroNombre.Name = "CuadroNombre";
            this.CuadroNombre.Size = new System.Drawing.Size(218, 20);
            this.CuadroNombre.TabIndex = 2;
            // 
            // CuadroApellido
            // 
            this.CuadroApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroApellido.Location = new System.Drawing.Point(62, 50);
            this.CuadroApellido.Name = "CuadroApellido";
            this.CuadroApellido.Size = new System.Drawing.Size(218, 20);
            this.CuadroApellido.TabIndex = 3;
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonBuscar.Location = new System.Drawing.Point(297, 50);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(75, 23);
            this.BotonBuscar.TabIndex = 4;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // Layout
            // 
            this.Layout.ColumnCount = 2;
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout.Controls.Add(this.LabelDNI, 0, 0);
            this.Layout.Controls.Add(this.LabelDNI2, 1, 0);
            this.Layout.Controls.Add(this.LabelDomicilio, 0, 1);
            this.Layout.Controls.Add(this.LabelDomicilio2, 1, 1);
            this.Layout.Controls.Add(this.LabelTelefono, 0, 2);
            this.Layout.Controls.Add(this.LabelTelefono2, 1, 2);
            this.Layout.Controls.Add(this.LabelFechaNacimiento, 0, 3);
            this.Layout.Controls.Add(this.LabelFechaNacimiento2, 1, 3);
            this.Layout.Controls.Add(this.LabelProfesion, 0, 4);
            this.Layout.Controls.Add(this.LabelProfesion2, 1, 4);
            this.Layout.Controls.Add(this.LabelLugarTrabajo, 0, 5);
            this.Layout.Controls.Add(this.LabelLugarTrabajo2, 1, 5);
            this.Layout.Controls.Add(this.LabelCUIL, 0, 6);
            this.Layout.Controls.Add(this.LabelCUIL2, 1, 6);
            this.Layout.Controls.Add(this.LabelEstadoCivil, 0, 7);
            this.Layout.Controls.Add(this.LabelEstadoCivil2, 1, 7);
            this.Layout.Controls.Add(this.LabelRepresentante, 0, 8);
            this.Layout.Controls.Add(this.LabelRepresentante2, 1, 8);
            this.Layout.Controls.Add(this.LabelDomicilioLegal, 0, 9);
            this.Layout.Controls.Add(this.LabelDomicilioLegal2, 1, 9);
            this.Layout.Controls.Add(this.LabelJuiciosAsociados, 0, 10);
            this.Layout.Controls.Add(this.LabelCobrosAsociados, 0, 11);
            this.Layout.Controls.Add(this.BotonVerJuicios, 1, 10);
            this.Layout.Controls.Add(this.BotonVerCobros, 1, 11);
            this.Layout.Location = new System.Drawing.Point(14, 130);
            this.Layout.Name = "Layout";
            this.Layout.RowCount = 12;
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.Layout.Size = new System.Drawing.Size(358, 324);
            this.Layout.TabIndex = 5;
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
            // LabelDNI2
            // 
            this.LabelDNI2.AutoSize = true;
            this.LabelDNI2.Location = new System.Drawing.Point(182, 0);
            this.LabelDNI2.Name = "LabelDNI2";
            this.LabelDNI2.Size = new System.Drawing.Size(10, 13);
            this.LabelDNI2.TabIndex = 1;
            this.LabelDNI2.Text = "-";
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
            // LabelDomicilio2
            // 
            this.LabelDomicilio2.AutoSize = true;
            this.LabelDomicilio2.Location = new System.Drawing.Point(182, 26);
            this.LabelDomicilio2.Name = "LabelDomicilio2";
            this.LabelDomicilio2.Size = new System.Drawing.Size(10, 13);
            this.LabelDomicilio2.TabIndex = 3;
            this.LabelDomicilio2.Text = "-";
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
            // LabelTelefono2
            // 
            this.LabelTelefono2.AutoSize = true;
            this.LabelTelefono2.Location = new System.Drawing.Point(182, 52);
            this.LabelTelefono2.Name = "LabelTelefono2";
            this.LabelTelefono2.Size = new System.Drawing.Size(10, 13);
            this.LabelTelefono2.TabIndex = 5;
            this.LabelTelefono2.Text = "-";
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
            // LabelFechaNacimiento2
            // 
            this.LabelFechaNacimiento2.AutoSize = true;
            this.LabelFechaNacimiento2.Location = new System.Drawing.Point(182, 78);
            this.LabelFechaNacimiento2.Name = "LabelFechaNacimiento2";
            this.LabelFechaNacimiento2.Size = new System.Drawing.Size(10, 13);
            this.LabelFechaNacimiento2.TabIndex = 7;
            this.LabelFechaNacimiento2.Text = "-";
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
            // LabelProfesion2
            // 
            this.LabelProfesion2.AutoSize = true;
            this.LabelProfesion2.Location = new System.Drawing.Point(182, 104);
            this.LabelProfesion2.Name = "LabelProfesion2";
            this.LabelProfesion2.Size = new System.Drawing.Size(10, 13);
            this.LabelProfesion2.TabIndex = 9;
            this.LabelProfesion2.Text = "-";
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
            // LabelLugarTrabajo2
            // 
            this.LabelLugarTrabajo2.AutoSize = true;
            this.LabelLugarTrabajo2.Location = new System.Drawing.Point(182, 130);
            this.LabelLugarTrabajo2.Name = "LabelLugarTrabajo2";
            this.LabelLugarTrabajo2.Size = new System.Drawing.Size(10, 13);
            this.LabelLugarTrabajo2.TabIndex = 11;
            this.LabelLugarTrabajo2.Text = "-";
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
            // LabelCUIL2
            // 
            this.LabelCUIL2.AutoSize = true;
            this.LabelCUIL2.Location = new System.Drawing.Point(182, 156);
            this.LabelCUIL2.Name = "LabelCUIL2";
            this.LabelCUIL2.Size = new System.Drawing.Size(10, 13);
            this.LabelCUIL2.TabIndex = 13;
            this.LabelCUIL2.Text = "-";
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
            // LabelEstadoCivil2
            // 
            this.LabelEstadoCivil2.AutoSize = true;
            this.LabelEstadoCivil2.Location = new System.Drawing.Point(182, 182);
            this.LabelEstadoCivil2.Name = "LabelEstadoCivil2";
            this.LabelEstadoCivil2.Size = new System.Drawing.Size(10, 13);
            this.LabelEstadoCivil2.TabIndex = 15;
            this.LabelEstadoCivil2.Text = "-";
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
            // LabelRepresentante2
            // 
            this.LabelRepresentante2.AutoSize = true;
            this.LabelRepresentante2.Location = new System.Drawing.Point(182, 208);
            this.LabelRepresentante2.Name = "LabelRepresentante2";
            this.LabelRepresentante2.Size = new System.Drawing.Size(10, 13);
            this.LabelRepresentante2.TabIndex = 17;
            this.LabelRepresentante2.Text = "-";
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
            // LabelDomicilioLegal2
            // 
            this.LabelDomicilioLegal2.AutoSize = true;
            this.LabelDomicilioLegal2.Location = new System.Drawing.Point(182, 234);
            this.LabelDomicilioLegal2.Name = "LabelDomicilioLegal2";
            this.LabelDomicilioLegal2.Size = new System.Drawing.Size(10, 13);
            this.LabelDomicilioLegal2.TabIndex = 19;
            this.LabelDomicilioLegal2.Text = "-";
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
            this.LabelCobrosAsociados.Location = new System.Drawing.Point(3, 286);
            this.LabelCobrosAsociados.Name = "LabelCobrosAsociados";
            this.LabelCobrosAsociados.Size = new System.Drawing.Size(91, 13);
            this.LabelCobrosAsociados.TabIndex = 22;
            this.LabelCobrosAsociados.Text = "Cobros asociados";
            // 
            // BotonVerJuicios
            // 
            this.BotonVerJuicios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotonVerJuicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonVerJuicios.Location = new System.Drawing.Point(231, 263);
            this.BotonVerJuicios.Name = "BotonVerJuicios";
            this.BotonVerJuicios.Size = new System.Drawing.Size(75, 20);
            this.BotonVerJuicios.TabIndex = 23;
            this.BotonVerJuicios.Text = "Ver";
            this.BotonVerJuicios.UseVisualStyleBackColor = true;
            // 
            // BotonVerCobros
            // 
            this.BotonVerCobros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotonVerCobros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonVerCobros.Location = new System.Drawing.Point(231, 293);
            this.BotonVerCobros.Name = "BotonVerCobros";
            this.BotonVerCobros.Size = new System.Drawing.Size(75, 23);
            this.BotonVerCobros.TabIndex = 24;
            this.BotonVerCobros.Text = "Ver";
            this.BotonVerCobros.UseVisualStyleBackColor = true;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCancelar.Location = new System.Drawing.Point(145, 460);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(95, 24);
            this.BotonCancelar.TabIndex = 41;
            this.BotonCancelar.Text = "Aceptar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonBusquedaAvanzada
            // 
            this.BotonBusquedaAvanzada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonBusquedaAvanzada.Location = new System.Drawing.Point(12, 86);
            this.BotonBusquedaAvanzada.Name = "BotonBusquedaAvanzada";
            this.BotonBusquedaAvanzada.Size = new System.Drawing.Size(172, 23);
            this.BotonBusquedaAvanzada.TabIndex = 42;
            this.BotonBusquedaAvanzada.Text = "Buscar por otro campo";
            this.BotonBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.BotonBusquedaAvanzada.Click += new System.EventHandler(this.BotonBusquedaAvanzada_Click);
            // 
            // ConsultaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 492);
            this.Controls.Add(this.BotonBusquedaAvanzada);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.Layout);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.CuadroApellido);
            this.Controls.Add(this.CuadroNombre);
            this.Controls.Add(this.LabelApellido);
            this.Controls.Add(this.LabelNombre);
            this.Name = "ConsultaPersona";
            this.Text = "ConsultaPersona";
            this.Layout.ResumeLayout(false);
            this.Layout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.Label LabelApellido;
        private System.Windows.Forms.TextBox CuadroNombre;
        private System.Windows.Forms.TextBox CuadroApellido;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.TableLayoutPanel Layout;
        private System.Windows.Forms.Label LabelDNI;
        private System.Windows.Forms.Label LabelDNI2;
        private System.Windows.Forms.Label LabelDomicilio;
        private System.Windows.Forms.Label LabelDomicilio2;
        private System.Windows.Forms.Label LabelTelefono;
        private System.Windows.Forms.Label LabelTelefono2;
        private System.Windows.Forms.Label LabelFechaNacimiento;
        private System.Windows.Forms.Label LabelFechaNacimiento2;
        private System.Windows.Forms.Label LabelProfesion;
        private System.Windows.Forms.Label LabelProfesion2;
        private System.Windows.Forms.Label LabelLugarTrabajo;
        private System.Windows.Forms.Label LabelLugarTrabajo2;
        private System.Windows.Forms.Label LabelCUIL;
        private System.Windows.Forms.Label LabelCUIL2;
        private System.Windows.Forms.Label LabelEstadoCivil;
        private System.Windows.Forms.Label LabelEstadoCivil2;
        private System.Windows.Forms.Label LabelRepresentante;
        private System.Windows.Forms.Label LabelRepresentante2;
        private System.Windows.Forms.Label LabelDomicilioLegal;
        private System.Windows.Forms.Label LabelDomicilioLegal2;
        private System.Windows.Forms.Label LabelJuiciosAsociados;
        private System.Windows.Forms.Label LabelCobrosAsociados;
        private System.Windows.Forms.Button BotonVerJuicios;
        private System.Windows.Forms.Button BotonVerCobros;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonBusquedaAvanzada;
    }
}