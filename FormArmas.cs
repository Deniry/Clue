using System.Linq;
using System.Windows.Forms;

namespace Clue
{
    public partial class FormArmas : Form
    {
        public FormArmas()
        {
            InitializeComponent();
        }

        private void imgCuchillo_Click(object sender, System.EventArgs e)
        {
            if (Program.controladorJuego.Pistas > 0)
            {
                MessageBox.Show(
                Program.controladorJuego.ObtenerPista(Program.controladorJuego.Personajes.Where(x => x.Arma.Equals(Armas.Cuchillo.ToString())).First().Lugar),
                $"Pista #{Program.controladorJuego.Pistas}");
                Program.controladorJuego.Pistas--;
            }
            else
            {
                MessageBox.Show("Ya no tienes pistas, ve a la pantalla de conclusión", "Sin pistas :(");
            }
        }
        private void imgArmaSilenciada_Click(object sender, System.EventArgs e)
        {
            if (Program.controladorJuego.Pistas > 0)
            {
                MessageBox.Show(
                Program.controladorJuego.ObtenerPista(Program.controladorJuego.Personajes.Where(x => x.Arma.Equals(Armas.ArmaSilenciada.ToString())).First().Lugar),
                $"Pista #{Program.controladorJuego.Pistas}");
                Program.controladorJuego.Pistas--;
            }
            else
            {
                MessageBox.Show("Ya no tienes pistas, ve a la pantalla de conclusión", "Sin pistas :(");
            }
        }
        private void imgBallesta_Click(object sender, System.EventArgs e)
        {
            if (Program.controladorJuego.Pistas > 0)
            {
                MessageBox.Show(
                Program.controladorJuego.ObtenerPista(Program.controladorJuego.Personajes.Where(x => x.Arma.Equals(Armas.Ballesta.ToString())).First().Lugar),
                $"Pista #{Program.controladorJuego.Pistas}");
                Program.controladorJuego.Pistas--;
            }
            else
            {
                MessageBox.Show("Ya no tienes pistas, ve a la pantalla de conclusión", "Sin pistas :(");
            }
        }
        private void imgCable_Click(object sender, System.EventArgs e)
        {
            if (Program.controladorJuego.Pistas > 0)
            {
                MessageBox.Show(
                Program.controladorJuego.ObtenerPista(Program.controladorJuego.Personajes.Where(x => x.Arma.Equals(Armas.Cable.ToString())).First().Lugar),
                $"Pista #{Program.controladorJuego.Pistas}");
                Program.controladorJuego.Pistas--;
            }
            else
            {
                MessageBox.Show("Ya no tienes pistas, ve a la pantalla de conclusión", "Sin pistas :(");
            }
        }
        private void imgPistola_Click(object sender, System.EventArgs e)
        {
            if (Program.controladorJuego.Pistas > 0)
            {
                MessageBox.Show(
                Program.controladorJuego.ObtenerPista(Program.controladorJuego.Personajes.Where(x => x.Arma.Equals(Armas.Pistola.ToString())).First().Lugar),
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
