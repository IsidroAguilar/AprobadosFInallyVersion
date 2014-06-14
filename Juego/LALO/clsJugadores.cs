using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego.LALO
{
    public class clsJugadores
    {
        private static string[] Jugadores { get; set; }

        public void RegistrarJugadores()
        {
            Jugadores = new string[6];
        }

        public void RegistrarJugador(int Contador, string Path)
        {
            Jugadores[Contador] = Path;
        }

        public string RutasJugadores(int Contador, ref string Path)
        {
            Path = Jugadores[Contador];
            return Path;
        }

    }
}
