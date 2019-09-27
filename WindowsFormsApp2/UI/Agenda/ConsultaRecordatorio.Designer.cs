namespace LawyerHelper.UI.Agenda
{
    partial class ConsultaRecordatorio
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
            this.LabelListaRecordatorios = new System.Windows.Forms.Label();
            this.checkedListBoxRecordatorio = new System.Windows.Forms.CheckedListBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.LabelDescripcion = new System.Windows.Forms.Label();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelListaRecordatorios
            // 
            this.LabelListaRecordatorios.AutoSize = true;
            this.LabelListaRecordatorios.Location = new System.Drawing.Point(16, 8);
            this.LabelListaRecordatorios.Name = "LabelListaRecordatorios";
            this.LabelListaRecordatorios.Size = new System.Drawing.Size(111, 13);
            this.LabelListaRecordatorios.TabIndex = 158;
            this.LabelListaRecordatorios.Text = "Lista de recordatorios:";
            // 
            // checkedListBoxRecordatorio
            // 
            this.checkedListBoxRecordatorio.FormattingEnabled = true;
            this.checkedListBoxRecordatorio.Location = new System.Drawing.Point(16, 36);
            this.checkedListBoxRecordatorio.Name = "checkedListBoxRecordatorio";
            this.checkedListBoxRecordatorio.Size = new System.Drawing.Size(348, 214);
            this.checkedListBoxRecordatorio.TabIndex = 157;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(71, 270);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescripcion.Size = new System.Drawing.Size(293, 136);
            this.textBoxDescripcion.TabIndex = 160;
            // 
            // LabelDescripcion
            // 
            this.LabelDescripcion.AutoSize = true;
            this.LabelDescripcion.Location = new System.Drawing.Point(-1, 270);
            this.LabelDescripcion.Name = "LabelDescripcion";
            this.LabelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.LabelDescripcion.TabIndex = 159;
            this.LabelDescripcion.Text = "Descripcion:";
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(277, 460);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(95, 24);
            this.BotonCancelar.TabIndex = 161;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            // 
            // ConsultaRecordatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 496);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.LabelDescripcion);
            this.Controls.Add(this.LabelListaRecordatorios);
            this.Controls.Add(this.checkedListBoxRecordatorio);
            this.Name = "ConsultaRecordatorio";
            this.Text = "ConsultaRecordatorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelListaRecordatorios;
        private System.Windows.Forms.CheckedListBox checkedListBoxRecordatorio;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label LabelDescripcion;
        private System.Windows.Forms.Button BotonCancelar;
    }
}