namespace LawyerHelper.UI.Juicios
{
    partial class BuscarJuicio
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
            this.BotonMostrarTodos = new System.Windows.Forms.Button();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.CuadroParametro = new System.Windows.Forms.TextBox();
            this.labelCuadroParametro = new System.Windows.Forms.Label();
            this.comboBoxParametro = new System.Windows.Forms.ComboBox();
            this.LabelComboBoxParametro = new System.Windows.Forms.Label();
            this.ComboBoxResultados = new System.Windows.Forms.ComboBox();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.CheckBoxEliminados = new System.Windows.Forms.CheckBox();
            this.Layout = new System.Windows.Forms.TableLayoutPanel();
            this.ListBoxDemandados = new System.Windows.Forms.ListBox();
            this.ListBoxDemandantes = new System.Windows.Forms.ListBox();
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
            this.Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotonMostrarTodos
            // 
            this.BotonMostrarTodos.Location = new System.Drawing.Point(12, 78);
            this.BotonMostrarTodos.Name = "BotonMostrarTodos";
            this.BotonMostrarTodos.Size = new System.Drawing.Size(494, 30);
            this.BotonMostrarTodos.TabIndex = 98;
            this.BotonMostrarTodos.Text = "Mostrar todos los juicios";
            this.BotonMostrarTodos.UseVisualStyleBackColor = true;
            this.BotonMostrarTodos.Click += new System.EventHandler(this.BotonMostrarTodos_Click);
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Location = new System.Drawing.Point(416, 45);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(90, 21);
            this.BotonBuscar.TabIndex = 95;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // CuadroParametro
            // 
            this.CuadroParametro.Location = new System.Drawing.Point(196, 46);
            this.CuadroParametro.Name = "CuadroParametro";
            this.CuadroParametro.Size = new System.Drawing.Size(202, 20);
            this.CuadroParametro.TabIndex = 94;
            // 
            // labelCuadroParametro
            // 
            this.labelCuadroParametro.AutoSize = true;
            this.labelCuadroParametro.Location = new System.Drawing.Point(92, 49);
            this.labelCuadroParametro.Name = "labelCuadroParametro";
            this.labelCuadroParametro.Size = new System.Drawing.Size(98, 13);
            this.labelCuadroParametro.TabIndex = 93;
            this.labelCuadroParametro.Text = "Ingresar parametro:";
            // 
            // comboBoxParametro
            // 
            this.comboBoxParametro.FormattingEnabled = true;
            this.comboBoxParametro.Items.AddRange(new object[] {
            "NroExpediente",
            "Juez",
            "Secretario",
            "Etapa",
            "Descripcion",
            "Bienes",
            "Fecha",
            "GrupoFamiliar",
            "TipoProceso",
            "Recurso",
            "Competencia",
            "Fuero",
            "Caratula",
            "Folio",
            "Libro",
            "Jurisdiccion",
            "Precio"});
            this.comboBoxParametro.Location = new System.Drawing.Point(196, 15);
            this.comboBoxParametro.Name = "comboBoxParametro";
            this.comboBoxParametro.Size = new System.Drawing.Size(202, 21);
            this.comboBoxParametro.TabIndex = 92;
            // 
            // LabelComboBoxParametro
            // 
            this.LabelComboBoxParametro.AutoSize = true;
            this.LabelComboBoxParametro.Location = new System.Drawing.Point(9, 15);
            this.LabelComboBoxParametro.Name = "LabelComboBoxParametro";
            this.LabelComboBoxParametro.Size = new System.Drawing.Size(181, 13);
            this.LabelComboBoxParametro.TabIndex = 91;
            this.LabelComboBoxParametro.Text = "Seleccionar parametro de busqueda:";
            // 
            // ComboBoxResultados
            // 
            this.ComboBoxResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxResultados.FormattingEnabled = true;
            this.ComboBoxResultados.Location = new System.Drawing.Point(39, 119);
            this.ComboBoxResultados.Name = "ComboBoxResultados";
            this.ComboBoxResultados.Size = new System.Drawing.Size(439, 21);
            this.ComboBoxResultados.TabIndex = 100;
            this.ComboBoxResultados.SelectedIndexChanged += new System.EventHandler(this.ComboBoxResultados_SelectedIndexChanged);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BotonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAceptar.Location = new System.Drawing.Point(39, 603);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(95, 24);
            this.BotonAceptar.TabIndex = 102;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCancelar.Location = new System.Drawing.Point(383, 603);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(95, 24);
            this.BotonCancelar.TabIndex = 101;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            // 
            // CheckBoxEliminados
            // 
            this.CheckBoxEliminados.AutoSize = true;
            this.CheckBoxEliminados.Location = new System.Drawing.Point(404, 17);
            this.CheckBoxEliminados.Name = "CheckBoxEliminados";
            this.CheckBoxEliminados.Size = new System.Drawing.Size(111, 17);
            this.CheckBoxEliminados.TabIndex = 103;
            this.CheckBoxEliminados.Text = "Buscar eliminados";
            this.CheckBoxEliminados.UseVisualStyleBackColor = true;
            // 
            // Layout
            // 
            this.Layout.ColumnCount = 2;
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Layout.Controls.Add(this.ListBoxDemandados, 1, 18);
            this.Layout.Controls.Add(this.ListBoxDemandantes, 1, 17);
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
            this.Layout.Location = new System.Drawing.Point(39, 146);
            this.Layout.Name = "Layout";
            this.Layout.RowCount = 19;
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
            this.Layout.Size = new System.Drawing.Size(439, 448);
            this.Layout.TabIndex = 104;
            // 
            // ListBoxDemandados
            // 
            this.ListBoxDemandados.FormattingEnabled = true;
            this.ListBoxDemandados.Location = new System.Drawing.Point(97, 374);
            this.ListBoxDemandados.Name = "ListBoxDemandados";
            this.ListBoxDemandados.Size = new System.Drawing.Size(324, 69);
            this.ListBoxDemandados.TabIndex = 178;
            // 
            // ListBoxDemandantes
            // 
            this.ListBoxDemandantes.FormattingEnabled = true;
            this.ListBoxDemandantes.Location = new System.Drawing.Point(97, 299);
            this.ListBoxDemandantes.Name = "ListBoxDemandantes";
            this.ListBoxDemandantes.Size = new System.Drawing.Size(324, 69);
            this.ListBoxDemandantes.TabIndex = 178;
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
            this.LabelDemandado.Location = new System.Drawing.Point(3, 371);
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
            // BuscarJuicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 639);
            this.Controls.Add(this.Layout);
            this.Controls.Add(this.CheckBoxEliminados);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.ComboBoxResultados);
            this.Controls.Add(this.BotonMostrarTodos);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.CuadroParametro);
            this.Controls.Add(this.labelCuadroParametro);
            this.Controls.Add(this.comboBoxParametro);
            this.Controls.Add(this.LabelComboBoxParametro);
            this.Name = "BuscarJuicio";
            this.Text = "BuscarJuicio";
            this.Layout.ResumeLayout(false);
            this.Layout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BotonMostrarTodos;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.TextBox CuadroParametro;
        private System.Windows.Forms.Label labelCuadroParametro;
        private System.Windows.Forms.ComboBox comboBoxParametro;
        private System.Windows.Forms.Label LabelComboBoxParametro;
        private System.Windows.Forms.ComboBox ComboBoxResultados;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.CheckBox CheckBoxEliminados;
        private System.Windows.Forms.TableLayoutPanel Layout;
        private System.Windows.Forms.ListBox ListBoxDemandados;
        private System.Windows.Forms.ListBox ListBoxDemandantes;
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
    }
}