using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAnimales
{
    class Lagartija : Animales
    {
        /*La clase Lagartija, no hereda nada de la clase Mamifero por lo que es independiente*/
        private int patas;
        private string namae;

        public override void getNombre(string nombre)
        {
            namae = nombre;
        }

        public void Mostrar()
        {
            Console.WriteLine("El nombre de la lagartija es: {0}",namae);
        }
        

        public void getNumeroPatas(int numPatas)
        {
            patas = numPatas;
        }

        public void MostrarPatas()
        {
            Console.WriteLine("La lagartija tiene {0} patas",patas);
        }

        public void PonerHuevos()
        {
            Console.WriteLine("Pone huevos...");
        }

        public void Arrastrarse()
        {
            Console.WriteLine("Arrastrándose...");
            Console.ReadKey();
        }
    }
}
