using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAnimales
{
    class Caballo : Mamiferos
    {
        /*Cada Clase tiene  métodos propios de su clase, aunque heredan los métodos
         de su clase madre llamada Mamiferos*/


        //Obtenemos el número de patas de cada clase
        public int patas;
        public void getNumeroPatas(int numPatas)
        {
            patas = numPatas;
        }

        public void MostrarPatas()
        {
            Console.WriteLine("El caballo tiene {0} patas",patas);
        }

        //Método único de Caballo
        public void Cabalgar()
        {
            Console.WriteLine("Cabalgando");
            Console.WriteLine("");
        }
    }
}
