using System.Collections.Generic;
using System.Linq;

namespace Clue
{
    public enum Nombres { Fisher, Grimm, Kestrel, Archer, Briggs }
    public enum Lugares { Cabina, Alojamiento, Carga, Enfermeria, Taller }
    public enum Armas { Pistola, Ballesta, Cable, ArmaSilenciada, Cuchillo }

    public class ClueController
    {
        public static List<string> sospechosos = new List<string>()
        { 
            Nombres.Fisher.ToString(),
            Nombres.Grimm.ToString(),
            Nombres.Kestrel.ToString(),
            Nombres.Archer.ToString(),
            Nombres.Briggs.ToString()
        };

        public static List<string> lugares = new List<string>()
        {
            Lugares.Cabina.ToString(),
            Lugares.Alojamiento.ToString(),
            Lugares.Carga.ToString(),
            Lugares.Enfermeria.ToString(),
            Lugares.Taller.ToString()
        };

        public static List<string> armas = new List<string>()
        {
            Armas.Pistola.ToString(),
            Armas.Ballesta.ToString(),
            Armas.Cable.ToString(),
            Armas.ArmaSilenciada.ToString(),
            Armas.Cuchillo.ToString(),
        };

        public static Dictionary<string, string> escenario = new Dictionary<string, string>();
        
        public int Pistas { get; set; }
        public bool JuegoFinalizado { get; set; }
        public bool WinLose { get; set; }
        public Personaje Asesino { get; set; }
        public List<Personaje> Personajes { get; set; }

    public ClueController()
        {
            // Desordenar listas
            sospechosos.Shuffle();
            lugares.Shuffle();
            armas.Shuffle();

            // Generar personajes
            Personajes = new List<Personaje>()
            {
                new Personaje(){ Nombre = sospechosos[0], Arma = armas[0], Lugar = lugares[0], Asesino = true  },
                new Personaje(){ Nombre = sospechosos[1], Arma = armas[1], Lugar = lugares[1], Asesino = false },
                new Personaje(){ Nombre = sospechosos[2], Arma = armas[2], Lugar = lugares[2], Asesino = false },
                new Personaje(){ Nombre = sospechosos[3], Arma = armas[3], Lugar = lugares[3], Asesino = false },
                new Personaje(){ Nombre = sospechosos[4], Arma = armas[4], Lugar = lugares[4], Asesino = false },
            };
            Asesino = Personajes.Where(x => x.Asesino).FirstOrDefault();

            // Generar escenario
            switch (Asesino.Lugar)
            {
                case "Cabina":
                    InicializarEscenarioCabina();
                    break;
                case "Alojamiento":
                    InicializarEscenarioAlojamiento();
                    break;
                case "Carga":
                    InicializarEscenarioCarga();
                    break;
                case "Enfermeria":
                    InicializarEscenarioEnfermeria();
                    break;
                case "Taller":
                    InicializarEscenarioTaller();
                    break;
            }

            // Numero de pistas disponibles
            Pistas = 4;
        }

        public string ObtenerPista(string lugar)
        {
            return escenario[lugar];
        }

        private void InicializarEscenarioCabina()
        {
            Personaje personajeCabina = Personajes.Where(x => x.Lugar.Equals(Lugares.Cabina.ToString())).FirstOrDefault();
            Personaje personajeCarga = Personajes.Where(x => x.Lugar.Equals(Lugares.Carga.ToString())).FirstOrDefault();
            Personaje personajeEnfermeria = Personajes.Where(x => x.Lugar.Equals(Lugares.Enfermeria.ToString())).FirstOrDefault();
            Personaje personajeTaller = Personajes.Where(x => x.Lugar.Equals(Lugares.Taller.ToString())).FirstOrDefault();

            escenario = new Dictionary<string, string>
            {
                {
                    Lugares.Cabina.ToString(),
                    $"{personajeCabina.Nombre} reporta que se encontraba en la cabina del avion revisando los controles,\r\n" +
                    $"el dice haber visto {personajeCabina.Arma} en la cabina,\r\n" +
                    $"las camaras confirman que {personajeCabina.Nombre} estaba en la cabina y {personajeCabina.Arma} tambien se encontraba ahi\r\n" +
                    "Las camaras dejaron de funcionar por un momento."
                },
                {
                    Lugares.Alojamiento.ToString(),
                    $"{Asesino.Nombre} informa que se encontraba en el alojamiento de pasajeros descansando en su cama,\r\n" +
                    $"dice haber visto {personajeTaller.Arma} en una de las literas.\r\n" +
                    $"Las camaras confirman que {personajeTaller.Arma} estaba en las literas, pero {Asesino.Nombre} no se encontraba allí.\r\n" +
                    "Las camaras funcionaron en todo momento."
                },
                {
                    Lugares.Carga.ToString(),
                    $"{personajeCarga.Nombre} menciono que estaba dandole mantenimiento al helicoptero en la zona de carga,\r\n" +
                    $"{personajeCarga.Nombre} dijo que encima de una caja estaba un(a) {personajeCarga.Arma},\r\n" +
                    $"las camaras confirman que {personajeCarga.Nombre} estaba ahi al igual que {personajeCarga.Arma} estaba sobre una de las cajas.\r\n" +
                    "Las camaras funcionaron en todo momento."
                },
                {
                    Lugares.Enfermeria.ToString(),
                    $"{personajeEnfermeria.Nombre} dice que se encontraba en el area medica haciendo inventario del equipo medico disponible,\r\n" +
                    $"{personajeEnfermeria.Nombre} menciona que encima de la camilla estaba {personajeEnfermeria.Arma},\r\n" +
                    $"las camaras confirman que {personajeEnfermeria.Nombre} si estaba en el lugar al igual que {personajeEnfermeria.Arma} se encontraba encima de la camilla.\r\n" +
                    "Las camaras funcionaron en todo momento."
                },
                {
                    Lugares.Taller.ToString(),
                    $"{personajeTaller.Nombre} menciona que estuvo en el taller de Charlie mejorando su equipo,\r\n" +
                    $"{personajeTaller.Nombre} menciona que vio en el taller {Asesino.Arma}\r\n" +
                    $"Las camaras de seguridad confirman que {personajeTaller.Nombre} estuvo en el lugar, pero {Asesino.Arma} no estaba por ningun lado del taller.\r\n" +
                    "Las camaras funcionaron en todo momento."
                },
                {
                    "Respuesta",
                    $"El asesino es {Asesino.Nombre} que dijo estar en el {Asesino.Lugar}, lo mato en la Cabina con un(a) {Asesino.Arma} del taller de Charlie"
                }
            };
        }

        private void InicializarEscenarioAlojamiento()
        {
            Personaje personajeCabina = Personajes.Where(x => x.Lugar.Equals(Lugares.Cabina.ToString())).FirstOrDefault();
            Personaje personajeCarga = Personajes.Where(x => x.Lugar.Equals(Lugares.Carga.ToString())).FirstOrDefault();
            Personaje personajeEnfermeria = Personajes.Where(x => x.Lugar.Equals(Lugares.Enfermeria.ToString())).FirstOrDefault();
            Personaje personajeAlojamiento = Personajes.Where(x => x.Lugar.Equals(Lugares.Alojamiento.ToString())).FirstOrDefault();

            escenario = new Dictionary<string, string>
            {
                {
                    Lugares.Cabina.ToString(),
                    $"{personajeCabina.Nombre} reporta que se encontraba en la cabina del avion revisando los controles,\r\n" +
                    $"el dice haber visto {personajeCabina.Arma} en la cabina,\r\n" +
                    $"las camaras confirman que {personajeCabina.Nombre} estaba en la cabina y {personajeCabina.Arma} tambien se encontraba ahi\r\n" +
                    "Las camaras funcionaron en todo momento."
                },
                {
                    Lugares.Alojamiento.ToString(),
                    $"{personajeAlojamiento.Nombre} informa que se encontraba en el alojamiento de pasajeros descansando en su cama,\r\n" +
                    $"dice haber visto {personajeAlojamiento.Arma} en una de las literas.\r\n" +
                    $"Las camaras confirman que {personajeAlojamiento.Arma} estaba en las literas y {personajeAlojamiento.Nombre} se encontraba allí.\r\n" +
                    "Las camaras dejaron de funcionar por un momento."
                },
                {
                    Lugares.Carga.ToString(),
                    $"{personajeCarga.Nombre} menciono que estaba dandole mantenimiento al helicoptero en la zona de carga,\r\n" +
                    $"{personajeCarga.Nombre} dijo que encima de una caja estaba un(a) {personajeCarga.Arma},\r\n" +
                    $"las camaras confirman que {personajeCarga.Nombre} estaba ahi al igual que {personajeCarga.Arma} estaba sobre una de las cajas.\r\n" +
                    "Las camaras funcionaron en todo momento."
                },
                {
                    Lugares.Enfermeria.ToString(),
                    $"{personajeEnfermeria.Nombre} dice que se encontraba en el area medica haciendo inventario del equipo medico disponible,\r\n" +
                    $"{personajeEnfermeria.Nombre} menciona que encima de la camilla estaba {Asesino.Arma},\r\n" +
                    $"las camaras confirman que {personajeEnfermeria.Nombre} si estaba en el lugar, pero {Asesino.Arma} no se encontraba encima de la camilla.\r\n" +
                    "Las camaras funcionaron en todo momento."
                },
                {
                    Lugares.Taller.ToString(),
                    $"{Asesino.Nombre} menciona que estuvo en el taller de Charlie mejorando su equipo,\r\n" +
                    $"{Asesino.Nombre} menciona que vio en el taller {personajeEnfermeria.Arma}\r\n" +
                    $"Las camaras no detectaron a {Asesino.Nombre} en el lugar, pero {personajeEnfermeria.Arma} estaba en una mesa del taller.\r\n" +
                    "Las camaras funcionaron en todo momento."
                },
                {
                    "Respuesta",
                    $"El asesino es {Asesino.Nombre} que dijo estar en el {Asesino.Lugar}, lo mato en el Alojamiento con un(a) {Asesino.Arma} de la Enfermeria"
                }
            };
        }

        private void InicializarEscenarioCarga()
        {
            Personaje personajeCabina = Personajes.Where(x => x.Lugar.Equals(Lugares.Cabina.ToString())).FirstOrDefault();
            Personaje personajeCarga = Personajes.Where(x => x.Lugar.Equals(Lugares.Carga.ToString())).FirstOrDefault();
            Personaje personajeAlojamiento = Personajes.Where(x => x.Lugar.Equals(Lugares.Alojamiento.ToString())).FirstOrDefault();
            Personaje personajeTaller = Personajes.Where(x => x.Lugar.Equals(Lugares.Taller.ToString())).FirstOrDefault();

            escenario = new Dictionary<string, string>
            {
                {
                    Lugares.Cabina.ToString(),
                    $"{personajeCabina.Nombre} reporta que se encontraba en la cabina del avion revisando los controles,\r\n" +
                    $"el dice haber visto {personajeCabina.Arma} en la cabina,\r\n" +
                    $"las camaras confirman que {personajeCabina.Nombre} estaba en la cabina y {personajeCabina.Arma} tambien se encontraba ahi\r\n" +
                    "Las camaras funcionaron en todo momento."
                },
                {
                    Lugares.Alojamiento.ToString(),
                    $"{personajeAlojamiento.Nombre} informa que se encontraba en el alojamiento de pasajeros descansando en su cama,\r\n" +
                    $"dice haber visto {Asesino.Arma} en una de las literas.\r\n" +
                    $"Las camaras no encontraron {Asesino.Arma} en las literas, pero {personajeAlojamiento.Nombre} se encontraba allí.\r\n" +
                    "Las camaras funcionaron en todo momento."
                },
                {
                    Lugares.Carga.ToString(),
                    $"{personajeCarga.Nombre} menciono que estaba dandole mantenimiento al helicoptero en la zona de carga,\r\n" +
                    $"{personajeCarga.Nombre} dijo que encima de una caja estaba un(a) {personajeCarga.Arma},\r\n" +
                    $"las camaras confirman que {personajeCarga.Nombre} estaba ahi al igual que {personajeCarga.Arma} estaba sobre una de las cajas.\r\n" +
                    "Las camaras dejaron de funcionar por un momento."
                },
                {
                    Lugares.Enfermeria.ToString(),
                    $"{Asesino.Nombre} dice que se encontraba en el area medica haciendo inventario del equipo medico disponible,\r\n" +
                    $"{Asesino.Nombre} menciona que encima de la camilla estaba {personajeAlojamiento.Arma},\r\n" +
                    $"las camaras no encontraron a {Asesino.Nombre} por ningun lado, pero {personajeAlojamiento.Arma} si se encontraba encima de la camilla.\r\n" +
                    "Las camaras funcionaron en todo momento."
                },
                {
                    Lugares.Taller.ToString(),
                    $"{personajeTaller.Nombre} menciona que estuvo en el taller de Charlie mejorando su equipo,\r\n" +
                    $"{personajeTaller.Nombre} menciona que vio en el taller {personajeTaller.Arma}\r\n" +
                    $"Las camaras de seguridad confirman que {personajeTaller.Nombre} estuvo en el lugar y {personajeTaller.Arma} estaba en una mesa del taller.\r\n" +
                    "Las camaras funcionaron en todo momento."
                },
                {
                    "Respuesta",
                    $"El asesino es {Asesino.Nombre} que dijo estar en el {Asesino.Lugar}, lo mato en la Zona de Carga con un(a) {Asesino.Arma} del Alojamiento"
                }
            };
        }

        private void InicializarEscenarioEnfermeria()
        {
            Personaje personajeAlojamiento = Personajes.Where(x => x.Lugar.Equals(Lugares.Alojamiento.ToString())).FirstOrDefault();
            Personaje personajeCarga = Personajes.Where(x => x.Lugar.Equals(Lugares.Carga.ToString())).FirstOrDefault();
            Personaje personajeEnfermeria = Personajes.Where(x => x.Lugar.Equals(Lugares.Enfermeria.ToString())).FirstOrDefault();
            Personaje personajeTaller = Personajes.Where(x => x.Lugar.Equals(Lugares.Taller.ToString())).FirstOrDefault();

            escenario = new Dictionary<string, string>
            {
                {
                    Lugares.Cabina.ToString(),
                    $"{Asesino.Nombre} reporta que se encontraba en la cabina del avion revisando los controles,\r\n" +
                    $"el dice haber visto {personajeCarga.Arma} en la cabina,\r\n" +
                    $"las camaras no encontraron a {Asesino.Nombre} en la cabina, pero {personajeCarga.Arma} si se encontraba ahi\r\n" +
                    "Las camaras funcionaron en todo momento."
                },
                {
                    Lugares.Alojamiento.ToString(),
                    $"{Asesino.Nombre} informa que se encontraba en el alojamiento de pasajeros descansando en su cama,\r\n" +
                    $"dice haber visto {personajeTaller.Arma} en una de las literas.\r\n" +
                    $"Las camaras confirman que {personajeTaller.Arma} estaba en las literas, pero {Asesino.Nombre} no se encontraba allí.\r\n" +
                    "Las camaras funcionaron en todo momento."
                },
                {
                    Lugares.Carga.ToString(),
                    $"{personajeCarga.Nombre} menciono que estaba dandole mantenimiento al helicoptero en la zona de carga,\r\n" +
                    $"{personajeCarga.Nombre} dijo que encima de una caja estaba un(a) {Asesino.Arma},\r\n" +
                    $"las camaras confirman que {personajeCarga.Nombre} estaba ahi, pero {Asesino.Arma} no estaba en la Zona de Carga.\r\n" +
                    "Las camaras funcionaron en todo momento."
                },
                {
                    Lugares.Enfermeria.ToString(),
                    $"{personajeEnfermeria.Nombre} dice que se encontraba en el area medica haciendo inventario del equipo medico disponible,\r\n" +
                    $"{personajeEnfermeria.Nombre} menciona que encima de la camilla estaba {personajeEnfermeria.Arma},\r\n" +
                    $"las camaras confirman que {personajeEnfermeria.Nombre} si estaba en el lugar al igual que {personajeEnfermeria.Arma} se encontraba encima de la camilla.\r\n" +
                    "Las camaras dejaron de funcionar por un momento."
                },
                {
                    Lugares.Taller.ToString(),
                    $"{personajeTaller.Nombre} menciona que estuvo en el taller de Charlie mejorando su equipo,\r\n" +
                    $"{personajeTaller.Nombre} menciona que vio en el taller {Asesino.Arma}\r\n" +
                    $"Las camaras de seguridad confirman que {personajeTaller.Nombre} estuvo en el lugar, pero {Asesino.Arma} no estaba por ningun lado del taller.\r\n" +
                    "Las camaras funcionaron en todo momento."
                },
                {
                    "Respuesta",
                    $"El asesino es {Asesino.Nombre} que dijo estar en el {Asesino.Lugar}, lo mato en la Enfermeria con un(a) {Asesino.Arma} de la Zona de Carga"
                }
            };
        }

        private void InicializarEscenarioTaller()
        {
            Personaje personajeCabina = Personajes.Where(x => x.Lugar.Equals(Lugares.Cabina.ToString())).FirstOrDefault();
            Personaje personajeAlojamiento = Personajes.Where(x => x.Lugar.Equals(Lugares.Alojamiento.ToString())).FirstOrDefault();
            Personaje personajeEnfermeria = Personajes.Where(x => x.Lugar.Equals(Lugares.Enfermeria.ToString())).FirstOrDefault();
            Personaje personajeTaller = Personajes.Where(x => x.Lugar.Equals(Lugares.Taller.ToString())).FirstOrDefault();

            escenario = new Dictionary<string, string>
            {
                {
                    Lugares.Cabina.ToString(),
                    $"{personajeCabina.Nombre} reporta que se encontraba en la cabina del avion revisando los controles,\r\n" +
                    $"el dice haber visto {Asesino.Arma} en la cabina,\r\n" +
                    $"las camaras confirman que {personajeCabina.Nombre} estaba en la cabina, pero {Asesino.Arma} no se encontraba en la cabina\r\n" +
                    "Las camaras funcionaron en todo momento."
                },
                {
                    Lugares.Alojamiento.ToString(),
                    $"{personajeAlojamiento.Nombre} informa que se encontraba en el alojamiento de pasajeros descansando en su cama,\r\n" +
                    $"dice haber visto {personajeTaller.Arma} en una de las literas.\r\n" +
                    $"Las camaras confirman que {personajeTaller.Arma} estaba en las literas y {personajeAlojamiento.Nombre} se encontraba en los alojamientos.\r\n" +
                    "Las camaras funcionaron en todo momento."
                },
                {
                    Lugares.Carga.ToString(),
                    $"{Asesino.Nombre} menciono que estaba dandole mantenimiento al helicoptero en la zona de carga,\r\n" +
                    $"{Asesino.Nombre} dijo que encima de una caja estaba un(a) {personajeCabina.Arma},\r\n" +
                    $"las camaras confirman que {Asesino.Nombre} estaba ahi al igual que {personajeCabina.Arma} estaba sobre una de las cajas.\r\n" +
                    "Las camaras funcionaron en todo momento."
                },
                {
                    Lugares.Enfermeria.ToString(),
                    $"{personajeEnfermeria.Nombre} dice que se encontraba en el area medica haciendo inventario del equipo medico disponible,\r\n" +
                    $"{personajeEnfermeria.Nombre} menciona que encima de la camilla estaba {personajeEnfermeria.Arma},\r\n" +
                    $"las camaras confirman que {personajeEnfermeria.Nombre} si estaba en el lugar al igual que {personajeEnfermeria.Arma} se encontraba encima de la camilla.\r\n" +
                    "Las camaras funcionaron en todo momento."
                },
                {
                    Lugares.Taller.ToString(),
                    $"{personajeTaller.Nombre} menciona que estuvo en el taller de Charlie mejorando su equipo,\r\n" +
                    $"{personajeTaller.Nombre} menciona que vio en el taller {personajeTaller.Arma}\r\n" +
                    $"Las camaras de seguridad confirman que {personajeTaller.Nombre} estuvo en el lugar y {personajeTaller.Arma} estaba en una mesa del taller.\r\n" +
                    "Las camaras dejaron de funcionar por un momento."
                },
                {
                    "Respuesta",
                    $"El asesino es {Asesino.Nombre} que dijo estar en el {Asesino.Lugar}, lo mato en el Taller de Charlie con un(a) {Asesino.Arma} de la Cabina"
                }
            };
        }
    }
}
