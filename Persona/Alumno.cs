using System;
using System.Collections.Generic;
using System.Text;

namespace Clase3
{
    // HEREDA DE LA CLASE PERSONA 
    class Alumno : Persona
    {
        // VARIABLES
        private int id;
        private string name;
        private int lib;

        // GETTERS Y SETTERS
        public int libreta 
        { 
            get => lib; 
            set => lib = value; 
        }

        public int dni
        {
            get => id;
            set => id = value;
        }

        public string nombre
        {
            get => name;
            set => name = value;
        }

        // CONSTRUCTOR 
        public Alumno() { }

        // CONSTRUCTOR SOBRECARGADO
        public Alumno(int DNI, string Nombre, int Libreta)
        {
            dni = DNI;
            name = Nombre;
            libreta = Libreta;
        }

        public string getNombre()
        {
            return name;
        }
       
        public void setNombre(string n)
        {
            name = n;
        }

        // METODO DE COMPARACION DE ORDENAMIENTO
        public int CompareTo(Persona other)
        {
            // COMPARAR DNI DE ALUMNO
            return dni.CompareTo(other.dni);
        }

    }
}
