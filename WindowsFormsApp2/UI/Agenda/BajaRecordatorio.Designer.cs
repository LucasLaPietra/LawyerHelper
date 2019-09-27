namespace LawyerHelper.UI.Agenda
{
    partial class BajaRecordatorio
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
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.LabelDescripcion = new System.Windows.Forms.Label();
            this.BotonDarDeBaja = new System.Windows.Forms.Button();
            this.checkedListBoxRecordatorios = new System.Windows.Forms.CheckedListBox();
            this.LabelListaRecordatorios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(277, 459);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(95, 24);
            this.BotonCancelar.TabIndex = 40;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(79, 289);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescripcion.Size = new System.Drawing.Size(293, 136);
            this.textBoxDescripcion.TabIndex = 38;
            // 
            // LabelDescripcion
            // 
            this.LabelDescripcion.AutoSize = true;
            this.LabelDescripcion.Location = new System.Drawing.Point(7, 289);
            this.LabelDescripcion.Name = "LabelDescripcion";
            this.LabelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.LabelDescripcion.TabIndex = 36;
            this.LabelDescripcion.Text = "Descripcion:";
            // 
            // BotonDarDeBaja
            // 
            this.BotonDarDeBaja.Location = new System.Drawing.Point(12, 459);
            this.BotonDarDeBaja.Name = "BotonDarDeBaja";
            this.BotonDarDeBaja.Size = new System.Drawing.Size(138, 25);
            this.BotonDarDeBaja.TabIndex = 50;
            this.BotonDarDeBaja.Text = "Dar de baja";
            this.BotonDarDeBaja.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxRecordatorios
            // 
            this.checkedListBoxRecordatorios.FormattingEnabled = true;
            this.checkedListBoxRecordatorios.Location = new System.Drawing.Point(12, 52);
            this.checkedListBoxRecordatorios.Name = "checkedListBoxRecordatorios";
            this.checkedListBoxRecordatorios.Size = new System.Drawing.Size(348, 214);
            this.checkedListBoxRecordatorios.TabIndex = 155;
            // 
            // LabelListaRecordatorios
            // 
            this.LabelListaRecordatorios.AutoSize = true;
            this.LabelListaRecordatorios.Location = new System.Drawing.Point(12, 24);
            this.LabelListaRecordatorios.Name = "LabelListaRecordatorios";
            this.LabelListaRecordatorios.Size = new System.Drawing.Size(111, 13);
            this.LabelListaRecordatorios.TabIndex = 156;
            this.LabelListaRecordatorios.Text = "Lista de recordatorios:";
            // 
            // BajaRecordatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 496);
            this.Controls.Add(this.LabelListaRecordatorios);
            this.Controls.Add(this.checkedListBoxRecordatorios);
            this.Controls.Add(this.BotonDarDeBaja);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.LabelDescripcion);
            this.Name = "BajaRecordatorio";
            this.Text = "BajaRecordatorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label LabelDescripcion;
        private System.Windows.Forms.Button BotonDarDeBaja;
        private System.Windows.Forms.CheckedListBox checkedListBoxRecordatorios;
        private System.Windows.Forms.Label LabelListaRecordatorios;
    }
}