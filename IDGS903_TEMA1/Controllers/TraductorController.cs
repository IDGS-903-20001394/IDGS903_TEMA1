using IDGS903_TEMA1.Models;
using IDGS903_TEMA1.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_TEMA1.Controllers
{
    public class TraductorController : Controller
    {
        // GET: Traductor
        public ActionResult Registrar(string mostrar)
        {
            var ts = new TraductorServices();
            ViewBag.traducciones = ts.LeerTraduccion();
            ViewBag.mostrar = false;

            if(mostrar == "Mostrar")
            {
                ViewBag.mostrar = true;
            }

            return View();
        }
        [HttpPost]
        public ActionResult Registrar(Traductor trad)
        {
            var ts = new TraductorServices();

            if(trad.español != null && trad.ingles != null)
            {
            ts.GuardarTraduccion(trad);
            }
            ViewBag.traducciones = ts.LeerTraduccion();
            return View();
        }

        public ActionResult Buscar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Buscar(Traductor trad, string idioma)
        {            
            string resultado = trad.buscar(idioma);
            ViewBag.res = resultado;
            return View();
        }
    }
}