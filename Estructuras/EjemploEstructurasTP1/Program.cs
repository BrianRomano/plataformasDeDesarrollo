using System;

namespace EjemploEstructurasTP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mercado m = new Mercado();
            m.agregarProd("TV");
            m.agregarProd("Notebook");
            m.agregarProd("Mouse");
            m.agregarProd("Teclado");
            m.agregarProd("DVD");
            m.agregarProd("Play");
            m.agregarProd("Monitor");
            m.agregarProd("Equipo de música");
            m.agregarProd("Aire acondicionado");
            m.agregarProd("Mueble");

            string input = "";
            while (!input.Equals("0"))
            {
                Console.WriteLine("Elija una opción, 0 para salir:");
                Console.WriteLine("1) Mostrar Productos");
                Console.WriteLine("2) Agregar Producto");
                Console.WriteLine("3) Modificar Producto");
                Console.WriteLine("4) Eliminar Producto");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        m.mostrarProds();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese un nombre: ");
                        if (m.agregarProd(Console.ReadLine()))
                            Console.WriteLine("OK");
                        else
                            Console.WriteLine("Error");
                        break;
                    case "3":
                        Console.WriteLine("Ingrese un NUEVO nombre para el producto: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Ingrese ID a modificar: ");
                        int idx;
                        if (!int.TryParse(Console.ReadLine(), out idx) || !m.modificarProd(idx, name))
                            Console.WriteLine("Error");
                        else
                            Console.WriteLine("OK");
                        break;
                    case "4":
                        Console.WriteLine("Ingrese ID a eliminar: ");
                        int idy;
                        if (!int.TryParse(Console.ReadLine(), out idy) || !m.eliminarProd(idy))
                            Console.WriteLine("Error");
                        else
                            Console.WriteLine("OK");
                        break;
                    default:
                        break;
                }


            }
        }
    }
}
