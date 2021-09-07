using System;
using System.Collections.Generic;

namespace EjemploDIC
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARAR DICCIONARIO PRUEBA
            Dictionary<string, int> prueba = new Dictionary<string, int>(); 

            // AGREGAR DATOS AL DICCIONARIO
            prueba.Add("uno", 1);
            prueba.Add("dos", 2);

            // MOSTRAR POSICION 1 DEL DICCIONARIO
            Console.WriteLine("Con clave uno: " + prueba["uno"]);

            // CAMBIAR EL VALOR DE LA POSICION "UNO" A 3
            prueba["uno"] = 3;

            // ITERAR EL DICCIONARIO PRUEBA
            foreach (KeyValuePair<string, int> kvp in prueba)
            {
                /* KEY = STRING
                ** VALUE = INT   
                */    
                Console.WriteLine("Key = "+ kvp.Key+", Value = "+ kvp.Value);
            }

            // ITERAR KEYS DEL DICCIONARIO PRUEBA
            foreach (string s in prueba.Keys)
            {
                Console.WriteLine("valor=" + prueba[s]);
            }
            
            // COMPROBAR CON EL METODO ConstainsKey SI LA KEY "UNO" EXISTE EN EL DICCIONARIO PRUEBA
            if (!prueba.ContainsKey("uno")){
                // SI NO EXISTE SE AGREGA AL DICCIONARIO
                prueba.Add("uno", 1);
            } else {
                // SI YA EXISTE, NO AGREGA NADA Y MUESTRA UN MENSAJE DE ERROR
                Console.WriteLine("no puedo, ya existe");
            }
        }
    }
}
