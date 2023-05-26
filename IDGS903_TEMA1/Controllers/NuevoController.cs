using IDGS903_TEMA1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace IDGS903_TEMA1.Controllers
{
    public class NuevoController : Controller
    {
        // GET: Nuevo
        public ActionResult Ventana()
        {
            return View();
        }

        public ActionResult Calculos(string n1, string n2, string operacion)
        {
            int res = 0;

            if (operacion == "sumar")
            {
                res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
            }
            else if (operacion == "restar")
            {
                res = Convert.ToInt16(n1) - Convert.ToInt16(n2);
            }
            else if (operacion == "multiplicar")
            {
                res = Convert.ToInt16(n1) * Convert.ToInt16(n2);
            }
            else if (operacion == "dividir")
            {
                res = Convert.ToInt16(n1) / Convert.ToInt16(n2);
            }

            ViewBag.Res = Convert.ToString(res);
            return View();
        }

        public ActionResult Ventana2(operasBas op)
        {
            op.realizarOp();
            var model = new operasBas();
            model.Res = op.Res;

            return View(model);
        }
    }
}