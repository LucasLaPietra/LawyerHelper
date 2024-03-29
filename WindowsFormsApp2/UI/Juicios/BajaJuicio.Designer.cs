﻿namespace LawyerHelper.UI.Juicios
{
    partial class BajaJuicio
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
            this.BotonBusquedaAvanzada = new System.Windows.Forms.Button();
            this.CuadroNroExpediente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonConsultarDemandante = new System.Windows.Forms.Button();
            this.BotonConsultarDemandados = new System.Windows.Forms.Button();
            this.Layout = new System.Windows.Forms.TableLayoutPanel();
            this.ListBoxPagos = new System.Windows.Forms.ListBox();
            this.BotonConsultarDocumentos = new System.Windows.Forms.Button();
            this.ListBoxCobros = new System.Windows.Forms.ListBox();
            this.ListBoxDemandados = new System.Windows.Forms.ListBox();
            this.LabelPagos = new System.Windows.Forms.Label();
            this.ListBoxDemandantes = new System.Windows.Forms.ListBox();
            this.LabelCobros = new System.Windows.Forms.Label();
            this.labelDocumentos = new System.Windows.Forms.Label();
            this.LabelFecha = new System.Windows.Forms.Label();
            this.LabelFolio = new System.Windows.Forms.Label();
            this.LabelFuero = new System.Windows.Forms.Label();
            this.LabelTipoProceso = new System.Windows.Forms.Label();
            this.LabelExpediente2 = new System.Windows.Forms.Label();
            this.LabelCompetencia = new System.Windows.Forms.Label();
            this.LabelRecurso = new System.Windows.Forms.Label();
            this.LabelCaratula = new System.Windows.Forms.Label();
            this.LabelLibro = new System.Windows.Forms.Label();
            this.LabelDescripcion = new System.Windows.Forms.Label();
            this.LabelBienes = new System.Windows.Forms.Label();
            this.LabelFecha2 = new System.Windows.Forms.Label();
            this.LabelFolio2 = new System.Windows.Forms.Label();
            this.LabelJurisdiccion2 = new System.Windows.Forms.Label();
            this.LabelFuero2 = new System.Windows.Forms.Label();
            this.LabelTipoProceso2 = new System.Windows.Forms.Label();
            this.LabelCompetencia2 = new System.Windows.Forms.Label();
            this.LabelRecurso2 = new System.Windows.Forms.Label();
            this.LabelCaratula2 = new System.Windows.Forms.Label();
            this.labelLibro2 = new System.Windows.Forms.Label();
            this.LabelGrupoFamiliar = new System.Windows.Forms.Label();
            this.LabelJuez = new System.Windows.Forms.Label();
            this.LabelSecretario = new System.Windows.Forms.Label();
            this.LabelPrecio = new System.Windows.Forms.Label();
            this.LabelDemandante = new System.Windows.Forms.Label();
            this.LabelDemandado = new System.Windows.Forms.Label();
            this.LabelJuez2 = new System.Windows.Forms.Label();
            this.LabelSecretario2 = new System.Windows.Forms.Label();
            this.LabelPrecio2 = new System.Windows.Forms.Label();
            this.LabelJurisdiccion = new System.Windows.Forms.Label();
            this.LabelEtapa = new System.Windows.Forms.Label();
            this.LabelExpediente = new System.Windows.Forms.Label();
            this.CuadroBienes = new System.Windows.Forms.TextBox();
            this.CuadroDescripcion = new System.Windows.Forms.TextBox();
            this.LabelEtapa2 = new System.Windows.Forms.Label();
            this.CuadroGrupoFamiliar = new System.Windows.Forms.TextBox();
            this.BotonConsultarPagos = new System.Windows.Forms.Button();
            this.BotonConsultarCobro = new System.Windows.Forms.Button();
            this.Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotonBusquedaAvanzada
            // 
            this.BotonBusquedaAvanzada.Location = new System.Drawing.Point(12, 53);
            this.BotonBusquedaAvanzada.Name = "BotonBusquedaAvanzada";
            this.BotonBusquedaAvanzada.Size = new System.Drawing.Size(138, 24);
            this.BotonBusquedaAvanzada.TabIndex = 37;
            this.BotonBusquedaAvanzada.Text = "Buscar por otro campo";
            this.BotonBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.BotonBusquedaAvanzada.Click += new System.EventHandler(this.BotonBusquedaAvanzada_Click);
            // 
            // CuadroNroExpediente
            // 
            this.CuadroNroExpediente.Location = new System.Drawing.Point(118, 14);
            this.CuadroNroExpediente.Name = "CuadroNroExpediente";
            this.CuadroNroExpediente.Size = new System.Drawing.Size(315, 20);
            this.CuadroNroExpediente.TabIndex = 34;
            this.CuadroNroExpediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CuadroNroExpediente_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nro. de expediente:";
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Location = new System.Drawing.Point(440, 9);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(90, 28);
            this.BotonBuscar.TabIndex = 96;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAceptar.Location = new System.Drawing.Point(101, 696);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(95, 22);
            this.BotonAceptar.TabIndex = 182;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCancelar.Location = new System.Drawing.Point(357, 696);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(95, 22);
            this.BotonCancelar.TabIndex = 185;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonConsultarDemandante
            // 
            this.BotonConsultarDemandante.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BotonConsultarDemandante.Enabled = false;
            this.BotonConsultarDemandante.Location = new System.Drawing.Point(457, 382);
            this.BotonConsultarDemandante.Name = "BotonConsultarDemandante";
            this.BotonConsultarDemandante.Size = new System.Drawing.Size(73, 25);
            this.BotonConsultarDemandante.TabIndex = 181;
            this.BotonConsultarDemandante.Text = "Consultar";
            this.BotonConsultarDemandante.UseVisualStyleBackColor = true;
            this.BotonConsultarDemandante.Click += new System.EventHandler(this.BotonConsultarDemandante_Click);
            // 
            // BotonConsultarDemandados
            // 
            this.BotonConsultarDemandados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BotonConsultarDemandados.Enabled = false;
            this.BotonConsultarDemandados.Location = new System.Drawing.Point(457, 444);
            this.BotonConsultarDemandados.Name = "BotonConsultarDemandados";
            this.BotonConsultarDemandados.Size = new System.Drawing.Size(73, 25);
            this.BotonConsultarDemandados.TabIndex = 183;
            this.BotonConsultarDemandados.Text = "Consultar";
            this.BotonConsultarDemandados.UseVisualStyleBackColor = true;
            this.BotonConsultarDemandados.Click += new System.EventHandler(this.BotonConsultarDemandados_Click);
            // 
            // Layout
            // 
            this.Layout.ColumnCount = 2;
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Layout.Controls.Add(this.ListBoxPagos, 1, 20);
            this.Layout.Controls.Add(this.BotonConsultarDocumentos, 1, 21);
            this.Layout.Controls.Add(this.ListBoxCobros, 1, 19);
            this.Layout.Controls.Add(this.ListBoxDemandados, 1, 18);
            this.Layout.Controls.Add(this.LabelPagos, 0, 20);
            this.Layout.Controls.Add(this.ListBoxDemandantes, 1, 17);
            this.Layout.Controls.Add(this.LabelCobros, 0, 19);
            this.Layout.Controls.Add(this.labelDocumentos, 0, 21);
            this.Layout.Controls.Add(this.LabelFecha, 0, 1);
            this.Layout.Controls.Add(this.LabelFolio, 0, 2);
            this.Layout.Controls.Add(this.LabelFuero, 0, 4);
            this.Layout.Controls.Add(this.LabelTipoProceso, 0, 5);
            this.Layout.Controls.Add(this.LabelExpediente2, 1, 0);
            this.Layout.Controls.Add(this.LabelCompetencia, 0, 6);
            this.Layout.Controls.Add(this.LabelRecurso, 0, 7);
            this.Layout.Controls.Add(this.LabelCaratula, 0, 8);
            this.Layout.Controls.Add(this.LabelLibro, 0, 9);
            this.Layout.Controls.Add(this.LabelDescripcion, 0, 10);
            this.Layout.Controls.Add(this.LabelBienes, 0, 12);
            this.Layout.Controls.Add(this.LabelFecha2, 1, 1);
            this.Layout.Controls.Add(this.LabelFolio2, 1, 2);
            this.Layout.Controls.Add(this.LabelJurisdiccion2, 1, 3);
            this.Layout.Controls.Add(this.LabelFuero2, 1, 4);
            this.Layout.Controls.Add(this.LabelTipoProceso2, 1, 5);
            this.Layout.Controls.Add(this.LabelCompetencia2, 1, 6);
            this.Layout.Controls.Add(this.LabelRecurso2, 1, 7);
            this.Layout.Controls.Add(this.LabelCaratula2, 1, 8);
            this.Layout.Controls.Add(this.labelLibro2, 1, 9);
            this.Layout.Controls.Add(this.LabelGrupoFamiliar, 0, 13);
            this.Layout.Controls.Add(this.LabelJuez, 0, 14);
            this.Layout.Controls.Add(this.LabelSecretario, 0, 15);
            this.Layout.Controls.Add(this.LabelPrecio, 0, 16);
            this.Layout.Controls.Add(this.LabelDemandante, 0, 17);
            this.Layout.Controls.Add(this.LabelDemandado, 0, 18);
            this.Layout.Controls.Add(this.LabelJuez2, 1, 14);
            this.Layout.Controls.Add(this.LabelSecretario2, 1, 15);
            this.Layout.Controls.Add(this.LabelPrecio2, 1, 16);
            this.Layout.Controls.Add(this.LabelJurisdiccion, 0, 3);
            this.Layout.Controls.Add(this.LabelEtapa, 0, 11);
            this.Layout.Controls.Add(this.LabelExpediente, 0, 0);
            this.Layout.Controls.Add(this.CuadroBienes, 1, 12);
            this.Layout.Controls.Add(this.CuadroDescripcion, 1, 10);
            this.Layout.Controls.Add(this.LabelEtapa2, 1, 11);
            this.Layout.Controls.Add(this.CuadroGrupoFamiliar, 1, 13);
            this.Layout.Location = new System.Drawing.Point(15, 83);
            this.Layout.Name = "Layout";
            this.Layout.RowCount = 22;
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
            this.Layout.Size = new System.Drawing.Size(439, 581);
            this.Layout.TabIndex = 186;
            // 
            // ListBoxPagos
            // 
            this.ListBoxPagos.FormattingEnabled = true;
            this.ListBoxPagos.Location = new System.Drawing.Point(97, 485);
            this.ListBoxPagos.Name = "ListBoxPagos";
            this.ListBoxPagos.Size = new System.Drawing.Size(337, 56);
            this.ListBoxPagos.TabIndex = 184;
            // 
            // BotonConsultarDocumentos
            // 
            this.BotonConsultarDocumentos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BotonConsultarDocumentos.Enabled = false;
            this.BotonConsultarDocumentos.Location = new System.Drawing.Point(102, 547);
            this.BotonConsultarDocumentos.Name = "BotonConsultarDocumentos";
            this.BotonConsultarDocumentos.Size = new System.Drawing.Size(332, 25);
            this.BotonConsultarDocumentos.TabIndex = 179;
            this.BotonConsultarDocumentos.Text = "Consultar Documentos";
            this.BotonConsultarDocumentos.UseVisualStyleBackColor = true;
            // 
            // ListBoxCobros
            // 
            this.ListBoxCobros.FormattingEnabled = true;
            this.ListBoxCobros.Location = new System.Drawing.Point(97, 423);
            this.ListBoxCobros.Name = "ListBoxCobros";
            this.ListBoxCobros.Size = new System.Drawing.Size(337, 56);
            this.ListBoxCobros.TabIndex = 185;
            // 
            // ListBoxDemandados
            // 
            this.ListBoxDemandados.FormattingEnabled = true;
            this.ListBoxDemandados.Location = new System.Drawing.Point(97, 361);
            this.ListBoxDemandados.Name = "ListBoxDemandados";
            this.ListBoxDemandados.Size = new System.Drawing.Size(337, 56);
            this.ListBoxDemandados.TabIndex = 178;
            // 
            // LabelPagos
            // 
            this.LabelPagos.AutoSize = true;
            this.LabelPagos.Location = new System.Drawing.Point(3, 482);
            this.LabelPagos.Name = "LabelPagos";
            this.LabelPagos.Size = new System.Drawing.Size(40, 13);
            this.LabelPagos.TabIndex = 182;
            this.LabelPagos.Text = "Pagos:";
            // 
            // ListBoxDemandantes
            // 
            this.ListBoxDemandantes.FormattingEnabled = true;
            this.ListBoxDemandantes.Location = new System.Drawing.Point(97, 299);
            this.ListBoxDemandantes.Name = "ListBoxDemandantes";
            this.ListBoxDemandantes.Size = new System.Drawing.Size(337, 56);
            this.ListBoxDemandantes.TabIndex = 178;
            // 
            // LabelCobros
            // 
            this.LabelCobros.AutoSize = true;
            this.LabelCobros.Location = new System.Drawing.Point(3, 420);
            this.LabelCobros.Name = "LabelCobros";
            this.LabelCobros.Size = new System.Drawing.Size(43, 13);
            this.LabelCobros.TabIndex = 183;
            this.LabelCobros.Text = "Cobros:";
            // 
            // labelDocumentos
            // 
            this.labelDocumentos.AutoSize = true;
            this.labelDocumentos.Location = new System.Drawing.Point(3, 544);
            this.labelDocumentos.Name = "labelDocumentos";
            this.labelDocumentos.Size = new System.Drawing.Size(70, 13);
            this.labelDocumentos.TabIndex = 175;
            this.labelDocumentos.Text = "Documentos:";
            // 
            // LabelFecha
            // 
            this.LabelFecha.AutoSize = true;
            this.LabelFecha.Location = new System.Drawing.Point(3, 13);
            this.LabelFecha.Name = "LabelFecha";
            this.LabelFecha.Size = new System.Drawing.Size(40, 13);
            this.LabelFecha.TabIndex = 1;
            this.LabelFecha.Text = "Fecha:";
            // 
            // LabelFolio
            // 
            this.LabelFolio.AutoSize = true;
            this.LabelFolio.Location = new System.Drawing.Point(3, 26);
            this.LabelFolio.Name = "LabelFolio";
            this.LabelFolio.Size = new System.Drawing.Size(32, 13);
            this.LabelFolio.TabIndex = 2;
            this.LabelFolio.Text = "Folio:";
            // 
            // LabelFuero
            // 
            this.LabelFuero.AutoSize = true;
            this.LabelFuero.Location = new System.Drawing.Point(3, 52);
            this.LabelFuero.Name = "LabelFuero";
            this.LabelFuero.Size = new System.Drawing.Size(37, 13);
            this.LabelFuero.TabIndex = 4;
            this.LabelFuero.Text = "Fuero:";
            // 
            // LabelTipoProceso
            // 
            this.LabelTipoProceso.AutoSize = true;
            this.LabelTipoProceso.Location = new System.Drawing.Point(3, 65);
            this.LabelTipoProceso.Name = "LabelTipoProceso";
            this.LabelTipoProceso.Size = new System.Drawing.Size(88, 13);
            this.LabelTipoProceso.TabIndex = 5;
            this.LabelTipoProceso.Text = "Tipo de Proceso:";
            // 
            // LabelExpediente2
            // 
            this.LabelExpediente2.AutoSize = true;
            this.LabelExpediente2.Location = new System.Drawing.Point(97, 0);
            this.LabelExpediente2.Name = "LabelExpediente2";
            this.LabelExpediente2.Size = new System.Drawing.Size(10, 13);
            this.LabelExpediente2.TabIndex = 6;
            this.LabelExpediente2.Text = "-";
            // 
            // LabelCompetencia
            // 
            this.LabelCompetencia.AutoSize = true;
            this.LabelCompetencia.Location = new System.Drawing.Point(3, 78);
            this.LabelCompetencia.Name = "LabelCompetencia";
            this.LabelCompetencia.Size = new System.Drawing.Size(72, 13);
            this.LabelCompetencia.TabIndex = 7;
            this.LabelCompetencia.Text = "Competencia:";
            // 
            // LabelRecurso
            // 
            this.LabelRecurso.AutoSize = true;
            this.LabelRecurso.Location = new System.Drawing.Point(3, 91);
            this.LabelRecurso.Name = "LabelRecurso";
            this.LabelRecurso.Size = new System.Drawing.Size(50, 13);
            this.LabelRecurso.TabIndex = 8;
            this.LabelRecurso.Text = "Recurso:";
            // 
            // LabelCaratula
            // 
            this.LabelCaratula.AutoSize = true;
            this.LabelCaratula.Location = new System.Drawing.Point(3, 104);
            this.LabelCaratula.Name = "LabelCaratula";
            this.LabelCaratula.Size = new System.Drawing.Size(49, 13);
            this.LabelCaratula.TabIndex = 9;
            this.LabelCaratula.Text = "Caratula:";
            // 
            // LabelLibro
            // 
            this.LabelLibro.AutoSize = true;
            this.LabelLibro.Location = new System.Drawing.Point(3, 117);
            this.LabelLibro.Name = "LabelLibro";
            this.LabelLibro.Size = new System.Drawing.Size(33, 13);
            this.LabelLibro.TabIndex = 10;
            this.LabelLibro.Text = "Libro:";
            // 
            // LabelDescripcion
            // 
            this.LabelDescripcion.AutoSize = true;
            this.LabelDescripcion.Location = new System.Drawing.Point(3, 130);
            this.LabelDescripcion.Name = "LabelDescripcion";
            this.LabelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.LabelDescripcion.TabIndex = 11;
            this.LabelDescripcion.Text = "Descripcion:";
            // 
            // LabelBienes
            // 
            this.LabelBienes.AutoSize = true;
            this.LabelBienes.Location = new System.Drawing.Point(3, 181);
            this.LabelBienes.Name = "LabelBienes";
            this.LabelBienes.Size = new System.Drawing.Size(42, 13);
            this.LabelBienes.TabIndex = 13;
            this.LabelBienes.Text = "Bienes:";
            // 
            // LabelFecha2
            // 
            this.LabelFecha2.AutoSize = true;
            this.LabelFecha2.Location = new System.Drawing.Point(97, 13);
            this.LabelFecha2.Name = "LabelFecha2";
            this.LabelFecha2.Size = new System.Drawing.Size(10, 13);
            this.LabelFecha2.TabIndex = 14;
            this.LabelFecha2.Text = "-";
            // 
            // LabelFolio2
            // 
            this.LabelFolio2.AutoSize = true;
            this.LabelFolio2.Location = new System.Drawing.Point(97, 26);
            this.LabelFolio2.Name = "LabelFolio2";
            this.LabelFolio2.Size = new System.Drawing.Size(10, 13);
            this.LabelFolio2.TabIndex = 15;
            this.LabelFolio2.Text = "-";
            // 
            // LabelJurisdiccion2
            // 
            this.LabelJurisdiccion2.AutoSize = true;
            this.LabelJurisdiccion2.Location = new System.Drawing.Point(97, 39);
            this.LabelJurisdiccion2.Name = "LabelJurisdiccion2";
            this.LabelJurisdiccion2.Size = new System.Drawing.Size(10, 13);
            this.LabelJurisdiccion2.TabIndex = 16;
            this.LabelJurisdiccion2.Text = "-";
            // 
            // LabelFuero2
            // 
            this.LabelFuero2.AutoSize = true;
            this.LabelFuero2.Location = new System.Drawing.Point(97, 52);
            this.LabelFuero2.Name = "LabelFuero2";
            this.LabelFuero2.Size = new System.Drawing.Size(10, 13);
            this.LabelFuero2.TabIndex = 17;
            this.LabelFuero2.Text = "-";
            // 
            // LabelTipoProceso2
            // 
            this.LabelTipoProceso2.AutoSize = true;
            this.LabelTipoProceso2.Location = new System.Drawing.Point(97, 65);
            this.LabelTipoProceso2.Name = "LabelTipoProceso2";
            this.LabelTipoProceso2.Size = new System.Drawing.Size(10, 13);
            this.LabelTipoProceso2.TabIndex = 18;
            this.LabelTipoProceso2.Text = "-";
            // 
            // LabelCompetencia2
            // 
            this.LabelCompetencia2.AutoSize = true;
            this.LabelCompetencia2.Location = new System.Drawing.Point(97, 78);
            this.LabelCompetencia2.Name = "LabelCompetencia2";
            this.LabelCompetencia2.Size = new System.Drawing.Size(10, 13);
            this.LabelCompetencia2.TabIndex = 19;
            this.LabelCompetencia2.Text = "-";
            // 
            // LabelRecurso2
            // 
            this.LabelRecurso2.AutoSize = true;
            this.LabelRecurso2.Location = new System.Drawing.Point(97, 91);
            this.LabelRecurso2.Name = "LabelRecurso2";
            this.LabelRecurso2.Size = new System.Drawing.Size(10, 13);
            this.LabelRecurso2.TabIndex = 20;
            this.LabelRecurso2.Text = "-";
            // 
            // LabelCaratula2
            // 
            this.LabelCaratula2.AutoSize = true;
            this.LabelCaratula2.Location = new System.Drawing.Point(97, 104);
            this.LabelCaratula2.Name = "LabelCaratula2";
            this.LabelCaratula2.Size = new System.Drawing.Size(10, 13);
            this.LabelCaratula2.TabIndex = 21;
            this.LabelCaratula2.Text = "-";
            // 
            // labelLibro2
            // 
            this.labelLibro2.AutoSize = true;
            this.labelLibro2.Location = new System.Drawing.Point(97, 117);
            this.labelLibro2.Name = "labelLibro2";
            this.labelLibro2.Size = new System.Drawing.Size(10, 13);
            this.labelLibro2.TabIndex = 22;
            this.labelLibro2.Text = "-";
            // 
            // LabelGrupoFamiliar
            // 
            this.LabelGrupoFamiliar.AutoSize = true;
            this.LabelGrupoFamiliar.Location = new System.Drawing.Point(3, 219);
            this.LabelGrupoFamiliar.Name = "LabelGrupoFamiliar";
            this.LabelGrupoFamiliar.Size = new System.Drawing.Size(77, 13);
            this.LabelGrupoFamiliar.TabIndex = 26;
            this.LabelGrupoFamiliar.Text = "Grupo Familiar:";
            // 
            // LabelJuez
            // 
            this.LabelJuez.AutoSize = true;
            this.LabelJuez.Location = new System.Drawing.Point(3, 257);
            this.LabelJuez.Name = "LabelJuez";
            this.LabelJuez.Size = new System.Drawing.Size(32, 13);
            this.LabelJuez.TabIndex = 27;
            this.LabelJuez.Text = "Juez:";
            // 
            // LabelSecretario
            // 
            this.LabelSecretario.AutoSize = true;
            this.LabelSecretario.Location = new System.Drawing.Point(3, 270);
            this.LabelSecretario.Name = "LabelSecretario";
            this.LabelSecretario.Size = new System.Drawing.Size(58, 13);
            this.LabelSecretario.TabIndex = 28;
            this.LabelSecretario.Text = "Secretario:";
            // 
            // LabelPrecio
            // 
            this.LabelPrecio.AutoSize = true;
            this.LabelPrecio.Location = new System.Drawing.Point(3, 283);
            this.LabelPrecio.Name = "LabelPrecio";
            this.LabelPrecio.Size = new System.Drawing.Size(40, 13);
            this.LabelPrecio.TabIndex = 29;
            this.LabelPrecio.Text = "Precio:";
            // 
            // LabelDemandante
            // 
            this.LabelDemandante.AutoSize = true;
            this.LabelDemandante.Location = new System.Drawing.Point(3, 296);
            this.LabelDemandante.Name = "LabelDemandante";
            this.LabelDemandante.Size = new System.Drawing.Size(76, 13);
            this.LabelDemandante.TabIndex = 30;
            this.LabelDemandante.Text = "Demandantes:";
            // 
            // LabelDemandado
            // 
            this.LabelDemandado.AutoSize = true;
            this.LabelDemandado.Location = new System.Drawing.Point(3, 358);
            this.LabelDemandado.Name = "LabelDemandado";
            this.LabelDemandado.Size = new System.Drawing.Size(73, 13);
            this.LabelDemandado.TabIndex = 31;
            this.LabelDemandado.Text = "Demandados:";
            // 
            // LabelJuez2
            // 
            this.LabelJuez2.AutoSize = true;
            this.LabelJuez2.Location = new System.Drawing.Point(97, 257);
            this.LabelJuez2.Name = "LabelJuez2";
            this.LabelJuez2.Size = new System.Drawing.Size(10, 13);
            this.LabelJuez2.TabIndex = 33;
            this.LabelJuez2.Text = "-";
            // 
            // LabelSecretario2
            // 
            this.LabelSecretario2.AutoSize = true;
            this.LabelSecretario2.Location = new System.Drawing.Point(97, 270);
            this.LabelSecretario2.Name = "LabelSecretario2";
            this.LabelSecretario2.Size = new System.Drawing.Size(10, 13);
            this.LabelSecretario2.TabIndex = 34;
            this.LabelSecretario2.Text = "-";
            // 
            // LabelPrecio2
            // 
            this.LabelPrecio2.AutoSize = true;
            this.LabelPrecio2.Location = new System.Drawing.Point(97, 283);
            this.LabelPrecio2.Name = "LabelPrecio2";
            this.LabelPrecio2.Size = new System.Drawing.Size(10, 13);
            this.LabelPrecio2.TabIndex = 36;
            this.LabelPrecio2.Text = "-";
            // 
            // LabelJurisdiccion
            // 
            this.LabelJurisdiccion.AutoSize = true;
            this.LabelJurisdiccion.Location = new System.Drawing.Point(3, 39);
            this.LabelJurisdiccion.Name = "LabelJurisdiccion";
            this.LabelJurisdiccion.Size = new System.Drawing.Size(65, 13);
            this.LabelJurisdiccion.TabIndex = 3;
            this.LabelJurisdiccion.Text = "Jurisdiccion:";
            // 
            // LabelEtapa
            // 
            this.LabelEtapa.AutoSize = true;
            this.LabelEtapa.Location = new System.Drawing.Point(3, 168);
            this.LabelEtapa.Name = "LabelEtapa";
            this.LabelEtapa.Size = new System.Drawing.Size(38, 13);
            this.LabelEtapa.TabIndex = 12;
            this.LabelEtapa.Text = "Etapa:";
            // 
            // LabelExpediente
            // 
            this.LabelExpediente.AutoSize = true;
            this.LabelExpediente.Location = new System.Drawing.Point(3, 0);
            this.LabelExpediente.Name = "LabelExpediente";
            this.LabelExpediente.Size = new System.Drawing.Size(83, 13);
            this.LabelExpediente.TabIndex = 0;
            this.LabelExpediente.Text = "Nro Expediente:";
            // 
            // CuadroBienes
            // 
            this.CuadroBienes.Location = new System.Drawing.Point(97, 184);
            this.CuadroBienes.Multiline = true;
            this.CuadroBienes.Name = "CuadroBienes";
            this.CuadroBienes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CuadroBienes.Size = new System.Drawing.Size(342, 32);
            this.CuadroBienes.TabIndex = 172;
            // 
            // CuadroDescripcion
            // 
            this.CuadroDescripcion.Location = new System.Drawing.Point(97, 133);
            this.CuadroDescripcion.Multiline = true;
            this.CuadroDescripcion.Name = "CuadroDescripcion";
            this.CuadroDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CuadroDescripcion.Size = new System.Drawing.Size(342, 32);
            this.CuadroDescripcion.TabIndex = 173;
            // 
            // LabelEtapa2
            // 
            this.LabelEtapa2.AutoSize = true;
            this.LabelEtapa2.Location = new System.Drawing.Point(97, 168);
            this.LabelEtapa2.Name = "LabelEtapa2";
            this.LabelEtapa2.Size = new System.Drawing.Size(10, 13);
            this.LabelEtapa2.TabIndex = 24;
            this.LabelEtapa2.Text = "-";
            // 
            // CuadroGrupoFamiliar
            // 
            this.CuadroGrupoFamiliar.Location = new System.Drawing.Point(97, 222);
            this.CuadroGrupoFamiliar.Multiline = true;
            this.CuadroGrupoFamiliar.Name = "CuadroGrupoFamiliar";
            this.CuadroGrupoFamiliar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CuadroGrupoFamiliar.Size = new System.Drawing.Size(342, 32);
            this.CuadroGrupoFamiliar.TabIndex = 174;
            // 
            // BotonConsultarPagos
            // 
            this.BotonConsultarPagos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BotonConsultarPagos.Enabled = false;
            this.BotonConsultarPagos.Location = new System.Drawing.Point(457, 568);
            this.BotonConsultarPagos.Name = "BotonConsultarPagos";
            this.BotonConsultarPagos.Size = new System.Drawing.Size(71, 25);
            this.BotonConsultarPagos.TabIndex = 188;
            this.BotonConsultarPagos.Text = "Consultar";
            this.BotonConsultarPagos.UseVisualStyleBackColor = true;
            this.BotonConsultarPagos.Click += new System.EventHandler(this.BotonConsultarPagos_Click);
            // 
            // BotonConsultarCobro
            // 
            this.BotonConsultarCobro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BotonConsultarCobro.Enabled = false;
            this.BotonConsultarCobro.Location = new System.Drawing.Point(457, 506);
            this.BotonConsultarCobro.Name = "BotonConsultarCobro";
            this.BotonConsultarCobro.Size = new System.Drawing.Size(73, 25);
            this.BotonConsultarCobro.TabIndex = 187;
            this.BotonConsultarCobro.Text = "Consultar";
            this.BotonConsultarCobro.UseVisualStyleBackColor = true;
            this.BotonConsultarCobro.Click += new System.EventHandler(this.BotonConsultarCobro_Click);
            // 
            // BajaJuicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 730);
            this.Controls.Add(this.BotonConsultarPagos);
            this.Controls.Add(this.BotonConsultarCobro);
            this.Controls.Add(this.Layout);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonConsultarDemandados);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.BotonConsultarDemandante);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.BotonBusquedaAvanzada);
            this.Controls.Add(this.CuadroNroExpediente);
            this.Controls.Add(this.label1);
            this.Name = "BajaJuicio";
            this.Text = "BajaJuicio";
            this.Layout.ResumeLayout(false);
            this.Layout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonBusquedaAvanzada;
        private System.Windows.Forms.TextBox CuadroNroExpediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonConsultarDemandante;
        private System.Windows.Forms.Button BotonConsultarDemandados;
        private System.Windows.Forms.TableLayoutPanel Layout;
        private System.Windows.Forms.ListBox ListBoxPagos;
        private System.Windows.Forms.Button BotonConsultarDocumentos;
        private System.Windows.Forms.ListBox ListBoxCobros;
        private System.Windows.Forms.ListBox ListBoxDemandados;
        private System.Windows.Forms.Label LabelPagos;
        private System.Windows.Forms.ListBox ListBoxDemandantes;
        private System.Windows.Forms.Label LabelCobros;
        private System.Windows.Forms.Label labelDocumentos;
        private System.Windows.Forms.Label LabelFecha;
        private System.Windows.Forms.Label LabelFolio;
        private System.Windows.Forms.Label LabelFuero;
        private System.Windows.Forms.Label LabelTipoProceso;
        private System.Windows.Forms.Label LabelExpediente2;
        private System.Windows.Forms.Label LabelCompetencia;
        private System.Windows.Forms.Label LabelRecurso;
        private System.Windows.Forms.Label LabelCaratula;
        private System.Windows.Forms.Label LabelLibro;
        private System.Windows.Forms.Label LabelDescripcion;
        private System.Windows.Forms.Label LabelBienes;
        private System.Windows.Forms.Label LabelFecha2;
        private System.Windows.Forms.Label LabelFolio2;
        private System.Windows.Forms.Label LabelJurisdiccion2;
        private System.Windows.Forms.Label LabelFuero2;
        private System.Windows.Forms.Label LabelTipoProceso2;
        private System.Windows.Forms.Label LabelCompetencia2;
        private System.Windows.Forms.Label LabelRecurso2;
        private System.Windows.Forms.Label LabelCaratula2;
        private System.Windows.Forms.Label labelLibro2;
        private System.Windows.Forms.Label LabelGrupoFamiliar;
        private System.Windows.Forms.Label LabelJuez;
        private System.Windows.Forms.Label LabelSecretario;
        private System.Windows.Forms.Label LabelPrecio;
        private System.Windows.Forms.Label LabelDemandante;
        private System.Windows.Forms.Label LabelDemandado;
        private System.Windows.Forms.Label LabelJuez2;
        private System.Windows.Forms.Label LabelSecretario2;
        private System.Windows.Forms.Label LabelPrecio2;
        private System.Windows.Forms.Label LabelJurisdiccion;
        private System.Windows.Forms.Label LabelEtapa;
        private System.Windows.Forms.Label LabelExpediente;
        private System.Windows.Forms.TextBox CuadroBienes;
        private System.Windows.Forms.TextBox CuadroDescripcion;
        private System.Windows.Forms.Label LabelEtapa2;
        private System.Windows.Forms.TextBox CuadroGrupoFamiliar;
        private System.Windows.Forms.Button BotonConsultarPagos;
        private System.Windows.Forms.Button BotonConsultarCobro;
    }
}