namespace WindowsFormsApp2
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.BotonAgenda = new System.Windows.Forms.Button();
            this.BotonPagos = new System.Windows.Forms.Button();
            this.BotonCobros = new System.Windows.Forms.Button();
            this.BotonJuicios = new System.Windows.Forms.Button();
            this.BotonPersonas = new System.Windows.Forms.Button();
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.LabelCreditos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BotonAgenda
            // 
            this.BotonAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAgenda.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAgenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(208)))));
            this.BotonAgenda.Image = ((System.Drawing.Image)(resources.GetObject("BotonAgenda.Image")));
            this.BotonAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonAgenda.Location = new System.Drawing.Point(-1, 270);
            this.BotonAgenda.Name = "BotonAgenda";
            this.BotonAgenda.Size = new System.Drawing.Size(210, 75);
            this.BotonAgenda.TabIndex = 2;
            this.BotonAgenda.Text = "Agenda";
            this.BotonAgenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonAgenda.UseVisualStyleBackColor = true;
            this.BotonAgenda.Click += new System.EventHandler(this.BotonAgenda_Click);
            // 
            // BotonPagos
            // 
            this.BotonPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonPagos.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(208)))));
            this.BotonPagos.Image = ((System.Drawing.Image)(resources.GetObject("BotonPagos.Image")));
            this.BotonPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonPagos.Location = new System.Drawing.Point(-1, 345);
            this.BotonPagos.Name = "BotonPagos";
            this.BotonPagos.Size = new System.Drawing.Size(210, 75);
            this.BotonPagos.TabIndex = 3;
            this.BotonPagos.Text = "Pagos";
            this.BotonPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonPagos.UseVisualStyleBackColor = true;
            this.BotonPagos.Click += new System.EventHandler(this.BotonPagos_Click);
            // 
            // BotonCobros
            // 
            this.BotonCobros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCobros.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCobros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(208)))));
            this.BotonCobros.Image = ((System.Drawing.Image)(resources.GetObject("BotonCobros.Image")));
            this.BotonCobros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonCobros.Location = new System.Drawing.Point(-1, 420);
            this.BotonCobros.Name = "BotonCobros";
            this.BotonCobros.Size = new System.Drawing.Size(210, 75);
            this.BotonCobros.TabIndex = 4;
            this.BotonCobros.Text = "Cobros";
            this.BotonCobros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonCobros.UseVisualStyleBackColor = true;
            this.BotonCobros.Click += new System.EventHandler(this.BotonCobros_Click);
            // 
            // BotonJuicios
            // 
            this.BotonJuicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonJuicios.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonJuicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(208)))));
            this.BotonJuicios.Image = ((System.Drawing.Image)(resources.GetObject("BotonJuicios.Image")));
            this.BotonJuicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonJuicios.Location = new System.Drawing.Point(-1, 195);
            this.BotonJuicios.Name = "BotonJuicios";
            this.BotonJuicios.Size = new System.Drawing.Size(210, 75);
            this.BotonJuicios.TabIndex = 1;
            this.BotonJuicios.Text = "Juicios";
            this.BotonJuicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonJuicios.UseVisualStyleBackColor = true;
            this.BotonJuicios.Click += new System.EventHandler(this.BotonJuicios_Click);
            // 
            // BotonPersonas
            // 
            this.BotonPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonPersonas.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPersonas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(208)))));
            this.BotonPersonas.Image = ((System.Drawing.Image)(resources.GetObject("BotonPersonas.Image")));
            this.BotonPersonas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonPersonas.Location = new System.Drawing.Point(-1, 120);
            this.BotonPersonas.Name = "BotonPersonas";
            this.BotonPersonas.Size = new System.Drawing.Size(210, 75);
            this.BotonPersonas.TabIndex = 0;
            this.BotonPersonas.Text = "Personas";
            this.BotonPersonas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonPersonas.UseVisualStyleBackColor = true;
            this.BotonPersonas.Click += new System.EventHandler(this.BotonPersonas_Click);
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Font = new System.Drawing.Font("Roboto Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(208)))));
            this.LabelTitulo.Location = new System.Drawing.Point(8, 55);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(193, 33);
            this.LabelTitulo.TabIndex = 5;
            this.LabelTitulo.Text = "LawyerHelper";
            // 
            // LabelCreditos
            // 
            this.LabelCreditos.AutoSize = true;
            this.LabelCreditos.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCreditos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(208)))));
            this.LabelCreditos.Location = new System.Drawing.Point(257, 539);
            this.LabelCreditos.Name = "LabelCreditos";
            this.LabelCreditos.Size = new System.Drawing.Size(215, 13);
            this.LabelCreditos.TabIndex = 6;
            this.LabelCreditos.Text = "Alba, Chrispens, La Pietra, Retamar - 2019";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(238, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 450);
            this.panel1.TabIndex = 7;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelCreditos);
            this.Controls.Add(this.LabelTitulo);
            this.Controls.Add(this.BotonCobros);
            this.Controls.Add(this.BotonPagos);
            this.Controls.Add(this.BotonAgenda);
            this.Controls.Add(this.BotonJuicios);
            this.Controls.Add(this.BotonPersonas);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonPersonas;
        private System.Windows.Forms.Button BotonJuicios;
        private System.Windows.Forms.Button BotonAgenda;
        private System.Windows.Forms.Button BotonPagos;
        private System.Windows.Forms.Button BotonCobros;
        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.Label LabelCreditos;
        private System.Windows.Forms.Panel panel1;
    }
}

