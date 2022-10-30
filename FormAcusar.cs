using System.Linq;
using System.Windows.Forms;

namespace Clue
{
    public partial class FormAcusar : Form
    {
        public FormAcusar()
        {
            InitializeComponent();
        }

        private void btnAcusar_Click(object sender, System.EventArgs e)
        {
            if (!Program.controladorJuego.JuegoFinalizado)
            {

                RadioButton nombre = opcionPersonaje.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                RadioButton arma = opcionArma.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                RadioButton lugar = opcionLugar.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                if (nombre.Text.Equals(Program.controladorJuego.Asesino.Nombre) &&
                    arma.Text.Equals(Program.controladorJuego.Asesino.Arma) &&
                    lugar.Text.Equals(Program.controladorJuego.Asesino.Lugar))
                {
                    Program.controladorJuego.WinLose = true;
                    MessageBox.Show($"¡Has ganado!\r\n\r\n Felicidades encontraste al asesino y lo has encarcelado, ahora podremos interrogarlo para saber realmente quien " +
                        $"esta detras de esto\r\n\r\n {Program.controladorJuego.ObtenerPista("Respuesta")}", "¡Ganaste!");
                }
                else
                {
                    Program.controladorJuego.WinLose = false;
                    MessageBox.Show($"Has perdido...\r\n\r\n El asesino fue a por ti y decidio eliminarte antes de que continuaras con la investigacion\r\n\r\n" +
                        $"{Program.controladorJuego.ObtenerPista("Respuesta")}", "Perdiste :(");
                }

                Program.controladorJuego.JuegoFinalizado = true;
            }
            else
            {
                MessageBox.Show($"Ya has terminado tu trabajo soldado y has {(Program.controladorJuego.WinLose ? "Ganado" : "Perdido")} \r\n Inicia un nuevo juego", "Inicia nuevo juego");
            }
        }
    }
}
