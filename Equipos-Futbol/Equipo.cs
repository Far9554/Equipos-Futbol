using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos_Futbol
{
    internal class Equipo
    {
        private string NombreEquipo;
        private List<Jugador> jugadorList = new List<Jugador>();

        public List<Jugador> Jugadores { get { return jugadorList; } set { jugadorList = value; } }

        public Equipo(string xNombre) { NombreEquipo = xNombre; }

        public void MostrarJugadores()
        {
            Console.WriteLine("-- " + NombreEquipo + " --");
            foreach(Jugador j in  jugadorList)
            {

            }
        }
    }
}
