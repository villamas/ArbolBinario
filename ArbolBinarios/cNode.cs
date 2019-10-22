using System;
using System.Diagnostics;

namespace ArbolBinarios
{
    public class cNode
    {
        private int dato;
        private cNode izq;
        private cNode der;

        public int Dato { get => dato; set => dato = value; }
       // internal cNode Izq { get => izq; set => izq = value; }
        internal cNode Der { get => der; set => der = value; }

        internal cNode Izq { get; set; }

        public cNode()
        {
            dato = 0;
            izq = null;
            der = null;
        }
    }
}
