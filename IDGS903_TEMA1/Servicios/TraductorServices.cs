using IDGS903_TEMA1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS903_TEMA1.Servicios
{
    public class TraductorServices
    {
        public void GuardarTraduccion(Traductor trd)
        {
            var ing = trd.ingles.ToUpper();
            var esp = trd.español.ToUpper();
 
            var datos = ing+','+esp+Environment.NewLine;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/traductor.txt");

            File.AppendAllText(archivo, datos);
        }

        public Array LeerTraduccion()
        {
            Array tradData = null;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/traductor.txt");

            if (File.Exists(archivo))
            {
                tradData = File.ReadAllLines(archivo);
            }

            return tradData;
        }
    }
}