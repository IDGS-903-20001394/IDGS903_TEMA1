using IDGS903_TEMA1.Models;
using IDGS903_TEMA1.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_TEMA1.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda

        public ActionResult MuestraPulques()
        {
            var pulquesVenta = new PulqueServices();
            var model = pulquesVenta.ObtenerPulque();

            return View(model);
        }

        public ActionResult MuestraPulques2()
        {
            TempData["nombres"] = "Alejandro Gaytán";
            var pulquesVenta = new PulqueServices();
            var model = pulquesVenta.ObtenerPulque();

            return View(model);
        }

        public ActionResult Index()
        {
            var pulque1 = new Pulques()
            {
                Nombre = "puqueMango",
                Descripcion = "mango"
            };
            //return Content("Christian Muñoz ASP.NET");
            //return View();
            return Json(pulque1, JsonRequestBehavior.AllowGet);
        }

        /*
        public RedirectResult Vista()
        {
            return Redirect("https://google.com.mx");
        }
        */

        public ActionResult Vista() 
        {
            var pulque1 = new Pulques()
            {
                Nombre = "puqueMango",
                Descripcion = "Mango",
                Litros = 23,
                Caducidad = new DateTime(2023, 11, 3)
            };

            ViewBag.pulques = pulque1;

            return View();
        }
        public ActionResult Vista2()
        {
            ViewBag.saludo = "Hola mundo";
            ViewBag.fecha = new DateTime(2023, 11, 2);
            ViewData["Nombre"] = "Christian";

            string nombre = "";
            if(TempData.ContainsKey("nombres"))
            {
                nombre = TempData["nombres"] as String;
            }
            ViewBag.nombreNuevo = nombre;

            return View();
        }
    }
}