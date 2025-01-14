﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_PlataformasDeDesarrollo
{
    class Compra : IComparable<Compra>
    {
        private int IDCompra;
        private Usuario Comprador;
        public Dictionary<Producto, int> Productos = new Dictionary<Producto, int>();
        private double Total;

        public Compra() { }

        public Compra(int ID, Usuario Comprador,Dictionary<Producto, int> Producto, double Total)
        {
            nIDCompra = ID;
            nComprador = Comprador;
            foreach (KeyValuePair<Producto, int> kvp in Producto)
            {
                nProductos.Add(kvp.Key, kvp.Value);
            }
            nTotal = Total;


        }

        public int nIDCompra
        {
            get { return IDCompra; }
            set { IDCompra = value; }
        }

        public Usuario nComprador
        {
            get { return Comprador; }
            set { Comprador = value; }
        }

        public Dictionary<Producto, int> nProductos
        {
            get { return Productos; }
            set { Productos = value;}
        }

        public void Agregar(Producto key, int value)
        {
                nProductos.Add(key, value);
        }

        public double nTotal
        {
            get { return Total; }
            set { Total = value; }
        }

        public int CompareTo(Compra otro)
        {
            return nIDCompra.CompareTo(otro.nIDCompra);
        }

        public override string ToString()
        {

            string leer = "";
            foreach (KeyValuePair<Producto, int> kvp in Productos)
            {
                leer += "Key = " + kvp.Key + ", Value = " + kvp.Value + "\n";
            }

            return nIDCompra + "-" + nComprador + "-" + nTotal + "-" + leer;

        }
    }
}
