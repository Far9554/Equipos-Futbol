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
        private int edad;
        private string posicion;
        private string fechaNacimiento;
        private string nacionalidad;
        private string lugarNacimiento;
        private int alturaCms;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellidos { get {  return apellidos; } set {  apellidos = value; } }

        public int Edad { get { return edad; } set { edad = value; } }

        public string Posicion { get {  return posicion; } set {  posicion = value; } }

        public string FechaNacimiento { get {  return fechaNacimiento; } set { fechaNacimiento = value; } }

        public string Nacionalidad { get { return nacionalidad; } set { nacionalidad = value; } }

        public string LugarNacimiento { get { return lugarNacimiento; } set { lugarNacimiento = value; } }

        public int AlturaCms { get { return alturaCms; } set { alturaCms = value; } }

        public Jugador() { }

        public Jugador(string nombre, string apellidos, int edad, string posicion, string fechaNacimiento, string nacionalidad, string lugarNacimiento, int alturaCms)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            this.posicion = posicion;
            this.fechaNacimiento = fechaNacimiento;
            this.nacionalidad = nacionalidad;
            this.lugarNacimiento = lugarNacimiento;
            this.alturaCms = alturaCms;
        }
    }
}
