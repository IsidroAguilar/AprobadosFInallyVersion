using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Preguntas
    {
        public Preguntas()
        {

        }
        public int Id_Juego { get; set; }
        public int Id { get; set; }
        public int Id_cuest { get; set; }
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }
        public string Opcion2 { get; set; }
        public string Opcion3 { get; set; }
        public string Opcion4 { get; set; }
    }
}
