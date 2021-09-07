using System;

namespace Clase3Comun
{
    public interface Persona : IComparable<Persona>
    {
        //se definen los get y set típicos para los atributos
        public int getDni();
        public void setDni(int nuevoDNI);
        public string getNombre();
        public void setNombre(string nuevoNombre);

        //este método me permite establecer un orden, es obligatorio si digo que implemento IComparable
        //como es una interfaz no lo defino acá, lo define la clase que implemente esta interfaz
        public int CompareTo(Persona other);

    }
}
