using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Hum.Juego
{
    class clsEquipos
    {
        public static Stack<Equipo> Equipos = new Stack<Equipo>();
        public clsEquipos()
        {

        }
        public bool Insertar(Equipo equipo)
        {
            try
            {
                Equipos.Push(equipo);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Stack<Equipo> Mostrar()
        {
            return Equipos;
        }
    }
}
