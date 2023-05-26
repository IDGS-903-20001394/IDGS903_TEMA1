using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_TEMA1.Models
{
    public class operasBas
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Res { get; set; }

        public String operacion { get; set; }

        public void Sumar()
        {
            this.Res = this.Num1 + this.Num2;
        }

        public void Restar()
        {
            this.Res = this.Num1 - this.Num2;
        }

        public void Multiplicar()
        {
            this.Res = (this.Num1 * this.Num2);
        }
        public void Dividir()
        {
            this.Res = ((this.Num1 / this.Num2));
        }

        public void realizarOp()
        {
            if (this.operacion == "sumar")
            {
                Sumar();
            }
            else if (this.operacion == "restar")
            {
                Restar();
            }
            else if (this.operacion == "multiplicar")
            {
                Multiplicar();
            }
            else if (this.operacion == "dividir")
            {
                Dividir();
            }
        }

    }
}