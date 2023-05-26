using IDGS903_TEMA1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_TEMA1.Controllers
{
    public class D2PController : Controller
    {
        // GET: D2P
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resultado(D2P puntos)
        {   
            puntos.Calcular();


            return View(puntos);
        }
    }
}