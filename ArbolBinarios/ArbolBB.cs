using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ArbolBinarios
{
    public class ArbolBB
    {
        private cNode raiz;
        private cNode trabajo;
        private int i = 0;
        public ArbolBB()
        {
            raiz = null;
        }
        internal cNode Raiz { get => raiz; set => raiz = value; }

        public cNode Insertar(int pDato, cNode pNodo)
        {
            cNode temp = null;


            //Si no hy a quien insertar entonces creamos el dnodo
            if (pNodo == null)
            {
                temp = new cNode();
                temp.Dato = pDato;

                return temp;
            }

            if (pDato < pNodo.Dato)
            {
                pNodo.Izq = Insertar(pDato, pNodo.Izq);
            }

            if (pDato > pNodo.Dato)
            {
                pNodo.Der = Insertar(pDato, pNodo.Der);
            }

            return pNodo;
        }
        /// <summary>
        /// transversa
        /// </summary>
        /// <param name="pNodo"></param>
        public void Transversa(cNode pNodo)
        {
            if (pNodo ==null)
                return;

            for (int n = 0; n < i; n++)
                           Console.Write(" ");

            Console.WriteLine(pNodo.Dato);
            //si tengo izq proceso izq
            if (pNodo.Izq!=null)
            {
               i++;
               Console.Write("I ");
                Transversa(pNodo.Izq);
                i--;

            }

            //si tengo dere proceso dere
            if (pNodo.Der != null)
            {
                i++;
                Console.Write("D ");
                Transversa(pNodo.Der);
                i--;

            }

        }

        public int EncuentraMinimo(cNode pNodo)
        {
            if (pNodo == null)
                return 0;

            trabajo = pNodo;

            int minimo = trabajo.Dato;

            while (trabajo.Izq != null)
            {
                trabajo = trabajo.Izq;
                minimo = trabajo.Dato;
            }
            return minimo;

        }

        public int EncuentraMaximo(cNode pNodo)
        {
            if (pNodo == null)
                return 0;

            trabajo = pNodo;

            int maximo = trabajo.Dato;

            while (trabajo.Der != null)
            {
                trabajo = trabajo.Der;
                maximo = trabajo.Dato;
            }
            return maximo;

        }

        public cNode EncuentraNodoMinimo(cNode pNodo)
        {
            if (pNodo == null)
                return null;

            trabajo = pNodo;

            int minimo = trabajo.Dato;

            while (trabajo.Izq != null)
            {
                trabajo = trabajo.Izq;
                minimo = trabajo.Dato;
            }
            return trabajo;

        }


        public cNode EncuentraNodoMaximo(cNode pNodo)
        {
            if (pNodo == null)
                return null;

            trabajo = pNodo;

            int maximo = trabajo.Dato;

            while (trabajo.Der != null)
            {
                trabajo = trabajo.Der;
                maximo = trabajo.Dato;
            }
            return trabajo;

        }

        public void TransversaOrdenada(cNode pNodo)
        {

            if (pNodo == null)
                return;

            if (pNodo.Izq != null)
            {
                i++;
                TransversaOrdenada(pNodo.Izq);
                i--;

            }

            Console.Write("{0},", pNodo.Dato);

            //si tengo dere proceso dere
            if (pNodo.Der != null)
            {
                i++;
                  TransversaOrdenada(pNodo.Der);
                i--;

            }
        }



    }
}
