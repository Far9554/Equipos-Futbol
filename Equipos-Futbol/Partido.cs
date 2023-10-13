using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos_Futbol
{
    internal class Partido
    {
        private Equipo equipo1;
        private Equipo equipo2;
        private int golesEquipo1;
        private int golesEquipo2;

        public Equipo Equipo1 { get { return equipo1; } set { equipo1 = value; } }
        public Equipo Equipo2 { get { return equipo2; } set { equipo2 = value; } }
        public int GolesEquipo1 { get { return golesEquipo1; } set { golesEquipo1 = value; } }
        public int GolesEquipo2 { get { return golesEquipo2; } set { golesEquipo2 = value; } }

        public Partido() { }

        public Partido(Equipo equipo1, Equipo equipo2)
        {
            this.equipo1 = equipo1;
            this.equipo2 = equipo2;
        }

        public Partido(Equipo equipo1, Equipo equipo2, int golesEquipo1, int golesEquipo2)
        {
            this.equipo1 = equipo1;
            this.equipo2 = equipo2;
            this.golesEquipo1 = golesEquipo1;
            this.golesEquipo2 = golesEquipo2;
        }

        public void GenerarResultado()
        {
            Random rnd = new Random();
            golesEquipo1 = rnd.Next(7);
            golesEquipo2 = rnd.Next(7);
        }

        public string ObtenerResultado()
        {
            return equipo1.NombreEquipo + " " + golesEquipo1 + "\n" + equipo2.NombreEquipo + " " + golesEquipo2;
        }
    }
}
