using IDGS903_TEMA1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS903_TEMA1.Servicios
{
    public class GuardaService
    {
        public void GuardarArchivo(Maestros maes)
        {
            var mat = maes.Matricula;
            var nom = maes.Nombre;
            var apa = maes.Apaterno;
            var ama = maes.Amaterno;
            var ema = maes.Email;

            var datos = mat+','+nom+","+apa+","+ama+","+ema+Environment.NewLine;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");

            File.AppendAllText(archivo, datos);
        }
    }
}