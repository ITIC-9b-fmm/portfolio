using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAnimales
{
    class Gorila : Mamiferos
    {

        public int patas;

        public void getNumeroPatas(int numPatas)
        {
            patas = numPatas;
        }

        public void MostrarPatas()
        {
            Console.WriteLine("El gorila tiene {0} patas",patas);
        }

        public void HacerNada()
        {
            Console.WriteLine("Haciendo nada...");
            Console.WriteLine("");
        }
    }
}
