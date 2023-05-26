﻿using IDGS903_TEMA1.Models;
using IDGS903_TEMA1.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_TEMA1.Controllers
{
    public class ArchivosController : Controller
    {
        // GET: Archivos
        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Maestros maes)
        {
            var op = new GuardaService();
            op.GuardarArchivo(maes);
            return View();
        }

        public ActionResult LeerDatos()
        {
            var maes = new LeerService();
            ViewBag.Maestros = maes.LeerArchivo();
            return View();
        }
    }
}