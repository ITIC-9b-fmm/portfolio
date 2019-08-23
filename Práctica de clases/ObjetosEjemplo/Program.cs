using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleadoscls empleado;//Se crea el objeto de la clase Empleadoscls
            empleado = new Empleadoscls();/*Instanciar el objeto empleado, primero se pone el nombre
            del objeto, seguido el signo igual, posteriormente new y por último el nombre
            del constructor*/

            empleado.Nombre = "John";
            empleado.Edad = 25;
            empleado.SueldoDiario = 15;
            //Se le asignan los valores al objeto empleado de la clase Empleadoscls

            int total;
            total = empleado.CalculaSalario(30);/*A la variable total, se le asigna el valor
            del resultado correspondiente a la función CalculaSalario, mandandole un número
            como parámetros, los cuales corresponden a los días*/

            Console.WriteLine("El salario de " + empleado.Nombre + " durante 30 días,");
            Console.WriteLine("fue de $" + total);
            Console.ReadKey();

        }
    }
}
