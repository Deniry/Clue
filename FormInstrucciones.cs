using System.Windows.Forms;

namespace Clue
{
    public partial class FormInstrucciones : Form
    {
        private int pista;

        public FormInstrucciones()
        {
            InitializeComponent();
            lblInstrucciones.Text =
                "Codigo rojo esto no es un simulacro!!!!\r\n" +
                "Alguien a matado a nuestro informante Andriy Kobin\r\n" +
                "Hay un traidor abordo del avion, como lider de seguridad\r\n" +
                "del Paladin es tu deber encontrarlo.";
            pista = 0;
            this.CambiarPista();
        }

        private void CambiarPista()
        {
            switch (pista)
            {
                case 1:
                    lblPistas.Text =
                        "Hay 5 lugares posibles donde pudo ocurrir el asesinato:\r\n\r\n" +
                        "+Alojamiento\r\n" +
                        "+Cabina\r\n" +
                        "+Almacén\r\n" +
                        "+Enfermería\r\n" +
                        "+Taller";
                    break;
                case 2:
                    lblPistas.Text =
                        "Las armas que pudieron ser usadas para el asesinato son:\r\n\r\n" +
                        "+Cuchillo\r\n" +
                        "+Five Seven(Pistola)\r\n" +
                        "+Cable de Metal\r\n" +
                        "+SC-20K Silenciada\r\n" +
                        "+Ballesta";
                    break;
                case 3:
                    lblPistas.Text =
                        "Podras consultar la informacion recopilada por el sistema\r\n" +
                        "de seguridad del Paladin 4 veces, tu mision es encontrar \r\n" +
                        "el arma con el que fue ocasionado el homicidio, en donde \r\n" +
                        "fue el altercado e identificar al traidor en la nave y \r\n" +
                        "capturarlo, en caso de que lo logres seras recompensado \r\n" +
                        "por tus esfuerzos, de lo contrario es probable que el asesino\r\n" +
                        "termine eliminandote ya que todos los integrantes de \r\n" +
                        "la nave son agentes altamente entrenados.\r\n\r\n" +
                        "Rezamos por su exito, que tenga suerte soldado.";
                    lblPistas.ForeColor = System.Drawing.Color.LightGreen;
                    break;
                default:
                    pista = 0;
                    lblPistas.ForeColor = System.Drawing.Color.Lime;
                    lblPistas.Text =
                            "Dentro del Paladin hay 5 sospechosos:\r\n\r\n" +
                            "+Sam Fisher\r\n" +
                            "Ocupacion: SEAL de la Marina\r\n\r\n" +
                            "+Isaac Briggs\r\n" +
                            "Ocupacion: Operador de campo de Fourth Echelon\r\n\r\n" +
                            "+Mikhail Loskov (Kestrel)\r\n" +
                            "Ocupacion: Agente de campo de Voron\r\n\r\n" +
                            "+Anna Grimsdottir (Grim)\r\n" +
                            "Ocupacion: Oficial de operaciones tecnicas de Fourth Echelon\r\n\r\n" +
                            "+Robert Sloane (Archer)\r\n" +
                            "Ocuapcion: Operador de campo de Third Echelons";
                    break;
            }
            
        }

        private void btnSiguiente_Click(object sender, System.EventArgs e)
        {
            pista++;
            this.CambiarPista();
        }
    }
}
