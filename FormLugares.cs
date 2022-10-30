using System.Windows.Forms;

namespace Clue
{
    public partial class FormLugares : Form
    {
        public FormLugares()
        {
            InitializeComponent();
        }

        private void imgAlojamiento_Click(object sender, System.EventArgs e)
        {
            if (Program.controladorJuego.Pistas > 0)
            {
                MessageBox.Show(
                Program.controladorJuego.ObtenerPista(Lugares.Alojamiento.ToString()),
                $"Pista #{Program.controladorJuego.Pistas}");
                Program.controladorJuego.Pistas--;
            }
            else
            {
                MessageBox.Show("Ya no tienes pistas, ve a la pantalla de conclusión", "Sin pistas :(");
            }
        }

        private void imgCabina_Click(object sender, System.EventArgs e)
        {
            if (Program.controladorJuego.Pistas > 0)
            {
                MessageBox.Show(
                Program.controladorJuego.ObtenerPista(Lugares.Cabina.ToString()),
                $"Pista #{Program.controladorJuego.Pistas}");
                Program.controladorJuego.Pistas--;
            }
            else
            {
                MessageBox.Show("Ya no tienes pistas, ve a la pantalla de conclusión", "Sin pistas :(");
            }
        }

        private void imgCarga_Click(object sender, System.EventArgs e)
        {
            if (Program.controladorJuego.Pistas > 0)
            {
                MessageBox.Show(
                Program.controladorJuego.ObtenerPista(Lugares.Carga.ToString()),
                $"Pista #{Program.controladorJuego.Pistas}");
                Program.controladorJuego.Pistas--;
            }
            else
            {
                MessageBox.Show("Ya no tienes pistas, ve a la pantalla de conclusión", "Sin pistas :(");
            }
        }

        private void imgEnfermeria_Click(object sender, System.EventArgs e)
        {
            if (Program.controladorJuego.Pistas > 0)
            {
                MessageBox.Show(
                Program.controladorJuego.ObtenerPista(Lugares.Enfermeria.ToString()),
                $"Pista #{Program.controladorJuego.Pistas}");
                Program.controladorJuego.Pistas--;
            }
            else
            {
                MessageBox.Show("Ya no tienes pistas, ve a la pantalla de conclusión", "Sin pistas :(");
            }
        }
        private void imgTaller_Click(object sender, System.EventArgs e)
        {
            if (Program.controladorJuego.Pistas > 0)
            {
                MessageBox.Show(
                Program.controladorJuego.ObtenerPista(Lugares.Taller.ToString()),
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
