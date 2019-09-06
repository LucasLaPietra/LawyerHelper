namespace LawyerHelper.UI.Personas
{
    partial class ParametroDeBusqueda
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
            this.LabelComboBoxParametro = new System.Windows.Forms.Label();
            this.comboBoxParametro = new System.Windows.Forms.ComboBox();
            this.labelCuadroParametro = new System.Windows.Forms.Label();
            this.CuadroParametro = new System.Windows.Forms.TextBox();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.LabelTelefono = new System.Windows.Forms.Label();
            this.LabelFechaDeNacimiento = new System.Windows.Forms.Label();
            this.LabelDomicilio = new System.Windows.Forms.Label();
            this.LabelCUIL = new System.Windows.Forms.Label();
            this.LabelProfesion = new System.Windows.Forms.Label();
            this.LabelDNI = new System.Windows.Forms.Label();
            this.LabelApellido = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelComboBoxParametro
            // 
            this.LabelComboBoxParametro.AutoSize = true;
            this.LabelComboBoxParametro.Location = new System.Drawing.Point(20, 26);
            this.LabelComboBoxParametro.Name = "LabelComboBoxParametro";
            this.LabelComboBoxParametro.Size = new System.Drawing.Size(181, 13);
            this.LabelComboBoxParametro.TabIndex = 59;
            this.LabelComboBoxParametro.Text = "Seleccionar parametro de busqueda:";
            this.LabelComboBoxParametro.Click += new System.EventHandler(this.LabelApellido_Click);
            // 
            // comboBoxParametro
            // 
            this.comboBoxParametro.FormattingEnabled = true;
            this.comboBoxParametro.Location = new System.Drawing.Point(207, 26);
            this.comboBoxParametro.Name = "comboBoxParametro";
            this.comboBoxParametro.Size = new System.Drawing.Size(202, 21);
            this.comboBoxParametro.TabIndex = 60;
            // 
            // labelCuadroParametro
            // 
            this.labelCuadroParametro.AutoSize = true;
            this.labelCuadroParametro.Location = new System.Drawing.Point(89, 81);
            this.labelCuadroParametro.Name = "labelCuadroParametro";
            this.labelCuadroParametro.Size = new System.Drawing.Size(95, 13);
            this.labelCuadroParametro.TabIndex = 61;
            this.labelCuadroParametro.Text = "Ingresar parametro";
            this.labelCuadroParametro.Click += new System.EventHandler(this.Label1_Click);
            // 
            // CuadroParametro
            // 
            this.CuadroParametro.Location = new System.Drawing.Point(207, 78);
            this.CuadroParametro.Name = "CuadroParametro";
            this.CuadroParametro.Size = new System.Drawing.Size(202, 20);
            this.CuadroParametro.TabIndex = 62;
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Location = new System.Drawing.Point(222, 116);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(163, 28);
            this.BotonBuscar.TabIndex = 63;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(477, 255);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(95, 24);
            this.BotonCancelar.TabIndex = 69;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            // 
            // LabelTelefono
            // 
            this.LabelTelefono.AutoSize = true;
            this.LabelTelefono.Location = new System.Drawing.Point(3, 39);
            this.LabelTelefono.Name = "LabelTelefono";
            this.LabelTelefono.Size = new System.Drawing.Size(51, 17);
            this.LabelTelefono.TabIndex = 5;
            this.LabelTelefono.Text = "Teléfono:";
            this.LabelTelefono.UseCompatibleTextRendering = true;
            // 
            // LabelFechaDeNacimiento
            // 
            this.LabelFechaDeNacimiento.AutoSize = true;
            this.LabelFechaDeNacimiento.Location = new System.Drawing.Point(3, 56);
            this.LabelFechaDeNacimiento.Name = "LabelFechaDeNacimiento";
            this.LabelFechaDeNacimiento.Size = new System.Drawing.Size(111, 13);
            this.LabelFechaDeNacimiento.TabIndex = 4;
            this.LabelFechaDeNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // LabelDomicilio
            // 
            this.LabelDomicilio.AutoSize = true;
            this.LabelDomicilio.Location = new System.Drawing.Point(3, 26);
            this.LabelDomicilio.Name = "LabelDomicilio";
            this.LabelDomicilio.Size = new System.Drawing.Size(52, 13);
            this.LabelDomicilio.TabIndex = 3;
            this.LabelDomicilio.Text = "Domicilio:";
            // 
            // LabelCUIL
            // 
            this.LabelCUIL.AutoSize = true;
            this.LabelCUIL.Location = new System.Drawing.Point(3, 82);
            this.LabelCUIL.Name = "LabelCUIL";
            this.LabelCUIL.Size = new System.Drawing.Size(65, 13);
            this.LabelCUIL.TabIndex = 8;
            this.LabelCUIL.Text = "CUIL/CUID:";
            // 
            // LabelProfesion
            // 
            this.LabelProfesion.AutoSize = true;
            this.LabelProfesion.Location = new System.Drawing.Point(3, 69);
            this.LabelProfesion.Name = "LabelProfesion";
            this.LabelProfesion.Size = new System.Drawing.Size(54, 13);
            this.LabelProfesion.TabIndex = 7;
            this.LabelProfesion.Text = "Profesión:";
            // 
            // LabelDNI
            // 
            this.LabelDNI.AutoSize = true;
            this.LabelDNI.Location = new System.Drawing.Point(3, 13);
            this.LabelDNI.Name = "LabelDNI";
            this.LabelDNI.Size = new System.Drawing.Size(29, 13);
            this.LabelDNI.TabIndex = 2;
            this.LabelDNI.Text = "DNI:";
            // 
            // LabelApellido
            // 
            this.LabelApellido.AutoSize = true;
            this.LabelApellido.Location = new System.Drawing.Point(3, 0);
            this.LabelApellido.Name = "LabelApellido";
            this.LabelApellido.Size = new System.Drawing.Size(47, 13);
            this.LabelApellido.TabIndex = 1;
            this.LabelApellido.Text = "Apellido:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.LabelApellido, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelDNI, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LabelProfesion, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.LabelCUIL, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.LabelDomicilio, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LabelFechaDeNacimiento, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.LabelTelefono, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 159);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 21;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(439, 98);
            this.tableLayoutPanel1.TabIndex = 70;
            // 
            // ParametroDeBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 291);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.CuadroParametro);
            this.Controls.Add(this.labelCuadroParametro);
            this.Controls.Add(this.comboBoxParametro);
            this.Controls.Add(this.LabelComboBoxParametro);
            this.Name = "ParametroDeBusqueda";
            this.Text = "BuscarPersona";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelComboBoxParametro;
        private System.Windows.Forms.ComboBox comboBoxParametro;
        private System.Windows.Forms.Label labelCuadroParametro;
        private System.Windows.Forms.TextBox CuadroParametro;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Label LabelTelefono;
        private System.Windows.Forms.Label LabelFechaDeNacimiento;
        private System.Windows.Forms.Label LabelDomicilio;
        private System.Windows.Forms.Label LabelCUIL;
        private System.Windows.Forms.Label LabelProfesion;
        private System.Windows.Forms.Label LabelDNI;
        private System.Windows.Forms.Label LabelApellido;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}