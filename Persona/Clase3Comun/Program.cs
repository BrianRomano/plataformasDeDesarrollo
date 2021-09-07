using System;
using System.Collections.Generic;

namespace Clase3Comun
{
    class Program
    {
        static void Main(string[] args)
        {
            //creo una lista de personas
            List<Persona> misPersonas = new List<Persona>();
            
            //esta bandera me avisa si me cargaron un 0 para salir del while de "carga"
            int flag = -1;

            string input, nombre;
            int dni, extra;
            while (flag < 0)
            {
                Console.WriteLine("Ingrese dni: ");
                input = Console.ReadLine();
                dni = int.Parse(input);
                if (dni == 0)
                {
                    //si getDni() es 0 salgo y paso a mostrar datos cargados
                    flag = 0;
                    break;
                }
                Console.WriteLine("Ingrese nombre: ");
                input = Console.ReadLine();
                nombre = input;
                Console.WriteLine("Ingrese Matricula/Libreta: ");
                input = Console.ReadLine();
                extra = int.Parse(input);
                //si el número ingresado es de 4 cifras se que es un alumno sino debe ser un profesor
                if (extra <= 9999)
                    misPersonas.Add(new Alumno(dni, nombre, extra));
                else
                    misPersonas.Add(new Profesor(dni, nombre, extra));
            }
            int countProfes = 0;
            int countAlumnos = 0;
            //no necesito guardar la cantidad de elementos de la lista, es una propiedad
            Console.WriteLine("Se agregaron " + misPersonas.Count + " personas: ");
            foreach(Persona P in misPersonas)
            {
                //si necesito saber cuantos son de cada tipo uso "is" si es profesor suma para profes, sino suma para alumnos
                if (P is Profesor)
                {
                    //en este punto se que es profesor así que lo asigno a la variable de este tipo para poder extrar la matrícula
                    Profesor aux = (Profesor)P;
                    Console.WriteLine(P.getDni() + " - " + P.getNombre() + " - " + aux.getMatricula());
                    countProfes++;
                }
                else
                {
                    //mismo pero para alumnos
                    Alumno aux = (Alumno)P;
                    Console.WriteLine(P.getDni() + " - " + P.getNombre() + " - " + aux.getLibreta());
                    countAlumnos++;
                }
            }
            Console.WriteLine("Cantidad de profesores: " + countProfes);
            Console.WriteLine("Cantidad de alumnos: " + countAlumnos);
            //mismo que antes pero ahora ordenado por getDni()
            Console.WriteLine("Ahora sorted by dni");
            misPersonas.Sort();
            
            //y si quiero ordenar descendente? descomentar la instrucción debajo!
            //misPersonas.Reverse();

            countProfes = 0;
            countAlumnos = 0;
            Console.WriteLine("Se agregaron " + misPersonas.Count + " personas: ");
            foreach (Persona P in misPersonas)
            {
                if (P is Profesor)
                {
                    Profesor aux = (Profesor)P;
                    Console.WriteLine(P.getDni() + " - " + P.getNombre() + " - " + aux.getMatricula());
                    countProfes++;
                }
                else
                {
                    Alumno aux = (Alumno)P;
                    Console.WriteLine(P.getDni() + " - " + P.getNombre() + " - " + aux.getLibreta());
                    countAlumnos++;
                }
            }

            Console.WriteLine("Cantidad de profesores: " + countProfes);
            Console.WriteLine("Cantidad de alumnos: " + countAlumnos);

            //para ejecutar con arreglos descomentar debajo
            ProgramArray prog2 = new ProgramArray();
            prog2.procesar();
        }
    }
}
