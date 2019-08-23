using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAnimales
{
    abstract class Animales
    {
        public void Respirar()
        {
            Console.WriteLine("Está respirando");
        }

        public abstract void getNombre(string nombre);
    }
}
