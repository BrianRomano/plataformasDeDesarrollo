using System;
using System.Collections.Generic;

namespace Clase3
{
    class Program
    {
        static void Main(string[] args)
        {
            // LISTA DE PERSONAS
            List<Persona> misPersonas = new List<Persona>();

            // COMPROBAR QUE LA LISTA PERSONAS NO ESTE VACIA Y QUE DNI EN LA POSICION 0 DE LA LISTA SEA 123
            if (misPersonas[0] != null & misPersonas[0].dni==123){
                Console.WriteLine("Es un alumno");
            } else {
                Console.WriteLine("Es un profesor");
            }
            
            // OBJETO ALUMNO 
            Alumno al = (Alumno) misPersonas[1];

            // ESTA BANDERA ME AVISA SI ME CARGARON UN 0 PARA SALIR DEL WHILE DE "CARGA"
            int flag = -1;

            // VARIABLES PARA GUARDAR ENTRADAS 
            string input, nombre;
            int dni, extra;

            while (flag < 0)
            {
                // GUARDAR Y LEER DATOS
                Console.WriteLine("Ingrese DNI: ");
                input = Console.ReadLine();
                dni = int.Parse(input);

                if (dni == 0)
                {
                    // SI DNI ES 0 SALGO DEL WHILE Y MUESTRO LOS DATOS CARGADOS
                    flag = 0;
                    break;
                }

                // GUARDAR Y LEER DATOS
                Console.WriteLine("Ingrese Nombre: ");
                input = Console.ReadLine();
                nombre = input;

                // GUARDAR Y LEER DATOS
                Console.WriteLine("Ingrese Matricula/libreta: ");
                input = Console.ReadLine();
                extra = int.Parse(input);

                // SI EL NUMERO INGRESADO ES DE 4 CIFRAS SE QUE ES UN ALUMNO SINO DEBE SER UN PROFESOR
                if (extra <= 9999){
                    misPersonas.Add(new Alumno(dni, nombre, extra));
                } else {
                    misPersonas.Add(new Profesor(dni, nombre, extra));
                }
            }

            // CONTADORES DE PROFESORES Y ALUMNOS
            int countProfes = 0;
            int countAlumnos = 0;

            // CON EL METODO Count PUEDO CONTAR LA CANTIDAD DE ITEMS QUE EXISTEN EN LA LISTA
            Console.WriteLine("Se agregaron " + misPersonas.Count + " personas: ");

            // ITERAR LA LISTA misPersonas
            foreach(Persona P in misPersonas)
            {
                // COMPROBAR CON is SI PERTENECE AL TIPO DE PERSONA PROFESOR
                if (P is Profesor)
                {
                    // YA QUE ES PROFESOR ASIGNO LA VARIABLE MATRICULA
                    Profesor aux = (Profesor)P;
                    Console.WriteLine(P.dni + " - " + P.nombre + " - " + aux.matricula);
                    // SUMO UN PROFESOR
                    countProfes++;
                }
                else
                {
                    // YA QUE ES ALUMNO ASIGNO LA VARIABLE LIBRETA
                    Alumno aux = (Alumno)P;
                    Console.WriteLine(P.dni + " - " + P.nombre + " - " + aux.libreta);
                    // SUMO UN ALUMNO
                    countAlumnos++;
                }
            }

            // MOSTRAR DATOS
            Console.WriteLine("Cantidad de profesores: " + countProfes);
            Console.WriteLine("Cantidad de alumnos: " + countAlumnos);
            
            // MOSTRAR DATOS ORDENADOS POR DNI
            Console.WriteLine("Ahora sorted by DNI");
            misPersonas.Sort();

            /*
            ** MOSTRAR ORDENADOS POR DNI DE MANERA DESCENDENTE
            ** misPersonas.Reverse();
            */ 

            // CONTADORES DE PROFESORES Y ALUMNOS SETEADOS A 0 NUEVAMENTE
            countProfes = 0;
            countAlumnos = 0;

            // MOSTRAR CANTIDAD DE PERSONAS QUE SE AGREGARON A LA LISTA
            Console.WriteLine("Se agregaron " + misPersonas.Count + " personas: ");

            // ITERAR LA LISTA misPersonas
            foreach (Persona P in misPersonas)
            {   
                // COMPROBAR CON is SI ES PROFESOR
                if (P is Profesor)
                {
                    // YA QUE ES PROFESOR ASIGNO LA VARIABLE MATRICULA
                    Profesor aux = (Profesor)P;
                    Console.WriteLine(P.dni + " - " + P.nombre + " - " + aux.matricula);
                    // SUMAR UN PROFESOR
                    countProfes++;
                }
                else
                {
                    // YA QUE ES ALUMNO ASIGNO LA VARIABLE LIBRETA
                    Alumno aux = (Alumno)P;
                    Console.WriteLine(P.dni + " - " + P.nombre + " - " + aux.libreta);
                    // SUMAR UN ALUMNO
                    countAlumnos++;
                }
            }

            // MOSTRAR DATOS
            Console.WriteLine("Cantidad de profesores: " + countProfes);
            Console.WriteLine("Cantidad de alumnos: " + countAlumnos);

            // PRUEBAS CON ALUMNOS
            Console.WriteLine("Antes de irme, juguemos un poco con los get y set de alumnos...");            
            foreach(Persona p in misPersonas)
            {
                if (p is Alumno)
                {
                    Alumno Al = (Alumno)p;
                    Console.WriteLine("Este alumno se llama segun get: " + Al.nombre);
                    Console.WriteLine("Este alumno se llama segun getNombre: " + Al.getNombre());
                    //le cambio el nombre con setter
                    Console.WriteLine("Le cambio el nombre con setter a mimi");
                    Al.nombre = "mimi";
                    Console.WriteLine("Este alumno se llama segun get: " + Al.nombre);
                    Console.WriteLine("Este alumno se llama segun getNombre: " + Al.getNombre());
                    //ahora le cambio el nombre con setNombre
                    Console.WriteLine("Le cambio el nombre con setNombre a yiyi");
                    Al.nombre = "yiyi";
                    Console.WriteLine("Este alumno se llama segun get: " + Al.nombre);
                    Console.WriteLine("Este alumno se llama segun getNombre: " + Al.getNombre());
                    Console.WriteLine("Parece que es lo mismo, podría usar cualquiera de los dos :)");
                }
            }
        }
    }
}
