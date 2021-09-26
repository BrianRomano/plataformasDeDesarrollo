using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploEstructurasTP1
{
    class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Producto(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public override string ToString()
        {
            return "ID: " + id + " nombre: " + nombre;
        }

        
    }
}
