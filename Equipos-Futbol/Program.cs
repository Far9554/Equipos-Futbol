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
        static List<Club> Clubs = new List<Club>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - Dar de alta a jugador");
                Console.WriteLine("2 - Dar de alta a equipo");
                Console.WriteLine("3 - Agregar jugador a equipo");
                Console.WriteLine("4 - Eliminar jugador de equipo");
                Console.WriteLine("5 - Mostrar Jugadores Equipo");
                Console.WriteLine("6 - Crear Club");
                Console.WriteLine("7 - Añadir Equipo a Club");

                SeleccionarFuncion(Int32.Parse(Console.ReadLine()));
            }
        }

        static void SeleccionarFuncion(int Opcion)
        {
            switch (Opcion)
            {
                case 1:
                    CrearJugador();
                    break;
                case 2:
                    CrearEquipo();
                    break;
                case 3:
                    SelectorEquipo().Jugadores.Add(SelectorJugador());
                    break;
                case 4:
                    Equipo e = SelectorEquipo();
                    e.Jugadores.Remove(e.SelectorJugadorEquipo());
                    break;
                case 5:
                    SelectorEquipo().MostrarJugadores();
                    break;
                case 6:
                    CrearClub();
                    break;
                case 7:
                    SelectorClub().Equipos.Add(SelectorEquipo());
                    break;
                default:
                    return;
            }
        }

        static Equipo SelectorEquipo()
        {
            Console.WriteLine("-- EQUIPOS --");
            for (int i = 0; i < Equipos.Count; i++)
                Console.WriteLine(i + Equipos[i].NombreEquipo);

            Console.Write("Introduce numero Equipo: ");
            int id = Int32.Parse(Console.ReadLine());
            return Equipos[id];
        }

        static Jugador SelectorJugador()
        {
            Console.WriteLine("-- JUGADORES --");
            for (int i = 0; i < Jugadores.Count; i++)
                Console.WriteLine(i + Jugadores[i].Nombre);

            Console.Write("Introduce numero Jugador: ");
            int id = Int32.Parse(Console.ReadLine());
            return Jugadores[id];
        }

        static Club SelectorClub()
        {
            Console.WriteLine("-- CLUBS --");
            for (int i = 0; i < Clubs.Count; i++)
                Console.WriteLine(i + Clubs[i].Nombre);

            Console.Write("Introduce numero Club: ");
            int id = Int32.Parse(Console.ReadLine());
            return Clubs[id];
        }

        static void CrearJugador()
        {
            Console.WriteLine("Nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Apellidos:");
            string apellidos = Console.ReadLine();

            Console.WriteLine("Posición:");
            string posicion = Console.ReadLine();

            Console.WriteLine("Fecha nacimiento (dd/mm/yyyy):");
            string fechaNacimiento = Console.ReadLine();

            Console.WriteLine("Nacionalidad:");
            string nacionalidad = Console.ReadLine();

            Jugadores.Add(new Jugador(nombre, apellidos, posicion, fechaNacimiento, nacionalidad));
            Console.WriteLine("Jugador creado correctamente!");
        }

        static void CrearEquipo()
        {
            Console.WriteLine("--Crear Equipo--");
            Console.Write("Nombre Equipo: ");
            string n = Console.ReadLine();

            Equipos.Add(new Equipo(n));
        }

        static void CrearClub()
        {
            Console.WriteLine("--Crear Club--");
            Console.Write("Nombre Club: ");
            string n = Console.ReadLine();

            Clubs.Add(new Club(n));
        }
    }
}
