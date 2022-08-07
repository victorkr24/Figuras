using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
     public class Cuadrado
    {
        
        public static void CalcularArea()
        {
            double  area, lado;
            Console.WriteLine("Ingrese el lado  del cuadrado ");
            lado = double.Parse(Console.ReadLine());
            area =  lado * lado;

            Console.WriteLine("El area del cuadrado es : "+ area);

        }

        public static void CalcularPerimetro()
        {
            double perimetro;
            Console.WriteLine("Ingrese el lado del cuadrado");
            double lado = double.Parse(Console.ReadLine());

            perimetro = lado + lado + lado + lado;
            Console.WriteLine("El perimetro del cuadrado es : " + perimetro);


        }
    }
}
