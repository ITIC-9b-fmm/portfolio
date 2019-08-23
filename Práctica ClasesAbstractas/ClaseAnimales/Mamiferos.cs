using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAnimales
{
    class Mamiferos : Animales
    {
        private string name;
        public void Pensar()
        {
            Console.WriteLine("Está pensando");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Cuida Crías");
        }

        public override void getNombre(string nombre)
        {
            name = nombre;
        }

        public void Mostrar()
        {
            Console.WriteLine("Su nombre es: {0}", name);
        }
    }
}
