using IDGS903_TEMA1.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_TEMA1.Models
{
    public class Traductor
    {
        public string ingles { get; set; }
        public string español { get; set; }
        public string busqueda { get; set; }

        public string buscar(string idioma)
        {
            var ts = new TraductorServices();
            Array traducciones = ts.LeerTraduccion();
            string resultado = "No se encontró la traducción";

            if (idioma == "Ing")
            {
                foreach (string item in traducciones)
                {
                    if (this.busqueda.ToUpper() == item.Split(',')[1])
                    {
                        resultado = item.Split(',')[0];
                    }
                }
            }
            else if (idioma == "Esp")
            {
                foreach (string item in traducciones)
                {
                    if (this.busqueda.ToUpper() == item.Split(',')[0])
                    {
                        resultado = item.Split(',')[1];
                    }
                }
            }

            return resultado;
        }
    }
}