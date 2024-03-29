﻿namespace LawyerHelper.UI.Documentos
{
    partial class ModificarDocumento
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
            this.TimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.CuadroNumeroFoja = new System.Windows.Forms.TextBox();
            this.CuadroNombreDocumento = new System.Windows.Forms.TextBox();
            this.CheckEnExpediente = new System.Windows.Forms.CheckBox();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.CuadroDetalle = new System.Windows.Forms.TextBox();
            this.CuadroTipo = new System.Windows.Forms.TextBox();
            this.ComboBoxResultados = new System.Windows.Forms.ComboBox();
            this.BotonMostrarTodos = new System.Windows.Forms.Button();
            this.CheckBoxEliminados = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TimePickerFecha
            // 
            this.TimePickerFecha.Location = new System.Drawing.Point(149, 291);
            this.TimePickerFecha.Name = "TimePickerFecha";
            this.TimePickerFecha.Size = new System.Drawing.Size(276, 20);
            this.TimePickerFecha.TabIndex = 38;
            // 
            // CuadroNumeroFoja
            // 
            this.CuadroNumeroFoja.Location = new System.Drawing.Point(108, 25);
            this.CuadroNumeroFoja.Name = "CuadroNumeroFoja";
            this.CuadroNumeroFoja.Size = new System.Drawing.Size(150, 20);
            this.CuadroNumeroFoja.TabIndex = 35;
            // 
            // CuadroNombreDocumento
            // 
            this.CuadroNombreDocumento.Location = new System.Drawing.Point(148, 139);
            this.CuadroNombreDocumento.Name = "CuadroNombreDocumento";
            this.CuadroNombreDocumento.Size = new System.Drawing.Size(277, 20);
            this.CuadroNombreDocumento.TabIndex = 34;
            // 
            // CheckEnExpediente
            // 
            this.CheckEnExpediente.AutoSize = true;
            this.CheckEnExpediente.Location = new System.Drawing.Point(148, 247);
            this.CheckEnExpediente.Name = "CheckEnExpediente";
            this.CheckEnExpediente.Size = new System.Drawing.Size(35, 17);
            this.CheckEnExpediente.TabIndex = 32;
            this.CheckEnExpediente.Text = "Si";
            this.CheckEnExpediente.UseVisualStyleBackColor = true;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(275, 482);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(95, 24);
            this.BotonCancelar.TabIndex = 30;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Location = new System.Drawing.Point(63, 482);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(95, 24);
            this.BotonAceptar.TabIndex = 29;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Detalle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "En expediente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Numero de foja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tipo de documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre del documento";
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Location = new System.Drawing.Point(264, 24);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(75, 23);
            this.BotonBuscar.TabIndex = 39;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // CuadroDetalle
            // 
            this.CuadroDetalle.Location = new System.Drawing.Point(148, 338);
            this.CuadroDetalle.Multiline = true;
            this.CuadroDetalle.Name = "CuadroDetalle";
            this.CuadroDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CuadroDetalle.Size = new System.Drawing.Size(304, 108);
            this.CuadroDetalle.TabIndex = 172;
            // 
            // CuadroTipo
            // 
            this.CuadroTipo.Location = new System.Drawing.Point(148, 196);
            this.CuadroTipo.Name = "CuadroTipo";
            this.CuadroTipo.Size = new System.Drawing.Size(277, 20);
            this.CuadroTipo.TabIndex = 225;
            // 
            // ComboBoxResultados
            // 
            this.ComboBoxResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxResultados.FormattingEnabled = true;
            this.ComboBoxResultados.Location = new System.Drawing.Point(17, 101);
            this.ComboBoxResultados.Name = "ComboBoxResultados";
            this.ComboBoxResultados.Size = new System.Drawing.Size(435, 21);
            this.ComboBoxResultados.TabIndex = 227;
            this.ComboBoxResultados.SelectedIndexChanged += new System.EventHandler(this.ComboBoxResultados_SelectedIndexChanged);
            // 
            // BotonMostrarTodos
            // 
            this.BotonMostrarTodos.Location = new System.Drawing.Point(13, 60);
            this.BotonMostrarTodos.Name = "BotonMostrarTodos";
            this.BotonMostrarTodos.Size = new System.Drawing.Size(439, 30);
            this.BotonMostrarTodos.TabIndex = 226;
            this.BotonMostrarTodos.Text = "Mostrar todos los documentos";
            this.BotonMostrarTodos.UseVisualStyleBackColor = true;
            this.BotonMostrarTodos.Click += new System.EventHandler(this.BotonMostrarTodos_Click);
            // 
            // CheckBoxEliminados
            // 
            this.CheckBoxEliminados.AutoSize = true;
            this.CheckBoxEliminados.Location = new System.Drawing.Point(345, 27);
            this.CheckBoxEliminados.Name = "CheckBoxEliminados";
            this.CheckBoxEliminados.Size = new System.Drawing.Size(111, 17);
            this.CheckBoxEliminados.TabIndex = 228;
            this.CheckBoxEliminados.Text = "Buscar eliminados";
            this.CheckBoxEliminados.UseVisualStyleBackColor = true;
            // 
            // ModificarDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 527);
            this.Controls.Add(this.CheckBoxEliminados);
            this.Controls.Add(this.ComboBoxResultados);
            this.Controls.Add(this.BotonMostrarTodos);
            this.Controls.Add(this.CuadroTipo);
            this.Controls.Add(this.CuadroDetalle);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.TimePickerFecha);
            this.Controls.Add(this.CuadroNumeroFoja);
            this.Controls.Add(this.CuadroNombreDocumento);
            this.Controls.Add(this.CheckEnExpediente);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificarDocumento";
            this.Text = "ModificarDocumento";
            this.Load += new System.EventHandler(this.ModificarDocumento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker TimePickerFecha;
        private System.Windows.Forms.TextBox CuadroNumeroFoja;
        private System.Windows.Forms.TextBox CuadroNombreDocumento;
        private System.Windows.Forms.CheckBox CheckEnExpediente;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.TextBox CuadroDetalle;
        private System.Windows.Forms.TextBox CuadroTipo;
        private System.Windows.Forms.ComboBox ComboBoxResultados;
        private System.Windows.Forms.Button BotonMostrarTodos;
        private System.Windows.Forms.CheckBox CheckBoxEliminados;
    }
}