using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploEstructurasTP1
{
    class Mercado
    {
        private List<Producto> misProd;
        public Mercado()
        {
            misProd = new List<Producto>();
        }
        public bool agregarProd(string nombre)
        {
            misProd.Add(new Producto(misProd.Count,nombre));
            return true;
        }
        public bool modificarProd(int id, string nombre)
        {
            if (misProd[id] != null)
            {
                misProd[id].nombre = nombre;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool eliminarProd(int id)
        {
            if (misProd.Count > id && misProd[id] != null)
            {
                misProd[id] = null;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void mostrarProds()
        {
            foreach (Producto p in misProd)
                if(p!=null)
                    Console.WriteLine(p);
        }

    }
}
