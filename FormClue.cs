using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Clue
{
    public partial class FormClue : Form
    {
        public FormClue()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panNavegacion.Height = btnSospechosos.Height;
            panNavegacion.Top = btnSospechosos.Top;
            panNavegacion.Left = btnSospechosos.Left;
            btnSospechosos.BackColor = Color.FromArgb(46, 51, 73);

            IniciarNuevoJuego();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void btnNuevoJuego_Click(object sender, EventArgs e)
        {
            panNavegacion.Height = btnNuevoJuego.Height;
            panNavegacion.Top = btnNuevoJuego.Top;
            panNavegacion.Left = btnNuevoJuego.Left;
            btnNuevoJuego.BackColor = Color.FromArgb(46, 51, 73);
            this.pnlPantalla.Controls.Clear();

            IniciarNuevoJuego();
        }

        private void IniciarNuevoJuego()
        {
            Program.controladorJuego = new ClueController();
            FormInstrucciones instrucciones = new FormInstrucciones { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.pnlPantalla.Controls.Add(instrucciones);
            instrucciones.Show();
        }

        private void btnSospechosos_Click(object sender, EventArgs e)
        {
            panNavegacion.Height = btnSospechosos.Height;
            panNavegacion.Top = btnSospechosos.Top;
            panNavegacion.Left = btnSospechosos.Left;
            btnSospechosos.BackColor = Color.FromArgb(46, 51, 73);
            this.pnlPantalla.Controls.Clear();

            FormSospechosos sospechosos = new FormSospechosos { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.pnlPantalla.Controls.Add(sospechosos);
            sospechosos.Show();
        }

        private void btnLugares_Click(object sender, EventArgs e)
        {
            panNavegacion.Height = btnLugares.Height;
            panNavegacion.Top = btnLugares.Top;
            panNavegacion.Left = btnLugares.Left;
            btnLugares.BackColor = Color.FromArgb(46, 51, 73);
            this.pnlPantalla.Controls.Clear();

            FormLugares lugares = new FormLugares { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.pnlPantalla.Controls.Add(lugares);
            lugares.Show();
        }

        private void btnArmas_Click(object sender, EventArgs e)
        {
            panNavegacion.Height = btnArmas.Height;
            panNavegacion.Top = btnArmas.Top;
            panNavegacion.Left = btnArmas.Left;
            btnArmas.BackColor = Color.FromArgb(46, 51, 73);
            this.pnlPantalla.Controls.Clear();

            FormArmas armas = new FormArmas { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.pnlPantalla.Controls.Add(armas);
            armas.Show();
        }

        private void btnAcusar_Click(object sender, EventArgs e)
        {
            panNavegacion.Height = btnAcusar.Height;
            panNavegacion.Top = btnAcusar.Top;
            panNavegacion.Left = btnAcusar.Left;
            btnAcusar.BackColor = Color.FromArgb(46, 51, 73);
            this.pnlPantalla.Controls.Clear();

            FormAcusar acusar = new FormAcusar { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.pnlPantalla.Controls.Add(acusar);
            acusar.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnOpcion_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
