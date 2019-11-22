﻿namespace LawyerHelper.UI.Personas
{
    partial class MenuPersonasUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BotonConsulta = new System.Windows.Forms.Button();
            this.BotonModificacion = new System.Windows.Forms.Button();
            this.BotonBaja = new System.Windows.Forms.Button();
            this.BotonAlta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonConsulta
            // 
            this.BotonConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BotonConsulta.ForeColor = System.Drawing.Color.Black;
            this.BotonConsulta.Location = new System.Drawing.Point(0, 150);
            this.BotonConsulta.Name = "BotonConsulta";
            this.BotonConsulta.Size = new System.Drawing.Size(230, 50);
            this.BotonConsulta.TabIndex = 11;
            this.BotonConsulta.Text = "Consulta";
            this.BotonConsulta.UseVisualStyleBackColor = true;
            this.BotonConsulta.Click += new System.EventHandler(this.BotonConsulta_Click);
            // 
            // BotonModificacion
            // 
            this.BotonModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BotonModificacion.ForeColor = System.Drawing.Color.Black;
            this.BotonModificacion.Location = new System.Drawing.Point(0, 100);
            this.BotonModificacion.Name = "BotonModificacion";
            this.BotonModificacion.Size = new System.Drawing.Size(230, 50);
            this.BotonModificacion.TabIndex = 10;
            this.BotonModificacion.Text = "Modificacion";
            this.BotonModificacion.UseVisualStyleBackColor = true;
            this.BotonModificacion.Click += new System.EventHandler(this.BotonModificacion_Click);
            // 
            // BotonBaja
            // 
            this.BotonBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BotonBaja.ForeColor = System.Drawing.Color.Black;
            this.BotonBaja.Location = new System.Drawing.Point(0, 50);
            this.BotonBaja.Name = "BotonBaja";
            this.BotonBaja.Size = new System.Drawing.Size(230, 50);
            this.BotonBaja.TabIndex = 9;
            this.BotonBaja.Text = "Baja";
            this.BotonBaja.UseVisualStyleBackColor = true;
            this.BotonBaja.Click += new System.EventHandler(this.BotonBaja_Click);
            // 
            // BotonAlta
            // 
            this.BotonAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BotonAlta.ForeColor = System.Drawing.Color.Black;
            this.BotonAlta.Location = new System.Drawing.Point(0, 0);
            this.BotonAlta.Name = "BotonAlta";
            this.BotonAlta.Size = new System.Drawing.Size(230, 50);
            this.BotonAlta.TabIndex = 8;
            this.BotonAlta.Text = "Alta";
            this.BotonAlta.UseVisualStyleBackColor = true;
            this.BotonAlta.Click += new System.EventHandler(this.BotonAlta_Click);
            // 
            // MenuPersonasUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.BotonConsulta);
            this.Controls.Add(this.BotonModificacion);
            this.Controls.Add(this.BotonBaja);
            this.Controls.Add(this.BotonAlta);
            this.Name = "MenuPersonasUC";
            this.Size = new System.Drawing.Size(230, 550);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonConsulta;
        private System.Windows.Forms.Button BotonModificacion;
        private System.Windows.Forms.Button BotonBaja;
        private System.Windows.Forms.Button BotonAlta;
    }
}
