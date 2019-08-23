using BasicMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /*Se crea una lista y se instancían 4 coches dándoles sus atributos 
            correspondientes. Esta parte es la del Controlador*/
            var coches = new List<Coche>
            {
                new Coche {Marca="BMW",Modelo="X6",Color="Gris"},
                new Coche {Marca="Mercedes",Modelo="A200",Color="Blanco"},
                new Coche {Marca="Porsche",Modelo="Cayanne",Color="Azul"},
                new Coche {Marca="Ford",Modelo="Mustang",Color="Rojo"}
            };

            return View(coches);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}