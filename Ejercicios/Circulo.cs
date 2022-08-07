using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Circulo
    {

        public static void CalcularPerimetro()
        {
            Console.WriteLine("Ingrese el valor de radio");
            double radio = double.Parse(Console.ReadLine());

            double perimetro = 2.0 * Math.PI * radio;

            Console.WriteLine("El perimetro del circulo es " + perimetro);
        }

        public static void CalcularArea()
        {
            Console.WriteLine("Ingrese el valor de radio");
            double radio = double.Parse(Console.ReadLine());

            double area = Math.PI * radio * radio;
            Console.WriteLine("El are del ciruclo es "+ area);
        }
    }
}
