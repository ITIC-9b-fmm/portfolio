using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAnimales
{
    class Ballena : Mamiferos
    {
        int cola = 1;
        int aletas = 2;
        double largo = 25.6;


        //Métodos únicos de Ballena
        public void MostrarPartes()
        {
            Console.WriteLine("La ballena mide {0}m de largo, tiene {1} cola y {2} aletas", largo,cola,aletas);
        }

        public void Nadar()
        {
            Console.WriteLine("Está nadando...");
            Console.WriteLine("");
        }
    }
}
