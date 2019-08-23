using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Csuma s = new Csuma();
            s.Calcular(4, 6);
            CResta r = new CResta();
            r.Calcular(5,1);
            CMultiplicacion m = new CMultiplicacion();
            m.Calcular(4,8);
            cDivision d = new cDivision();
            d.Calcular(12,2);

            
        }
    }
}
