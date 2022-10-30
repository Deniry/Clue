namespace Clue
{
    partial class FormClue
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClue));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAcusar = new System.Windows.Forms.Button();
            this.btnNuevoJuego = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnArmas = new System.Windows.Forms.Button();
            this.btnLugares = new System.Windows.Forms.Button();
            this.btnSospechosos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panNavegacion = new System.Windows.Forms.Panel();
            this.pnlPantalla = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnAcusar);
            this.panel1.Controls.Add(this.btnNuevoJuego);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnArmas);
            this.panel1.Controls.Add(this.btnLugares);
            this.panel1.Controls.Add(this.btnSospechosos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 600);
            this.panel1.TabIndex = 0;
            // 
            // btnAcusar
            // 
            this.btnAcusar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcusar.FlatAppearance.BorderSize = 0;
            this.btnAcusar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcusar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcusar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAcusar.Image = global::Clue.Properties.Resources.busqueda;
            this.btnAcusar.Location = new System.Drawing.Point(0, 360);
            this.btnAcusar.Name = "btnAcusar";
            this.btnAcusar.Size = new System.Drawing.Size(200, 60);
            this.btnAcusar.TabIndex = 6;
            this.btnAcusar.Text = "Concluir  ";
            this.btnAcusar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAcusar.UseVisualStyleBackColor = true;
            this.btnAcusar.Click += new System.EventHandler(this.btnAcusar_Click);
            this.btnAcusar.Leave += new System.EventHandler(this.BtnOpcion_Leave);
            // 
            // btnNuevoJuego
            // 
            this.btnNuevoJuego.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNuevoJuego.FlatAppearance.BorderSize = 0;
            this.btnNuevoJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoJuego.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoJuego.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNuevoJuego.Image = global::Clue.Properties.Resources.agregar_documento;
            this.btnNuevoJuego.Location = new System.Drawing.Point(0, 480);
            this.btnNuevoJuego.Name = "btnNuevoJuego";
            this.btnNuevoJuego.Size = new System.Drawing.Size(200, 60);
            this.btnNuevoJuego.TabIndex = 5;
            this.btnNuevoJuego.Text = "Nuevo Juego";
            this.btnNuevoJuego.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevoJuego.UseVisualStyleBackColor = true;
            this.btnNuevoJuego.Click += new System.EventHandler(this.btnNuevoJuego_Click);
            this.btnNuevoJuego.Leave += new System.EventHandler(this.BtnOpcion_Leave);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSalir.Image = global::Clue.Properties.Resources.salir_alt;
            this.btnSalir.Location = new System.Drawing.Point(0, 540);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 60);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir                 ";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            this.btnSalir.Leave += new System.EventHandler(this.BtnOpcion_Leave);
            // 
            // btnArmas
            // 
            this.btnArmas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArmas.FlatAppearance.BorderSize = 0;
            this.btnArmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArmas.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArmas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnArmas.Image = global::Clue.Properties.Resources.arco_de_flecha;
            this.btnArmas.Location = new System.Drawing.Point(0, 300);
            this.btnArmas.Name = "btnArmas";
            this.btnArmas.Size = new System.Drawing.Size(200, 60);
            this.btnArmas.TabIndex = 3;
            this.btnArmas.Text = "Armas      ";
            this.btnArmas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnArmas.UseVisualStyleBackColor = true;
            this.btnArmas.Click += new System.EventHandler(this.btnArmas_Click);
            this.btnArmas.Leave += new System.EventHandler(this.BtnOpcion_Leave);
            // 
            // btnLugares
            // 
            this.btnLugares.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLugares.FlatAppearance.BorderSize = 0;
            this.btnLugares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLugares.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLugares.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLugares.Image = global::Clue.Properties.Resources.marcador;
            this.btnLugares.Location = new System.Drawing.Point(0, 240);
            this.btnLugares.Name = "btnLugares";
            this.btnLugares.Size = new System.Drawing.Size(200, 60);
            this.btnLugares.TabIndex = 2;
            this.btnLugares.Text = "Lugares   ";
            this.btnLugares.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLugares.UseVisualStyleBackColor = true;
            this.btnLugares.Click += new System.EventHandler(this.btnLugares_Click);
            this.btnLugares.Leave += new System.EventHandler(this.BtnOpcion_Leave);
            // 
            // btnSospechosos
            // 
            this.btnSospechosos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSospechosos.FlatAppearance.BorderSize = 0;
            this.btnSospechosos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSospechosos.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSospechosos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSospechosos.Image = global::Clue.Properties.Resources.correr;
            this.btnSospechosos.Location = new System.Drawing.Point(0, 180);
            this.btnSospechosos.Name = "btnSospechosos";
            this.btnSospechosos.Size = new System.Drawing.Size(200, 60);
            this.btnSospechosos.TabIndex = 1;
            this.btnSospechosos.Text = "Sospechosos";
            this.btnSospechosos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSospechosos.UseVisualStyleBackColor = true;
            this.btnSospechosos.Click += new System.EventHandler(this.btnSospechosos_Click);
            this.btnSospechosos.Leave += new System.EventHandler(this.BtnOpcion_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 180);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(44, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Segundo Parcial";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(23, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deniry Santana";
            // 
            // panNavegacion
            // 
            this.panNavegacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panNavegacion.Location = new System.Drawing.Point(0, 200);
            this.panNavegacion.Name = "panNavegacion";
            this.panNavegacion.Size = new System.Drawing.Size(3, 100);
            this.panNavegacion.TabIndex = 1;
            // 
            // pnlPantalla
            // 
            this.pnlPantalla.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPantalla.Location = new System.Drawing.Point(200, 0);
            this.pnlPantalla.Name = "pnlPantalla";
            this.pnlPantalla.Size = new System.Drawing.Size(750, 600);
            this.pnlPantalla.TabIndex = 2;
            // 
            // FormClue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.pnlPantalla);
            this.Controls.Add(this.panNavegacion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnArmas;
        private System.Windows.Forms.Button btnLugares;
        private System.Windows.Forms.Button btnSospechosos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panNavegacion;
        private System.Windows.Forms.Panel pnlPantalla;
        private System.Windows.Forms.Button btnAcusar;
        private System.Windows.Forms.Button btnNuevoJuego;
    }
}