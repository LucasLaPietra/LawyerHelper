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
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonVerJuicio = new System.Windows.Forms.Button();
            this.ListaJuiciosEncontrados = new System.Windows.Forms.ListBox();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.CuadroParametro = new System.Windows.Forms.TextBox();
            this.labelCuadroParametro = new System.Windows.Forms.Label();
            this.comboBoxParametro = new System.Windows.Forms.ComboBox();
            this.LabelComboBoxParametro = new System.Windows.Forms.Label();
            this.BotonMostrarTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(424, 418);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(95, 24);
            this.BotonCancelar.TabIndex = 79;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            // 
            // BotonVerJuicio
            // 
            this.BotonVerJuicio.Location = new System.Drawing.Point(9, 414);
            this.BotonVerJuicio.Name = "BotonVerJuicio";
            this.BotonVerJuicio.Size = new System.Drawing.Size(163, 28);
            this.BotonVerJuicio.TabIndex = 78;
            this.BotonVerJuicio.Text = "Ver Juicio";
            this.BotonVerJuicio.UseVisualStyleBackColor = true;
            // 
            // ListaJuiciosEncontrados
            // 
            this.ListaJuiciosEncontrados.FormattingEnabled = true;
            this.ListaJuiciosEncontrados.Location = new System.Drawing.Point(37, 209);
            this.ListaJuiciosEncontrados.Name = "ListaJuiciosEncontrados";
            this.ListaJuiciosEncontrados.Size = new System.Drawing.Size(386, 186);
            this.ListaJuiciosEncontrados.TabIndex = 77;
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Location = new System.Drawing.Point(236, 122);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(163, 28);
            this.BotonBuscar.TabIndex = 76;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            // 
            // CuadroParametro
            // 
            this.CuadroParametro.Location = new System.Drawing.Point(221, 84);
            this.CuadroParametro.Name = "CuadroParametro";
            this.CuadroParametro.Size = new System.Drawing.Size(202, 20);
            this.CuadroParametro.TabIndex = 75;
            // 
            // labelCuadroParametro
            // 
            this.labelCuadroParametro.AutoSize = true;
            this.labelCuadroParametro.Location = new System.Drawing.Point(103, 87);
            this.labelCuadroParametro.Name = "labelCuadroParametro";
            this.labelCuadroParametro.Size = new System.Drawing.Size(95, 13);
            this.labelCuadroParametro.TabIndex = 74;
            this.labelCuadroParametro.Text = "Ingresar parametro";
            // 
            // comboBoxParametro
            // 
            this.comboBoxParametro.FormattingEnabled = true;
            this.comboBoxParametro.Location = new System.Drawing.Point(221, 32);
            this.comboBoxParametro.Name = "comboBoxParametro";
            this.comboBoxParametro.Size = new System.Drawing.Size(202, 21);
            this.comboBoxParametro.TabIndex = 73;
            // 
            // LabelComboBoxParametro
            // 
            this.LabelComboBoxParametro.AutoSize = true;
            this.LabelComboBoxParametro.Location = new System.Drawing.Point(34, 32);
            this.LabelComboBoxParametro.Name = "LabelComboBoxParametro";
            this.LabelComboBoxParametro.Size = new System.Drawing.Size(181, 13);
            this.LabelComboBoxParametro.TabIndex = 72;
            this.LabelComboBoxParametro.Text = "Seleccionar parametro de busqueda:";
            // 
            // BotonMostrarTodos
            // 
            this.BotonMostrarTodos.Location = new System.Drawing.Point(236, 162);
            this.BotonMostrarTodos.Name = "BotonMostrarTodos";
            this.BotonMostrarTodos.Size = new System.Drawing.Size(163, 28);
            this.BotonMostrarTodos.TabIndex = 80;
            this.BotonMostrarTodos.Text = "Ver todos los juicios";
            this.BotonMostrarTodos.UseVisualStyleBackColor = true;
            // 
            // BuscarJuicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.BotonMostrarTodos);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonVerJuicio);
            this.Controls.Add(this.ListaJuiciosEncontrados);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.CuadroParametro);
            this.Controls.Add(this.labelCuadroParametro);
            this.Controls.Add(this.comboBoxParametro);
            this.Controls.Add(this.LabelComboBoxParametro);
            this.Name = "BuscarJuicio";
            this.Text = "BuscarJuicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonVerJuicio;
        private System.Windows.Forms.ListBox ListaJuiciosEncontrados;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.TextBox CuadroParametro;
        private System.Windows.Forms.Label labelCuadroParametro;
        private System.Windows.Forms.ComboBox comboBoxParametro;
        private System.Windows.Forms.Label LabelComboBoxParametro;
        private System.Windows.Forms.Button BotonMostrarTodos;
    }
}