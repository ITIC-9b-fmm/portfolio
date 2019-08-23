using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicMVC.Models
{
    /*Se ha creado esta clase como el modelo del patrón MVC
     Esta parte es el Módelo del patrón.*/
    public class Coche
    {
        //Se le añaden las propiedades a la clase Coche
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
    }
}