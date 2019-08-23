using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAnimales
{
    class Dios
    {
        //Un método "Crear" manda a llamar a cada método que crea a cada objeto
        public void Crear()
        {
            CrearHumano();
            CrearCaballo();
            CrearGorila();
            CrearBallena();
            CrearLagartija();
        }


        //Los siguientes métodos, crear un objeto de la clase Humano, Ballena, Caballo, Gorila y Lagartija
        public void CrearHumano()
        {
            Humano Adan = new Humano();
            Adan.getNombre("Adán");
            Adan.Mostrar();
            Adan.getNumeroPatas(0);
            Adan.MostrarPatas();
            Adan.Respirar();
            Adan.Pensar();
            Adan.Razonar();
        }

        public void CrearCaballo()
        {
            Caballo spirit = new Caballo();
            spirit.getNombre("Spirit, el caballo indomable");
            spirit.Mostrar();
            spirit.getNumeroPatas(4);
            spirit.MostrarPatas();
            spirit.Respirar();
            spirit.Pensar();
            spirit.CuidarCrias();
            spirit.Cabalgar();
        }

        public void CrearGorila()
        {
            Gorila x = new Gorila();
            x.getNombre("Barney");
            x.Mostrar();
            x.getNumeroPatas(2);
            x.MostrarPatas();
            x.Respirar();
            x.Pensar();
            x.CuidarCrias();
            x.HacerNada();
        }

        public void CrearBallena()
        {
            Ballena y = new Ballena();
            y.getNombre("Tiny");
            y.Mostrar();
            y.MostrarPartes();
            y.Respirar();
            y.Pensar();
            y.CuidarCrias();
            y.Nadar();
            
        }

        public void CrearLagartija()
        {
            Lagartija rango = new Lagartija();
            rango.getNombre("Rango");
            rango.Mostrar();
            rango.getNumeroPatas(4);
            rango.MostrarPatas();
            rango.Respirar();
            rango.PonerHuevos();
            rango.Arrastrarse();
        }
    }
}
