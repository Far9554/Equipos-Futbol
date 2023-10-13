using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos_Futbol
{
    internal class Program
    {
        static List<Equipo> Equipos = new List<Equipo>();
        static List<Jugador> Jugadores = new List<Jugador>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - Dar de alta a jugador");
                Console.WriteLine("2 - Dar de alta a equipo");
                Console.WriteLine("3 - Agregar jugador a equipo");
                Console.WriteLine("4 - Mostrar Jugadores Equipo");
                Console.WriteLine("5 - Mostrar todos los jugadores y su equipo");
                Console.WriteLine("6 - Mostrar Informacion General");

                SeleccionarFuncion(Int32.Parse(Console.ReadLine()));
            }
        }

        static void SeleccionarFuncion(int Opcion)
        {
            switch (Opcion)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    return;
            }
        }

        public Equipo SelectorEquipo()
        {
            Console.WriteLine("-- MEDICOS --");
            for (int i = 0; i < Equipos.Count; i++)
            {
                Console.WriteLine(i + " - Dr. " + Equipos[i].NombreEquipo);
            }

            Console.Write("Introduce numero Medico: ");
            int id = Int32.Parse(Console.ReadLine());
            return Equipos[id];
        }
    }
}
