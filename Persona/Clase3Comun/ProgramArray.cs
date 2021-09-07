using System;
using System.Collections.Generic;
using System.Text;

namespace Clase3Comun
{
    class ProgramArray
    {
        public ProgramArray()
        {

        }
        public void procesar()
        {
            //creo una lista de personas
            Persona[] misPersonas = new Persona[5];
            //necesito guardarme la cantidad de elementos
            int cantidad = 0;
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
                //NOTAR que al agregar uso la cantidad que es mi puntero a la última posición
                if (extra <= 9999)
                    misPersonas[cantidad]=new Alumno(dni, nombre, extra);
                else
                    misPersonas[cantidad]=new Profesor(dni, nombre, extra);
                //no debo olvidar actualizar la cantidad de elementos
                cantidad++;
            }
            int countProfes = 0;
            int countAlumnos = 0;
            //necesito guardar la cantidad de elementos en el array, la propiedad Length NO ES CORRECTA ya que me indica la cantidad de casilleros no de elementos
            Console.WriteLine("Se agregaron " + misPersonas.Length + " personas: ");
            Console.WriteLine("Se agregaron " + cantidad + " personas: ");
            //¿PUEDO USAR UN FOREACH? ¿Que control debo hacer?
            foreach (Persona P in misPersonas)
            {
                //TENGO QUE VALIDAR QUE NO SEA NULL porque recorro todo el array
                if (P != null)
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
            }
            Console.WriteLine("Cantidad de profesores: " + countProfes);
            Console.WriteLine("Cantidad de alumnos: " + countAlumnos);

            //Notar que los arreglos no tienen un método SORT, debemos ordenar a mano...
            //¿QUÉ PASA SI USO UN FOR HASTA Cantidad? ¿Sería lo mismo si uso i<misPersonas.Length?
            countProfes = 0;
            countAlumnos = 0;
            Console.WriteLine("Se agregaron " + misPersonas.Length + " personas: ");
            Console.WriteLine("Se agregaron " + cantidad + " personas: ");
            for (int i = 0; i<cantidad;i++)
            {
                if (misPersonas[i] is Profesor)
                {
                    Profesor aux = (Profesor)misPersonas[i];
                    Console.WriteLine(aux.getDni() + " - " + aux.getNombre() + " - " + aux.getMatricula());
                    countProfes++;
                }
                else
                {
                    Alumno aux = (Alumno)misPersonas[i];
                    Console.WriteLine(aux.getDni() + " - " + aux.getNombre() + " - " + aux.getLibreta());
                    countAlumnos++;
                }
            }
        }
    }
    
}
