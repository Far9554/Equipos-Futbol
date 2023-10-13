using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos_Futbol
{
    internal class Jugador
    {
        private string nombre;
        private string apellidos;
        private string posicion;
        private string fechaNacimiento;
        private string nacionalidad;
        private string nombreEquipo;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellidos { get {  return apellidos; } set {  apellidos = value; } }

        public string Posicion { get {  return posicion; } set {  posicion = value; } }

        public string FechaNacimiento { get {  return fechaNacimiento; } set { fechaNacimiento = value; } }

        public string Nacionalidad { get { return nacionalidad; } set { nacionalidad = value; } }

        public string NombreEquipo { get { return nombreEquipo; } set { nombreEquipo = value; } }

        public Jugador() { }

        public Jugador(string nombre, string apellidos, string posicion, string fechaNacimiento, string nacionalidad)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.posicion = posicion;
            this.fechaNacimiento = fechaNacimiento;
            this.nacionalidad = nacionalidad;
        }
    }
}
