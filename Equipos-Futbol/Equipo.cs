﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos_Futbol
{
    internal class Equipo
    {
        private string nombreEquipo;
        private List<Jugador> jugadorList = new List<Jugador>();

        public string NombreEquipo { get { return nombreEquipo; } set {  nombreEquipo = value; } }
        public List<Jugador> Jugadores { get { return jugadorList; } set { jugadorList = value; } }


        public Equipo(string xNombre) { nombreEquipo = xNombre; }

        public void MostrarJugadores()
        {
            Console.WriteLine("-- " + nombreEquipo + " --");
            foreach(Jugador j in  jugadorList)
                Console.WriteLine(j.Nombre);

            Console.ReadLine();
        }
        public Jugador SelectorJugadorEquipo()
        {
            Console.WriteLine("-- JUGADORES --");
            for (int i = 0; i < Jugadores.Count; i++)
            {
                Console.WriteLine(i + Jugadores[i].Nombre);
            }

            Console.Write("Introduce numero jugador: ");
            int id = Int32.Parse(Console.ReadLine());
            return Jugadores[id];
        }
    }
}
