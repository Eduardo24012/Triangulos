using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsTriangulo miTriangulo = new clsTriangulo();

            int opcion = 1;
            do
            {
                switch(opcion)
                {
                    case 1:

                        Console.WriteLine("TIPOS DE TRIANGULOS");
                        Console.WriteLine("registra el lado A del triangulo");
                        miTriangulo.setLadoA(float.Parse(Console.ReadLine()));
                        Console.WriteLine("Registra el lado B de triangulo");
                        miTriangulo.setLadoB(float.Parse(Console.ReadLine()));
                        Console.WriteLine("Registra el lado C del triangulo");
                        miTriangulo.setLadoC(float.Parse(Console.ReadLine()));
                        Console.WriteLine("El perimetro del triangulo es: " + miTriangulo.Perimetro() + " m");
                        Console.WriteLine("El area del triangulo es: " + miTriangulo.Area() + " m2");
                        Console.WriteLine("EL TIPO DE TRIÁNGULO ES UN: " + miTriangulo.TipoTriangulo());
                        Console.WriteLine();
                        break;
                        
                }

            }while(opcion != 2);
        }
    }
}
