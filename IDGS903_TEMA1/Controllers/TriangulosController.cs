using IDGS903_TEMA1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_TEMA1.Controllers
{
    public class TriangulosController : Controller
    {
        // GET: Triangulos
        public ActionResult Index()
        {
            ViewBag.isCalculated = false;
            return View();
        }
        [HttpPost]
        public ActionResult Index(CalcTriangulos ctrl) {

            ctrl.Calcular();
            ViewBag.isCalculated = true;
            return View(ctrl);
        }
    }
}