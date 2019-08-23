using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAnimales
{
    class Humano : Mamiferos
    {

        public int patas;

        public void getNumeroPatas(int numPatas)
        {
            patas = numPatas;
        }

        public void MostrarPatas()
        {
            Console.WriteLine("El humano tiene {0} patas, porque tiene pies y brazos",patas);
        }

        public void Razonar()
        {
            Console.WriteLine("Está razonando");
            Console.WriteLine("");
        }
    }
}
