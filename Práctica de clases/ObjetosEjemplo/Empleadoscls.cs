using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosEjemplo
{
    public class Empleadoscls
    {
        public Empleadoscls()
        {
            Nombre = "";
            SueldoDiario = 0;
            Edad = 0;
        }/*Se inicializan los valores de la clase*/

        public string Nombre;
        public int SueldoDiario;
        public int Edad;

        public int CalculaSalario(int NumeroDias)
        {
            int CalculoTotal;
            CalculoTotal = SueldoDiario * NumeroDias;
            return CalculoTotal;
        }/*Esta función calcula el sueldo de acuerdo al número
        de días que haya trabajado el empleado */
    }
}
