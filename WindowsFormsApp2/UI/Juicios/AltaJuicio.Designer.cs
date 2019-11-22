namespace WindowsFormsApp2.Juicios
{
    partial class AltaJuicios
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
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.LabelFolio = new System.Windows.Forms.Label();
            this.LabelExpediente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelSecretario = new System.Windows.Forms.Label();
            this.LabelEtapa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelDescripcion = new System.Windows.Forms.Label();
            this.LabelPrecio = new System.Windows.Forms.Label();
            this.CuadroFolio = new System.Windows.Forms.TextBox();
            this.CuadroExpediente = new System.Windows.Forms.TextBox();
            this.CuadroJuez = new System.Windows.Forms.TextBox();
            this.CuadroSecretario = new System.Windows.Forms.TextBox();
            this.CuadroEtapa = new System.Windows.Forms.TextBox();
            this.CuadroLugar = new System.Windows.Forms.TextBox();
            this.CuadroDescripcion = new System.Windows.Forms.TextBox();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.CuadroBienes = new System.Windows.Forms.TextBox();
            this.labelBienes = new System.Windows.Forms.Label();
            this.CuadroGrupoFamiliar = new System.Windows.Forms.TextBox();
            this.labelGrupoFamiliar = new System.Windows.Forms.Label();
            this.LabelFuero = new System.Windows.Forms.Label();
            this.CuadroTipoDeProceso = new System.Windows.Forms.TextBox();
            this.CuadroRecurso = new System.Windows.Forms.TextBox();
            this.CuadroTramite = new System.Windows.Forms.TextBox();
            this.CuadroJurisdiccion = new System.Windows.Forms.TextBox();
            this.CuadroCompetencia = new System.Windows.Forms.TextBox();
            this.labelCompetencia = new System.Windows.Forms.Label();
            this.labelRecurso = new System.Windows.Forms.Label();
            this.labelTramite = new System.Windows.Forms.Label();
            this.labelJurisdiccion = new System.Windows.Forms.Label();
            this.LabelCaratula = new System.Windows.Forms.Label();
            this.CuadroCaratula = new System.Windows.Forms.TextBox();
            this.CuadroFuero = new System.Windows.Forms.TextBox();
            this.LabelTipoDeProceso = new System.Windows.Forms.Label();
            this.labelLibro = new System.Windows.Forms.Label();
            this.CuadroLibro = new System.Windows.Forms.TextBox();
            this.Layout2 = new System.Windows.Forms.TableLayoutPanel();
            this.ListBoxDemandados = new System.Windows.Forms.ListBox();
            this.LabelDemandante = new System.Windows.Forms.Label();
            this.ListBoxDemandantes = new System.Windows.Forms.ListBox();
            this.LabelDemandado = new System.Windows.Forms.Label();
            this.RadioButtonDemandados = new System.Windows.Forms.RadioButton();
            this.RadioButtonDemandantes = new System.Windows.Forms.RadioButton();
            this.BotonEliminarDemandado = new System.Windows.Forms.Button();
            this.BotonAgregarDemandado = new System.Windows.Forms.Button();
            this.BotonEliminarDemandante = new System.Windows.Forms.Button();
            this.BotonAgregarDemandante = new System.Windows.Forms.Button();
            this.CuadroPrecio = new System.Windows.Forms.NumericUpDown();
            this.Layout2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CuadroPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fecha:";
            // 
            // dateTimeFecha
            // 
            this.dateTimeFecha.Location = new System.Drawing.Point(93, 20);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.Size = new System.Drawing.Size(221, 20);
            this.dateTimeFecha.TabIndex = 15;
            // 
            // LabelFolio
            // 
            this.LabelFolio.AutoSize = true;
            this.LabelFolio.Location = new System.Drawing.Point(57, 51);
            this.LabelFolio.Name = "LabelFolio";
            this.LabelFolio.Size = new System.Drawing.Size(32, 13);
            this.LabelFolio.TabIndex = 17;
            this.LabelFolio.Text = "Folio:";
            // 
            // LabelExpediente
            // 
            this.LabelExpediente.AutoSize = true;
            this.LabelExpediente.Location = new System.Drawing.Point(6, 82);
            this.LabelExpediente.Name = "LabelExpediente";
            this.LabelExpediente.Size = new System.Drawing.Size(83, 13);
            this.LabelExpediente.TabIndex = 18;
            this.LabelExpediente.Text = "Nro Expediente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Juez:";
            // 
            // LabelSecretario
            // 
            this.LabelSecretario.AutoSize = true;
            this.LabelSecretario.Location = new System.Drawing.Point(31, 144);
            this.LabelSecretario.Name = "LabelSecretario";
            this.LabelSecretario.Size = new System.Drawing.Size(58, 13);
            this.LabelSecretario.TabIndex = 20;
            this.LabelSecretario.Text = "Secretario:";
            // 
            // LabelEtapa
            // 
            this.LabelEtapa.AutoSize = true;
            this.LabelEtapa.Location = new System.Drawing.Point(272, 53);
            this.LabelEtapa.Name = "LabelEtapa";
            this.LabelEtapa.Size = new System.Drawing.Size(38, 13);
            this.LabelEtapa.TabIndex = 21;
            this.LabelEtapa.Text = "Etapa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Lugar:";
            // 
            // LabelDescripcion
            // 
            this.LabelDescripcion.AutoSize = true;
            this.LabelDescripcion.Location = new System.Drawing.Point(22, 444);
            this.LabelDescripcion.Name = "LabelDescripcion";
            this.LabelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.LabelDescripcion.TabIndex = 24;
            this.LabelDescripcion.Text = "Descripcion:";
            // 
            // LabelPrecio
            // 
            this.LabelPrecio.AutoSize = true;
            this.LabelPrecio.Location = new System.Drawing.Point(39, 411);
            this.LabelPrecio.Name = "LabelPrecio";
            this.LabelPrecio.Size = new System.Drawing.Size(40, 13);
            this.LabelPrecio.TabIndex = 25;
            this.LabelPrecio.Text = "Precio:";
            // 
            // CuadroFolio
            // 
            this.CuadroFolio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroFolio.Location = new System.Drawing.Point(93, 51);
            this.CuadroFolio.Name = "CuadroFolio";
            this.CuadroFolio.Size = new System.Drawing.Size(168, 20);
            this.CuadroFolio.TabIndex = 26;
            // 
            // CuadroExpediente
            // 
            this.CuadroExpediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroExpediente.Location = new System.Drawing.Point(94, 79);
            this.CuadroExpediente.Name = "CuadroExpediente";
            this.CuadroExpediente.Size = new System.Drawing.Size(164, 20);
            this.CuadroExpediente.TabIndex = 27;
            // 
            // CuadroJuez
            // 
            this.CuadroJuez.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroJuez.Location = new System.Drawing.Point(93, 110);
            this.CuadroJuez.Name = "CuadroJuez";
            this.CuadroJuez.Size = new System.Drawing.Size(390, 20);
            this.CuadroJuez.TabIndex = 28;
            // 
            // CuadroSecretario
            // 
            this.CuadroSecretario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroSecretario.Location = new System.Drawing.Point(93, 141);
            this.CuadroSecretario.Name = "CuadroSecretario";
            this.CuadroSecretario.Size = new System.Drawing.Size(390, 20);
            this.CuadroSecretario.TabIndex = 29;
            // 
            // CuadroEtapa
            // 
            this.CuadroEtapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroEtapa.Location = new System.Drawing.Point(315, 48);
            this.CuadroEtapa.Name = "CuadroEtapa";
            this.CuadroEtapa.Size = new System.Drawing.Size(168, 20);
            this.CuadroEtapa.TabIndex = 30;
            // 
            // CuadroLugar
            // 
            this.CuadroLugar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroLugar.Location = new System.Drawing.Point(315, 77);
            this.CuadroLugar.Name = "CuadroLugar";
            this.CuadroLugar.Size = new System.Drawing.Size(168, 20);
            this.CuadroLugar.TabIndex = 31;
            // 
            // CuadroDescripcion
            // 
            this.CuadroDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroDescripcion.Location = new System.Drawing.Point(92, 444);
            this.CuadroDescripcion.Multiline = true;
            this.CuadroDescripcion.Name = "CuadroDescripcion";
            this.CuadroDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CuadroDescripcion.Size = new System.Drawing.Size(385, 70);
            this.CuadroDescripcion.TabIndex = 33;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCancelar.Location = new System.Drawing.Point(590, 556);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(95, 24);
            this.BotonCancelar.TabIndex = 37;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAceptar.Location = new System.Drawing.Point(382, 556);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(95, 24);
            this.BotonAceptar.TabIndex = 36;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // CuadroBienes
            // 
            this.CuadroBienes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroBienes.Location = new System.Drawing.Point(93, 305);
            this.CuadroBienes.Multiline = true;
            this.CuadroBienes.Name = "CuadroBienes";
            this.CuadroBienes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CuadroBienes.Size = new System.Drawing.Size(384, 35);
            this.CuadroBienes.TabIndex = 49;
            // 
            // labelBienes
            // 
            this.labelBienes.AutoSize = true;
            this.labelBienes.Location = new System.Drawing.Point(42, 308);
            this.labelBienes.Name = "labelBienes";
            this.labelBienes.Size = new System.Drawing.Size(42, 13);
            this.labelBienes.TabIndex = 48;
            this.labelBienes.Text = "Bienes:";
            // 
            // CuadroGrupoFamiliar
            // 
            this.CuadroGrupoFamiliar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroGrupoFamiliar.Location = new System.Drawing.Point(93, 356);
            this.CuadroGrupoFamiliar.Multiline = true;
            this.CuadroGrupoFamiliar.Name = "CuadroGrupoFamiliar";
            this.CuadroGrupoFamiliar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CuadroGrupoFamiliar.Size = new System.Drawing.Size(384, 35);
            this.CuadroGrupoFamiliar.TabIndex = 50;
            // 
            // labelGrupoFamiliar
            // 
            this.labelGrupoFamiliar.AutoSize = true;
            this.labelGrupoFamiliar.Location = new System.Drawing.Point(9, 359);
            this.labelGrupoFamiliar.Name = "labelGrupoFamiliar";
            this.labelGrupoFamiliar.Size = new System.Drawing.Size(80, 13);
            this.labelGrupoFamiliar.TabIndex = 51;
            this.labelGrupoFamiliar.Text = "Grupo Familiar: ";
            // 
            // LabelFuero
            // 
            this.LabelFuero.AutoSize = true;
            this.LabelFuero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelFuero.Location = new System.Drawing.Point(273, 238);
            this.LabelFuero.Name = "LabelFuero";
            this.LabelFuero.Size = new System.Drawing.Size(37, 13);
            this.LabelFuero.TabIndex = 63;
            this.LabelFuero.Text = "Fuero:";
            // 
            // CuadroTipoDeProceso
            // 
            this.CuadroTipoDeProceso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroTipoDeProceso.Location = new System.Drawing.Point(93, 236);
            this.CuadroTipoDeProceso.Name = "CuadroTipoDeProceso";
            this.CuadroTipoDeProceso.Size = new System.Drawing.Size(165, 20);
            this.CuadroTipoDeProceso.TabIndex = 62;
            // 
            // CuadroRecurso
            // 
            this.CuadroRecurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroRecurso.Location = new System.Drawing.Point(315, 206);
            this.CuadroRecurso.Name = "CuadroRecurso";
            this.CuadroRecurso.Size = new System.Drawing.Size(168, 20);
            this.CuadroRecurso.TabIndex = 61;
            // 
            // CuadroTramite
            // 
            this.CuadroTramite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroTramite.Location = new System.Drawing.Point(315, 171);
            this.CuadroTramite.Name = "CuadroTramite";
            this.CuadroTramite.Size = new System.Drawing.Size(168, 20);
            this.CuadroTramite.TabIndex = 60;
            // 
            // CuadroJurisdiccion
            // 
            this.CuadroJurisdiccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroJurisdiccion.Location = new System.Drawing.Point(93, 171);
            this.CuadroJurisdiccion.Name = "CuadroJurisdiccion";
            this.CuadroJurisdiccion.Size = new System.Drawing.Size(168, 20);
            this.CuadroJurisdiccion.TabIndex = 59;
            // 
            // CuadroCompetencia
            // 
            this.CuadroCompetencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroCompetencia.Location = new System.Drawing.Point(93, 203);
            this.CuadroCompetencia.Name = "CuadroCompetencia";
            this.CuadroCompetencia.Size = new System.Drawing.Size(168, 20);
            this.CuadroCompetencia.TabIndex = 58;
            // 
            // labelCompetencia
            // 
            this.labelCompetencia.AutoSize = true;
            this.labelCompetencia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCompetencia.Location = new System.Drawing.Point(18, 206);
            this.labelCompetencia.Name = "labelCompetencia";
            this.labelCompetencia.Size = new System.Drawing.Size(72, 13);
            this.labelCompetencia.TabIndex = 57;
            this.labelCompetencia.Text = "Competencia:";
            // 
            // labelRecurso
            // 
            this.labelRecurso.AutoSize = true;
            this.labelRecurso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelRecurso.Location = new System.Drawing.Point(260, 210);
            this.labelRecurso.Name = "labelRecurso";
            this.labelRecurso.Size = new System.Drawing.Size(50, 13);
            this.labelRecurso.TabIndex = 56;
            this.labelRecurso.Text = "Recurso:";
            // 
            // labelTramite
            // 
            this.labelTramite.AutoSize = true;
            this.labelTramite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTramite.Location = new System.Drawing.Point(269, 175);
            this.labelTramite.Name = "labelTramite";
            this.labelTramite.Size = new System.Drawing.Size(45, 13);
            this.labelTramite.TabIndex = 55;
            this.labelTramite.Text = "Tramite:";
            // 
            // labelJurisdiccion
            // 
            this.labelJurisdiccion.AutoSize = true;
            this.labelJurisdiccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelJurisdiccion.Location = new System.Drawing.Point(25, 175);
            this.labelJurisdiccion.Name = "labelJurisdiccion";
            this.labelJurisdiccion.Size = new System.Drawing.Size(65, 13);
            this.labelJurisdiccion.TabIndex = 54;
            this.labelJurisdiccion.Text = "Jurisdiccion:";
            // 
            // LabelCaratula
            // 
            this.LabelCaratula.AutoSize = true;
            this.LabelCaratula.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelCaratula.Location = new System.Drawing.Point(38, 272);
            this.LabelCaratula.Name = "LabelCaratula";
            this.LabelCaratula.Size = new System.Drawing.Size(49, 13);
            this.LabelCaratula.TabIndex = 65;
            this.LabelCaratula.Text = "Caratula:";
            // 
            // CuadroCaratula
            // 
            this.CuadroCaratula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroCaratula.Location = new System.Drawing.Point(93, 269);
            this.CuadroCaratula.Name = "CuadroCaratula";
            this.CuadroCaratula.Size = new System.Drawing.Size(165, 20);
            this.CuadroCaratula.TabIndex = 64;
            // 
            // CuadroFuero
            // 
            this.CuadroFuero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroFuero.Location = new System.Drawing.Point(318, 236);
            this.CuadroFuero.Name = "CuadroFuero";
            this.CuadroFuero.Size = new System.Drawing.Size(165, 20);
            this.CuadroFuero.TabIndex = 66;
            // 
            // LabelTipoDeProceso
            // 
            this.LabelTipoDeProceso.AutoSize = true;
            this.LabelTipoDeProceso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelTipoDeProceso.Location = new System.Drawing.Point(2, 239);
            this.LabelTipoDeProceso.Name = "LabelTipoDeProceso";
            this.LabelTipoDeProceso.Size = new System.Drawing.Size(88, 13);
            this.LabelTipoDeProceso.TabIndex = 67;
            this.LabelTipoDeProceso.Text = "Tipo de Proceso:";
            // 
            // labelLibro
            // 
            this.labelLibro.AutoSize = true;
            this.labelLibro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLibro.Location = new System.Drawing.Point(277, 269);
            this.labelLibro.Name = "labelLibro";
            this.labelLibro.Size = new System.Drawing.Size(33, 13);
            this.labelLibro.TabIndex = 69;
            this.labelLibro.Text = "Libro:";
            // 
            // CuadroLibro
            // 
            this.CuadroLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroLibro.Location = new System.Drawing.Point(318, 269);
            this.CuadroLibro.Name = "CuadroLibro";
            this.CuadroLibro.Size = new System.Drawing.Size(165, 20);
            this.CuadroLibro.TabIndex = 68;
            // 
            // Layout2
            // 
            this.Layout2.ColumnCount = 2;
            this.Layout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Layout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Layout2.Controls.Add(this.ListBoxDemandados, 1, 1);
            this.Layout2.Controls.Add(this.LabelDemandante, 0, 0);
            this.Layout2.Controls.Add(this.ListBoxDemandantes, 1, 0);
            this.Layout2.Controls.Add(this.LabelDemandado, 0, 1);
            this.Layout2.Location = new System.Drawing.Point(505, 20);
            this.Layout2.Name = "Layout2";
            this.Layout2.RowCount = 5;
            this.Layout2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout2.Size = new System.Drawing.Size(411, 271);
            this.Layout2.TabIndex = 94;
            // 
            // ListBoxDemandados
            // 
            this.ListBoxDemandados.FormattingEnabled = true;
            this.ListBoxDemandados.Location = new System.Drawing.Point(85, 78);
            this.ListBoxDemandados.Name = "ListBoxDemandados";
            this.ListBoxDemandados.Size = new System.Drawing.Size(324, 69);
            this.ListBoxDemandados.TabIndex = 74;
            // 
            // LabelDemandante
            // 
            this.LabelDemandante.AutoSize = true;
            this.LabelDemandante.Location = new System.Drawing.Point(3, 0);
            this.LabelDemandante.Name = "LabelDemandante";
            this.LabelDemandante.Size = new System.Drawing.Size(76, 13);
            this.LabelDemandante.TabIndex = 30;
            this.LabelDemandante.Text = "Demandantes:";
            // 
            // ListBoxDemandantes
            // 
            this.ListBoxDemandantes.FormattingEnabled = true;
            this.ListBoxDemandantes.Location = new System.Drawing.Point(85, 3);
            this.ListBoxDemandantes.Name = "ListBoxDemandantes";
            this.ListBoxDemandantes.Size = new System.Drawing.Size(324, 69);
            this.ListBoxDemandantes.TabIndex = 73;
            // 
            // LabelDemandado
            // 
            this.LabelDemandado.AutoSize = true;
            this.LabelDemandado.Location = new System.Drawing.Point(3, 75);
            this.LabelDemandado.Name = "LabelDemandado";
            this.LabelDemandado.Size = new System.Drawing.Size(73, 13);
            this.LabelDemandado.TabIndex = 31;
            this.LabelDemandado.Text = "Demandados:";
            // 
            // RadioButtonDemandados
            // 
            this.RadioButtonDemandados.AutoSize = true;
            this.RadioButtonDemandados.Location = new System.Drawing.Point(1003, 122);
            this.RadioButtonDemandados.Name = "RadioButtonDemandados";
            this.RadioButtonDemandados.Size = new System.Drawing.Size(57, 17);
            this.RadioButtonDemandados.TabIndex = 93;
            this.RadioButtonDemandados.TabStop = true;
            this.RadioButtonDemandados.Text = "Cliente";
            this.RadioButtonDemandados.UseVisualStyleBackColor = true;
            // 
            // RadioButtonDemandantes
            // 
            this.RadioButtonDemandantes.AutoSize = true;
            this.RadioButtonDemandantes.Location = new System.Drawing.Point(1003, 49);
            this.RadioButtonDemandantes.Name = "RadioButtonDemandantes";
            this.RadioButtonDemandantes.Size = new System.Drawing.Size(57, 17);
            this.RadioButtonDemandantes.TabIndex = 92;
            this.RadioButtonDemandantes.TabStop = true;
            this.RadioButtonDemandantes.Text = "Cliente";
            this.RadioButtonDemandantes.UseVisualStyleBackColor = true;
            // 
            // BotonEliminarDemandado
            // 
            this.BotonEliminarDemandado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonEliminarDemandado.Location = new System.Drawing.Point(922, 135);
            this.BotonEliminarDemandado.Name = "BotonEliminarDemandado";
            this.BotonEliminarDemandado.Size = new System.Drawing.Size(75, 23);
            this.BotonEliminarDemandado.TabIndex = 91;
            this.BotonEliminarDemandado.Text = "Eliminar";
            this.BotonEliminarDemandado.UseVisualStyleBackColor = true;
            this.BotonEliminarDemandado.Click += new System.EventHandler(this.BotonEliminarDemandado_Click);
            // 
            // BotonAgregarDemandado
            // 
            this.BotonAgregarDemandado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAgregarDemandado.Location = new System.Drawing.Point(922, 106);
            this.BotonAgregarDemandado.Name = "BotonAgregarDemandado";
            this.BotonAgregarDemandado.Size = new System.Drawing.Size(75, 23);
            this.BotonAgregarDemandado.TabIndex = 90;
            this.BotonAgregarDemandado.Text = "Agregar";
            this.BotonAgregarDemandado.UseVisualStyleBackColor = true;
            this.BotonAgregarDemandado.Click += new System.EventHandler(this.BotonAgregarDemandado_Click);
            // 
            // BotonEliminarDemandante
            // 
            this.BotonEliminarDemandante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonEliminarDemandante.Location = new System.Drawing.Point(922, 61);
            this.BotonEliminarDemandante.Name = "BotonEliminarDemandante";
            this.BotonEliminarDemandante.Size = new System.Drawing.Size(75, 23);
            this.BotonEliminarDemandante.TabIndex = 89;
            this.BotonEliminarDemandante.Text = "Eliminar";
            this.BotonEliminarDemandante.UseVisualStyleBackColor = true;
            this.BotonEliminarDemandante.Click += new System.EventHandler(this.BotonEliminarDemandante_Click);
            // 
            // BotonAgregarDemandante
            // 
            this.BotonAgregarDemandante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAgregarDemandante.Location = new System.Drawing.Point(922, 32);
            this.BotonAgregarDemandante.Name = "BotonAgregarDemandante";
            this.BotonAgregarDemandante.Size = new System.Drawing.Size(75, 23);
            this.BotonAgregarDemandante.TabIndex = 88;
            this.BotonAgregarDemandante.Text = "Agregar";
            this.BotonAgregarDemandante.UseVisualStyleBackColor = true;
            this.BotonAgregarDemandante.Click += new System.EventHandler(this.BotonAgregarDemandante_Click);
            // 
            // CuadroPrecio
            // 
            this.CuadroPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuadroPrecio.DecimalPlaces = 2;
            this.CuadroPrecio.Location = new System.Drawing.Point(92, 409);
            this.CuadroPrecio.Name = "CuadroPrecio";
            this.CuadroPrecio.Size = new System.Drawing.Size(385, 20);
            this.CuadroPrecio.TabIndex = 99;
            // 
            // AltaJuicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 589);
            this.Controls.Add(this.CuadroPrecio);
            this.Controls.Add(this.Layout2);
            this.Controls.Add(this.RadioButtonDemandados);
            this.Controls.Add(this.RadioButtonDemandantes);
            this.Controls.Add(this.BotonEliminarDemandado);
            this.Controls.Add(this.BotonAgregarDemandado);
            this.Controls.Add(this.BotonEliminarDemandante);
            this.Controls.Add(this.BotonAgregarDemandante);
            this.Controls.Add(this.labelLibro);
            this.Controls.Add(this.CuadroLibro);
            this.Controls.Add(this.LabelTipoDeProceso);
            this.Controls.Add(this.CuadroFuero);
            this.Controls.Add(this.LabelCaratula);
            this.Controls.Add(this.CuadroCaratula);
            this.Controls.Add(this.LabelFuero);
            this.Controls.Add(this.CuadroTipoDeProceso);
            this.Controls.Add(this.CuadroRecurso);
            this.Controls.Add(this.CuadroTramite);
            this.Controls.Add(this.CuadroJurisdiccion);
            this.Controls.Add(this.CuadroCompetencia);
            this.Controls.Add(this.labelCompetencia);
            this.Controls.Add(this.labelRecurso);
            this.Controls.Add(this.labelTramite);
            this.Controls.Add(this.labelJurisdiccion);
            this.Controls.Add(this.labelGrupoFamiliar);
            this.Controls.Add(this.CuadroGrupoFamiliar);
            this.Controls.Add(this.CuadroBienes);
            this.Controls.Add(this.labelBienes);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.CuadroDescripcion);
            this.Controls.Add(this.CuadroLugar);
            this.Controls.Add(this.CuadroEtapa);
            this.Controls.Add(this.CuadroSecretario);
            this.Controls.Add(this.CuadroJuez);
            this.Controls.Add(this.CuadroExpediente);
            this.Controls.Add(this.CuadroFolio);
            this.Controls.Add(this.LabelPrecio);
            this.Controls.Add(this.LabelDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelEtapa);
            this.Controls.Add(this.LabelSecretario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelExpediente);
            this.Controls.Add(this.LabelFolio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeFecha);
            this.Name = "AltaJuicios";
            this.Text = "AltaJuicios";
            this.Load += new System.EventHandler(this.AltaJuicios_Load);
            this.Layout2.ResumeLayout(false);
            this.Layout2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CuadroPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeFecha;
        private System.Windows.Forms.Label LabelFolio;
        private System.Windows.Forms.Label LabelExpediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelSecretario;
        private System.Windows.Forms.Label LabelEtapa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelDescripcion;
        private System.Windows.Forms.Label LabelPrecio;
        private System.Windows.Forms.TextBox CuadroFolio;
        private System.Windows.Forms.TextBox CuadroExpediente;
        private System.Windows.Forms.TextBox CuadroJuez;
        private System.Windows.Forms.TextBox CuadroSecretario;
        private System.Windows.Forms.TextBox CuadroEtapa;
        private System.Windows.Forms.TextBox CuadroLugar;
        private System.Windows.Forms.TextBox CuadroDescripcion;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.TextBox CuadroBienes;
        private System.Windows.Forms.Label labelBienes;
        private System.Windows.Forms.TextBox CuadroGrupoFamiliar;
        private System.Windows.Forms.Label labelGrupoFamiliar;
        private System.Windows.Forms.Label LabelFuero;
        private System.Windows.Forms.TextBox CuadroTipoDeProceso;
        private System.Windows.Forms.TextBox CuadroRecurso;
        private System.Windows.Forms.TextBox CuadroTramite;
        private System.Windows.Forms.TextBox CuadroJurisdiccion;
        private System.Windows.Forms.TextBox CuadroCompetencia;
        private System.Windows.Forms.Label labelCompetencia;
        private System.Windows.Forms.Label labelRecurso;
        private System.Windows.Forms.Label labelTramite;
        private System.Windows.Forms.Label labelJurisdiccion;
        private System.Windows.Forms.Label LabelCaratula;
        private System.Windows.Forms.TextBox CuadroCaratula;
        private System.Windows.Forms.TextBox CuadroFuero;
        private System.Windows.Forms.Label LabelTipoDeProceso;
        private System.Windows.Forms.Label labelLibro;
        private System.Windows.Forms.TextBox CuadroLibro;
        private System.Windows.Forms.TableLayoutPanel Layout2;
        private System.Windows.Forms.ListBox ListBoxDemandados;
        private System.Windows.Forms.Label LabelDemandante;
        private System.Windows.Forms.ListBox ListBoxDemandantes;
        private System.Windows.Forms.Label LabelDemandado;
        private System.Windows.Forms.RadioButton RadioButtonDemandados;
        private System.Windows.Forms.RadioButton RadioButtonDemandantes;
        private System.Windows.Forms.Button BotonEliminarDemandado;
        private System.Windows.Forms.Button BotonAgregarDemandado;
        private System.Windows.Forms.Button BotonEliminarDemandante;
        private System.Windows.Forms.Button BotonAgregarDemandante;
        private System.Windows.Forms.NumericUpDown CuadroPrecio;
    }
}