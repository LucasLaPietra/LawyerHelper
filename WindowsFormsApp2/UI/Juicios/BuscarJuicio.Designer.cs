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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.BotonMostrarTodos = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonVerJuicio = new System.Windows.Forms.Button();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.CuadroParametro = new System.Windows.Forms.TextBox();
            this.labelCuadroParametro = new System.Windows.Forms.Label();
            this.comboBoxParametro = new System.Windows.Forms.ComboBox();
            this.LabelComboBoxParametro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 202);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(440, 184);
            this.checkedListBox1.TabIndex = 99;
            // 
            // BotonMostrarTodos
            // 
            this.BotonMostrarTodos.Location = new System.Drawing.Point(236, 150);
            this.BotonMostrarTodos.Name = "BotonMostrarTodos";
            this.BotonMostrarTodos.Size = new System.Drawing.Size(163, 28);
            this.BotonMostrarTodos.TabIndex = 98;
            this.BotonMostrarTodos.Text = "Ver todos los juicios";
            this.BotonMostrarTodos.UseVisualStyleBackColor = true;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(357, 445);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(95, 24);
            this.BotonCancelar.TabIndex = 97;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            // 
            // BotonVerJuicio
            // 
            this.BotonVerJuicio.Location = new System.Drawing.Point(12, 443);
            this.BotonVerJuicio.Name = "BotonVerJuicio";
            this.BotonVerJuicio.Size = new System.Drawing.Size(163, 28);
            this.BotonVerJuicio.TabIndex = 96;
            this.BotonVerJuicio.Text = "Ver Juicio";
            this.BotonVerJuicio.UseVisualStyleBackColor = true;
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Location = new System.Drawing.Point(236, 103);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(163, 28);
            this.BotonBuscar.TabIndex = 95;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            // 
            // CuadroParametro
            // 
            this.CuadroParametro.Location = new System.Drawing.Point(221, 68);
            this.CuadroParametro.Name = "CuadroParametro";
            this.CuadroParametro.Size = new System.Drawing.Size(202, 20);
            this.CuadroParametro.TabIndex = 94;
            // 
            // labelCuadroParametro
            // 
            this.labelCuadroParametro.AutoSize = true;
            this.labelCuadroParametro.Location = new System.Drawing.Point(103, 71);
            this.labelCuadroParametro.Name = "labelCuadroParametro";
            this.labelCuadroParametro.Size = new System.Drawing.Size(95, 13);
            this.labelCuadroParametro.TabIndex = 93;
            this.labelCuadroParametro.Text = "Ingresar parametro";
            // 
            // comboBoxParametro
            // 
            this.comboBoxParametro.FormattingEnabled = true;
            this.comboBoxParametro.Location = new System.Drawing.Point(221, 16);
            this.comboBoxParametro.Name = "comboBoxParametro";
            this.comboBoxParametro.Size = new System.Drawing.Size(202, 21);
            this.comboBoxParametro.TabIndex = 92;
            // 
            // LabelComboBoxParametro
            // 
            this.LabelComboBoxParametro.AutoSize = true;
            this.LabelComboBoxParametro.Location = new System.Drawing.Point(34, 16);
            this.LabelComboBoxParametro.Name = "LabelComboBoxParametro";
            this.LabelComboBoxParametro.Size = new System.Drawing.Size(181, 13);
            this.LabelComboBoxParametro.TabIndex = 91;
            this.LabelComboBoxParametro.Text = "Seleccionar parametro de busqueda:";
            // 
            // BuscarJuicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 496);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.BotonMostrarTodos);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonVerJuicio);
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

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button BotonMostrarTodos;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonVerJuicio;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.TextBox CuadroParametro;
        private System.Windows.Forms.Label labelCuadroParametro;
        private System.Windows.Forms.ComboBox comboBoxParametro;
        private System.Windows.Forms.Label LabelComboBoxParametro;
    }
}