using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos_Futbol
{
    internal class Club
    {
        private List<Equipo> equipos = new List<Equipo>();
        private string nombre;

        public List<Equipo> Equipos { get { return equipos; } set { equipos = value; } }

        public string Nombre { get { return nombre; } set { nombre = value; } }

        public Club() { }

        public Club(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
