using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    internal class clsTriangulo
    {
        //Atributos
        protected float LadoA;
        protected float LadoB;
        protected float LadoC;

        //Constructor
        public clsTriangulo()
        {
            LadoA = 0;
            LadoB = 0;
            LadoC = 0;
        }
        //Propiedades
        public float getLadoA()
        {
            return LadoA;
        }
        public void setLadoA(float valor)
        {
            LadoA = valor;
        }
        public float getLadoB()
        {
            return LadoB;
        }
        public void setLadoB(float valor)
        {
            LadoB = valor;
        }
        public float getLadoC()
        {
            return LadoC;
        }
        public void setLadoC(float valor)
        {
            LadoC = valor;
        }
        //Metodos
        public float Perimetro()
        {
            float res = 0;
            res= LadoA+LadoB+LadoC;
            return res;
        }
        public float Area()
        {
            float res = 0, result = 0;
            float S;
            S = Perimetro()/2;
            result = S * (S - LadoA) * (S - LadoB) * (S - LadoC);
            res = (float)Math.Sqrt(result);
            return res;

        }
        public string TipoTriangulo()
        {
            if (LadoA == LadoB && LadoB == LadoC)
            {
                return "TRIÁNGULO EQUILÁTERO";
            }
            else if (LadoA == LadoB || LadoA == LadoC || LadoB == LadoC)
            {
                return "TRIÁNGULO ISÓSCELES";
            }
            else
                return "TRIÁNGULO ESCALENO";
        }
    }
}
