using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAnimales
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se ha creado una clase Dios, para que se encargue de la creación de
             todos lo objetos y desde el método Main, ejecutamos el método "Crear" 
             de la clase Dios*/
            Dios Florentino = new Dios();
            Florentino.Crear();

        }
    }
}
