
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase3Comun
{
    class Profesor : Persona
    {
        //atributos privados de la clase
        private int dni;
        private string nombre;
        private int matricula;

        public Profesor(int DNI, string Nombre, int Matricula)
        {
            // es lo mismo si asigno al atributo private o a la property con get/set ya que el valor se copia
            dni = DNI;
            nombre = Nombre;
            matricula = Matricula;
        }

        public int getDni() { return dni; }
        public void setDni(int nuevoDNI) { dni = nuevoDNI; }
        public string getNombre() { return nombre; }
        public void setNombre(string nuevoNombre) { nombre = nuevoNombre; }
        public int getMatricula() { return matricula; }
        public void setMatricula(int nuevaLibreta) { matricula = nuevaLibreta; }

        //Esta es la "magia del sort" simplemente le digo que ordene esta persona contra otra por DNI
        //Esto establece un orden entre distintas personas, distintos tipos de órdenes luego jugamos con
        //el método sort desde el programa principal
        public int CompareTo(Persona other)
        {
            return dni.CompareTo(other.getDni());
        }

    }
}
