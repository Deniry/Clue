namespace Clue
{
    partial class FormLugares
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
            this.imgTaller = new System.Windows.Forms.PictureBox();
            this.imgEnfermeria = new System.Windows.Forms.PictureBox();
            this.imgCabina = new System.Windows.Forms.PictureBox();
            this.imgCarga = new System.Windows.Forms.PictureBox();
            this.imgAlojamiento = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTaller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEnfermeria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCabina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlojamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // imgTaller
            // 
            this.imgTaller.Image = global::Clue.Properties.Resources.Taller;
            this.imgTaller.Location = new System.Drawing.Point(384, 404);
            this.imgTaller.Name = "imgTaller";
            this.imgTaller.Size = new System.Drawing.Size(351, 184);
            this.imgTaller.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTaller.TabIndex = 4;
            this.imgTaller.TabStop = false;
            this.imgTaller.Click += new System.EventHandler(this.imgTaller_Click);
            // 
            // imgEnfermeria
            // 
            this.imgEnfermeria.Image = global::Clue.Properties.Resources.Enfermeria;
            this.imgEnfermeria.Location = new System.Drawing.Point(12, 404);
            this.imgEnfermeria.Name = "imgEnfermeria";
            this.imgEnfermeria.Size = new System.Drawing.Size(351, 184);
            this.imgEnfermeria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgEnfermeria.TabIndex = 3;
            this.imgEnfermeria.TabStop = false;
            this.imgEnfermeria.Click += new System.EventHandler(this.imgEnfermeria_Click);
            // 
            // imgCabina
            // 
            this.imgCabina.Image = global::Clue.Properties.Resources.Cabina;
            this.imgCabina.Location = new System.Drawing.Point(384, 12);
            this.imgCabina.Name = "imgCabina";
            this.imgCabina.Size = new System.Drawing.Size(354, 184);
            this.imgCabina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCabina.TabIndex = 2;
            this.imgCabina.TabStop = false;
            this.imgCabina.Click += new System.EventHandler(this.imgCabina_Click);
            // 
            // imgCarga
            // 
            this.imgCarga.Image = global::Clue.Properties.Resources.Carga;
            this.imgCarga.Location = new System.Drawing.Point(211, 214);
            this.imgCarga.Name = "imgCarga";
            this.imgCarga.Size = new System.Drawing.Size(355, 184);
            this.imgCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCarga.TabIndex = 1;
            this.imgCarga.TabStop = false;
            this.imgCarga.Click += new System.EventHandler(this.imgCarga_Click);
            // 
            // imgAlojamiento
            // 
            this.imgAlojamiento.Image = global::Clue.Properties.Resources.Alojamiento;
            this.imgAlojamiento.Location = new System.Drawing.Point(12, 12);
            this.imgAlojamiento.Name = "imgAlojamiento";
            this.imgAlojamiento.Size = new System.Drawing.Size(355, 184);
            this.imgAlojamiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAlojamiento.TabIndex = 0;
            this.imgAlojamiento.TabStop = false;
            this.imgAlojamiento.Click += new System.EventHandler(this.imgAlojamiento_Click);
            // 
            // FormLugares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(750, 600);
            this.Controls.Add(this.imgTaller);
            this.Controls.Add(this.imgEnfermeria);
            this.Controls.Add(this.imgCabina);
            this.Controls.Add(this.imgCarga);
            this.Controls.Add(this.imgAlojamiento);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLugares";
            this.Text = "FormSospechosos";
            ((System.ComponentModel.ISupportInitialize)(this.imgTaller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEnfermeria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCabina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlojamiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgAlojamiento;
        private System.Windows.Forms.PictureBox imgCarga;
        private System.Windows.Forms.PictureBox imgCabina;
        private System.Windows.Forms.PictureBox imgEnfermeria;
        private System.Windows.Forms.PictureBox imgTaller;
    }
}