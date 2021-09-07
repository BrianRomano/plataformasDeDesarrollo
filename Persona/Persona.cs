using System;
namespace Clase3
{
    // AL SER IComparable ES OBLIGATORIO EL METODO CompareTo
    public interface Persona : IComparable<Persona>
    {
        // VARIABLES 
        private int dni;
        private string nombre; 

        // GETTERS Y SETTERS
        public int dni { get; set; }
        public string nombre { get; set; }

        // METODO QUE PERMITE ESTABLECER UN ORDEN. AL SER UNA INTERFAZ DEFINO EN LA CLASE IMPLEMENTADA 
        public int CompareTo(Persona other);
    }
}
