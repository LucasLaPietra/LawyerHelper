namespace LawyerHelper.UI.Documentos
{
    partial class BajaDocumento
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
            this.LabelFecha2 = new System.Windows.Forms.Label();
            this.LabelTipo2 = new System.Windows.Forms.Label();
            this.LabelNombre2 = new System.Windows.Forms.Label();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.CuadroNumeroFoja = new System.Windows.Forms.TextBox();
            this.CheckEnExpediente = new System.Windows.Forms.CheckBox();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.CuadroDetalle = new System.Windows.Forms.TextBox();
            this.LabelDetalle = new System.Windows.Forms.Label();
            this.LabelFecha = new System.Windows.Forms.Label();
            this.LabelExpediente = new System.Windows.Forms.Label();
            this.LabelFoja = new System.Windows.Forms.Label();
            this.LabelTipoDocumento = new System.Windows.Forms.Label();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.LabelFoja2 = new System.Windows.Forms.Label();
            this.ComboBoxResultados = new System.Windows.Forms.ComboBox();
            this.BotonMostrarTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelFecha2
            // 
            this.LabelFecha2.AutoSize = true;
            this.LabelFecha2.Location = new System.Drawing.Point(143, 303);
            this.LabelFecha2.Name = "LabelFecha2";
            this.LabelFecha2.Size = new System.Drawing.Size(10, 13);
            this.LabelFecha2.TabIndex = 78;
            this.LabelFecha2.Text = "-";
            // 
            // LabelTipo2
            // 
            this.LabelTipo2.AutoSize = true;
            this.LabelTipo2.Location = new System.Drawing.Point(143, 167);
            this.LabelTipo2.Name = "LabelTipo2";
            this.LabelTipo2.Size = new System.Drawing.Size(10, 13);
            this.LabelTipo2.TabIndex = 77;
            this.LabelTipo2.Text = "-";
            // 
            // LabelNombre2
            // 
            this.LabelNombre2.AutoSize = true;
            this.LabelNombre2.Location = new System.Drawing.Point(143, 127);
            this.LabelNombre2.Name = "LabelNombre2";
            this.LabelNombre2.Size = new System.Drawing.Size(10, 13);
            this.LabelNombre2.TabIndex = 76;
            this.LabelNombre2.Text = "-";
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Location = new System.Drawing.Point(299, 22);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(75, 23);
            this.BotonBuscar.TabIndex = 74;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // CuadroNumeroFoja
            // 
            this.CuadroNumeroFoja.Location = new System.Drawing.Point(122, 24);
            this.CuadroNumeroFoja.Name = "CuadroNumeroFoja";
            this.CuadroNumeroFoja.Size = new System.Drawing.Size(171, 20);
            this.CuadroNumeroFoja.TabIndex = 73;
            // 
            // CheckEnExpediente
            // 
            this.CheckEnExpediente.AutoCheck = false;
            this.CheckEnExpediente.AutoSize = true;
            this.CheckEnExpediente.Location = new System.Drawing.Point(146, 252);
            this.CheckEnExpediente.Name = "CheckEnExpediente";
            this.CheckEnExpediente.Size = new System.Drawing.Size(35, 17);
            this.CheckEnExpediente.TabIndex = 71;
            this.CheckEnExpediente.Text = "Si";
            this.CheckEnExpediente.UseVisualStyleBackColor = true;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(279, 521);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(95, 24);
            this.BotonCancelar.TabIndex = 69;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Numero de foja";
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Location = new System.Drawing.Point(21, 521);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(100, 23);
            this.BotonAceptar.TabIndex = 80;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // CuadroDetalle
            // 
            this.CuadroDetalle.Location = new System.Drawing.Point(124, 342);
            this.CuadroDetalle.Multiline = true;
            this.CuadroDetalle.Name = "CuadroDetalle";
            this.CuadroDetalle.ReadOnly = true;
            this.CuadroDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CuadroDetalle.Size = new System.Drawing.Size(250, 151);
            this.CuadroDetalle.TabIndex = 199;
            // 
            // LabelDetalle
            // 
            this.LabelDetalle.AutoSize = true;
            this.LabelDetalle.Location = new System.Drawing.Point(73, 345);
            this.LabelDetalle.Name = "LabelDetalle";
            this.LabelDetalle.Size = new System.Drawing.Size(40, 13);
            this.LabelDetalle.TabIndex = 198;
            this.LabelDetalle.Text = "Detalle";
            // 
            // LabelFecha
            // 
            this.LabelFecha.AutoSize = true;
            this.LabelFecha.Location = new System.Drawing.Point(76, 303);
            this.LabelFecha.Name = "LabelFecha";
            this.LabelFecha.Size = new System.Drawing.Size(37, 13);
            this.LabelFecha.TabIndex = 197;
            this.LabelFecha.Text = "Fecha";
            // 
            // LabelExpediente
            // 
            this.LabelExpediente.AutoSize = true;
            this.LabelExpediente.Location = new System.Drawing.Point(38, 253);
            this.LabelExpediente.Name = "LabelExpediente";
            this.LabelExpediente.Size = new System.Drawing.Size(75, 13);
            this.LabelExpediente.TabIndex = 196;
            this.LabelExpediente.Text = "En expediente";
            // 
            // LabelFoja
            // 
            this.LabelFoja.AutoSize = true;
            this.LabelFoja.Location = new System.Drawing.Point(34, 214);
            this.LabelFoja.Name = "LabelFoja";
            this.LabelFoja.Size = new System.Drawing.Size(79, 13);
            this.LabelFoja.TabIndex = 195;
            this.LabelFoja.Text = "Numero de foja";
            // 
            // LabelTipoDocumento
            // 
            this.LabelTipoDocumento.AutoSize = true;
            this.LabelTipoDocumento.Location = new System.Drawing.Point(14, 167);
            this.LabelTipoDocumento.Name = "LabelTipoDocumento";
            this.LabelTipoDocumento.Size = new System.Drawing.Size(99, 13);
            this.LabelTipoDocumento.TabIndex = 194;
            this.LabelTipoDocumento.Text = "Tipo de documento";
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(66, 127);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(47, 13);
            this.LabelNombre.TabIndex = 193;
            this.LabelNombre.Text = "Nombre ";
            // 
            // LabelFoja2
            // 
            this.LabelFoja2.AutoSize = true;
            this.LabelFoja2.Location = new System.Drawing.Point(143, 214);
            this.LabelFoja2.Name = "LabelFoja2";
            this.LabelFoja2.Size = new System.Drawing.Size(10, 13);
            this.LabelFoja2.TabIndex = 203;
            this.LabelFoja2.Text = "-";
            // 
            // ComboBoxResultados
            // 
            this.ComboBoxResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxResultados.FormattingEnabled = true;
            this.ComboBoxResultados.Location = new System.Drawing.Point(21, 92);
            this.ComboBoxResultados.Name = "ComboBoxResultados";
            this.ComboBoxResultados.Size = new System.Drawing.Size(353, 21);
            this.ComboBoxResultados.TabIndex = 205;
            this.ComboBoxResultados.SelectedIndexChanged += new System.EventHandler(this.ComboBoxResultados_SelectedIndexChanged);
            // 
            // BotonMostrarTodos
            // 
            this.BotonMostrarTodos.Location = new System.Drawing.Point(17, 51);
            this.BotonMostrarTodos.Name = "BotonMostrarTodos";
            this.BotonMostrarTodos.Size = new System.Drawing.Size(357, 30);
            this.BotonMostrarTodos.TabIndex = 204;
            this.BotonMostrarTodos.Text = "Mostrar todos los documentos";
            this.BotonMostrarTodos.UseVisualStyleBackColor = true;
            this.BotonMostrarTodos.Click += new System.EventHandler(this.BotonMostrarTodos_Click);
            // 
            // BajaDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.ComboBoxResultados);
            this.Controls.Add(this.BotonMostrarTodos);
            this.Controls.Add(this.LabelFoja2);
            this.Controls.Add(this.CuadroDetalle);
            this.Controls.Add(this.LabelDetalle);
            this.Controls.Add(this.LabelFecha);
            this.Controls.Add(this.LabelExpediente);
            this.Controls.Add(this.LabelFoja);
            this.Controls.Add(this.LabelTipoDocumento);
            this.Controls.Add(this.LabelNombre);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.LabelFecha2);
            this.Controls.Add(this.LabelTipo2);
            this.Controls.Add(this.LabelNombre2);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.CuadroNumeroFoja);
            this.Controls.Add(this.CheckEnExpediente);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.label3);
            this.Name = "BajaDocumento";
            this.Text = "BajaDocumento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelFecha2;
        private System.Windows.Forms.Label LabelTipo2;
        private System.Windows.Forms.Label LabelNombre2;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.TextBox CuadroNumeroFoja;
        private System.Windows.Forms.CheckBox CheckEnExpediente;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.TextBox CuadroDetalle;
        private System.Windows.Forms.Label LabelDetalle;
        private System.Windows.Forms.Label LabelFecha;
        private System.Windows.Forms.Label LabelExpediente;
        private System.Windows.Forms.Label LabelFoja;
        private System.Windows.Forms.Label LabelTipoDocumento;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.Label LabelFoja2;
        private System.Windows.Forms.ComboBox ComboBoxResultados;
        private System.Windows.Forms.Button BotonMostrarTodos;
    }
}