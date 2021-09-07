using System;
using System.Collections.Generic;
using System.Text;

namespace Clase3Comun
{
    class Alumno : Persona
    {
        //atributos privados de la clase
        private int dni;
        private string nombre;
        private int lib;

        public Alumno(int DNI, string Nombre, int Libreta)
        {
            // es lo mismo si asigno al atributo private o a la property con get/set ya que el valor se copia
            dni = DNI;
            nombre = Nombre;
            lib = Libreta;
        }

        public int getDni() { return dni; }
        public void setDni(int nuevoDNI) { dni = nuevoDNI; }
        public string getNombre() { return nombre; }
        public void setNombre(string nuevoNombre) { nombre = nuevoNombre; }
        public int getLibreta() { return lib; }
        public void setLibreta(int nuevaLibreta) { lib = nuevaLibreta; }

        //Esta es la "magia del sort" simplemente le digo que ordene esta persona contra otra por DNI
        //Esto establece un orden entre distintas personas, distintos tipos de órdenes luego jugamos con
        //el método sort desde el programa principal
        public int CompareTo(Persona other)
        {
            return dni.CompareTo(other.getDni());
        }

    }
}
