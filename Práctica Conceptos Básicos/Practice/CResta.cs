using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class CResta:Calculadora
    {
        private double r = 0;
        public void Calcular(double a, double b)
        {
            r = a - b;
            this.Mostrar(r);
        }
        public void Mostrar(double r)
        {

            Console.WriteLine("El resultado de la resta es : {0}", r);
            Console.ReadKey();

        }
    }
}
