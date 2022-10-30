using System.Linq;
using System.Windows.Forms;

namespace Clue
{
    public partial class FormSospechosos : Form
    {
        public FormSospechosos()
        {
            InitializeComponent();
        }

        private void imgFisher_Click(object sender, System.EventArgs e)
        {
            if (Program.controladorJuego.Pistas > 0)
            {
                MessageBox.Show(
                Program.controladorJuego.ObtenerPista(Program.controladorJuego.Personajes.Where(x => x.Nombre.Equals(Nombres.Fisher.ToString())).First().Lugar),
                $"Pista #{Program.controladorJuego.Pistas}");
                Program.controladorJuego.Pistas--;
            }
            else
            {
                MessageBox.Show("Ya no tienes pistas, ve a la pantalla de conclusión","Sin pistas :(");
            }
        }
        private void imgGrimm_Click(object sender, System.EventArgs e)
        {
            if (Program.controladorJuego.Pistas > 0)
            {
                MessageBox.Show(
                Program.controladorJuego.ObtenerPista(Program.controladorJuego.Personajes.Where(x => x.Nombre.Equals(Nombres.Grimm.ToString())).First().Lugar),
                $"Pista #{Program.controladorJuego.Pistas}");
                Program.controladorJuego.Pistas--;
            }
            else
            {
                MessageBox.Show("Ya no tienes pistas, ve a la pantalla de conclusión", "Sin pistas :(");
            }
        }
        private void imgKestrel_Click(object sender, System.EventArgs e)
        {
            if (Program.controladorJuego.Pistas > 0)
            {
                MessageBox.Show(
                Program.controladorJuego.ObtenerPista(Program.controladorJuego.Personajes.Where(x => x.Nombre.Equals(Nombres.Kestrel.ToString())).First().Lugar),
                $"Pista #{Program.controladorJuego.Pistas}");
                Program.controladorJuego.Pistas--;
            }
            else
            {
                MessageBox.Show("Ya no tienes pistas, ve a la pantalla de conclusión", "Sin pistas :(");
            }
        }
        private void imgArcher_Click(object sender, System.EventArgs e)
        {
            if (Program.controladorJuego.Pistas > 0)
            {
                MessageBox.Show(
                Program.controladorJuego.ObtenerPista(Program.controladorJuego.Personajes.Where(x => x.Nombre.Equals(Nombres.Archer.ToString())).First().Lugar),
                $"Pista #{Program.controladorJuego.Pistas}");
                Program.controladorJuego.Pistas--;
            }
            else
            {
                MessageBox.Show("Ya no tienes pistas, ve a la pantalla de conclusión", "Sin pistas :(");
            }
        }
        private void imgBriggs_Click(object sender, System.EventArgs e)
        {
            if (Program.controladorJuego.Pistas > 0)
            {
                MessageBox.Show(
                Program.controladorJuego.ObtenerPista(Program.controladorJuego.Personajes.Where(x => x.Nombre.Equals(Nombres.Briggs.ToString())).First().Lugar),
                $"Pista #{Program.controladorJuego.Pistas}");
                Program.controladorJuego.Pistas--;
            }
            else
            {
                MessageBox.Show("Ya no tienes pistas, ve a la pantalla de conclusión", "Sin pistas :(");
            }
        }
    }
}
