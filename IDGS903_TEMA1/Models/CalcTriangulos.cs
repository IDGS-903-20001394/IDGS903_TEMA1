using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_TEMA1.Models
{
    public class CalcTriangulos
    {
        public double x1 { get; set; }
        public double y1 { get; set; }
        public double x2 { get; set; }
        public double y2 { get; set; }
        public double x3 { get; set; }
        public double y3 { get; set; }

        public double lado1 { get; set; }
        public double lado2 { get; set; }
        public double lado3 { get; set; }

        public bool isTriangulo { get; set; }

        public string nombreT { get; set; }
        public double area { get; set; }
       

        public void Calcular()
        {
            calcularLados();
            obtenerTriangulo();
            obtenerArea();
        }

        public void calcularLados()
        {
            double r1 = Math.Pow((this.x2 - this.x1), 2) + Math.Pow((this.y2 - this.y1), 2);
            this.lado1 = Math.Round(Math.Sqrt(r1));

            double r2 = Math.Pow((this.x3 - this.x1), 2) + Math.Pow((this.y3 - this.y1), 2);
            this.lado2 = Math.Round(Math.Sqrt(r2));

            double r3 = Math.Pow((this.x3 - this.x2), 2) + Math.Pow((this.y3 - this.y2), 2);
            this.lado3 = Math.Round(Math.Sqrt(r3));

        }

        public void obtenerTriangulo()
        {
            if(this.lado1 == this.lado2 && this.lado2 == this.lado3)
            {
                this.nombreT = "Equilatero";
            } else if(this.lado1 == this.lado2 || this.lado2 == this.lado3 || this.lado1 == this.lado3)
                {
                    this.nombreT = "Isóceles";
                }
                else
                {
                    this.nombreT = "Escaleno";
                }

            if ((this.lado1 + this.lado2 > this.lado3) && (this.lado2 + this.lado3) > this.lado1 && (this.lado1 + this.lado3 > this.lado2))
            { 
                this.isTriangulo = true;
            }
            else
            {
                this.isTriangulo = false;
            }
        }

        public void obtenerArea()
        {
            double Base;
            double Altura;

            if (this.isTriangulo)
            {
                if (this.nombreT == "Equilatero")
                {
                    Base = this.lado2;
                    Altura = Math.Sqrt(Math.Pow(this.lado1, 2) - Math.Pow(Base/2, 2));
                    this.area = Math.Round(((Base * Altura) / 2), 2);
                }else if(this.nombreT == "Isóceles")
                {
                    if(this.lado1 == this.lado2)
                    {
                        Base = lado3;
                        Altura = Math.Sqrt(Math.Pow(this.lado1, 2) - Math.Pow(Base / 2, 2));
                        this.area = Math.Round(((Base * Altura) / 2), 2);
                    }
                    else if(this.lado1 == this.lado3)
                    {
                        Base = lado2;
                        Altura = Math.Sqrt(Math.Pow(this.lado1, 2) - Math.Pow(Base / 2, 2));
                        this.area = Math.Round(((Base * Altura) / 2), 2);
                    }
                    else
                    {
                        Base = this.lado1;
                        Altura = Math.Sqrt(Math.Pow(this.lado2, 2) - Math.Pow(Base / 2, 2));
                        this.area = Math.Round(((Base * Altura) / 2), 2);
                    }
                }else
                {
                    double s = ((this.lado1 + this.lado2 + this.lado3) / 2);
                    this.area = Math.Round(Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3)), 2);
                }
            }
        }
    }  
}