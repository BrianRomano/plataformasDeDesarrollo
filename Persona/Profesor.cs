using System;
using System.Collections.Generic;
using System.Text;

namespace Clase3
{
    // HEREDA DE LA CLASE PERSONA 
    class Profesor : Persona
    {
        // VARIABLES
        private int id;
        private string name;
        private int mat;

        // GETTERS Y SETTERS
        public int matricula
        {
            get => mat;
            set => mat = value;
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
        public Profesor() { }

        // CONSTRUCTOR SOBRECARGADO
        public Profesor(int DNI, string Nombre, int Matricula)
        {
            dni = DNI;
            name = Nombre;
            matricula = Matricula;
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
            // COMPARAR DNI DE PROFESOR
            return dni.CompareTo(other.dni);
        }

    }
}
