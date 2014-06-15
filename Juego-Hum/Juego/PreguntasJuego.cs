using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Hum.Juego
{
    class PreguntasJuego
    {
        public PreguntasJuego()
        {

        }
        public uint Id { get; set; }
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }
        public string Opcion2 { get; set; }
        public string Opcion3 { get; set; }
        public string Opcion4 { get; set; }
        public int Status { get; set; }
    }
}
