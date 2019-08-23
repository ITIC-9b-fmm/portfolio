using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Csuma:Calculadora
    {
        private double r = 0;
        private ArrayList resultados = new ArrayList();

        //métodos a implementar

        public void Calcular(double a, double b)
        {
            r = a + b;
            this.Mostrar(r);
        }

        //métodos propios de la clase

        public void Mostrar(double r)
        {

            Console.WriteLine("El resultado de la suma es : {0}", r);
            Console.ReadKey();

            resultados.Add(r);
        }
        public void muestraResultados()
        {
            foreach
                (double r in resultados)
                Console.WriteLine(r);

        }


    }
}
